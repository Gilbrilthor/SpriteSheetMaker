using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace SpriteSheetMaker
{
    public partial class spriteSheetForm : Form
    {
        public spriteSheetForm()
        {
            InitializeComponent();

            // Initialize the timer to 24 fps
            animationIntervalTimer = new System.Timers.Timer(1000.0 / (double)intervalNumberPicker.Value);
            animationIntervalTimer.Elapsed += new System.Timers.ElapsedEventHandler(OnFrameIntervalEvent);
        }

        System.Timers.Timer animationIntervalTimer;

        private void openButton_Click(object sender, EventArgs e)
        {
            // Get the file name to display in the picture box
            openImagesDialog.ShowDialog();
            
            string[] filenames = openImagesDialog.FileNames;

            // Update the image list
            updateImageList(filenames);

            // Display the first picture in the picture box
            displayPicture(new ImageFile(filenames[0]));
        }

        private void updateImageList(IEnumerable<string> fileList)
        {
            // Order the list by the default string comparison
            fileList.OrderBy(s => s);

            //ObjectCollection is a view of the items. Any changes will be reflected
            ListBox.ObjectCollection items = imageListBox.Items;

            // Add any new files to the list

            foreach (string filepath in fileList)
            {
                // Create a imageFile object out of the file path.
                // This is used to keep the path information but only display the filename.
                ImageFile file = new ImageFile(filepath);

                // Make sure it doesn't already have the filename
                if (!items.Contains(file))
                {
                    items.Add(file);
                }
            }

            // Update the frame slider
            updateFrameTrackBar();
        }

        // Delegate to allow timer to update the trackbar
        delegate void UpdateFrameTrackBarCallback();

        private void updateFrameTrackBar()
        {
            // If you're not on the correct thread, refire it on the correct thread
            if (this.frameTrackBar.InvokeRequired)
            {
                UpdateFrameTrackBarCallback d = new UpdateFrameTrackBarCallback(updateFrameTrackBar);
                this.Invoke(d);
            }
            else
            {
                frameTrackBar.Maximum = imageListBox.Items.Count - 1;
                frameTrackBar.Value = currentSpriteIndex;
            }
        }

        private int currentSpriteIndex;

        private void stepAnimForward()
        {
            // Increment the current index, and then make it wrap around
            currentSpriteIndex = ++currentSpriteIndex % imageListBox.Items.Count;

            // Get the new image that it's pointing to
            ImageFile file = (ImageFile) imageListBox.Items[currentSpriteIndex];

            // display the picture in the pic box
            displayPicture(file);

            // Update the track bar
            updateFrameTrackBar();
        }

        private void stepAnimBackward()
        {
            // Decrement the current index, and then make it wrap around
            if (--currentSpriteIndex < 0)
            {
                currentSpriteIndex = imageListBox.Items.Count - 1;
            }

            // Get the new image that it's pointing to
            ImageFile file = (ImageFile) imageListBox.Items[currentSpriteIndex];

            // display the picture in the pic box
            displayPicture(file);

            // Update the track bar
            updateFrameTrackBar();
        }

        private void playAnimation()
        {
            animationIntervalTimer.Enabled = true;
            isPlaying = true;
        }

        private void pauseAnimation()
        {
            animationIntervalTimer.Enabled = false;
            isPlaying = false;
        }

        bool isPlaying;

        private void togglePlaying()
        {
            isPlaying = !isPlaying;
            animationIntervalTimer.Enabled = isPlaying;
        }

        private void displayPicture(ImageFile file)
        {

            // If there was an old pic, dispose of it
            if (spritePictureBox.Image != null)
            {
                spritePictureBox.Image.Dispose();
            }

            // Convert it back to an image for the pic box
            spritePictureBox.Image = Bitmap.FromFile(file.Path);
        }
        
        private void updateFPSTiming(int framesPerSecond)
        {
            // Set the interval to the new frames per second
            // 1000 milliseconds / framesPerSecond = millisecondsPerFrame
            animationIntervalTimer.Interval = 1000.0 / framesPerSecond;
        }

        private void OnFrameIntervalEvent(object source, System.Timers.ElapsedEventArgs e)
        {
            stepAnimForward();
        }

        private class ImageFile : IComparable<ImageFile>, IEquatable<ImageFile>
        {
            public string Path { get; private set; }
            public string Filename { get; private set; }

            public ImageFile(string filepath)
            {
                Path = filepath;
                Filename = System.IO.Path.GetFileName(filepath);
            }

            public override string ToString()
            {
                return Filename;
            }

            public int CompareTo(ImageFile other)
            {
                return Path.CompareTo(other.Path);
            }

            public bool Equals(ImageFile other)
            {
                return Path.Equals(other.Path);
            }
        }

        private void stepForwardButton_Click(object sender, EventArgs e)
        {
            stepAnimForward();
        }

        private void stepBackButton_Click(object sender, EventArgs e)
        {
            stepAnimBackward();
        }

        private void frameTrackBar_Scroll(object sender, EventArgs e)
        {
            // Set the current index to the new value and then display the frame
            currentSpriteIndex = frameTrackBar.Value;
            displayPicture((ImageFile)imageListBox.Items[currentSpriteIndex]);
        }

        private void playPauseButton_Click(object sender, EventArgs e)
        {
            togglePlaying();

            // Set the text on the playPause button
            playPauseButton.Text = isPlaying ? "Pause" : "Play";
        }

        private void intervalNumberPicker_ValueChanged(object sender, EventArgs e)
        {
            updateFPSTiming((int)intervalNumberPicker.Value);
        }
    }
}

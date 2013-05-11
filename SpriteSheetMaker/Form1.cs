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

            animationStyle = AnimationStyle.Looping;
            animationDirection = AnimationDirection.Forward;

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

        enum AnimationDirection
        {
            Forward = 1,
            Backward = -1
        }

        AnimationDirection animationDirection;

        private void stepAnimForward()
        {
            // Increment the current index, and then make it wrap around
            //currentSpriteIndex = ++currentSpriteIndex % imageListBox.Items.Count;
            currentSpriteIndex += (int)animationDirection;

            // If the index is going to go out of bounds, fix it
            if (currentSpriteIndex < 0 || currentSpriteIndex > imageListBox.Items.Count - 1)
            {
                switch (animationStyle)
                {
                    case AnimationStyle.Looping:
                        currentSpriteIndex = 0;
                        break;
                    case AnimationStyle.PingPong:
                        switch (animationDirection)
                        {
                            case AnimationDirection.Forward:
                                animationDirection = AnimationDirection.Backward;
                                break;
                            case AnimationDirection.Backward:
                                animationDirection = AnimationDirection.Forward;
                                break;
                            default:
                                break;
                        }

                        // Advance the index in the correct direction to avoid an indexing error
                        // Advance by 2 to keep the the last frame from being repeated
                        currentSpriteIndex += (int)animationDirection * 2;
                        break;
                    default:
                        break;
                }
            }

            // Get the new image that it's pointing to
            ImageFile file = (ImageFile)imageListBox.Items[currentSpriteIndex];

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

        Color frameColor;

        private void pickColorFromChooser()
        {
            colorPicker.Color = frameColorPreviewPanel.BackColor;
            if (colorPicker.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                frameColor = colorPicker.Color;
                frameColorPreviewPanel.BackColor = frameColor;
            }
        }

        enum SpriteSheetDirection
        {
            Horizontal,
            Vertical
        }

        private void makeSpriteSheet(SpriteSheetDirection direction, int pixelBuffer, Color bufferColor, string filename, IList<ImageFile> frames)
        {
            // Create an array of images representing the frames and fill it with them
            Image[] frameArray = new Image[frames.Count];
            for (int i = 0; i < frameArray.Length; i++)
			{
                frameArray[i] = Bitmap.FromFile(frames[i].Path);
			}

            // longDimension = length of all frames + pixelBuffer * (number of frames - 1)
            int longDimension = frameArray.Sum(frame => (direction == SpriteSheetDirection.Horizontal? frame.Width : frame.Height));
            longDimension += pixelBuffer * (frameArray.Length - 1);
            // Short dimension = max value of the frame's side that is opposite the direction
            int shortDimension = frameArray.Max(frame => (direction == SpriteSheetDirection.Vertical? frame.Width : frame.Height));

            // Make the bitmap
            Bitmap output = null;

            switch (direction)
            {
                case SpriteSheetDirection.Horizontal:
                    output = new Bitmap(longDimension, shortDimension);
                    break;
                case SpriteSheetDirection.Vertical:
                    output = new Bitmap(shortDimension, longDimension);
                    break;
                default:
                    break;
            }

            // Make the graphics object and clear it with the frame color
            Graphics g = Graphics.FromImage(output);
            g.Clear(bufferColor);

            int longOffset = 0;
            for (int i = 0; i < frameArray.Length; i++)
            {
                // offset for top left corner = max of the short dimension / 2 - frames short dimension / 2
                int shortOffset = shortDimension / 2 - (direction == SpriteSheetDirection.Vertical ? frameArray[i].Width : frameArray[i].Height) / 2;

                Point topLeftPoint = new Point();

                switch (direction)
                {
                    case SpriteSheetDirection.Horizontal:
                        topLeftPoint.Y = shortOffset;
                        topLeftPoint.X = longOffset;
                        break;
                    case SpriteSheetDirection.Vertical:
                        topLeftPoint.X = shortOffset;
                        topLeftPoint.Y = longOffset;
                        break;
                    default:
                        break;
                }

                g.DrawImage(frameArray[i], topLeftPoint);

                longOffset += (direction == SpriteSheetDirection.Horizontal ? frameArray[i].Width : frameArray[i].Height);
                longOffset += pixelBuffer;
            }

            // Save the bitmap to the file specified
            output.Save(filename);

            // Create an info file to accompany the bitmap
            makeInfoFile(frames, output.Size, (int)intervalNumberPicker.Value, animationStyle, filename, bufferColor, pixelBuffer);

            // Clean up the stuff left over
            for (int i = 0; i < frameArray.Length; i++)
            {
                frameArray[i].Dispose();
            }

            g.Dispose();
            output.Dispose();
        }

        private void makeInfoFile(IList<ImageFile> frames, Size imageSize,
            int framesPerSecond, AnimationStyle animationStyle, string filename,
            Color pixelBufferColor, int pixelBufferSize)
        {
            List<string> fileLines = new List<string>();

            string imageFileName = System.IO.Path.GetFileName(filename);

            fileLines.Add(String.Format("File Name: {0}", imageFileName));
            fileLines.Add(String.Format("File Dimensions: {0}", imageSize));
            fileLines.Add(String.Format("Number of frames: {0}", frames.Count));
            fileLines.Add(String.Format("Pixel Buffer Size: {0}", pixelBufferSize));
            fileLines.Add(String.Format("Pixel Buffer Color: {0}", pixelBufferColor.Name));

            fileLines.Add(String.Format("Animation Type: {0}", System.Enum.GetName(typeof(AnimationStyle), animationStyle)));
            fileLines.Add(String.Format("Frames per second: {0}", framesPerSecond));
            fileLines.Add(String.Format("Duration of frame in milliseconds: {0}", 1000 / framesPerSecond));
            fileLines.Add(string.Empty);
            fileLines.Add("List of frame filenames:");

            int frameNumber = 1;
            foreach (ImageFile file in frames)
            {
                fileLines.Add(String.Format("{0,3}: {1}", frameNumber++, file.Filename));
            }

            fileLines.Add(string.Empty);
            fileLines.Add(String.Format("Created on: {0}", DateTime.Now.ToString()));

            string textFilePath = System.IO.Path.ChangeExtension(filename, ".txt");
            File.WriteAllLines(textFilePath, fileLines);
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

        enum AnimationStyle
        {
            Looping,
            PingPong
        }

        private AnimationStyle animationStyle;

        private void animationRButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = (RadioButton)sender;

            switch (rb.Name)
            {
                case "animationLoopRButton":
                    animationStyle = AnimationStyle.Looping;
                    animationDirection = AnimationDirection.Forward;
                    break;
                case "animationPingPongRButton":
                    animationStyle = AnimationStyle.PingPong;
                    break;
                default:
                    break;
            }

        }

        private void pickFrameColorButton_Click(object sender, EventArgs e)
        {
            pickColorFromChooser();
        }

        private void saveSheetButton_Click(object sender, EventArgs e)
        {
            // Get the direction that they want to use
            SpriteSheetDirection direction = horizontalSheetRButton.Checked? SpriteSheetDirection.Horizontal : SpriteSheetDirection.Vertical;

            if (saveSheetDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string filename = saveSheetDialog.FileName;
                // Get the files to use and turn them into a list of ImageFiles
                List<ImageFile> files = new List<ImageFile>(imageListBox.Items.Cast<ImageFile>());
                makeSpriteSheet(direction, (int)frameBufferNumberPicker.Value, frameColor, filename, files);
            }
        }
    }
}

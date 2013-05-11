namespace SpriteSheetMaker
{
    partial class spriteSheetForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.spritePictureBox = new System.Windows.Forms.PictureBox();
            this.imageListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.saveSheetButton = new System.Windows.Forms.Button();
            this.stepForwardButton = new System.Windows.Forms.Button();
            this.playPauseButton = new System.Windows.Forms.Button();
            this.stepBackButton = new System.Windows.Forms.Button();
            this.openButton = new System.Windows.Forms.Button();
            this.openImagesDialog = new System.Windows.Forms.OpenFileDialog();
            this.colorPicker = new System.Windows.Forms.ColorDialog();
            this.saveSheetDialog = new System.Windows.Forms.SaveFileDialog();
            this.frameTrackBar = new System.Windows.Forms.TrackBar();
            this.horizontalSheetRButton = new System.Windows.Forms.RadioButton();
            this.verticalSheetRButton = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.intervalNumberPicker = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.spritePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.frameTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.intervalNumberPicker)).BeginInit();
            this.SuspendLayout();
            // 
            // spritePictureBox
            // 
            this.spritePictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.spritePictureBox.Location = new System.Drawing.Point(12, 12);
            this.spritePictureBox.Name = "spritePictureBox";
            this.spritePictureBox.Size = new System.Drawing.Size(229, 225);
            this.spritePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.spritePictureBox.TabIndex = 0;
            this.spritePictureBox.TabStop = false;
            // 
            // imageListBox
            // 
            this.imageListBox.FormattingEnabled = true;
            this.imageListBox.Location = new System.Drawing.Point(369, 261);
            this.imageListBox.Name = "imageListBox";
            this.imageListBox.Size = new System.Drawing.Size(138, 186);
            this.imageListBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(366, 243);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Images";
            // 
            // saveSheetButton
            // 
            this.saveSheetButton.Location = new System.Drawing.Point(12, 341);
            this.saveSheetButton.Name = "saveSheetButton";
            this.saveSheetButton.Size = new System.Drawing.Size(98, 23);
            this.saveSheetButton.TabIndex = 3;
            this.saveSheetButton.Text = "Save As...";
            this.saveSheetButton.UseVisualStyleBackColor = true;
            // 
            // stepForwardButton
            // 
            this.stepForwardButton.Location = new System.Drawing.Point(431, 12);
            this.stepForwardButton.Name = "stepForwardButton";
            this.stepForwardButton.Size = new System.Drawing.Size(75, 23);
            this.stepForwardButton.TabIndex = 4;
            this.stepForwardButton.Text = ">>";
            this.stepForwardButton.UseVisualStyleBackColor = true;
            this.stepForwardButton.Click += new System.EventHandler(this.stepForwardButton_Click);
            // 
            // playPauseButton
            // 
            this.playPauseButton.Location = new System.Drawing.Point(339, 12);
            this.playPauseButton.Name = "playPauseButton";
            this.playPauseButton.Size = new System.Drawing.Size(75, 23);
            this.playPauseButton.TabIndex = 5;
            this.playPauseButton.Text = "Play";
            this.playPauseButton.UseVisualStyleBackColor = true;
            this.playPauseButton.Click += new System.EventHandler(this.playPauseButton_Click);
            // 
            // stepBackButton
            // 
            this.stepBackButton.Location = new System.Drawing.Point(247, 12);
            this.stepBackButton.Name = "stepBackButton";
            this.stepBackButton.Size = new System.Drawing.Size(75, 23);
            this.stepBackButton.TabIndex = 6;
            this.stepBackButton.Text = "<<";
            this.stepBackButton.UseVisualStyleBackColor = true;
            this.stepBackButton.Click += new System.EventHandler(this.stepBackButton_Click);
            // 
            // openButton
            // 
            this.openButton.Location = new System.Drawing.Point(12, 312);
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(98, 23);
            this.openButton.TabIndex = 7;
            this.openButton.Text = "Open Images...";
            this.openButton.UseVisualStyleBackColor = true;
            this.openButton.Click += new System.EventHandler(this.openButton_Click);
            // 
            // openImagesDialog
            // 
            this.openImagesDialog.FileName = "openFileDialog1";
            this.openImagesDialog.Filter = "BMP Files|*.bmp";
            this.openImagesDialog.Multiselect = true;
            // 
            // frameTrackBar
            // 
            this.frameTrackBar.Location = new System.Drawing.Point(12, 243);
            this.frameTrackBar.Name = "frameTrackBar";
            this.frameTrackBar.Size = new System.Drawing.Size(229, 45);
            this.frameTrackBar.TabIndex = 8;
            this.frameTrackBar.Scroll += new System.EventHandler(this.frameTrackBar_Scroll);
            // 
            // horizontalSheetRButton
            // 
            this.horizontalSheetRButton.AutoSize = true;
            this.horizontalSheetRButton.Location = new System.Drawing.Point(50, 383);
            this.horizontalSheetRButton.Name = "horizontalSheetRButton";
            this.horizontalSheetRButton.Size = new System.Drawing.Size(72, 17);
            this.horizontalSheetRButton.TabIndex = 9;
            this.horizontalSheetRButton.TabStop = true;
            this.horizontalSheetRButton.Text = "Horizontal";
            this.horizontalSheetRButton.UseVisualStyleBackColor = true;
            // 
            // verticalSheetRButton
            // 
            this.verticalSheetRButton.AutoSize = true;
            this.verticalSheetRButton.Location = new System.Drawing.Point(50, 407);
            this.verticalSheetRButton.Name = "verticalSheetRButton";
            this.verticalSheetRButton.Size = new System.Drawing.Size(60, 17);
            this.verticalSheetRButton.TabIndex = 10;
            this.verticalSheetRButton.TabStop = true;
            this.verticalSheetRButton.Text = "Vertical";
            this.verticalSheetRButton.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 367);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Sprite Sheet Direction";
            // 
            // intervalNumberPicker
            // 
            this.intervalNumberPicker.Location = new System.Drawing.Point(339, 54);
            this.intervalNumberPicker.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.intervalNumberPicker.Name = "intervalNumberPicker";
            this.intervalNumberPicker.Size = new System.Drawing.Size(75, 20);
            this.intervalNumberPicker.TabIndex = 12;
            this.intervalNumberPicker.Value = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.intervalNumberPicker.ValueChanged += new System.EventHandler(this.intervalNumberPicker_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(339, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Frames per Second";
            // 
            // spriteSheetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 459);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.intervalNumberPicker);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.verticalSheetRButton);
            this.Controls.Add(this.horizontalSheetRButton);
            this.Controls.Add(this.frameTrackBar);
            this.Controls.Add(this.openButton);
            this.Controls.Add(this.stepBackButton);
            this.Controls.Add(this.playPauseButton);
            this.Controls.Add(this.stepForwardButton);
            this.Controls.Add(this.saveSheetButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.imageListBox);
            this.Controls.Add(this.spritePictureBox);
            this.Name = "spriteSheetForm";
            this.Text = "Sprite Sheet Maker";
            ((System.ComponentModel.ISupportInitialize)(this.spritePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.frameTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.intervalNumberPicker)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox spritePictureBox;
        private System.Windows.Forms.ListBox imageListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button saveSheetButton;
        private System.Windows.Forms.Button stepForwardButton;
        private System.Windows.Forms.Button playPauseButton;
        private System.Windows.Forms.Button stepBackButton;
        private System.Windows.Forms.Button openButton;
        private System.Windows.Forms.OpenFileDialog openImagesDialog;
        private System.Windows.Forms.ColorDialog colorPicker;
        private System.Windows.Forms.SaveFileDialog saveSheetDialog;
        private System.Windows.Forms.TrackBar frameTrackBar;
        private System.Windows.Forms.RadioButton horizontalSheetRButton;
        private System.Windows.Forms.RadioButton verticalSheetRButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown intervalNumberPicker;
        private System.Windows.Forms.Label label3;
    }
}


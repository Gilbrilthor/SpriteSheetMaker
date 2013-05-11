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
            this.intervalNumberPicker = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.spriteSheetDirectionGroupBox = new System.Windows.Forms.GroupBox();
            this.animationStyleGroupBox = new System.Windows.Forms.GroupBox();
            this.animationPingPongRButton = new System.Windows.Forms.RadioButton();
            this.animationLoopRButton = new System.Windows.Forms.RadioButton();
            this.frameBufferNumberPicker = new System.Windows.Forms.NumericUpDown();
            this.frameColorPreviewPanel = new System.Windows.Forms.Panel();
            this.pickFrameColorButton = new System.Windows.Forms.Button();
            this.frameOptionsPanel = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.spritePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.frameTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.intervalNumberPicker)).BeginInit();
            this.spriteSheetDirectionGroupBox.SuspendLayout();
            this.animationStyleGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.frameBufferNumberPicker)).BeginInit();
            this.frameOptionsPanel.SuspendLayout();
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
            this.saveSheetButton.Location = new System.Drawing.Point(113, 294);
            this.saveSheetButton.Name = "saveSheetButton";
            this.saveSheetButton.Size = new System.Drawing.Size(98, 23);
            this.saveSheetButton.TabIndex = 3;
            this.saveSheetButton.Text = "Save As...";
            this.saveSheetButton.UseVisualStyleBackColor = true;
            this.saveSheetButton.Click += new System.EventHandler(this.saveSheetButton_Click);
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
            this.openButton.Location = new System.Drawing.Point(9, 294);
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
            // saveSheetDialog
            // 
            this.saveSheetDialog.Filter = "BMP files|*.bmp";
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
            this.horizontalSheetRButton.Checked = true;
            this.horizontalSheetRButton.Location = new System.Drawing.Point(6, 29);
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
            this.verticalSheetRButton.Location = new System.Drawing.Point(6, 53);
            this.verticalSheetRButton.Name = "verticalSheetRButton";
            this.verticalSheetRButton.Size = new System.Drawing.Size(60, 17);
            this.verticalSheetRButton.TabIndex = 10;
            this.verticalSheetRButton.Text = "Vertical";
            this.verticalSheetRButton.UseVisualStyleBackColor = true;
            // 
            // intervalNumberPicker
            // 
            this.intervalNumberPicker.Location = new System.Drawing.Point(413, 129);
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
            this.label3.Location = new System.Drawing.Point(413, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Frames per Second";
            // 
            // spriteSheetDirectionGroupBox
            // 
            this.spriteSheetDirectionGroupBox.Controls.Add(this.horizontalSheetRButton);
            this.spriteSheetDirectionGroupBox.Controls.Add(this.verticalSheetRButton);
            this.spriteSheetDirectionGroupBox.Location = new System.Drawing.Point(11, 323);
            this.spriteSheetDirectionGroupBox.Name = "spriteSheetDirectionGroupBox";
            this.spriteSheetDirectionGroupBox.Size = new System.Drawing.Size(85, 80);
            this.spriteSheetDirectionGroupBox.TabIndex = 14;
            this.spriteSheetDirectionGroupBox.TabStop = false;
            this.spriteSheetDirectionGroupBox.Text = "Sprite Sheet Direction";
            // 
            // animationStyleGroupBox
            // 
            this.animationStyleGroupBox.Controls.Add(this.animationPingPongRButton);
            this.animationStyleGroupBox.Controls.Add(this.animationLoopRButton);
            this.animationStyleGroupBox.Location = new System.Drawing.Point(276, 50);
            this.animationStyleGroupBox.Name = "animationStyleGroupBox";
            this.animationStyleGroupBox.Size = new System.Drawing.Size(200, 45);
            this.animationStyleGroupBox.TabIndex = 15;
            this.animationStyleGroupBox.TabStop = false;
            this.animationStyleGroupBox.Text = "Animation Style";
            // 
            // animationPingPongRButton
            // 
            this.animationPingPongRButton.AutoSize = true;
            this.animationPingPongRButton.Location = new System.Drawing.Point(98, 20);
            this.animationPingPongRButton.Name = "animationPingPongRButton";
            this.animationPingPongRButton.Size = new System.Drawing.Size(71, 17);
            this.animationPingPongRButton.TabIndex = 1;
            this.animationPingPongRButton.Text = "PingPong";
            this.animationPingPongRButton.UseVisualStyleBackColor = true;
            this.animationPingPongRButton.CheckedChanged += new System.EventHandler(this.animationRButton_CheckedChanged);
            // 
            // animationLoopRButton
            // 
            this.animationLoopRButton.AutoSize = true;
            this.animationLoopRButton.Checked = true;
            this.animationLoopRButton.Location = new System.Drawing.Point(19, 20);
            this.animationLoopRButton.Name = "animationLoopRButton";
            this.animationLoopRButton.Size = new System.Drawing.Size(49, 17);
            this.animationLoopRButton.TabIndex = 0;
            this.animationLoopRButton.TabStop = true;
            this.animationLoopRButton.Text = "Loop";
            this.animationLoopRButton.UseVisualStyleBackColor = true;
            this.animationLoopRButton.CheckedChanged += new System.EventHandler(this.animationRButton_CheckedChanged);
            // 
            // frameBufferNumberPicker
            // 
            this.frameBufferNumberPicker.Location = new System.Drawing.Point(86, 19);
            this.frameBufferNumberPicker.Name = "frameBufferNumberPicker";
            this.frameBufferNumberPicker.Size = new System.Drawing.Size(108, 20);
            this.frameBufferNumberPicker.TabIndex = 17;
            // 
            // frameColorPreviewPanel
            // 
            this.frameColorPreviewPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.frameColorPreviewPanel.Location = new System.Drawing.Point(86, 54);
            this.frameColorPreviewPanel.Name = "frameColorPreviewPanel";
            this.frameColorPreviewPanel.Size = new System.Drawing.Size(22, 23);
            this.frameColorPreviewPanel.TabIndex = 18;
            // 
            // pickFrameColorButton
            // 
            this.pickFrameColorButton.Location = new System.Drawing.Point(115, 53);
            this.pickFrameColorButton.Name = "pickFrameColorButton";
            this.pickFrameColorButton.Size = new System.Drawing.Size(75, 23);
            this.pickFrameColorButton.TabIndex = 19;
            this.pickFrameColorButton.Text = "Color...";
            this.pickFrameColorButton.UseVisualStyleBackColor = true;
            this.pickFrameColorButton.Click += new System.EventHandler(this.pickFrameColorButton_Click);
            // 
            // frameOptionsPanel
            // 
            this.frameOptionsPanel.Controls.Add(this.label4);
            this.frameOptionsPanel.Controls.Add(this.label2);
            this.frameOptionsPanel.Controls.Add(this.frameBufferNumberPicker);
            this.frameOptionsPanel.Controls.Add(this.pickFrameColorButton);
            this.frameOptionsPanel.Controls.Add(this.frameColorPreviewPanel);
            this.frameOptionsPanel.Location = new System.Drawing.Point(113, 323);
            this.frameOptionsPanel.Name = "frameOptionsPanel";
            this.frameOptionsPanel.Size = new System.Drawing.Size(200, 80);
            this.frameOptionsPanel.TabIndex = 20;
            this.frameOptionsPanel.TabStop = false;
            this.frameOptionsPanel.Text = "Frame Options";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Pixel Buffer";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Buffer Color";
            // 
            // spriteSheetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 459);
            this.Controls.Add(this.frameOptionsPanel);
            this.Controls.Add(this.animationStyleGroupBox);
            this.Controls.Add(this.spriteSheetDirectionGroupBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.intervalNumberPicker);
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
            this.spriteSheetDirectionGroupBox.ResumeLayout(false);
            this.spriteSheetDirectionGroupBox.PerformLayout();
            this.animationStyleGroupBox.ResumeLayout(false);
            this.animationStyleGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.frameBufferNumberPicker)).EndInit();
            this.frameOptionsPanel.ResumeLayout(false);
            this.frameOptionsPanel.PerformLayout();
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
        private System.Windows.Forms.NumericUpDown intervalNumberPicker;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox spriteSheetDirectionGroupBox;
        private System.Windows.Forms.GroupBox animationStyleGroupBox;
        private System.Windows.Forms.RadioButton animationPingPongRButton;
        private System.Windows.Forms.RadioButton animationLoopRButton;
        private System.Windows.Forms.NumericUpDown frameBufferNumberPicker;
        private System.Windows.Forms.Panel frameColorPreviewPanel;
        private System.Windows.Forms.Button pickFrameColorButton;
        private System.Windows.Forms.GroupBox frameOptionsPanel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
    }
}


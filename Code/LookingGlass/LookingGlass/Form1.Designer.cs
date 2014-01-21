namespace LookingGlass
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.fullScreenButton = new System.Windows.Forms.Button();
            this.x0 = new System.Windows.Forms.TextBox();
            this.x1 = new System.Windows.Forms.TextBox();
            this.y0 = new System.Windows.Forms.TextBox();
            this.y1 = new System.Windows.Forms.TextBox();
            this.takePictureButton = new System.Windows.Forms.Button();
            this.numPictures = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "x:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "y:";
            // 
            // fullScreenButton
            // 
            this.fullScreenButton.Location = new System.Drawing.Point(91, 109);
            this.fullScreenButton.Name = "fullScreenButton";
            this.fullScreenButton.Size = new System.Drawing.Size(75, 23);
            this.fullScreenButton.TabIndex = 6;
            this.fullScreenButton.Text = "FullScreen";
            this.fullScreenButton.UseVisualStyleBackColor = true;
            this.fullScreenButton.Click += new System.EventHandler(this.fullScreenButton_Click);
            // 
            // x0
            // 
            this.x0.Location = new System.Drawing.Point(34, 10);
            this.x0.Name = "x0";
            this.x0.Size = new System.Drawing.Size(100, 20);
            this.x0.TabIndex = 7;
            // 
            // x1
            // 
            this.x1.Location = new System.Drawing.Point(140, 10);
            this.x1.Name = "x1";
            this.x1.Size = new System.Drawing.Size(100, 20);
            this.x1.TabIndex = 8;
            // 
            // y0
            // 
            this.y0.Location = new System.Drawing.Point(34, 37);
            this.y0.Name = "y0";
            this.y0.Size = new System.Drawing.Size(100, 20);
            this.y0.TabIndex = 9;
            // 
            // y1
            // 
            this.y1.Location = new System.Drawing.Point(140, 37);
            this.y1.Name = "y1";
            this.y1.Size = new System.Drawing.Size(100, 20);
            this.y1.TabIndex = 10;
            // 
            // takePictureButton
            // 
            this.takePictureButton.Location = new System.Drawing.Point(91, 138);
            this.takePictureButton.Name = "takePictureButton";
            this.takePictureButton.Size = new System.Drawing.Size(75, 23);
            this.takePictureButton.TabIndex = 11;
            this.takePictureButton.Text = "Take Pic";
            this.takePictureButton.UseVisualStyleBackColor = true;
            this.takePictureButton.Click += new System.EventHandler(this.takePictureButton_Click);
            // 
            // numPictures
            // 
            this.numPictures.Location = new System.Drawing.Point(140, 63);
            this.numPictures.Name = "numPictures";
            this.numPictures.Size = new System.Drawing.Size(100, 20);
            this.numPictures.TabIndex = 12;
            this.numPictures.Text = "1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "NumPictures:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 173);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numPictures);
            this.Controls.Add(this.takePictureButton);
            this.Controls.Add(this.y1);
            this.Controls.Add(this.y0);
            this.Controls.Add(this.x1);
            this.Controls.Add(this.x0);
            this.Controls.Add(this.fullScreenButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Pic-Cap";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button fullScreenButton;
        private System.Windows.Forms.TextBox x0;
        private System.Windows.Forms.TextBox x1;
        private System.Windows.Forms.TextBox y0;
        private System.Windows.Forms.TextBox y1;
        private System.Windows.Forms.Button takePictureButton;
        private System.Windows.Forms.TextBox numPictures;
        private System.Windows.Forms.Label label3;

    }
}


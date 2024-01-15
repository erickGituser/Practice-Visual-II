namespace PracticeOne.Dialogs
{
    partial class About
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(About));
            pictureBoxCopyright = new PictureBox();
            labelErick = new Label();
            buttonAccept = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCopyright).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxCopyright
            // 
            pictureBoxCopyright.Image = (Image)resources.GetObject("pictureBoxCopyright.Image");
            pictureBoxCopyright.Location = new Point(24, 76);
            pictureBoxCopyright.Name = "pictureBoxCopyright";
            pictureBoxCopyright.Size = new Size(318, 144);
            pictureBoxCopyright.TabIndex = 0;
            pictureBoxCopyright.TabStop = false;
            // 
            // labelErick
            // 
            labelErick.AutoSize = true;
            labelErick.Location = new Point(24, 32);
            labelErick.Name = "labelErick";
            labelErick.Size = new Size(301, 15);
            labelErick.TabIndex = 1;
            labelErick.Text = "This proyect was created by Erick Alberto Salgado Suazo";
            // 
            // buttonAccept
            // 
            buttonAccept.BackColor = SystemColors.ButtonShadow;
            buttonAccept.Location = new Point(267, 249);
            buttonAccept.Name = "buttonAccept";
            buttonAccept.Size = new Size(75, 23);
            buttonAccept.TabIndex = 2;
            buttonAccept.Text = "Accept";
            buttonAccept.UseVisualStyleBackColor = false;
            buttonAccept.Click += buttonAccept_Click;
            // 
            // About
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(371, 284);
            Controls.Add(buttonAccept);
            Controls.Add(labelErick);
            Controls.Add(pictureBoxCopyright);
            Name = "About";
            Text = "About";
            ((System.ComponentModel.ISupportInitialize)pictureBoxCopyright).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBoxCopyright;
        private Label labelErick;
        private Button buttonAccept;
    }
}
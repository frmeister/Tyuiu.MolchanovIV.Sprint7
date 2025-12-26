namespace Tyuiu.MolchanovIV.Sprint7.Project.V8
{
    partial class FormAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            pictureBoxAbout = new PictureBox();
            info_textBoxAbout = new TextBox();
            buttonAboutOk = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxAbout).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxAbout
            // 
            pictureBoxAbout.Image = (Image)resources.GetObject("pictureBoxAbout.Image");
            pictureBoxAbout.Location = new Point(12, 12);
            pictureBoxAbout.Name = "pictureBoxAbout";
            pictureBoxAbout.Size = new Size(207, 249);
            pictureBoxAbout.TabIndex = 0;
            pictureBoxAbout.TabStop = false;
            // 
            // info_textBoxAbout
            // 
            info_textBoxAbout.BackColor = SystemColors.Control;
            info_textBoxAbout.BorderStyle = BorderStyle.None;
            info_textBoxAbout.Enabled = false;
            info_textBoxAbout.Location = new Point(251, 12);
            info_textBoxAbout.Multiline = true;
            info_textBoxAbout.Name = "info_textBoxAbout";
            info_textBoxAbout.Size = new Size(421, 249);
            info_textBoxAbout.TabIndex = 1;
            info_textBoxAbout.Text = resources.GetString("info_textBoxAbout.Text");
            // 
            // buttonAboutOk
            // 
            buttonAboutOk.Location = new Point(590, 300);
            buttonAboutOk.Name = "buttonAboutOk";
            buttonAboutOk.Size = new Size(82, 49);
            buttonAboutOk.TabIndex = 2;
            buttonAboutOk.Text = "OK";
            buttonAboutOk.UseVisualStyleBackColor = true;
            buttonAboutOk.Click += buttonAboutOk_Click;
            // 
            // FormAbout
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(684, 361);
            Controls.Add(buttonAboutOk);
            Controls.Add(info_textBoxAbout);
            Controls.Add(pictureBoxAbout);
            MaximumSize = new Size(700, 400);
            MinimumSize = new Size(700, 400);
            Name = "FormAbout";
            Text = "О программе";
            ((System.ComponentModel.ISupportInitialize)pictureBoxAbout).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBoxAbout;
        private TextBox info_textBoxAbout;
        private Button buttonAboutOk;
    }
}
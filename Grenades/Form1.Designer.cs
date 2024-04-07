namespace Grenades
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            character = new PictureBox();
            generationTimer = new System.Windows.Forms.Timer(components);
            movementTimer = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)character).BeginInit();
            SuspendLayout();
            // 
            // character
            // 
            character.Image = Resource1.runner_left;
            character.Location = new Point(372, 341);
            character.Name = "character";
            character.Size = new Size(50, 50);
            character.SizeMode = PictureBoxSizeMode.CenterImage;
            character.TabIndex = 0;
            character.TabStop = false;
            // 
            // generationTimer
            // 
            generationTimer.Enabled = true;
            generationTimer.Interval = 2000;
            generationTimer.Tick += generationTimer_Tick;
            // 
            // movementTimer
            // 
            movementTimer.Enabled = true;
            movementTimer.Interval = 2;
            movementTimer.Tick += movementTimer_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(782, 403);
            Controls.Add(character);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Grenades";
            KeyDown += Form1_KeyDown;
            ((System.ComponentModel.ISupportInitialize)character).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox character;
        private System.Windows.Forms.Timer generationTimer;
        private System.Windows.Forms.Timer movementTimer;
    }
}

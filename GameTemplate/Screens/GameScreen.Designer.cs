namespace GameTemplate.Screens
{
    partial class GameScreen
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textLabel = new System.Windows.Forms.Label();
            this.charBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.charBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textLabel
            // 
            this.textLabel.BackColor = System.Drawing.Color.SpringGreen;
            this.textLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.textLabel.Enabled = false;
            this.textLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textLabel.Location = new System.Drawing.Point(32, 420);
            this.textLabel.Name = "textLabel";
            this.textLabel.Size = new System.Drawing.Size(787, 98);
            this.textLabel.TabIndex = 0;
            // 
            // charBox1
            // 
            this.charBox1.BackColor = System.Drawing.Color.Transparent;
            this.charBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.charBox1.Location = new System.Drawing.Point(36, 60);
            this.charBox1.Name = "charBox1";
            this.charBox1.Size = new System.Drawing.Size(247, 565);
            this.charBox1.TabIndex = 1;
            this.charBox1.TabStop = false;
            // 
            // GameScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::GameTemplate.Properties.Resources.bedroom;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.textLabel);
            this.Controls.Add(this.charBox1);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "GameScreen";
            this.Size = new System.Drawing.Size(838, 518);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.GameScreen_PreviewKeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.charBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label textLabel;
        private System.Windows.Forms.PictureBox charBox1;
    }
}

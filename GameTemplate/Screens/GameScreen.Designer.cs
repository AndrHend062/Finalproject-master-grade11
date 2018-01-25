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
            this.charBox2 = new System.Windows.Forms.PictureBox();
            this.charBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.charBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.charBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.charBox3)).BeginInit();
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
            this.charBox1.Location = new System.Drawing.Point(36, 87);
            this.charBox1.Name = "charBox1";
            this.charBox1.Size = new System.Drawing.Size(247, 565);
            this.charBox1.TabIndex = 1;
            this.charBox1.TabStop = false;
            // 
            // charBox2
            // 
            this.charBox2.BackColor = System.Drawing.Color.Transparent;
            this.charBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.charBox2.Location = new System.Drawing.Point(323, 87);
            this.charBox2.Name = "charBox2";
            this.charBox2.Size = new System.Drawing.Size(247, 565);
            this.charBox2.TabIndex = 2;
            this.charBox2.TabStop = false;
            // 
            // charBox3
            // 
            this.charBox3.BackColor = System.Drawing.Color.Transparent;
            this.charBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.charBox3.Location = new System.Drawing.Point(626, 87);
            this.charBox3.Name = "charBox3";
            this.charBox3.Size = new System.Drawing.Size(247, 565);
            this.charBox3.TabIndex = 3;
            this.charBox3.TabStop = false;
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
            this.Controls.Add(this.charBox2);
            this.Controls.Add(this.charBox3);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "GameScreen";
            this.Size = new System.Drawing.Size(1033, 652);
            this.Click += new System.EventHandler(this.GameScreen_Click);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.GameScreen_PreviewKeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.charBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.charBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.charBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label textLabel;
        private System.Windows.Forms.PictureBox charBox1;
        private System.Windows.Forms.PictureBox charBox2;
        private System.Windows.Forms.PictureBox charBox3;
    }
}

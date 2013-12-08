namespace TextureStealer
{
    partial class Interface
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Interface));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.openImageFileButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.originalImageBox = new System.Windows.Forms.PictureBox();
            this.newImageBox = new System.Windows.Forms.PictureBox();
            this.textureBox = new System.Windows.Forms.PictureBox();
            this.toolStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.originalImageBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newImageBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.openImageFileButton,
            this.toolStripButton3,
            this.toolStripButton4});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(384, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "Ajuda";
            this.toolStripButton1.Click += new System.EventHandler(this.openHelpWindow);
            // 
            // openImageFileButton
            // 
            this.openImageFileButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.openImageFileButton.Image = ((System.Drawing.Image)(resources.GetObject("openImageFileButton.Image")));
            this.openImageFileButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openImageFileButton.Name = "openImageFileButton";
            this.openImageFileButton.Size = new System.Drawing.Size(23, 22);
            this.openImageFileButton.Text = "Abrir Arquivo";
            this.openImageFileButton.Click += new System.EventHandler(this.openImageFile);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton3.Text = "Balde";
            this.toolStripButton3.Click += new System.EventHandler(this.selectTextureFilling);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton4.Text = "Pincel";
            this.toolStripButton4.Click += new System.EventHandler(this.selectTextureBrush);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableLayoutPanel1.Controls.Add(this.originalImageBox, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.newImageBox, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.textureBox, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 25);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(384, 237);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // originalImageBox
            // 
            this.originalImageBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.originalImageBox.Location = new System.Drawing.Point(3, 3);
            this.originalImageBox.Name = "originalImageBox";
            this.originalImageBox.Size = new System.Drawing.Size(166, 231);
            this.originalImageBox.TabIndex = 0;
            this.originalImageBox.TabStop = false;
            this.originalImageBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.captureTexture);
            // 
            // newImageBox
            // 
            this.newImageBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.newImageBox.Location = new System.Drawing.Point(213, 3);
            this.newImageBox.Name = "newImageBox";
            this.newImageBox.Size = new System.Drawing.Size(168, 231);
            this.newImageBox.TabIndex = 1;
            this.newImageBox.TabStop = false;
            this.newImageBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.drawTexture);
            // 
            // textureBox
            // 
            this.textureBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.textureBox.Location = new System.Drawing.Point(175, 184);
            this.textureBox.Name = "textureBox";
            this.textureBox.Size = new System.Drawing.Size(32, 50);
            this.textureBox.TabIndex = 2;
            this.textureBox.TabStop = false;
            // 
            // Interface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 262);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Interface";
            this.Text = "TextureStealer";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.originalImageBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newImageBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton openImageFileButton;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox originalImageBox;
        private System.Windows.Forms.PictureBox newImageBox;
        private System.Windows.Forms.PictureBox textureBox;
    }
}


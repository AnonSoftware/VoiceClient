namespace testPlugin.views
{
    partial class SoundPlatform
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
            this.components = new System.ComponentModel.Container();
            this.btn_player = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.setFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_player
            // 
            this.btn_player.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_player.Location = new System.Drawing.Point(0, 0);
            this.btn_player.Name = "btn_player";
            this.btn_player.Size = new System.Drawing.Size(150, 150);
            this.btn_player.TabIndex = 0;
            this.btn_player.Text = "button1";
            this.btn_player.UseVisualStyleBackColor = true;
            this.btn_player.Click += new System.EventHandler(this.Btn_player_Click);
            this.btn_player.MouseDown += new System.Windows.Forms.MouseEventHandler(this.rightClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.setFileToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(112, 26);
            // 
            // setFileToolStripMenuItem
            // 
            this.setFileToolStripMenuItem.Name = "setFileToolStripMenuItem";
            this.setFileToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.setFileToolStripMenuItem.Text = "Set File";
            this.setFileToolStripMenuItem.Click += new System.EventHandler(this.SetFileToolStripMenuItem_Click);
            // 
            // SoundPlatform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Controls.Add(this.btn_player);
            this.Name = "SoundPlatform";
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_player;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem setFileToolStripMenuItem;
    }
}

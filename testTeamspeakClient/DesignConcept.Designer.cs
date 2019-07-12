namespace testTeamspeakClient
{
    partial class DesignConcept
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.connectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connectToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.disconnectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_plugins = new System.Windows.Forms.Button();
            this.btn_create_channel = new System.Windows.Forms.Button();
            this.btn_audio = new System.Windows.Forms.Button();
            this.btn_page_settings = new System.Windows.Forms.Button();
            this.btn_page_users = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.muteMicrophoneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.muteHeadphonesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.muteAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnl_content = new System.Windows.Forms.Panel();
            this.contextMenuStripPlugins = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.contextMenuStripPlugins.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(55)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.connectToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(998, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(12, 20);
            // 
            // connectToolStripMenuItem
            // 
            this.connectToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectToolStripMenuItem1,
            this.disconnectToolStripMenuItem});
            this.connectToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.connectToolStripMenuItem.Name = "connectToolStripMenuItem";
            this.connectToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.connectToolStripMenuItem.Text = "Connections";
            // 
            // connectToolStripMenuItem1
            // 
            this.connectToolStripMenuItem1.Name = "connectToolStripMenuItem1";
            this.connectToolStripMenuItem1.Size = new System.Drawing.Size(133, 22);
            this.connectToolStripMenuItem1.Text = "Connect";
            // 
            // disconnectToolStripMenuItem
            // 
            this.disconnectToolStripMenuItem.Name = "disconnectToolStripMenuItem";
            this.disconnectToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.disconnectToolStripMenuItem.Text = "Disconnect";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.panel1.Controls.Add(this.btn_plugins);
            this.panel1.Controls.Add(this.btn_create_channel);
            this.panel1.Controls.Add(this.btn_audio);
            this.panel1.Controls.Add(this.btn_page_settings);
            this.panel1.Controls.Add(this.btn_page_users);
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(184, 422);
            this.panel1.TabIndex = 1;
            // 
            // btn_plugins
            // 
            this.btn_plugins.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(80)))));
            this.btn_plugins.FlatAppearance.BorderSize = 0;
            this.btn_plugins.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btn_plugins.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_plugins.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_plugins.ForeColor = System.Drawing.Color.White;
            this.btn_plugins.Location = new System.Drawing.Point(3, 175);
            this.btn_plugins.Name = "btn_plugins";
            this.btn_plugins.Size = new System.Drawing.Size(178, 44);
            this.btn_plugins.TabIndex = 4;
            this.btn_plugins.Text = "Plugins";
            this.btn_plugins.UseVisualStyleBackColor = false;
            this.btn_plugins.Click += new System.EventHandler(this.Btn_plugins_Click);
            // 
            // btn_create_channel
            // 
            this.btn_create_channel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(80)))));
            this.btn_create_channel.FlatAppearance.BorderSize = 0;
            this.btn_create_channel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btn_create_channel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_create_channel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_create_channel.ForeColor = System.Drawing.Color.White;
            this.btn_create_channel.Location = new System.Drawing.Point(3, 122);
            this.btn_create_channel.Name = "btn_create_channel";
            this.btn_create_channel.Size = new System.Drawing.Size(178, 44);
            this.btn_create_channel.TabIndex = 3;
            this.btn_create_channel.Text = "Create";
            this.btn_create_channel.UseVisualStyleBackColor = false;
            this.btn_create_channel.Click += new System.EventHandler(this.Btn_create_channel_Click);
            // 
            // btn_audio
            // 
            this.btn_audio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(80)))));
            this.btn_audio.FlatAppearance.BorderSize = 0;
            this.btn_audio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btn_audio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_audio.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_audio.ForeColor = System.Drawing.Color.White;
            this.btn_audio.Location = new System.Drawing.Point(3, 69);
            this.btn_audio.Name = "btn_audio";
            this.btn_audio.Size = new System.Drawing.Size(178, 44);
            this.btn_audio.TabIndex = 2;
            this.btn_audio.Text = "Audio";
            this.btn_audio.UseVisualStyleBackColor = false;
            this.btn_audio.Click += new System.EventHandler(this.Btn_audio_Click);
            // 
            // btn_page_settings
            // 
            this.btn_page_settings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(80)))));
            this.btn_page_settings.FlatAppearance.BorderSize = 0;
            this.btn_page_settings.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btn_page_settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_page_settings.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_page_settings.ForeColor = System.Drawing.Color.White;
            this.btn_page_settings.Location = new System.Drawing.Point(3, 370);
            this.btn_page_settings.Name = "btn_page_settings";
            this.btn_page_settings.Size = new System.Drawing.Size(178, 44);
            this.btn_page_settings.TabIndex = 1;
            this.btn_page_settings.Text = "Settings";
            this.btn_page_settings.UseVisualStyleBackColor = false;
            this.btn_page_settings.Click += new System.EventHandler(this.Btn_page_settings_Click);
            // 
            // btn_page_users
            // 
            this.btn_page_users.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(80)))));
            this.btn_page_users.FlatAppearance.BorderSize = 0;
            this.btn_page_users.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btn_page_users.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_page_users.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_page_users.ForeColor = System.Drawing.Color.White;
            this.btn_page_users.Location = new System.Drawing.Point(3, 18);
            this.btn_page_users.Name = "btn_page_users";
            this.btn_page_users.Size = new System.Drawing.Size(178, 44);
            this.btn_page_users.TabIndex = 0;
            this.btn_page_users.Text = "Users";
            this.btn_page_users.UseVisualStyleBackColor = false;
            this.btn_page_users.Click += new System.EventHandler(this.Btn_page_users_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.muteMicrophoneToolStripMenuItem,
            this.muteHeadphonesToolStripMenuItem,
            this.muteAllToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(173, 70);
            // 
            // muteMicrophoneToolStripMenuItem
            // 
            this.muteMicrophoneToolStripMenuItem.Name = "muteMicrophoneToolStripMenuItem";
            this.muteMicrophoneToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.muteMicrophoneToolStripMenuItem.Text = "Mute Microphone";
            this.muteMicrophoneToolStripMenuItem.Click += new System.EventHandler(this.MuteMicrophoneToolStripMenuItem_Click);
            // 
            // muteHeadphonesToolStripMenuItem
            // 
            this.muteHeadphonesToolStripMenuItem.Name = "muteHeadphonesToolStripMenuItem";
            this.muteHeadphonesToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.muteHeadphonesToolStripMenuItem.Text = "Mute Headphones";
            this.muteHeadphonesToolStripMenuItem.Click += new System.EventHandler(this.MuteHeadphonesToolStripMenuItem_Click);
            // 
            // muteAllToolStripMenuItem
            // 
            this.muteAllToolStripMenuItem.Name = "muteAllToolStripMenuItem";
            this.muteAllToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.muteAllToolStripMenuItem.Text = "Mute All";
            this.muteAllToolStripMenuItem.Click += new System.EventHandler(this.MuteAllToolStripMenuItem_Click);
            // 
            // pnl_content
            // 
            this.pnl_content.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_content.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(130)))));
            this.pnl_content.Location = new System.Drawing.Point(184, 23);
            this.pnl_content.Name = "pnl_content";
            this.pnl_content.Size = new System.Drawing.Size(814, 423);
            this.pnl_content.TabIndex = 2;
            // 
            // contextMenuStripPlugins
            // 
            this.contextMenuStripPlugins.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.contextMenuStripPlugins.Name = "contextMenuStripPlugins";
            this.contextMenuStripPlugins.Size = new System.Drawing.Size(181, 48);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // DesignConcept
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 446);
            this.Controls.Add(this.pnl_content);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "DesignConcept";
            this.Text = "DesignConcept";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.shutdown_ts);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.contextMenuStripPlugins.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem connectToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_page_users;
        private System.Windows.Forms.Button btn_page_settings;
        private System.Windows.Forms.ToolStripMenuItem connectToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem disconnectToolStripMenuItem;
        private System.Windows.Forms.Button btn_audio;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem muteMicrophoneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem muteHeadphonesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem muteAllToolStripMenuItem;
        private System.Windows.Forms.Panel pnl_content;
        private System.Windows.Forms.Button btn_create_channel;
        private System.Windows.Forms.Button btn_plugins;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripPlugins;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}
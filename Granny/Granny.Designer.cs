using System.Windows.Forms;

namespace Granny
{
    partial class Granny
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
            this.ScriptList = new System.Windows.Forms.ListBox();
            this.ListStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.LoadStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.ExecuteStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.ListRefresh = new System.IO.FileSystemWatcher();
            this.AttachBtn = new System.Windows.Forms.Button();
            this.ClearBtn = new System.Windows.Forms.Button();
            this.OpenFileBtn = new System.Windows.Forms.Button();
            this.ExecuteFileBtn = new System.Windows.Forms.Button();
            this.SaveFileBtn = new System.Windows.Forms.Button();
            this.ExecuteBtn = new System.Windows.Forms.Button();
            this.Header = new System.Windows.Forms.Panel();
            this.CloseBtn = new System.Windows.Forms.Button();
            this.MinBtn = new System.Windows.Forms.Button();
            this.Title = new System.Windows.Forms.Label();
            this.ScriptBox = new System.Windows.Forms.WebBrowser();
            this.InjectionTimer = new System.Windows.Forms.Timer(this.components);
            this.ScriptSaver = new System.Windows.Forms.Timer(this.components);
            this.OpenBtn = new System.Windows.Forms.Button();
            this.FolderWatcher = new System.IO.FileSystemWatcher();
            this.KillRblxBtn = new System.Windows.Forms.Button();
            this.ScriptsBtn = new System.Windows.Forms.Button();
            this.ScriptsStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.GrannyHubStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.DarkDexStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.RemoteSpyStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.InfinityYieldStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.MiscBtn = new System.Windows.Forms.Button();
            this.MiscStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.JoinStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.TabPanel = new System.Windows.Forms.Panel();
            this.AutoAttachTimer = new System.Windows.Forms.Timer(this.components);
            this.ListStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListRefresh)).BeginInit();
            this.Header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FolderWatcher)).BeginInit();
            this.ScriptsStrip.SuspendLayout();
            this.MiscStrip.SuspendLayout();
            this.TabPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ScriptList
            // 
            this.ScriptList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ScriptList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ScriptList.ContextMenuStrip = this.ListStrip;
            this.ScriptList.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScriptList.ForeColor = System.Drawing.Color.White;
            this.ScriptList.FormattingEnabled = true;
            this.ScriptList.ItemHeight = 23;
            this.ScriptList.Location = new System.Drawing.Point(663, 122);
            this.ScriptList.Name = "ScriptList";
            this.ScriptList.Size = new System.Drawing.Size(115, 184);
            this.ScriptList.TabIndex = 0;
            // 
            // ListStrip
            // 
            this.ListStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.ListStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ListStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LoadStrip,
            this.ExecuteStrip,
            this.DeleteStrip});
            this.ListStrip.Name = "ListStrip";
            this.ListStrip.Size = new System.Drawing.Size(130, 76);
            // 
            // LoadStrip
            // 
            this.LoadStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(44)))));
            this.LoadStrip.ForeColor = System.Drawing.Color.White;
            this.LoadStrip.Name = "LoadStrip";
            this.LoadStrip.Size = new System.Drawing.Size(129, 24);
            this.LoadStrip.Text = "Load";
            this.LoadStrip.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // ExecuteStrip
            // 
            this.ExecuteStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(44)))));
            this.ExecuteStrip.ForeColor = System.Drawing.Color.White;
            this.ExecuteStrip.Name = "ExecuteStrip";
            this.ExecuteStrip.Size = new System.Drawing.Size(129, 24);
            this.ExecuteStrip.Text = "Execute";
            this.ExecuteStrip.Click += new System.EventHandler(this.ExecuteStrip_Click);
            // 
            // DeleteStrip
            // 
            this.DeleteStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(44)))));
            this.DeleteStrip.ForeColor = System.Drawing.Color.White;
            this.DeleteStrip.Name = "DeleteStrip";
            this.DeleteStrip.Size = new System.Drawing.Size(129, 24);
            this.DeleteStrip.Text = "Delete";
            this.DeleteStrip.Click += new System.EventHandler(this.DeleteStrip_Click);
            // 
            // ListRefresh
            // 
            this.ListRefresh.EnableRaisingEvents = true;
            this.ListRefresh.Path = "Scripts\\";
            this.ListRefresh.SynchronizingObject = this;
            this.ListRefresh.Changed += new System.IO.FileSystemEventHandler(this.ListRefresh_Changed);
            this.ListRefresh.Deleted += new System.IO.FileSystemEventHandler(this.ListRefresh_Deleted);
            this.ListRefresh.Renamed += new System.IO.RenamedEventHandler(this.ListRefresh_Renamed);
            // 
            // AttachBtn
            // 
            this.AttachBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.AttachBtn.FlatAppearance.BorderSize = 0;
            this.AttachBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AttachBtn.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Bold);
            this.AttachBtn.Location = new System.Drawing.Point(701, 332);
            this.AttachBtn.Name = "AttachBtn";
            this.AttachBtn.Size = new System.Drawing.Size(75, 39);
            this.AttachBtn.TabIndex = 1;
            this.AttachBtn.Text = "Attach";
            this.AttachBtn.UseVisualStyleBackColor = false;
            this.AttachBtn.Click += new System.EventHandler(this.AttachBtn_Click);
            // 
            // ClearBtn
            // 
            this.ClearBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ClearBtn.FlatAppearance.BorderSize = 0;
            this.ClearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearBtn.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Bold);
            this.ClearBtn.Location = new System.Drawing.Point(93, 332);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(75, 39);
            this.ClearBtn.TabIndex = 2;
            this.ClearBtn.Text = "Clear";
            this.ClearBtn.UseVisualStyleBackColor = false;
            this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // OpenFileBtn
            // 
            this.OpenFileBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.OpenFileBtn.FlatAppearance.BorderSize = 0;
            this.OpenFileBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OpenFileBtn.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Bold);
            this.OpenFileBtn.Location = new System.Drawing.Point(174, 332);
            this.OpenFileBtn.Name = "OpenFileBtn";
            this.OpenFileBtn.Size = new System.Drawing.Size(75, 39);
            this.OpenFileBtn.TabIndex = 3;
            this.OpenFileBtn.Text = "Open File";
            this.OpenFileBtn.UseVisualStyleBackColor = false;
            this.OpenFileBtn.Click += new System.EventHandler(this.OpenFileBtn_Click);
            // 
            // ExecuteFileBtn
            // 
            this.ExecuteFileBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ExecuteFileBtn.FlatAppearance.BorderSize = 0;
            this.ExecuteFileBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExecuteFileBtn.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Bold);
            this.ExecuteFileBtn.Location = new System.Drawing.Point(255, 332);
            this.ExecuteFileBtn.Name = "ExecuteFileBtn";
            this.ExecuteFileBtn.Size = new System.Drawing.Size(94, 39);
            this.ExecuteFileBtn.TabIndex = 4;
            this.ExecuteFileBtn.Text = "Execute File";
            this.ExecuteFileBtn.UseVisualStyleBackColor = false;
            this.ExecuteFileBtn.Click += new System.EventHandler(this.ExecuteFileBtn_Click);
            // 
            // SaveFileBtn
            // 
            this.SaveFileBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.SaveFileBtn.FlatAppearance.BorderSize = 0;
            this.SaveFileBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveFileBtn.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Bold);
            this.SaveFileBtn.Location = new System.Drawing.Point(355, 332);
            this.SaveFileBtn.Name = "SaveFileBtn";
            this.SaveFileBtn.Size = new System.Drawing.Size(75, 39);
            this.SaveFileBtn.TabIndex = 5;
            this.SaveFileBtn.Text = "Save File";
            this.SaveFileBtn.UseVisualStyleBackColor = false;
            this.SaveFileBtn.Click += new System.EventHandler(this.SaveFileBtn_Click);
            // 
            // ExecuteBtn
            // 
            this.ExecuteBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ExecuteBtn.FlatAppearance.BorderSize = 0;
            this.ExecuteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExecuteBtn.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Bold);
            this.ExecuteBtn.Location = new System.Drawing.Point(12, 332);
            this.ExecuteBtn.Name = "ExecuteBtn";
            this.ExecuteBtn.Size = new System.Drawing.Size(75, 39);
            this.ExecuteBtn.TabIndex = 6;
            this.ExecuteBtn.Text = "Execute";
            this.ExecuteBtn.UseVisualStyleBackColor = false;
            this.ExecuteBtn.Click += new System.EventHandler(this.ExecuteBtn_Click);
            // 
            // Header
            // 
            this.Header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.Header.Controls.Add(this.CloseBtn);
            this.Header.Controls.Add(this.MinBtn);
            this.Header.Controls.Add(this.Title);
            this.Header.Location = new System.Drawing.Point(-4, -7);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(800, 55);
            this.Header.TabIndex = 7;
            this.Header.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Header_MouseDown);
            this.Header.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Header_MouseMove);
            // 
            // CloseBtn
            // 
            this.CloseBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.CloseBtn.FlatAppearance.BorderSize = 0;
            this.CloseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseBtn.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.CloseBtn.Location = new System.Drawing.Point(718, 11);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(61, 29);
            this.CloseBtn.TabIndex = 2;
            this.CloseBtn.Text = "X";
            this.CloseBtn.UseVisualStyleBackColor = false;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // MinBtn
            // 
            this.MinBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.MinBtn.FlatAppearance.BorderSize = 0;
            this.MinBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinBtn.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.MinBtn.Location = new System.Drawing.Point(664, 9);
            this.MinBtn.Name = "MinBtn";
            this.MinBtn.Size = new System.Drawing.Size(61, 29);
            this.MinBtn.TabIndex = 1;
            this.MinBtn.Text = "-";
            this.MinBtn.UseVisualStyleBackColor = false;
            this.MinBtn.Click += new System.EventHandler(this.MinBtn_Click);
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Location = new System.Drawing.Point(3, 23);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(52, 17);
            this.Title.TabIndex = 0;
            this.Title.Text = "Granny";
            // 
            // ScriptBox
            // 
            this.ScriptBox.Location = new System.Drawing.Point(13, 122);
            this.ScriptBox.MinimumSize = new System.Drawing.Size(20, 20);
            this.ScriptBox.Name = "ScriptBox";
            this.ScriptBox.Size = new System.Drawing.Size(644, 184);
            this.ScriptBox.TabIndex = 8;
            // 
            // InjectionTimer
            // 
            this.InjectionTimer.Enabled = true;
            this.InjectionTimer.Tick += new System.EventHandler(this.InjectionTimer_Tick);
            // 
            // ScriptSaver
            // 
            this.ScriptSaver.Enabled = true;
            this.ScriptSaver.Tick += new System.EventHandler(this.ScriptSaver_Tick);
            // 
            // OpenBtn
            // 
            this.OpenBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.OpenBtn.FlatAppearance.BorderSize = 0;
            this.OpenBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OpenBtn.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Bold);
            this.OpenBtn.Location = new System.Drawing.Point(436, 332);
            this.OpenBtn.Name = "OpenBtn";
            this.OpenBtn.Size = new System.Drawing.Size(148, 39);
            this.OpenBtn.TabIndex = 9;
            this.OpenBtn.Text = "Open Granny Folder";
            this.OpenBtn.UseVisualStyleBackColor = false;
            this.OpenBtn.Click += new System.EventHandler(this.OpenBtn_Click);
            // 
            // FolderWatcher
            // 
            this.FolderWatcher.EnableRaisingEvents = true;
            this.FolderWatcher.SynchronizingObject = this;
            this.FolderWatcher.Changed += new System.IO.FileSystemEventHandler(this.FolderWatcher_Changed);
            this.FolderWatcher.Deleted += new System.IO.FileSystemEventHandler(this.FolderWatcher_Deleted);
            // 
            // KillRblxBtn
            // 
            this.KillRblxBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.KillRblxBtn.FlatAppearance.BorderSize = 0;
            this.KillRblxBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.KillRblxBtn.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Bold);
            this.KillRblxBtn.Location = new System.Drawing.Point(590, 332);
            this.KillRblxBtn.Name = "KillRblxBtn";
            this.KillRblxBtn.Size = new System.Drawing.Size(105, 39);
            this.KillRblxBtn.TabIndex = 10;
            this.KillRblxBtn.Text = "Kill Roblox";
            this.KillRblxBtn.UseVisualStyleBackColor = false;
            this.KillRblxBtn.Click += new System.EventHandler(this.KillRblxBtn_Click);
            // 
            // ScriptsBtn
            // 
            this.ScriptsBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.ScriptsBtn.ContextMenuStrip = this.ScriptsStrip;
            this.ScriptsBtn.FlatAppearance.BorderSize = 0;
            this.ScriptsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ScriptsBtn.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Bold);
            this.ScriptsBtn.Location = new System.Drawing.Point(288, 3);
            this.ScriptsBtn.Name = "ScriptsBtn";
            this.ScriptsBtn.Size = new System.Drawing.Size(94, 39);
            this.ScriptsBtn.TabIndex = 11;
            this.ScriptsBtn.Text = "Scripts";
            this.ScriptsBtn.UseVisualStyleBackColor = false;
            // 
            // ScriptsStrip
            // 
            this.ScriptsStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.ScriptsStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ScriptsStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.GrannyHubStrip,
            this.DarkDexStrip,
            this.RemoteSpyStrip,
            this.InfinityYieldStrip});
            this.ScriptsStrip.Name = "ListStrip";
            this.ScriptsStrip.Size = new System.Drawing.Size(161, 100);
            // 
            // GrannyHubStrip
            // 
            this.GrannyHubStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(44)))));
            this.GrannyHubStrip.ForeColor = System.Drawing.Color.White;
            this.GrannyHubStrip.Name = "GrannyHubStrip";
            this.GrannyHubStrip.Size = new System.Drawing.Size(160, 24);
            this.GrannyHubStrip.Text = "GrannyHub";
            this.GrannyHubStrip.Click += new System.EventHandler(this.GrannyHubStrip_Click);
            // 
            // DarkDexStrip
            // 
            this.DarkDexStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(44)))));
            this.DarkDexStrip.ForeColor = System.Drawing.Color.White;
            this.DarkDexStrip.Name = "DarkDexStrip";
            this.DarkDexStrip.Size = new System.Drawing.Size(160, 24);
            this.DarkDexStrip.Text = "DarkDex";
            this.DarkDexStrip.Click += new System.EventHandler(this.DarkDexStrip_Click);
            // 
            // RemoteSpyStrip
            // 
            this.RemoteSpyStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(44)))));
            this.RemoteSpyStrip.ForeColor = System.Drawing.Color.White;
            this.RemoteSpyStrip.Name = "RemoteSpyStrip";
            this.RemoteSpyStrip.Size = new System.Drawing.Size(160, 24);
            this.RemoteSpyStrip.Text = "RemoteSpy";
            this.RemoteSpyStrip.Click += new System.EventHandler(this.RemoteSpyStrip_Click);
            // 
            // InfinityYieldStrip
            // 
            this.InfinityYieldStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(44)))));
            this.InfinityYieldStrip.ForeColor = System.Drawing.Color.White;
            this.InfinityYieldStrip.Name = "InfinityYieldStrip";
            this.InfinityYieldStrip.Size = new System.Drawing.Size(160, 24);
            this.InfinityYieldStrip.Text = "Infinity Yield";
            this.InfinityYieldStrip.Click += new System.EventHandler(this.InfinityYieldStrip_Click);
            // 
            // MiscBtn
            // 
            this.MiscBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.MiscBtn.ContextMenuStrip = this.MiscStrip;
            this.MiscBtn.FlatAppearance.BorderSize = 0;
            this.MiscBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MiscBtn.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Bold);
            this.MiscBtn.Location = new System.Drawing.Point(388, 3);
            this.MiscBtn.Name = "MiscBtn";
            this.MiscBtn.Size = new System.Drawing.Size(94, 39);
            this.MiscBtn.TabIndex = 12;
            this.MiscBtn.Text = "Misc";
            this.MiscBtn.UseVisualStyleBackColor = false;
            // 
            // MiscStrip
            // 
            this.MiscStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.MiscStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MiscStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.JoinStrip});
            this.MiscStrip.Name = "ListStrip";
            this.MiscStrip.Size = new System.Drawing.Size(200, 28);
            // 
            // JoinStrip
            // 
            this.JoinStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(44)))));
            this.JoinStrip.ForeColor = System.Drawing.Color.White;
            this.JoinStrip.Name = "JoinStrip";
            this.JoinStrip.Size = new System.Drawing.Size(199, 24);
            this.JoinStrip.Text = "Join Granny Server";
            this.JoinStrip.Click += new System.EventHandler(this.JoinStrip_Click);
            // 
            // TabPanel
            // 
            this.TabPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.TabPanel.Controls.Add(this.ScriptsBtn);
            this.TabPanel.Controls.Add(this.MiscBtn);
            this.TabPanel.Location = new System.Drawing.Point(2, 54);
            this.TabPanel.Name = "TabPanel";
            this.TabPanel.Size = new System.Drawing.Size(800, 55);
            this.TabPanel.TabIndex = 8;
            // 
            // AutoAttachTimer
            // 
            this.AutoAttachTimer.Enabled = true;
            this.AutoAttachTimer.Tick += new System.EventHandler(this.AutoAttachTimer_Tick);
            // 
            // Granny
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(790, 383);
            this.Controls.Add(this.TabPanel);
            this.Controls.Add(this.KillRblxBtn);
            this.Controls.Add(this.OpenBtn);
            this.Controls.Add(this.ScriptBox);
            this.Controls.Add(this.Header);
            this.Controls.Add(this.ExecuteBtn);
            this.Controls.Add(this.SaveFileBtn);
            this.Controls.Add(this.ExecuteFileBtn);
            this.Controls.Add(this.OpenFileBtn);
            this.Controls.Add(this.ClearBtn);
            this.Controls.Add(this.AttachBtn);
            this.Controls.Add(this.ScriptList);
            this.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Granny";
            this.Text = "Granny";
            this.Load += new System.EventHandler(this.Granny_Load);
            this.ListStrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ListRefresh)).EndInit();
            this.Header.ResumeLayout(false);
            this.Header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FolderWatcher)).EndInit();
            this.ScriptsStrip.ResumeLayout(false);
            this.MiscStrip.ResumeLayout(false);
            this.TabPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox ScriptList;
        private System.IO.FileSystemWatcher ListRefresh;
        private System.Windows.Forms.Button ExecuteBtn;
        private System.Windows.Forms.Button SaveFileBtn;
        private System.Windows.Forms.Button ExecuteFileBtn;
        private System.Windows.Forms.Button OpenFileBtn;
        private System.Windows.Forms.Button ClearBtn;
        private System.Windows.Forms.Button AttachBtn;
        private System.Windows.Forms.Panel Header;
        private System.Windows.Forms.Button CloseBtn;
        private System.Windows.Forms.Button MinBtn;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.WebBrowser ScriptBox;
        private System.Windows.Forms.Timer InjectionTimer;
        private System.Windows.Forms.ContextMenuStrip ListStrip;
        private System.Windows.Forms.ToolStripMenuItem LoadStrip;
        private System.Windows.Forms.ToolStripMenuItem DeleteStrip;
        private System.Windows.Forms.ToolStripMenuItem ExecuteStrip;
        private System.Windows.Forms.Timer ScriptSaver;
        private System.Windows.Forms.Button OpenBtn;
        private System.IO.FileSystemWatcher FolderWatcher;
        private System.Windows.Forms.Button KillRblxBtn;
        private Button MiscBtn;
        private Button ScriptsBtn;
        private ContextMenuStrip MiscStrip;
        private ToolStripMenuItem JoinStrip;
        private ContextMenuStrip ScriptsStrip;
        private ToolStripMenuItem GrannyHubStrip;
        private ToolStripMenuItem DarkDexStrip;
        private ToolStripMenuItem RemoteSpyStrip;
        private ToolStripMenuItem InfinityYieldStrip;
        private Panel TabPanel;
        private Timer AutoAttachTimer;
    }
}


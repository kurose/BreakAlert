namespace BreakAlert
{
    partial class MainForm
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuForNotifyIcon = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuItemEnd = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuForNotifyIcon.SuspendLayout();
            this.SuspendLayout();
            // 
            // notifyIcon
            // 
            this.notifyIcon.ContextMenuStrip = this.contextMenuForNotifyIcon;
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "BreakAlert";
            this.notifyIcon.Visible = true;
            // 
            // contextMenuForNotifyIcon
            // 
            this.contextMenuForNotifyIcon.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemEnd});
            this.contextMenuForNotifyIcon.Name = "contextMenuForNotifyIcon";
            this.contextMenuForNotifyIcon.Size = new System.Drawing.Size(101, 26);
            // 
            // menuItemEnd
            // 
            this.menuItemEnd.Name = "menuItemEnd";
            this.menuItemEnd.Size = new System.Drawing.Size(152, 22);
            this.menuItemEnd.Text = "終了";
            this.menuItemEnd.Click += new System.EventHandler(this.menuItemEnd_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(116, 22);
            this.ControlBox = false;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Opacity = 0D;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.contextMenuForNotifyIcon.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.ContextMenuStrip contextMenuForNotifyIcon;
        private System.Windows.Forms.ToolStripMenuItem menuItemEnd;
    }
}


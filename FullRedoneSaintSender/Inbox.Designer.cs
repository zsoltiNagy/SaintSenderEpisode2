namespace FullRedoneSaintSender
{
    partial class Inbox
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
            this.InboxListView = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // InboxListView
            // 
            this.InboxListView.GridLines = true;
            this.InboxListView.Location = new System.Drawing.Point(12, 13);
            this.InboxListView.Name = "InboxListView";
            this.InboxListView.Size = new System.Drawing.Size(817, 238);
            this.InboxListView.TabIndex = 1;
            this.InboxListView.UseCompatibleStateImageBehavior = false;
            this.InboxListView.View = System.Windows.Forms.View.Details;
            // 
            // Inbox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 261);
            this.Controls.Add(this.InboxListView);
            this.Name = "Inbox";
            this.Text = "Inbox";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListView InboxListView;
    }
}
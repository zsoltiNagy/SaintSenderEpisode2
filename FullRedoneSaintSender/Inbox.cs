using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using S22.Imap;
using System.Net.Mail;

namespace FullRedoneSaintSender
{
    public partial class Inbox : Form
    {
        
        string hostname = "imap.gmail.com",
               username = "CodeCooler123", password = "kalamajka";
        public Inbox()
        {
            SetupInbox();
        }

        public void SetupInbox()
        {
            InitializeComponent();
            InboxListView.View = View.Details;
            InboxListView.Columns.Add("From");
            InboxListView.Columns.Add("Subject");
            FillInbox(); 
            // The default port for IMAP over SSL is 993.
            InboxListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
        }

        public void FillInbox()
        {
            using (ImapClient client = new ImapClient(hostname, 993, username, password, AuthMethod.Login, true))
            {
                // Returns a collection of identifiers of all mails matching the specified search criteria.
                IEnumerable<uint> uids = client.Search(SearchCondition.Seen());
                // Download mail messages from the default mailbox.
                IEnumerable<MailMessage> messages = client.GetMessages(uids);
                foreach (var message in messages)
                {
                    string[] columnContentArray = new string[] {
                        message.From.DisplayName + message.From.Address,
                        message.Subject
                    };
                    ListViewItem item = new ListViewItem(columnContentArray);
                    item.Tag = message;
                    InboxListView.Items.Add(item);
                }
            }
        }
    }
}

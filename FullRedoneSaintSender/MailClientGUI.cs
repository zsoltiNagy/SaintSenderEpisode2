using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;
using S22.Imap;
using System.Net.Mail;

namespace FullRedoneSaintSender
{
    public partial class MailClientGUI : Form
    {
        public MailClientGUI()
        {
            InitializeComponent();
            string hostname = "imap.gmail.com",
               username = "CodeCooler123", password = "kalamajka";
            // The default port for IMAP over SSL is 993.
            using (ImapClient client = new ImapClient(hostname, 993, username, password, AuthMethod.Login, true))
            {
                Console.WriteLine("We are connected!");
                label1.Text = "We are connected!";
                // Returns a collection of identifiers of all mails matching the specified search criteria.
                IEnumerable<uint> uids = client.Search(SearchCondition.Seen());
                // Download mail messages from the default mailbox.
                IEnumerable<MailMessage> messages = client.GetMessages(uids);
                foreach (var message in messages)
                {
                    listBox1.Items.Add(message.From.Address);
                }
            }
        }
    }
}

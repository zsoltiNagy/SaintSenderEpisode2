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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            //FillInbox();
        }

        private void StartLoginProcess(string username, string password)
        {
            // Connect to Gmail's IMAP server on port 993 using SSL.
            ImapClient Client = new ImapClient("imap.gmail.com", 993, true);
            try
            {
                Client.Login(username, password, AuthMethod.Auto);
                UserNotification.Text = "YEAH!!";
            }
            catch (InvalidCredentialsException)
            {
                UserNotification.Text = "The server rejected the supplied credentials.";
            }
            
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            string username = UsernameLabel.Text, password = PasswordLabel.Text;
            StartLoginProcess(username, password);
        }
    }
}

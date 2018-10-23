using System;
using System.Net;
using System.Net.Mail;
using System.Windows;


namespace MailSender
{
    public partial class WpfMailSender
    {
        public WpfMailSender() => InitializeComponent();

        private void SendButton_OnClick(object sender, RoutedEventArgs e)
        {
            try
            {
                EmailSendServiceClass emailSendService = new EmailSendServiceClass();

                emailSendService.SendEmail(UserName_TextBox.Text, Password_PasswordBox.SecurePassword, tbNameMessage.Text, tbBodyMassage.Text);
            }
            catch (Exception error)
            {
                var error_dlg = new ErrorDialog(error.Message);
                error_dlg.Owner = this;              
                error_dlg.ShowDialog();
               
                return;
            }

            var dlg = new SendCompleteDialog();
            dlg.Owner = this;
            dlg.ShowDialog();
        }
    }
}

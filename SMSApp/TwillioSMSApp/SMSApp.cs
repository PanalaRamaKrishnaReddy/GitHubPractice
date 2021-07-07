using System;
using System.Windows.Forms;
using Twilio;
using Twilio.Rest.Api.V2010.Account;
using Vonage.Request;
using Vonage;

namespace SMSApp
{
    public partial class SMSApp : Form
    {
        VonageClient vonageClient = new VonageClient(null);
        public SMSApp()
        {
            InitializeComponent();
            var credentials = Credentials.FromApiKeyAndSecret(
            "d0235810",
            "HirJo1GzoIwH4k30"
            );

            vonageClient = new VonageClient(credentials);
        }

        private void BtnSend_Click(object sender, EventArgs e)
        {
            try
            {
                var response = vonageClient.SmsClient.SendAnSms(new Vonage.Messaging.SendSmsRequest()
                {
                    To = "918971862349",
                    From = "Vonage APIs",
                    Text = txtMessage.Text
                });

                if(response != null && Convert.ToInt32(response.MessageCount) > 0 && response.Messages[0].StatusCode.ToString() == "Success")
                {
                    MessageBox.Show("Send successfully");
                }
            }
            catch { MessageBox.Show("Please try again, after some time"); }
        }
    }
}

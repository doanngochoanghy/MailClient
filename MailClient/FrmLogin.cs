using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Security;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MailClient
{
    public partial class FrmLogin : Form
    {
        string user, password;
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            TcpClient SmtpServer = new TcpClient("smtp.viettel.com.vn", 465);
            SslStream SmtpStream = new SslStream(SmtpServer.GetStream());
            TcpClient Pop3Server = new TcpClient("pop3.viettel.com.vn", 995);
            SslStream Pop3Stream = new SslStream(Pop3Server.GetStream());
            user = txtUser.Text;
            password = txtPassword.Text;
            string result;
            Pop3Stream.AuthenticateAsClient("pop3.viettel.com.vn");
            SSLStream.ReadMessage(Pop3Stream);
            SmtpStream.AuthenticateAsClient("smtp.viettel.com.vn");
            SSLStream.ReadMessage(SmtpStream);
            SSLStream.WriteMessage(SmtpStream, "EHLO viettel.com.vn\r\n");
            SSLStream.ReadMessage(SmtpStream);
            SSLStream.WriteMessage(SmtpStream, "AUTH LOGIN\r\n");
            SSLStream.ReadMessage(SmtpStream);
            if (user == "")
            {
                lblNotification.Text = "Bạn chưa nhập tài khoản!";
                txtUser.Focus();
            }
            else
            {
                if (password == "")
                {
                    lblNotification.Text = "Bạn chưa nhập mật khẩu!";
                    txtPassword.Focus();
                }
                else
                {
                    SSLStream.WriteMessage(SmtpStream, string.Format("{0}\r\n", Convert.ToBase64String(Encoding.ASCII.GetBytes(user))));
                    SSLStream.ReadMessage(SmtpStream);
                    SSLStream.WriteMessage(SmtpStream, string.Format("{0}\r\n", Convert.ToBase64String(Encoding.ASCII.GetBytes(password))));
                    result = SSLStream.ReadMessage(SmtpStream);
                    if (result.Substring(0, 3) != "235")
                    {
                        lblNotification.Text = "Tài khoản hoặc mật khẩu bạn nhập không đúng. Hãy nhập lại!";
                        txtPassword.Text = "";
                        txtPassword.Focus();
                    }
                    else
                    {
                        SSLStream.WriteMessage(Pop3Stream, String.Format("USER {0}\r\n", user));
                        SSLStream.ReadMessage(Pop3Stream);
                        SSLStream.WriteMessage(Pop3Stream, String.Format("PASS {0}\r\n", password));
                        SSLStream.ReadMessage(Pop3Stream);
                        ////SmtpServer.Close();
                        //Pop3Server.Close();
                        FrmMain FormMain = new FrmMain(SmtpStream, Pop3Stream, user);
                        FormMain.Show();
                        this.Dispose();
                    }
                }
            }
        }
    }
}

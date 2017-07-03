using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.IO;

namespace MailClient
{
    public partial class FrmMain : Form
    {
        SslStream SmtpStream, Pop3Stream;
        string user;
        int MailQuantity;
        string allData;
        public FrmMain(SslStream smtpStream, SslStream pop3Stream, string user)
        {
            InitializeComponent();
            SmtpStream = smtpStream;
            Pop3Stream = pop3Stream;
            if (!user.Contains("@"))
            {
                user += "@viettel.com.vn";
            }
            this.user = user;
            lblUser.Text = user;
            //UpdateInbox();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            FrmLogin frmLogin = new FrmLogin();
            frmLogin.Show();
            this.Dispose();
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            //try
            {

                SSLStream.WriteMessage(SmtpStream, string.Format("MAIL FROM:<{0}>\r\n", user));
                /*MessageBox.Show(*/
                SSLStream.ReadMessage(SmtpStream)/*)*/;
                if (txtTo.Text == "")
                {
                    MessageBox.Show("Bạn chưa nhập địa chỉ người nhận.");
                    txtTo.Focus();
                }
                else
                {

                    SSLStream.WriteMessage(SmtpStream, string.Format("RCPT TO:<{0}>\r\n", txtTo.Text));
                    SSLStream.ReadMessage(SmtpStream);
                    SSLStream.WriteMessage(SmtpStream, "DATA\r\n");
                    SSLStream.ReadMessage(SmtpStream);
                    SSLStream.WriteMessage(SmtpStream, string.Format("Subject: {0}\r\n", txtSubject.Text));
                    SSLStream.WriteMessage(SmtpStream, string.Format("From: {0}\r\n", user));
                    SSLStream.WriteMessage(SmtpStream, string.Format("To: {0}\r\n", txtTo.Text));
                    SSLStream.WriteMessage(SmtpStream, string.Format("CC: {0}\r\n", txtCc.Text));
                    SSLStream.WriteMessage(SmtpStream, txtContent.Text + "\r\n");
                    SSLStream.WriteMessage(SmtpStream, ".\r\n");
                    if (SSLStream.ReadMessage(SmtpStream).Substring(0, 3) == "250")
                    {
                        MessageBox.Show("Gửi thành công!");
                        txtCc.Text = "";
                        txtContent.Text = "";
                        txtSubject.Text = "";
                        txtTo.Text = "";
                    }

                }
            }
            //catch (Exception ex)
            {
                //MessageBox.Show("Gửi mail bị lỗi. Vui lòng thử lại!");

                //throw ex;
            }

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {

            Cursor.Current = Cursors.WaitCursor;
            UpdateInbox();
            Cursor.Current = Cursors.Default;
            //SSLStream.WriteMessage(Pop3Stream, "RETR 144\r\n");
            //txtContentInbox.Text = ReadSender(ReadAllData(Pop3Stream));
            //string allData= ReadAllData(Pop3Stream);
            //txtContentInbox.Text = allData;
            //lvwInbox.Items.Clear();
            //ListViewItem item = new ListViewItem(ReadTime(allData));
            //string[] timeSplit = ReadTime(allData).Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            //item.SubItems.Add(timeSplit[1]+" "+timeSplit[2]+" "+timeSplit[4].Substring(0,5));
            //lvwInbox.Items.Add(item);
            //lvwInbox.Items[0].Selected = true;
            //lvwInbox.SelectedItems.Clear() ;
            //lvwInbox.Select();
            //lvwInbox.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
        }

        private string ReadAllData(SslStream sslStream)
        {
            string allData = string.Empty;
            string partData;
            do
            {
                partData = SSLStream.ReadMessage(sslStream);
                allData += partData;
            } while (!partData.Contains("\r\n.\r\n"));
            return allData;
        }


        private string ReadSender(string allData)
        {
            string sender;
            string senderData= allData.Substring(allData.IndexOf("\r\nFrom:") + 8, allData.IndexOf("\r\n", allData.IndexOf("\r\nFrom:") + 1) - allData.IndexOf("\r\nFrom:") - 8);
            if (!senderData.Contains("<"))
            {
                sender = senderData;
            }
            else
            {
                sender = senderData.Substring(senderData.IndexOf('<')+1, senderData.IndexOf('>') - senderData.IndexOf('<')-1);
            }
            return sender;
        }

        private string ReadTime(string allData)
        {
            string time;
            time = allData.Substring(allData.IndexOf("\r\nDate:") + 8, allData.IndexOf("\r\n", allData.IndexOf("\r\nDate:") + 1) - allData.IndexOf("\r\nDate:") -8);
            return time;
        }
        private string ReadContent(string allData)
        {
            string content=string.Empty;
            int start, end;
            if (allData.Contains("\r\nContent-Type:"))
            {
                if (allData.Contains("\r\nContent-Type: text/html;"))
                {
                    start = allData.IndexOf("\r\n<html");
                    end = allData.IndexOf("/html>\r\n", start + 1);

                    if (start!=-1)
                    {
                        content = allData.Substring(start + 2, end - start + 5);
                        content = content.Replace("=\r\n", "");
                        int i = 0, k = 0;
                        byte[] bytes = new byte[content.Length];
                        if (allData.IndexOf("\r\nContent-Transfer-Encoding: quoted-printable\r\n",allData.IndexOf("\r\nContent-Type: text/html;"))!=-1)
                        {
                            while (i < content.Length)
                            {
                                if (content[i] != '=')
                                {
                                    bytes[k] = Convert.ToByte(content[i]);
                                    i++;
                                    k++;
                                }
                                else
                                {
                                    string str = content.Substring(i + 1, 2);
                                    int value = Convert.ToInt32(str, 16);
                                    bytes[k] = Convert.ToByte(value);
                                    k++;
                                    i += 3;
                                }
                            }
                            content = Encoding.UTF8.GetString(bytes); 
                        }
                    }
                    else
                    {
                        content = string.Empty;
                    }
                }
                else
                {
                    start = allData.IndexOf("\r\n\r\n", allData.IndexOf("Content-Type: text/plain;")) + 4;
                    end = allData.IndexOf("\r\n\r\n--", start + 1);
                    content = allData.Substring(start, end - start);
                    content =content.Replace("<","&lt;").Replace(">","&gt;");
                    content = content.Replace("\r\n", "<br>");
                }
            }
            else
            {
                start = allData.IndexOf("\r\n\r\n")+4;
                end = allData.IndexOf("\r\n.\r\n");
                content = allData.Substring(start, end - start);
                content = content.Replace("\r\n", "<br>");
            }
            //if (allData.IndexOf("\r\nContent-Type: text/html;")!=-1)
            //{
            //    start = allData.IndexOf("\r\n<html>");
            //    end = allData.IndexOf("</html>\r\n", start + 1);
            //    content = allData.Substring(start+2, end - start+5); 
            //}
            //else
            //{
            //    start = allData.IndexOf("\r\n\r\n");
            //    end = allData.IndexOf("\r\n.\r\n");
            //    content = allData.Substring(start, end - start);
            //}
            return content;
        }

        private string ReadSubject(string allData)
        {
            string subject=string.Empty;
            int startPos, endPos;
            startPos = allData.IndexOf("\r\nSubject")+8;
            do
            {
                endPos = allData.IndexOf("\r\n", startPos+3);
                subject += allData.Substring(startPos+3, endPos - startPos-3);
                startPos = endPos;
            } while (allData[endPos+2]==' '|| allData[endPos + 2] == '\t');
            return subject;
        }
        
        private void ReadAttachmentName(string allData)
        {
            lbxAttachment.Items.Clear();
            int start, end;
            string filename;
            start = allData.IndexOf("\r\nContent-Disposition: attachment;");
            while (start!=-1)
            {
                start = allData.IndexOf("filename=", start + 1)+9;
                end = allData.IndexOf("\r\n", start + 1);
                filename = allData.Substring(start, end - start);
                lbxAttachment.Items.Add(filename.Replace("\"",""));
                start = allData.IndexOf("\r\nContent-Disposition: attachment;",end+1);
            }
        }
        private string ConvertSubject(string subjectData)
        {
            string subject = "";
            if ((subjectData.Contains("=?utf-8?") || subjectData.Contains("=?UTF-8?")) && subjectData.Contains("?="))
            {
                subjectData = subjectData.Replace("8?q?","8?Q?");
                if (subjectData.Contains("Q?"))
                {
                    subjectData = subjectData.Replace("=?utf-8?Q?", "");
                    subjectData = subjectData.Replace("=?UTF-8?Q?", "");
                    subjectData = subjectData.Replace("?=", "");
                    subjectData = subjectData.Replace("_", " ");
                    int i = 0, k = 0;
                    byte[] bytes = new byte[subjectData.Length];
                    while (i < subjectData.Length)
                    {
                        if (subjectData[i] != '=')
                        {
                            bytes[k] = Convert.ToByte(subjectData[i]);
                            i++;
                            k++;
                        }
                        else
                        {
                            string str = subjectData.Substring(i + 1, 2);
                            int value = Convert.ToInt32(str, 16);
                            bytes[k] = Convert.ToByte(value);
                            k++;
                            i += 3;
                        }
                    }
                    subject = Encoding.UTF8.GetString(bytes);
                }
                else
                {
                    subjectData = subjectData.Replace("8?b?","8?B?");
                    int startPos, endPos;
                    startPos = subjectData.IndexOf("8?B?", 0)+4;
                    do
                    {
                        endPos = subjectData.IndexOf("?=",startPos);
                        subject += Encoding.UTF8.GetString(Convert.FromBase64String(subjectData.Substring(startPos, endPos-startPos)));
                        startPos = endPos + 12;
                    } while (startPos<subjectData.Length);
                }
            }
            else
            {
                subject = subjectData;
            }
            return subject;
        }
        private void lvwInbox_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button==MouseButtons.Left)
            {
                try
                {
                    webBrowser1.DocumentText = string.Empty;
                    lvwInbox.Select();
                    int indexMail = MailQuantity - lvwInbox.SelectedItems[0].Index;
                    SSLStream.WriteMessage(Pop3Stream, string.Format("RETR {0}\r\n", indexMail));
                    allData = ReadAllData(Pop3Stream);
                    //webBrowser1.DocumentText = allData.Replace("\r\n", "<br>");
                    webBrowser1.DocumentText = ReadContent(allData);
                    //webBrowser1.DocumentText = allData;

                    ReadAttachmentName(allData);
                    //////    
                }
                catch (Exception)
                {
                    MessageBox.Show("Đã xảy ra lỗi");
                    //throw ex;
                }
                //lvwInbox.SelectedItems.Clear();
            }
        }

        private void tabMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            webBrowser1.DocumentText=string.Empty;
        }

        private void txtContentInbox_Enter(object sender, EventArgs e)
        {
            lvwInbox.SelectedItems[0].BackColor = Color.PowderBlue;
        }

        private void txtContentInbox_Leave(object sender, EventArgs e)
        {
            lvwInbox.SelectedItems[0].BackColor = Color.White;
        }

        private void lbxAttachment_Leave(object sender, EventArgs e)
        {
            lbxAttachment.SelectedItems.Clear();
        }

        private void lbxAttachment_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (lbxAttachment.SelectedItems.Count > 0)
                {
                    string path, filename;
                    filename = lbxAttachment.SelectedItem.ToString();
                    string base64Data;
                    byte[] byteData;
                    int start, end;
                    start = allData.IndexOf("\r\nContent-Disposition: attachment;");
                    start = allData.IndexOf(filename, start);
                    start = allData.IndexOf("\r\n\r\n", start);
                    end = allData.IndexOf("\r\n--", start);
                    base64Data = allData.Substring(start, end - start);
                    base64Data = base64Data.Replace("\r\n", "");
                    byteData = Convert.FromBase64String(base64Data);
                    FolderBrowserDialog fbd = new FolderBrowserDialog();
                    DialogResult result = fbd.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        path = fbd.SelectedPath;
                        path += "\\" + filename;
                        FileStream fs = new FileStream(path, FileMode.Create, FileAccess.Write);
                        fs.Write(byteData, 0, byteData.Length);
                        fs.Close();
                        MessageBox.Show(string.Format("Download file {0} thành công!", filename));
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Đã xảy ra lỗi khi download!");
                //throw;
            }
        }

        private void UpdateInbox()
        {
            SSLStream.WriteMessage(Pop3Stream, "STAT\r\n");
            MailQuantity = int.Parse(SSLStream.ReadMessage(Pop3Stream).Split(' ')[1]);
            lblMailQuantity.Text = string.Format("{0} messages", MailQuantity);
            webBrowser1.DocumentText = string.Empty;
            for (int i = MailQuantity; i > MailQuantity-100; i--)
            {
                SSLStream.WriteMessage(Pop3Stream, string.Format("RETR {0}\r\n",i));
                string allData = ReadAllData(Pop3Stream);
                ListViewItem itemHeader = new ListViewItem(ReadSender(allData));
                string[] timeSplit = ReadTime(allData).Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                itemHeader.SubItems.Add(timeSplit[1] + " " + timeSplit[2] + " " + timeSplit[4].Substring(0, 5));
                itemHeader.SubItems.Add(ConvertSubject( ReadSubject(allData)));
                lvwInbox.Items.Add(itemHeader);
                lvwInbox.Columns[2].AutoResize(ColumnHeaderAutoResizeStyle.ColumnContent);
            }
        }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SendMail_Beta
{
    public partial class MailForm : Form
    {
        Attachment attach;

        bool flagStatus;

        public MailForm()
        {
            InitializeComponent();
            attach = null;
            flagStatus = false;

            tbxUser.Text = "lengocson2204@gmail.com";
            tbxPass.Text = "0979300575";
        }

        void sendMess(string from, string to, string subject, string message, Attachment attach = null)
        {
            MailMessage mess = new MailMessage(from, to, subject, message);

            if (tbxTo.Text == "" || tbxUser.Text == "" || tbxPass.Text == "")
            {
                MessageBox.Show("Người xưa có câu: 'chủ đề có thể không có nhưng người nhận + tài khoản + mật khẩu phải có nha.'", "Ơ không nhập đủ rồi gửi bằng niềm tin à bác!!");
            }
            else
            {
                if (attach != null)
                {
                    mess.Attachments.Add(attach);
                }

                SmtpClient client = new SmtpClient("smtp.gmail.com", 587);

                client.EnableSsl = true;

                client.Credentials = new NetworkCredential(tbxUser.Text, tbxPass.Text);

                client.Send(mess);
            }
        }

        private void btnBrowser_Click(object sender, EventArgs e)
        {
            
            OpenFileDialog dialog = new OpenFileDialog();
            
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                flagStatus = true;
            }
            else
            {
                flagStatus = false;
            }

            tbxTo.Text = dialog.FileName;

            if (tbxTo.Text != "" && tbxTo.Text == tbxAtt.Text)
            {
                MessageBox.Show("Bạn cần tạo ra 1 file đính kèm khác tên để gửi", "Lỗi");
                attach = null;
                flagStatus = false;
            }
        }


        private void btnAtt_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.ShowDialog();

            foreach (string item in dialog.FileNames)
            {
                tbxAtt.Text = item;
                if (tbxTo.Text == tbxAtt.Text)
                {
                    MessageBox.Show("Bạn cần tạo ra 1 file đính kèm khác tên để gửi", "Lỗi");
                    tbxAtt.Text = "Đã hủy đính kèm...";
                    attach = null;
                }
                else
                {
                    MessageBox.Show("Thêm thành công!", "Thông Báo");
                }
            }
        }

        private void btnCancelAtt_Click(object sender, EventArgs e)
        {
            attach = null;
            MessageBox.Show("Huỷ đính kèm", "Thông báo");
            tbxAtt.Text = "Đã hủy đính kèm...";
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            attach = null;
            Thread thread = new Thread(() =>
            {
                try
                {
                    FileInfo file = new FileInfo(tbxAtt.Text);
                    attach = new Attachment(tbxAtt.Text);
                }
                catch
                {
                }

                if (flagStatus == false)
                {
                    if (tbxTo.Text == "" || tbxUser.Text == "" || tbxPass.Text == "")
                    {
                        MessageBox.Show("Người xưa có câu: 'chủ đề có thể không có nhưng người nhận + tài khoản + mật khẩu phải có nha.'", "Ơ không nhập đủ rồi gửi bằng niềm tin à bác!!");
                    }
                    else
                    {
                        sendMess(tbxUser.Text, tbxTo.Text, tbxSubject.Text, tbxMessage.Text, attach);
                        lblStatus.Invoke((Action)(() => lblStatus.Text = "Đã gửi"));
                    }
                }
                else
                { 
                    if (tbxTo.Text == "" || tbxUser.Text == "" || tbxPass.Text == "")
                    {
                        MessageBox.Show("Người xưa có câu: 'chủ đề có thể không có nhưng người nhận + tài khoản + mật khẩu phải có nha.'", "Ơ không nhập đủ rồi gửi bằng niềm tin à bác!!");
                    }
                    else
                    {
                        StreamReader sr = new StreamReader(tbxTo.Text);
                        string email;

                        while ((email = sr.ReadLine()) != null)
                        {
                            if (tbxTo.Text == "" || tbxUser.Text == "" || tbxPass.Text == "")
                            {
                                MessageBox.Show("Người xưa có câu: 'chủ đề có thể không có nhưng người nhận + tài khoản + mật khẩu phải có nha.'", "Ơ không nhập đủ rồi gửi bằng niềm tin à bác!!");
                            }
                            else
                            { 
                                sendMess(tbxUser.Text, email, tbxSubject.Text, tbxMessage.Text, attach);
                            }
                        }
                        sr.Close();
                        lblStatus.Invoke((Action)(() => 
                        {
                            lblStatus.Text = "Đã gửi";
                            flagStatus = false;
                            tbxTo.Text = "";
                        }));
                    }
                }
            });
            thread.Start();
        }
    }
}

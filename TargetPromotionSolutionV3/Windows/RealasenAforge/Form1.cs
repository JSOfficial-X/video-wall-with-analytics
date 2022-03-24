using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video.DirectShow;
using AForge.Video;
using System.Drawing.Imaging;
using System.Diagnostics;
using System.Net.Mail;
using System.IO;

namespace RealasenAforge
{
    public partial class Form1 : Form
    {
        private FilterInfoCollection CaptureDevice;
        private VideoCaptureDevice FinalFrame;
        int x = 0;
        public Form1()
        {
            InitializeComponent();
            //CaptureDevice = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            //foreach (FilterInfo Device in CaptureDevice)
            //{
            //    comboBox1.Items.Add(Device.Name);
            //}
            //comboBox1.SelectedIndex = 0;

        }
        private void FinalFrame_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            //pictureBox1.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
                Task.Factory.StartNew(() =>
                {
                    for (x = 0; x < 5; x++)
                    {
                        haha(x);
                    }

                });
            
                //FinalFrame = new VideoCaptureDevice();
                //FinalFrame = new VideoCaptureDevice(CaptureDevice[comboBox1.SelectedIndex].MonikerString);
                //FinalFrame.NewFrame += new NewFrameEventHandler(FinalFrame_NewFrame);
                //FinalFrame.Start();
                //try
                //{
                //MailMessage objeto_mail = new MailMessage();
                //SmtpClient client = new SmtpClient();
                //client.EnableSsl = true;
                //client.Port = 587;
                //client.Host = "smtp.gmail.com";
                //client.Timeout = 90000;
                //client.DeliveryMethod = SmtpDeliveryMethod.Network;
                //client.UseDefaultCredentials = false;
                //client.Credentials = new System.Net.NetworkCredential("gloriamei223@gmail.com", "Shmilu14");
                //objeto_mail.From = new MailAddress("gloriamei223@gmail.com");
                //objeto_mail.To.Add(new MailAddress("gloria_mei322@yahoo.com"));
                //objeto_mail.Subject = "from c#";
                //objeto_mail.Body = "hahaha lipianpian";
                //Attachment atta = new System.Net.Mail.Attachment(@"C:\Game\Promotor_Person\quiz.jpg");
                //objeto_mail.Attachments.Add(atta);

                //if (attachmentFilename != null)
                //{
                //    Attachment attachment = new Attachment(attachmentFilename, MediaTypeNames.Application.Octet);
                //    ContentDisposition disposition = attachment.ContentDisposition;
                //    disposition.CreationDate = File.GetCreationTime(attachmentFilename);
                //    disposition.ModificationDate = File.GetLastWriteTime(attachmentFilename);
                //    disposition.ReadDate = File.GetLastAccessTime(attachmentFilename);
                //    disposition.FileName = Path.GetFileName(attachmentFilename);
                //    disposition.Size = new FileInfo(attachmentFilename).Length;
                //    disposition.DispositionType = DispositionTypeNames.Attachment;
                //    message.Attachments.Add(attachment);
                //}
                //    client.Send(objeto_mail);
                //    MessageBox.Show("sent");
                //}
                //catch (Exception ex)
                //{
                //    MessageBox.Show(ex.ToString());
                //}

                //string path = @"C:\Users\GLORI\Desktop\Dropbox\应用\PromotorFile\PromotorSpeech\quiz.txt";
                //StreamReader quiz = new StreamReader(path);
                //string data = quiz.ReadToEnd();
                //quiz.Close();
                //char[] chs = { '/', '/' };
                //string[] quizData = data.Split(chs, StringSplitOptions.RemoveEmptyEntries);
                //if (quizData[2].Equals(quizData[3],StringComparison.OrdinalIgnoreCase)==true)
                //{
                //    MessageBox.Show("Test");
                //}




            }

      void haha(int x)
        {
            MessageBox.Show(x.ToString());
        }
    }
}

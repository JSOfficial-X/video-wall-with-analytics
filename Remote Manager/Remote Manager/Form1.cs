using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using ObooltNet;
using System.Net;
namespace Remote_Manager
{
    public partial class frmRemoteManager : Form
    {
        List<string> listFiles = new List<string>();
        NetConnection client;
        IPAddress ip = IPAddress.Parse("172.18.147.231");
        string currentSelection;
        public frmRemoteManager()
        {
            InitializeComponent();
        }
        #region Content Manager
        
        private void frmRemoteManager_Load(object sender, EventArgs e)
        {
            GetFiles(ProjectPath.defaultVideoPath);
            currentSelection = "Default Videos";
            this.Invoke(new MethodInvoker(delegate
            {
                lblCurrentSelection.Text = currentSelection;
            }));
            DisableAllEmergencyButton();
        }

        private void btnDefaultVideos_Click(object sender, EventArgs e)
        {
            GetFiles(ProjectPath.defaultVideoPath);
            currentSelection = "Default Videos";
            this.Invoke(new MethodInvoker(delegate
            {
                lblCurrentSelection.Text = currentSelection;
            }));
        }

        private void btnYouthMale_Click(object sender, EventArgs e)
        {
            GetFiles(ProjectPath.videoPathForMaleYouth);
            currentSelection = "Youth Male";
            this.Invoke(new MethodInvoker(delegate
            {
                lblCurrentSelection.Text = currentSelection;
            }));
        }

        private void btnAdultMale_Click(object sender, EventArgs e)
        {
            GetFiles(ProjectPath.videoPathForMaleMiddleAge);
            currentSelection = "Adult Male";
            this.Invoke(new MethodInvoker(delegate
            {
                lblCurrentSelection.Text = currentSelection;
            }));
        }

        private void btnSeniorMale_Click(object sender, EventArgs e)
        {
            GetFiles(ProjectPath.videoPathForSeniorMale);
            currentSelection = "Senior Female";
            this.Invoke(new MethodInvoker(delegate
            {
                lblCurrentSelection.Text = currentSelection;
            }));
        }

        private void btnYouthFemale_Click(object sender, EventArgs e)
        {
            GetFiles(ProjectPath.videoPathForFemaleYouth);
            currentSelection = "Youth Female";
            this.Invoke(new MethodInvoker(delegate
            {
                lblCurrentSelection.Text = currentSelection;
            }));
        }

        private void btnAdultFemale_Click(object sender, EventArgs e)
        {
            GetFiles(ProjectPath.videoPathForFemaleMiddleAge);
            currentSelection = "Adult Female";
            this.Invoke(new MethodInvoker(delegate
            {
                lblCurrentSelection.Text = currentSelection;
            }));
        }

        private void btnSeniorFemale_Click(object sender, EventArgs e)
        {
            GetFiles(ProjectPath.videoPathForSeniorFemale);
            currentSelection = "Senior Female";
            this.Invoke(new MethodInvoker(delegate
            {
                lblCurrentSelection.Text = currentSelection;
            }));
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog oFDUploader = new OpenFileDialog();
            
            if (oFDUploader.ShowDialog()==DialogResult.OK)
            {
                string fileName = oFDUploader.FileName;
                string file = Path.GetFileName(fileName);
                if (currentSelection=="Default Videos")
                {
                    //File.SetAttributes(fullFilePath, FileAttributes.Normal);
                    File.Copy(fileName, Path.Combine(ProjectPath.defaultVideoPath, file), true);
                    File.SetAttributes(Path.Combine(ProjectPath.defaultVideoPath, file),FileAttributes.Normal);
                   
                    GetFiles(ProjectPath.defaultVideoPath);
                }
                if (currentSelection == "Youth Male")
                {
                    File.Copy(fileName, Path.Combine(ProjectPath.videoPathForMaleYouth, file), true);
                    File.SetAttributes(Path.Combine(ProjectPath.videoPathForMaleYouth, file), FileAttributes.Normal);


                    GetFiles(ProjectPath.videoPathForMaleYouth);
                }
                if (currentSelection == "Adult Male")
                {
                    File.Copy(fileName, Path.Combine(ProjectPath.videoPathForMaleMiddleAge, file), true);
                    File.SetAttributes(Path.Combine(ProjectPath.videoPathForMaleMiddleAge, file), FileAttributes.Normal);


                    GetFiles(ProjectPath.videoPathForMaleMiddleAge);
                }
                if (currentSelection == "Senior Male")
                {
                    File.Copy(fileName, Path.Combine(ProjectPath.videoPathForSeniorMale, file), true);
                    File.SetAttributes(Path.Combine(ProjectPath.videoPathForSeniorMale, file), FileAttributes.Normal);


                    GetFiles(ProjectPath.videoPathForSeniorMale);
                }
                if (currentSelection == "Youth Female")
                {
                    File.Copy(fileName, Path.Combine(ProjectPath.videoPathForFemaleYouth, file), true);
                    File.SetAttributes(Path.Combine(ProjectPath.videoPathForFemaleYouth, file), FileAttributes.Normal);


                    GetFiles(ProjectPath.videoPathForFemaleYouth);
                }
                if (currentSelection == "Adult Female")
                {
                    File.Copy(fileName, Path.Combine(ProjectPath.videoPathForFemaleMiddleAge, file), true);
                    File.SetAttributes(Path.Combine(ProjectPath.videoPathForFemaleMiddleAge, file), FileAttributes.Normal);


                    GetFiles(ProjectPath.videoPathForFemaleMiddleAge);
                }
                if (currentSelection == "Senior Female")
                {
                    File.Copy(fileName, Path.Combine(ProjectPath.videoPathForSeniorFemale, file), true);
                    File.SetAttributes(Path.Combine(ProjectPath.videoPathForSeniorFemale, file), FileAttributes.Normal);


                    GetFiles(ProjectPath.videoPathForSeniorFemale);
                }
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult delete=MessageBox.Show("Delete All Files In "+currentSelection+"?","Delete",MessageBoxButtons.YesNo);
            if (delete == DialogResult.Yes)
            {
                try {
                    if (currentSelection == "Default Videos")
                    {
                        Array.ForEach(Directory.GetFiles(ProjectPath.defaultVideoPath),
                       delegate (string path) { File.Delete(path); });
                        GetFiles(ProjectPath.defaultVideoPath);
                    }
                    if (currentSelection == "Youth Male")
                    {
                        Array.ForEach(Directory.GetFiles(ProjectPath.videoPathForMaleYouth),
                     delegate (string path) { File.Delete(path); });
                        GetFiles(ProjectPath.videoPathForMaleYouth);
                    }
                    if (currentSelection == "Adult Male")
                    {
                        Array.ForEach(Directory.GetFiles(ProjectPath.videoPathForMaleMiddleAge),
                     delegate (string path) { File.Delete(path); });
                        GetFiles(ProjectPath.videoPathForMaleMiddleAge);
                    }
                    if (currentSelection == "Senior Male")
                    {
                        Array.ForEach(Directory.GetFiles(ProjectPath.videoPathForSeniorMale),
                    delegate (string path) { File.Delete(path); });
                        GetFiles(ProjectPath.videoPathForSeniorMale);
                    }
                    if (currentSelection == "Youth Female")
                    {
                        Array.ForEach(Directory.GetFiles(ProjectPath.videoPathForFemaleYouth),
                     delegate (string path) { File.Delete(path); });
                        GetFiles(ProjectPath.videoPathForFemaleYouth);
                    }
                    if (currentSelection == "Adult Female")
                    {
                        Array.ForEach(Directory.GetFiles(ProjectPath.videoPathForFemaleMiddleAge),
                     delegate (string path) { File.Delete(path); });
                        GetFiles(ProjectPath.videoPathForFemaleMiddleAge);
                    }
                    if (currentSelection == "Senior Female")
                    {
                        Array.ForEach(Directory.GetFiles(ProjectPath.videoPathForSeniorFemale),
                     delegate (string path) { File.Delete(path); });
                        GetFiles(ProjectPath.videoPathForSeniorMale);

                    }
                }
                catch
                {
                    MessageBox.Show("Files are emtpied");
                }
                
            }
            else if (delete == DialogResult.No)
            {
                //code for No
            }

        }
        private void GetFiles(string path)
        {
            if(path!=null)
            {
                listFiles.Clear();
                listView1.Items.Clear();
                foreach (string files in Directory.GetFiles(path))
                {
                    imageList1.Images.Add(Icon.ExtractAssociatedIcon(files));
                    listView1.LargeImageList = imageList1;
                    FileInfo fileInfo = new FileInfo(files);
                    listFiles.Add(fileInfo.FullName);
                    listView1.Items.Add(fileInfo.Name, imageList1.Images.Count - 1);
                }
            }

        }
        #endregion

        #region Emergency Remote
         
        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                client = new NetConnection();
                client.OnConnect += Client_OnConnect;
                client.OnDisconnect += Client_OnDisconnect;
                client.OnDataReceived += Client_OnDataReceived;
                client.Connect(ip, 8500);
              
            }
            catch
            {
                MessageBox.Show("Server not started");
            }
        }

        private void Client_OnDataReceived(object sender, NetConnection connection, byte[] e)
        {
          
        }

        private void Client_OnDisconnect(object sender, NetConnection connection)
        {
            DisableAllEmergencyButton();
        }

        private void Client_OnConnect(object sender, NetConnection connection)
        {
            EnableAllEmergencyButton();
        }

        private void DisableAllEmergencyButton()
        {
            btnSend.Enabled = false;
            btnStop.Enabled = false;
            btnReturn.Enabled = false;
            btnMaleFirst.Enabled = false;
            btnFemaleFirst.Enabled = false;
            if (btnConnect.Enabled==false)
            {
                btnConnect.Enabled = true;
            }
            lblConnectionStatus.Text = "Disconnected";
          
        }
        private void EnableAllEmergencyButton()
        {
            btnSend.Enabled = true;
            btnStop.Enabled = true;
            btnReturn.Enabled = false;
            btnMaleFirst.Enabled = false;
            btnFemaleFirst.Enabled = true;
            if (btnConnect.Enabled == true)
            {
                btnConnect.Enabled = false;
            }
            lblConnectionStatus.Text = "Connected";
        }
        
        private void btnSend_Click(object sender, EventArgs e)
        {
            try
            {
                client.OnDataReceived -= Client_OnDataReceived;
            }
            catch
            {

            }
            client.OnDataReceived += Client_OnDataReceived;
           // StringReader msgSent = new StringReader(richTxtMessage);
            client.Send(Encoding.UTF8.GetBytes(richTxtMessage.Text));
            richTxtMessage.Clear();
            btnSend.Enabled = false;
            btnReturn.Enabled = true;

        }

        private void btnReturn_Click(object sender, EventArgs e)
        {

            try
            {
                client.OnDataReceived -= Client_OnDataReceived;
            }
            catch
            {

            }
            client.OnDataReceived += Client_OnDataReceived;
            StringReader msgSent = new StringReader("Return");
            client.Send(Encoding.UTF8.GetBytes(msgSent.ReadLine()));
            btnSend.Enabled = true;
            btnReturn.Enabled = false;

        }

        private void btnStop_Click(object sender, EventArgs e)
        {

            try
            {
                client.OnDataReceived -= Client_OnDataReceived;
            }
            catch
            {

            }
            client.OnDataReceived += Client_OnDataReceived;
            StringReader msgSent = new StringReader("STOP");
            client.Send(Encoding.UTF8.GetBytes(msgSent.ReadLine()));
            
        }

        private void btnMaleFirst_Click(object sender, EventArgs e)
        {
            try
            {
                client.OnDataReceived -= Client_OnDataReceived;
            }
            catch
            {

            }
            client.OnDataReceived += Client_OnDataReceived;
            StringReader msgSent = new StringReader("male");
            client.Send(Encoding.UTF8.GetBytes(msgSent.ReadLine()));
            btnMaleFirst.Enabled = false;
            chkMaleFirst.Checked = true;
            chkFemaleFirst.Checked = false;
            btnFemaleFirst.Enabled = true;
        }

        private void btnFemaleFirst_Click(object sender, EventArgs e)
        {
            try
            {
                client.OnDataReceived -= Client_OnDataReceived;
            }
            catch
            {

            }
            client.OnDataReceived += Client_OnDataReceived;
            StringReader msgSent = new StringReader("female");
            client.Send(Encoding.UTF8.GetBytes(msgSent.ReadLine()));
            btnMaleFirst.Enabled = true;
            chkMaleFirst.Checked = false;
            chkFemaleFirst.Checked = true;
            btnFemaleFirst.Enabled = false;
        }
        #endregion

    }
}

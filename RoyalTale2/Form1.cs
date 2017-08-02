using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mime;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RoyalTale2
{
    public partial class Form1 : Form
    {
        FTPConnection _FTPConnection = new FTPConnection();
        string size = "Windowed";
        public Form1()
        {
            InitializeComponent(); 
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void updateButton_Click(object sender, EventArgs e)
        {
            if (updateOldMethodCheckBox.Checked == true)
            {
                this.updateProgressBar.Value = 0;
                string filelocation = filelocationBox.Text;
                if (filelocation != "")
                {
                    string[] files = _FTPConnection.GetFileList();
                    this.updateProgressBar.Maximum = files.Length;
                    var updating = new Thread(() =>
                    {
                        this.BeginInvoke(new Action(() =>
                        {
                            foreach (string x in files)
                            {

                                _FTPConnection.Download(x, filelocation.Substring(0, filelocation.LastIndexOf("\\")));
                                this.updateProgressBar.Increment(1);

                            }
                        }));
                    });
                    updating.Start();
                    MessageBox.Show("Download Complete");
                }
                else
                {
                    MessageBox.Show("Please Locate Game Location", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                this.updateProgressBar.Value = 0;
                string filelocation = filelocationBox.Text;
                if (filelocation != "")
                {
                    List<string> filenames = new List<string>();
                    List<string> URLs = new List<string>();
                    // AJJIYA.SPF
                    filenames.Add("AJJIYA.SPF");
                    URLs.Add(@"https://doc-0o-9c-docs.googleusercontent.com/docs/securesc/ehqpljql3e1tfalnotucne4a3ko9iqeg/etqniu4mgsjhj55j5a7vdhkso0rvenag/1501617600000/00490531678179985977/00490531678179985977/0B3kYR-z7_dXeVVFac0VMMk03cjQ?e=download");
                    // BANX.SPF
                    filenames.Add("BANX.SPF");
                    URLs.Add(@"https://doc-00-9c-docs.googleusercontent.com/docs/securesc/ehqpljql3e1tfalnotucne4a3ko9iqeg/1n8shg5o82fs7qr491d14e81ql9l8t18/1501617600000/00490531678179985977/00490531678179985977/0B3kYR-z7_dXeMm00b01ONlQyWUE?e=download");
                    // BARY.SPF
                    filenames.Add("BARY.SPF");
                    URLs.Add(@"https://doc-0g-9c-docs.googleusercontent.com/docs/securesc/ehqpljql3e1tfalnotucne4a3ko9iqeg/fqe2tnf27h2ctlvjgm3fh760a9gb0sqq/1501624800000/00490531678179985977/00490531678179985977/0B3kYR-z7_dXed1JXam1wTVlBQ2s?e=download");
                    // BERY.SPF
                    filenames.Add("BERY.SPF");
                    URLs.Add(@"https://doc-10-9c-docs.googleusercontent.com/docs/securesc/ehqpljql3e1tfalnotucne4a3ko9iqeg/m24vu0tlpndt59v1gggvp9emol3g7co4/1501624800000/00490531678179985977/00490531678179985977/0B3kYR-z7_dXeUVYzOWtXV1NnalU?e=download");
                    // BONGSUKS.SPF
                    filenames.Add("BONGSUKS.SPF");
                    URLs.Add(@"https://doc-08-9c-docs.googleusercontent.com/docs/securesc/ehqpljql3e1tfalnotucne4a3ko9iqeg/ajbquj056pb05hbq8hsq29k6snbfcjit/1501624800000/00490531678179985977/00490531678179985977/0B3kYR-z7_dXedzB0a3pOdHhqWDA?e=download");
                    // CLAIRE.SPF
                    filenames.Add("CLAIRE.SPF");
                    URLs.Add(@"https://doc-0c-9c-docs.googleusercontent.com/docs/securesc/ehqpljql3e1tfalnotucne4a3ko9iqeg/4um0he3chpf9ubrjp5kccv1upaaj3h3v/1501624800000/00490531678179985977/00490531678179985977/0B3kYR-z7_dXeMURLZXBXelVhVEk?e=download");
                    // DALBONG.SPF
                    filenames.Add("DALBONG.SPF");
                    URLs.Add(@"https://doc-0c-9c-docs.googleusercontent.com/docs/securesc/ehqpljql3e1tfalnotucne4a3ko9iqeg/km9p2skkb4o9bg5qlqml0qgehn3567rh/1501624800000/00490531678179985977/00490531678179985977/0B3kYR-z7_dXedTFad2JtUkJYMzA?e=download");
                    // GUSTAV.SPF
                    filenames.Add("GUSTAV.SPF");
                    URLs.Add(@"https://doc-00-9c-docs.googleusercontent.com/docs/securesc/ehqpljql3e1tfalnotucne4a3ko9iqeg/q346rfiujq04hl9um30vge3pmtevf53u/1501624800000/00490531678179985977/00490531678179985977/0B3kYR-z7_dXeNEhub3Y4OHVodnc?e=download");
                    // HOSHIM.SPF
                    filenames.Add("HOSHIM.SPF");
                    URLs.Add(@"https://doc-0s-9c-docs.googleusercontent.com/docs/securesc/ehqpljql3e1tfalnotucne4a3ko9iqeg/3bcqfa0t1lour6b57g0unpqp5j2761ja/1501624800000/00490531678179985977/00490531678179985977/0B3kYR-z7_dXeVC1MOFJwbGsxWWs?e=download");
                    // JINSSAGA.SPF
                    filenames.Add("JINSSAGA.SPF");
                    URLs.Add(@"https://doc-0c-9c-docs.googleusercontent.com/docs/securesc/ehqpljql3e1tfalnotucne4a3ko9iqeg/if3f34c66vp58l0ao1q8p2d96f04uvor/1501624800000/00490531678179985977/00490531678179985977/0B3kYR-z7_dXeazdJcGlwdDZObVE?e=download");
                    // JINXSAGA.SPF
                    filenames.Add("JINXSAGA.SPF");
                    URLs.Add(@"https://doc-0o-9c-docs.googleusercontent.com/docs/securesc/ehqpljql3e1tfalnotucne4a3ko9iqeg/ls60aboecpo9kjmhjp4p0gckf3ov3dv8/1501624800000/00490531678179985977/00490531678179985977/0B3kYR-z7_dXeMTIzTmZXY2hXNFU?e=download");
                    // JJENGE.SPF
                    filenames.Add("JJENGE.SPF");
                    URLs.Add(@"https://doc-0g-9c-docs.googleusercontent.com/docs/securesc/ehqpljql3e1tfalnotucne4a3ko9iqeg/baqsf6tttg6i06s8o2oq5r1h87pbaari/1501624800000/00490531678179985977/00490531678179985977/0B3kYR-z7_dXeb0lBNmlrMDRNZVE?e=download");
                    // JOOX2.SPF
                    filenames.Add("JOOX2.SPF");
                    URLs.Add(@"https://doc-14-9c-docs.googleusercontent.com/docs/securesc/ehqpljql3e1tfalnotucne4a3ko9iqeg/lj6jd0a5prsa3ri736ej3b8fqe4mljhc/1501624800000/00490531678179985977/00490531678179985977/0B3kYR-z7_dXeODNPbzI5WElYOWM?e=download");
                    // JOOX3.SPF
                    filenames.Add("JOOX3.SPF");
                    URLs.Add(@"https://doc-0g-9c-docs.googleusercontent.com/docs/securesc/ehqpljql3e1tfalnotucne4a3ko9iqeg/1l3logsighlb86ikq4g1s2539iqtqhmj/1501624800000/00490531678179985977/00490531678179985977/0B3kYR-z7_dXeOFFxNENnU1JOaVU?e=download");
                    // MAKO1298.SPF
                    filenames.Add("MAKO1298.SPF");
                    URLs.Add(@"https://doc-0k-9c-docs.googleusercontent.com/docs/securesc/ehqpljql3e1tfalnotucne4a3ko9iqeg/cks231pi7stk66glhk802hup22jlbs2d/1501624800000/00490531678179985977/00490531678179985977/0B3kYR-z7_dXeSkhjeWFzc0FuRDg?e=download");
                    // METALGENI.SPF
                    filenames.Add("METALGENI.SPF");
                    URLs.Add(@"https://doc-0c-9c-docs.googleusercontent.com/docs/securesc/ehqpljql3e1tfalnotucne4a3ko9iqeg/8c30ddl27d3gdqc9ktk4f0c54s1i5l7s/1501624800000/00490531678179985977/00490531678179985977/0B3kYR-z7_dXeWUFMUk9fbUxteHM?e=download");
                    // ROWED.SPF
                    filenames.Add("ROWED.SPF");
                    URLs.Add(@"https://doc-0s-9c-docs.googleusercontent.com/docs/securesc/ehqpljql3e1tfalnotucne4a3ko9iqeg/kc8rg55ng7gkvg3c26rad32r6vu27p0i/1501624800000/00490531678179985977/00490531678179985977/0B3kYR-z7_dXecTdWdl9kRWNUVDg?e=download");
                    // ROWID.SPF
                    filenames.Add("ROWID.SPF");
                    URLs.Add(@"https://doc-08-9c-docs.googleusercontent.com/docs/securesc/ehqpljql3e1tfalnotucne4a3ko9iqeg/jk4u3gp1jsv1rg2hp82q8v03f319icsl/1501624800000/00490531678179985977/00490531678179985977/0B3kYR-z7_dXeNlJscmQtUlZmQUU?e=download");
                    // RYUMS.SPF
                    filenames.Add("RYUMS.SPF");
                    URLs.Add(@"https://doc-0o-9c-docs.googleusercontent.com/docs/securesc/ehqpljql3e1tfalnotucne4a3ko9iqeg/vp1ibgi9336ugeok5gcr74re8nu92g4f/1501624800000/00490531678179985977/00490531678179985977/0B3kYR-z7_dXeVnBnZ0VtMWFoQXM?e=download");
                    // ZENNE.SPF
                    filenames.Add("ZENNE.SPF");
                    URLs.Add(@"https://doc-0s-9c-docs.googleusercontent.com/docs/securesc/ehqpljql3e1tfalnotucne4a3ko9iqeg/2j4i1pfa1073vs41b0r6nj0k7qqn0c2n/1501624800000/00490531678179985977/00490531678179985977/0B3kYR-z7_dXeaWppNXpYMEVLbzg?e=download");
                    this.updateProgressBar.Maximum = URLs.Count();
                    var updating = new Thread(() =>
                    {
                        this.BeginInvoke(new Action(() =>
                        {
                            for (int i = 0; i < URLs.Count(); i++)
                            {
                                var request = (HttpWebRequest)WebRequest.Create(URLs[i]);
                                request.Method = "HEAD";
                                var response = (HttpWebResponse)request.GetResponse();
                                WebClient wc = new WebClient();
                                if (File.Exists(filelocation.Substring(0, filelocation.LastIndexOf("\\")) + filenames[i]) == true)
                                {
                                    if (response.LastModified > File.GetLastWriteTime(filelocation.Substring(0, filelocation.LastIndexOf("\\")) + filenames[i]))
                                    {
                                        wc.DownloadFile(URLs[i], filelocation.Substring(0, filelocation.LastIndexOf("\\")) + filenames[i]);
                                    }
                                }
                                else
                                {
                                    wc.DownloadFile(URLs[i], filelocation.Substring(0, filelocation.LastIndexOf("\\")) + filenames[i]);
                                }
                                this.updateProgressBar.Increment(1);
                            }
                        }));
                    });
                    updating.Start();
                    MessageBox.Show("Download Complete");
                }
                else
                {
                    MessageBox.Show("Please Locate Game Location", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            string gameloc = filelocationBox.Text;
            string arg = "/Run:VLOW /" + size + " /LS:100.2.188.147:10000 /LOCALE:JAPAN /PUBLISHER:GAMEPOT";
            string start = "start " + gameloc + arg;
            if (!String.IsNullOrEmpty(gameloc))
            {
                ProcessStartInfo startInfo = new ProcessStartInfo(gameloc);

                startInfo.Arguments = arg;
                startInfo.WorkingDirectory = Path.GetDirectoryName(gameloc);

                System.Diagnostics.Process.Start(startInfo);
            }
            else
            {
                MessageBox.Show("Please Locate Game Location", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            filelocationBox.Text = Properties.Settings.Default.FileLoc;
        }

        private void portBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            DialogResult result = gameFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                string file = gameFileDialog.FileName;
                filelocationBox.Text = file;
            }
        }

        private void checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox.Checked == true)
            {
                size = "Full";
            }
            else
            {
                size = "Windowed";
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Properties.Settings.Default.FileLoc = filelocationBox.Text;
            Properties.Settings.Default.Save();
        }

        private void getClientButton_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://drive.google.com/file/d/0B7AGQiu1DaKgS01sV2NWLXdCdE0/view");
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            RegisterForm _RegisterForm = new RegisterForm();
            _RegisterForm.Show();
        }
    }
}

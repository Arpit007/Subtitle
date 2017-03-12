using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Subtitle
{
    public partial class Form1 : Form
    {
        private Process proc = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void moviePathButton_Click(object sender, EventArgs e)
        {
            Progress.Text = "No Ongoing Conversion";
            openFileDialog1.Title = "Select Movie"; 
            openFileDialog1.Filter= "Video files (*.mkv;*.mp4)|*.mkv;*.mp4";
            DialogResult dr = openFileDialog1.ShowDialog();
            if(dr== System.Windows.Forms.DialogResult.OK)
            {
                moviePath.Text = openFileDialog1.FileName;
                outputPath.Text = "";
                subsPath.Text = "";
            }
        }

        private void subsPathButton_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Select Subtitle";
            openFileDialog1.Filter = "Subtitle files (*.srt)|*.srt|All files (*.*)|*.*";
            DialogResult dr = openFileDialog1.ShowDialog();
            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                subsPath.Text = openFileDialog1.FileName;
            }
        }

        private void convertButton_Click(object sender, EventArgs e)
        {
            string mvPath = moviePath.Text;
            string subPath = subsPath.Text;
            string outPath = outputPath.Text;
            string extension = Path.GetExtension(mvPath);
           
            if (mvPath == "" || subPath == "" || outPath =="")
            {
                MessageBox.Show("All Fields are Mandatory", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string Command = "";
                if (extension == ".mkv")
                {
                    Command = "-i \"" + mvPath + "\" -sub_charenc CP1252 -i \"" + subPath + 
                        "\" -map 0:v -map 0:a -c copy -map 1 -c:s:0 srt -metadata:s:s:0 language=en \"" + outPath + "\"";
                }
                else
                {
                    Command = "-i \"" + mvPath + "\" -sub_charenc CP1252 -i \"" + subPath + 
                        "\" -map 0:v -map 0:a -c copy -map 1 -c:s:0 mov_text -metadata:s:s:0 language=en \"" + outPath+"\"";
                }
                try
                {
                    proc = Process.Start(new ProcessStartInfo { Arguments = Command, FileName = "ffmpeg", WindowStyle = ProcessWindowStyle.Hidden });
                    proc.EnableRaisingEvents = true;
                    Progress.Text = "Please Wait, Converting...";
                    moviePathButton.Enabled = false;
                    subsPathButton.Enabled = false;
                    outputPathButton.Enabled = false;
                    convertButton.Enabled = false;
                    proc.Exited += new EventHandler(onProcessExit);
                }
                catch(Exception ex)
                {
                    Progress.Text = "Failed";
                    moviePathButton.Enabled = true;
                    subsPathButton.Enabled = true;
                    outputPathButton.Enabled = true;
                    convertButton.Enabled = true;
                }
            }
        }

        private void onProcessExit(object sender, EventArgs e)
        {
            Invoke(new Action(() => {
                Progress.Text = "Conversion Complete";
                moviePathButton.Enabled = true;
                subsPathButton.Enabled = true;
                outputPathButton.Enabled = true;
                convertButton.Enabled = true;
            }));
        }

        private void outputPathButton_Click(object sender, EventArgs e)
        {
            if(moviePath.Text=="")
                MessageBox.Show("Select Movie First", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            else
            {
                string extension = Path.GetExtension(moviePath.Text);
                saveFileDialog1.Filter= "Video files (*"+extension+")|*"+extension;
                DialogResult dr = saveFileDialog1.ShowDialog();
                if(dr==DialogResult.OK)
                {
                    outputPath.Text = saveFileDialog1.FileName;
                }
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (proc != null && proc.HasExited == false)
            {
                proc.EnableRaisingEvents = true;
                proc.Kill();
                proc.WaitForExit();
                if (File.Exists(outputPath.Text))
                    File.Delete(outputPath.Text);
            }            
        }
    }
}


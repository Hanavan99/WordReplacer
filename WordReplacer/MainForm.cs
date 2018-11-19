using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace WordReplacer
{

    public partial class MainForm : Form
    {

        private ProgressForm progressForm;
        private Replacer<byte> replacer = new BinaryReplacer(0xFFFF);

        public MainForm()
        {
            InitializeComponent();
        }

        private void wxReplacementBrowse_Click(object sender, EventArgs e)
        {
            wxOpenFile.InitialDirectory = wxReplacementPath.Text;
            if (wxOpenFile.ShowDialog() == DialogResult.OK)
            {
                wxReplacementPath.Text = wxOpenFile.FileName;
            }
        }

        private void wxSourceBrowse_Click(object sender, EventArgs e)
        {
            wxOpenFile.InitialDirectory = wxSourcePath.Text;
            if (wxOpenFile.ShowDialog() == DialogResult.OK)
            {
                wxSourcePath.Text = wxOpenFile.FileName;
            }
        }

        private void wxDestBrowse_Click(object sender, EventArgs e)
        {
            wxSaveFile.InitialDirectory = wxDestPath.Text;
            if (wxSaveFile.ShowDialog() == DialogResult.OK)
            {
                wxDestPath.Text = wxSaveFile.FileName;
            }
        }

        private void wxCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void wxReplace_Click(object sender, EventArgs e)
        {
            Enabled = false;
            progressForm = new ProgressForm(this);
            progressForm.Show();
            progressForm.GetCancelButton().Click += (_sender, _e) => {
                wxBackgroundWorker.CancelAsync();
                progressForm.Close();
            };
            wxBackgroundWorker.RunWorkerAsync();
            progressForm.GetProgressLabel().Text = "Replacing...";
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            wxReplacementPath.Text = Properties.Settings.Default.replacementPath;
            wxSourcePath.Text = Properties.Settings.Default.sourcePath;
            wxDestPath.Text = Properties.Settings.Default.destPath;
            uxReplacementType.Text = Properties.Settings.Default.replacementType;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.replacementPath = wxReplacementPath.Text;
            Properties.Settings.Default.sourcePath = wxSourcePath.Text;
            Properties.Settings.Default.destPath = wxDestPath.Text;
            Properties.Settings.Default.replacementType = uxReplacementType.Text;
            Properties.Settings.Default.Save();
        }

        private void wxBackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
           
            

            // read all replacement definitions from file
            try
            {
                FileInfo replacementFileInfo = new FileInfo(wxReplacementPath.Text);
                long fileLength = replacementFileInfo.Length;

                FileStream replaceReader = new FileStream(wxReplacementPath.Text, FileMode.Open);

                Trie<byte> trie = replacer.ParseReplacementFile(replaceReader, 0x2C, new byte[] { 0x0D, 0x0A }); // use comma as delimiter with CRLF as line delimiter

                /*Dictionary<byte, Trie<byte>>.KeyCollection.Enumerator test = trie.Children.Keys.GetEnumerator();
                while (test.MoveNext())
                {
                    Console.WriteLine(test.Current);
                }*/

                FileStream sourceReader = new FileStream(wxSourcePath.Text, FileMode.Open);
                FileStream destWriter = new FileStream(wxDestPath.Text, FileMode.Create);

                replacer.Replace(sourceReader, destWriter, trie, null);
                

            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not open replacement word map file: " + ex.Message);
                Console.WriteLine(ex.StackTrace);
                return;
            }

            // write all data to the destination file
            /*try
            {
                FileStream destWriter = new FileStream(wxDestPath.Text, FileMode.Create);
                using (destWriter)
                {
                    try
                    {
                        // load source file to read from
                        StreamReader sourceReader;
                        if (uxInferFileEncoding.Checked)
                        {
                            sourceReader = new StreamReader(wxSourcePath.Text, true);
                            destFileEncoding = sourceReader.CurrentEncoding;
                        } else
                        {
                            sourceReader = new StreamReader(wxSourcePath.Text, sourceFileEncoding);
                        }
                         
                        FileInfo sourceFileInfo = new FileInfo(wxSourcePath.Text);
                        long fileLength = sourceFileInfo.Length;

                        using (sourceReader)
                        {
                            int progress = 0;
                            while (!sourceReader.EndOfStream)
                            {
                                if (wxBackgroundWorker.CancellationPending)
                                {
                                    break;
                                }
                                string line = sourceReader.ReadLine();
                                int i = 0;
                                foreach (KeyValuePair<string, string> item in map)
                                {
                                    if (wxBackgroundWorker.CancellationPending)
                                    {
                                        break;
                                    }
                                    line = Regex.Replace(line, item.Key, item.Value, wxCaseSensitive.Checked ? RegexOptions.None : RegexOptions.IgnoreCase);
                                    progress = (int)(((double)(sourceReader.BaseStream.Position * i) / (double)(fileLength * map.Count)) * 50) + 50;
                                    if (progressForm.GetProgressBar().Value != progress)
                                    {
                                        wxBackgroundWorker.ReportProgress(progress);
                                    }
                                    i++;
                                }
                                byte[] lineArray = destFileEncoding.GetBytes(line + "\n");
                                destWriter.Write(lineArray, 0, lineArray.Length);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Could not open source file: " + ex.Message);
                        return;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to save destination file: " + ex.Message);
                return;
            }*/

        }

        private void wxBackgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            MessageBox.Show("Replacement complete.");
            progressForm.Close();
            Enabled = true;
        }

        private void wxBackgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressForm.GetProgressBar().Value = e.ProgressPercentage;
        }

        private string[] getEncodingNames(EncodingInfo[] infos)
        {
            string[] names = new string[infos.Length];
            for (int i = 0; i < infos.Length; i++)
            {
                names[i] = infos[i].DisplayName;
            }
            return names;
        }

        private EncodingInfo getEncodingInfoFromString(string name, EncodingInfo[] infos)
        {
            for (int i = 0; i < infos.Length; i++)
            {
                if (infos[i].DisplayName == name)
                {
                    return infos[i];
                }
            }
            return null;
        }

        public BackgroundWorker GetBackgroundWorker()
        {
            return wxBackgroundWorker;
        }

        private void uxInferFileEncoding_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}

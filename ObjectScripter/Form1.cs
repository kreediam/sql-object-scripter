using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace ObjectScripter
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        private Profiles profiles = new Profiles();
        private string settingsFile = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData), @"ObjectScripter\Config.xml");

        public Form1(string[] args)
        {
            InitializeComponent();
            Size sz = Size;
            MinimumSize = sz;
            string objs = null;

            if (args.Length > 0)
            {
                foreach (string str in args)
                {
                    if (objs != null)
                        objs = objs + ", ";

                    objs = objs + "'" + str.Trim() + "'";
                    txtObjects.Text += str.Trim() + Environment.NewLine;
                }

                DoProcess();
                MessageBox.Show(this, "Finished scripting " + objs, "DB Object Scripter", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(0);
            }

            LoadProfiles();
        }

        private void DoProcess()
        {
            try
            {
                Scripter s = new Scripter();
                s.ServerName = txtServer.Text;
                s.DatabaseName = txtDb.Text;
                s.UserId = txtUser.Text;
                s.Password = txtPass.Text;
                s.OutputPath = txtOutput.Text;


                s.ScriptKeys = cbScriptKeys.Checked;
                s.ScriptPerms = cbScriptPerms.Checked;
                s.ScriptDrops = cbScriptDrops.Checked;
                s.SeparateOutput = cbSeparateOutput.Checked;

                Output("");

                s.Script(txtObjects.Lines);

                if (cbLaunchDir.Checked)
                    Launch();

                Output("Finished!");
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.ToString());
            }
        }

        private void Launch()
        {
            Process p = new Process();
            p.StartInfo.FileName = txtOutput.Text;
            p.Start();
        }

        private void Output(string status)
        {
            barStaticItem1.Caption = status;
            Application.DoEvents();
        }

        private void LoadProfiles()
        {
            try
            {
                if (settingsFile == "" || !File.Exists(settingsFile)) return;
                XmlSerializer mySerializer = new XmlSerializer(typeof(Profiles));
                FileStream stream = new FileStream(settingsFile, FileMode.Open);
                profiles = mySerializer.Deserialize(stream) as Profiles;
                stream.Close();

                foreach (string str in profiles.profiles.Keys)
                {
                    cbProfiles.Properties.Items.Add(str);
                }

                cbProfiles.SelectedIndex = 0;
            }
            catch
            {
            }
        }

        private void SaveProfiles()
        {
            try
            {
                if (settingsFile == "") return;

                string directory = new FileInfo(settingsFile).DirectoryName;
                if (!Directory.Exists(directory))
                    Directory.CreateDirectory(directory);

                FileStream stream = new FileStream(settingsFile, FileMode.Create);
                XmlSerializer mySerializer = new XmlSerializer(typeof(Profiles));

                Profile p = null;
                string profile = cbProfiles.Text;

                if (profiles.profiles.ContainsKey(profile))
                {
                    p = profiles.profiles[profile];
                }
                else
                {
                    p = new Profile();
                    profiles.profiles.Add(profile, p);
                    cbProfiles.Properties.Items.Add(profile);
                }

                p.ProfileName = profile;
                p.Server = txtServer.Text;
                p.DataBase = txtDb.Text;
                p.User = txtUser.Text;
                p.Password = txtPass.Text;
                p.OutputDir = txtOutput.Text;

                mySerializer.Serialize(stream, profiles);
                stream.Close();
            }
            catch
            {
            }
        }

        private void barBtnSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SaveProfiles();
        }

        private void barBtnDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void barBtnClear_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            txtObjects.Text = "";
        }

        private void barBtnStart_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DoProcess();
        }

        private void cbProfiles_SelectedIndexChanged(object sender, EventArgs e)
        {
            string profile = cbProfiles.Text;
            if (profiles.profiles.ContainsKey(profile))
            {
                Profile p = profiles.profiles[profile];
                txtServer.Text = p.Server;
                txtDb.Text = p.DataBase;
                txtUser.Text = p.User;
                txtPass.Text = p.Password;
                txtOutput.Text = p.OutputDir;
            }
            else
            {
                txtServer.Text = "";
                txtDb.Text = "";
                txtUser.Text = "";
                txtPass.Text = "";
                txtOutput.Text = "";
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace ObjectScripter
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        private Profiles profs = new Profiles();
        private string settingsFile = @"C:\kreed\Documents\KreedApps\Object Scripter.dat";

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
                profs = mySerializer.Deserialize(stream) as Profiles;
                stream.Close();

                foreach (string str in profs.profiles.Keys)
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

                if (profs.profiles.ContainsKey(profile))
                {
                    p = profs.profiles[profile];
                }
                else
                {
                    p = new Profile();
                    profs.profiles.Add(profile, p);
                    cbProfiles.Properties.Items.Add(profile);
                }

                p.ProfileName = profile;
                p.Server = txtServer.Text;
                p.DataBase = txtDb.Text;
                p.User = txtUser.Text;
                p.Password = txtPass.Text;
                p.OutputDir = txtOutput.Text;

                mySerializer.Serialize(stream, profs);
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
            if (profs.profiles.ContainsKey(profile))
            {
                Profile p = profs.profiles[profile];
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

    [Serializable]
    public class Profiles
    {
        public MyDictionary<string, Profile> profiles;

        public Profiles()
        {
            profiles = new MyDictionary<string, Profile>();
        }
    }

    [Serializable]
    public class Profile
    {
        public string ProfileName;
        public string Server;
        public string DataBase;
        public string User;
        public string Password;
        public string OutputDir;
    }

    [XmlRoot("dictionary")]
    public class MyDictionary<TKey, TValue> : Dictionary<TKey, TValue>, IXmlSerializable
    {
        public System.Xml.Schema.XmlSchema GetSchema()
        {
            return null;
        }

        public void ReadXml(System.Xml.XmlReader reader)
        {
            XmlSerializer keySerializer = new XmlSerializer(typeof(TKey));
            XmlSerializer valueSerializer = new XmlSerializer(typeof(TValue));
            bool wasEmpty = reader.IsEmptyElement;
            reader.Read();

            if (wasEmpty)
                return;

            while (reader.NodeType != System.Xml.XmlNodeType.EndElement)
            {
                reader.ReadStartElement("item");
                reader.ReadStartElement("key");
                TKey key = (TKey)keySerializer.Deserialize(reader);
                reader.ReadEndElement();
                reader.ReadStartElement("value");
                TValue value = (TValue)valueSerializer.Deserialize(reader);
                reader.ReadEndElement();
                this.Add(key, value);
                reader.ReadEndElement();
                reader.MoveToContent();
            }
            reader.ReadEndElement();
        }

        public void WriteXml(System.Xml.XmlWriter writer)
        {
            XmlSerializer keySerializer = new XmlSerializer(typeof(TKey));
            XmlSerializer valueSerializer = new XmlSerializer(typeof(TValue));

            foreach (TKey key in this.Keys)
            {
                writer.WriteStartElement("item");
                writer.WriteStartElement("key");
                keySerializer.Serialize(writer, key);
                writer.WriteEndElement();
                writer.WriteStartElement("value");
                TValue value = this[key];
                valueSerializer.Serialize(writer, value);
                writer.WriteEndElement();
                writer.WriteEndElement();
            }
        }
    }
}
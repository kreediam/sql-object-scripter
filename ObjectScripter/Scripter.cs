using System;
using System.Collections.Specialized;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Microsoft.SqlServer.Management.Smo;

namespace ObjectScripter
{
    public class Scripter
    {
        public string ServerName { get; set; }
        public string DatabaseName { get; set; }
        public string UserId { get; set; }
        public string Password { get; set; }
        public string OutputPath { get; set; }
        public bool ScriptKeys { get; set; }
        public bool ScriptPerms { get; set; }
        public bool ScriptDrops { get; set; }
        public bool SeparateOutput { get; set; }

        //Server[@Name='ST-DEVSQL\SQL2008R2']/Database[@Name='PriceSentinel']/StoredProcedure[@Name='CalculateSmoothedHistogram' and @Schema='dbo']
        //Server[@Name='ST-DEVSQL\SQL2008R2']/Database[@Name='PriceSentinel']/Table[@Name='tblOscillations' and @Schema='dbo']

        private string CalculateURN()
        {
            return string.Empty;
        }

        public void Script(string[] objectNames)
        {
            ScriptingOptions so = new ScriptingOptions();
            so.ClusteredIndexes = true;
            so.Default = true;
            so.Indexes = true;
            so.IncludeHeaders = true;
            so.DriAllKeys = true;
            so.Permissions = true;
            //so.AppendToFile = true;

            Server srv = new Server(this.ServerName);
            srv.ConnectionContext.LoginSecure = false;
            srv.ConnectionContext.Login = this.UserId;
            srv.ConnectionContext.Password = this.Password;
            //srv.ConnectionContext.ServerInstance = "";

            Database db = srv.Databases[this.DatabaseName];

            StringCollection sc = null;
            string outputFile = Path.Combine(this.OutputPath, "Script.sql");

            foreach (String objectName in objectNames)
            {
                if (String.IsNullOrWhiteSpace(objectName))
                    continue;

                IScriptable dbobject = this.GetObject(db, objectName);
                if (dbobject == null)
                    MessageBox.Show(db.Name + ":" + db.ID + " doesn't contain " + objectName);

                if (this.SeparateOutput)
                    outputFile = Path.Combine(this.OutputPath, objectName + ".sql");

                //todo: may not work when combining output into one file
                File.WriteAllLines(outputFile, sc.Cast<string>());
            }
        }

        private IScriptable GetObject(Database db, string name)
        {
            if (db.Tables.Contains(name))
                return db.Tables[name];

            if (db.Views.Contains(name))
                return db.Views[name];

            if (db.StoredProcedures.Contains(name))
                return db.StoredProcedures[name];

            if (db.Triggers.Contains(name))
                return db.Triggers[name];

            return null;
        }
    }
}
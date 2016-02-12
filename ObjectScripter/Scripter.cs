using System;
using System.Collections.Specialized;
using System.IO;
using System.Linq;
using Microsoft.SqlServer.Management.Smo;
using System.Windows.Forms;
using Microsoft.SqlServer.Management.Sdk.Sfc;

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
            Server srv = new Server(this.ServerName);
            srv.ConnectionContext.LoginSecure = false;
            srv.ConnectionContext.Login = this.UserId;
            srv.ConnectionContext.Password = this.Password;
            //srv.ConnectionContext.ServerInstance = "";

            Database db = srv.Databases[this.DatabaseName];


            var x = srv.GetSmoObject(new Urn(CalculateURN()));





            ScriptingOptions so = new ScriptingOptions();
            so.ClusteredIndexes = true;
            so.Default = true;
            so.Indexes = true;
            so.IncludeHeaders = true;
            so.DriAllKeys = true;
            so.Permissions = true;
            //so.AppendToFile = true;

            StringCollection sc = null;
            string outputFile = Path.Combine(this.OutputPath, "Script.sql"); 

            foreach (String objectName in objectNames)
            {
                if (String.IsNullOrWhiteSpace(objectName))
                    continue;

                var a = db.Tables[objectName];

                //todo: add support for other object types
                if (!db.StoredProcedures.Contains(objectName))
                    MessageBox.Show(db.Name + ":" + db.ID + " doesn't contain " + objectName);

                StoredProcedure sp = db.StoredProcedures[objectName];
                sc = sp.Script(so);

                var y = sp.Urn;

                if (this.SeparateOutput)
                    outputFile = Path.Combine(this.OutputPath, objectName + ".sql");

                //todo: may not work when combining output into one file
                File.WriteAllLines(outputFile, sc.Cast<string>());
            }
        }
    }


    //public class Scripter
    //{
    //    private SQLServerClass sqlServer;
    //    private Database dmodb;
    //    private StreamWriter writer;
    //    private string _server;
    //    private string _db;
    //    private string _uid;
    //    private string _pw;
    //    private string _outputDir;
    //    private bool _scriptKeys;
    //    private bool _scriptPerms;
    //    private bool _scriptDrops;
    //    private bool _separateOutput;

    //    public Scripter()
    //    {
    //        sqlServer = new SQLServerClass();
    //        //sqlServer.LoginSecure = true;
    //    }

    //    public void Connect()
    //    {
    //        sqlServer.Connect(_server, _uid, _pw);
    //    }

    //    public void Script(string objName)
    //    {
    //        DBObject obj;
    //        string filename = null;
    //        string sql = null;
    //        objName = objName.Trim();

    //        if (dmodb == null)
    //            throw new Exception("No source database.  Did you set the Database property?");

    //        try
    //        {
    //            if (_separateOutput)
    //                filename = _outputDir + "\\" + objName + ".sql";
    //            else
    //                writer = new StreamWriter(_outputDir + "\\ScriptOutput.sql", true);

    //            if (File.Exists(filename))
    //                File.SetAttributes(filename, FileAttributes.Normal);

    //            SQLDMO_SCRIPT_TYPE scriptType = SQLDMO_SCRIPT_TYPE.SQLDMOScript_Default;

    //            if (_scriptKeys)
    //                scriptType |= SQLDMO_SCRIPT_TYPE.SQLDMOScript_DRI_PrimaryKey;

    //            if (_scriptPerms)
    //                scriptType |= SQLDMO_SCRIPT_TYPE.SQLDMOScript_Permissions;

    //            if (_scriptDrops)
    //                scriptType |= SQLDMO_SCRIPT_TYPE.SQLDMOScript_Drops;

    //            obj = dmodb.GetObjectByName(objName, SQLDMO_OBJECT_TYPE.SQLDMOObj_AllDatabaseUserObjects, "dbo");
    //            sql = obj.Script(scriptType, filename, SQLDMO_SCRIPT2_TYPE.SQLDMOScript2_Default);

    //            if (writer != null && sql != null)
    //                writer.WriteLine(sql);

    //        }
    //        catch (Exception exp)
    //        {
    //            Console.WriteLine(exp.StackTrace);
    //            throw;
    //        }
    //        finally
    //        {
    //            if (writer != null)
    //                writer.Close();
    //        }
    //    }

    //    public String Server
    //    {
    //        set { _server = value; }
    //        get { return _server; }
    //    }

    //    public String Database
    //    {
    //        set
    //        {
    //            _db = value;
    //            foreach (SQLDMO.Database dbase in sqlServer.Databases)
    //            {
    //                if (dbase.Name.ToLower() == _db.ToLower())
    //                {
    //                    dmodb = dbase;
    //                    break;
    //                }
    //            }
    //        }
    //        get { return _db; }
    //    }

    //    public String UserId
    //    {
    //        set { _uid = value; }
    //        get { return _uid; }
    //    }

    //    public String Password
    //    {
    //        set { _pw = value; }
    //        get { return _pw; }
    //    }

    //    public String OutputPath
    //    {
    //        set { _outputDir = value; }
    //        get { return _outputDir; }
    //    }

    //    public bool ScriptKeys
    //    {
    //        set { _scriptKeys = value; }
    //        get { return _scriptKeys; }
    //    }

    //    public bool ScriptPerms
    //    {
    //        set { _scriptPerms = value; }
    //        get { return _scriptPerms; }
    //    }

    //    public bool ScriptDrops
    //    {
    //        set { _scriptDrops = value; }
    //        get { return _scriptDrops; }
    //    }

    //    public bool SeparateOutput
    //    {
    //        set { _separateOutput = value; }
    //        get { return _separateOutput; }
    //    }
    //}
}


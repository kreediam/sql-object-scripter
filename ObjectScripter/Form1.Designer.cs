namespace ObjectScripter
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtObjects = new DevExpress.XtraEditors.MemoEdit();
            this.txtServer = new DevExpress.XtraEditors.TextEdit();
            this.txtOutput = new DevExpress.XtraEditors.TextEdit();
            this.txtPass = new DevExpress.XtraEditors.TextEdit();
            this.txtUser = new DevExpress.XtraEditors.TextEdit();
            this.txtDb = new DevExpress.XtraEditors.TextEdit();
            this.cbProfiles = new DevExpress.XtraEditors.ComboBoxEdit();
            this.label7 = new System.Windows.Forms.Label();
            this.barManager1 = new DevExpress.XtraBars.BarManager();
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.barBtnSave = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnDelete = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnClear = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnStart = new DevExpress.XtraBars.BarButtonItem();
            this.barSubItem1 = new DevExpress.XtraBars.BarSubItem();
            this.cbLaunchDir = new DevExpress.XtraBars.BarCheckItem();
            this.cbSeparateOutput = new DevExpress.XtraBars.BarCheckItem();
            this.cbScriptKeys = new DevExpress.XtraBars.BarCheckItem();
            this.cbScriptPerms = new DevExpress.XtraBars.BarCheckItem();
            this.cbScriptDrops = new DevExpress.XtraBars.BarCheckItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barStaticItem1 = new DevExpress.XtraBars.BarStaticItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            ((System.ComponentModel.ISupportInitialize)(this.txtObjects.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtServer.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOutput.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPass.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUser.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDb.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbProfiles.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Database";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "User";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Password";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Database Objects";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 292);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Output Directory";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Server";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtObjects
            // 
            this.txtObjects.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtObjects.EditValue = "";
            this.txtObjects.Location = new System.Drawing.Point(109, 140);
            this.txtObjects.Margin = new System.Windows.Forms.Padding(0);
            this.txtObjects.Name = "txtObjects";
            this.txtObjects.Properties.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtObjects.Properties.WordWrap = false;
            this.txtObjects.Size = new System.Drawing.Size(210, 146);
            this.txtObjects.TabIndex = 11;
            // 
            // txtServer
            // 
            this.txtServer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtServer.Location = new System.Drawing.Point(109, 52);
            this.txtServer.Name = "txtServer";
            this.txtServer.Size = new System.Drawing.Size(210, 20);
            this.txtServer.TabIndex = 3;
            // 
            // txtOutput
            // 
            this.txtOutput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOutput.Location = new System.Drawing.Point(109, 288);
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(210, 20);
            this.txtOutput.TabIndex = 13;
            // 
            // txtPass
            // 
            this.txtPass.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPass.EditValue = "";
            this.txtPass.Location = new System.Drawing.Point(109, 118);
            this.txtPass.Name = "txtPass";
            this.txtPass.Properties.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(210, 20);
            this.txtPass.TabIndex = 9;
            // 
            // txtUser
            // 
            this.txtUser.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUser.Location = new System.Drawing.Point(109, 96);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(210, 20);
            this.txtUser.TabIndex = 7;
            // 
            // txtDb
            // 
            this.txtDb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDb.Location = new System.Drawing.Point(109, 74);
            this.txtDb.Name = "txtDb";
            this.txtDb.Size = new System.Drawing.Size(210, 20);
            this.txtDb.TabIndex = 5;
            // 
            // cbProfiles
            // 
            this.cbProfiles.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbProfiles.Location = new System.Drawing.Point(109, 30);
            this.cbProfiles.Name = "cbProfiles";
            this.cbProfiles.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbProfiles.Properties.Sorted = true;
            this.cbProfiles.Size = new System.Drawing.Size(210, 20);
            this.cbProfiles.TabIndex = 1;
            this.cbProfiles.SelectedIndexChanged += new System.EventHandler(this.cbProfiles_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Profile";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2,
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barStaticItem1,
            this.barBtnSave,
            this.barBtnDelete,
            this.barBtnClear,
            this.barBtnStart,
            this.barSubItem1,
            this.cbLaunchDir,
            this.cbSeparateOutput,
            this.cbScriptKeys,
            this.cbScriptPerms,
            this.cbScriptDrops});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 11;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar2
            // 
            this.bar2.BarName = "Custom 3";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barBtnSave),
            new DevExpress.XtraBars.LinkPersistInfo(this.barBtnDelete),
            new DevExpress.XtraBars.LinkPersistInfo(this.barBtnClear),
            new DevExpress.XtraBars.LinkPersistInfo(this.barBtnStart),
            new DevExpress.XtraBars.LinkPersistInfo(this.barSubItem1)});
            this.bar2.OptionsBar.AllowQuickCustomization = false;
            this.bar2.OptionsBar.DrawDragBorder = false;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Custom 3";
            // 
            // barBtnSave
            // 
            this.barBtnSave.Caption = "Sa&ve";
            this.barBtnSave.Id = 1;
            this.barBtnSave.Name = "barBtnSave";
            this.barBtnSave.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnSave_ItemClick);
            // 
            // barBtnDelete
            // 
            this.barBtnDelete.Caption = "&Delete";
            this.barBtnDelete.Id = 2;
            this.barBtnDelete.Name = "barBtnDelete";
            this.barBtnDelete.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnDelete_ItemClick);
            // 
            // barBtnClear
            // 
            this.barBtnClear.Caption = "&Clear";
            this.barBtnClear.Id = 3;
            this.barBtnClear.Name = "barBtnClear";
            this.barBtnClear.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnClear_ItemClick);
            // 
            // barBtnStart
            // 
            this.barBtnStart.Caption = "&Start";
            this.barBtnStart.Id = 4;
            this.barBtnStart.Name = "barBtnStart";
            this.barBtnStart.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnStart_ItemClick);
            // 
            // barSubItem1
            // 
            this.barSubItem1.Caption = "&Options";
            this.barSubItem1.Id = 5;
            this.barSubItem1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.cbLaunchDir),
            new DevExpress.XtraBars.LinkPersistInfo(this.cbSeparateOutput),
            new DevExpress.XtraBars.LinkPersistInfo(this.cbScriptKeys),
            new DevExpress.XtraBars.LinkPersistInfo(this.cbScriptPerms),
            new DevExpress.XtraBars.LinkPersistInfo(this.cbScriptDrops)});
            this.barSubItem1.Name = "barSubItem1";
            // 
            // cbLaunchDir
            // 
            this.cbLaunchDir.Caption = "Launch &Output Dir";
            this.cbLaunchDir.Checked = true;
            this.cbLaunchDir.Id = 6;
            this.cbLaunchDir.Name = "cbLaunchDir";
            // 
            // cbSeparateOutput
            // 
            this.cbSeparateOutput.Caption = "Separate Output &Files";
            this.cbSeparateOutput.Checked = true;
            this.cbSeparateOutput.Id = 7;
            this.cbSeparateOutput.Name = "cbSeparateOutput";
            // 
            // cbScriptKeys
            // 
            this.cbScriptKeys.Caption = "Script &Keys";
            this.cbScriptKeys.Checked = true;
            this.cbScriptKeys.Id = 8;
            this.cbScriptKeys.Name = "cbScriptKeys";
            // 
            // cbScriptPerms
            // 
            this.cbScriptPerms.Caption = "Script &Permissions";
            this.cbScriptPerms.Checked = true;
            this.cbScriptPerms.Id = 9;
            this.cbScriptPerms.Name = "cbScriptPerms";
            // 
            // cbScriptDrops
            // 
            this.cbScriptDrops.Caption = "Script &Drops";
            this.cbScriptDrops.Checked = true;
            this.cbScriptDrops.Id = 10;
            this.cbScriptDrops.Name = "cbScriptDrops";
            // 
            // bar3
            // 
            this.bar3.BarName = "Custom 4";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barStaticItem1)});
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Custom 4";
            // 
            // barStaticItem1
            // 
            this.barStaticItem1.Border = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.barStaticItem1.Id = 0;
            this.barStaticItem1.Name = "barStaticItem1";
            this.barStaticItem1.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 342);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbProfiles);
            this.Controls.Add(this.txtDb);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.txtServer);
            this.Controls.Add(this.txtObjects);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Database Object Scripter";
            ((System.ComponentModel.ISupportInitialize)(this.txtObjects.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtServer.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOutput.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPass.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUser.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDb.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbProfiles.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private DevExpress.XtraEditors.MemoEdit txtObjects;
        private DevExpress.XtraEditors.TextEdit txtServer;
        private DevExpress.XtraEditors.TextEdit txtOutput;
        private DevExpress.XtraEditors.TextEdit txtPass;
        private DevExpress.XtraEditors.TextEdit txtUser;
        private DevExpress.XtraEditors.TextEdit txtDb;
        private DevExpress.XtraEditors.ComboBoxEdit cbProfiles;
        private System.Windows.Forms.Label label7;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarStaticItem barStaticItem1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem barBtnSave;
        private DevExpress.XtraBars.BarButtonItem barBtnDelete;
        private DevExpress.XtraBars.BarButtonItem barBtnClear;
        private DevExpress.XtraBars.BarButtonItem barBtnStart;
        private DevExpress.XtraBars.BarSubItem barSubItem1;
        private DevExpress.XtraBars.BarCheckItem cbLaunchDir;
        private DevExpress.XtraBars.BarCheckItem cbSeparateOutput;
        private DevExpress.XtraBars.BarCheckItem cbScriptKeys;
        private DevExpress.XtraBars.BarCheckItem cbScriptPerms;
        private DevExpress.XtraBars.BarCheckItem cbScriptDrops;
    }
}


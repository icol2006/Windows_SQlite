namespace appSqliteManagerPro
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dataBaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openDataBase = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.ExportDatabaseToSQL = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.executeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.trvTables = new System.Windows.Forms.TreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgvTableInfo = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.primarykey = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbpData = new System.Windows.Forms.TabPage();
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.tbQuerys = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.lblRecordAfected = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtQuery = new ScintillaNET.Scintilla();
            this.dgvQueryResults = new System.Windows.Forms.DataGridView();
            this.lblRegAfe = new System.Windows.Forms.Label();
            this.btnExecuteQuery = new System.Windows.Forms.Button();
            this.ctxOpcionoes = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.ddeleteTableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.renameTableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.exportTableToSQLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.tstExecuteQuery = new System.Windows.Forms.ToolStripButton();
            this.tstSaveQuery = new System.Windows.Forms.ToolStripButton();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTable = new System.Windows.Forms.Label();
            this.bgwkExecuteSql = new System.ComponentModel.BackgroundWorker();
            this.bgwkCargarDgvDatos = new System.ComponentModel.BackgroundWorker();
            this.bgwkExportSQL = new System.ComponentModel.BackgroundWorker();
            this.ctxDataGridview = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem8 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTableInfo)).BeginInit();
            this.tbpData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            this.tbQuerys.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuery)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQueryResults)).BeginInit();
            this.ctxOpcionoes.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.ctxDataGridview.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.AliceBlue;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dataBaseToolStripMenuItem,
            this.toolStripMenuItem4,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(1029, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dataBaseToolStripMenuItem
            // 
            this.dataBaseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openDataBase,
            this.toolStripMenuItem2,
            this.ExportDatabaseToSQL,
            this.closeToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.dataBaseToolStripMenuItem.Name = "dataBaseToolStripMenuItem";
            this.dataBaseToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.dataBaseToolStripMenuItem.Text = "Database";
            // 
            // openDataBase
            // 
            this.openDataBase.Name = "openDataBase";
            this.openDataBase.Size = new System.Drawing.Size(196, 22);
            this.openDataBase.Text = "Open Database";
            this.openDataBase.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(196, 22);
            this.toolStripMenuItem2.Text = "New Database";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // ExportDatabaseToSQL
            // 
            this.ExportDatabaseToSQL.Name = "ExportDatabaseToSQL";
            this.ExportDatabaseToSQL.Size = new System.Drawing.Size(196, 22);
            this.ExportDatabaseToSQL.Text = "Export Database to SQL";
            this.ExportDatabaseToSQL.Click += new System.EventHandler(this.ExportDatabaseToSQL_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.closeToolStripMenuItem.Text = "Close Database";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.executeToolStripMenuItem});
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(40, 20);
            this.toolStripMenuItem4.Text = "SQL";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Enabled = false;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // executeToolStripMenuItem
            // 
            this.executeToolStripMenuItem.Enabled = false;
            this.executeToolStripMenuItem.Name = "executeToolStripMenuItem";
            this.executeToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.executeToolStripMenuItem.Text = "Execute";
            this.executeToolStripMenuItem.Click += new System.EventHandler(this.executeToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.helpToolStripMenuItem.Text = "About";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.splitContainer1.Location = new System.Drawing.Point(3, 102);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.trvTables);
            this.splitContainer1.Panel1MinSize = 250;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tabControl1);
            this.splitContainer1.Size = new System.Drawing.Size(1017, 533);
            this.splitContainer1.SplitterDistance = 250;
            this.splitContainer1.TabIndex = 5;
            // 
            // trvTables
            // 
            this.trvTables.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trvTables.BackColor = System.Drawing.Color.LightGray;
            this.trvTables.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trvTables.ForeColor = System.Drawing.Color.Black;
            this.trvTables.ImageIndex = 0;
            this.trvTables.ImageList = this.imageList1;
            this.trvTables.Location = new System.Drawing.Point(0, -4);
            this.trvTables.Name = "trvTables";
            this.trvTables.SelectedImageIndex = 0;
            this.trvTables.Size = new System.Drawing.Size(250, 533);
            this.trvTables.TabIndex = 0;
            this.trvTables.MouseClick += new System.Windows.Forms.MouseEventHandler(this.trvTables_MouseClick);
            this.trvTables.MouseDown += new System.Windows.Forms.MouseEventHandler(this.trvTables_MouseDown);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Double-J-Design-Ravenna-3d-Database-Active.ico");
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tbpData);
            this.tabControl1.Controls.Add(this.tbQuerys);
            this.tabControl1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(2, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(762, 527);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 4;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            this.tabControl1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tabControl1_MouseClick);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgvTableInfo);
            this.tabPage2.Location = new System.Drawing.Point(4, 28);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(754, 495);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Table Structure";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvTableInfo
            // 
            this.dgvTableInfo.AllowUserToAddRows = false;
            this.dgvTableInfo.AllowUserToDeleteRows = false;
            this.dgvTableInfo.AllowUserToResizeRows = false;
            this.dgvTableInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTableInfo.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvTableInfo.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTableInfo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTableInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTableInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.Column1,
            this.type,
            this.primarykey});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTableInfo.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTableInfo.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvTableInfo.Location = new System.Drawing.Point(3, 3);
            this.dgvTableInfo.Name = "dgvTableInfo";
            this.dgvTableInfo.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTableInfo.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvTableInfo.RowHeadersVisible = false;
            this.dgvTableInfo.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dgvTableInfo.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.SystemColors.Desktop;
            this.dgvTableInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvTableInfo.Size = new System.Drawing.Size(748, 489);
            this.dgvTableInfo.TabIndex = 4;
            this.dgvTableInfo.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvTableInfo_CellMouseClick);
            this.dgvTableInfo.SelectionChanged += new System.EventHandler(this.dgvTableInfo_SelectionChanged);
            this.dgvTableInfo.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dgvTableInfo_KeyUp);
            this.dgvTableInfo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dgvTableInfo_MouseDown);
            // 
            // id
            // 
            this.id.DataPropertyName = "cid";
            this.id.HeaderText = "Column Id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 150;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "name";
            this.Column1.HeaderText = "Column Name";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 150;
            // 
            // type
            // 
            this.type.DataPropertyName = "type";
            this.type.HeaderText = "Column Type";
            this.type.Name = "type";
            this.type.ReadOnly = true;
            this.type.Width = 150;
            // 
            // primarykey
            // 
            this.primarykey.DataPropertyName = "pk";
            this.primarykey.HeaderText = "Primary Key";
            this.primarykey.Name = "primarykey";
            this.primarykey.ReadOnly = true;
            this.primarykey.Width = 150;
            // 
            // tbpData
            // 
            this.tbpData.BackColor = System.Drawing.SystemColors.Control;
            this.tbpData.Controls.Add(this.dgvDatos);
            this.tbpData.Location = new System.Drawing.Point(4, 28);
            this.tbpData.Name = "tbpData";
            this.tbpData.Padding = new System.Windows.Forms.Padding(3);
            this.tbpData.Size = new System.Drawing.Size(754, 495);
            this.tbpData.TabIndex = 0;
            this.tbpData.Text = "Data";
            // 
            // dgvDatos
            // 
            this.dgvDatos.AllowUserToAddRows = false;
            this.dgvDatos.AllowUserToDeleteRows = false;
            this.dgvDatos.AllowUserToResizeRows = false;
            this.dgvDatos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDatos.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvDatos.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDatos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDatos.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvDatos.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvDatos.Location = new System.Drawing.Point(3, -5);
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDatos.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvDatos.RowHeadersVisible = false;
            this.dgvDatos.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dgvDatos.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvDatos.Size = new System.Drawing.Size(748, 494);
            this.dgvDatos.TabIndex = 9;
            this.dgvDatos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDatos_CellClick);
            this.dgvDatos.SelectionChanged += new System.EventHandler(this.dgvDatos_SelectionChanged);
            this.dgvDatos.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dgvDatos_KeyUp);
            this.dgvDatos.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dgvDatos_MouseDown);
            // 
            // tbQuerys
            // 
            this.tbQuerys.BackColor = System.Drawing.Color.LightGray;
            this.tbQuerys.Controls.Add(this.button2);
            this.tbQuerys.Controls.Add(this.lblRecordAfected);
            this.tbQuerys.Controls.Add(this.label2);
            this.tbQuerys.Controls.Add(this.txtQuery);
            this.tbQuerys.Controls.Add(this.dgvQueryResults);
            this.tbQuerys.Controls.Add(this.lblRegAfe);
            this.tbQuerys.Controls.Add(this.btnExecuteQuery);
            this.tbQuerys.Location = new System.Drawing.Point(4, 28);
            this.tbQuerys.Name = "tbQuerys";
            this.tbQuerys.Padding = new System.Windows.Forms.Padding(3);
            this.tbQuerys.Size = new System.Drawing.Size(754, 495);
            this.tbQuerys.TabIndex = 2;
            this.tbQuerys.Text = "Execute SQL";
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(284, 469);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(162, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "Export Results to CVS";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // lblRecordAfected
            // 
            this.lblRecordAfected.AutoSize = true;
            this.lblRecordAfected.Location = new System.Drawing.Point(132, 192);
            this.lblRecordAfected.Name = "lblRecordAfected";
            this.lblRecordAfected.Size = new System.Drawing.Size(15, 16);
            this.lblRecordAfected.TabIndex = 11;
            this.lblRecordAfected.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Records Afected";
            // 
            // txtQuery
            // 
            this.txtQuery.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtQuery.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtQuery.ConfigurationManager.Language = "mssql";
            this.txtQuery.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuery.Location = new System.Drawing.Point(0, 0);
            this.txtQuery.Name = "txtQuery";
            this.txtQuery.Size = new System.Drawing.Size(751, 186);
            this.txtQuery.Styles.BraceBad.Size = 11F;
            this.txtQuery.Styles.BraceLight.Size = 11F;
            this.txtQuery.Styles.CallTip.FontName = "Segoe U";
            this.txtQuery.Styles.ControlChar.Size = 11F;
            this.txtQuery.Styles.Default.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtQuery.Styles.Default.Size = 11F;
            this.txtQuery.Styles.IndentGuide.Size = 11F;
            this.txtQuery.Styles.LastPredefined.Size = 11F;
            this.txtQuery.Styles.LineNumber.Size = 11F;
            this.txtQuery.Styles.Max.Size = 11F;
            this.txtQuery.TabIndex = 9;
            // 
            // dgvQueryResults
            // 
            this.dgvQueryResults.AllowUserToAddRows = false;
            this.dgvQueryResults.AllowUserToDeleteRows = false;
            this.dgvQueryResults.AllowUserToResizeRows = false;
            this.dgvQueryResults.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvQueryResults.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvQueryResults.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvQueryResults.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvQueryResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvQueryResults.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvQueryResults.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvQueryResults.Location = new System.Drawing.Point(0, 221);
            this.dgvQueryResults.Name = "dgvQueryResults";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvQueryResults.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvQueryResults.RowHeadersVisible = false;
            this.dgvQueryResults.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dgvQueryResults.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvQueryResults.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvQueryResults.Size = new System.Drawing.Size(747, 243);
            this.dgvQueryResults.TabIndex = 8;
            this.dgvQueryResults.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dgvQueryResults_KeyUp);
            this.dgvQueryResults.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dgvQueryResults_MouseDown);
            // 
            // lblRegAfe
            // 
            this.lblRegAfe.AutoSize = true;
            this.lblRegAfe.ForeColor = System.Drawing.Color.Lime;
            this.lblRegAfe.Location = new System.Drawing.Point(19, 259);
            this.lblRegAfe.Name = "lblRegAfe";
            this.lblRegAfe.Size = new System.Drawing.Size(0, 16);
            this.lblRegAfe.TabIndex = 7;
            // 
            // btnExecuteQuery
            // 
            this.btnExecuteQuery.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExecuteQuery.Location = new System.Drawing.Point(284, 192);
            this.btnExecuteQuery.Name = "btnExecuteQuery";
            this.btnExecuteQuery.Size = new System.Drawing.Size(162, 23);
            this.btnExecuteQuery.TabIndex = 6;
            this.btnExecuteQuery.Text = "Execute query";
            this.btnExecuteQuery.UseVisualStyleBackColor = true;
            this.btnExecuteQuery.Click += new System.EventHandler(this.btnExecuteQuery_Click);
            // 
            // ctxOpcionoes
            // 
            this.ctxOpcionoes.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem6,
            this.toolStripMenuItem1,
            this.toolStripMenuItem7,
            this.toolStripMenuItem5,
            this.ddeleteTableToolStripMenuItem,
            this.renameTableToolStripMenuItem,
            this.toolStripMenuItem3,
            this.exportTableToSQLToolStripMenuItem});
            this.ctxOpcionoes.Name = "contextMenuStrip1";
            this.ctxOpcionoes.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.ctxOpcionoes.ShowImageMargin = false;
            this.ctxOpcionoes.Size = new System.Drawing.Size(150, 180);
            this.ctxOpcionoes.Text = "Export table";
            this.ctxOpcionoes.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening_1);
            this.ctxOpcionoes.Click += new System.EventHandler(this.contextMenuStrip1_Click);
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(149, 22);
            this.toolStripMenuItem6.Text = "Sintax - Select";
            this.toolStripMenuItem6.Click += new System.EventHandler(this.toolStripMenuItem6_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(149, 22);
            this.toolStripMenuItem1.Text = "Sintax - Create";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click_1);
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.Size = new System.Drawing.Size(149, 22);
            this.toolStripMenuItem7.Text = "Sintax - Update";
            this.toolStripMenuItem7.Click += new System.EventHandler(this.toolStripMenuItem7_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(149, 22);
            this.toolStripMenuItem5.Text = "Sintax - Insert";
            this.toolStripMenuItem5.Click += new System.EventHandler(this.toolStripMenuItem5_Click);
            // 
            // ddeleteTableToolStripMenuItem
            // 
            this.ddeleteTableToolStripMenuItem.Name = "ddeleteTableToolStripMenuItem";
            this.ddeleteTableToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.ddeleteTableToolStripMenuItem.Text = "Delete Table";
            this.ddeleteTableToolStripMenuItem.Click += new System.EventHandler(this.ddeleteTableToolStripMenuItem_Click);
            // 
            // renameTableToolStripMenuItem
            // 
            this.renameTableToolStripMenuItem.Name = "renameTableToolStripMenuItem";
            this.renameTableToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.renameTableToolStripMenuItem.Text = "Rename Table";
            this.renameTableToolStripMenuItem.Click += new System.EventHandler(this.renameTableToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(149, 22);
            this.toolStripMenuItem3.Text = "Export table to CSV";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // exportTableToSQLToolStripMenuItem
            // 
            this.exportTableToSQLToolStripMenuItem.Name = "exportTableToSQLToolStripMenuItem";
            this.exportTableToSQLToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.exportTableToSQLToolStripMenuItem.Text = "Export table to SQL";
            this.exportTableToSQLToolStripMenuItem.Click += new System.EventHandler(this.exportTableToSQLToolStripMenuItem_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(745, 102);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(0, 0);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.ControlText;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton3,
            this.tstExecuteQuery,
            this.tstSaveQuery});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1029, 55);
            this.toolStrip1.TabIndex = 8;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(52, 52);
            this.toolStripButton1.Text = "Open Database";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(52, 52);
            this.toolStripButton2.Text = "New Database";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(52, 52);
            this.toolStripButton3.Text = "Close Database";
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // tstExecuteQuery
            // 
            this.tstExecuteQuery.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tstExecuteQuery.Enabled = false;
            this.tstExecuteQuery.Image = ((System.Drawing.Image)(resources.GetObject("tstExecuteQuery.Image")));
            this.tstExecuteQuery.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tstExecuteQuery.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tstExecuteQuery.Name = "tstExecuteQuery";
            this.tstExecuteQuery.Size = new System.Drawing.Size(52, 52);
            this.tstExecuteQuery.Text = "Execute SQL";
            this.tstExecuteQuery.Click += new System.EventHandler(this.tstExecuteQuery_Click);
            // 
            // tstSaveQuery
            // 
            this.tstSaveQuery.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tstSaveQuery.Enabled = false;
            this.tstSaveQuery.Image = ((System.Drawing.Image)(resources.GetObject("tstSaveQuery.Image")));
            this.tstSaveQuery.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tstSaveQuery.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tstSaveQuery.Name = "tstSaveQuery";
            this.tstSaveQuery.Size = new System.Drawing.Size(52, 52);
            this.tstSaveQuery.Text = "Save sql";
            this.tstSaveQuery.Click += new System.EventHandler(this.tstSaveQuery_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(-1, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Database";
            // 
            // lblTable
            // 
            this.lblTable.AutoSize = true;
            this.lblTable.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, System.Drawing.FontStyle.Bold);
            this.lblTable.Location = new System.Drawing.Point(381, 79);
            this.lblTable.Name = "lblTable";
            this.lblTable.Size = new System.Drawing.Size(64, 20);
            this.lblTable.TabIndex = 9;
            this.lblTable.Text = "Table";
            // 
            // bgwkExecuteSql
            // 
            this.bgwkExecuteSql.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bkgwExecuteSql_DoWork);
            this.bgwkExecuteSql.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bkgwExecuteSql_RunWorkerCompleted);
            // 
            // bgwkCargarDgvDatos
            // 
            this.bgwkCargarDgvDatos.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwkCargarDgvDatos_DoWork);
            this.bgwkCargarDgvDatos.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwkCargarDgvDatos_RunWorkerCompleted);
            // 
            // bgwkExportSQL
            // 
            this.bgwkExportSQL.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwkExportSQL_DoWork);
            this.bgwkExportSQL.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwkExportSQL_RunWorkerCompleted);
            // 
            // ctxDataGridview
            // 
            this.ctxDataGridview.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem8});
            this.ctxDataGridview.Name = "ctxDataGridview";
            this.ctxDataGridview.Size = new System.Drawing.Size(140, 26);
            // 
            // toolStripMenuItem8
            // 
            this.toolStripMenuItem8.Name = "toolStripMenuItem8";
            this.toolStripMenuItem8.Size = new System.Drawing.Size(139, 22);
            this.toolStripMenuItem8.Text = "Copy Values";
            this.toolStripMenuItem8.Click += new System.EventHandler(this.toolStripMenuItem8_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1029, 639);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTable);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Windows SQlite";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTableInfo)).EndInit();
            this.tbpData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            this.tbQuerys.ResumeLayout(false);
            this.tbQuerys.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuery)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQueryResults)).EndInit();
            this.ctxOpcionoes.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ctxDataGridview.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dataBaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openDataBase;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TreeView trvTables;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tbQuerys;
        private System.Windows.Forms.Button btnExecuteQuery;
        private System.Windows.Forms.Label lblRegAfe;
        private System.Windows.Forms.DataGridView dgvQueryResults;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip ctxOpcionoes;
        private System.Windows.Forms.FontDialog fontDialog1;
        private ScintillaNET.Scintilla txtQuery;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton tstExecuteQuery;
        private System.Windows.Forms.TabPage tbpData;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.Label lblRecordAfected;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTable;
        private System.Windows.Forms.DataGridView dgvDatos;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem renameTableToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ddeleteTableToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton tstSaveQuery;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem executeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportTableToSQLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExportDatabaseToSQL;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dgvTableInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn type;
        private System.Windows.Forms.DataGridViewTextBoxColumn primarykey;
        private System.ComponentModel.BackgroundWorker bgwkExecuteSql;
        private System.ComponentModel.BackgroundWorker bgwkCargarDgvDatos;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem7;
        private System.ComponentModel.BackgroundWorker bgwkExportSQL;
        private System.Windows.Forms.ContextMenuStrip ctxDataGridview;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem8;
    }
}


#region Copyright & License Information
﻿/*
 * Copyright 2014 Maykol Alvarado P
 * This file is part of windows sqlite which is free software. It is made
 * available to you under the terms of the GNU General Public License
 * as published by the Free Software Foundation. For more information,
 * see COPYING.
 */
﻿#endregion

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using appSqliteManagerPro.Clases;
using System.IO;
using System.Diagnostics;
using appSqliteAdmin.Clases;
using System.Text.RegularExpressions;
using appSqliteAdmin;

namespace appSqliteManagerPro
{
    public partial class Form1 : Form
    {
        String databaseName = "";
        String tableName = "";
        DatabaseSqlite oDatabaseSqlite;
        List<String> listTables = new List<string>();
        List<String> listColumsTypes = new List<string>();
        List<String> listColumsNames = new List<string>();
        String[] StructureTable = new String[6];
        String queryType = "";
        String record_Selected = "";
        String query = "";
        String columnPrimaryKey = "", valuePrimaryKey = "";
        String[] columnStructure = new String[5];
        int rowsAfected = 0;
        DataGridViewCell ActiveCell = null;
        string startupPath;
        List<String> listColumsSelect = new List<string>();
        List<String> listColumsFilter = new List<string>();
        String columnType = "";
        List<String[]> listDataStructureTable = new List<String[]>();
        String filenameSQl = "";
        Archivos oArchivos = new Archivos();
        String sintax = "";
        string result = "";
        string[] listQuerys;
        frmProcessing ofrmProcessingDgvSqlQuery;
        frmProcessing ofrmProcessingDgvData;
        frmProcessing ofrmProcessingExportSQL;
        delegate void updateDelegate(DataTable val);
        delegate void updateDelegateoFrmProcessingDgvSqlQuery();
        


        public Form1()
        {
            InitializeComponent();
            dgvTableInfo.AutoGenerateColumns = false;
            tabControl1.Enabled = false;
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {

            openDatabase();

        }


        public void openDatabase()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.FilterIndex = 2;
            openFileDialog.RestoreDirectory = true;
            openFileDialog.Title = "Search SQlite files";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    closeDatabase();

                    this.oDatabaseSqlite = new DatabaseSqlite();

                    this.trvTables.Nodes.Clear();
                    this.trvTables.Refresh();

                    this.databaseName = openFileDialog.FileName.ToString();
                    this.showTables();
                    if (trvTables.Nodes.Count > 0)
                    {
                        TreeNode selectedNode = this.trvTables.Nodes[0];
                        this.trvTables.SelectedNode = selectedNode;
                        this.tableName = this.trvTables.SelectedNode.Text;
                        //this.refresh_dgvDatos();
                        refresh_dgvEstructura();
                        lblTable.Text = "TABLE - " + tableName;
                        startupPath = Path.GetFullPath("sqlite3.exe");
                        
                    }

                    tabControl1.Enabled = true;

                    this.Text = "SQlite Administrator - " + this.databaseName;


                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error\n" + ex.Message);
                }
            }
            this.dgvDatos.ColumnHeadersDefaultCellStyle.BackColor = Color.Blue;
        }


        public void showTables()
        {
            this.trvTables.Nodes.Clear();
            this.trvTables.Refresh();
            this.oDatabaseSqlite = new DatabaseSqlite(this.databaseName);
            this.listTables = this.oDatabaseSqlite.listTables_List();
            foreach (string current in this.listTables)
            {
                this.trvTables.Nodes.Add(current);
            }

            /*  if(trvTables.Nodes.Count==0){
                  dgvDatos.DataSource = null;
                  dgvTableInfo.DataSource = null;
              }*/
        }

        private void dgvTablas_Click(object sender, EventArgs e)
        {
        }

        private void dgvTablas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            closeDatabase();
        }

        public void closeDatabase()
        {
            this.dgvDatos.DataSource = null;
            this.dgvDatos.Rows.Clear();
            this.dgvDatos.Refresh();
            this.trvTables.Nodes.Clear();
            this.dgvQueryResults.DataSource = null;
            this.dgvQueryResults.Rows.Clear();
            this.dgvQueryResults.Refresh();
            this.dgvTableInfo.DataSource = null;
            this.dgvTableInfo.Rows.Clear();
            this.dgvTableInfo.Refresh();
            this.txtQuery.Text = "";
            tabControl1.Enabled = false;
            tabControl1.SelectedIndex = 0;

            this.lblRecordAfected.Text = "0";
            this.Text = "SQlite Database Administrator";
            this.lblTable.Text = "";
            tableName = "";

            if (oDatabaseSqlite != null)
            {
                oDatabaseSqlite.Disconnect();
                this.oDatabaseSqlite = null;
            }



        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lstvTables_MouseClick_1(object sender, MouseEventArgs e)
        {
            this.dgvDatos.DataSource = this.oDatabaseSqlite.listData(this.tableName);
        }

        private void trvTables_MouseClick(object sender, MouseEventArgs e)
        {


            if (e.Button == MouseButtons.Left)
            {
                TreeNode treeNode = this.trvTables.SelectedNode = this.trvTables.GetNodeAt(e.Location);
                this.tableName = treeNode.Text;
                // this.refresh_dgvDatos();
                refresh_dgvEstructura();
                lblTable.Text = "TABLE - " + tableName;

                listColumsSelect.Clear();


                if (tabControl1.SelectedIndex == 1)
                {
                    if (bgwkCargarDgvDatos.IsBusy)
                        bgwkCargarDgvDatos.CancelAsync();
                    ofrmProcessingDgvData = new frmProcessing();
                    ofrmProcessingDgvData.Show();
                    bgwkCargarDgvDatos.RunWorkerAsync();

                }



                if (tabControl1.SelectedTab == tbQuerys)
                {
                    lblTable.Text = "";
                }
            }
            //tabQuerysData.SelectedTab = tbpAddRecord;

        }

        public void refresh_trvTables()
        {
        }
        public void refresh_dgvEstructura()
        {
            // this.dgvDatos.DataSource = this.oDatabaseSqlite.listData(this.dataTableName);
            listColumsTypes = oDatabaseSqlite.getColumnsTypes_List(tableName);
            this.dgvTableInfo.DataSource = this.oDatabaseSqlite.getColumnsTypesTables_DataTable(this.tableName);
        }

        public void refresh_dgvDatos()
        {
            if (oDatabaseSqlite != null)
                this.dgvDatos.DataSource = this.oDatabaseSqlite.selectData(listColumsTypes.Count, this.tableName);
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
        }

        private void btnExecuteQuery_Click(object sender, EventArgs e)
        {
            ofrmProcessingDgvSqlQuery = new frmProcessing();
            ofrmProcessingDgvSqlQuery.Show();
            listQuerys = this.txtQuery.Text.Split(';');
            tstExecuteQuery.Enabled = false;
            btnExecuteQuery.Enabled = false;
            tabControl1.Enabled = false;
            trvTables.Enabled = false;
            this.bgwkExecuteSql.RunWorkerAsync();

        }

        public String executeQuery()
        {
            String result = "";

            int i = 0;
            if (oDatabaseSqlite != null)
            {

                try
                {
                    String query = "";

                    this.rowsAfected = 0;

                    for (i = 0; i < listQuerys.Length; i++)
                    {
                        query = listQuerys[i];

                        if (i == 0)
                        {
                            query = query.Replace("\r", "");
                        }
                        else
                        {
                            query = query.Replace("\r\n", "");
                        }

                        if (!query.Trim().Equals(""))
                        {
                            queryType = query.Substring(0, query.IndexOf(" "));

                            if (queryType.ToUpper().Equals("SELECT"))
                            {
                                UpdateDgvQueryResults(this.oDatabaseSqlite.queryDatabase(query));
                                ////////          this.dgvQueryResults.DataSource = this.oDatabaseSqlite.queryDatabase(query);
                            }
                            else
                            {

                                rowsAfected += oDatabaseSqlite.updateDatabase(query);

                                if (rowsAfected == -1)
                                {
                                    i = listQuerys.Length + 2;
                                    result = "0";
                                }
                                else
                                {
                                    result = rowsAfected + "";
                                }


                            }
                        }

                    }



                }
                catch (Exception ex)
                {
                    UpdateoFrmProcessingDgvSqlQuery();
                    //ofrmProcessingDgvSqlQuery.Dispose();
                    //trvTables.Enabled = true;
                    //tabControl1.Enabled = true;
                    //btnExecuteQuery.Enabled = true;*/
                    MessageBox.Show(ex.Message.ToString());

                    i = listQuerys.Length + 2;
                }


            }
            return result;
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAbout frmAbout = new frmAbout();
            frmAbout.Show();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            openDatabase();
            //load_Grid_ADD_Update_Delete_Record();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            closeDatabase();
        }

        private void tabControl1_MouseClick(object sender, MouseEventArgs e)
        {
            if (tabControl1.SelectedTab == tbQuerys)
            {
                tstExecuteQuery.Enabled = true;
                tstSaveQuery.Enabled = true;
                saveToolStripMenuItem.Enabled = true;
                executeToolStripMenuItem.Enabled = true;
            }
            else
            {
                tstExecuteQuery.Enabled = false;
                tstSaveQuery.Enabled = false;
                saveToolStripMenuItem.Enabled = false;
                executeToolStripMenuItem.Enabled = false;
            }

            if (tabControl1.SelectedTab == tbpData && tableName.Trim().Length>0)
            {
                ofrmProcessingDgvData = new frmProcessing();
                ofrmProcessingDgvData.Show();
                bgwkCargarDgvDatos.RunWorkerAsync();
            }

        }

        private void tstExecuteQuery_Click(object sender, EventArgs e)
        {
            if (!databaseName.Trim().Equals("")){


                ofrmProcessingDgvSqlQuery = new frmProcessing();
                ofrmProcessingDgvSqlQuery.Show();
                listQuerys = this.txtQuery.Text.Split(';');
                tstExecuteQuery.Enabled = false;
                btnExecuteQuery.Enabled = false;
                tabControl1.Enabled = false;
                trvTables.Enabled = false;
                this.bgwkExecuteSql.RunWorkerAsync();


            }
        }



        private void btnAcceptAddRecord_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }







        private void dgvDatos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //   record_Selected=dgvDatos.Rows[e.RowIndex].Cells[0].Value.ToString();



        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {

            createDataBase();
        }

        public void createDataBase()
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            //SE ESPECIFICA EL TIPO DE EXTENSION QUE SE VA USAR "access files 2007(*.accdb)|*.accdb"
            saveFileDialog1.RestoreDirectory = true;
            saveFileDialog1.InitialDirectory = "C:\\";

            try
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    closeDatabase();

                    this.oDatabaseSqlite = new DatabaseSqlite();

                    databaseName = saveFileDialog1.FileName;

                    this.oDatabaseSqlite = new DatabaseSqlite();

                    oDatabaseSqlite.create_Database(databaseName);


                    this.showTables();
                    if (trvTables.Nodes.Count > 0)
                    {
                        TreeNode selectedNode = this.trvTables.Nodes[0];
                        this.trvTables.SelectedNode = selectedNode;
                        this.tableName = this.trvTables.SelectedNode.Text;
                        //this.refresh_dgvDatos();
                        refresh_dgvEstructura();
                        lblTable.Text = "TABLE - " + tableName;
                        startupPath = Path.GetFullPath("sqlite3.exe");

                    }
                    tabControl1.Enabled = true;

                    this.Text = "SQlite Administrator - " + this.databaseName;


                }
            }
            catch (Exception ex)
            {


            }

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

            foreach (TreeNode item in trvTables.Nodes)
            {
                if (item.Text.Equals(tableName))
                {
                    trvTables.SelectedNode = item;
                    trvTables.Select();
                }
            }


            this.trvTables.Refresh();

            if (tabControl1.SelectedIndex < 2)
            {
                lblTable.Text = "TABLE - " + tableName;
                tstExecuteQuery.Enabled = false;
                tstSaveQuery.Enabled = false;
            }
            else
            {
                lblTable.Text = "";
                tstExecuteQuery.Enabled = true;
                tstSaveQuery.Enabled = true;
            }



        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            createDataBase();


        }

        private void dgvDatos_MouseDown(object sender, MouseEventArgs e)
        {
            if (oDatabaseSqlite != null)
            {
                if (e.Button == MouseButtons.Right)
                {

                    ctxDataGridview.Show(Cursor.Position);
                    ctxDataGridview.Enabled = true;
                    ctxDataGridview.Visible = true;

                }
            }
        }

        private void contextMenu_Click(object sender, EventArgs e)
        {
            switch (sender.ToString().Trim())
            {
                case "Copy":
                    Process.Start("https://www.google.com");
                    break;

            }
        }

        private void dgvTableInfo_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvTableInfo_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void dgvTableInfo_SelectionChanged(object sender, EventArgs e)
        {
            refresh_treeview();
        }



        public void refresh_treeview()
        {
            foreach (TreeNode item in trvTables.Nodes)
            {
                if (item.Text.Equals(tableName))
                {
                    trvTables.SelectedNode = item;
                    trvTables.Select();
                }
            }


            this.trvTables.Refresh();



        }

        private void dgvDatos_SelectionChanged(object sender, EventArgs e)
        {
            // refresh_treeview();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip1_Click(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip1_Opening_1(object sender, CancelEventArgs e)
        {

        }

        private void trvTables_MouseDown(object sender, MouseEventArgs e)
        {
            if (oDatabaseSqlite != null)
            {
                if (e.Button == MouseButtons.Right)
                {
                    ctxOpcionoes.Show(Cursor.Position);
                    ctxOpcionoes.Enabled = true;
                    ctxOpcionoes.Visible = true;

                }
            }
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "csv files (*.csv)|*.csv";

            //SE ESPECIFICA EL TIPO DE EXTENSION QUE SE VA USAR "access files 2007(*.accdb)|*.accdb"
            saveFileDialog1.RestoreDirectory = true;
            saveFileDialog1.InitialDirectory = "C:\\";
            String fileUbication = "";
            DataTable oDataTableExport = new DataTable();
            oDataTableExport = this.oDatabaseSqlite.selectData(listColumsTypes.Count, this.tableName);


            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                fileUbication = saveFileDialog1.FileName;

                if (File.Exists(fileUbication))
                {
                    File.Delete(fileUbication);
                }

                dgvDatos.DataSource = oDatabaseSqlite.selectData(listColumsTypes.Count, this.tableName);


                oArchivos.exportarDatagridToExcel(dgvDatos, fileUbication);


            }


        }



        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (listColumsSelect.Count > 0)
            {
                query = "Select ";

                for (int i = 0; i < listColumsSelect.Count - 1; i++)
                {
                    query += listColumsSelect[i] + ", ";
                }
                query += listColumsSelect[listColumsSelect.Count - 1];

                query += " from [" + tableName + "]";

                if (listColumsFilter.Count > 0)
                {
                    query += " where " + listColumsFilter[0];
                }

                this.dgvDatos.DataSource = this.oDatabaseSqlite.queryDatabase(query);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {

            listColumsSelect.Clear();
        }



        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void txtVarFiltro_TextChanged(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            String[] listColumsTable = new String[5];
            listColumsTable = oDatabaseSqlite.getSQlMasterTable(tableName);

            tabControl1.SelectedTab = tbQuerys;

            txtQuery.Text = listColumsTable[4]+";";

            tstExecuteQuery.Enabled = true;
            tstSaveQuery.Enabled = true;


        }

        private void renameTableToolStripMenuItem_Click(object sender, EventArgs e)
        {

            string entrada = Microsoft.VisualBasic.Interaction.InputBox("Type the new table name", "Rename table");

            if (entrada.Length > 0)

                try
                {
                    oDatabaseSqlite.renameTable(tableName, entrada);
                    lblTable.Text = "Table-" + entrada;
                    tableName = entrada;
                    this.showTables();
                    refresh_treeview();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }



        }

        private void ddeleteTableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to delete the table?", "Confirmation", MessageBoxButtons.YesNoCancel);
            if (result == DialogResult.Yes)
            {
                oDatabaseSqlite.dropTable(tableName);
                lblTable.Text = "Table";
                tableName = "";
                this.showTables();
                refresh_treeview();
                dgvDatos.DataSource = null;
                dgvDatos.Rows.Clear();
                dgvTableInfo.DataSource = null;
                dgvTableInfo.Rows.Clear();
            }
        }

        private void tstSaveQuery_Click(object sender, EventArgs e)
        {
            saveSQl();
        }


        public void saveSQl()
        {

            if (txtQuery.TextLength > 0)
            {


                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                saveFileDialog1.Filter = "sql files (*.sql)|*.sql";

                //SE ESPECIFICA EL TIPO DE EXTENSION QUE SE VA USAR "access files 2007(*.accdb)|*.accdb"
                saveFileDialog1.RestoreDirectory = true;
                saveFileDialog1.InitialDirectory = "C:\\";

                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    filenameSQl = saveFileDialog1.FileName;

                    oArchivos.hacerDocumentoTexto(filenameSQl, txtQuery.Text);
                }

            }
        }

        private void btnExportToCSV_Click(object sender, EventArgs e)
        {
            Archivos oArchivos = new Archivos();

            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.RestoreDirectory = true;
            saveFileDialog1.InitialDirectory = "C:\\";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                filenameSQl = saveFileDialog1.FileName;

                oArchivos.exportarDatagridToExcel(dgvDatos, filenameSQl);
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveSQl();
        }

        private void executeToolStripMenuItem_Click(object sender, EventArgs e)
        {

            executeQuery();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            oDatabaseSqlite.getColumnsTypes_List("redes");
            oDatabaseSqlite.exportSQL("redes");
        }

        private void exportTableToSQLToolStripMenuItem_Click(object sender, EventArgs e)
        {

            sintax = oDatabaseSqlite.exportSQL(tableName);

            saveFile(sintax);
        }

        private void ExportDatabaseToSQL_Click(object sender, EventArgs e)
        {
            ofrmProcessingExportSQL = new frmProcessing();
            ofrmProcessingExportSQL.Show();
            bgwkExportSQL.RunWorkerAsync();

        }

        private void exportSQL(){
            try
            {
                listTables = oDatabaseSqlite.listTables_List();


                for (int i = 0; i < listTables.Count; i++)
                {
                    sintax += oDatabaseSqlite.exportSQL(listTables[i]);
                }

                

               
            }
            catch (Exception EX)
            {


            }
        }


        public void saveFile(String sintaxParam)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            //Specify the extensions allowed
            saveFileDialog1.Filter = "Text File|.txt";
            //Empty the FileName text box of the dialog
            saveFileDialog1.FileName = String.Empty;
            //Set default extension as .txt
            saveFileDialog1.DefaultExt = ".txt";

            //Open the dialog and determine which button was pressed
            DialogResult result = saveFileDialog1.ShowDialog();

            //If the user presses the Save button
            if (result == DialogResult.OK)
            {

                //sintax = oDatabaseSqlite.exportSQL(tableName);

                //Create a file stream using the file name
                FileStream fs = new FileStream(saveFileDialog1.FileName, FileMode.Create);

                //Create a writer that will write to the stream
                StreamWriter writer = new StreamWriter(fs);
                //Write the contents of the text box to the stream
                writer.Write(sintaxParam);
                //Close the writer and the stream
                writer.Close();
            }
            sintax = "";
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Archivos oArchivos = new Archivos();

            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "csv files (*.csv)|*.csv";

            saveFileDialog1.RestoreDirectory = true;
            saveFileDialog1.InitialDirectory = "C:\\";

            if (dgvQueryResults.DataSource != null)
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    filenameSQl = saveFileDialog1.FileName;

                    oArchivos.exportarDatagridToExcel(dgvQueryResults, filenameSQl);
                }
            }
        }

        private void bkgwExecuteSql_DoWork(object sender, DoWorkEventArgs e)
        {

            result = executeQuery();
        }

        private void bkgwExecuteSql_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            ofrmProcessingDgvSqlQuery.Close();

            lblRecordAfected.Text = result;

            if (!queryType.ToUpper().Equals("SELECT"))
            {
                //tableName = "";
                this.showTables();
                dgvDatos.DataSource = null;
                dgvTableInfo.DataSource = null;

            }
            btnExecuteQuery.Enabled = true;
            tstExecuteQuery.Enabled = true;
            tabControl1.Enabled = true;
            trvTables.Enabled = true;
            tstExecuteQuery.Enabled = true;
        }

        private void UpdateDgvQueryResults(DataTable updateVal)
        {
            if (dgvQueryResults.InvokeRequired)
                dgvQueryResults.Invoke(new updateDelegate(UpdateDgvQueryResults), updateVal);
            else
            {
                dgvQueryResults.DataSource = updateVal;

            foreach (DataGridViewColumn col in dgvQueryResults.Columns)
            {
                if (col.ValueType == typeof(string))
                {

                    col.Width = 250;
                }
            }

            }

        }

        private void UpdateDgvDatos(DataTable updateVal)
        {
            if (dgvDatos.InvokeRequired)
                dgvDatos.Invoke(new updateDelegate(UpdateDgvDatos), updateVal);
            else{
                dgvDatos.DataSource = updateVal;

            foreach (DataGridViewColumn col in dgvDatos.Columns)
            {
                if (col.ValueType == typeof(string))
                {
                  
                    col.Width = 250;
                }
            }
            }
        }


        private void UpdateoFrmProcessingDgvSqlQuery()
        {
            if (ofrmProcessingDgvSqlQuery.InvokeRequired)
                ofrmProcessingDgvSqlQuery.Invoke(new updateDelegateoFrmProcessingDgvSqlQuery(UpdateoFrmProcessingDgvSqlQuery));
            else
                ofrmProcessingDgvSqlQuery.Close();

        }


        private void bgwkCargarDgvDatos_DoWork(object sender, DoWorkEventArgs e)
        {
            UpdateDgvDatos(this.oDatabaseSqlite.selectData(listColumsTypes.Count, this.tableName));

        }

        private void bgwkCargarDgvDatos_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            ofrmProcessingDgvData.Close();
        }

        public String sintaxisInsertQuery()
        {
            String result = "insert into " + tableName;
            String columns = "(";
            String values = "(";

            listColumsNames = oDatabaseSqlite.getColumnsTable(tableName);

            for (int i = 0; i < listColumsTypes.Count - 1; i++)
            {
                columns += listColumsNames[i] + ",";

                if (listColumsTypes[i].ToUpper().Equals("TEXT"))
                {
                    values += "' ',";

                }
                else
                {
                    values += "0,";
                }


            }

            columns += listColumsNames[listColumsNames.Count - 1] + ") values ";

            if (listColumsTypes[listColumsTypes.Count - 1].ToUpper().Equals("TEXT"))
            {
                values += "' ')";

            }
            else
            {
                values += "0)";
            }

            result += columns + values + ";";

            return result;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(sintaxisInsertQuery());
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            txtQuery.Text = this.sintaxisInsertQuery();
            tabControl1.SelectedIndex = 2;
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            txtQuery.Text = sintaxisSelect();
            tabControl1.SelectedIndex = 2;
        }

        private String sintaxisSelect() {
            String resultado = "select ";
            listColumsNames = oDatabaseSqlite.getColumnsTable(tableName);

            for (int i=0; i<listColumsNames.Count-1; i++)
            {
                resultado += listColumsNames[i] + ", ";
            }

            resultado += listColumsNames[listColumsNames.Count - 1] + " ";

            resultado += " from " + tableName+";";

            return resultado;
        }


        private String sintaxisUpdate(){
            String resultado="";
            listColumsNames = oDatabaseSqlite.getColumnsTable(tableName);

            resultado = "update " + tableName+" set ";

            for(int i=0; i<listColumsNames.Count-1; i++){


                if (listColumsTypes[i].ToUpper().Equals("TEXT"))
                {
                    resultado +=listColumsNames[i]+ "=' ',";

                }
                else
                {
                    resultado += listColumsNames[i] + "=0,";
                }


            }

            if (listColumsTypes[listColumsTypes.Count - 1].ToUpper().Equals("TEXT"))
            {
                resultado += listColumsNames[listColumsNames.Count - 1] + "=' ';";

            }
            else
            {
                resultado += listColumsNames[listColumsNames.Count - 1] + "=0;";
            }



            return resultado;
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            txtQuery.Text = sintaxisUpdate();
            tabControl1.SelectedIndex = 2;
        }

        private void bgwkExportSQL_DoWork(object sender, DoWorkEventArgs e)
        {
            exportSQL();
        }

        private void bgwkExportSQL_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            saveFile(sintax);
            ofrmProcessingExportSQL.Close();
        }

        private void dgvTableInfo_MouseDown(object sender, MouseEventArgs e)
        {
            if (oDatabaseSqlite != null)
            {
                if (e.Button == MouseButtons.Right)
                {

                    ctxDataGridview.Show(Cursor.Position);
                    ctxDataGridview.Enabled = true;
                    ctxDataGridview.Visible = true;

                }
            }
        }

      private void copyDataGridViewuStructure(){
 
      if (this.dgvTableInfo
            .GetCellCount(DataGridViewElementStates.Selected) > 0)
        {
            try
            {
                // Add the selection to the clipboard.
                Clipboard.SetDataObject(
                    this.dgvTableInfo.GetClipboardContent());
            }
            catch (System.Runtime.InteropServices.ExternalException)
            {

            }
        }
      }

              private void copyDataGridViewData(){
 
      if (this.dgvDatos
            .GetCellCount(DataGridViewElementStates.Selected) > 0)
        {
            try
            {
                // Add the selection to the clipboard.
                Clipboard.SetDataObject(
                    this.dgvDatos.GetClipboardContent());
            }
            catch (System.Runtime.InteropServices.ExternalException)
            {

            }
        }
      }

              private void copyDataGridViewSQLQuery(){
 
      if (this.dgvQueryResults
            .GetCellCount(DataGridViewElementStates.Selected) > 0)
        {
            try
            {
                // Add the selection to the clipboard.
                Clipboard.SetDataObject(
                    this.dgvQueryResults.GetClipboardContent());
            }
            catch (System.Runtime.InteropServices.ExternalException)
            {

            }
        }
      }


        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {
                 switch (tabControl1.SelectedIndex)
	            {
                     case 0:
                         copyDataGridViewuStructure();
                         break;
                     case 1:
                         copyDataGridViewData();
                         break;
                     case 2:
                         copyDataGridViewSQLQuery();
                 break;
	           	default:
                break;
            	}
        }

        private void dgvQueryResults_MouseDown(object sender, MouseEventArgs e)
        {
            if (oDatabaseSqlite != null)
            {
                if (e.Button == MouseButtons.Right)
                {

                    ctxDataGridview.Show(Cursor.Position);
                    ctxDataGridview.Enabled = true;
                    ctxDataGridview.Visible = true;

                }
            }
        }

        private void dgvDatos_KeyUp(object sender, KeyEventArgs e)
        {

            if (e.KeyData == (Keys.Control | Keys.C))
            {
                copyDataGridViewData();
            }
        }

        private void dgvTableInfo_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == (Keys.Control | Keys.C))
            {
                copyDataGridViewuStructure();
            }
        }

        private void dgvQueryResults_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == (Keys.Control | Keys.C))
            {
                copyDataGridViewSQLQuery();
            }
        }


    }
}

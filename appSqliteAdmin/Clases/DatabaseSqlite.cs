#region Copyright & License Information
﻿/*
 * Copyright 2014 Maykol Alvarado P
 * This file is part of windows sqlite which is free software. It is made
 * available to you under the terms of the GNU General Public License
 * as published by the Free Software Foundation. For more information,
 * see COPYING.
 */
﻿#endregion

﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;
using System.Text;
using System.Globalization;
using System.Diagnostics;
using System.IO;

namespace appSqliteManagerPro.Clases
{
    public class DatabaseSqlite
    {
        private static string sqlConnectionString;
        private static SQLiteConnection oSQLiteConnection;
        private static SQLiteDataAdapter oSQLiteDataAdapter;
        private static SQLiteCommand oSQLiteCommand;
        private static DataTable oDataTable;
        private static SQLiteDataReader oSQLiteDataReader;


        public DatabaseSqlite(string pSqliteDatabaseLocation)
        {
            DatabaseSqlite.sqlConnectionString = "Data Source=" + pSqliteDatabaseLocation + ";Version=3;New=False;Compress=True;";
        }


        public DatabaseSqlite()
        {
        }


        public void Connect()
        {
            try
            {
                DatabaseSqlite.oSQLiteConnection = new SQLiteConnection(DatabaseSqlite.sqlConnectionString);
                DatabaseSqlite.oSQLiteConnection.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fallo al abrir la base \n" + ex.Message.ToString());
            }
        }


        public void Disconnect()
        {
            DatabaseSqlite.oSQLiteConnection.Close();

        }


        public DataTable listTables_Datatable()
        {
            this.Connect();
            string text = "SELECT name 'Tables' FROM sqlite_master WHERE type ='table' and name<>'android_metadata'";
            DatabaseSqlite.oSQLiteDataAdapter = new SQLiteDataAdapter(text, DatabaseSqlite.oSQLiteConnection);
            DatabaseSqlite.oDataTable = new DataTable();
            DatabaseSqlite.oSQLiteDataAdapter.Fill(DatabaseSqlite.oDataTable);
            this.Disconnect();
            return DatabaseSqlite.oDataTable;
        }


        public DataTable listData(string pTableName)
        {
            this.Connect();
            try
            {
                string text = "SELECT * FROM " + pTableName;
                DatabaseSqlite.oSQLiteDataAdapter = new SQLiteDataAdapter(text, DatabaseSqlite.oSQLiteConnection);
                DatabaseSqlite.oDataTable = new DataTable();
                DatabaseSqlite.oSQLiteDataAdapter.Fill(DatabaseSqlite.oDataTable);
            }
            catch (Exception)
            {
            }

            this.Disconnect();
            return DatabaseSqlite.oDataTable;
        }


        public List<string> listTables_List()
        {
            List<string> list = new List<string>();
            this.Connect();
            string text = "SELECT name FROM sqlite_master WHERE type ='table' and name<>'android_metadata'";
            DatabaseSqlite.oSQLiteCommand = new SQLiteCommand(text, DatabaseSqlite.oSQLiteConnection);
            SQLiteDataReader sQLiteDataReader = DatabaseSqlite.oSQLiteCommand.ExecuteReader();
            if (sQLiteDataReader.HasRows)
            {
                while (sQLiteDataReader.Read())
                {
                    string @string = sQLiteDataReader.GetString(0);
                    list.Add(@string);
                }
            }
            this.Disconnect();
            return list;
        }


        public DataTable getColumnsTypesTables_DataTable(string tableName)
        {
            this.Connect();
            string text = "PRAGMA table_info('" + tableName + "');";
            DatabaseSqlite.oSQLiteDataAdapter = new SQLiteDataAdapter(text, DatabaseSqlite.oSQLiteConnection);
            DatabaseSqlite.oDataTable = new DataTable();
            DatabaseSqlite.oSQLiteDataAdapter.Fill(DatabaseSqlite.oDataTable);
            this.Disconnect();
            return DatabaseSqlite.oDataTable;
        }


        public List<string> getColumnsTypes_List(string tableName)
        {
            List<string> listColumns = new List<string>();
            this.Connect();
            string text = "PRAGMA table_info('" + tableName + "');";
            string columns = "";
            DatabaseSqlite.oSQLiteCommand = new SQLiteCommand(text, DatabaseSqlite.oSQLiteConnection);
            SQLiteDataReader sQLiteDataReader = DatabaseSqlite.oSQLiteCommand.ExecuteReader();
            if (sQLiteDataReader.HasRows)
            {
                while (sQLiteDataReader.Read())
                {
                    columns = sQLiteDataReader.GetString(2);
                    listColumns.Add(columns);
                }
            }
            sQLiteDataReader.Close();

            this.Disconnect();
            return listColumns;
        }


        public DataTable queryDatabase(string query)
        {
            DataTable dataTable = new DataTable();
            dataTable = null;
            this.Connect();


                DatabaseSqlite.oSQLiteDataAdapter = new SQLiteDataAdapter(query, DatabaseSqlite.oSQLiteConnection);
                dataTable = new DataTable();
                DatabaseSqlite.oSQLiteDataAdapter.Fill(dataTable);


            return dataTable;
        }

        public int updateDatabase(string query)
        {
            DataTable dataTable = new DataTable();
            int rowsAfected = -1;

            this.Connect();

                DatabaseSqlite.oSQLiteCommand = new SQLiteCommand(query, DatabaseSqlite.oSQLiteConnection);
                rowsAfected = DatabaseSqlite.oSQLiteCommand.ExecuteNonQuery();


            return rowsAfected;
        }

        //        public List<String[]> selectData(int numColumns, String datatable){
        public DataTable selectData(int numColumns, String datatable)
        {
            List<String[]> listaData = new List<string[]>();
            List<String> row = new List<string>();
            String[] arrData = new String[numColumns];
            String query = "", value = "";
            List<String> listColumsTime = new List<string>();
            String queryTableTime = "";
            List<String> listColumsTable = new List<string>();
            int columTime = 0;

            listColumsTime = this.find_column_Datetime(datatable);

            listColumsTable = this.getColumnsTable(datatable);

            this.getColumnsTable(datatable);

            if (listColumsTime.Count > 0)
            {

                for (int i = 0; i < listColumsTable.Count; i++)
                {

                    columTime = listColumsTime.IndexOf(listColumsTable[i]);

                    if (columTime > -1)
                    {
                        queryTableTime += "CAST([" + listColumsTable[i] + "] AS TEXT) as " + listColumsTable[i] + ",";
                    }
                    else
                    {
                        queryTableTime += "[" + listColumsTable[i] + "],";
                    }


                }

                queryTableTime = queryTableTime.Substring(0, queryTableTime.Length - 1);
            }




            Connect();

            if (queryTableTime.Length > 0)
            {
                query = "select " + queryTableTime + " from [" + datatable + "]";
            }
            else
            {
                query = "select * from [" + datatable + "]";
            }

            oSQLiteCommand = new SQLiteCommand(query, oSQLiteConnection);
            oSQLiteDataReader = oSQLiteCommand.ExecuteReader();

            if (oSQLiteDataReader.HasRows)
            {

                while (oSQLiteDataReader.Read())
                {

                    for (int i = 0; i < numColumns; i++)
                    {


                        if (oSQLiteDataReader.GetValue(i) != DBNull.Value)
                        {
                            value = Convert.ToString(oSQLiteDataReader.GetValue(i));

                        }
                        else
                        {
                            value = "";
                        }

                        // byte[] bytes = Encoding.GetEncoding("iso-8859-8").GetBytes(value);
                        byte[] bytes = Encoding.Default.GetBytes(value);
                        value = Encoding.Default.GetString(bytes);


                        row.Add(value);
                    }

                    arrData = new String[numColumns];

                    arrData = row.ToArray();

                    row.Clear();

                    listaData.Add(arrData);

                }

            }

            Disconnect();

            DataTable oDataTable = new DataTable();

            foreach (var item in listColumsTable)
            {
                oDataTable.Columns.Add(item);
            }

            foreach (var item in listaData)
            {
                oDataTable.Rows.Add(item);
            }

            return oDataTable;
        }

        public List<String> getColumnsTable(string tableName)
        {
            List<String> listColumsTable = new List<string>();

            this.Connect();
            string text = "PRAGMA table_info('" + tableName + "');";
            string columns = "";
            DatabaseSqlite.oSQLiteCommand = new SQLiteCommand(text, DatabaseSqlite.oSQLiteConnection);
            SQLiteDataReader sQLiteDataReader = DatabaseSqlite.oSQLiteCommand.ExecuteReader();
            if (sQLiteDataReader.HasRows)
            {
                while (sQLiteDataReader.Read())
                {
                    columns = sQLiteDataReader.GetString(1);
                    listColumsTable.Add(columns);
                }
            }

            sQLiteDataReader.Close();

            this.Disconnect();

            return listColumsTable;

        }


        public List<String[]> getStructureTable(string tableName)
        {
            List<String[]> listDataStructureTable = new List<String[]>();
            String[] data = new String[6];
            String cid = "", name = "", type = "", notnull = "", dft_Value = "", pk = "";


            this.Connect();
            string text = "PRAGMA table_info('" + tableName + "');";

            DatabaseSqlite.oSQLiteCommand = new SQLiteCommand(text, DatabaseSqlite.oSQLiteConnection);
            SQLiteDataReader sQLiteDataReader = DatabaseSqlite.oSQLiteCommand.ExecuteReader();
            if (sQLiteDataReader.HasRows)
            {
                while (sQLiteDataReader.Read())
                {
                    cid = sQLiteDataReader.GetValue(0).ToString();
                    name = sQLiteDataReader.GetString(1);
                    type = sQLiteDataReader.GetString(2);
                    notnull = sQLiteDataReader.GetValue(3).ToString();
                    dft_Value = sQLiteDataReader.GetValue(4).ToString();
                    pk = sQLiteDataReader.GetValue(5).ToString();

                    data = new String[] { cid, name, type, notnull, dft_Value, pk };

                    listDataStructureTable.Add(data);
                }
            }
            this.Disconnect();

            return listDataStructureTable;

        }

        public List<String> find_column_Datetime(String pTableName)
        {
            List<String[]> listDataStructureTable = new List<String[]>();
            String[] data = new String[6];
            List<String> listColumsTime = new List<string>();

            Connect();

            listDataStructureTable = this.getStructureTable(pTableName);

            foreach (var item in listDataStructureTable)
            {

                if (item[2].ToUpper().Equals("TIMESTAMP") || item[2].ToUpper().Equals("DATE") || item[2].ToUpper().Equals("DATETIME"))
                {
                    listColumsTime.Add(item[1]);
                }
            }

            Disconnect();

            return listColumsTime;
        }


        public void create_Database(String file)
        {
            SQLiteConnection.CreateFile(file);

            //         oSQLiteConnection = new SQLiteConnection("Data Source="+file+";Version=3;");

        }

        public void exportaDatabase(string startupPath, string databaseName, string tableName)
        {
            String query = ".mode csv;" + "\n.header on;" + "\n.out file.dmp;" + "\nselect * from employess";

            string strCmdText;
            // strCmdText = "/C ipconfig > afds.txt"+"\nipconfig > afds2.txt";
            //System.Diagnostics.Process.Start("CMD.exe", strCmdText);

            Process p = new Process();
            StreamWriter sw;

            ProcessStartInfo psI = new ProcessStartInfo("cmd");
            psI.UseShellExecute = false;
            psI.RedirectStandardInput = true;
            psI.RedirectStandardOutput = true;
            psI.RedirectStandardError = true;
            psI.CreateNoWindow = true;
            p.StartInfo = psI;
            p.Start();
            sw = p.StandardInput;

            //
            sw.AutoFlush = true;
            sw.WriteLine("/C cd " + startupPath);
            sw.WriteLine("sqlite3 " + databaseName);
            sw.WriteLine(".mode csv");
            sw.WriteLine(".header on");
            sw.WriteLine(".separator ;");
            sw.WriteLine(".out file.csv");
            sw.WriteLine("select * from " + tableName + ";");
            sw.Close();
        }







        public String[] getSQlMasterTable(string tableName)
        {

            String[] listColumsTable = new String[5];

            this.Connect();
            string text = "SELECT type,name,tbl_name,rootpage,sql FROM sqlite_master WHERE tbl_name like '" + tableName + "' and type='table'";
            DatabaseSqlite.oSQLiteCommand = new SQLiteCommand(text, DatabaseSqlite.oSQLiteConnection);
            SQLiteDataReader sQLiteDataReader = DatabaseSqlite.oSQLiteCommand.ExecuteReader();
            if (sQLiteDataReader.HasRows)
            {
                while (sQLiteDataReader.Read())
                {
                    listColumsTable = new String[] { sQLiteDataReader.GetString(0), sQLiteDataReader.GetString(1), sQLiteDataReader.GetString(2), sQLiteDataReader.GetInt32(3) + "", sQLiteDataReader.GetString(4) };
                }
            }

            sQLiteDataReader.Close();

            this.Disconnect();

            return listColumsTable;

        }

        public void renameTable(String oldTableName, String newTableName)
        {

            this.Connect();
            string text = "ALTER TABLE " + oldTableName + " RENAME TO " + newTableName;
            DatabaseSqlite.oSQLiteCommand = new SQLiteCommand(text, DatabaseSqlite.oSQLiteConnection);
            DatabaseSqlite.oSQLiteCommand.ExecuteNonQuery();

        }


        public void dropTable(String tableName)
        {

            this.Connect();
            string text = "DROP TABLE " + tableName;
            DatabaseSqlite.oSQLiteCommand = new SQLiteCommand(text, DatabaseSqlite.oSQLiteConnection);
            DatabaseSqlite.oSQLiteCommand.ExecuteNonQuery();

        }


        public String exportSQL(String tableName)
        {
            String resultado = "", consulta = "";
            List<String> listadoTiposColumnas = new List<string>();
            SQLiteDataReader sQLiteDataReader;
            

            listadoTiposColumnas=this.getColumnsTypes_List(tableName);

            Connect();
            consulta = "select * from " + tableName;
            DatabaseSqlite.oSQLiteCommand = new SQLiteCommand(consulta, DatabaseSqlite.oSQLiteConnection);
            sQLiteDataReader = DatabaseSqlite.oSQLiteCommand.ExecuteReader();
            if (sQLiteDataReader.HasRows)
            {
                while (sQLiteDataReader.Read())
                {
                    resultado += "insert into " + tableName + " values(";
                    for (int i = 0; i < sQLiteDataReader.FieldCount; i++)
                    {
                        if(listadoTiposColumnas[i].ToUpper().Equals("TEXT")){
                            resultado += "'" + sQLiteDataReader.GetString(i) + "'";
                        }else{
                            resultado += sQLiteDataReader.GetValue(i)+"";
                        }

                        if(i == sQLiteDataReader.FieldCount-1){
                            resultado += ");";
                        }else{
                            resultado += ",";
                        }
                        
                    }

                    resultado += "\n";
                }
            }

            sQLiteDataReader.Close();
            Disconnect();

            return resultado;
        }

    }
};

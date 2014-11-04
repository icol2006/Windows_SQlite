using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace appSqliteAdmin.Clases
{
    public class Archivos
    {
        public void hacerDocumentoTexto(string nombreArchivo, string texto)
        {
            StreamWriter writer = null;
            string fileName =  nombreArchivo;

            // Delete a file by using File class static method...
            if (System.IO.File.Exists(fileName))
            {
                // Use a try block to catch IOExceptions, to
                // handle the case of the file already being
                // opened by another process.
                try
                {
                    System.IO.File.Delete(fileName);
                }
                catch (System.IO.IOException exe)
                {
                    Console.WriteLine(exe.Message);
                    return;
                }
            }

            writer = File.CreateText(fileName);
            writer.WriteLine(texto);

            writer.Close();

        }


        public void exportarDatagridToExcel(DataGridView dGV, string filename)
        {
            string stOutput = "";
            // Export titles:
            string sHeaders = "";
            String data = "";

            for (int j = 0; j < dGV.Columns.Count; j++)
                sHeaders = sHeaders.ToString() + Convert.ToString(dGV.Columns[j].HeaderText) + ";";
            stOutput += sHeaders + "\r\n";
            // Export data.
            for (int i = 0; i < dGV.RowCount; i++)
            {
                string stLine = "";
                for (int j = 0; j < dGV.Rows[i].Cells.Count; j++)
                {
                    data = Convert.ToString(dGV.Rows[i].Cells[j].Value);
                    data = data.Replace("\r\n", " ");
                    stLine = stLine.ToString() + data + ";";
                }
                stOutput += stLine + "\r\n";

            }
            stOutput += "\r\n";

            Encoding utf16 = Encoding.GetEncoding(1254);
            byte[] output = utf16.GetBytes(stOutput);
            FileStream fs = new FileStream(filename, FileMode.Create);
            BinaryWriter bw = new BinaryWriter(fs);
            bw.Write(output, 0, output.Length); //write the encoded file
            bw.Flush();
            bw.Close();
            fs.Close();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lead.Prim.Cater.Common
{
    static class CsvHelper
    {
        public static DataTable CsvToDataTable(string filePath)
        {
            DataTable dataTable = new DataTable();
            StreamReader streamReader = new StreamReader(filePath, Encoding.Default, false);
            int flag = 0;
            while (!streamReader.EndOfStream)
            {
                flag = flag + 1;
                string str = streamReader.ReadLine();
                string[] split = str.Split(',');
                if (flag == 1)
                {
                    for (int i = 0; i < split.Length; i++)
                    {
                        DataColumn dataColumn = new DataColumn();
                        dataColumn.DataType = typeof(String);
                        dataColumn.ColumnName = split[i];
                        dataTable.Columns.Add(dataColumn);
                    }
                }
                if (flag >= 2)
                {
                    DataRow dataRow = dataTable.NewRow();
                    for (int i = 0; i < split.Length; i++)
                    {
                        dataRow[i] = split[i];
                    }
                    dataTable.Rows.Add(dataRow);
                }
            }
            streamReader.Close();
            return dataTable;
        }

        public static void DataTableToCsv(string filePath,DataTable dataTable)
        {
            if (dataTable == null || dataTable.Rows.Count == 0)
            {
                return;
            }
            string bufferLine = "";
            StreamWriter streamWriter = new StreamWriter(filePath,false,Encoding.Default);
            foreach (DataColumn item in dataTable.Columns)
            {
                bufferLine += item.ColumnName + ",";
                bufferLine.Substring(0,bufferLine.Length-1);
                streamWriter.WriteLine(bufferLine);
            }
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                bufferLine = "";
                for (int j = 0; j < dataTable.Columns.Count; j++)
                {
                    bufferLine += dataTable.Rows[i][j].ToString() + ",";
                }
                streamWriter.WriteLine(bufferLine);
            }
            streamWriter.Close();
        }
    }
}

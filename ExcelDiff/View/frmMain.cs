using Microsoft.Office.Interop.Excel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExcelDiff.View
{
    public partial class frmMain : Form
    {
        ArrayList tempList = new ArrayList();
        public frmMain()
        {
            InitializeComponent();
            cmdGenerate.Enabled = false;
        }

        private void btnSelectFile1_Click(object sender, EventArgs e)
        {
            cmdGenerate.Enabled = false;
            opFile.FileName = "";
            opFile.Filter = "Excel 97-2003 Workbook (*.xls)|*.xls|Excel Workbook (*.xlsx)|*.xlsx";
            if (opFile.ShowDialog() == DialogResult.OK)
            {
                txtFile1.Text = opFile.FileName;
            }
        }

        private void selectFile2_Click(object sender, EventArgs e)
        {
            cmdGenerate.Enabled = false;
            opFile.FileName = "";
            opFile.Filter = "Excel 97-2003 Workbook (*.xls)|*.xls|Excel Workbook (*.xlsx)|*.xlsx";
            if (opFile.ShowDialog() == DialogResult.OK)
            {
                txtFile2.Text = opFile.FileName;
            }
        }

        private void cmdCompare_Click(object sender, EventArgs e)
        {
            if (txtFile1.Text == "" || txtFile2.Text == "")
            {
                MessageBox.Show("Must specfic 2 Excel files");
            }
            else
            {
                //Compare
                if (new System.IO.FileInfo(txtFile1.Text).Length > new FileInfo(txtFile2.Text).Length)
                {
                    //The first one is larger
                    Compare(new FileInfo(txtFile1.Text), new FileInfo(txtFile2.Text));
                }
                else
                {
                    Compare(new FileInfo(txtFile2.Text), new FileInfo(txtFile1.Text));
                }

            }
        }

        private void Compare(FileInfo File1, FileInfo File2)
        {
            Microsoft.Office.Interop.Excel.Application app = new Microsoft.Office.Interop.Excel.Application();
            //1 large 2 small
            try
            {
                Microsoft.Office.Interop.Excel.Workbook wb = app.Workbooks.Open(File1.FullName, Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                        Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                        Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                        Type.Missing, Type.Missing);
                Microsoft.Office.Interop.Excel.Workbook wb2 = app.Workbooks.Open(File2.FullName, Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                        Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                        Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                        Type.Missing, Type.Missing);
                Worksheet oSheet = wb.Worksheets[1];
                Worksheet oSheet2 = wb2.Worksheets[1];
                Range excelRange = oSheet.UsedRange;
                Range excelRange2 = oSheet2.UsedRange;
                var temp = ArrayCheck(ConvertToArray(excelRange.Cells.Value2), ConvertToArray(excelRange2.Cells.Value2));
                foreach (string iTemp in temp)
                {
                    lstResult.Items.Add(iTemp);
                }
                cmdGenerate.Enabled = true;
                app.Quit();
            }
            catch (Exception ex)
            {
                app.Quit();
            }

        }

        private ArrayList ArrayCheck(ArrayList List1, ArrayList List2)
        {
            if(List1.Count > List2.Count)
            {
                //tempList = (ArrayList)List1.Clone();
                tempList.AddRange(List1);
                foreach (string temp in List1)
                {
                    foreach (string temp2 in List2)
                    {
                        if (temp == temp2)
                        {
                            tempList.Remove(temp);
                        }
                    }
                }
            }
            else
            {
                tempList.AddRange(List2);
                //tempList = (ArrayList)List2.Clone();

                foreach (string temp in List2)
                {
                    foreach (string temp2 in List1)
                    {
                        if (temp == temp2)
                        {
                            tempList.Remove(temp);
                        }
                    }
                }
            }
            

            return tempList;
        }

        private ArrayList ConvertToArray(object _Array)
        {
            ArrayList iReturnValue = new ArrayList();
            object[,] temp = (object[,])_Array;
            string _tempstr = "";

            for (int i = 1; i < temp.GetUpperBound(0)+1; i++)
            {
                _tempstr = "";
                for (int j = 1; j < temp.GetUpperBound(1)+1; j++)
                {
                    _tempstr += temp[i, j].ToString() + "\t";
                }
                iReturnValue.Add(_tempstr);
            }
            return iReturnValue;
        }


        private void cmdGenerate_Click(object sender, EventArgs e)
        {
            if (folderB.ShowDialog() == DialogResult.OK)
            {

                using (StreamWriter file = new StreamWriter(folderB.SelectedPath + @"\Result.csv" , false, Encoding.Unicode))
                {
                    foreach (string temp in tempList)
                    {
                        file.WriteLine(temp);
                        file.Flush();
                    }
                }

            }
        }
    }
}

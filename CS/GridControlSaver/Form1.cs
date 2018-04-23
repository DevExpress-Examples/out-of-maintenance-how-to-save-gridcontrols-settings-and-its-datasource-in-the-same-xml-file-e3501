using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GridControlSaver
{
    public partial class FormMain : Form
    {
        private DataTable dtListSource;
        private GCDataSaver dataSaverSource;
        private GCDataSaver dataSaverDest;


        public FormMain()
        {
            InitializeComponent();

            dtListSource = new DataTable("MyTable");
            dtListSource.Columns.AddRange(new DataColumn[] { new DataColumn("Col1"), new DataColumn("Col2") });
            for (int i = 0; i < 10; i++)
                dtListSource.Rows.Add(new string[] { "Col1_" + i.ToString(), "Col1_" + i.ToString() });

            gridContrlSource.DataSource = dtListSource;

            dataSaverSource = new GCDataSaver(gridContrlSource);
            dataSaverDest = new GCDataSaver(gridContrlDest);
        }



        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (buttonEdit1.Text == string.Empty) 
            {
                MessageBox.Show("You should specify name of file.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            dataSaverSource.SaveToXml(buttonEdit1.Text);
        }



        private void simpleButton2_Click(object sender, EventArgs e)
        {
            if (buttonEdit1.Text == string.Empty)
            {
                MessageBox.Show("You should specify name of file.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            dataSaverDest.RestoreFromXml(buttonEdit1.Text, dtListSource.GetType());
        }



        private void buttonEdit1_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (saveFileDialog1.ShowDialog() != DialogResult.OK) return;

            buttonEdit1.EditValue = saveFileDialog1.FileName;
        }
    }
}
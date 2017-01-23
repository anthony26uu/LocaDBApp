using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LocaDBApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dBDataSet.informacion' table. You can move, or remove it, as needed.
            this.informacionTableAdapter.Fill(this.dBDataSet.informacion);
            // TODO: This line of code loads data into the 'dBDataSet.informacion' table. You can move, or remove it, as needed.
            this.informacionTableAdapter.Fill(this.dBDataSet.informacion);
            timer1.Start();

        }

        private void informacionBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.informacionBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dBDataSet);

        }

        private void informacionBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.informacionBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dBDataSet);

        }

        private void informacionDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void edadLabel_Click(object sender, EventArgs e)
        {

        }

        private void informacionDataGridView_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.informacionBindingSource.AddNew();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.informacionBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dBDataSet);
            

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.informacionBindingSource.RemoveCurrent();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        int contador = 0;

        

        //private object label1_status;

        private void timer1_Tick(object sender, EventArgs e)
        {
            contador = informacionBindingSource.Count;       

            Estadolabel.Text = "Cantidad "+contador.ToString();

            if(contador<2)
            {
                button4.Visible = false;
                button5.Visible = false;

            }
            else
            {
                button4.Visible = true;
                button5.Visible = true;
            }
            



        }

        private void button4_Click(object sender, EventArgs e)
        {
            informacionBindingSource.MoveNext();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            informacionBindingSource.MovePrevious();

        }

        private void buscarNombreToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.informacionTableAdapter.BuscarNombre(this.dBDataSet.informacion, nameToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void buscarNombreToolStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}

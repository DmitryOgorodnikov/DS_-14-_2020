using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using serverW3;

namespace clientW3
{
    public partial class add1 : Form
    {
        Autoparts A = null;
        public add1()
        {
            InitializeComponent();
        }

        private void scb1_Scroll(object sender, ScrollEventArgs e)
        {
            lbprice.Text = scb1.Value.ToString();
        }

        private void add1_Load(object sender, EventArgs e)
        {
            txt3.Items.AddRange(getColumnB(Program.f1.Operations.getListB()));
            try
            {
                txt3.SelectedIndex = 0;
            }
            catch
            {
                MessageBox.Show(this, "Справочник Марок пуст!","Сообщение об ошибке", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btn8.Enabled = false;
            }
            txt4.Items.AddRange(getColumnP(Program.f1.Operations.getListP()));
            try
            {
                txt4.SelectedIndex = 0;
            }
            catch
            {
                MessageBox.Show(this, "Справочник Акций пуст!", "Сообщение об ошибке", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btn8.Enabled = false;
            }
            txt5.Items.AddRange(getColumnS(Program.f1.Operations.getListS()));
            try
            {
                txt5.SelectedIndex = 0;
            }
            catch
            {
                MessageBox.Show(this, "Справочник Поставщиков пуст!", "Сообщение об ошибке", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btn8.Enabled = false;
            }
            txt6.Items.AddRange(getColumnW(Program.f1.Operations.getListW()));
            try
            {
                txt6.SelectedIndex = 0;
            }
            catch
            {
                MessageBox.Show(this, "Справочник Гарантий пуст!", "Сообщение об ошибке", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btn8.Enabled = false;
            }
        }


        private Object[] getColumnB(List<Brands> lstB)
        {
            Object[] Cmodel = new Object[lstB.Count];
            int Iret = 0;
            foreach (Brands brands in lstB)
            {
                Cmodel[Iret] = brands.getName();
                Iret++;
            }
            return (Cmodel);
        }

        private Object[] getColumnP(List<Promotions> lstP)
        {
            Object[] Cmodel = new Object[lstP.Count];
            int Iret = 0;
            foreach (Promotions promotions in lstP)
            {
                Cmodel[Iret] = promotions.getName();
                Iret++;
            }
            return (Cmodel);
        }

        private Object[] getColumnS(List<Suppliers> lstS)
        {
            Object[] Cmodel = new Object[lstS.Count];
            int Iret = 0;
            foreach (Suppliers suppliers in lstS)
            {
                Cmodel[Iret] = suppliers.getName();
                Iret++;
            }
            return (Cmodel);
        }

        private Object[] getColumnW(List<Warranty> lstW)
        {
            Object[] Cmodel = new Object[lstW.Count];
            int Iret = 0;
            foreach (Warranty warranty in lstW)
            {
                Cmodel[Iret] = warranty.getType();
                Iret++;
            }
            return (Cmodel);
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            try
            {
                A = new Autoparts(Convert.ToInt32(txt1.Text), txt2.Text.ToString(), txt3.SelectedItem.ToString(), txt4.SelectedItem.ToString(), txt5.SelectedItem.ToString(), txt6.SelectedItem.ToString(), Convert.ToInt32(sp1.Value), Convert.ToInt32(scb1.Value));
                this.Close();
            }
            catch
            {
                MessageBox.Show(this, "Недопустимые данные!", "Сообщение об ошибке", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        public Autoparts getAutoparts
        {
            get
            {
                return A;
            }
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}

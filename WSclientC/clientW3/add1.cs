using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace clientW3
{
    public partial class add1 : Form
    {
        WSclientC.localhost.autoparts A = new WSclientC.localhost.autoparts();
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
            txt3.Items.AddRange(getColumnB(Program.f1.arrBrands));
            try
            {
                txt3.SelectedIndex = 0;
            }
            catch
            {
                MessageBox.Show(this, "Справочник Марок пуст!","Сообщение об ошибке", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btn8.Enabled = false;
            }
            txt4.Items.AddRange(getColumnP(Program.f1.arrPromotions));
            try
            {
                txt4.SelectedIndex = 0;
            }
            catch
            {
                MessageBox.Show(this, "Справочник Акций пуст!", "Сообщение об ошибке", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btn8.Enabled = false;
            }
            txt5.Items.AddRange(getColumnS(Program.f1.arrSuppliers));
            try
            {
                txt5.SelectedIndex = 0;
            }
            catch
            {
                MessageBox.Show(this, "Справочник Поставщиков пуст!", "Сообщение об ошибке", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btn8.Enabled = false;
            }
            txt6.Items.AddRange(getColumnW(Program.f1.arrWarranty));
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


        private Object[] getColumnB(WSclientC.localhost.brands[] lstB)
        {
            Object[] Cmodel = new Object[lstB.Length];
            int Iret = 0;
            foreach (WSclientC.localhost.brands brands in lstB)
            {
                Cmodel[Iret] = brands.name;
                Iret++;
            }
            return (Cmodel);
        }

        private Object[] getColumnP(WSclientC.localhost.promotions[] lstP)
        {
            Object[] Cmodel = new Object[lstP.Length];
            int Iret = 0;
            foreach (WSclientC.localhost.promotions promotions in lstP)
            {
                Cmodel[Iret] = promotions.name;
                Iret++;
            }
            return (Cmodel);
        }

        private Object[] getColumnS(WSclientC.localhost.suppliers[] lstS)
        {
            Object[] Cmodel = new Object[lstS.Length];
            int Iret = 0;
            foreach (WSclientC.localhost.suppliers suppliers in lstS)
            {
                Cmodel[Iret] = suppliers.name;
                Iret++;
            }
            return (Cmodel);
        }

        private Object[] getColumnW(WSclientC.localhost.warranty[] lstW)
        {
            Object[] Cmodel = new Object[lstW.Length];
            int Iret = 0;
            foreach (WSclientC.localhost.warranty warranty in lstW)
            {
                Cmodel[Iret] = warranty.type;
                Iret++;
            }
            return (Cmodel);
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            try
            {
                A.id = Convert.ToInt32(txt1.Text);
                A.name = txt2.Text.ToString();
                A.brand = txt3.SelectedItem.ToString();
                A.promotion = txt4.SelectedItem.ToString();
                A.supplie = txt5.SelectedItem.ToString();
                A.warranty = txt6.SelectedItem.ToString();
                A.kol = Convert.ToInt32(sp1.Value);
                A.price = Convert.ToInt32(scb1.Value);
                this.Close();
            }
            catch
            {
                MessageBox.Show(this, "Недопустимые данные!", "Сообщение об ошибке", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public WSclientC.localhost.autoparts getAutoparts
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

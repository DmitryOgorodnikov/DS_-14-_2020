using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WSclientC.localhost;


namespace clientW3
{
    public partial class Form1 : Form
    {

        public WSclientC.localhost.ServiceService service = new WSclientC.localhost.ServiceService();
        public WSclientC.localhost.autoparts[] arrAutoparts;
        public WSclientC.localhost.brands[] arrBrands;
        public WSclientC.localhost.promotions[] arrPromotions;
        public WSclientC.localhost.suppliers[] arrSuppliers;
        public WSclientC.localhost.warranty[] arrWarranty;
        public Form1()
        {
            Program.f1 = this;
            arrAutoparts = service.getA();
            InitializeComponent();
            arrBrands = service.getB();
            arrPromotions = service.getP();
            arrSuppliers = service.getS();
            arrWarranty = service.getW();
        }

        public void Form1_Load(object sender, EventArgs e)
        {

        }

        public int sw = 0;
        int add = 0;
        private void btn1_Click(object sender, EventArgs e)
        {
            //arrAutoparts = service.getA();
            btn6.Enabled = true;
            btnsum.Enabled = true;
            start.Visible = false;
            sw = 1;
            add = 1;
            btnsum.Enabled = true;
            Table.Columns.Clear();
            Table.Columns.Add("ID", "id");
            Table.Columns.Add("NAME","Название");
            Table.Columns.Add("BRAND", "Марка");
            Table.Columns.Add("SUPPLIER", "Поставщик");
            Table.Columns.Add("WARRANTY", "Гарантия");
            Table.Columns.Add("PROMOTION", "Акция");
            Table.Columns.Add("QUANTITY", "Количество");
            Table.Columns.Add("AMOUNT", "Сумма");
            doVivodA(arrAutoparts);
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            //arrBrands = service.getB();
            btn6.Enabled = true;
            btnsum.Enabled = false;
            txtsum.Text = "";
            start.Visible = false;
            sw = 2;
            add = 2;
            btnsum.Enabled = false;
            Table.Columns.Clear();
            Table.Columns.Add("NAME", "Имя");
            Table.Columns.Add("DESCRIPTION", "Описание");
            doVivodB(arrBrands);
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            //arrPromotions = service.getP();
            btn6.Enabled = true;
            btnsum.Enabled = false;
            txtsum.Text = "";
            start.Visible = false;
            sw = 3;
            add = 2;
            btnsum.Enabled = false;
            Table.Columns.Clear();
            Table.Columns.Add("NAME", "Имя");
            Table.Columns.Add("DATA", "Дата начала");
            Table.Columns.Add("DURATION", "Длительность(в днях)");
            Table.Columns.Add("DESCRIPTION", "Описание");
            doVivodP(arrPromotions);
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            //arrSuppliers = service.getS();
            btn6.Enabled = true;
            btnsum.Enabled = false;
            txtsum.Text = "";
            start.Visible = false;
            sw = 4;
            add = 2;
            btnsum.Enabled = false;
            Table.Columns.Clear();
            Table.Columns.Add("NAME", "Имя");
            Table.Columns.Add("ADDRESS", "Адрес");
            Table.Columns.Add("Number", "Номер");
            Table.Columns.Add("INN", "ИНН");
            doVivodS(arrSuppliers);
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            //arrWarranty = service.getW();
            btn6.Enabled = true;
            btnsum.Enabled = false;
            txtsum.Text = "";
            start.Visible = false;
            sw = 5;
            add = 2;
            btnsum.Enabled = false;
            Table.Columns.Clear();
            Table.Columns.Add("TYPE", "Тип");
            Table.Columns.Add("DURATION", "Длительность (в месяцах)");
            doVivodW(arrWarranty);
        }
    
        private void btn6_Click(object sender, EventArgs e)
        {
            switch (add)
            {
                case 1:
                    txtsum.Text = "";
                    add1 a1 = new add1();
                    a1.ShowDialog();
                    if (a1.getAutoparts != null)
                    {
                        try
                        {
                            Table.Rows.Clear();
                            doVivodA(service.setA(a1.getAutoparts));
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(this, "Ошибка соединения: +" + ex, "Сообщение об ошибке", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }
                    break;
                case 2:
                    add2 a2 = new add2();
                    a2.ShowDialog();
                    switch(sw)
                    {
                        case 2:
                            if (a2.getBrands != null)
                            {
                                try
                                {
                                    Table.Rows.Clear();
                                    doVivodB(service.setB(a2.getBrands));
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show(this, "Ошибка соединения: +" + ex, "Сообщение об ошибке", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            break;
                        case 3:
                            if (a2.getPromotions != null)
                            {
                                try
                                {
                                    Table.Rows.Clear();
                                    doVivodP(service.setP(a2.getPromotions));
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show(this, "Ошибка соединения: +" + ex, "Сообщение об ошибке", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            break;
                        case 4:
                            if (a2.getSuppliers != null)
                            {
                                try
                                {
                                    Table.Rows.Clear();
                                    doVivodS(service.setS(a2.getSuppliers));
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show(this, "Ошибка соединения: +" + ex, "Сообщение об ошибке", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            break;
                        case 5:
                            if (a2.getWarranty != null)
                            {
                                try
                                {
                                    Table.Rows.Clear();
                                    doVivodW(service.setW(a2.getWarranty));
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show(this, "Ошибка соединения: +" + ex, "Сообщение об ошибке", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            break;
                    }
                    break;
            }
        }
        public void doVivodA(autoparts[] lstA)
        {
            foreach (WSclientC.localhost.autoparts autoparts in lstA)
            {
                Object[] rowData = new Object[8];
                rowData[0] = autoparts.id;
                rowData[1] = autoparts.name;
                rowData[2] = autoparts.brand;
                rowData[3] = autoparts.promotion;
                rowData[4] = autoparts.supplie;
                rowData[5] = autoparts.warranty;
                rowData[6] = autoparts.kol;
                rowData[7] = autoparts.kol*autoparts.price;
                Table.Rows.Add(rowData);
            }
        }

        private void doVivodB(brands[] lstB)
        {
            foreach (WSclientC.localhost.brands brands in lstB)
            {
                Object[] rowData = new Object[2];
                rowData[0] = brands.name;
                rowData[1] = brands.description;
                Table.Rows.Add(rowData);
            }
        }

        private void doVivodP(promotions[] lstP)
        {
            foreach (WSclientC.localhost.promotions promotions in lstP)
            {
                Object[] rowData = new Object[4];
                rowData[0] = promotions.name;
                rowData[1] = promotions.data;
                rowData[2] = promotions.duration;
                rowData[3] = promotions.essence;
                Table.Rows.Add(rowData);
            }
        }

        private void doVivodS(suppliers[] lstS)
        {
            foreach (WSclientC.localhost.suppliers suppliers in lstS)
            {
                Object[] rowData = new Object[4];
                rowData[0] = suppliers.name;
                rowData[1] = suppliers.address;
                rowData[2] = suppliers.telephone;
                rowData[3] = suppliers.inn;
                Table.Rows.Add(rowData);
            }
        }

        private void doVivodW(warranty[] lstW)
        {
            foreach (WSclientC.localhost.warranty warranty in lstW)
            {
                Object[] rowData = new Object[2];
                rowData[0] = warranty.type;
                rowData[1] = warranty.duration;
                Table.Rows.Add(rowData);
            }
        }


        private void btn7_Click(object sender, EventArgs e)
        {
            int SR = Table.Rows.GetRowCount(DataGridViewElementStates.Selected);
            switch (sw)
            {
                case 1:
                    txtsum.Text = "";
                    Table.Rows.Clear();
                    doVivodA(service.remA(SR));
                    break;
                case 2:
                    Table.Rows.Clear();
                    doVivodB(service.remB(SR));
                    break;
                case 3:
                    Table.Rows.Clear();
                    doVivodP(service.remP(SR));
                    break;
                case 4:
                    Table.Rows.Clear();
                    doVivodS(service.remS(SR));
                    break;
                case 5:
                    Table.Rows.Clear();
                    doVivodW(service.remW(SR));
                    break;
            }
        }

        private void Table_SelectionChanged(object sender, EventArgs e)
        {
            btn7.Enabled = true;
        }

        private void btnsum_Click(object sender, EventArgs e)
        {
            txtsum.Text = Convert.ToString(service.getSumA());
        }
    }
}

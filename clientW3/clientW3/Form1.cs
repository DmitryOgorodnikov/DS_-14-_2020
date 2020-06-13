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
    public partial class Form1 : Form
    {

        public Operation Operations = null;
        public Form1()
        {
            Program.f1 = this;
            InitializeComponent();
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                TcpClientChannel chan = new TcpClientChannel();
                ChannelServices.RegisterChannel(chan, false);
                Operations = (Operation)Activator.GetObject(
                typeof(Operation), "tcp://localhost:9000/TalkIsGood");
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Ошибка соединения: +" + ex, "Сообщение об ошибке", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public int sw = 0;
        int add = 0;
        private void btn1_Click(object sender, EventArgs e)
        {
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
            doVivodA(Operations.getListA());
        }

        private void btn2_Click(object sender, EventArgs e)
        {
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
            doVivodB(Operations.getListB());
        }

        private void btn3_Click(object sender, EventArgs e)
        {
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
            doVivodP(Operations.getListP());
        }

        private void btn4_Click(object sender, EventArgs e)
        {
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
            doVivodS(Operations.getListS());
        }

        private void btn5_Click(object sender, EventArgs e)
        {
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
            doVivodW(Operations.getListW());
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
                            doVivodA(Operations.addNewAutopart(a1.getAutoparts));
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
                                    doVivodB(Operations.addNewBrand(a2.getBrands));
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
                                    doVivodP(Operations.addNewPromotion(a2.getPromotions));
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
                                    doVivodS(Operations.addNewSupplier(a2.getSuppliers));
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
                                    doVivodW(Operations.addNewWarranty(a2.getWarranty));
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

        public void doVivodA(List<Autoparts> lstA)
        {
            foreach (Autoparts autoparts in lstA)
            {
                Object[] rowData = new Object[8];
                rowData[0] = autoparts.getId();
                rowData[1] = autoparts.getName();
                rowData[2] = autoparts.getBrand();
                rowData[3] = autoparts.getPromotion();
                rowData[4] = autoparts.getSupplie();
                rowData[5] = autoparts.getWarranty();
                rowData[6] = autoparts.getKol();
                rowData[7] = autoparts.getKol()*autoparts.getPrice();
                Table.Rows.Add(rowData);
            }
        }

        private void doVivodB(List<Brands> lstB)
        {
            foreach (Brands brands in lstB)
            {
                Object[] rowData = new Object[2];
                rowData[0] = brands.getName();
                rowData[1] = brands.getDescription();
                Table.Rows.Add(rowData);
            }
        }

        private void doVivodP(List<Promotions> lstP)
        {
            foreach (Promotions promotions in lstP)
            {
                Object[] rowData = new Object[4];
                rowData[0] = promotions.getName();
                rowData[1] = promotions.getData();
                rowData[2] = promotions.getDuration();
                rowData[3] = promotions.getEssence();
                Table.Rows.Add(rowData);
            }
        }

        private void doVivodS(List<Suppliers> lstS)
        {
            foreach (Suppliers suppliers in lstS)
            {
                Object[] rowData = new Object[4];
                rowData[0] = suppliers.getName();
                rowData[1] = suppliers.getAddress();
                rowData[2] = suppliers.getTelephone();
                rowData[3] = suppliers.getInn();
                Table.Rows.Add(rowData);
            }
        }

        private void doVivodW(List<Warranty> lstW)
        {
            foreach (Warranty warranty in lstW)
            {
                Object[] rowData = new Object[2];
                rowData[0] = warranty.getType();
                rowData[1] = warranty.getDuration();
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
                    doVivodA(Operations.remListA(SR));
                    break;
                case 2:
                    Table.Rows.Clear();
                    doVivodB(Operations.remListB(SR));
                    break;
                case 3:
                    Table.Rows.Clear();
                    doVivodP(Operations.remListP(SR));
                    break;
                case 4:
                    Table.Rows.Clear();
                    doVivodS(Operations.remListS(SR));
                    break;
                case 5:
                    Table.Rows.Clear();
                    doVivodW(Operations.remListW(SR));
                    break;
            }
        }

        private void Table_SelectionChanged(object sender, EventArgs e)
        {
            btn7.Enabled = true;
        }

        private void btnsum_Click(object sender, EventArgs e)
        {
            txtsum.Text = Convert.ToString(Operations.getSum());
        }

    }
}

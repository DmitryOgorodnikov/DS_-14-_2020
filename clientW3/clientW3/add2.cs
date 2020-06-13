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
    public partial class add2 : Form
    {
        Brands B = null;
        Promotions P = null;
        Suppliers S = null;
        Warranty W = null;
        public add2()
        {
            InitializeComponent();
            switch(Program.f1.sw)
            {
                case 2:
                    lb01.Text = "Имя";
                    lb02.Text = "Описание";
                    lb03.Text = "";
                    lb04.Text = "";
                    txt03.Visible = false;
                    txt04.Visible = false;
                    break;
                case 3:
                    lb01.Text = "Имя";
                    lb02.Text = "Дата начала(День.Месяц.Год)";
                    lb03.Text = "Длительность(в днях)";
                    lb04.Text = "Описание";
                    txt03.Visible = true;
                    txt04.Visible = true;
                    break;
                case 4:
                    lb01.Text = "Имя";
                    lb02.Text = "Адрес";
                    lb03.Text = "Номер";
                    lb04.Text = "ИНН";
                    txt03.Visible = true;
                    txt04.Visible = true;
                    break;
                case 5:
                    lb01.Text = "Тип";
                    lb02.Text = "Длительность (в месяцах)";
                    lb03.Text = "";
                    lb04.Text = "";
                    txt03.Visible = false;
                    txt04.Visible = false;
                    break;
            }
        }

        private void btn10_Click(object sender, EventArgs e)
        {
            switch (Program.f1.sw)
            {
                case 2:
                    try
                    {
                        B = new Brands(txt01.Text.ToString(), txt02.Text.ToString());
                        this.Close();
                    }
                    catch
                    {
                        MessageBox.Show(this, "Недопустимые данные!", "Сообщение об ошибке", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;
                case 3:
                    try
                    {
                        P = new Promotions(txt01.Text.ToString(), txt02.Text.ToString(), Convert.ToInt32(txt03.Text), txt04.Text.ToString());
                        this.Close();
                    }
                    catch
                    {
                        MessageBox.Show(this, "Недопустимые данные!", "Сообщение об ошибке", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;
                case 4:
                    try
                    {
                        S = new Suppliers(txt01.Text.ToString(), txt02.Text.ToString(), Convert.ToInt64(txt03.Text), Convert.ToInt64(txt04.Text));
                        this.Close();
                    }
                    catch
                    {
                        MessageBox.Show(this, "Недопустимые данные!", "Сообщение об ошибке", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;
                case 5:
                    try
                    {
                        W = new Warranty(txt01.Text.ToString(), Convert.ToInt32(txt02.Text));
                        this.Close();
                    }
                    catch
                    {
                        MessageBox.Show(this, "Недопустимые данные!", "Сообщение об ошибке", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;
            }
        }

        public Brands getBrands
        {
            get
            {
                return B;
            }
        }

        public Promotions getPromotions
        {
            get
            {
                return P;
            }
        }

        public Suppliers getSuppliers
        {
            get
            {
                return S;
            }
        }

        public Warranty getWarranty
        {
            get
            {
                return W;
            }
        }

        private void btn11_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}

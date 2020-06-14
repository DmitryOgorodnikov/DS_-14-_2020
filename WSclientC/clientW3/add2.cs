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
    public partial class add2 : Form
    {
        WSclientC.localhost.brands B = new WSclientC.localhost.brands();
        WSclientC.localhost.promotions P = new WSclientC.localhost.promotions();
        WSclientC.localhost.suppliers S = new WSclientC.localhost.suppliers();
        WSclientC.localhost.warranty W = new WSclientC.localhost.warranty();
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
                    string ABC = B.name;
                    try
                    {
                        B.name = txt01.Text.ToString();
                        B.description = txt02.Text.ToString();
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
                        P.name = txt01.Text.ToString();
                        P.data = txt02.Text.ToString();
                        P.duration = Convert.ToInt32(txt03.Text);
                        P.essence = txt04.Text.ToString();
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
                        S.name = txt01.Text.ToString();
                        S.address = txt02.Text.ToString();
                        S.telephone = Convert.ToInt64(txt03.Text);
                        S.inn = Convert.ToInt64(txt04.Text);
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
                        W.type = txt01.Text.ToString();
                        W.duration = Convert.ToInt32(txt02.Text);
                        this.Close();
                    }
                    catch
                    {
                        MessageBox.Show(this, "Недопустимые данные!", "Сообщение об ошибке", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;
            }
        }

        public WSclientC.localhost.brands getBrands
        {
            get
            {
                return B;
            }
        }

        public WSclientC.localhost.promotions getPromotions
        {
            get
            {
                return P;
            }
        }

        public WSclientC.localhost.suppliers getSuppliers
        {
            get
            {
                return S;
            }
        }

        public WSclientC.localhost.warranty getWarranty
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

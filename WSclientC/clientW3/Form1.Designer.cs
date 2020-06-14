namespace clientW3
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lb1 = new System.Windows.Forms.Label();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.lb8 = new System.Windows.Forms.Label();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btnsum = new System.Windows.Forms.Button();
            this.txtsum = new System.Windows.Forms.TextBox();
            this.Table = new System.Windows.Forms.DataGridView();
            this.start = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Table)).BeginInit();
            this.SuspendLayout();
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.Location = new System.Drawing.Point(13, 13);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(76, 13);
            this.lb1.TabIndex = 0;
            this.lb1.Text = "Справочники:";
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(95, 8);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(86, 23);
            this.btn1.TabIndex = 1;
            this.btn1.Text = "Автозапчасти";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(187, 8);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(75, 23);
            this.btn2.TabIndex = 2;
            this.btn2.Text = "Марки";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(268, 8);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(75, 23);
            this.btn3.TabIndex = 3;
            this.btn3.Text = "Акции";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(349, 8);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(75, 23);
            this.btn4.TabIndex = 4;
            this.btn4.Text = "Поставщики";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btn5
            // 
            this.btn5.Location = new System.Drawing.Point(430, 8);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(75, 23);
            this.btn5.TabIndex = 5;
            this.btn5.Text = "Гарантия";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // lb8
            // 
            this.lb8.AutoSize = true;
            this.lb8.Location = new System.Drawing.Point(511, 13);
            this.lb8.Name = "lb8";
            this.lb8.Size = new System.Drawing.Size(252, 13);
            this.lb8.TabIndex = 6;
            this.lb8.Text = "Огородников Дмитрий Алексеевич - Вариант 14";
            // 
            // btn6
            // 
            this.btn6.Enabled = false;
            this.btn6.Location = new System.Drawing.Point(16, 338);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(75, 23);
            this.btn6.TabIndex = 8;
            this.btn6.Text = "Добавить";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.btn6_Click);
            // 
            // btn7
            // 
            this.btn7.Enabled = false;
            this.btn7.Location = new System.Drawing.Point(97, 338);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(75, 23);
            this.btn7.TabIndex = 9;
            this.btn7.Text = "Удалить";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.btn7_Click);
            // 
            // btnsum
            // 
            this.btnsum.Enabled = false;
            this.btnsum.Location = new System.Drawing.Point(556, 339);
            this.btnsum.Name = "btnsum";
            this.btnsum.Size = new System.Drawing.Size(111, 23);
            this.btnsum.TabIndex = 10;
            this.btnsum.Text = "Подсчитать сумму";
            this.btnsum.UseVisualStyleBackColor = true;
            this.btnsum.Click += new System.EventHandler(this.btnsum_Click);
            // 
            // txtsum
            // 
            this.txtsum.Location = new System.Drawing.Point(673, 341);
            this.txtsum.Name = "txtsum";
            this.txtsum.Size = new System.Drawing.Size(90, 20);
            this.txtsum.TabIndex = 11;
            // 
            // Table
            // 
            this.Table.AllowUserToAddRows = false;
            this.Table.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.Table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Table.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.Table.Location = new System.Drawing.Point(16, 37);
            this.Table.Name = "Table";
            this.Table.Size = new System.Drawing.Size(747, 295);
            this.Table.TabIndex = 12;
            this.Table.SelectionChanged += new System.EventHandler(this.Table_SelectionChanged);
            // 
            // start
            // 
            this.start.AutoSize = true;
            this.start.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.start.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.start.Location = new System.Drawing.Point(229, 161);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(291, 31);
            this.start.TabIndex = 13;
            this.start.Text = "Выберите справочник";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 367);
            this.Controls.Add(this.start);
            this.Controls.Add(this.Table);
            this.Controls.Add(this.txtsum);
            this.Controls.Add(this.btnsum);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.lb8);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.lb1);
            this.Name = "Form1";
            this.Text = "Самостоятельная работа 4";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Table)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Label lb8;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btnsum;
        private System.Windows.Forms.TextBox txtsum;
        private System.Windows.Forms.DataGridView Table;
        private System.Windows.Forms.Label start;
    }
}


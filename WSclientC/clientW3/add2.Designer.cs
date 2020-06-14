namespace clientW3
{
    partial class add2
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
            this.lb01 = new System.Windows.Forms.Label();
            this.lb02 = new System.Windows.Forms.Label();
            this.lb03 = new System.Windows.Forms.Label();
            this.lb04 = new System.Windows.Forms.Label();
            this.txt01 = new System.Windows.Forms.TextBox();
            this.txt02 = new System.Windows.Forms.TextBox();
            this.txt03 = new System.Windows.Forms.TextBox();
            this.txt04 = new System.Windows.Forms.TextBox();
            this.btn10 = new System.Windows.Forms.Button();
            this.btn11 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb01
            // 
            this.lb01.AutoSize = true;
            this.lb01.Location = new System.Drawing.Point(12, 8);
            this.lb01.Name = "lb01";
            this.lb01.Size = new System.Drawing.Size(10, 13);
            this.lb01.TabIndex = 0;
            this.lb01.Text = "-";
            // 
            // lb02
            // 
            this.lb02.AutoSize = true;
            this.lb02.Location = new System.Drawing.Point(12, 34);
            this.lb02.Name = "lb02";
            this.lb02.Size = new System.Drawing.Size(10, 13);
            this.lb02.TabIndex = 7;
            this.lb02.Text = "-";
            // 
            // lb03
            // 
            this.lb03.AutoSize = true;
            this.lb03.Location = new System.Drawing.Point(12, 60);
            this.lb03.Name = "lb03";
            this.lb03.Size = new System.Drawing.Size(10, 13);
            this.lb03.TabIndex = 8;
            this.lb03.Text = "-";
            // 
            // lb04
            // 
            this.lb04.AutoSize = true;
            this.lb04.Location = new System.Drawing.Point(12, 86);
            this.lb04.Name = "lb04";
            this.lb04.Size = new System.Drawing.Size(10, 13);
            this.lb04.TabIndex = 9;
            this.lb04.Text = "-";
            // 
            // txt01
            // 
            this.txt01.Location = new System.Drawing.Point(213, 8);
            this.txt01.Name = "txt01";
            this.txt01.Size = new System.Drawing.Size(158, 20);
            this.txt01.TabIndex = 10;
            // 
            // txt02
            // 
            this.txt02.Location = new System.Drawing.Point(213, 34);
            this.txt02.Name = "txt02";
            this.txt02.Size = new System.Drawing.Size(158, 20);
            this.txt02.TabIndex = 11;
            // 
            // txt03
            // 
            this.txt03.Location = new System.Drawing.Point(213, 60);
            this.txt03.Name = "txt03";
            this.txt03.Size = new System.Drawing.Size(158, 20);
            this.txt03.TabIndex = 12;
            // 
            // txt04
            // 
            this.txt04.Location = new System.Drawing.Point(213, 86);
            this.txt04.Name = "txt04";
            this.txt04.Size = new System.Drawing.Size(158, 20);
            this.txt04.TabIndex = 13;
            // 
            // btn10
            // 
            this.btn10.Location = new System.Drawing.Point(12, 134);
            this.btn10.Name = "btn10";
            this.btn10.Size = new System.Drawing.Size(75, 23);
            this.btn10.TabIndex = 14;
            this.btn10.Text = "Ок";
            this.btn10.UseVisualStyleBackColor = true;
            this.btn10.Click += new System.EventHandler(this.btn10_Click);
            // 
            // btn11
            // 
            this.btn11.Location = new System.Drawing.Point(296, 134);
            this.btn11.Name = "btn11";
            this.btn11.Size = new System.Drawing.Size(75, 23);
            this.btn11.TabIndex = 15;
            this.btn11.Text = "Отмена";
            this.btn11.UseVisualStyleBackColor = true;
            this.btn11.Click += new System.EventHandler(this.btn11_Click);
            // 
            // add2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 163);
            this.Controls.Add(this.btn11);
            this.Controls.Add(this.btn10);
            this.Controls.Add(this.txt04);
            this.Controls.Add(this.txt03);
            this.Controls.Add(this.txt02);
            this.Controls.Add(this.txt01);
            this.Controls.Add(this.lb04);
            this.Controls.Add(this.lb03);
            this.Controls.Add(this.lb02);
            this.Controls.Add(this.lb01);
            this.Name = "add2";
            this.Text = "add1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb01;
        private System.Windows.Forms.Label lb02;
        private System.Windows.Forms.Label lb03;
        private System.Windows.Forms.Label lb04;
        private System.Windows.Forms.TextBox txt01;
        private System.Windows.Forms.TextBox txt02;
        private System.Windows.Forms.TextBox txt03;
        private System.Windows.Forms.TextBox txt04;
        private System.Windows.Forms.Button btn10;
        private System.Windows.Forms.Button btn11;
    }
}
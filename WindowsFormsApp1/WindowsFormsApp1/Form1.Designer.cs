namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox_vvod = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label_result = new System.Windows.Forms.Label();
            this.button_I = new System.Windows.Forms.Button();
            this.button_V = new System.Windows.Forms.Button();
            this.button_X = new System.Windows.Forms.Button();
            this.button_L = new System.Windows.Forms.Button();
            this.button_C = new System.Windows.Forms.Button();
            this.button_D = new System.Windows.Forms.Button();
            this.button_M = new System.Windows.Forms.Button();
            this.button_0 = new System.Windows.Forms.Button();
            this.button_1 = new System.Windows.Forms.Button();
            this.button_2 = new System.Windows.Forms.Button();
            this.button_3 = new System.Windows.Forms.Button();
            this.button_4 = new System.Windows.Forms.Button();
            this.button_5 = new System.Windows.Forms.Button();
            this.button_6 = new System.Windows.Forms.Button();
            this.button_7 = new System.Windows.Forms.Button();
            this.button_8 = new System.Windows.Forms.Button();
            this.button_9 = new System.Windows.Forms.Button();
            this.button_plus = new System.Windows.Forms.Button();
            this.button_minus = new System.Windows.Forms.Button();
            this.button_umnozhit = new System.Windows.Forms.Button();
            this.button_div = new System.Windows.Forms.Button();
            this.button_mod = new System.Windows.Forms.Button();
            this.button1_to_10 = new System.Windows.Forms.Button();
            this.button_toX = new System.Windows.Forms.Button();
            this.button_ravno = new System.Windows.Forms.Button();
            this.button_ce = new System.Windows.Forms.Button();
            this.button_clean = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_vvod
            // 
            this.textBox_vvod.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_vvod.Location = new System.Drawing.Point(12, 7);
            this.textBox_vvod.Name = "textBox_vvod";
            this.textBox_vvod.ReadOnly = true;
            this.textBox_vvod.Size = new System.Drawing.Size(338, 34);
            this.textBox_vvod.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "Результат:";
            // 
            // label_result
            // 
            this.label_result.AutoSize = true;
            this.label_result.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_result.Location = new System.Drawing.Point(130, 54);
            this.label_result.Name = "label_result";
            this.label_result.Size = new System.Drawing.Size(60, 27);
            this.label_result.TabIndex = 2;
            this.label_result.Text = "____";
            // 
            // button_I
            // 
            this.button_I.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_I.Location = new System.Drawing.Point(15, 117);
            this.button_I.Name = "button_I";
            this.button_I.Size = new System.Drawing.Size(44, 39);
            this.button_I.TabIndex = 3;
            this.button_I.Text = "I";
            this.button_I.UseVisualStyleBackColor = true;
            this.button_I.Click += new System.EventHandler(this.button_I_Click);
            // 
            // button_V
            // 
            this.button_V.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_V.Location = new System.Drawing.Point(65, 117);
            this.button_V.Name = "button_V";
            this.button_V.Size = new System.Drawing.Size(44, 39);
            this.button_V.TabIndex = 4;
            this.button_V.Text = "V";
            this.button_V.UseVisualStyleBackColor = true;
            this.button_V.Click += new System.EventHandler(this.button_V_Click);
            // 
            // button_X
            // 
            this.button_X.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_X.Location = new System.Drawing.Point(115, 117);
            this.button_X.Name = "button_X";
            this.button_X.Size = new System.Drawing.Size(44, 39);
            this.button_X.TabIndex = 5;
            this.button_X.Text = "X";
            this.button_X.UseVisualStyleBackColor = true;
            this.button_X.Click += new System.EventHandler(this.button_X_Click);
            // 
            // button_L
            // 
            this.button_L.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_L.Location = new System.Drawing.Point(165, 117);
            this.button_L.Name = "button_L";
            this.button_L.Size = new System.Drawing.Size(44, 39);
            this.button_L.TabIndex = 6;
            this.button_L.Text = "L";
            this.button_L.UseVisualStyleBackColor = true;
            this.button_L.Click += new System.EventHandler(this.button_L_Click);
            // 
            // button_C
            // 
            this.button_C.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_C.Location = new System.Drawing.Point(35, 162);
            this.button_C.Name = "button_C";
            this.button_C.Size = new System.Drawing.Size(44, 39);
            this.button_C.TabIndex = 7;
            this.button_C.Text = "C";
            this.button_C.UseVisualStyleBackColor = true;
            this.button_C.Click += new System.EventHandler(this.button_C_Click);
            // 
            // button_D
            // 
            this.button_D.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_D.Location = new System.Drawing.Point(85, 162);
            this.button_D.Name = "button_D";
            this.button_D.Size = new System.Drawing.Size(44, 39);
            this.button_D.TabIndex = 8;
            this.button_D.Text = "D";
            this.button_D.UseVisualStyleBackColor = true;
            this.button_D.Click += new System.EventHandler(this.button_D_Click);
            // 
            // button_M
            // 
            this.button_M.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_M.Location = new System.Drawing.Point(135, 162);
            this.button_M.Name = "button_M";
            this.button_M.Size = new System.Drawing.Size(44, 39);
            this.button_M.TabIndex = 9;
            this.button_M.Text = "M";
            this.button_M.UseVisualStyleBackColor = true;
            this.button_M.Click += new System.EventHandler(this.button_M_Click);
            // 
            // button_0
            // 
            this.button_0.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_0.Location = new System.Drawing.Point(15, 207);
            this.button_0.Name = "button_0";
            this.button_0.Size = new System.Drawing.Size(34, 32);
            this.button_0.TabIndex = 10;
            this.button_0.Text = "0";
            this.button_0.UseVisualStyleBackColor = true;
            this.button_0.Click += new System.EventHandler(this.button_0_Click);
            // 
            // button_1
            // 
            this.button_1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_1.Location = new System.Drawing.Point(55, 207);
            this.button_1.Name = "button_1";
            this.button_1.Size = new System.Drawing.Size(34, 32);
            this.button_1.TabIndex = 11;
            this.button_1.Text = "1";
            this.button_1.UseVisualStyleBackColor = true;
            this.button_1.Click += new System.EventHandler(this.button_1_Click);
            // 
            // button_2
            // 
            this.button_2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_2.Location = new System.Drawing.Point(95, 207);
            this.button_2.Name = "button_2";
            this.button_2.Size = new System.Drawing.Size(34, 32);
            this.button_2.TabIndex = 12;
            this.button_2.Text = "2";
            this.button_2.UseVisualStyleBackColor = true;
            this.button_2.Click += new System.EventHandler(this.button_2_Click);
            // 
            // button_3
            // 
            this.button_3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_3.Location = new System.Drawing.Point(135, 207);
            this.button_3.Name = "button_3";
            this.button_3.Size = new System.Drawing.Size(34, 32);
            this.button_3.TabIndex = 13;
            this.button_3.Text = "3";
            this.button_3.UseVisualStyleBackColor = true;
            this.button_3.Click += new System.EventHandler(this.button_3_Click);
            // 
            // button_4
            // 
            this.button_4.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_4.Location = new System.Drawing.Point(175, 207);
            this.button_4.Name = "button_4";
            this.button_4.Size = new System.Drawing.Size(34, 32);
            this.button_4.TabIndex = 14;
            this.button_4.Text = "4";
            this.button_4.UseVisualStyleBackColor = true;
            this.button_4.Click += new System.EventHandler(this.button_4_Click);
            // 
            // button_5
            // 
            this.button_5.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_5.Location = new System.Drawing.Point(15, 245);
            this.button_5.Name = "button_5";
            this.button_5.Size = new System.Drawing.Size(34, 32);
            this.button_5.TabIndex = 15;
            this.button_5.Text = "5";
            this.button_5.UseVisualStyleBackColor = true;
            this.button_5.Click += new System.EventHandler(this.button_5_Click);
            // 
            // button_6
            // 
            this.button_6.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_6.Location = new System.Drawing.Point(55, 245);
            this.button_6.Name = "button_6";
            this.button_6.Size = new System.Drawing.Size(34, 32);
            this.button_6.TabIndex = 16;
            this.button_6.Text = "6";
            this.button_6.UseVisualStyleBackColor = true;
            this.button_6.Click += new System.EventHandler(this.button_6_Click);
            // 
            // button_7
            // 
            this.button_7.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_7.Location = new System.Drawing.Point(95, 245);
            this.button_7.Name = "button_7";
            this.button_7.Size = new System.Drawing.Size(34, 32);
            this.button_7.TabIndex = 17;
            this.button_7.Text = "7";
            this.button_7.UseVisualStyleBackColor = true;
            this.button_7.Click += new System.EventHandler(this.button_7_Click);
            // 
            // button_8
            // 
            this.button_8.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_8.Location = new System.Drawing.Point(135, 245);
            this.button_8.Name = "button_8";
            this.button_8.Size = new System.Drawing.Size(34, 32);
            this.button_8.TabIndex = 18;
            this.button_8.Text = "8";
            this.button_8.UseVisualStyleBackColor = true;
            this.button_8.Click += new System.EventHandler(this.button_8_Click);
            // 
            // button_9
            // 
            this.button_9.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_9.Location = new System.Drawing.Point(175, 245);
            this.button_9.Name = "button_9";
            this.button_9.Size = new System.Drawing.Size(34, 32);
            this.button_9.TabIndex = 19;
            this.button_9.Text = "9";
            this.button_9.UseVisualStyleBackColor = true;
            this.button_9.Click += new System.EventHandler(this.button_9_Click);
            // 
            // button_plus
            // 
            this.button_plus.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_plus.Location = new System.Drawing.Point(230, 88);
            this.button_plus.Name = "button_plus";
            this.button_plus.Size = new System.Drawing.Size(56, 39);
            this.button_plus.TabIndex = 20;
            this.button_plus.Text = "+";
            this.button_plus.UseVisualStyleBackColor = true;
            this.button_plus.Click += new System.EventHandler(this.button_plus_Click);
            // 
            // button_minus
            // 
            this.button_minus.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_minus.Location = new System.Drawing.Point(292, 88);
            this.button_minus.Name = "button_minus";
            this.button_minus.Size = new System.Drawing.Size(56, 39);
            this.button_minus.TabIndex = 21;
            this.button_minus.Text = "-";
            this.button_minus.UseVisualStyleBackColor = true;
            this.button_minus.Click += new System.EventHandler(this.button_minus_Click);
            // 
            // button_umnozhit
            // 
            this.button_umnozhit.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_umnozhit.Location = new System.Drawing.Point(230, 130);
            this.button_umnozhit.Name = "button_umnozhit";
            this.button_umnozhit.Size = new System.Drawing.Size(56, 39);
            this.button_umnozhit.TabIndex = 22;
            this.button_umnozhit.Text = "*";
            this.button_umnozhit.UseVisualStyleBackColor = true;
            this.button_umnozhit.Click += new System.EventHandler(this.button_umnozhit_Click);
            // 
            // button_div
            // 
            this.button_div.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_div.Location = new System.Drawing.Point(292, 130);
            this.button_div.Name = "button_div";
            this.button_div.Size = new System.Drawing.Size(56, 39);
            this.button_div.TabIndex = 23;
            this.button_div.Text = "DIV";
            this.button_div.UseVisualStyleBackColor = true;
            this.button_div.Click += new System.EventHandler(this.button_div_Click);
            // 
            // button_mod
            // 
            this.button_mod.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_mod.Location = new System.Drawing.Point(230, 171);
            this.button_mod.Name = "button_mod";
            this.button_mod.Size = new System.Drawing.Size(56, 39);
            this.button_mod.TabIndex = 24;
            this.button_mod.Text = "MOD";
            this.button_mod.UseVisualStyleBackColor = true;
            this.button_mod.Click += new System.EventHandler(this.button_mod_Click);
            // 
            // button1_to_10
            // 
            this.button1_to_10.Font = new System.Drawing.Font("Times New Roman", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1_to_10.Location = new System.Drawing.Point(292, 171);
            this.button1_to_10.Name = "button1_to_10";
            this.button1_to_10.Size = new System.Drawing.Size(56, 39);
            this.button1_to_10.TabIndex = 25;
            this.button1_to_10.Text = "X->10";
            this.button1_to_10.UseVisualStyleBackColor = true;
            this.button1_to_10.Click += new System.EventHandler(this.button1_to_10_Click);
            // 
            // button_toX
            // 
            this.button_toX.Font = new System.Drawing.Font("Times New Roman", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_toX.Location = new System.Drawing.Point(230, 213);
            this.button_toX.Name = "button_toX";
            this.button_toX.Size = new System.Drawing.Size(56, 39);
            this.button_toX.TabIndex = 26;
            this.button_toX.Text = "X<-10";
            this.button_toX.UseVisualStyleBackColor = true;
            this.button_toX.Click += new System.EventHandler(this.button_toX_Click);
            // 
            // button_ravno
            // 
            this.button_ravno.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ravno.Location = new System.Drawing.Point(292, 213);
            this.button_ravno.Name = "button_ravno";
            this.button_ravno.Size = new System.Drawing.Size(56, 39);
            this.button_ravno.TabIndex = 27;
            this.button_ravno.Text = "=";
            this.button_ravno.UseVisualStyleBackColor = true;
            this.button_ravno.Click += new System.EventHandler(this.button_ravno_Click);
            // 
            // button_ce
            // 
            this.button_ce.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ce.Location = new System.Drawing.Point(230, 258);
            this.button_ce.Name = "button_ce";
            this.button_ce.Size = new System.Drawing.Size(56, 39);
            this.button_ce.TabIndex = 28;
            this.button_ce.Text = "CE";
            this.button_ce.UseVisualStyleBackColor = true;
            this.button_ce.Click += new System.EventHandler(this.button_ce_Click);
            // 
            // button_clean
            // 
            this.button_clean.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_clean.Location = new System.Drawing.Point(292, 258);
            this.button_clean.Name = "button_clean";
            this.button_clean.Size = new System.Drawing.Size(56, 39);
            this.button_clean.TabIndex = 29;
            this.button_clean.Text = "C";
            this.button_clean.UseVisualStyleBackColor = true;
            this.button_clean.Click += new System.EventHandler(this.button_clean_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 301);
            this.Controls.Add(this.button_clean);
            this.Controls.Add(this.button_ce);
            this.Controls.Add(this.button_ravno);
            this.Controls.Add(this.button_toX);
            this.Controls.Add(this.button1_to_10);
            this.Controls.Add(this.button_mod);
            this.Controls.Add(this.button_div);
            this.Controls.Add(this.button_umnozhit);
            this.Controls.Add(this.button_minus);
            this.Controls.Add(this.button_plus);
            this.Controls.Add(this.button_9);
            this.Controls.Add(this.button_8);
            this.Controls.Add(this.button_7);
            this.Controls.Add(this.button_6);
            this.Controls.Add(this.button_5);
            this.Controls.Add(this.button_4);
            this.Controls.Add(this.button_3);
            this.Controls.Add(this.button_2);
            this.Controls.Add(this.button_1);
            this.Controls.Add(this.button_0);
            this.Controls.Add(this.button_M);
            this.Controls.Add(this.button_D);
            this.Controls.Add(this.button_C);
            this.Controls.Add(this.button_L);
            this.Controls.Add(this.button_X);
            this.Controls.Add(this.button_V);
            this.Controls.Add(this.button_I);
            this.Controls.Add(this.label_result);
            this.Controls.Add(this.textBox_vvod);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Калькулятор римских цифр";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_vvod;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_result;
        private System.Windows.Forms.Button button_I;
        private System.Windows.Forms.Button button_V;
        private System.Windows.Forms.Button button_X;
        private System.Windows.Forms.Button button_L;
        private System.Windows.Forms.Button button_C;
        private System.Windows.Forms.Button button_D;
        private System.Windows.Forms.Button button_M;
        private System.Windows.Forms.Button button_0;
        private System.Windows.Forms.Button button_1;
        private System.Windows.Forms.Button button_2;
        private System.Windows.Forms.Button button_3;
        private System.Windows.Forms.Button button_4;
        private System.Windows.Forms.Button button_5;
        private System.Windows.Forms.Button button_6;
        private System.Windows.Forms.Button button_7;
        private System.Windows.Forms.Button button_8;
        private System.Windows.Forms.Button button_9;
        private System.Windows.Forms.Button button_plus;
        private System.Windows.Forms.Button button_minus;
        private System.Windows.Forms.Button button_umnozhit;
        private System.Windows.Forms.Button button_div;
        private System.Windows.Forms.Button button_mod;
        private System.Windows.Forms.Button button1_to_10;
        private System.Windows.Forms.Button button_toX;
        private System.Windows.Forms.Button button_ravno;
        private System.Windows.Forms.Button button_ce;
        private System.Windows.Forms.Button button_clean;
    }
}


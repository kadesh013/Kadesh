namespace Target_Teste
{
    partial class Frm_Menu
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
            this.btn_Fibo = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btn_sort = new System.Windows.Forms.Button();
            this.btn_inversao = new System.Windows.Forms.Button();
            this.btn_pct = new System.Windows.Forms.Button();
            this.btn_teste = new System.Windows.Forms.Button();
            this.btn_faturamento = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Fibo
            // 
            this.btn_Fibo.Location = new System.Drawing.Point(15, 125);
            this.btn_Fibo.Name = "btn_Fibo";
            this.btn_Fibo.Size = new System.Drawing.Size(157, 55);
            this.btn_Fibo.TabIndex = 1;
            this.btn_Fibo.Text = "Fibonacci";
            this.btn_Fibo.UseVisualStyleBackColor = true;
            this.btn_Fibo.Click += new System.EventHandler(this.btn_Fibo_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(284, 65);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(222, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(284, 106);
            this.listBox1.Name = "listBox1";
            this.listBox1.ScrollAlwaysVisible = true;
            this.listBox1.Size = new System.Drawing.Size(488, 251);
            this.listBox1.TabIndex = 3;
            // 
            // btn_sort
            // 
            this.btn_sort.Location = new System.Drawing.Point(15, 234);
            this.btn_sort.Name = "btn_sort";
            this.btn_sort.Size = new System.Drawing.Size(157, 49);
            this.btn_sort.TabIndex = 4;
            this.btn_sort.Text = "Reverse Sort";
            this.btn_sort.UseVisualStyleBackColor = true;
            this.btn_sort.Click += new System.EventHandler(this.btn_sort_Click);
            // 
            // btn_inversao
            // 
            this.btn_inversao.Location = new System.Drawing.Point(15, 289);
            this.btn_inversao.Name = "btn_inversao";
            this.btn_inversao.Size = new System.Drawing.Size(157, 49);
            this.btn_inversao.TabIndex = 5;
            this.btn_inversao.Text = "Inversão com lista";
            this.btn_inversao.UseVisualStyleBackColor = true;
            this.btn_inversao.Click += new System.EventHandler(this.btn_inversao_Click);
            // 
            // btn_pct
            // 
            this.btn_pct.Location = new System.Drawing.Point(15, 344);
            this.btn_pct.Name = "btn_pct";
            this.btn_pct.Size = new System.Drawing.Size(157, 46);
            this.btn_pct.TabIndex = 6;
            this.btn_pct.Text = "Porcentagem";
            this.btn_pct.UseVisualStyleBackColor = true;
            this.btn_pct.Click += new System.EventHandler(this.btn_pct_Click);
            // 
            // btn_teste
            // 
            this.btn_teste.Location = new System.Drawing.Point(15, 186);
            this.btn_teste.Name = "btn_teste";
            this.btn_teste.Size = new System.Drawing.Size(157, 42);
            this.btn_teste.TabIndex = 7;
            this.btn_teste.Text = "1° Teste";
            this.btn_teste.UseVisualStyleBackColor = true;
            this.btn_teste.Click += new System.EventHandler(this.btn_teste_Click);
            // 
            // btn_faturamento
            // 
            this.btn_faturamento.Location = new System.Drawing.Point(15, 65);
            this.btn_faturamento.Name = "btn_faturamento";
            this.btn_faturamento.Size = new System.Drawing.Size(157, 42);
            this.btn_faturamento.TabIndex = 8;
            this.btn_faturamento.Text = "Faturamento";
            this.btn_faturamento.UseVisualStyleBackColor = true;
            this.btn_faturamento.Click += new System.EventHandler(this.btn_faturamento_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(281, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Dados";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(512, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(340, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "LETRAS SÓ DEVEM SER UTILIZADAS COM REVERSE/INVERSÃO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(241, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Deixar dados.json em uma pasta na raiz C:\\dados";
            // 
            // Frm_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 416);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_faturamento);
            this.Controls.Add(this.btn_teste);
            this.Controls.Add(this.btn_pct);
            this.Controls.Add(this.btn_inversao);
            this.Controls.Add(this.btn_sort);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btn_Fibo);
            this.Name = "Frm_Menu";
            this.Text = "Target_Teste";
            this.Load += new System.EventHandler(this.Frm_Menu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_Fibo;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btn_sort;
        private System.Windows.Forms.Button btn_inversao;
        private System.Windows.Forms.Button btn_pct;
        private System.Windows.Forms.Button btn_teste;
        private System.Windows.Forms.Button btn_faturamento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}
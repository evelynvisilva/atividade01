namespace atividade01.View
{
    partial class calculadora
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
            lbl_Calculadora = new Label();
            lbl_Valor1 = new Label();
            lbl_Valor2 = new Label();
            tbx_Valor1 = new TextBox();
            tbx_Valor2 = new TextBox();
            btn_Calcular = new Button();
            label1 = new Label();
            txt_resultado = new TextBox();
            SuspendLayout();
            // 
            // lbl_Calculadora
            // 
            lbl_Calculadora.AutoSize = true;
            lbl_Calculadora.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_Calculadora.Location = new Point(149, 31);
            lbl_Calculadora.Name = "lbl_Calculadora";
            lbl_Calculadora.Size = new Size(149, 32);
            lbl_Calculadora.TabIndex = 0;
            lbl_Calculadora.Text = "Calculadora";
            // 
            // lbl_Valor1
            // 
            lbl_Valor1.AutoSize = true;
            lbl_Valor1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_Valor1.Location = new Point(74, 175);
            lbl_Valor1.Name = "lbl_Valor1";
            lbl_Valor1.Size = new Size(59, 21);
            lbl_Valor1.TabIndex = 1;
            lbl_Valor1.Text = "Valor 1";
            // 
            // lbl_Valor2
            // 
            lbl_Valor2.AutoSize = true;
            lbl_Valor2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_Valor2.Location = new Point(74, 226);
            lbl_Valor2.Name = "lbl_Valor2";
            lbl_Valor2.Size = new Size(59, 21);
            lbl_Valor2.TabIndex = 2;
            lbl_Valor2.Text = "Valor 2";
            // 
            // tbx_Valor1
            // 
            tbx_Valor1.Location = new Point(149, 177);
            tbx_Valor1.Name = "tbx_Valor1";
            tbx_Valor1.Size = new Size(149, 23);
            tbx_Valor1.TabIndex = 3;
            // 
            // tbx_Valor2
            // 
            tbx_Valor2.Location = new Point(149, 224);
            tbx_Valor2.Name = "tbx_Valor2";
            tbx_Valor2.Size = new Size(149, 23);
            tbx_Valor2.TabIndex = 4;
            // 
            // btn_Calcular
            // 
            btn_Calcular.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Calcular.Location = new Point(149, 287);
            btn_Calcular.Name = "btn_Calcular";
            btn_Calcular.Size = new Size(149, 46);
            btn_Calcular.TabIndex = 5;
            btn_Calcular.Text = "Calcular";
            btn_Calcular.UseVisualStyleBackColor = true;
            btn_Calcular.Click += btn_Calcular_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(185, 63);
            label1.Name = "label1";
            label1.Size = new Size(67, 30);
            label1.TabIndex = 6;
            label1.Text = "Soma";
            // 
            // txt_resultado
            // 
            txt_resultado.BackColor = Color.MidnightBlue;
            txt_resultado.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_resultado.ForeColor = SystemColors.Window;
            txt_resultado.Location = new Point(149, 120);
            txt_resultado.Name = "txt_resultado";
            txt_resultado.Size = new Size(149, 33);
            txt_resultado.TabIndex = 7;
            // 
            // calculadora
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(447, 450);
            Controls.Add(txt_resultado);
            Controls.Add(label1);
            Controls.Add(btn_Calcular);
            Controls.Add(tbx_Valor2);
            Controls.Add(tbx_Valor1);
            Controls.Add(lbl_Valor2);
            Controls.Add(lbl_Valor1);
            Controls.Add(lbl_Calculadora);
            Name = "calculadora";
            Text = "calculadora";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_Calculadora;
        private Label lbl_Valor1;
        private Label lbl_Valor2;
        private TextBox tbx_Valor1;
        private TextBox tbx_Valor2;
        private Button btn_Calcular;
        private Label label1;
        private TextBox txt_resultado;
    }
}
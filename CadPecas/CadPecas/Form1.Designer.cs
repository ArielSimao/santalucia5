namespace CadPecas
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCodPeca = new System.Windows.Forms.TextBox();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.btnInserir = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtProc = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cód. Peça";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Descrição:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Valor:";
            // 
            // txtCodPeca
            // 
            this.txtCodPeca.Location = new System.Drawing.Point(153, 32);
            this.txtCodPeca.Name = "txtCodPeca";
            this.txtCodPeca.Size = new System.Drawing.Size(100, 22);
            this.txtCodPeca.TabIndex = 3;
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(153, 87);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(367, 22);
            this.txtDescricao.TabIndex = 4;
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(153, 141);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(100, 22);
            this.txtValor.TabIndex = 5;
            // 
            // btnInserir
            // 
            this.btnInserir.Location = new System.Drawing.Point(321, 139);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(75, 36);
            this.btnInserir.TabIndex = 6;
            this.btnInserir.Text = "Inserir";
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(60, 245);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Procurar por Código:";
            // 
            // txtProc
            // 
            this.txtProc.Location = new System.Drawing.Point(60, 279);
            this.txtProc.Name = "txtProc";
            this.txtProc.Size = new System.Drawing.Size(140, 22);
            this.txtProc.TabIndex = 8;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(238, 279);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 36);
            this.btnBuscar.TabIndex = 9;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 383);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtProc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnInserir);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.txtCodPeca);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Cadastro de Peças";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCodPeca;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtProc;
        private System.Windows.Forms.Button btnBuscar;
    }
}


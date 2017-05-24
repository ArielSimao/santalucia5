namespace PrjSuporteCorrecao
{
    partial class FrmSuporte
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
            this.label4 = new System.Windows.Forms.Label();
            this.lblSatisfacao = new System.Windows.Forms.Label();
            this.txtNumMaquina = new System.Windows.Forms.TextBox();
            this.txtNomeEquipamento = new System.Windows.Forms.TextBox();
            this.txtDescricaoProblema = new System.Windows.Forms.TextBox();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.btnGravar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.saveArquivo = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(70, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Número Máquina:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(70, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(269, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome do Equipamento:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(70, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(271, 26);
            this.label3.TabIndex = 2;
            this.label3.Text = "Descrição do Problema:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(86, 356);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(581, 26);
            this.label4.TabIndex = 3;
            this.label4.Text = "Grau de Satisfação com o Atendimento do Suporte:";
            // 
            // lblSatisfacao
            // 
            this.lblSatisfacao.AutoSize = true;
            this.lblSatisfacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSatisfacao.Location = new System.Drawing.Point(673, 397);
            this.lblSatisfacao.Name = "lblSatisfacao";
            this.lblSatisfacao.Size = new System.Drawing.Size(0, 25);
            this.lblSatisfacao.TabIndex = 4;
            // 
            // txtNumMaquina
            // 
            this.txtNumMaquina.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumMaquina.Location = new System.Drawing.Point(352, 45);
            this.txtNumMaquina.Name = "txtNumMaquina";
            this.txtNumMaquina.Size = new System.Drawing.Size(242, 32);
            this.txtNumMaquina.TabIndex = 5;
            // 
            // txtNomeEquipamento
            // 
            this.txtNomeEquipamento.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeEquipamento.Location = new System.Drawing.Point(352, 118);
            this.txtNomeEquipamento.Name = "txtNomeEquipamento";
            this.txtNomeEquipamento.Size = new System.Drawing.Size(493, 32);
            this.txtNomeEquipamento.TabIndex = 6;
            // 
            // txtDescricaoProblema
            // 
            this.txtDescricaoProblema.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescricaoProblema.Location = new System.Drawing.Point(347, 201);
            this.txtDescricaoProblema.Multiline = true;
            this.txtDescricaoProblema.Name = "txtDescricaoProblema";
            this.txtDescricaoProblema.Size = new System.Drawing.Size(493, 134);
            this.txtDescricaoProblema.TabIndex = 7;
            // 
            // trackBar1
            // 
            this.trackBar1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.trackBar1.Location = new System.Drawing.Point(90, 406);
            this.trackBar1.Maximum = 4;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(504, 69);
            this.trackBar1.TabIndex = 8;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // btnGravar
            // 
            this.btnGravar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGravar.Location = new System.Drawing.Point(534, 481);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(201, 69);
            this.btnGravar.TabIndex = 9;
            this.btnGravar.Text = "Grava Solução";
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(752, 481);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(201, 69);
            this.btnLimpar.TabIndex = 10;
            this.btnLimpar.Text = "Limpar Formulário";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.button2_Click);
            // 
            // FrmSuporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1021, 591);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.txtDescricaoProblema);
            this.Controls.Add(this.txtNomeEquipamento);
            this.Controls.Add(this.txtNumMaquina);
            this.Controls.Add(this.lblSatisfacao);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmSuporte";
            this.Text = "Suporte";
            this.Load += new System.EventHandler(this.FrmSuporte_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblSatisfacao;
        private System.Windows.Forms.TextBox txtNumMaquina;
        private System.Windows.Forms.TextBox txtNomeEquipamento;
        private System.Windows.Forms.TextBox txtDescricaoProblema;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.SaveFileDialog saveArquivo;
    }
}


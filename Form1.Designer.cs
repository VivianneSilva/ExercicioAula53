namespace Aula53_Exercicio
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtColaborador = new System.Windows.Forms.TextBox();
            this.txtSalarioBruto = new System.Windows.Forms.TextBox();
            this.txtValorProjeto = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.rdnCLT = new System.Windows.Forms.RadioButton();
            this.rdnPJ = new System.Windows.Forms.RadioButton();
            this.rdnFree = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Colaborador";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Salario Bruto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Valor Projeto";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(541, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Tipo do Contrato";
            // 
            // txtColaborador
            // 
            this.txtColaborador.Location = new System.Drawing.Point(156, 32);
            this.txtColaborador.Name = "txtColaborador";
            this.txtColaborador.Size = new System.Drawing.Size(247, 20);
            this.txtColaborador.TabIndex = 3;
            // 
            // txtSalarioBruto
            // 
            this.txtSalarioBruto.Location = new System.Drawing.Point(156, 78);
            this.txtSalarioBruto.Name = "txtSalarioBruto";
            this.txtSalarioBruto.Size = new System.Drawing.Size(247, 20);
            this.txtSalarioBruto.TabIndex = 3;
            // 
            // txtValorProjeto
            // 
            this.txtValorProjeto.Location = new System.Drawing.Point(156, 124);
            this.txtValorProjeto.Name = "txtValorProjeto";
            this.txtValorProjeto.Size = new System.Drawing.Size(247, 20);
            this.txtValorProjeto.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(37, 329);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Valor Total";
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(143, 329);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(229, 20);
            this.txtResultado.TabIndex = 5;
            // 
            // rdnCLT
            // 
            this.rdnCLT.AutoSize = true;
            this.rdnCLT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.rdnCLT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdnCLT.Location = new System.Drawing.Point(544, 103);
            this.rdnCLT.Name = "rdnCLT";
            this.rdnCLT.Size = new System.Drawing.Size(59, 24);
            this.rdnCLT.TabIndex = 6;
            this.rdnCLT.TabStop = true;
            this.rdnCLT.Text = "CLT";
            this.rdnCLT.UseVisualStyleBackColor = false;
            this.rdnCLT.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rdnPJ
            // 
            this.rdnPJ.AutoSize = true;
            this.rdnPJ.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.rdnPJ.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdnPJ.Location = new System.Drawing.Point(544, 158);
            this.rdnPJ.Name = "rdnPJ";
            this.rdnPJ.Size = new System.Drawing.Size(47, 24);
            this.rdnPJ.TabIndex = 6;
            this.rdnPJ.TabStop = true;
            this.rdnPJ.Text = "PJ";
            this.rdnPJ.UseVisualStyleBackColor = false;
            this.rdnPJ.CheckedChanged += new System.EventHandler(this.rdnPJ_CheckedChanged);
            // 
            // rdnFree
            // 
            this.rdnFree.AutoSize = true;
            this.rdnFree.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.rdnFree.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdnFree.Location = new System.Drawing.Point(544, 212);
            this.rdnFree.Name = "rdnFree";
            this.rdnFree.Size = new System.Drawing.Size(124, 24);
            this.rdnFree.TabIndex = 6;
            this.rdnFree.TabStop = true;
            this.rdnFree.Text = "Free Lancer";
            this.rdnFree.UseVisualStyleBackColor = false;
            this.rdnFree.CheckedChanged += new System.EventHandler(this.rdnFree_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rdnFree);
            this.Controls.Add(this.rdnPJ);
            this.Controls.Add(this.rdnCLT);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtValorProjeto);
            this.Controls.Add(this.txtSalarioBruto);
            this.Controls.Add(this.txtColaborador);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtColaborador;
        private System.Windows.Forms.TextBox txtSalarioBruto;
        private System.Windows.Forms.TextBox txtValorProjeto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.RadioButton rdnCLT;
        private System.Windows.Forms.RadioButton rdnPJ;
        private System.Windows.Forms.RadioButton rdnFree;
    }
}


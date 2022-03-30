namespace OOP_Banco
{
    partial class Principal
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
            this.lblNome = new System.Windows.Forms.Label();
            this.lblSaldo = new System.Windows.Forms.Label();
            this.btnSaque = new System.Windows.Forms.Button();
            this.btnDeposito = new System.Windows.Forms.Button();
            this.btnTransferencia = new System.Windows.Forms.Button();
            this.lblPix = new System.Windows.Forms.Label();
            this.lsxLog = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(12, 9);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(45, 13);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "lblNome";
            // 
            // lblSaldo
            // 
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.Location = new System.Drawing.Point(27, 63);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(30, 13);
            this.lblSaldo.TabIndex = 1;
            this.lblSaldo.Text = "R$ 0";
            // 
            // btnSaque
            // 
            this.btnSaque.Location = new System.Drawing.Point(2, 111);
            this.btnSaque.Name = "btnSaque";
            this.btnSaque.Size = new System.Drawing.Size(85, 23);
            this.btnSaque.TabIndex = 2;
            this.btnSaque.Text = "Saque";
            this.btnSaque.UseVisualStyleBackColor = true;
            this.btnSaque.Click += new System.EventHandler(this.btnSaque_Click);
            // 
            // btnDeposito
            // 
            this.btnDeposito.Location = new System.Drawing.Point(2, 140);
            this.btnDeposito.Name = "btnDeposito";
            this.btnDeposito.Size = new System.Drawing.Size(85, 23);
            this.btnDeposito.TabIndex = 3;
            this.btnDeposito.Text = "Depósito";
            this.btnDeposito.UseVisualStyleBackColor = true;
            this.btnDeposito.Click += new System.EventHandler(this.btnDeposito_Click);
            // 
            // btnTransferencia
            // 
            this.btnTransferencia.Location = new System.Drawing.Point(2, 169);
            this.btnTransferencia.Name = "btnTransferencia";
            this.btnTransferencia.Size = new System.Drawing.Size(85, 23);
            this.btnTransferencia.TabIndex = 4;
            this.btnTransferencia.Text = "Transferência";
            this.btnTransferencia.UseVisualStyleBackColor = true;
            this.btnTransferencia.Click += new System.EventHandler(this.btnTransferencia_Click);
            // 
            // lblPix
            // 
            this.lblPix.AutoSize = true;
            this.lblPix.Location = new System.Drawing.Point(387, 9);
            this.lblPix.Name = "lblPix";
            this.lblPix.Size = new System.Drawing.Size(31, 13);
            this.lblPix.TabIndex = 5;
            this.lblPix.Text = "lblPix";
            this.lblPix.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lsxLog
            // 
            this.lsxLog.FormattingEnabled = true;
            this.lsxLog.Location = new System.Drawing.Point(93, 32);
            this.lsxLog.Name = "lsxLog";
            this.lsxLog.Size = new System.Drawing.Size(325, 160);
            this.lsxLog.TabIndex = 6;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 205);
            this.Controls.Add(this.lsxLog);
            this.Controls.Add(this.lblPix);
            this.Controls.Add(this.btnTransferencia);
            this.Controls.Add(this.btnDeposito);
            this.Controls.Add(this.btnSaque);
            this.Controls.Add(this.lblSaldo);
            this.Controls.Add(this.lblNome);
            this.Name = "Principal";
            this.Text = "Banco";
            this.Load += new System.EventHandler(this.Principal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblSaldo;
        private System.Windows.Forms.Button btnSaque;
        private System.Windows.Forms.Button btnDeposito;
        private System.Windows.Forms.Button btnTransferencia;
        private System.Windows.Forms.Label lblPix;
        private System.Windows.Forms.ListBox lsxLog;
    }
}


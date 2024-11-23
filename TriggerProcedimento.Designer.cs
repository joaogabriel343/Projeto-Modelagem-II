namespace Projeto_Final_II
{
    partial class TriggerProcedimento
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
            this.btnGerarRelatorio = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dgvResultados = new System.Windows.Forms.DataGridView();
            this.lblQuantidadeParticipantes = new System.Windows.Forms.Label();
            this.txtIDInscricao = new System.Windows.Forms.TextBox();
            this.txtIDParticipante = new System.Windows.Forms.TextBox();
            this.txtIDEvento = new System.Windows.Forms.TextBox();
            this.txtStatusPagamento = new System.Windows.Forms.TextBox();
            this.txtFormaPagamento = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultados)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGerarRelatorio
            // 
            this.btnGerarRelatorio.Location = new System.Drawing.Point(237, 514);
            this.btnGerarRelatorio.Name = "btnGerarRelatorio";
            this.btnGerarRelatorio.Size = new System.Drawing.Size(144, 99);
            this.btnGerarRelatorio.TabIndex = 0;
            this.btnGerarRelatorio.Text = "Gerar Relatório Procedimento";
            this.btnGerarRelatorio.UseVisualStyleBackColor = true;
            this.btnGerarRelatorio.Click += new System.EventHandler(this.btnGerarRelatorio_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(412, 514);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(144, 99);
            this.button2.TabIndex = 1;
            this.button2.Text = "Gerar Relatório Trigger";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dgvResultados
            // 
            this.dgvResultados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResultados.Location = new System.Drawing.Point(27, 51);
            this.dgvResultados.Name = "dgvResultados";
            this.dgvResultados.RowHeadersWidth = 62;
            this.dgvResultados.RowTemplate.Height = 28;
            this.dgvResultados.Size = new System.Drawing.Size(1112, 282);
            this.dgvResultados.TabIndex = 2;
            // 
            // lblQuantidadeParticipantes
            // 
            this.lblQuantidadeParticipantes.AutoSize = true;
            this.lblQuantidadeParticipantes.Location = new System.Drawing.Point(996, 754);
            this.lblQuantidadeParticipantes.Name = "lblQuantidadeParticipantes";
            this.lblQuantidadeParticipantes.Size = new System.Drawing.Size(13, 20);
            this.lblQuantidadeParticipantes.TabIndex = 3;
            this.lblQuantidadeParticipantes.Text = ".";
            // 
            // txtIDInscricao
            // 
            this.txtIDInscricao.Location = new System.Drawing.Point(1000, 418);
            this.txtIDInscricao.Name = "txtIDInscricao";
            this.txtIDInscricao.Size = new System.Drawing.Size(184, 26);
            this.txtIDInscricao.TabIndex = 4;
            // 
            // txtIDParticipante
            // 
            this.txtIDParticipante.Location = new System.Drawing.Point(1000, 467);
            this.txtIDParticipante.Name = "txtIDParticipante";
            this.txtIDParticipante.Size = new System.Drawing.Size(184, 26);
            this.txtIDParticipante.TabIndex = 5;
            // 
            // txtIDEvento
            // 
            this.txtIDEvento.Location = new System.Drawing.Point(1000, 514);
            this.txtIDEvento.Name = "txtIDEvento";
            this.txtIDEvento.Size = new System.Drawing.Size(184, 26);
            this.txtIDEvento.TabIndex = 6;
            // 
            // txtStatusPagamento
            // 
            this.txtStatusPagamento.Location = new System.Drawing.Point(1000, 626);
            this.txtStatusPagamento.Name = "txtStatusPagamento";
            this.txtStatusPagamento.Size = new System.Drawing.Size(184, 26);
            this.txtStatusPagamento.TabIndex = 8;
            // 
            // txtFormaPagamento
            // 
            this.txtFormaPagamento.Location = new System.Drawing.Point(1000, 679);
            this.txtFormaPagamento.Name = "txtFormaPagamento";
            this.txtFormaPagamento.Size = new System.Drawing.Size(184, 26);
            this.txtFormaPagamento.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(833, 424);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "ID Inscrição";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(833, 473);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "ID Participante";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(833, 520);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "ID Evento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(832, 581);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "Data Inscrição";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(832, 632);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "Status Pagamento";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(833, 685);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(141, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "Forma Pagamento";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(1000, 575);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 26);
            this.dateTimePicker1.TabIndex = 16;
            // 
            // TriggerProcedimento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1352, 828);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFormaPagamento);
            this.Controls.Add(this.txtStatusPagamento);
            this.Controls.Add(this.txtIDEvento);
            this.Controls.Add(this.txtIDParticipante);
            this.Controls.Add(this.txtIDInscricao);
            this.Controls.Add(this.lblQuantidadeParticipantes);
            this.Controls.Add(this.dgvResultados);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnGerarRelatorio);
            this.Name = "TriggerProcedimento";
            this.Text = "TriggerProcedimento";
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGerarRelatorio;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dgvResultados;
        private System.Windows.Forms.Label lblQuantidadeParticipantes;
        private System.Windows.Forms.TextBox txtIDInscricao;
        private System.Windows.Forms.TextBox txtIDParticipante;
        private System.Windows.Forms.TextBox txtIDEvento;
        private System.Windows.Forms.TextBox txtStatusPagamento;
        private System.Windows.Forms.TextBox txtFormaPagamento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}
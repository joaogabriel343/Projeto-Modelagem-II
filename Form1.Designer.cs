namespace Projeto_Final_II
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
            this.dgvResultados = new System.Windows.Forms.DataGridView();
            this.btnEventosMaisParticipantes = new System.Windows.Forms.Button();
            this.btnMediaParticipacao = new System.Windows.Forms.Button();
            this.btnPalestrantesMaisAtividades = new System.Windows.Forms.Button();
            this.btnParticipantesTodasAtividades = new System.Windows.Forms.Button();
            this.btnRankingPatrocinadores = new System.Windows.Forms.Button();
            this.btnCertificadosEmitidos = new System.Windows.Forms.Button();
            this.btnRegistrarInscricao = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultados)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvResultados
            // 
            this.dgvResultados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResultados.Location = new System.Drawing.Point(1742, 927);
            this.dgvResultados.Name = "dgvResultados";
            this.dgvResultados.RowHeadersWidth = 62;
            this.dgvResultados.RowTemplate.Height = 28;
            this.dgvResultados.Size = new System.Drawing.Size(10, 10);
            this.dgvResultados.TabIndex = 0;
            // 
            // btnEventosMaisParticipantes
            // 
            this.btnEventosMaisParticipantes.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnEventosMaisParticipantes.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEventosMaisParticipantes.Location = new System.Drawing.Point(35, 612);
            this.btnEventosMaisParticipantes.Name = "btnEventosMaisParticipantes";
            this.btnEventosMaisParticipantes.Size = new System.Drawing.Size(186, 51);
            this.btnEventosMaisParticipantes.TabIndex = 1;
            this.btnEventosMaisParticipantes.Text = "Mais participantes";
            this.btnEventosMaisParticipantes.UseVisualStyleBackColor = false;
            this.btnEventosMaisParticipantes.Click += new System.EventHandler(this.btnEventosMaisParticipantes_Click);
            // 
            // btnMediaParticipacao
            // 
            this.btnMediaParticipacao.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnMediaParticipacao.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMediaParticipacao.Location = new System.Drawing.Point(227, 612);
            this.btnMediaParticipacao.Name = "btnMediaParticipacao";
            this.btnMediaParticipacao.Size = new System.Drawing.Size(186, 51);
            this.btnMediaParticipacao.TabIndex = 2;
            this.btnMediaParticipacao.Text = "Media Participação";
            this.btnMediaParticipacao.UseVisualStyleBackColor = false;
            this.btnMediaParticipacao.Click += new System.EventHandler(this.btnMediaParticipacao_Click);
            // 
            // btnPalestrantesMaisAtividades
            // 
            this.btnPalestrantesMaisAtividades.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnPalestrantesMaisAtividades.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPalestrantesMaisAtividades.Location = new System.Drawing.Point(419, 612);
            this.btnPalestrantesMaisAtividades.Name = "btnPalestrantesMaisAtividades";
            this.btnPalestrantesMaisAtividades.Size = new System.Drawing.Size(179, 51);
            this.btnPalestrantesMaisAtividades.TabIndex = 3;
            this.btnPalestrantesMaisAtividades.Text = "Palestratrante/Atvd";
            this.btnPalestrantesMaisAtividades.UseVisualStyleBackColor = false;
            this.btnPalestrantesMaisAtividades.Click += new System.EventHandler(this.btnPalestrantesMaisAtividades_Click);
            // 
            // btnParticipantesTodasAtividades
            // 
            this.btnParticipantesTodasAtividades.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnParticipantesTodasAtividades.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnParticipantesTodasAtividades.Location = new System.Drawing.Point(604, 612);
            this.btnParticipantesTodasAtividades.Name = "btnParticipantesTodasAtividades";
            this.btnParticipantesTodasAtividades.Size = new System.Drawing.Size(179, 51);
            this.btnParticipantesTodasAtividades.TabIndex = 4;
            this.btnParticipantesTodasAtividades.Text = "Participante/Atvd";
            this.btnParticipantesTodasAtividades.UseVisualStyleBackColor = false;
            this.btnParticipantesTodasAtividades.Click += new System.EventHandler(this.btnParticipantesTodasAtividades_Click);
            // 
            // btnRankingPatrocinadores
            // 
            this.btnRankingPatrocinadores.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnRankingPatrocinadores.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRankingPatrocinadores.Location = new System.Drawing.Point(789, 612);
            this.btnRankingPatrocinadores.Name = "btnRankingPatrocinadores";
            this.btnRankingPatrocinadores.Size = new System.Drawing.Size(195, 51);
            this.btnRankingPatrocinadores.TabIndex = 5;
            this.btnRankingPatrocinadores.Text = "Ranking/Patrocinador";
            this.btnRankingPatrocinadores.UseVisualStyleBackColor = false;
            this.btnRankingPatrocinadores.Click += new System.EventHandler(this.btnRankingPatrocinadores_Click);
            // 
            // btnCertificadosEmitidos
            // 
            this.btnCertificadosEmitidos.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCertificadosEmitidos.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCertificadosEmitidos.Location = new System.Drawing.Point(999, 612);
            this.btnCertificadosEmitidos.Name = "btnCertificadosEmitidos";
            this.btnCertificadosEmitidos.Size = new System.Drawing.Size(195, 51);
            this.btnCertificadosEmitidos.TabIndex = 6;
            this.btnCertificadosEmitidos.Text = "Certificados Emitidos";
            this.btnCertificadosEmitidos.UseVisualStyleBackColor = false;
            this.btnCertificadosEmitidos.Click += new System.EventHandler(this.btnCertificadosEmitidos_Click);
            // 
            // btnRegistrarInscricao
            // 
            this.btnRegistrarInscricao.Location = new System.Drawing.Point(1422, 597);
            this.btnRegistrarInscricao.Name = "btnRegistrarInscricao";
            this.btnRegistrarInscricao.Size = new System.Drawing.Size(172, 80);
            this.btnRegistrarInscricao.TabIndex = 8;
            this.btnRegistrarInscricao.Text = "Ir para Gerar Relatório";
            this.btnRegistrarInscricao.UseVisualStyleBackColor = true;
            this.btnRegistrarInscricao.Click += new System.EventHandler(this.btnRegistrarInscricao_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1751, 936);
            this.Controls.Add(this.btnRegistrarInscricao);
            this.Controls.Add(this.btnCertificadosEmitidos);
            this.Controls.Add(this.btnRankingPatrocinadores);
            this.Controls.Add(this.btnParticipantesTodasAtividades);
            this.Controls.Add(this.btnPalestrantesMaisAtividades);
            this.Controls.Add(this.btnMediaParticipacao);
            this.Controls.Add(this.btnEventosMaisParticipantes);
            this.Controls.Add(this.dgvResultados);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvResultados;
        private System.Windows.Forms.Button btnEventosMaisParticipantes;
        private System.Windows.Forms.Button btnMediaParticipacao;
        private System.Windows.Forms.Button btnPalestrantesMaisAtividades;
        private System.Windows.Forms.Button btnParticipantesTodasAtividades;
        private System.Windows.Forms.Button btnRankingPatrocinadores;
        private System.Windows.Forms.Button btnCertificadosEmitidos;
        private System.Windows.Forms.Button btnRegistrarInscricao;
    }
}


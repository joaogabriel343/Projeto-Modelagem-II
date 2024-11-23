using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Final_II
{
    public partial class Form1 : Form
    {
        private readonly string connectionString = "Server=DESKTOP-DIFT32I\\SQLEXPRESS;Database=Gestão de Eventos Acadêmico;Trusted_Connection=True;";

        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.Sizable;
            this.WindowState = FormWindowState.Maximized;
        }

        private void btnEventosMaisParticipantes_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    //• Eventos com mais participantes inscritos.
                    string query = @"
                    SELECT E.Nome AS Evento, COUNT(I.IDParticipante) AS TotalInscritos
                    FROM Eventos E
                    JOIN Inscricoes I ON E.IDEvento = I.IDEvento
                    GROUP BY E.IDEvento, E.Nome
                    ORDER BY TotalInscritos DESC;";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dgvResultados.DataSource = dt;
                    dgvResultados.AutoResizeColumns();
                    dgvResultados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dgvResultados.Dock = DockStyle.Fill;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro: {ex.Message}");
                }
            }
        }

        private void btnMediaParticipacao_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    //• Atividades de um evento com média de participação.
                    string query = @"
                        DECLARE @IDEvento INT = 1;

                        SELECT A.Titulo AS Atividade, 
                               AVG(CASE WHEN I.IDInscricao IS NOT NULL THEN 1 ELSE 0 END) AS MediaParticipantes
                        FROM Atividades A
                        LEFT JOIN Inscricoes I ON A.IDEvento = I.IDEvento
                        WHERE A.IDEvento = @IDEvento
                        GROUP BY A.IDAtividade, A.Titulo;
                         ";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dgvResultados.DataSource = dt;
                    dgvResultados.AutoResizeColumns();
                    dgvResultados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dgvResultados.Dock = DockStyle.Fill;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro: {ex.Message}");
                }
            }
        }

        private void btnPalestrantesMaisAtividades_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    //• Palestrante com mais atividades ministradas em um período.
                    string query = @"
                    DECLARE @DataInicio DATE = '2024-01-01'; 
                    DECLARE @DataFim DATE = '2024-12-31';   
                    SELECT TOP 1 P.Nome AS Palestrante, COUNT(AP.IDAtividade) AS TotalAtividades
                    FROM Palestrantes P
                    JOIN AtividadePalestrante AP ON P.IDPalestrante = AP.IDPalestrante
                    JOIN Atividades A ON AP.IDAtividade = A.IDAtividade
                    WHERE A.Data BETWEEN @DataInicio AND @DataFim
                    GROUP BY P.IDPalestrante, P.Nome
                    ORDER BY TotalAtividades DESC;
                    ";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dgvResultados.DataSource = dt;
                    dgvResultados.AutoResizeColumns();
                    dgvResultados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dgvResultados.Dock = DockStyle.Fill;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro: {ex.Message}");
                }
            }
        }

        private void btnParticipantesTodasAtividades_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    //• Participantes que compareceram a todas as atividades de um evento.
                    string query = @"
                        SELECT p.Nome AS Participante,
                         e.Nome AS Evento
                        FROM Participantes p
                        JOIN Inscricoes i ON p.IDParticipante = i.IDParticipante
                        JOIN Eventos e ON e.IDEvento = i.IDEvento
                        WHERE e.IDEvento = 1 
                        AND EXISTS (
  
                            SELECT 1
                            FROM Atividades a
                            WHERE a.IDEvento = e.IDEvento
                            AND EXISTS (
                                SELECT 1
                                FROM Certificados c
                                WHERE c.IDParticipante = p.IDParticipante
                                AND c.IDAtividade = a.IDAtividade
                            )
                        )
                        GROUP BY p.IDParticipante, e.Nome, p.Nome;";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dgvResultados.DataSource = dt;
                    dgvResultados.AutoResizeColumns();
                    dgvResultados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dgvResultados.Dock = DockStyle.Fill;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro: {ex.Message}");
                }
            }
        }

        private void btnRankingPatrocinadores_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    //• Ranking de patrocinadores por valor total.
                    string query = @"
                    SELECT pt.NomeEmpresa,
                    SUM(pt.ValorApoio) AS ValorTotal
                    FROM Patrocinadores pt
                    JOIN EventoPatrocinador ep ON pt.IDPatrocinador = ep.IDPatrocinador
                    GROUP BY pt.IDPatrocinador, pt.NomeEmpresa
                    ORDER BY ValorTotal DESC;";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dgvResultados.DataSource = dt;
                    dgvResultados.AutoResizeColumns();
                    dgvResultados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dgvResultados.Dock = DockStyle.Fill;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro: {ex.Message}");
                }
            }
        }

        private void btnCertificadosEmitidos_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    //• Total de certificados emitidos por evento e percentual de atividades concluídas.
                    string query = @"
                        SELECT e.Nome AS Evento,
                        COUNT(c.IDCertificado) AS TotalCertificadosEmitidos,
                        COUNT(DISTINCT a.IDAtividade) AS TotalAtividades,
                        (COUNT(c.IDCertificado) * 100.0 / COUNT(DISTINCT a.IDAtividade)) AS PercentualConclusao
                        FROM Eventos e
                        JOIN Atividades a ON e.IDEvento = a.IDEvento
                        LEFT JOIN Certificados c ON a.IDAtividade = c.IDAtividade
                        GROUP BY e.IDEvento, e.Nome;
                        ";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dgvResultados.DataSource = dt;
                    dgvResultados.AutoResizeColumns();
                    dgvResultados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dgvResultados.Dock = DockStyle.Fill;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro: {ex.Message}");
                }
            }
        }

      

        private void btnRegistrarInscricao_Click(object sender, EventArgs e)
        {
            TriggerProcedimento tgp = new TriggerProcedimento();
            tgp.ShowDialog();
        }
    }
}

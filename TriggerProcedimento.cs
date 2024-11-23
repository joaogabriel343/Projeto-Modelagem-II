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
    public partial class TriggerProcedimento : Form
    {
        private readonly string connectionString = "Server=DESKTOP-DIFT32I\\SQLEXPRESS;Database=Gestão de Eventos Acadêmico;Trusted_Connection=True;";

        public TriggerProcedimento()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.Sizable;
            this.WindowState = FormWindowState.Maximized;
        }

        private void btnGerarRelatorio_Click_1(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    int eventoId = 1;
                    // Procedimento Armazenado: Criar um procedimento armazenado para gerar um relatório consolidado 
                    // de participantes e certificados por evento.
                    SqlCommand command = new SqlCommand("sp_RelatorioParticipantesCertificadosPorEvento", connection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@IDEvento", eventoId);

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dgvResultados.DataSource = dt;
                  
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro: {ex.Message}");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = "INSERT INTO Inscricoes (IDInscricao, IDParticipante, IDEvento, DataInscricao, StatusPagamento, FormaPagamento) VALUES (@IDInscricao, @IDParticipante, @IDEvento, @DataInscricao, @StatusPagamento, @FormaPagamento)";

                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@IDInscricao", txtIDInscricao.Text);
                    command.Parameters.AddWithValue("@IDParticipante", txtIDParticipante.Text);
                    command.Parameters.AddWithValue("@IDEvento", txtIDEvento.Text);
                    command.Parameters.AddWithValue("@DataInscricao", DateTime.Now);
                    command.Parameters.AddWithValue("@StatusPagamento", txtStatusPagamento.Text);
                    command.Parameters.AddWithValue("@FormaPagamento", txtFormaPagamento.Text);



                    command.ExecuteNonQuery();

                    string countQuery = "SELECT COUNT(*) AS QuantidadeParticipantes FROM Inscricoes WHERE IDEvento = @IDEvento";
                    SqlCommand countCommand = new SqlCommand(countQuery, connection);
                    countCommand.Parameters.AddWithValue("@IDEvento", txtIDEvento.Text);

                    int quantidadeParticipantes = (int)countCommand.ExecuteScalar();

                    lblQuantidadeParticipantes.Text = "Participantes no Evento: " + quantidadeParticipantes.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.Message);
                }
            }
        }
    }
}

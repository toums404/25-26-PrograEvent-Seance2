using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace _25_26_PrograEvent_Seance2
{
    public partial class FenetreBDD : Form
    {
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\BDDClient.mdf;Integrated Security=True;Connect Timeout=30;";
        public FenetreBDD()
        {
            InitializeComponent();
        }

        private void FenetreBDD_Load(object sender, EventArgs e)
        {

        }

        private void bConsulter_Click(object sender, EventArgs e)
        {
            lbConsole.Items.Clear();
            string query = "SELECT PRENOM, NOM, ID_CLIENT FROM T_CLIENT";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string prenom = reader["PRENOM"].ToString();
                                string nom = reader["NOM"].ToString();
                                string numCli = reader["ID_CLIENT"].ToString();

                                lbConsole.Items.Add($"{prenom} {nom} ({numCli})");
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erreur de consultation : " + ex.Message);
                    }
                }
            }
        }

        private void bDenombrer_Click(object sender, EventArgs e)
        {
            string query = "SELECT COUNT(*) FROM T_CLIENT";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {
                        connection.Open();
                        int nombreClients = (int)command.ExecuteScalar();
                        lbConsole.Items.Add($"--- Nombre total d'enregistrements : {nombreClients} ---");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erreur de dénombrement : " + ex.Message);
                    }
                }
            }
        }

        private void bAjouter_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbNom.Text) || string.IsNullOrWhiteSpace(tbPrenom.Text))
            {
                MessageBox.Show("Veuillez remplir le nom et le prénom.");
                return;
            }

            string query = "INSERT INTO T_CLIENT (NOM, PRENOM) VALUES (@nom, @prenom)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@nom", tbNom.Text);
                    command.Parameters.AddWithValue("@prenom", tbPrenom.Text);

                    try
                    {
                        connection.Open();
                        int lignesAjoutees = command.ExecuteNonQuery();

                        if (lignesAjoutees > 0)
                        {
                            lbConsole.Items.Add($"Client {tbPrenom.Text} {tbNom.Text} ajouté avec succès !");
                            tbNom.Clear();
                            tbPrenom.Clear();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erreur lors de l'ajout : " + ex.Message);
                    }
                }
            }
        }
    }

}

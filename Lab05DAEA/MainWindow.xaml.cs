using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data.SqlClient;

using System.Data;

namespace Lab05DAEA
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string connectionString = "Data Source=LAB1504-31\\SQLEXPRESS; Initial Catalog=Neptuno;User Id=eber; Password=123456;";
            string uspp = "usp_ListarCliente";

            List<Cliente> clientes = new List<Cliente>();

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    
                    connection.Open();

                    
                    using (SqlCommand command = new SqlCommand(uspp, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;


                        using (SqlDataReader reader = command.ExecuteReader())
                        {

                            while (reader.Read())
                            {
                                string IdCliente = reader.GetString("IdCliente");
                                string NombreCompania = reader.GetString("NombreCompañia");
                                string NombreContacto = reader.GetString("NombreContacto");
                                string CargoContacto = reader.GetString("CargoContacto");
                                string Direccion = reader.GetString("Direccion");
                                string Ciudad = reader.GetString("Ciudad");
                                string Region = reader.GetString("Region");
                                string CodPostal = reader.GetString("CodPostal");
                                string Pais = reader.GetString("Pais");
                                string Telefono = reader.GetString("Telefono");
                                string Fax = reader.GetString("Fax");

                                clientes.Add(new )
                            }
                            connection.Close();
                            
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                System.Windows.MessageBox.Show("Error al ejecutar el procedimiento almacenado: " + ex.Message);

            }
        }
    }
}
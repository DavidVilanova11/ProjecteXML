using System.Net;
using System.Xml;
using System.Xml.Schema;
using WinFormsApp1.DAO;
using WinFormsApp1.Model;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

            string pathFitxer = openFileDialog1.FileName;
            // Aquí pots fer el que necessitis amb el fitxer XML seleccionat
            // per exemple, carregar-lo a una base de dades o processar les seves dades.
            // També pots mostrar la ruta del fitxer en un TextBox o una etiqueta.
        }

        public static bool ValidarModel(string rutaArchivo, string rutaDTD)
        {
            try
            {
                XmlReaderSettings settings = new XmlReaderSettings();
                settings.ValidationType = ValidationType.DTD;
                settings.DtdProcessing = DtdProcessing.Parse;
                settings.XmlResolver = new XmlUrlResolver { Credentials = CredentialCache.DefaultCredentials };

                using (XmlReader reader = XmlReader.Create(rutaArchivo, settings))
                {
                    while (reader.Read()) { }
                }

                return true; // La validación fue exitosa
            }
            catch (XmlException)
            {
                return false; // La validación falló
            }
        }
        private static void ValidationEventHandler(object sender, ValidationEventArgs e)
        {
            if (e.Severity == XmlSeverityType.Error)
            {
                throw new XmlException("Error de validación DTD: " + e.Message);
            }
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void Enter_Click(object sender, EventArgs e)
        {
            // Cargar el archivo XML
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Archivo XML (*.xml)|*.xml";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {

                if (ValidarModel(openFileDialog.FileName, "C:\\Users\\PC\\Documents\\Classe\\XML\\reserva_animals.dtd"))
                {
                    txtRutaFitxer.Text = openFileDialog.FileName;
                    int rowsAffected = BD.EsborrarDades();
                    ReservaManager.CarregarModel(openFileDialog.FileName);
                }

                // BD.getDades();
            }
        }
    }

}
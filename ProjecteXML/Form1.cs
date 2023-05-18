using ProjecteXML.model;

namespace ProjecteXML
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCarregar_Click(object sender, EventArgs e)
        {
            //OpenFileDialog dlg = new OpenFileDialog();
            //dlg.ShowDialog();
            //Animal animal = new Animal();
            //int a = animal.Pos;
            //animal.Pos = 1;

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "File XML (*.xml)|*.xml";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                DMCManager.carregarModel(openFileDialog.FileName);

            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
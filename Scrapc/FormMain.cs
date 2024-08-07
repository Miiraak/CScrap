namespace Scrapc
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void ButtonChoice_Click(object sender, EventArgs e)
        {
            switch (comboBoxLangage.Text)
            {
                case "HTML":
                    // Instanciation de FormHTML
                    FormHTML formHTML = new();
                    formHTML.Show();
                    FormHTML.AllUrls.Clear();
                    break;
                case "Text":       
                    // Pour FormText
                    FormTEXT formText = new();
                    formText.Show();
                    FormTEXT.AllUrls.Clear();
                    break;
                case "Images":
                    // Pour FormImage
                    FormImage formImage = new();
                    formImage.Show();
                    FormImage.AllUrls.Clear();
                    break;
                case "URLs":
                    // Pour FormURL
                    FormURL formURL = new();
                    formURL.Show();
                    FormURL.AllUrls.Clear();
                    break;                                    
                default:
                    MessageBox.Show("Veuillez choisir une fonction.");
                    break;
            }
        }
    }
}


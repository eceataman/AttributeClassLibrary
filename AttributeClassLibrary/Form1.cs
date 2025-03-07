
using AttributeExample;

namespace AttributeClassLibrary

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

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            Person person = new Person
            {
                FirstName = txtFirstName.Text,
                LastName = txtLastName.Text
            };

           
            bool isValid = ZorunlulukKontrolu.Dogrula(person);
            txtFirstName.BackColor = string.IsNullOrEmpty(txtFirstName.Text) ? System.Drawing.Color.LightCoral : System.Drawing.Color.White;
            txtLastName.BackColor = string.IsNullOrEmpty(txtLastName.Text) ? System.Drawing.Color.LightCoral : System.Drawing.Color.White;

            if (!isValid)
            {
                MessageBox.Show("Lütfen tüm zorunlu alanlarý doldurun!", "Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                lblResult.Text = "Bilgiler baþarýyla kaydedildi!";
            }
        }
    }
}

namespace yaş_bulma_projesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Adı al
            string name = textBox1.Text;

            //Soyadı al
            string surname = textBox2.Text;

            // Yaşı TextBox'tan al
            int age = int.Parse(textBox3.Text);

            // Mevcut yılı al
            int currentYear = DateTime.Now.Year;

            // Doğum yılını hesapla
            int birthYear = currentYear - age;

            // Doğum yılını TextBox'a yazdır
            textBox4.Text = $"{name} {surname} doğdunuz yıl: " + birthYear.ToString();
        }
    }
}

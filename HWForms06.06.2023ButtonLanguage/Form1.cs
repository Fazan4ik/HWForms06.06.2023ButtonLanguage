namespace HWForms06._06._2023ButtonLanguage
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonGER_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = Image.FromFile("D:\\visual studio projects\\HWForms06.06.2023ButtonLanguage\\germany-flag-icon.png");
            this.Text = "Hallo Mensch";
        }

        private void buttonENG_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = Image.FromFile("D:\\visual studio projects\\HWForms06.06.2023ButtonLanguage\\united-kingdom-flag-icon.png");
            this.Text = "Hello human";
        }

        private void buttonUA_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = Image.FromFile("D:\\visual studio projects\\HWForms06.06.2023ButtonLanguage\\ukraine-flag-icon.png");
            this.Text = "Привіт друг";
        }
    }
}
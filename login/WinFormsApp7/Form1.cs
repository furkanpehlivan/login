namespace WinFormsApp7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public Form2 Form { get; private set; }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text=="FurkanPehlivan33" && textBox2.Text=="123456789")
            {
                MessageBox.Show("Giri� Yap�l�yor");
                Form2 frm = new Form2();
                frm.Show();
            }
            else
            {
                MessageBox.Show("Hatal� Kullan�c� Ad� Veya �ifre");
            }



            






           }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked)
            {
                textBox2.PasswordChar = '\0';
            }
            else
            {
                textBox2.PasswordChar = '*';
            }
        }
    }
    }

//Kullan�c� Ad�:FurkanPehlivan33
//�ifre:123456789
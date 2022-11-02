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
                MessageBox.Show("Giriþ Yapýlýyor");
                Form2 frm = new Form2();
                frm.Show();
            }
            else
            {
                MessageBox.Show("Hatalý Kullanýcý Adý Veya Þifre");
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

//Kullanýcý Adý:FurkanPehlivan33
//Þifre:123456789
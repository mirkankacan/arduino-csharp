using System;
using System.IO.Ports;
using System.Threading;
using System.Windows.Forms;

namespace OdevC_
{
   
    public partial class Form1 : Form
    {
        private SerialPort arduino;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("9600");
        }

     
        private void button2_Click(object sender, EventArgs e)
        {
            string port = comboBox1.Text;

            if (!string.IsNullOrWhiteSpace(port))
            {
                int intPort = Convert.ToInt32(port);

                arduino = new SerialPort("COM3", intPort);

                arduino.Open();
                MessageBox.Show("Bağlantı sağlandı!");
            }
            else
            {
                MessageBox.Show("Port seçimi yapınız!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string adimSayisi = textBox1.Text;

            if (!string.IsNullOrWhiteSpace(adimSayisi))
            {
                if (arduino != null && arduino.IsOpen)
                {
                    arduino.WriteLine(adimSayisi);

                    System.Threading.Thread.Sleep(100);

                    MessageBox.Show("Adım sayısı gönderildi!");
                }
                else
                {
                    MessageBox.Show("Bağlantı açık değil!");
                }
            }
            else
            {
                MessageBox.Show("Adım sayısı giriniz!");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (arduino != null && arduino.IsOpen)
            {
                arduino.Close();
                MessageBox.Show("Bağlantı durduruldu!");
            }
            else
            {
                MessageBox.Show("Bağlantı zaten kapalı!");
            }
        }

    }
}

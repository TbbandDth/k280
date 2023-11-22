using System.IO.Ports;
using Modbus.Device;

namespace 机械手控制
{
    public partial class Form1 : Form
    {
        SerialPort serialPort = null;
        public Form1()
        {
            InitializeComponent();
            this.Load += Forml_Load;
        }

        private void Forml_Load(object? sender, EventArgs e)
        {
            //初始化串口列表
            string[] ports = SerialPort.GetPortNames();
            foreach (var port in ports)
                this.comboBox1.Items.Add(port);
            this.comboBox1.SelectedIndex = 0;
        }

        private void btnConnetct_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort = new SerialPort();
                serialPort.PortName = this.comboBox1.Text;
                serialPort.BaudRate = int.Parse(this.textBox4.Text);
                serialPort.DataBits = int.Parse(this.textBox1.Text);
                serialPort.Parity = Parity.None;
                serialPort.StopBits = StopBits.One;

                serialPort.Open();

                MessageBox.Show("串口打开成功");
    
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
    }

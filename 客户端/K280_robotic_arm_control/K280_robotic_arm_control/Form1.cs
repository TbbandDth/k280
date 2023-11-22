using System.IO.Ports;
using Modbus.Device;


namespace K280_robotic_arm_control
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        private SerialPort serialPort;
        private IModbusSerialMaster modbusMaster;
        private Thread writeThread;
        private bool keepWriting = false;
        public Form1()
        {
            InitializeComponent();
            this.Load += Forml_Load;
        }

        private void Forml_Load(object? sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();
            foreach (var port in ports)
                this.comboBox1.Items.Add(port);
            this.comboBox1.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.button1.Text == "����")
                {
                    serialPort = new SerialPort();
                    serialPort.PortName = this.comboBox1.Text;
                    serialPort.BaudRate = int.Parse(this.textBox1.Text);
                    serialPort.DataBits = int.Parse(this.textBox2.Text);
                    serialPort.Parity = Parity.None;
                    serialPort.StopBits = StopBits.One;
                    serialPort.Open();
                    this.button1.Text = "�Ͽ�";
                    modbusMaster = ModbusSerialMaster.CreateRtu(serialPort);
                }
                else
                {
                    serialPort.Close();
                    this.button1.Text = "����";
                    modbusMaster = ModbusSerialMaster.CreateRtu(serialPort);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void WriteroneModBus(ushort registerAddress, ushort valueToWrite)
        {
            modbusMaster.WriteSingleRegister(0, registerAddress, valueToWrite);
        }

        private void InitializeModBus()
        {
            WriteroneModBus(907, 0);//�����˶�ģʽΪֱ�߲���
        }

        private void WritertowModBus(ushort startAddress, int coordinate_value)
        {
            ushort highOrderValue = (ushort)(coordinate_value >> 16);
            ushort lowOrderValue = (ushort)(coordinate_value & 0xFFFF);
            ushort[] valuesToWrite = new ushort[] { highOrderValue, lowOrderValue };
            modbusMaster.WriteMultipleRegisters(0, startAddress, valuesToWrite);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                ushort speed = ushort.Parse(this.textBox5.Text);
                int X = int.Parse(this.textBox6.Text);
                int Y = int.Parse(this.textBox7.Text);

                WriteroneModBus(908, speed);//�����˶��ٶ�
                WritertowModBus(1014, X);//����X������
                WritertowModBus(2014, Y);//����Y������

                WriteroneModBus(960, 2);//ִ��
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        //�˶���ʼ��
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                InitializeModBus();
                MessageBox.Show("��ʼ���ɹ�");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                if (writeThread == null || !writeThread.IsAlive)
                {
                    ushort speed = ushort.Parse(this.textBox10.Text);
                    WriteroneModBus(908, speed);
                    keepWriting = true;
                    writeThread = new Thread(WriteToRegisterRepeatedly);
                    writeThread.Start();
                    this.button4.Text = "ֹͣ";
                }
                else
                {
                    keepWriting = false;
                    this.button4.Text = "ִ�������˶�";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void WriteToRegisterRepeatedly()
        {
            int X1 = int.Parse(this.textBox9.Text);
            int Y1 = int.Parse(this.textBox8.Text);
            int X2 = int.Parse(this.textBox12.Text);
            int Y2 = int.Parse(this.textBox11.Text);
            while (keepWriting)
            {
                
                WritertowModBus(1014, X1);//����X������
                WritertowModBus(2014, Y1);//����Y������
                WriteroneModBus(960, 2);//ִ��
                Thread.Sleep(1000);


                WritertowModBus(1014, X2);//����X������
                WritertowModBus(2014, Y2);//����Y������
                WriteroneModBus(960, 2);//ִ��
                Thread.Sleep(1000);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ushort speed = ushort.Parse(this.textBox10.Text);
            WriteroneModBus(908, speed);
            WritertowModBus(1014, 249443);//����X������
            WritertowModBus(2014, 94046);//����Y������
            WriteroneModBus(960, 2);//ִ��
        }
    }
}

using System.IO.MemoryMappedFiles;
using System.Text;

namespace SharedMemoryApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void buttonSaveConvert_Click(object sender, EventArgs e)
        {
            int var_value = (int)numericUpDownSave.Value;
            byte[] saveBytes = BitConverter.GetBytes(var_value);
            textBoxFModule.Text = BitConverter.ToString(saveBytes);
            textBoxSModule.Text = BitConverter.ToString(saveBytes);
            textBoxTModule.Text = BitConverter.ToString(saveBytes);
            buttonSave.Enabled = true;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            byte[] bytes = StringToBytes(textBoxControler.Text);
            using (MemoryMappedFile mmf = MemoryMappedFile.CreateOrOpen("shared", 10000))
            {
                MemoryMappedViewAccessor mmva = mmf.CreateViewAccessor();
                mmva.Write(0, bytes.Length);
                mmva.WriteArray<byte>(0, bytes, 0, bytes.Length);
                mmva.Flush();
            }
        }

        private byte[] StringToBytes(String s)
        {
            byte[] data = new byte[(s.Length + 1) / 3];
            for (int i = 0; i < data.Length; i++)
            {
                data[i] = (byte)(
                   "0123456789ABCDEF".IndexOf(s[i * 3]) * 16 +
                   "0123456789ABCDEF".IndexOf(s[i * 3 + 1])
                );
            }
            return data;
        }

        private void buttonControlerStart_Click(object sender, EventArgs e)
        {
            String res = "";
            if (textBoxFModule.Text == textBoxSModule.Text)
            {
                res = textBoxFModule.Text;
            }
            else if (textBoxSModule.Text == textBoxTModule.Text)
            {
                res = textBoxSModule.Text;
            }
            else if (textBoxFModule.Text == textBoxTModule.Text)
            {
                res = textBoxFModule.Text;
            }
            else
            {
                MessageBox.Show("All three modules values are diffrent!", "Comparing ERROR",
                  MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            byte[] bytes = StringToBytes(res);
            int convertedInt = BitConverter.ToInt32(bytes, 0);
            textBoxControler.Text = convertedInt.ToString();
        }

        private void buttonStartRead_Click(object sender, EventArgs e)
        {
            using (MemoryMappedFile mmf = MemoryMappedFile.CreateOrOpen("shared", 10000))
            {
                MemoryMappedViewAccessor mmva = mmf.CreateViewAccessor();
                byte[] buffer = new byte[mmva.ReadInt32(0)];
                mmva.ReadArray<byte>(buffer.Length, buffer, 0, buffer.Length);
                Console.WriteLine("buffer: {0}", BitConverter.ToString(buffer));
                int res = BitConverter.ToInt32(buffer, 0);
                labelReadValue.Text = res.ToString();
            }
        }
    }
}
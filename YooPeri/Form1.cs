using System.Diagnostics;
using static System.Net.Mime.MediaTypeNames;

namespace YooPeri
{
    public partial class Form1 : Form
    {
        // P/Invoke to set a cue banner (placeholder) text on the TextBox
        private const int EM_SETCUEBANNER = 0x1501;
        [System.Runtime.InteropServices.DllImport("user32.dll", CharSet = System.Runtime.InteropServices.CharSet.Unicode)]
        private static extern IntPtr SendMessage(IntPtr hWnd, int Msg, IntPtr wParam, string lParam);

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string url = Link.Text;

            // 2. Abre o seletor de pasta
            FolderBrowserDialog folderDialog = new FolderBrowserDialog();

            if (folderDialog.ShowDialog() == DialogResult.OK)
            {
                // 3. Salva o caminho na string 'path'
                string path = folderDialog.SelectedPath;

                // 4. Abre o CMD na pasta selecionada e executa seu comando
                Process.Start("cmd.exe", $"/k cd /d \"{path}\" && yt-dlp --cookies-from-browser firefox {url}");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Set placeholder text for the Link TextBox
            SendMessage(Link.Handle, EM_SETCUEBANNER, (IntPtr)0, "Enter you link");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Link_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }
    }
}

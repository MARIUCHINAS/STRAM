using System.Diagnostics;
using System.IO;

namespace STRAM
{
    public partial class STRAM : Form
    {
        string arguments;
        string currentDirectory;
        public STRAM()
        {
            InitializeComponent();
        }

        public void UpdateRichTextBoxInput()
        {
            currentDirectory = Environment.CurrentDirectory + @"\steamcmd";
            arguments = "/k " + @"\steamcmd.exe +login anonymous +workshop_download_item " + textBox_GameID.Text + " " + textBox_WorkshopID.Text;
            richTextBox_Input.Text = arguments;
        }

        private void button_Download_Click(object sender, EventArgs e)
        {
            // https://coolors.co/c3c3e6-d1c8e1-bba0ca-b370b0-87255b


            currentDirectory = Environment.CurrentDirectory + @"\steamcmd";
            string scriptPath = System.Reflection.Assembly.GetExecutingAssembly().Location;
            string scriptDirectory = System.IO.Path.GetDirectoryName(scriptPath);
            string command = "cmd.exe";
            arguments = "/k " + "" + currentDirectory + @"\steamcmd.exe +login anonymous +workshop_download_item " + textBox_GameID.Text + " " + textBox_WorkshopID.Text; // Use "/k" instead of "/c" to keep the command prompt open

            ProcessStartInfo processStartInfo = new ProcessStartInfo(command, arguments);
            processStartInfo.WorkingDirectory = scriptDirectory;
            processStartInfo.UseShellExecute = false;
            processStartInfo.CreateNoWindow = false;

            try
            {
                Process.Start(processStartInfo);
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }

        }



        private void textBox_GameID_TextChanged(object sender, EventArgs e)
        {
            UpdateRichTextBoxInput();
        }

        private void textBox_WorkshopID_TextChanged(object sender, EventArgs e)
        {
            UpdateRichTextBoxInput();
        }

        private void timer_UpdateRichTextBoxInput_Tick(object sender, EventArgs e)
        {
            UpdateRichTextBoxInput();
        }

        private void STRAM_Load(object sender, EventArgs e)
        {
            currentDirectory = Environment.CurrentDirectory + @"\steamcmd";
            if (!Directory.Exists(currentDirectory))
            {
                MessageBox.Show("Could not find steamcmd folder in directory please install steamcmd and put the folder in this directory");
                ProcessStartInfo SteamCmdLink = new ProcessStartInfo("cmd", $"/c start https://steamcdn-a.akamaihd.net/client/installer/steamcmd.zip");
                SteamCmdLink.CreateNoWindow = true;
                SteamCmdLink.UseShellExecute = false;
                Process.Start(SteamCmdLink);
                Application.Exit();
            }
        }
    }
}
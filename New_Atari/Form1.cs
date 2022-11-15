using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.ComponentModel;
using System.IO;

namespace New_Atari
{
    public partial class Form1 : Form
    {
        string conda;
        string strCmdText = "C:\\Users\\ое\\PycharmProjects\\pythonProject\\venv\\Scripts\\activate.bat";
        private int chosenGame = 0;
        private string chosenAlgo;
        static string solutionDir = Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.FullName;
        public Form1()
        {
            InitializeComponent();
            conda = "";
        }
        //the BUTTONS
        private void B_showPlayedGame_Click(object sender, EventArgs e)
        {
            if (chosenAlgo != null)
            {
                if (chosenGame == 0)
                {
                    showFrozenLake(chosenAlgo);
                }
                else if (chosenGame == 1)
                {
                    trainCartPole(chosenAlgo);
                }
                else
                {
                    trainMountainCart(chosenAlgo);
                }
            }
        }
 
        private void b_Play_Click(object sender, EventArgs e)
        {
            MessageBox.Show("clickedPlay");
        }
        //chosse a game BUTTONS
        private void b_frozenLake_Click(object sender, EventArgs e)
        {
            chosenGame = 0;
            setAlgo(chosenGame);
        }

        private void b_cartPole_Click(object sender, EventArgs e)
        {
            chosenGame = 1;
            setAlgo(chosenGame);
        }

        private void b_MountCar_Click(object sender, EventArgs e)
        {
            chosenGame = 2;
            setAlgo(chosenGame);
        }
        //the Train Button
        private void b_Train_Click(object sender, EventArgs e)
        {
            if (chosenAlgo != null)
            {
                if (chosenGame == 0)
                {
                    trainFrozenLake(chosenAlgo);
                }
                else if (chosenGame == 1)
                {
                    trainCartPole(chosenAlgo);
                }
                else
                {
                    trainMountainCart(chosenAlgo);
                }
            }
        }
        //Choose An Algoritm
        private void cB_AlgoPick_SelectedValueChanged(object sender, EventArgs e)
        {
            chosenAlgo = cB_AlgoPick.SelectedItem.ToString();
            //MessageBox.Show(chosenAlgo);
        }

        //the Show Functions 
        private void showFrozenLake(string algo)
        {
            if (chosenGame == 0)
            {
                if (algo == "Q_learning")
                {
                    string pythonWorkDir = solutionDir + "\\gamesPy\\FrozenLake_Q_table_discrete\\";
                    var workingDirectory = Path.GetFullPath(pythonWorkDir);
                    string outputImagePath = workingDirectory + "frozenLake.png";
                    string outputVideoPath = workingDirectory + "f_lake.mp4";
                    drawPlt(outputImagePath);
                    vid_Player.Visible = true;
                    vid_Player.URL = outputVideoPath;
                    vid_Player.Ctlcontrols.play();
                }
            }
        }
       
        //The Train Functions

        private void trainFrozenLake(string algo)
        {
            // pB_wait.Visible = true;
            if (algo == "Q_learning")
            {
                string pythonWorkDir = solutionDir + "\\gamesPy\\FrozenLake_Q_table_discrete\\";
                var workingDirectory = Path.GetFullPath(pythonWorkDir);
                string command = String.Format("play.py");
                callProcess(pythonWorkDir, workingDirectory, command);
                try
                {
                    string outputImagePath = workingDirectory + "frozenLake.png";
                    drawPlt(outputImagePath);

                }
                catch (Exception exse)
                {
                    string message = exse.Message;
                }
            }
        }
        private void trainCartPole(string algo)
        {
            if (algo == "Q_learning")
            {
                string pythonWorkDir = solutionDir + "\\gamesPy\\CartPole_Q_table\\";
                var workingDirectory = Path.GetFullPath(pythonWorkDir);
                string command;
                command = String.Format("cartpole_descrit_Q-table.py");
                callProcess(pythonWorkDir, workingDirectory, command);
                try
                {
                    //here is not finished
                   // string outputImagePath = workingDirectory + "cartPole_.png";
                   // drawPlt(outputImagePath);

                }
                catch (Exception exse)
                {
                    string message = exse.Message;
                }
            }
        }

        private void trainMountainCart(string algo)
        {
            if (algo == "Q_learning")
            {
                string pythonWorkDir = solutionDir + "\\gamesPy\\CartPole_Q_table\\";
                var workingDirectory = Path.GetFullPath(pythonWorkDir);
                string command;
                command = String.Format("cartpole_descrit_Q-table.py");
                callProcess(pythonWorkDir, workingDirectory, command);
                try
                {
                    string outputImagePath = workingDirectory + "cartPole_.png";
                    drawPlt(outputImagePath);

                }
                catch (Exception exse)
                {
                    string message = exse.Message;
                }
            }

        }
        //Utilities
        private void setAlgo(int chGame)
        {
            L_AlgoPick.Visible = true;
            cB_AlgoPick.Visible = true;
            cB_AlgoPick.Items.Clear();
            if (chosenGame == 0)
            {
                cB_AlgoPick.Items.Add("Q_learning");
            }
            else if (chosenGame == 1)
            {
                cB_AlgoPick.Items.Add("Q_learning");
            }
            else
            {

            }
        }

        private void drawPlt(string outputImagePath)
        {
            L_welcome.Visible = false;
            L_Plot.Visible = true;
            pB_TrainigCurve.Visible = true;
            pB_TrainigCurve.Image = Image.FromStream(new MemoryStream(File.ReadAllBytes(outputImagePath)));
            pB_TrainigCurve.SizeMode = PictureBoxSizeMode.StretchImage;
        }
        private void callProcess(string pythonWorkDir, string workingDirectory, string command)
        {
            var process = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = "cmd.exe",
                    RedirectStandardInput = true,
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    WorkingDirectory = workingDirectory,
                    CreateNoWindow = true
                }
            };
            process.Start();
            // Pass multiple commands to cmd.exe
            using (var sw = process.StandardInput)
            {
                if (sw.BaseStream.CanWrite)
                {
                    // Vital to activate Anaconda
                    sw.WriteLine(strCmdText);
                    // run your script. You can also pass in arguments
                    // string command = String.Format("python matching.py --template \"{0}\" --image \"{1}\" --output \"{2}\" --count {3}",
                    //  wordPath, imagePath, outputImagePath, numOfResults);
                    //command = String.Format("play.py");
                    sw.WriteLine(command);
                    sw.WriteLine("exit");
                    //process.WaitForExit(600000);
                    while (!process.StandardOutput.EndOfStream)
                    {
                        var line = process.StandardOutput.ReadLine();
                        conda += line + "\r\n";
                    }
                    // 
                    // process.WaitForExit();
                }
                else
                {
                    Debug.WriteLine("Error occured");
                }
            }
        }
    }
}
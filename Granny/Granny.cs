using KrnlAPI;
using Microsoft.Win32;
using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Granny
{
    public partial class Granny : Form
    {
        Point lastPoint;
        public Granny()
        {
            InitializeComponent();
        }
        WebClient wc = new WebClient();
        private string defPath = "Monaco\\";

        private void addIntel(string label, string kind, string detail, string insertText)
        {
            string text = "\"" + label + "\"";
            string text2 = "\"" + kind + "\"";
            string text3 = "\"" + detail + "\"";
            string text4 = "\"" + insertText + "\"";
            ScriptBox.Document.InvokeScript("AddIntellisense", new object[]
            {
                label,
                kind,
                detail,
                insertText
            });
        }

        private void addGlobalF()
        {
            string[] array = File.ReadAllLines(this.defPath + "//globalf.txt");
            foreach (string text in array)
            {
                bool flag = text.Contains(':');
                if (flag)
                {
                    this.addIntel(text, "Function", text, text.Substring(1));
                }
                else
                {
                    this.addIntel(text, "Function", text, text);
                }
            }
        }

        private void addGlobalV()
        {
            foreach (string text in File.ReadLines(this.defPath + "//globalv.txt"))
            {
                this.addIntel(text, "Variable", text, text);
            }
        }

        private void addGlobalNS()
        {
            foreach (string text in File.ReadLines(this.defPath + "//globalns.txt"))
            {
                this.addIntel(text, "Class", text, text);
            }
        }

        private void addMath()
        {
            foreach (string text in File.ReadLines(this.defPath + "//classfunc.txt"))
            {
                this.addIntel(text, "Method", text, text);
            }
        }

        private void addBase()
        {
            foreach (string text in File.ReadLines(this.defPath + "//base.txt"))
            {
                this.addIntel(text, "Keyword", text, text);
            }
        }

        private async void Granny_Load(object sender, EventArgs e)
        {
            WebClient wc = new WebClient();
            wc.Proxy = null;
            try
            {
                RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Internet Explorer\\Main\\FeatureControl\\FEATURE_BROWSER_EMULATION", true);
                string friendlyName = AppDomain.CurrentDomain.FriendlyName;
                bool flag2 = registryKey.GetValue(friendlyName) == null;
                if (flag2)
                {
                    registryKey.SetValue(friendlyName, 11001, RegistryValueKind.DWord);
                }
                registryKey = null;
                friendlyName = null;
            }
            catch (Exception)
            {
            }
            ScriptBox.Url = new Uri(string.Format("file:///{0}/Monaco/Monaco.html", Directory.GetCurrentDirectory()));
            await Task.Delay(500);
            addBase();
            addMath();
            addGlobalNS();
            addGlobalV();
            addGlobalF();
            ScriptList.Items.Clear();
            Functions.PopulateListBox(ScriptList, "./Scripts", "*.txt");
            Functions.PopulateListBox(ScriptList, "./Scripts", "*.lua");
            using (StreamReader sr = new StreamReader("Script.txt"))
                this.ScriptBox.Document.InvokeScript("SetText", new object[1]
                {
                (object) sr.ReadToEnd()
                });
            if (!Directory.Exists("./autoexec"))
                Directory.CreateDirectory("autoexec");
            if (!Directory.Exists("./Scripts"))
                Directory.CreateDirectory("Scripts");
            if (!Directory.Exists("./workspace"))
                Directory.CreateDirectory("workspace");
        }
        private void ListRefresh_Changed(object sender, System.IO.FileSystemEventArgs e)
        {
            ScriptList.Items.Clear();
            Functions.PopulateListBox(ScriptList, "./Scripts", "*.txt");
            Functions.PopulateListBox(ScriptList, "./Scripts", "*.lua");
        }
        private void ListRefresh_Deleted(object sender, System.IO.FileSystemEventArgs e)
        {
            ScriptList.Items.Clear();
            Functions.PopulateListBox(ScriptList, "./Scripts", "*.txt");
            Functions.PopulateListBox(ScriptList, "./Scripts", "*.lua");
        }
        private void ListRefresh_Renamed(object sender, System.IO.FileSystemEventArgs e)
        {
            ScriptList.Items.Clear();
            Functions.PopulateListBox(ScriptList, "./Scripts", "*.txt");
            Functions.PopulateListBox(ScriptList, "./Scripts", "*.lua");
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void MinBtn_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void Header_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void Header_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            ScriptBox.Document.InvokeScript("SetText", new object[]
            {
                ""
            });
        }

        private void OpenFileBtn_Click(object sender, EventArgs e)
        {
            if (Functions.openfiledialog.ShowDialog() == DialogResult.OK)
            {
                try
                {

                    string MainText = File.ReadAllText(Functions.openfiledialog.FileName);
                    ScriptBox.Document.InvokeScript("SetText", new object[]
                    {
                          MainText
                    });

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
        }

        private void SaveFileBtn_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Lua Script (*.lua)|*.lua|Txt Script (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog1.Title = "Granny";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                using (Stream s = File.Open(saveFileDialog1.FileName, FileMode.OpenOrCreate))
                using (StreamWriter sw = new StreamWriter(s))
                {
                    HtmlDocument document = ScriptBox.Document;
                    string scriptName = "GetText";
                    object[] args = new string[0];
                    object obj = document.InvokeScript(scriptName, args);
                    string script = obj.ToString();
                    sw.Write(script);
                }
            }
        }

        private void ExecuteFileBtn_Click(object sender, EventArgs e)
        {
            if (Functions.openfiledialog.ShowDialog() == DialogResult.OK)
            {
                try
                {

                    string MainText = File.ReadAllText(Functions.openfiledialog.FileName);
                    MainAPI.Execute(MainText);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
        }

        private void ExecuteBtn_Click(object sender, EventArgs e)
        {
            HtmlDocument document = ScriptBox.Document;
            string scriptName = "GetText";
            object[] args = new string[0];
            object obj = document.InvokeScript(scriptName, args);
            string script = obj.ToString();
            MainAPI.Execute(script);
        }

        private void AttachBtn_Click(object sender, EventArgs e)
        {
            MainAPI.Inject();
        }

        private void InjectionTimer_Tick(object sender, EventArgs e)
        {
            if (MainAPI.IsAttached())
            {
                AttachBtn.Text = "Attached";
            }
            else
            {
                AttachBtn.Text = "Attach";
            }
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ScriptList.SelectedIndex != -1)
            {
                this.ScriptBox.Document.InvokeScript("SetText", new object[1]
                {
          (object) System.IO.File.ReadAllText("Scripts\\" + this.ScriptList.SelectedItem.ToString())
                });
            }
            else
            {
                int num = (int)MessageBox.Show("Please select a script from the list before trying to loading it.", "Name");
            }
        }

        private void ExecuteStrip_Click(object sender, EventArgs e)
        {
            MainAPI.Execute(File.ReadAllText("Scripts\\" + this.ScriptList.SelectedItem.ToString()));
        }

        private void DeleteStrip_Click(object sender, EventArgs e)
        {
            File.Delete("Scripts\\" + this.ScriptList.SelectedItem.ToString());
        }

        private void ScriptSaver_Tick(object sender, EventArgs e)
        {
            using (StreamWriter streamWriter = new StreamWriter("Script.txt"))
            {
                HtmlDocument document = ScriptBox.Document;
                string scriptName = "GetText";
                object[] args = new string[0];
                object obj = document.InvokeScript(scriptName, args);
                string script = obj.ToString();
                streamWriter.Write(script);
            }
        }

        private void OpenBtn_Click(object sender, EventArgs e)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo
            {
                Arguments = Application.StartupPath,
                FileName = "explorer.exe"
            };

            Process.Start(startInfo);
        }

        private void FolderWatcher_Changed(object sender, FileSystemEventArgs e)
        {
            if (!MainAPI.IsAttached())
            {
                System.IO.File.Delete("krnl");
                wc.DownloadFile("https://k-storage.com/bootstrapper/files/krnl.dll", "krnl.dll");
            }
            if (!Directory.Exists("./autoexec"))
                Directory.CreateDirectory("autoexec");
            if (!Directory.Exists("./Scripts"))
                Directory.CreateDirectory("Scripts");
            if (!Directory.Exists("./workspace"))
                Directory.CreateDirectory("workspace");
        }
        private void FolderWatcher_Deleted(object sender, FileSystemEventArgs e)
        {
            if (!MainAPI.IsAttached())
            {
                System.IO.File.Delete("krnl");
                wc.DownloadFile("https://k-storage.com/bootstrapper/files/krnl.dll", "krnl.dll");
            }
            if (!Directory.Exists("./autoexec"))
                Directory.CreateDirectory("autoexec");
            if (!Directory.Exists("./Scripts"))
                Directory.CreateDirectory("Scripts");
            if (!Directory.Exists("./workspace"))
                Directory.CreateDirectory("workspace");
        }

        private void KillRblxBtn_Click(object sender, EventArgs e)
        {
            foreach (Process process in Process.GetProcessesByName("RobloxPlayerBeta"))
                process.Kill();
        }

        private void JoinStrip_Click(object sender, EventArgs e)
        {
            Process.Start("https://discord.gg/esn6q3BbV2");
        }

        private void GrannyHubStrip_Click(object sender, EventArgs e)
        {
            MainAPI.Execute("loadstring(game:HttpGet('https://grannythedev.github.io/GrannyHub/GrannyHub.lua'))()");
        }

        private void DarkDexStrip_Click(object sender, EventArgs e)
        {
            MainAPI.Execute("loadstring(game:HttpGet('https://raw.githubusercontent.com/Babyhamsta/RBLX_Scripts/main/Universal/BypassedDarkDexV3.lua'))()");
        }

        private void RemoteSpyStrip_Click(object sender, EventArgs e)
        {
            MainAPI.Execute("loadstring(game:HttpGet('https://pastebin.com/raw/JZaJe9Sg'))()");
        }

        private void InfinityYieldStrip_Click(object sender, EventArgs e)
        {
            MainAPI.Execute("loadstring(game:HttpGet('https://raw.githubusercontent.com/EdgeIY/infiniteyield/master/source'))()");
        }

        private void AutoAttachTimer_Tick(object sender, EventArgs e)
        {
            if (Process.GetProcessesByName("RobloxPlayerBeta").Length >= 1)
            {
                MainAPI.Inject();
            }
        }
    }
}
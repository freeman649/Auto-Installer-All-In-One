using System;
using System.IO;
using System.Net.Http;
using System.Diagnostics;
using System.Windows.Forms;

namespace Auto_Installer_All_In_One
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void guna2Button1_Click(object sender, EventArgs e)
        {
            string url = "https://cdn.cloudflare.steamstatic.com/client/installer/SteamSetup.exe";
            string cheminLocal = "C:\\Auto_Installer_All_In_One_Setup\\SteamSetup.exe";

            using (HttpClient client = new HttpClient())
            {
                byte[] data = await client.GetByteArrayAsync(url);

                File.WriteAllBytes(cheminLocal, data);
            }

            Process.Start(cheminLocal);
        }

        private async void guna2Button2_Click(object sender, EventArgs e)
        {
            string url = "https://gamedownloads.rockstargames.com/public/installer/Rockstar-Games-Launcher.exe";
            string cheminLocal = "C:\\Auto_Installer_All_In_One_Setup\\Rockstar-Games-Launcher.exe";

            using (HttpClient client = new HttpClient())
            {
                byte[] data = await client.GetByteArrayAsync(url);

                File.WriteAllBytes(cheminLocal, data);
            }

            Process.Start(cheminLocal);
        }

        private async void guna2Button3_Click(object sender, EventArgs e)
        {
            string url = "https://launcher-public-service-prod06.ol.epicgames.com/launcher/api/installer/download/EpicGamesLauncherInstaller.msi?trackingId=93be4291c210451b9de4889c34e4b372";
            string cheminLocal = "C:\\Auto_Installer_All_In_One_Setup\\EpicInstaller-15.17.1-93be4291c210451b9de4889c34e4b372.msi";

            using (HttpClient client = new HttpClient())
            {
                byte[] data = await client.GetByteArrayAsync(url);

                File.WriteAllBytes(cheminLocal, data);
            }

            Process.Start(cheminLocal);
        }

        private async void guna2Button4_Click(object sender, EventArgs e)
        {
            string url = "https://ubi.li/4vxt9";
            string cheminLocal = "C:\\Auto_Installer_All_In_One_Setup\\UbisoftConnectInstaller.exe";

            using (HttpClient client = new HttpClient())
            {
                byte[] data = await client.GetByteArrayAsync(url);

                File.WriteAllBytes(cheminLocal, data);
            }

            Process.Start(cheminLocal);
        }

        private async void guna2Button5_Click(object sender, EventArgs e)
        {
            using (var customMessageBox = new Form())
            {
                customMessageBox.Text = "MessageBox Personnalisée";

                var labelContenu = new Label();
                labelContenu.Text = "choose which games you want to install on Riot Games";
                labelContenu.Location = new System.Drawing.Point(10, 10);
                customMessageBox.Controls.Add(labelContenu);

                var boutonInteractif = new Button();
                boutonInteractif.Text = "Valorant";
                boutonInteractif.Size = new System.Drawing.Size(100, 30);
                boutonInteractif.Location = new System.Drawing.Point(50, 50);
                boutonInteractif.Click += (s, ev) =>
                {
                    string url = "https://valorant.secure.dyn.riotcdn.net/channels/public/x/installer/current/live.live.eu.exe";
                    string cheminLocal = "C:\\Install VALORANT.exe";

                    using (HttpClient client = new HttpClient())
                    {
                        //byte[] data = await client.GetByteArrayAsync(url);

                        //File.WriteAllBytes(cheminLocal, data);
                    }

                    Process.Start(cheminLocal);
                };
                customMessageBox.Controls.Add(boutonInteractif);

                customMessageBox.ShowDialog();
            }
        }

        private async void guna2Button6_Click(object sender, EventArgs e)
        {
            string url = "https://webinstallers.gog-statics.com/download/GOG_Galaxy_2.0.exe";
            string cheminLocal = "C:\\Auto_Installer_All_In_One_Setup\\GOG_Galaxy_2.0.exe";

            using (HttpClient client = new HttpClient())
            {
                byte[] data = await client.GetByteArrayAsync(url);

                File.WriteAllBytes(cheminLocal, data);
            }

            Process.Start(cheminLocal);
        }

        private async void guna2Button7_Click(object sender, EventArgs e)
        {
            string url = "https://downloader.battle.net/download/getInstallerForGame?os=win&gameProgram=BATTLENET_APP&version=Live";
            string cheminLocal = "C:\\Auto_Installer_All_In_One_Setup\\Battle.net-Setup.exe";

            using (HttpClient client = new HttpClient())
            {
                byte[] data = await client.GetByteArrayAsync(url);

                File.WriteAllBytes(cheminLocal, data);
            }

            Process.Start(cheminLocal);
        }

        private async void guna2Button8_Click(object sender, EventArgs e)
        {
            string url = "https://cdn.discordapp.com/attachments/1188820883909902366/1191825591025012786/ChromeSetup.exe?ex=65a6d913&is=65946413&hm=3a8457d3e3a96f4037709058d9f585d0ac1832d0e6c36dbe10f411e295c0588b&";
            string cheminLocal = "C:\\Auto_Installer_All_In_One_Setup\\ChromeSetup.exe";

            using (HttpClient client = new HttpClient())
            {
                byte[] data = await client.GetByteArrayAsync(url);

                File.WriteAllBytes(cheminLocal, data);
            }

            Process.Start(cheminLocal);
        }

        private async void guna2Button13_Click(object sender, EventArgs e)
        {
            string url = "https://laptop-updates.brave.com/download/BRV010";
            string cheminLocal = "C:\\Auto_Installer_All_In_One_Setup\\BraveBrowserSetup-BRV010.exe";

            using (HttpClient client = new HttpClient())
            {
                byte[] data = await client.GetByteArrayAsync(url);

                File.WriteAllBytes(cheminLocal, data);
            }

            Process.Start(cheminLocal);
        }

        private async void guna2Button9_Click(object sender, EventArgs e)
        {
            string url = "https://www.opera.com/fr/computer/thanks?ni=stable&os=windows";
            string cheminLocal = "C:\\Auto_Installer_All_In_One_Setup\\OperaSetup.exe";

            using (HttpClient client = new HttpClient())
            {
                byte[] data = await client.GetByteArrayAsync(url);

                File.WriteAllBytes(cheminLocal, data);
            }

            Process.Start(cheminLocal);
        }

        private async void guna2Button11_Click(object sender, EventArgs e)
        {
            string url = "https://www.opera.com/fr/computer/thanks?ni=eapgx&os=windows";
            string cheminLocal = "C:\\Auto_Installer_All_In_One_Setup\\OperaGXSetup.exe";

            using (HttpClient client = new HttpClient())
            {
                byte[] data = await client.GetByteArrayAsync(url);

                File.WriteAllBytes(cheminLocal, data);
            }

            Process.Start(cheminLocal);
        }

        private async void guna2Button12_Click(object sender, EventArgs e)
        {
            string url = "https://cdn.discordapp.com/attachments/1188820883909902366/1192078897475485746/Firefox_Installer.fr.exe?ex=65a7c4fc&is=65954ffc&hm=d88239e0acb82d5d6d5812e413970b9416dabba2ec29fffdf1da3025a32cba1d&";
            string cheminLocal = "C:\\Auto_Installer_All_In_One_Setup\\Firefox_Installer.fr.exe";

            using (HttpClient client = new HttpClient())
            {
                byte[] data = await client.GetByteArrayAsync(url);

                File.WriteAllBytes(cheminLocal, data);
            }

            Process.Start(cheminLocal);
        }

        private async void guna2Button10_Click(object sender, EventArgs e)
        {
            string url = "https://www.mozilla.org/fr/firefox/download/thanks/";
            string cheminLocal = "C:\\Auto_Installer_All_In_One_Setup\\Firefox_Installer.exe";

            using (HttpClient client = new HttpClient())
            {
                byte[] data = await client.GetByteArrayAsync(url);

                File.WriteAllBytes(cheminLocal, data);
            }

            Process.Start(cheminLocal);
        }

        private async void guna2Button14_Click(object sender, EventArgs e)
        {
            string url = "https://dist.torproject.org/torbrowser/13.0.8/tor-browser-windows-x86_64-portable-13.0.8.exe";
            string cheminLocal = "C:\\Auto_Installer_All_In_One_Setup\\tor-browser-windows-x86_64-portable-13.0.8.exe";

            using (HttpClient client = new HttpClient())
            {
                byte[] data = await client.GetByteArrayAsync(url);

                File.WriteAllBytes(cheminLocal, data);
            }

            Process.Start(cheminLocal);
        }

        private async void guna2Button15_Click(object sender, EventArgs e)
        {
            string url = "";
            string cheminLocal = "";

            using (HttpClient client = new HttpClient())
            {
                byte[] data = await client.GetByteArrayAsync(url);

                File.WriteAllBytes(cheminLocal, data);
            }

            Process.Start(cheminLocal);
        }
    }
}

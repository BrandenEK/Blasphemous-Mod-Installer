﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.IO;
using System.Net;
using Newtonsoft.Json;
using System.Net.Http;
using System.Windows.Forms;

namespace BlasModInstaller.Pages
{
    public class BlasModPage : InstallerPage<ModRow>
    {
        public BlasModPage(Panel pageSection) : base(pageSection) { }

        protected override string SaveDataPath => Environment.CurrentDirectory + "\\downloads\\BlasphemousMods.json";

        protected override void LoadLocalData()
        {
            if (File.Exists(SaveDataPath))
            {
                string json = File.ReadAllText(SaveDataPath);
                List<ModData> localData = JsonConvert.DeserializeObject<List<ModData>>(json);
                
                for (int i = 0; i < localData.Count; i++)
                {
                    ModData localMod = localData[i];
                    dataCollection.Add(new ModRow(localMod));
                    dataCollection[i].CreateUI(PageSection, i);
                    MainForm.Log(localMod.Installed ? localMod.LocalVersion.ToString() : "Not installed");
                }
            }

            MainForm.Log($"Loaded {dataCollection.Count} local mods");
            SetBackgroundColor();
        }

        protected override async Task LoadGlobalData()
        {
            await base.LoadGlobalData();

            using (HttpClient client = new HttpClient())
            {
                string json = await client.GetStringAsync("https://raw.githubusercontent.com/BrandenEK/Blasphemous-Mod-Installer/main/mods.json");
                ModData[] globalData = JsonConvert.DeserializeObject<ModData[]>(json);

                foreach (ModData globalMod in globalData)
                {
                    Octokit.Release latestRelease = await MainForm.GetLatestRelease(globalMod.GithubAuthor, globalMod.GithubRepo);
                    Version webVersion = new Version(ModData.CleanSemanticVersion(latestRelease.TagName));
                    string downloadURL = latestRelease.Assets[0].BrowserDownloadUrl;

                    if (DataExists(globalMod, out ModData localMod))
                    {
                        localMod.UpdateLocalData(globalMod);
                        localMod.LatestVersion = webVersion.ToString();
                        localMod.LatestDownloadURL = downloadURL;
                        localMod.UI.UpdateUI();
                    }
                    else
                    {
                        globalMod.LatestVersion = webVersion.ToString();
                        globalMod.LatestDownloadURL = downloadURL;
                        dataCollection.Add(globalMod);
                        globalMod.UI.CreateUI(PageSection, dataCollection.Count - 1);
                    }
                }

                MainForm.Log($"Loaded {globalMods.Length} global mods");
            }

            //MainForm.Log($"Github API calls remaining: {github.GetLastApiInfo().RateLimit.Remaining}");
            SetBackgroundColor();
            SaveLocalData();
        }

        private void SetBackgroundColor()
        {
            PageSection.BackColor = dataCollection.Count % 2 == 0 ? Colors.DARK_GRAY : Colors.LIGHT_GRAY;
        }

        public int InstalledModsThatRequireDll(string dllName)
        {
            int count = 0;
            foreach (ModData mod in dataCollection)
            {
                if (mod.RequiresDll(dllName) && mod.Installed)
                    count++;
            }
            return count;
        }
    }
}

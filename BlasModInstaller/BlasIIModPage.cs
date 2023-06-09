﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;
using System.Threading.Tasks;

namespace BlasModInstaller.Pages
{
    public class BlasIIModPage : InstallerPage<Mod>
    {
        public BlasIIModPage(Panel pageSection) : base(pageSection) { }

        protected override string SaveDataPath => Environment.CurrentDirectory + "\\downloads\\BlasphemousIIMods.json";

        public override string Name => "Blasphemous II Mods";

        protected override void LoadLocalData()
        {
            base.LoadLocalData();
        }

        protected override Task LoadGlobalData()
        {
            return base.LoadGlobalData();
        }

        public override void Sort()
        {
            
        }
    }
}

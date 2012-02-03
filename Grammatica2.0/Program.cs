using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DevExpress.LookAndFeel;
using DevExpress.Xpo;
using DevExpress.Xpo.DB;
using System.IO;

namespace Grammatica2._0 {
    static class Program {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            string assemblyPath = Path.GetDirectoryName(typeof(Program).Assembly.Location);
            string connectionString = InMemoryDataStore.GetConnectionString(Path.Combine(assemblyPath, "data.xml"));
            XpoDefault.DataLayer = XpoDefault.GetDataLayer(connectionString, AutoCreateOption.DatabaseAndSchema);
            XpoDefault.Session = null;

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            DevExpress.Skins.SkinManager.EnableFormSkins();
            DevExpress.UserSkins.BonusSkins.Register();
            UserLookAndFeel.Default.SetSkinStyle("DevExpress Style");

            Application.Run(new Form1());
        }
    }
}
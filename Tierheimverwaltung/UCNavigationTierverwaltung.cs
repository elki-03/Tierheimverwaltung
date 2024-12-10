using System;
using System.Windows.Forms;
using Tierheimverwaltung.AufnahmeAbgabe;
using Tierheimverwaltung.Kennzeichnung;
using Tierheimverwaltung.MedAkte;
using Tierheimverwaltung.VerVer;

namespace Tierheimverwaltung
{
    public partial class UCNavigationTierverwaltung : UserControl
    {
        public UCNavigationTierverwaltung()
        {
            InitializeComponent();
            Form1.instance.PanelContainerBig.Controls.Clear();
        }


        private void buttonStammdaten_Click(object sender, EventArgs e)
        {
            Form1.instance.PanelContainerBig.Controls.Clear();
            UCStammtierdaten ucStammtierdaten = new UCStammtierdaten();
            Form1.instance.PanelContainerBig.Controls.Add(ucStammtierdaten);
            //Buttonfarbe ändern?
        }

        private void buttonKennzeichnung_Click(object sender, EventArgs e)
        {
            Form1.instance.PanelContainerBig.Controls.Clear();
            UCKennzeichnung ucKennzeichnung = new UCKennzeichnung();
            Form1.instance.PanelContainerBig.Controls.Add(ucKennzeichnung);
        }

        private void buttonMedizinischeAkte_Click(object sender, EventArgs e)
        {
            Form1.instance.PanelContainerBig.Controls.Clear();
            UCMedAkte ucMedAkte = new UCMedAkte();
            Form1.instance.PanelContainerBig.Controls.Add(ucMedAkte);
        }

        private void buttonVerhalten_Click(object sender, EventArgs e)
        {
            Form1.instance.PanelContainerBig.Controls.Clear();
            UCVerVer ucVerVer = new UCVerVer();
            Form1.instance.PanelContainerBig.Controls.Add(ucVerVer);
        }

        private void buttonAufnAbg_Click(object sender, EventArgs e)
        {
            Form1.instance.PanelContainerBig.Controls.Clear();
            UCAufAb ucAufAb = new UCAufAb();
            Form1.instance.PanelContainerBig.Controls.Add(ucAufAb);
        }
    }
}
using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Tierheimverwaltung
{
    public partial class Form1 : Form //Packet intallieren!!! Nuget --> MAterialSkin2 leocb
    {
        public static Form1 instance;

        public Form1()
        {
            InitializeComponent();
            
            instance = this;
        }


        public Panel PanelNavigation
        {
            get { return panelNavigation; }
            set { panelNavigation = value; }
        }
        
        public Panel PanelContainerBig
        {
            get { return panelContainerBig; }
            set { panelContainerBig = value; }
        }

        /*
        private void deleteButton_Click(object sender, EventArgs e)
        {
            PanelContainerBig.Controls.Clear();
            UCStammtierdaten ucStammtierdaten = new UCStammtierdaten();
            PanelContainerBig.Controls.Add(ucStammtierdaten);

        } */

        private void buttonTierverwaltung_Click(object sender, EventArgs e)
        {
            PanelNavigation.Controls.Clear();
            UCNavigationTierverwaltung ucNavigationTierverwaltung = new UCNavigationTierverwaltung();
            PanelNavigation.Controls.Add(ucNavigationTierverwaltung);
            
            PanelContainerBig.Controls.Clear();
            UCTierverwaltungZwischenPanel ucTierverwaltungZwischenPanel = new UCTierverwaltungZwischenPanel();
            PanelContainerBig.Controls.Add(ucTierverwaltungZwischenPanel);
            
        }
        
       


        private void buttonPersonen_Click(object sender, EventArgs e)
        {
            PanelNavigation.Controls.Clear();
            UCNavigationPersonen ucNavigationPersonen = new UCNavigationPersonen();
            PanelNavigation.Controls.Add(ucNavigationPersonen);
        }
    }

}
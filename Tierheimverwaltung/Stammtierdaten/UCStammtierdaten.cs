using System.Windows.Forms;
using System;
using Tierheimverwaltung.Kennzeichnung;



namespace Tierheimverwaltung
{
    public partial class UCStammtierdaten : UserControl
    {
        public static UCStammtierdaten instance;
        
        public UCStammtierdaten()
        {
            InitializeComponent();
            
            
            
            instance = this;
            UpdateStammtierView();
        }
        
        
        public void UpdateStammtierView()
        {
            dataGridView1.DataSource = DBStammtierdaten.ReadAllGrid().Tables[0];//liest Tabelle automatisch ganz
        }
        
        /*
        
        public Panel PanelContainerBigStammt
        {
            get { return panelContainerBigStammt; }
            set { panelContainerBigStammt = value; }
        }
        
        */
        
        public Panel PanelContainerStammt
        {
            get { return panelContainerStammt; }
            set { panelContainerStammt = value; }
        }
        

        /*
        private void buttonKennzeichnung_Click(object sender, EventArgs e)
        {
            Form1.instance.panelContainerBig.Controls.Clear();
            UCKennzeichnung ucKennzeichnung = new UCKennzeichnung();
            Form1.instance.panelContainerBig.Controls.Add(ucKennzeichnung);
        }
        ---------> zu umständlich alle Buttons einzelnd anzusprechen: Bessere Lösung naviagationspanel mit eigener UC
        */
        
        
        
        private void createButton_Click_1(object sender, EventArgs e)
        {
            PanelContainerStammt.Controls.Clear();
            UCStammtierCreate ucStammtierCreate = new UCStammtierCreate();
            PanelContainerStammt.Controls.Add(ucStammtierCreate);
        }
        
        private void updateButton_Click_1(object sender, EventArgs e)
        {
            PanelContainerStammt.Controls.Clear();
            UCStammtierUpdate ucStammtierUpdate = new UCStammtierUpdate();
            PanelContainerStammt.Controls.Add(ucStammtierUpdate);
        }
        
        private void deleteButton_Click_1(object sender, EventArgs e)
        {
            PanelContainerStammt.Controls.Clear();
            UCStammtierdatenDeleteIDEing ucStammtierdatenDeleteIDEing = new UCStammtierdatenDeleteIDEing();
            PanelContainerStammt.Controls.Add(ucStammtierdatenDeleteIDEing);
        }
        
        // private void buttonLandingPage_Click_1(object sender, EventArgs e)
        // {
        //     Landingpage landingpage = new Landingpage();
        //     landingpage.Show(); // --> neues Fenster mit neuer Form ploppt auf!! Karteikarte
        // }


        
    }
}
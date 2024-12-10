using System;
using System.Windows.Forms;
using MySqlConnector;

namespace Tierheimverwaltung.VerVer
{
    public partial class UCVerVerCreate : UserControl
    {
        public UCVerVerCreate()
        {
            InitializeComponent();
            labelTierIDVerVer.Text = Convert.ToString(GlobalVariables.idStammtier); //auswirkungen wenn man das weglässt?
        }


        private void buttonSaveCreateMedAkte_Click(object sender, EventArgs e)
        {
            try
                        {
                            int inputTextTier_id = Convert.ToInt32(labelTierIDVerVer.Text);
                            string inputTextVerhaltenNo = verhaltenNotb.Text;
                            string inputTextVertraeglichkeitNo = vertraeglichkeitNotb.Text;
                            int inputTextzustPerson_id = Convert.ToInt32(zustPerson_idtb.Text);
                            string inputTextPate = patetb.Text;
                         
            
            
                            VerVer medakteZusammen = new VerVer(inputTextTier_id, inputTextVerhaltenNo, inputTextVertraeglichkeitNo,
                                inputTextzustPerson_id, inputTextPate);
            
            
                            DBVerVer.Create(medakteZusammen);
                            //
                            UCVerVer.instance.UpdateVerVerView();
                            MessageBox.Show("Erfolgreich angelegt");
                        }
                        catch (MySqlException exception)
                        {
                            MessageBox.Show(exception.Message);
                        }
        }
    }
}
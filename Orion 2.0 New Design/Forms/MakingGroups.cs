using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using Newtonsoft.Json;

namespace Orion_2._0_New_Design.Forms
{
    public partial class MakingGroups : Form
    {
        string checkedBOX = "false";
        string stdDetails = "{0, -10}{1, -20}";
        string codeTP = "0";
        int index = 0;
        List<string> arrTPN = new List<string>();
        List<string> arrTPC = new List<string>();

        public void Alert(string msg, Form_Alert.enmType type)
        {
            Form_Alert frm = new Form_Alert();
            frm.showAlert(msg, type);
        }

        public MakingGroups()
        {
            InitializeComponent();

            using (WebClient webClient = new WebClient())
            {
                webClient.Encoding = Encoding.UTF8;
                string responseTP = webClient.DownloadString(Classes.DataBank.URL + "get_tp");
                dynamic ListBox = JsonConvert.DeserializeObject(responseTP);
                foreach (var tp in ListBox)
                {
                    arrTPC.Add(tp.CODE.ToString());
                    arrTPN.Add(tp.NAME.ToString());
                    comboBoxPlaces.Items.Add(tp.NAME);
                    index += 1;
                }
            }
            
        }
        private void comboBoxPlaces_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (checkBoxOTV.Checked)
                checkedBOX = "true";
            else
                checkedBOX = "false";
            listBoxWorkers.Items.Clear();
            for (int i = 0; i < index; i++)
            {
                if (arrTPN[i] == comboBoxPlaces.SelectedItem.ToString())
                {
                    codeTP = arrTPC[i];
                    break;
                }
            }
            using (WebClient webClient = new WebClient())
            {
                webClient.Encoding = Encoding.UTF8;
                string responseTP = webClient.DownloadString(Classes.DataBank.URL + "get_collaborator_list_num_groups?code=" + codeTP + "&checked=" + checkedBOX);
                dynamic ListWorkers = JsonConvert.DeserializeObject(responseTP);
                foreach (var item in ListWorkers)
                {
                    if (item.NAME.ToString().Length >= 16)
                        listBoxWorkers.Items.Add(item.NAME + "\t" + item.NUMBER);
                    else
                        listBoxWorkers.Items.Add(item.NAME + "\t\t" + item.NUMBER);
                }
            }
        }
    }
}

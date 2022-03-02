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
        int codeTP = 0;
        string[][] arrTP = new string[1][];

        public MakingGroups()
        {
            InitializeComponent();

            using (WebClient webClient = new WebClient())
            {
                webClient.Encoding = Encoding.UTF8;
                string responseTP = webClient.DownloadString(Classes.DataBank.URL + "get_tp");
                dynamic ListBox = JsonConvert.DeserializeObject(responseTP);
                var index = 0;
                foreach (var tp in ListBox)
                {
                    arrTP[0][index] = tp.CODE;
                    arrTP[1][index] = tp.NAME;
                    comboBoxPlaces.Items.Add(tp.NAME);
                    codeTP = tp.CODE;
                    index += 1;
                }
            }
            
        }
        private void comboBoxPlaces_SelectedIndexChanged(object sender, EventArgs e)
        {
            e.
            using (WebClient webClient = new WebClient())
            {
                webClient.Encoding = Encoding.UTF8;
                string responseTP = webClient.DownloadString(Classes.DataBank.URL + "get_collaborator_list_num_goups?code=" + codeTP);
                dynamic ListWorkers = JsonConvert.DeserializeObject(responseTP);
                foreach (var item in ListWorkers)
                {
                    listBoxWorkers.Items.Add(item.NAME);
                }
            }
        }
    }
}

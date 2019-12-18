using SwissTransport;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt_SBB
{
    public partial class Form1 : Form
    {
        private Transport transport = new Transport();
        
        public Form1()
        {
            InitializeComponent();

        }

        private void button_verbindungsuchen_Click(object sender, EventArgs e)
        {
            var route = Convert.ToString


        }

        private void comboBox_von_DropDown(object sender, EventArgs e)
        {
            var von = Convert.ToString(comboBox_von.Text);
            transport.GetStations(von);
            Stations stations = transport.GetStations(von);
            comboBox_von.Items.Clear();
            foreach (Station station in stations.StationList)
            {
                comboBox_von.Items.Add(station.Name);
            }
        }

        private void comboBox_nach_DropDown(object sender, EventArgs e)
        {
            var nach = Convert.ToString(comboBox_nach.Text);
            transport.GetStations(nach);
            Stations stations = transport.GetStations(nach);
            comboBox_nach.Items.Clear();
            foreach (Station station in stations.StationList)
            {
                comboBox_nach.Items.Add(station.Name);
            }
        }

    }
}

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
            Connections connections = transport.GetConnections(comboBox_von.Text, comboBox_nach.Text);
            //Connections connectionstime = transport.GetConnections(dtp_datum.Value.ToString("yyyy-MM-dd"), dtp_zeit.Text);
            listBox_main.Items.Clear();
            foreach (Connection connection in connections.ConnectionList)
            {
                listBox_main.Items.Add("Abfahrtsort: " + comboBox_von.Text);
                listBox_main.Items.Add("Ankunftsort: " + comboBox_nach.Text);
                listBox_main.Items.Add("Abfahrtszeit: " + connection.From.Departure + "\tAnkunftszeit: " + connection.To.Arrival + "\tLinie: " + connection.To.Platform);
                listBox_main.Items.Add("");
                
            }

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

        private void comboBox_abfahrtsplan_DropDown(object sender, EventArgs e)
        {
            var abf_von = Convert.ToString(comboBox_abfahrtsplan.Text);
            transport.GetStations(abf_von);
            Stations stations = transport.GetStations(abf_von);
            comboBox_abfahrtsplan.Items.Clear();
            foreach (Station station in stations.StationList)
            {
                comboBox_abfahrtsplan.Items.Add(station.Name);
            }
        }

        private void buttonabf_verbsuchen_Click(object sender, EventArgs e)
        {
            /*var vabf = Convert.ToString(comboBox_abfahrtsplan.Text);
            transport.GetStations(vabf);
            Connections connections = transport.GetConnections(comboBox_abfahrtsplan.Text, vabf);
            //Connections connections = transport.GetConnections(comboBox_abfahrtsplan.Text, comboBox_abfahrtsplan.Text);
            foreach (Connection connection in connections.ConnectionList)
            {
                listBox_abfahrtsplan.Items.Add(comboBox_nach.Text);
            }*/

            var vobf = Convert.ToString(comboBox_abfahrtsplan.Text);
            transport.GetConnections(vobf, vobf);
            Connections connections = transport.GetConnections(vobf, vobf);

            foreach(Connection connection in connections.ConnectionList)
            {
                listBox_abfahrtsplan.Items.Add(vobf);
            }

        }
    }
}

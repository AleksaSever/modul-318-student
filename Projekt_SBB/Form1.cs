using SwissTransport;
using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text;
using System.Net;
using System.Net.Mail;
using System.Reflection;

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
            /*Wenn Suche nicht nichts drin ist dann soll Programm ausführen
            wenn das nicht so ist dann MessageBox anzeigen*/
            if (comboBox_von.Text != "" && comboBox_nach.Text != "")   
            {
                Connections connections = transport.GetConnections(comboBox_von.Text, comboBox_nach.Text);
                //Löscht alle vorherigen Items aus der Liste
                listBox_main.Items.Clear();


                foreach (Connection connection in connections.ConnectionList)
                {
                    listBox_main.Items.Add("Abfahrtsort: " + comboBox_von.Text);
                    listBox_main.Items.Add("Ankunftsort: " + comboBox_nach.Text);
                    listBox_main.Items.Add("Abfahrtszeit: " + connection.From.Departure + "\tAnkunftszeit: " + connection.To.Arrival + "\tLinie: " + connection.To.Platform);
                    listBox_main.Items.Add("");

                }
            }
            else
            {
                MessageBox.Show("Kein Ab- oder Ankunftsort angegeben!");
            }
            

        }

        private void comboBox_von_DropDown(object sender, EventArgs e)
        {
            //von wird definiert als Text aus der comboBox_von
            var von = Convert.ToString(comboBox_von.Text);
            transport.GetStations(von);
            Stations stations = transport.GetStations(von);
            comboBox_von.Items.Clear();
            foreach (Station station in stations.StationList)
            {
                //Fügt in der comboBox Stationsnamen hinzu
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
            /*Wenn Suche nicht nichts drin ist dann soll Programm ausführen
            wenn das nicht so ist dann MessageBox anzeigen*/
            if (comboBox_abfahrtsplan.Text != "")
            {
                List<StationBoard> StationBoardList = transport.GetStationBoard(comboBox_abfahrtsplan.Text, string.Empty).Entries;

                listBox_abfahrtsplan.Items.Clear();

                foreach (var s in StationBoardList)
                {
                    if (s.Name != null)
                    {
                        listBox_abfahrtsplan.Items.Add("Von: " + comboBox_abfahrtsplan.Text + "\tNach: " + s.To + "\t\tNummer: " + s.Number);
                        listBox_abfahrtsplan.Items.Add("");
                    }
                }
            }
            else
            {
                MessageBox.Show("Kein Abfahrtsort angegeben!");
            }
        }

        private void button_stationsuchen_Click(object sender, EventArgs e)
        {
            /*Wenn Suche nicht nichts drin ist dann soll Programm ausführen
             wenn das nicht so ist dann MessageBox anzeigen*/
            if (comboBox_stationsuchen.Text != "")
            {
                double xcoordinate;
                //xcoordinate = station.Coordinate.XCoordinate;
                double ycoordinate;
                //ycoordinate = station.Coordinate.YCoordinate;
                string url;
                url = "https://www.google.ch/maps/place/" + comboBox_stationsuchen.Text;
                webBrowser_station.Navigate(url);
            }
            else
            {
                MessageBox.Show("Kein Stationsort angegeben!");
            }
        }

        private void comboBox_stationsuchen_DropDown(object sender, EventArgs e)
        {
            var stationsort = Convert.ToString(comboBox_stationsuchen.Text);
            transport.GetStations(stationsort);
            Stations stations = transport.GetStations(stationsort);
            comboBox_stationsuchen.Items.Clear();
            foreach (Station station in stations.StationList)
            {
                comboBox_stationsuchen.Items.Add(station.Name);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Anwendungsfenster kann man nicht manuell mit Muaszeiger vergrössern und verkleinern
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
        }

        private void button_web1_Click(object sender, EventArgs e)
        {
            //Öffnet Browser mit dieser URL
            System.Diagnostics.Process.Start("https://news.sbb.ch/");
        }

        private void button_web2_Click(object sender, EventArgs e)
        {
            //Öffnet Browser mit dieser URL
            System.Diagnostics.Process.Start("https://news.sbb.ch/");
        }

        private void button_web3_Click(object sender, EventArgs e)
        {
            //Öffnet Browser mit dieser URL
            System.Diagnostics.Process.Start("https://news.sbb.ch/");
        }

        private void button_resultatmail1_Click(object sender, EventArgs e)
        {

            


            //System.Diagnostics.Process.Start("mailto:mail@domain.com");
            //listBox_main.

        }

        private void comboBox_von_KeyPress(object sender, KeyPressEventArgs e)
        {
            comboBox_von.DroppedDown = comboBox_von.DroppedDown;
        }
    }
}

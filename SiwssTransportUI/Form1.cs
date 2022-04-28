using SwissTransport.Core;
using SwissTransport.Models;
namespace SiwssTransportUI;

public partial class MainForm : Form
{
    private readonly ITransport Datenbank;
    public MainForm()
    {
        InitializeComponent();
        this.Datenbank = new Transport();

    }

    private void btnSuchen_Click(object sender, EventArgs e)
    {
       
        string Startstation = cmbBoxStart.Text;
        string Endstation = cmbBoxEnde.Text;
        var Verbindungen = Datenbank.GetConnections(Startstation, Endstation);
        var Abfahrtplan = Datenbank.GetStationBoard(cmbBoxStart.Text, "1");
        listbox4Verbindungen.Items.Clear();
        listBoxAbfahrt.Items.Clear();
        if (Startstation == Endstation)
        {
            MessageBox.Show("Geben sie unterschiedliche Stationen an");
        }
        else if(Startstation=="" ||Endstation=="")
        {
            MessageBox.Show("Geben sie Stationen ein");
        }
        else
        {
            listbox4Verbindungen.Items.Add("Abfahrt:\t\t AbfahrtsOrt:\t\tAnkunft:\t\tVerspätung:\t\t Station:");
            foreach (var Connection in Verbindungen.ConnectionList)
            {
                if (Connection.From.Delay == 0)
                {
                    listbox4Verbindungen.Items.Add(String.Format("{0:HH:mm}", Connection.From.Departure)
                    + "\t\t" + Connection.From.Platform + "\t\t\t"
                    + String.Format("{0:HH:mm}", Connection.To.Arrival)
                    + "\t\t" + "-"
                    + "\t\t\t"
                    + Connection.From.Station.Name);
                }

                else if(Connection.From.Delay == null)
                {
                    listbox4Verbindungen.Items.Add(String.Format("{0:HH:mm}", Connection.From.Departure)
                    + "\t\t" + Connection.From.Platform + "\t\t\t"
                    + String.Format("{0:HH:mm}", Connection.To.Arrival)
                    + "\t\t" + "-"
                    + "\t\t\t"
                    + Connection.From.Station.Name);
                }
                else
                {
                    listbox4Verbindungen.Items.Add(String.Format("{0:HH:mm}", Connection.From.Departure)
                    + "\t\t" + Connection.From.Platform + "\t\t\t"
                    + String.Format("{0:HH:mm}", Connection.To.Arrival)
                    + "\t\t" + Connection.From.Delay + "min" + "\t\t\t"
                    + Connection.From.Station.Name);
                }
                

            }
                listBoxAbfahrt.Items.Add("Abfahrt:\t\tNummer:\t\tEndstation:");
                int maximum = 0;
                foreach (var Station in Abfahrtplan.Entries)
                {
                    maximum++;
                    listBoxAbfahrt.Items.Add(string.Format("{0:HH:mm}",Station.Stop.Departure)+ "\t\t"  +Station.Category + Station.Number+"\t\t"+ Station.To);
                    if (maximum >= 10) break;
                    
                }
        }


    }
    private void cmbBoxStart_KeyUp(object sender, KeyEventArgs e)
    {
        if(e.KeyData== Keys.Enter)
        {
            cmbBoxStart.Items.Clear();
            var stationbekommen = Datenbank.GetStations(cmbBoxStart.Text);

            List<string> neueliste = new List<string>();

            foreach(var inliste in stationbekommen.StationList)
            {
                neueliste.Add(inliste.Name.ToString());
            }
            foreach(var liste2 in neueliste)
            {
                cmbBoxStart.Items.Add(liste2.ToString());
            }
        }
        //das gleiche wie bei den connetcition

        //combobox auslesen 
        //getstation mit inhalt der combobox
        //lere liste
        //foreach(für jede station in der stationsliste)
        //immer den namen auf die neue liste aufschreiben
        //foreach jeder 10 stationsnamen jeder name der combobox als item hinzufügen
    }

    private void cmbBoxEnde_KeyUp(object sender, KeyEventArgs e)
    {
        
        if (e.KeyData == Keys.Enter)
        {
            cmbBoxEnde.Items.Clear();
            var stationbekommen = Datenbank.GetStations(cmbBoxEnde.Text);

            List<string> neueliste = new List<string>();

            foreach (var inliste in stationbekommen.StationList)
            {
                neueliste.Add(inliste.Name.ToString());
            }
            foreach (var liste2 in neueliste)
            {
                cmbBoxEnde.Items.Add(liste2.ToString());
            }
            //doppelt gebindet beheben
        }
    }

    
}
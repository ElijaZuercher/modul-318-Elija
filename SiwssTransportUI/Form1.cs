using SwissTransport.Core;
using SwissTransport.Models;
namespace SiwssTransportUI;

public partial class MainForm : Form
{
    private readonly ITransport Datenbank;
    public MainForm()
    {
        InitializeComponent();
        //Es wird ein Objekt der Klasse Transport erstellt, damit ich auf die verschiedene
        //Methoden zugreiffen kann wie zum Beispiel GetConnections
        this.Datenbank = new Transport();

    }
    private void btnSuchen_Click(object sender, EventArgs e)
    {
        
        string Startstation = cmbBoxStart.Text;
        string Endstation = cmbBoxEnde.Text;
        listbox4Verbindungen.Items.Clear();
        listBoxAbfahrt.Items.Clear();
        //Hier wird kontrolliert ob die Eingaben korrekt sind
        //Falls die Eingabe unvolständig oder falsch ist, wird eine Messagebox ausgegeben mit dem Probelem
        if (Startstation == Endstation)
        {
            MessageBox.Show("Geben sie unterschiedliche Stationen an");
        }
        else if(Startstation=="" ||Endstation=="")
        {
            MessageBox.Show("Geben sie Stationen ein");
        }
        else if(Startstation!="" && Endstation!="")
        {
            //Es wird die Methdode GetConnection aufgerufen und die Eingaben der Start und Endstation eingelesen
            var Verbindungen = Datenbank.GetConnections(Startstation, Endstation);
            var Abfahrtplan = Datenbank.GetStationBoard(cmbBoxStart.Text, "1");

            listbox4Verbindungen.Items.Add("Abfahrt:\t\tAbfahrtsOrt:\t\tAnkunft:\t\tVerspätung:\t\tStation:");
            //Es wird eine Verbindung gesucht zwischen Starteingabe und Endeingabe
            foreach (var Connection in Verbindungen.ConnectionList)
            {
                //Wenn es keine Verspätung gibt, wird nur das Zeichen - ausgegeben, falls es eine gibt gibt es diese an und "min" als Zeit angabe
                if (Connection.From.Delay == 0)
                {
                    listbox4Verbindungen.Items.Add(String.Format("{0:HH:mm}", Connection.From.Departure)+"\t\t" 
                    +Connection.From.Platform +"\t\t\t"
                    +String.Format("{0:HH:mm}", Connection.To.Arrival)+"\t\t" 
                    +"-"+"\t\t\t"
                    +Connection.From.Station.Name);
                }
                else if(Connection.From.Delay == null)
                {
                    listbox4Verbindungen.Items.Add(String.Format("{0:HH:mm}", Connection.From.Departure)+"\t\t" 
                    + Connection.From.Platform +"\t\t\t"
                    + String.Format("{0:HH:mm}", Connection.To.Arrival)+"\t\t" 
                    + "-"+"\t\t\t"
                    + Connection.From.Station.Name);
                }
                else
                {
                //Die Abfahrtszeiten, AbfahrtsOrt, Ankunft, Verspätung, Station werden in die listbox abgefüllt 
                    listbox4Verbindungen.Items.Add(String.Format("{0:HH:mm}", Connection.From.Departure)+"\t\t" 
                    + Connection.From.Platform +"\t\t\t"
                    + String.Format("{0:HH:mm}", Connection.To.Arrival)+"\t\t" 
                    + Connection.From.Delay + "min" +"\t\t\t"
                    + Connection.From.Station.Name);
                }
            }
                //Anzeigetafel wird mit Abfahrtzeit, Nummer und Endstation abgefüllt
                listBoxAbfahrt.Items.Add("Abfahrt:\t\tNummer:\t\tEndstation:");
                //Die maximum variable habe ich verwendet um 10 Abfahrten anzuzeigen, damit es übersichtlicher ist
                int maximum = 0;
                //Mit dem Wort Entries kann man sich anzeigen lassen, welche Buss/Züge an dieser Station fahren
                foreach (var Station in Abfahrtplan.Entries)
                {
                    maximum++;
                    listBoxAbfahrt.Items.Add(string.Format("{0:HH:mm}",Station.Stop.Departure)+"\t\t"  
                    +Station.Category 
                    +Station.Number+"\t\t"
                    +Station.To);
                    if (maximum == 10) break;
                }
        }
    }
    private void cmbBoxStart_KeyUp(object sender, KeyEventArgs tastenlesen)
    {
        //Es wird geschaut ob die Taste, die man gedrückt hat die Entertaste ist ansonsten wird es nicht ausgeführt
        //Hier wird Autocomplete gemacht und geschaut was in der Startstaionbox eingegeben wurde
        //Es werden alle Namen die änlich sind wie die Startstation genommen und werden in neueliste geschrieben
        //Dann werden alle diese Namen von der Liste: neueListe in die StartCombobox abgefüllt.
        if (tastenlesen.KeyData== Keys.Enter)
        {
            cmbBoxStart.Items.Clear();
            var stationbekommen = Datenbank.GetStations(cmbBoxStart.Text);
            List<string> neueliste = new List<string>();

            foreach(var inliste in stationbekommen.StationList)
            {
                neueliste.Add(inliste.Name.ToString());
            }

            foreach(var neuelisteAusgabe in neueliste)
            {
                cmbBoxStart.Items.Add(neuelisteAusgabe.ToString());
            }
            cmbBoxStart.DroppedDown = true;
        }  
    }

    private void cmbBoxEnde_KeyUp(object sender, KeyEventArgs tastenlesen)
    {
        //Hier wird Autocomplete gemacht dieses mal mit der Endstation gleiches Prinzip einfach mit der EndstationComboBox
        if (tastenlesen.KeyData == Keys.Enter)
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
            cmbBoxEnde.DroppedDown = true;
        }
    }
    //Die Uhrzeit wird angegeben und laufend aktualisiert
    private void timer1_Tick(object sender, EventArgs e)
    {
    //Mit ("HH:mm") werden Stunden und Minuten ausgegeben
        lblUhrzeit.Text=DateTime.Now.ToString("HH:mm");
    }
}
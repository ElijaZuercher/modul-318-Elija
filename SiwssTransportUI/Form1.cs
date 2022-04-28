using SwissTransport.Core;
using SwissTransport.Models;
namespace SiwssTransportUI;

public partial class MainForm : Form
{
    private readonly ITransport Datenbank;
    public MainForm()
    {
        InitializeComponent();
        this.Datenbank= new Transport();

    }

    private void btnSuchen_Click(object sender, EventArgs e)
    {
     
        string Startstation = cmbBoxStart.Text;
        string Endstation = cmbBoxEnde.Text;
        var Verbindungen = Datenbank.GetConnections(Startstation, Endstation);
        var Abfahrtplan = Datenbank.GetConnections(Startstation, Endstation);
        
        if (Startstation == Endstation)
        {
            MessageBox.Show("Geben sie unterschiedliche Stationen an");
        }
        else
        {
            listbox4Verbindungen.Items.Add("Abfahrt:\t\t AbfahrtsOrt:\t\tAnkunft:\t\tVerspätung:\t\t Station:");
            foreach (var Connection in Verbindungen.ConnectionList)
            {
              if(Connection.From.Delay.HasValue)
                {
                    listbox4Verbindungen.Items.Add(String.Format("{0:HH:mm}", Connection.From.Departure)
                 + "\t\t" + Connection.From.Platform + "\t\t\t"
                 + String.Format("{0:HH:mm}", Connection.To.Arrival)
                 + "\t\t" + Connection.From.Delay + "min" + "\t\t\t"
                 + Connection.From.Station.Name);
                }
                else
                {
                    listbox4Verbindungen.Items.Add(String.Format("{0:HH:mm}", Connection.From.Departure)
                 + "\t\t" + Connection.From.Platform + "\t\t\t"
                 + String.Format("{0:HH:mm}", Connection.To.Arrival)
                 + "\t\t" 
                 +" " 
                 + "min" + "\t\t\t" 
                 + Connection.From.Station.Name);
                }
                
            }
            listBoxAbfahrt.Items.Add("Abfahrt:\t\t Nummer:\t\t Station:");
            foreach (var Station in Abfahrtplan.ConnectionList)
            {
                listBoxAbfahrt.Items.Add(String.Format("{0:HH:mm}", Station.From.Departure)+ Station.From.Station.Score);
            }
            
        }
    }

    
}


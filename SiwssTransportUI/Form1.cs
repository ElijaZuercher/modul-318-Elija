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
        
        if (Startstation == Endstation)
        {
            MessageBox.Show("Geben sie unterschiedliche Stationen an");
        }
        else
        {
            listbox4Verbindungen.Items.Add("Abfahrt:\t\t Station:\t\t Ankunft:");
            foreach (var Connection in Verbindungen.ConnectionList)
            {
                listbox4Verbindungen.Items.Add(String.Format("{0:HH:mm}", Connection.From.Departure)+ "\t\t" +Connection.From.Station.Name + "\t\t" + String.Format("{0:HH:mm}", Connection.To.Arrival));
            }
            
            
        }
    }

    
}


namespace SiwssTransportUI;
public partial class MainForm : Form
{
    public MainForm()
    {
        InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {

    }

    private void Form1_Load(object sender, EventArgs e)
    {

    }

    private void placeholderTextBox1_TextChanged(object sender, EventArgs e)
    {

    }

    private void placeholderBoxBis_TextChanged(object sender, EventArgs e)
    {

    }

    private void label1_Click(object sender, EventArgs e)
    {

    }

    private void label2_Click(object sender, EventArgs e)
    {

    }

    private void btnSuchen_Click(object sender, EventArgs e)
    {
        string Startstation = cmbBoxStart.Text;
        string Endstation = cmbBoxEnde.Text;
        if (Startstation == Endstation)
        {
            MessageBox.Show("Geben sie unterschiedliche Stationen an");
        }
        else
        {
            listbox4Verbindungen.Items.Add(Endstation);
        }
    }
}


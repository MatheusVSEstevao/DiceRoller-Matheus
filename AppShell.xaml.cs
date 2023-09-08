

namespace DiceRoller;

public partial class MainPage : ContentPage
{
    private Random rnd = new Random();

    public MainPage()
    {
        InitializeComponent();
    }


    private void GerarNumeroAleatorio_Click(object sender, EventArgs e)
    {
        
        int numeroAleatorio = rnd.Next(1, 10);


        NumeroAleatorioLabel.Text = numeroAleatorio.ToString();
    }



   
}


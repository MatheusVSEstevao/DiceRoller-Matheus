using System.Collections.ObjectModel;


namespace DiceRoller;

public partial class MainPage : ContentPage
{
    private Random rnd = new Random();




    public MainPage()
    {
        InitializeComponent();

        Lados.SelectedIndexChanged += Picker_SelectedIndexChanged;

    }

    public void Picker_SelectedIndexChanged(object sender, EventArgs e)
    {
      
        string valorSelecionado = (string)Lados.SelectedItem;

       
      
    }


    private void GerarNumeroAleatorio_Click(object sender, EventArgs e)
    {
        string valorSelecionado = (string)Lados.SelectedItem;

        if (int.TryParse(valorSelecionado, out int maiorPossibilidade))
        {

            int numeroAleatorio = rnd.Next(1, maiorPossibilidade + 1);

            NumeroAleatorioLabel.Text = numeroAleatorio.ToString();
        }
        else
        {
           
            NumeroAleatorioLabel.Text = "Selecione a quantidade de lados.";
        }
    }





}


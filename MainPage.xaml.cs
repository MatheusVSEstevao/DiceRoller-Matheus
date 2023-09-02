namespace DiceRoller;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

	private void OnCounterClicked(object sender, EventArgs e)
	{
		count++;

		if (count == 1)
			CounterBtn.Text = $"Clicked {count} time";
		else
			CounterBtn.Text = $"Clicked {count} times";

		SemanticScreenReader.Announce(CounterBtn.Text);
	}


	void OnPickerSelectedIndexChanged(object sender, EventArgs e)
	{

		Label numLados = new Label();
		//  numLados.SetBinding(Label.TextProperty, new Binding("SelectedItem", source: picker));

		var qtLados = new List<string>();
		qtLados.Add("4");
		qtLados.Add("6");
		qtLados.Add("10");
		qtLados.Add("20");
		qtLados.Add("100");


	}

            
}

 


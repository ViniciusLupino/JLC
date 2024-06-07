namespace LoginApp.Pages;

public partial class Avaliacoes : ContentPage
{
	public Avaliacoes()
	{
		InitializeComponent();
	}

    private async void Inicio_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new HomePage());
    }

    private async void Locais_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Sedes());
    }

    private async void Avaliacoes1_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Avaliacoes());
    }

    private async void Info_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Sobre());
    }

    private async void Chat_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Contatos());
    }
}
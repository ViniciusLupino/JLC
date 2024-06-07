namespace LoginApp.Pages;

public partial class Sedes : TabbedPage
{
	public Sedes()
	{
		InitializeComponent();
	}

    private async void Inicio_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new HomePage());
    }

    private async void Avaliacoes_Clicked(object sender, EventArgs e)
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

    private async void Servicos_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Servicos());
    }

    ////////////////////////////////////////////////////////////////////

    private async void Inicio1_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new HomePage());
    }

    private async void Avaliacoes1_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Avaliacoes());
    }

    private async void Info1_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Sobre());
    }

    private async void Chat1_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Contatos());
    }

    private async void Servicos1_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Servicos());
    }
}
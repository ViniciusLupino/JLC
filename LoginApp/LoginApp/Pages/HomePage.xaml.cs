using LoginApp.Model;

namespace LoginApp.Pages;

public partial class HomePage : ContentPage
{
    private Usuario _usuario;
    public HomePage()
    {
        InitializeComponent();
        _usuario = App.Usuario;
    }

    private async void Login_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new ContaPage());
    }

    private async void Servicos_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Servicos());
    }

    private async void Locais_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Sedes());
    }

    private async void Avaliacoes_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Avaliacoes());
    }

    private async void Chat_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Contatos());
    }

    private async void Info_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Sobre());
    }
}
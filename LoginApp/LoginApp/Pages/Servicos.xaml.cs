namespace LoginApp.Pages;

public partial class Servicos : TabbedPage
{
    public Servicos()
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

    private async void btnEncomenda_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Contatos());
    }

    ////////////////////////////////////////////////////////////////

    private async void Inicio1_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new HomePage());
    }

    private async void Locais1_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Sedes());
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

    ////////////////////////////////////////////////////////////////

    private async void Inicio2_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new HomePage());
    }

    private async void Locais2_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Sedes());
    }

    private async void Avaliacoes2_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Avaliacoes());
    }

    private async void Info2_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Sobre());
    }

    private async void Chat2_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Contatos());
    }

    ////////////////////////////////////////////////////////////////

    private async void Inicio3_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new HomePage());
    }

    private async void Locais3_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Sedes());
    }

    private async void Avaliacoes3_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Avaliacoes());
    }

    private async void Info3_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Sobre());
    }

    private async void Chat3_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Contatos());
    }

    private async void btnEncomenda1_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Contatos());
    }

    private async void btnEncomenda2_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Contatos());
    }
}
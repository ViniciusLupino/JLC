namespace LoginApp.Pages;

public partial class Contatos : ContentPage
{
    public Contatos()
    {
        InitializeComponent();
    }

    private void btnTel_Clicked(object sender, EventArgs e)
    {
        try
        {
            string phoneNumber = "+55 14 99157-5607"; 
            PhoneDialer.Open(phoneNumber);
        }
        catch (ArgumentNullException)
        {
            // N�mero de telefone inv�lido
            DisplayAlert("Erro", "N�mero de telefone inv�lido.", "OK");
        }
        catch (FeatureNotSupportedException)
        {
            // Liga��o telef�nica n�o suportada neste dispositivo
            DisplayAlert("Erro", "Liga��o telef�nica n�o suportada neste dispositivo.", "OK");
        }
        catch (Exception ex)
        {
            // Outro erro ocorreu
            DisplayAlert("Erro", $"Erro desconhecido: {ex.Message}", "OK");
        }
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
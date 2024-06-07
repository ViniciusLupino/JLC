using LoginApp.Model;

namespace LoginApp.Pages;

public partial class ContaPage : ContentPage
{
	private Usuario _usuario;
	public ContaPage()
	{
		InitializeComponent();

		_usuario = App.Usuario;

		this.BindingContext = _usuario;
	}

    private async void btnSalvar_Clicked(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(_usuario.Email) && string.IsNullOrEmpty(_usuario.Senha) && string.IsNullOrEmpty(_usuario.Nome))
        {
            await DisplayAlert("Erro", "Preencha todas as informa��es", "Fechar");
            return;
        }
        var Data = DateOnly.Parse(_usuario.Data);
        var cadastro = await App.BancoDados.UsuarioDataTable.SalvarUsuario(_usuario);

        if (cadastro > 0)
        {
            await DisplayAlert("Sucesso", "Usu�rio cadastrado com sucesso", "Fechar");
            await Navigation.PopAsync();
        }
    }

    private async void Voltar_Clicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }

    private async void btnVoltar_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new HomePage());
    }
}
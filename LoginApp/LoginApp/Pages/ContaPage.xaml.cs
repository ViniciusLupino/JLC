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
        if (string.IsNullOrEmpty(_usuario.Nome) && string.IsNullOrEmpty(_usuario.Email) && string.IsNullOrEmpty(_usuario.Data) && string.IsNullOrEmpty(_usuario.Endereco) && string.IsNullOrEmpty(_usuario.Fone))
        {
            await Navigation.PopAsync();
        }
        var Data = DateOnly.Parse(_usuario.Data);
        var cadastro = await App.BancoDados.UsuarioDataTable.SalvarUsuario(_usuario);

        if (cadastro > 0)
        {
            await DisplayAlert("Sucesso", "Usuário atualizado com sucesso", "Fechar");
            await Navigation.PopAsync();
        }
    }

    private async void Voltar_Clicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}
namespace recAgenda13Ds2.Views;

public partial class Sobre : ContentPage
{
	public Sobre()
	{
        InitializeComponent();
	}
    private async void Voltar_Sobre_Clicked(object sender, EventArgs e)
    {
        try
        {
            //navigation para voltar com PopAsync
            Navigation.PopAsync();

        }    catch (Exception ex)

        {
            DisplayAlert("Ops", ex.Message, "OK");
        }   
    }
}
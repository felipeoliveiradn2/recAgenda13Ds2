namespace recAgenda13Ds2.Views;

public partial class HospedagemContratada : ContentPage
{
	public HospedagemContratada()
	{
		InitializeComponent();
	}

	private void Button_Clicked(object sender, EventArgs e)
	{
		try
		{
			//navigation para voltar com PopAsync, pode ser usado em sobre
			Navigation.PopAsync();

		} catch (Exception ex)

		{
			DisplayAlert("Ops", ex.Message, "OK");
		}
	}
		
}
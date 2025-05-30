namespace recAgenda13Ds2.Views;

public partial class ContratacaoHospedagem : ContentPage
{
	//declaracao de propriedades do app
	App PropriedadesApp;
	public ContratacaoHospedagem()
	{
		InitializeComponent();
		//irá permitir acessar o aplicativo em execução, ou seja o App.xaml onde estão os quartos

		PropriedadesApp = (App)Application.Current;

		//agora especificando com o pck "picker" do quarto, usando items source para cada item da array
		//há um binding no xaml para conseguir aparecer corretamente os quartos, no picker "pck_quarto" {Binding Descricao}

		pck_quarto.ItemsSource = PropriedadesApp.lista_quartos;

		//definição da data minima como a data atual (hoje)
		dtpck_checking.MinimumDate = DateTime.Now;

		//definição de datas para poder fazer o checking no máximo em um mês
		dtpck_checking.MaximumDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month + 1, DateTime.Now.Day);

		//agora para checkout com a mesma logica, porém com data minima sendo a data de checkin
		dtpck_checkout.MinimumDate = dtpck_checking.Date.AddDays(1);

		dtpck_checkout.MaximumDate = dtpck_checking.Date.AddMonths(6);

	}
	private void Button_Clicked(object sender, EventArgs e)
	{
		try
		{	//navigation pushAsync vai para a pagina hospedagem contratada
			Navigation.PushAsync(new HospedagemContratada());

		}catch (Exception ex)
		{
			DisplayAlert("Ops", ex.Message, "OK");
		}
	}

		//botao Sobre

		private async void SobreClicked(object sender, EventArgs e)
		{
			try
			{
				Navigation.PushAsync(new Sobre());
			}
			catch (Exception ex)
			{
				await DisplayAlert("Ops", ex.Message, "OK");
        }
		}     

    private void dtpck_checking_DateSelected(object sender, DateChangedEventArgs e)
    {
		DatePicker elemento = sender as DatePicker;

		DateTime data_selecionada_checkin = elemento.Date;
		//logica para ser selecionada a data mínima a partir do dia do checkin, nao checkout antes
		dtpck_checkout.MinimumDate = data_selecionada_checkin.AddDays(1);
		dtpck_checkout.MaximumDate = data_selecionada_checkin.AddMonths(6);
    }
}
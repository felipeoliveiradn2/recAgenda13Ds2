using recAgenda13Ds2.Models;

namespace recAgenda13Ds2
{
    public partial class App : Application
    {
        //array com lista de quartos
        public List<Quarto> lista_quartos = new List<Quarto>
        {
            new Quarto()
            {
                Descricao = "Suite super luxo",
                ValorDiariaAdulto= 110.00,
                ValorDiariaCrianca = 55.00

            },
            new Quarto()
            {
                Descricao = "Suite luxo",
                ValorDiariaAdulto= 80.00,
                ValorDiariaCrianca = 40.00

            },
            new Quarto()
            {
                Descricao = "Suite Single",
                ValorDiariaAdulto= 50.00,
                ValorDiariaCrianca = 25.00

            },
            new Quarto()
            {
                Descricao = "Suite da crise",
                ValorDiariaAdulto= 25.00,
                ValorDiariaCrianca = 12.50
            }
        };
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new Views.ContratacaoHospedagem());
        }
        protected override Window CreateWindow(IActivationState? activationState)
        {
            var window = base.CreateWindow(activationState);

            window.Width = 400;
            window.Height = 600;
            return window;

        }
    }
}

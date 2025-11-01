namespace MauiAppHotel
{
    public partial class App : Application
    {
        public App()
        {
#if !AUTO_GENERATED_INITIALIZECOMPONENT
            // Remova ou comente esta linha se o método InitializeComponent gerado automaticamente já existe.
            // Caso contrário, mantenha apenas uma definição de InitializeComponent.
           InitializeComponent();
#endif

            MainPage = new NavigationPage(new Views.ContratacaoHospedagem());
        }

        // Remova este método se houver um método InitializeComponent gerado automaticamente pelo XAML.
        // Caso contrário, mantenha apenas uma definição deste método.
        // private void InitializeComponent()
        // {
        //     throw new NotImplementedException();
        // }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            var window = base.CreateWindow(activationState);

            window.Width = 400;
            window.Height = 600;

            return window;
        }
    }
}
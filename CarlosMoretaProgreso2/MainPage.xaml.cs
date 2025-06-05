namespace CarlosMoretaProgreso2
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void IraChistes_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ChistesPage());
        }

        private void IraInformacion_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new InformacionPage());
        }
    }

}

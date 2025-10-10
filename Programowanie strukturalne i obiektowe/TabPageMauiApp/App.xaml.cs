namespace TabPageMauiApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            TabbedPage tabbedPage = new TabbedPage();
            tabbedPage.BarTextColor = Colors.Red;
            tabbedPage.SelectedTabColor = Colors.Blue;
            tabbedPage.BarBackgroundColor = Colors.Yellow;
            tabbedPage.Children.Add(new MainPage() { Title = "Strona główna"});
            tabbedPage.Children.Add(new AboutPage());
            tabbedPage.Children.Add(new AnotherPage());

            tabbedPage.Children.Add(new NavigationPage(new AnotherPage()));

            /*return new Window(tabbedPage)
            {
                TitleBar = new TitleBar()
                {
                    BackgroundColor = Colors.Red
                }
            };*/

            return new Window(tabbedPage);
        }


    }
}
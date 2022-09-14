namespace MauiApp1;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();

        MainPage = new MainPage();
        // Replace previous line with next one to check how NewPage1 should look.
        // MainPage = new NewPage1();
    }
}



namespace FitnessTest;

public partial class MainPage : ContentPage
{


    public MainPage()
    {
        InitializeComponent();
    }

    public async void CreateData(object sender, EventArgs e)
    {
        ImageButton button = (ImageButton)sender;
        int id = int.Parse(button.AutomationId);
        
            await Navigation.PushAsync(new MachineView(id));
        


    }

}


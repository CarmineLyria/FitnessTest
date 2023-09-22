

namespace FitnessTest;

public partial class MainPage : ContentPage
{

    //notes for later
    //build a json full of machine objects, then bind the data in the xaml
    //basically, when the button is pressed, retrieve a value from the stored object by calling the CreateData method
    //this will take the data-bound object at an index and build the page off of it
    //alternatively, pass an int to a switch, then use that int as an argument to call a build method that constructs the page based on that
    //must create an extension of the imagebutton class for that though

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


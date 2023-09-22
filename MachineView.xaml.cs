using System.Text.Json;
using System.IO;
using Android.Content.Res;

namespace FitnessTest;

public partial class MachineView : ContentPage
{

    Machine machine;
    public MachineView(int id)
    {
        List<Machine> jsonData;
        InitializeComponent();
        AssetManager assets = Android.App.Application.Context.Assets;
        string filename = "utazukin.json";
        string jsonContent = "";
        try
        {
            // Open a stream to the file in the Raw directory
            using (StreamReader reader = new StreamReader(assets.Open(filename)))
            {
                jsonContent = reader.ReadToEnd();
            }

            // Now, you can deserialize the JSON content
            jsonData = JsonSerializer.Deserialize<List<Machine>>(jsonContent);
            machine = jsonData.FirstOrDefault(m => m.id == id);
            Console.WriteLine("If you got this far, congrats! it works.");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        /*switch (id)
        {
            case 1:
                contentImage.Source = "abdominalcrunch.jpg";
                contentLabel.Text = "Abdominal Crunch";

                break;

            case 2:
                contentImage.Source = "armcurl.jpg";
                contentLabel.Text = "Arm Curl";
                break;

            case 3:
                contentImage.Source = "chestpress.jpg";
                contentLabel.Text = "Chest Press";
                break;

            case 4:
                contentImage.Source = "dumbbell.jpg";
                contentLabel.Text = "Dumbbell";
                break;

            case 5:
                contentImage.Source = "inclineseat.jpg";
                contentLabel.Text = "Incline Seat";
                break;

            case 6:
                contentImage.Source = "innerouterthigh.jpg";
                contentLabel.Text = "Inner Outer Thigh";
                break;

            case 7:
                contentImage.Source = "latpulldown.jpg";
                contentLabel.Text = "Lat Pulldown";
                break;

            case 8:
                contentImage.Source = "legcurl.jpg";
                contentLabel.Text = "Leg Curl";
                break;

            case 9:
                contentImage.Source = "legextension.jpg";
                contentLabel.Text = "Leg Extension";
                break;

            case 10:
                contentImage.Source = "legpress.jpg";
                contentLabel.Text = "Leg Press";
                break;

            case 11:
                contentImage.Source = "lowbakextension.jpg";
                contentLabel.Text = "Low Back Extension";
                break;

            case 12:
                contentImage.Source = "resistanceband.jpg";
                contentLabel.Text = "Resistance Band";
                break;

            case 13:
                contentImage.Source = "rotarytorso.jpg";
                contentLabel.Text = "Rotary Torso";
                break;

            case 14:
                contentImage.Source = "seatedpushdown.jpg";
                contentLabel.Text = "Seated Push Down";
                break;

            case 15:
                contentImage.Source = "seatedrow.jpg";
                contentLabel.Text = "Seated Row";
                break;

            case 16:
                contentImage.Source = "shoulderpress.jpg";
                contentLabel.Text = "Shoulder Press";
                break;
        }*/


        /*string holder;
        try
        {

            string content = File.ReadAllText("utazukin.json");
            jsonData = JsonSerializer.Deserialize<List<Machine>>(content);
            machine = jsonData.FirstOrDefault(m => m.id == id);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }



        if (machine != null)
        {
            this.BindingContext = machine;
        }*/

    }

}
using System.Text.Json;
using System.IO;
using Android.Content.Res;

namespace FitnessTest;

public partial class MachineView : ContentPage
{
    List<Machine> jsonData;
    string filename = "utazukin.json";
    string jsonContent = "";
    Machine machine;
    AssetManager assets = Android.App.Application.Context.Assets;

    public MachineView(int id)
    {
        InitializeComponent();

        try
        {
            // Get the full path to the JSON file in your project directory
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, filename);

            if (File.Exists(filePath))
            {
                // Read the JSON content from the file
                jsonContent = File.ReadAllText(filePath);
            }
            else
            {
                Console.WriteLine($"File not found: {filePath}");
            }

            Console.WriteLine(jsonContent);
            jsonData = JsonSerializer.Deserialize<List<Machine>>(jsonContent);
            machine = jsonData.FirstOrDefault(m => m.id == id);
            Console.WriteLine("If you got this far, congrats! it works.");
        }
        catch (JsonException ex)
        {
            Console.WriteLine("JSON Deserialization Error: " + ex.Message);
            Console.WriteLine("JSON Path: " + ex.Path);
            Console.WriteLine("Line Number: " + ex.LineNumber);
            Console.WriteLine("Byte Position in Line: " + ex.BytePositionInLine);
            Console.WriteLine(ex.StackTrace);
        }

        if (machine != null)
        {
            this.BindingContext = machine;
        }

        try
        {
            ExercisesList.ItemsSource = machine.data;
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
        }
    }

    public void AddValue(object sender, EventArgs e)
    {
        MachineData newData = new MachineData();

        try
        {
            newData.Weight = int.Parse(weightPicker.SelectedItem.ToString());
            newData.Repetitions = int.Parse(repsEntry.Text);
            newData.DatePerformed = datepicker.Date.ToShortDateString();
            machine.data.Add(newData);
            try
            {
                // Serialize the updated jsonData list to a JSON string
                string reserializedData = JsonSerializer.Serialize<List<Machine>>(jsonData);

                // Get the app's data directory
                string appDataDir = Environment.GetFolderPath(Environment.SpecialFolder.Personal);

                // Create the full path to the writable JSON file
                string filePath = Path.Combine(appDataDir, filename);

                // Write the serialized JSON string to the file
                File.WriteAllText(filePath, reserializedData);

            } catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        } catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
        }
        
    }

}
using System.Data;

namespace DiazDanielExamenProgreso2
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnButtonClicked(object sender, EventArgs e)
        {
            string nombre = "Daniel";
            string apellido = "Diaz";
            string folderName = nombre + apellido;
            string folerPath = Path.Combine(FileSystem.AppDataDirectory, folderName);

            if (!Directory.Exists(folerPath))
            {
                Directory.CreateDirectory(folerPath);

            }

            string fileName = folderName + ".txt";
            string filePath = Path.Combine(folerPath, fileName);
            string recargaInfo = "Informacion de la recarga: $100.00\n Fecha: " + DateTime.Now;

            await File.WriteAllLinesAsync(filePath, recargaInfo);
            await DisplayAlert("Exito", "La infomrcion se ha guardado correctamente en " + filePath, "Ok");
        }
    }

}

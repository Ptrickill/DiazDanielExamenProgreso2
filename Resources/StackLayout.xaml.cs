namespace DiazDanielExamenProgreso2.Resources;

public partial class StackLayout : ContentPage
{
	public StackLayout()
	{
		InitializeComponent();
	}

	private async void JBtn_Recargar_Click(object sender, EventArgs e)
	{
		string numero = JTex_NumeroDDiaz.Text;
		string nombre = JTex_Nombre.Text;

		if (string.IsNullOrEmpty(numero) || string.IsNullOrEmpty(nombre))
		{
			await DisplayAlert("Error", "Por favor, ingrese todos los datos.", "OK");
			return;

		}

		if (numero.Length != 10 || !long.TryParse(numero, out_))
		{
			await DisplayAlert("Error", "El numero de telefono debe tener 10 digitos validos", "Ok");
			return;

		}

		string fileName = $"{nombre.Replace(" ","")}.txt";
		string filePath = Path.Combine(FileSystem.AppDataDirectory,fileName);
		File.WriteAllText(filePath, $"Nombre: {nombre}\nNumero: {numero}");
		await DisplayAlert("Recarga Exitosa", "La recarga se realizo correctaente.", "Ok");
		JLbl_ResumenDDiaz.Text = $"La ultima recarga realizada fue:\nNombre:{nombre}\nNumero:{numero}";
		JTex_NumeroDDiaz.Text= string.Empty;
		JTex_Nombre= string.Empty;


	}
}
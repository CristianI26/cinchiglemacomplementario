namespace cinchiglemasus.Vistas;

public partial class Camara : ContentPage
{
	public Camara()
	{
		InitializeComponent();
	}

    private async void btnFto_Clicked(object sender, EventArgs e)
    {
        var foto = await MediaPicker.CapturePhotoAsync();

        if (foto != null)
        {
            var memoriaStream = await foto.OpenReadAsync();
            Imagen.Source = ImageSource.FromStream(() => memoriaStream);
        }
    }

    private async void btnGaleria_Clicked(object sender, EventArgs e)
    {
        var foto = await MediaPicker.PickPhotoAsync();

        if (foto != null)
        {
            var memoriaStream = await foto.OpenReadAsync();
            Imagen.Source = ImageSource.FromStream(() => memoriaStream);
        }

    }
}

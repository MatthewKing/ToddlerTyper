using System.Reflection;

namespace ToddlerTyper;

internal sealed partial class SplashForm : Form
{
    public SplashForm()
    {
        InitializeComponent();
        InitializeLogoImage();
        Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
    }

    private void InitializeLogoImage()
    {
        var assembly = Assembly.GetExecutingAssembly();
        using var stream = assembly.GetManifestResourceStream("ToddlerTyper.Logo.png");
        if (stream is not null)
        {
            uxLogo.BackgroundImage = new Bitmap(stream);
        }
    }

    private void uxStartButton_Click(object sender, EventArgs e)
    {
        DialogResult = DialogResult.OK;
        Close();
    }
}

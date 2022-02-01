namespace ToddlerTyper;

internal sealed partial class ToddlerTyperForm : Form
{
    private const int FontSizeIncrement = 10;
    private const int FontSizeMin = 10;
    private const int FontSizeMax = 250;

    private readonly HotkeyManager _hotkeys;

    public ToddlerTyperForm()
    {
        _hotkeys = new HotkeyManager();
        _hotkeys.SetHandler("Ctrl+Up", () => UpdateFontSize(FontSizeIncrement, FontSizeMin, FontSizeMax));
        _hotkeys.SetHandler("Ctrl+Down", () => UpdateFontSize(-FontSizeIncrement, FontSizeMin, FontSizeMax));

        InitializeComponent();
        Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
    }

    private void ToddlerTyperForm_Load(object sender, EventArgs e)
    {
        uxInfo.Text = $"Toddler Typer v{Application.ProductVersion} - Press ALT+F4 to exit";
    }

    protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
    {
        if (_hotkeys.Handle(keyData))
        {
            return true;
        }

        return base.ProcessCmdKey(ref msg, keyData);
    }

    private void UpdateFontSize(int increment, int min, int max)
    {
        var newSize = Math.Clamp(uxTextBox.Font.Size + increment, min, max);
        if (newSize != uxTextBox.Font.Size)
        {
            using var font = new Font(uxTextBox.Font.FontFamily, newSize);
            uxTextBox.Font = font;
        }
    }
}

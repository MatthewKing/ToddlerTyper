namespace ToddlerTyper;

public class HotkeyManager
{
    private readonly KeysConverter _keysConverter;
    private readonly IDictionary<string, Action> _handlers;

    public HotkeyManager()
    {
        _keysConverter = new KeysConverter();
        _handlers = new Dictionary<string, Action>(StringComparer.OrdinalIgnoreCase);
    }

    public void SetHandler(string hotkey, Action handler)
    {
        _handlers[hotkey] = handler;
    }

    public bool Handle(Keys keyData)
    {
        var hotkey = _keysConverter.ConvertToInvariantString(keyData);

        return Handle(hotkey);
    }

    public bool Handle(string? hotkey)
    {
        if (hotkey != null && _handlers.TryGetValue(hotkey, out var handler))
        {
            handler.Invoke();
            return true;
        }

        return false;
    }
}

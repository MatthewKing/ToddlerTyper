namespace ToddlerTyper;

internal sealed class ToddlerTyperApplicationContext : ApplicationContext
{
    private readonly IList<Form> _forms;

    public ToddlerTyperApplicationContext()
    {
        _forms = new List<Form>();

        LaunchSplashForm();
    }

    private void LaunchSplashForm()
    {
        var splashForm = new SplashForm();
        splashForm.FormClosed += (s, e) =>
        {
            var dialogResult = splashForm.DialogResult;

            splashForm.Dispose();

            if (splashForm.DialogResult is DialogResult.OK)
            {
                LaunchToddlerTyperForms();
            }
            else
            {
                ExitThreadCore();
            }
        };

        splashForm.Show();
    }

    private void LaunchToddlerTyperForms()
    {
        foreach (var screen in Screen.AllScreens)
        {
            var form = new ToddlerTyperForm();
            form.Location = screen.Bounds.Location;
            form.Size = screen.Bounds.Size;
            form.FormClosed += (s, e) => ExitThreadCore();

            form.Show();

            _forms.Add(form);
        }
    }

    protected override void Dispose(bool disposing)
    {
        if (disposing)
        {
            foreach (var form in _forms)
            {
                if (!form.IsDisposed)
                {
                    form.Dispose();
                }
            }
        }

        base.Dispose(disposing);
    }
}


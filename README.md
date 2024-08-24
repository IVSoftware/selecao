It sounds as though you're describing a scenario where multiple forms (like the Expenses form) and the the Main form can be visible and enabled at the same time and the user can interact with any form. This means that, to show any form, you will call `Show(this)` on it to display it as a non-modal dialog. A minimal example (that you can adapt for your app) might look like this.

[![menu item enable tracks form visibility][2]][2]
___
##### Minimal Expenses Form

Since the visibility of theses forms can cycle repeatedly, it's important to intercept the `Close` action (for example, if user clicks the form's [X] box to close it) and convert it to a `Hide` action instead. This is to prevent the default behavior where the form `Handle` disposes when the form closes.

```
public partial class ExpensesForm : Form
{
    public ExpensesForm() => InitializeComponent();
    protected override void OnFormClosing(FormClosingEventArgs e)
    {
        base.OnFormClosing(e);
        switch (e.CloseReason)
        {                
            case CloseReason.UserClosing:
                e.Cancel = true;
                Hide();
                break;
            default:
                break;
        }
    }
}
```
___

##### Main Form Code

Now, as I understand it, you have a menu item under `Selecao` that should track when (for example) the Expenses form visibility changes, and is enabled only when the Expenses form is visible. So, with `m_ExpensesForm` declared as a member of the main form, subscribe to its `VisibleChanged` event so that you can enable/disable controls in the main form as you see fit.

```
public partial class MainForm : Form
{
    public MainForm()
    {
        InitializeComponent();
        expensesToolStripMenuItem.Enabled = false;
        m_ExpensesForm = new ExpensesForm();

        // Track the Expenses form visibility
        m_ExpensesForm.VisibleChanged += (sender, e) =>
        {
            // Menu item is Enabled whenever Expenses form is visible
            expensesToolStripMenuItem.Enabled = m_ExpensesForm.Visible;

            // Our test button is Disabled when the Expenses form is visible.
            buttonShowExpenses.Enabled = !m_ExpensesForm.Visible;
        };
        buttonShowExpenses.Click += (sender, e) =>
        {
            // Passing 'this' keeps the child window on
            // top of the main form in the Z-order.
            m_ExpensesForm.Show(this);
            // Cosmetic positioning
            m_ExpensesForm.Location = new Point(Right + 10, Top);
        };
        // Dispose of the child form Handle only when the app closes.
        Disposed += (sender, e) =>
        {
            m_ExpensesForm.Dispose();
        };
    }
    private ExpensesForm m_ExpensesForm { get; }
}
```


  [1]: https://i.sstatic.net/g4rny5Iz.png
  [2]: https://i.sstatic.net/mL4Ur7pD.png
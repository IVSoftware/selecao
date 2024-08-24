namespace selecao
{
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
}

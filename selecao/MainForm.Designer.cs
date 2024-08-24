namespace selecao
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            propertiesToolStripMenuItem = new ToolStripMenuItem();
            selecaoToolStripMenuItem = new ToolStripMenuItem();
            buttonShowExpenses = new Button();
            expensesToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, propertiesToolStripMenuItem, selecaoToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(478, 33);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(54, 29);
            fileToolStripMenuItem.Text = "File";
            // 
            // propertiesToolStripMenuItem
            // 
            propertiesToolStripMenuItem.Name = "propertiesToolStripMenuItem";
            propertiesToolStripMenuItem.Size = new Size(108, 29);
            propertiesToolStripMenuItem.Text = "Properties";
            // 
            // selecaoToolStripMenuItem
            // 
            selecaoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { expensesToolStripMenuItem });
            selecaoToolStripMenuItem.Name = "selecaoToolStripMenuItem";
            selecaoToolStripMenuItem.Size = new Size(88, 29);
            selecaoToolStripMenuItem.Text = "Selecao";
            // 
            // buttonShowExpenses
            // 
            buttonShowExpenses.Location = new Point(22, 158);
            buttonShowExpenses.Name = "buttonShowExpenses";
            buttonShowExpenses.Size = new Size(288, 34);
            buttonShowExpenses.TabIndex = 1;
            buttonShowExpenses.Text = "Show Expenses Form";
            buttonShowExpenses.UseVisualStyleBackColor = true;
            // 
            // expensesToolStripMenuItem
            // 
            expensesToolStripMenuItem.Name = "expensesToolStripMenuItem";
            expensesToolStripMenuItem.Size = new Size(277, 34);
            expensesToolStripMenuItem.Text = "Expenses Menu Item";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(478, 244);
            Controls.Add(buttonShowExpenses);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Main Form";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem propertiesToolStripMenuItem;
        private ToolStripMenuItem selecaoToolStripMenuItem;
        private Button buttonShowExpenses;
        private ToolStripMenuItem expensesToolStripMenuItem;
    }
}

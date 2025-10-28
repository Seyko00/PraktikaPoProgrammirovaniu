using System.Drawing;
using System.Windows.Forms;

namespace NotepadPlus
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.newFile = new System.Windows.Forms.ToolStripMenuItem();
            this.openFile = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFile = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.newWindow = new System.Windows.Forms.ToolStripMenuItem();
            this.editMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.undo = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.cut = new System.Windows.Forms.ToolStripMenuItem();
            this.copy = new System.Windows.Forms.ToolStripMenuItem();
            this.paste = new System.Windows.Forms.ToolStripMenuItem();
            this.delete = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.selectAll = new System.Windows.Forms.ToolStripMenuItem();
            this.formatMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.fontItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textColorMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.wordWrapItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textColorMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.textColorMenu.Name = "textColorMenu";
            this.textColorMenu.Text = "Цвет текста";
            this.formatMenu.DropDownItems.Add(this.textColorMenu);
            this.viewMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.darkModeItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.about = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();

            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();

            // richTextBox1
            this.richTextBox1.AcceptsTab = true;
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Font = new System.Drawing.Font("Consolas", 10F);
            this.richTextBox1.Location = new System.Drawing.Point(0, 28);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(800, 422);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            this.richTextBox1.WordWrap = false;
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            this.richTextBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.richTextBox1_KeyDown);

            // menuStrip1
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.fileMenu, this.editMenu, this.formatMenu, this.viewMenu, this.helpMenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 1;

            // fileMenu
            this.fileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.newFile, this.openFile, this.saveFile, this.toolStripSeparator1, this.newWindow});
            this.fileMenu.Name = "fileMenu";
            this.fileMenu.Size = new System.Drawing.Size(52, 24);
            this.fileMenu.Text = "Файл";

            this.newFile.ShortcutKeys = Keys.Control | Keys.N;
            this.newFile.Text = "Новый";
            this.newFile.Click += (s, e) => ((Form1)this).NewFile();

            this.openFile.ShortcutKeys = Keys.Control | Keys.O;
            this.openFile.Text = "Открыть...";
            this.openFile.Click += (s, e) => ((Form1)this).OpenFile();

            this.saveFile.ShortcutKeys = Keys.Control | Keys.S;
            this.saveFile.Text = "Сохранить";
            this.saveFile.Click += (s, e) => ((Form1)this).SaveFile();

            this.newWindow.ShortcutKeys = Keys.Control | Keys.Shift | Keys.N;
            this.newWindow.Text = "Новое окно";
            this.newWindow.Click += (s, e) => ((Form1)this).NewWindow();

            // editMenu
            this.editMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.undo, this.toolStripSeparator2, this.cut, this.copy, this.paste, this.delete, this.toolStripSeparator3, this.selectAll});
            this.editMenu.Text = "Правка";

            this.undo.ShortcutKeys = Keys.Control | Keys.Z;
            this.undo.Text = "Отменить";
            this.undo.Click += (s, e) => richTextBox1.Undo();

            this.cut.ShortcutKeys = Keys.Control | Keys.X;
            this.cut.Text = "Вырезать";
            this.cut.Click += (s, e) => richTextBox1.Cut();

            this.copy.ShortcutKeys = Keys.Control | Keys.C;
            this.copy.Text = "Копировать";
            this.copy.Click += (s, e) => richTextBox1.Copy();

            this.paste.ShortcutKeys = Keys.Control | Keys.V;
            this.paste.Text = "Вставить";
            this.paste.Click += (s, e) => richTextBox1.Paste();

            this.delete.ShortcutKeys = Keys.Delete;
            this.delete.Text = "Удалить";
            this.delete.Click += (s, e) => richTextBox1.SelectedText = "";

            this.selectAll.ShortcutKeys = Keys.Control | Keys.A;
            this.selectAll.Text = "Выделить все";
            this.selectAll.Click += (s, e) => richTextBox1.SelectAll();

            // formatMenu
            this.formatMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.fontItem, this.textColorMenu, this.wordWrapItem});
            this.formatMenu.Text = "Формат";

            this.fontItem.Text = "Шрифт...";
            this.fontItem.Click += (s, e) => ((Form1)this).ChangeFont();

            this.wordWrapItem.CheckOnClick = true;
            this.wordWrapItem.Text = "Перенос по словам";
            this.wordWrapItem.Click += (s, e) => ((Form1)this).ToggleWordWrap();

            // viewMenu
            this.viewMenu.DropDownItems.Add(this.darkModeItem);
            this.viewMenu.Text = "Вид";

            this.darkModeItem.CheckOnClick = true;
            this.darkModeItem.Text = "Тёмная тема";
            this.darkModeItem.Click += (s, e) => ((Form1)this).ToggleDarkMode();

            // helpMenu
            this.helpMenu.DropDownItems.Add(this.about);
            this.helpMenu.Text = "Справка";

            this.about.Text = "О программе";
            this.about.Click += (s, e) => ((Form1)this).ShowAbout();

            // statusStrip1
            this.statusStrip1.Items.Add(this.statusLabel);
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);

            this.statusLabel.Text = "Готово";

            // Dialogs
            this.openFileDialog1.Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*";
            this.saveFileDialog1.Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*";
            this.fontDialog1.Font = new Font("Consolas", 10F);

            // Form1
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Текстовый редактор - Новый документ";
            this.Load += new System.EventHandler(this.Form1_Load);

            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileMenu;
        private System.Windows.Forms.ToolStripMenuItem newFile;
        private System.Windows.Forms.ToolStripMenuItem openFile;
        private System.Windows.Forms.ToolStripMenuItem saveFile;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem newWindow;
        private System.Windows.Forms.ToolStripMenuItem editMenu;
        private System.Windows.Forms.ToolStripMenuItem undo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem cut;
        private System.Windows.Forms.ToolStripMenuItem copy;
        private System.Windows.Forms.ToolStripMenuItem paste;
        private System.Windows.Forms.ToolStripMenuItem delete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem selectAll;
        private System.Windows.Forms.ToolStripMenuItem formatMenu;
        private System.Windows.Forms.ToolStripMenuItem fontItem;
        private System.Windows.Forms.ToolStripMenuItem textColorMenu;
        private System.Windows.Forms.ToolStripMenuItem wordWrapItem;
        private System.Windows.Forms.ToolStripMenuItem viewMenu;
        private System.Windows.Forms.ToolStripMenuItem darkModeItem;
        private System.Windows.Forms.ToolStripMenuItem helpMenu;
        private System.Windows.Forms.ToolStripMenuItem about;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.FontDialog fontDialog1;
    }
}
using System;
using System.IO;
using System.Windows.Forms;
using System.Timers;
using System.Drawing;

namespace NotepadPlus
{
    public partial class Form1 : Form
    {
        private System.Timers.Timer autoSaveTimer;
        private readonly string autoSavePath = Path.Combine(Path.GetTempPath(), "NotepadPlus_AutoSave.txt");
        private bool isDarkMode = false;

        public Form1()
        {
            InitializeComponent();
            SetupAutoSave();
            UpdateStatusBar();
        }

        private void SetupAutoSave()
        {
            autoSaveTimer = new System.Timers.Timer(60000); // каждые 60 сек
            autoSaveTimer.Elapsed += (s, e) => AutoSave();
            autoSaveTimer.AutoReset = true;
            autoSaveTimer.Start();

            // Восстановление при запуске
            if (File.Exists(autoSavePath))
            {
                if (MessageBox.Show("Восстановить автосохранённый текст?", "Восстановление",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    richTextBox1.Text = File.ReadAllText(autoSavePath);
                    this.Text = "Текстовый редактор - Восстановлено";
                }
                File.Delete(autoSavePath);
            }
        }

        private void AutoSave()
        {
            if (!string.IsNullOrWhiteSpace(richTextBox1.Text))
            {
                try { File.WriteAllText(autoSavePath, richTextBox1.Text); }
                catch { }
            }
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            autoSaveTimer?.Stop();
            if (File.Exists(autoSavePath)) File.Delete(autoSavePath);
            base.OnFormClosed(e);
        }

        private void UpdateStatusBar()
        {
            int chars = richTextBox1.Text.Length;
            int words = richTextBox1.Text.Split(new[] { ' ', '\n', '\r', '\t' }, StringSplitOptions.RemoveEmptyEntries).Length;
            int lines = richTextBox1.Lines.Length;
            statusLabel.Text = $"Символов: {chars} | Слов: {words} | Строк: {lines}";
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e) => UpdateStatusBar();

        private void InitializeColorMenu()
        {
            var colors = new (string name, Color color)[]
            {
                ("Чёрный", Color.Black),
                ("Синий", Color.Blue),
                ("Красный", Color.Red),
                ("Зелёный", Color.Green),
                ("Фиолетовый", Color.Purple),
                ("Оранжевый", Color.Orange)
            };

            foreach (var (name, color) in colors)
            {
                var item = new ToolStripMenuItem(name) { Tag = color };
                item.Click += (s, e) =>
                {
                    richTextBox1.ForeColor = color;
                    foreach (ToolStripMenuItem mi in textColorMenu.DropDownItems)
                        mi.Checked = false;
                    item.Checked = true;
                };
                if (name == "Чёрный") item.Checked = true;
                textColorMenu.DropDownItems.Add(item);
            }
        }

        // === Меню ===
        private void NewFile() { richTextBox1.Clear(); Text = "Текстовый редактор - Новый документ"; }
        private void OpenFile()
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.LoadFile(openFileDialog1.FileName, RichTextBoxStreamType.PlainText);
                Text = $"Текстовый редактор - {Path.GetFileName(openFileDialog1.FileName)}";
            }
        }
        private void SaveFile()
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.PlainText);
                Text = $"Текстовый редактор - {Path.GetFileName(saveFileDialog1.FileName)}";
            }
        }
        private void NewWindow() => new Form1 { Text = "Текстовый редактор - Новое окно" }.Show();
        private void ChangeFont()
        {
            fontDialog1.Font = richTextBox1.Font;
            if (fontDialog1.ShowDialog() == DialogResult.OK)
                richTextBox1.Font = fontDialog1.Font;
        }
        private void ToggleWordWrap()
        {
            richTextBox1.WordWrap = wordWrapItem.Checked;
            richTextBox1.ScrollBars = wordWrapItem.Checked
                ? RichTextBoxScrollBars.Vertical
                : RichTextBoxScrollBars.Both;
        }
        private void ToggleDarkMode()
        {
            isDarkMode = darkModeItem.Checked;
            Color back = isDarkMode ? Color.FromArgb(30, 30, 30) : SystemColors.Window;
            Color fore = isDarkMode ? Color.LightGray : SystemColors.WindowText;
            Color menu = isDarkMode ? Color.FromArgb(45, 45, 45) : SystemColors.Control;

            this.BackColor = back;
            richTextBox1.BackColor = back;
            richTextBox1.ForeColor = fore;
            menuStrip1.BackColor = menu;
            menuStrip1.ForeColor = fore;
            statusStrip1.BackColor = menu;
            statusStrip1.ForeColor = fore;
        }
        private void ShowAbout()
        {
            MessageBox.Show(
                "Блокнот+ 2.0\n" +
                "Разработано на C# Windows Forms\n\n" +
                "• Статистика текста\n" +
                "• Автосохранение\n" +
                "• Цвет текста\n" +
                "• Тёмная тема\n\n" +
                "Автор: Казаченко Никита\n\n" +
                "О программе");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] names = { "Чёрный", "Синий", "Красный", "Зелёный", "Фиолетовый", "Оранжевый" };
            Color[] colors = { Color.Black, Color.Blue, Color.Red, Color.Green, Color.Purple, Color.Orange };

            for (int i = 0; i < names.Length; i++)
            {
                ToolStripMenuItem item = new ToolStripMenuItem(names[i]);
                item.Tag = colors[i];
                item.Click += (s, ev) =>
                {
                    if (richTextBox1.SelectionLength > 0)
                    {
                        richTextBox1.SelectionColor = (Color)item.Tag;
                    }
                    else
                    {
                        richTextBox1.ForeColor = (Color)item.Tag;
                    }

                    // Снимаем галочку с других
                    foreach (ToolStripMenuItem m in textColorMenu.DropDownItems)
                        m.Checked = false;
                    item.Checked = true;
                };
                if (i == 0) item.Checked = true;
                textColorMenu.DropDownItems.Add(item);
            }
        }

        private void richTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control)
            {
                switch (e.KeyCode)
                {
                    case Keys.Z: richTextBox1.Undo(); break;
                    case Keys.X: richTextBox1.Cut(); break;
                    case Keys.C: richTextBox1.Copy(); break;
                    case Keys.V: richTextBox1.Paste(); break;
                    case Keys.A: richTextBox1.SelectAll(); break;
                    case Keys.N:
                        if (e.Shift) NewWindow(); else NewFile();
                        break;
                }
                e.Handled = true;
            }
            else if (e.KeyCode == Keys.Delete)
            {
                richTextBox1.SelectedText = "";
                e.Handled = true;
            }
        }
    }
}
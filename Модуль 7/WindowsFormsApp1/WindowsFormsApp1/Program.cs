using System;
using System.Windows.Forms;

namespace NotepadPlus
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var form1 = new Form1();
            form1.Show();

            var form2 = new Form1();
            form2.Text = "Текстовый редактор - Новое окно";
            form2.Show();

            Application.Run();
        }
    }
}
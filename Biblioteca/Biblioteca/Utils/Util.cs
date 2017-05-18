using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteca.Utils
{
    public class Util
    {
        public static void limparForm(Form form)
        {
            foreach (Control item in form.Controls)
            {
                if (item is TextBox)
                {
                    TextBox x = (TextBox)item;
                    x.Text = "";
                    x.Enabled = true;
                }
                if (item is MaskedTextBox)
                {
                    MaskedTextBox x = (MaskedTextBox)item;
                    x.Text = "";
                }
                if (item is ComboBox)
                {
                    ComboBox x = (ComboBox)item;
                    x.SelectedIndex = 0;
                }
            }
        }

        public static void liberarBotoes(Form form)
        {
            foreach (Control item in form.Controls)
            {
                if (item is GroupBox)
                {
                    foreach (Control b in item.Controls)
                    {
                        if (b is Button) b.Enabled = true;
                    }
                }
            }
        }

    }
}

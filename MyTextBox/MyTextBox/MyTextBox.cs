using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyTextBox
{
    public class MyTextBox : TextBox
    {
        public int MenorValor { get; set; }


        //Sobrescrever o onGotFocus

        protected override void OnGotFocus(EventArgs e)
        {
            this.BackColor = System.Drawing.Color.AliceBlue;
        }

        //Sobrescrever o lostFocus
        protected override void OnLostFocus(EventArgs e)
        {
            this.BackColor = System.Drawing.Color.White;
        }
        protected override void OnKeyUp(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }
    }
}

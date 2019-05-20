using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt2_PiotrBrodziak_49084
{
    //obsługa myszy
    private void pbPanelRysowniczy_MouseMove(object sender, MouseEventArgs e)
    {
        if (
            (pbPanelRysowniczy.Location.X < e.X) &
            (e.X < pbPanelRysowniczy.Location.X + (int)pbPanelRysowniczy.Size.Width) &
            (pbPanelRysowniczy.Location.Y < e.Y) &
            (e.Y < pbPanelRysowniczy.Location.Y + (int)pbPanelRysowniczy.Size.Height)
            )
        {
            pbLblX.Text = "x: " + e.X;
            pbLblY.Text = "y: " + e.Y;
        }

    }
}

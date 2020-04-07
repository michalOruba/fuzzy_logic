using System.Drawing;
using System.Windows.Forms;

namespace FuzzyLogicPrecipitation
{
    class Helper
    {
        public static void setAnchorAndLocation(Form form, Panel panel)
        {
            int horizontalPosition;
            int verticalPosition;
            if (form.Size.Height < panel.Size.Height)
            {
                panel.Anchor = (AnchorStyles.Top | AnchorStyles.Left);
                verticalPosition = 4;
                horizontalPosition = 10;
            }
            else
            {
                panel.Anchor = AnchorStyles.None;
                horizontalPosition = (form.Width - panel.Width) / 2;
                verticalPosition = (form.Height - panel.Height) / 2;
            }
            panel.Location = new Point(horizontalPosition, verticalPosition);
        }
    }
}

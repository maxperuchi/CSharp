using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Text;
using System.Threading.Tasks;

namespace TrayIconCounter
{
    public class EnumerableIcon
    {
        private static Icon GetTrayIconNumbers(int number)
        {
            ResourceManager RM = new ResourceManager("MyLocalisation.Properties.Resources", Assembly.GetExecutingAssembly());
            if (number >= 0 && number <= 99)
            {
                Bitmap iconA, iconB;
                if (number < 10)
                {
                    iconA = RM.GetObject("c0") as Bitmap;
                    iconB = RM.GetObject("c" + number.ToString()) as Bitmap;
                }
                else
                {
                    iconA = RM.GetObject("c" + number.ToString().Substring(0, 1)) as Bitmap;
                    iconB = RM.GetObject("c" + number.ToString().Substring(1, 1)) as Bitmap;
                }

                Bitmap bitmap = new Bitmap(iconA.Width + iconB.Width, Math.Max(iconA.Height, iconB.Height));
                using (Graphics g = Graphics.FromImage(bitmap))
                {
                    g.DrawImage(iconA, 0, 0);
                    g.DrawImage(iconB, iconA.Width, 0);
                }

                IntPtr Hicon = bitmap.GetHicon();
                Icon icon = Icon.FromHandle(Hicon);

                return icon;
            }
            else
            {
                return RM.GetObject("default") as Icon;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ukwenza
{
    public class Flags
    {
        public static int FirstStatue = 1;
        public static int Moolka = 1;
        public static int Load = 0;
        public static string User = "asd";
        public static int Admin = 0;
        public static int Magnus = 0;
        public static int Finalizata = 0;

        public static class CustomMessageBox
        {
            public static void Show(string title, string description)
            {
                // using construct ensures the resources are freed when form is closed
             //   using (var form = new CustomMessageForm(title, description))
                {
                //    form.ShowDialog();
                }
            }
        }
    }
}

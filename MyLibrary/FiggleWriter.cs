using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary
{
    public class FiggleWriter
    {
        public void Write (string messages)
        {
            Console.WriteLine(Figgle.FiggleFonts.Standard.Render(messages));
        }
    }
}

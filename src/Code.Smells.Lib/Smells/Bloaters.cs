using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code.Smells.Lib.Smells
{
    public class Bloaters
    {
        public void LongMethod()
        {
            // get the current directory so we can 
            // look for certain types of files
            var current_path = Path.GetDirectoryName(Environment.CurrentDirectory);

            // determine the assets folder location; there should always be one within th 
            var sub_directory = Path.Combine(current_path, "assets_folder");

            if (true)
            {

                // get all the files in the current folder

            }        }
    }
}

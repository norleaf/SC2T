using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game1
{
    public class ClassAutomation
    {
        public static void CreateClassesByFileNames()
        {
            var path = @"C:\Users\Hans Nørløv\Documents\Visual Studio 2019\Projects\Starcraft2Turnbased\Game1\Content";

            var files = Directory.GetFiles(path);
            StringBuilder visuals = new StringBuilder(); ;
            visuals.AppendLine("namespace Starcraft2Turnbased                                       ");
            visuals.AppendLine("{                                                               ");
            foreach (var f in files)
            {
                FileInfo fi = new FileInfo(f);
                var name = fi.Name.Replace(".xnb", "");
                visuals.AppendLine();
                visuals.AppendLine("    public class " + name + " : Unit                                 ");
                visuals.AppendLine("    {                                                           ");
                visuals.AppendLine("        public " + name + "()                                                        ");
                visuals.AppendLine("        {                                                           ");
                visuals.AppendLine("        }                                                           ");
                visuals.AppendLine("    }                                                           ");







            }
            visuals.AppendLine("}                                                               ");
            File.WriteAllText(Path.Combine(path, "visuals.txt"), visuals.ToString());

        }
    }
}

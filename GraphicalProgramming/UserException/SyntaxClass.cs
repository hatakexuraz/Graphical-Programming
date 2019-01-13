using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace GraphicalProgramming.UserException
{
    class SyntaxClass
    {
        private static String syntax = " shape <num>,<num>,<num>,<num>";

        public SyntaxClass()
        {

        }

        public static Boolean validateSyntax(String command)
        {
            int[] values = new int[14];
            string first = command.IndexOf(" ") > -1
                  ? command.Substring(0, command.IndexOf(" "))
                  : command;

            if(first.Equals("Circle") || first.Equals("Rectangle") || first.Equals("Polygon"))
            {
                Regex reg = new Regex("<[^#]+>");

                MatchCollection matches = reg.Matches(command);
                foreach (Match m in matches)
                {
                    int i = 0;
                    String a = m.Value;
                    Boolean isDigit = a.Any(c => char.IsDigit(c));
                    if (isDigit == true)
                    {
                        values[i] = Int32.Parse(m.Value);
                    }
                    else
                    {
                        throw (new ShapeException(a+ " is not a number"));
                    }
                    i++;
                }
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicalProgramming.UserException
{
    class ShapeException : Exception
    {
        public ShapeException(String message) : base(message){

        }
    }

    class ThrowShapeException
    {

        private String syntax = " shape <num>,<num>,<num>,<num>";
        public void validateParameter(String var)
        {
            if (!var.Any(c => char.IsDigit(c)))
            {
                throw (new ShapeException("Invalid parameter."));
            }
        }

        public void checkSyntax(string syntax)
        {
            string first = syntax.IndexOf(" ") > -1
                  ? syntax.Substring(0, syntax.IndexOf(" "))
                  : syntax;
            if (!(syntax.Equals("Circle") || syntax.Equals("Rectangle") || syntax.Equals("Polygon")))
            {
                throw (new ShapeException("Didn't understand the keyword."));
            }
        }
    }
}
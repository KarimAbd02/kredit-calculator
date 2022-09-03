using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProject1
{
    class ErrorNumber : Exception
    {
        public ErrorNumber() : base()
        { }

        public ErrorNumber(string str) : base(str)
        { }

        public override string ToString()
        {
            return base.Message;
        }
    }
    class Class1
    {
        double periods = 0;


        public double kreditden(double startcount, double rate, double years)
        {
            if (startcount < 10000) throw new ErrorNumber("не достаточное количество цифр");
            else if (startcount> 1000000000) throw new ErrorNumber("слишком много цифр");
            double kredit;
            double dayRate = rate / 365;
            periods = years * 365;
            startcount = startcount * Math.Pow((1 + dayRate), periods);
            kredit = startcount / periods;
            return kredit;
        }

        public double kreditmes(double startcount, double rate, int years)
        {
            if (startcount < 10000) throw new ErrorNumber("не достаточное количество цифр");
            else if (startcount > 1000000000) throw new ErrorNumber("слишком много цифр");
            string total;
            double monthRate = rate / 30;
            periods = years * 12;
            startcount = startcount * Math.Pow((1 + monthRate), periods);
            double kredit;
            total = Convert.ToString(Math.Round(startcount, 2));
            kredit = startcount / periods;
            return kredit;
        }
        public double kreditkvart(double startcount, double rate, int years)
        {
            if (startcount < 10000) throw new ErrorNumber("не достаточное количество цифр");
            else if (startcount > 1000000000) throw new ErrorNumber("слишком много цифр");
            double kredit;
            double quarterRate = rate / 90;
            periods = years * 4;
            startcount = startcount * Math.Pow((1 + quarterRate), periods);
            kredit = startcount / periods;
            return kredit;
        }

        public double kredithalfyear(double startcount, double rate, int years)
        {
            if (startcount < 10000) throw new ErrorNumber("не достаточное количество цифр");
            else if (startcount > 1000000000) throw new ErrorNumber("слишком много цифр");
            double kredit;
            double halfyearRate = rate / 182;
            periods = years * 2;
            startcount = startcount * Math.Pow((1 + halfyearRate), periods);
            kredit = startcount / periods;
            return kredit;
        }
        public double kredityear(double startcount, double rate, int years)
        {
            if (startcount < 10000) throw new ErrorNumber("не достаточное количество цифр");
            else if (startcount > 1000000000) throw new ErrorNumber("слишком много цифр");
            double kredit;
            double yearRate = rate / 365;
            periods = years;
            startcount = startcount * Math.Pow((1 + yearRate), periods);
            kredit = startcount / periods;
            return  kredit;

        }
    }
}

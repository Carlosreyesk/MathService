using System;

namespace WcfService1
{
    public class Operation
    {

        private double val1;
        private double val2;
        private string type;
        private double result;

        public Operation(double pv1, double pv2, string ptype)
        {
            setType(ptype);
            setVal1(pv1);
            setVal2(pv2); 
        }

        private void setType(string ptype) {
            this.type = ptype;
        }

        private void setVal1(double pv1)
        {
            this.val1 = pv1;
        }

        private void setVal2(double pv2)
        {
            this.val2 = pv2;
        }

        public string getType()
        {
            return this.type;
        }

        public double getVal1()
        {
            return this.val1;
        }
        public double getVal2()
        {
            return this.val2;
        }

        public double process()
        {

            string type = this.getType();
            double v1 = this.getVal1();
            double v2 = this.getVal2();

            if (type.Equals("Add", StringComparison.Ordinal))
            {
                result = v1 + v2;
            }
            else if (type.Equals("Subtract", StringComparison.Ordinal))
            {
                result = v1 - v2;
            }
            else if (type.Equals("Multiply", StringComparison.Ordinal))
            {
                result = v1 * v2;
            }
            else
            {
                result = v1 / v2;
            }

            return result;
        }
    }
}
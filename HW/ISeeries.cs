using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW
{
    interface ISeeries
    {
        void setStart(int x);
        int getNext();
        void reset();
    }
    class ArithProgression : ISeeries
    {
        int step;
        int startValue;
        int currenValue;
        public int getNext()
        {
            currenValue += step;
            return currenValue;
        }

        public void reset()
        {
            currenValue = startValue;
        }

        public void setStart(int x)
        {
            startValue=x;
            currenValue = startValue;
        }
        public void setStep(int s)
        {
            step=s;
        }
    }
    class GeomProgression : ISeeries
    {
        int step;
        int startValue;
        int currenValue;
        public int getNext()
        {
            currenValue = currenValue*step;
            return currenValue;
        }

        public void reset()
        {
            currenValue = startValue;
        }

        public void setStart(int x)
        {
            startValue = x;
            currenValue = startValue;
        }
        public void setStep(int s)
        {
            step = s;
        }
    }
}

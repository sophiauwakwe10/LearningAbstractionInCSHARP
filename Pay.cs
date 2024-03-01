using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningAbstractionInCSHARP
{
    public abstract class Pay
    {
        protected int _basicPay = 50000;
        protected int _houseRent = 89000;
        protected int _payRate = 5;
        protected int _netPay;

        public abstract int GradeOne { get;}         
        public abstract int GradeTwo { get;}
    }


    public class PayBill : Pay
    {
        public override int GradeOne
        {
            get
            {
                return _netPay = _basicPay + _houseRent;
            }
        }
           
        public override int GradeTwo
        {
            get
            {
            return _netPay = _basicPay+_basicPay/_payRate + _houseRent * _payRate;    
            }
        }


        public void Display()
        {
            Console.WriteLine("The output Sally was able to pay for GradeOne is : {0}", GradeOne);
            Console.WriteLine("The output Sally was able to pay for GradeOne is : {0}", GradeTwo);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductCRUD
{
    public delegate void MyDelegate();
    public class Student
    {
        //when event raise then notification will be sent to MyDelegate

        public event MyDelegate Fail;
        public event MyDelegate Pass;

        public void AcceptPercentage(double per)
        {
            if (per < 40)
            {
                Fail(); //raise an event / call to event
            }
            else
            {
                Pass();
            }
        }
        public class Message
        {
            public void SuccessMessage()
            {
                Console.WriteLine("You are Pass in the exam");
            }
            public void FailMessage()
            {
                Console.WriteLine("You are Fail in exam");
            }
        }
        public class Program
        {
            static void Main(string[] args)
            {
                try
                {
                    Student stud1 = new Student();
                    Message msg = new Message();

                    // bind event with delegate
                    stud1.Fail += new MyDelegate(msg.FailMessage);
                    stud1.Pass += new MyDelegate(msg.SuccessMessage);

                    stud1.AcceptPercentage(35);

                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

    }
}

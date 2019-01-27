using AutofacTest.IServices;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutofacTest.Services
{
    public class Test : ITest
    {
        public void SendMessage()
        {
            Console.WriteLine("Dyao");
        }
    }
}

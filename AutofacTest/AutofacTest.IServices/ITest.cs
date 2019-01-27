using AutofacTest.IServices.Infrastructure;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutofacTest.IServices
{
    public interface ITest : IDependency
    {
        void SendMessage();
    }
}

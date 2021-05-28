using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Autofac;

namespace Loans
{
    /* #TA01
       - you need to extened this class from Module and
         hence need the Autofac package
       - notice that you register the LoanDb as a singleton
         to simulate a db so every request can access the
         same loan data
       - LoanService needs to depend on IDb; use Resolve
         to get an instance
       - I think it's better to provide an Autofac Module
         as you know what's needed in DI for your class
         library to work
    */
    public class LoanAutofacModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.Register(c => new LoanDb()).
                As<IDb>().SingleInstance();
            builder.Register(c => new LoanService(c.Resolve<IDb>()))
                .As<ILoan>().InstancePerLifetimeScope();           
        }
    }
}

using ParkCostCalc.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ParkCostCalc.Core.Interfaces
{
    public interface IContactService
    {
        public Contact ContactUs(Contact contact);
    }
}

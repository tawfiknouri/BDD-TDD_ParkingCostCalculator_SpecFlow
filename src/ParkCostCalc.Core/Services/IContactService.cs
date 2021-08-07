using ParkCostCalc.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ParkCostCalc.Core.Services
{
    public interface IContactService
    {
        public Contact CreateContact(Contact contact);
    }
}

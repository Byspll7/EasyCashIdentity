﻿using EasyCashIdentity.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyCashIdentity.BusinessLayer.Abstract
{
    public interface ICustomerAccountService : IGenericService<CustomerAccount>
    {
        public List<CustomerAccount> TGetCustomerAccountsList(int id);
    }
}

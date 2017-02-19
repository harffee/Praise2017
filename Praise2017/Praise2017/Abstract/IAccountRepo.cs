using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Praise2017.Models;

namespace Praise2017.Abstract
{
   public interface IAccountRepo
    {
        IQueryable<AccountInfo> Accounts { get; }
        IQueryable<Detail> Details { get; }
    }
}

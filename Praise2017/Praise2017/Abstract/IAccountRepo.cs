using Praise2017.Models;
using System.Linq;

namespace Praise2017.Abstract
{
    public interface IAccountRepo
    {
        IQueryable<AccountInfo> Accounts { get; }
        IQueryable<Detail> Details { get; }
    }
}

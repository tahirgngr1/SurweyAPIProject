using SurweyAndLists;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace DataAccess.Implements
{
    public class OptionRepostiory : GenericRepository<Option,SurweyDbContext> , IOptionRepository
    {

        public OptionRepostiory()
        {
         
        }
    }
}

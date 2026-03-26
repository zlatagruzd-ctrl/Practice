using System.Collections.Generic;
using System.Linq;

namespace Gruzd_9
{
    public class ClientProcessor
    {
        public List<Client> FindDebtors(List<Client> clients)
        {
            return clients.Where(c => c.Balance < 0).ToList();
        }
    }
}
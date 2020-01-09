using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Catalog.Domain.Entities;

namespace Catalog.Domain.Repositories
{
    public class Teste : IItemRepository
    {
        public IUnitOfWork UnitOfWork { get; }
        public Task<IEnumerable<Item>> GetAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Item> GetAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Item Add(Item item)
        {
            throw new NotImplementedException();
        }

        public Item Update(Item item)
        {
            throw new NotImplementedException();
        }
    }

    public class Teste2
    {
        public void OI()
        {
            Item i = new Item();

            Teste t = new Teste();
            t.Update(i);
            t.UnitOfWork.SaveChangesAsync();


        }
    }
}

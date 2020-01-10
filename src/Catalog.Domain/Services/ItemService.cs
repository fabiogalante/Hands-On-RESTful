using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Catalog.Domain.Mappers;
using Catalog.Domain.Repositories;
using Catalog.Domain.Requests.Item;
using Catalog.Domain.Responses;

namespace Catalog.Domain.Services
{
    public class ItemService : IItemService
    {
        private readonly IItemRepository _itemRepository;
        private readonly IItemMapper _itemMapper;

        public ItemService(IItemRepository itemRepository, IItemMapper itemMapper)
        {
            _itemRepository = itemRepository;
            _itemMapper = itemMapper;
        }

        public async Task<ItemResult> GetItemsAsyncMap()
        {
           var itensByEntity =  await _itemRepository.GetAsync();

           var result = new ItemResult
           {
               Itens = itensByEntity
           };

           return result;

           // return result.Select(x => _itemMapper.Map(x));
        }

        public async Task<IEnumerable<ItemResponse>> GetItemsAsync()
        {
            var result = await _itemRepository.GetAsync();
            return result.Select(x => _itemMapper.Map(x));
        }

        public Task<ItemResponse> GetItemAsync(GetItemRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<ItemResponse> AddItemAsync(AddItemRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<ItemResponse> EditItemAsync(EditItemRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<ItemResponse> DeleteItemAsync(DeleteItemRequest request)
        {
            throw new NotImplementedException();
        }
    }
}

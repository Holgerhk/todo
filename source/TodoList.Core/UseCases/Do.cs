namespace TodoList.Core.UseCases
{
    using System;
    using TodoList.Core.Boundaries.Do;
    using TodoList.Core.Entities;
    using TodoList.Core.Gateways;

    public sealed class Do : IUseCase
    {
        private IItemGateway _itemGateway;

        public Do(IItemGateway itemGateway)
        {
            _itemGateway = itemGateway;
        }

        public void Execute(string itemId)
        {
            IItem item = _itemGateway.Get(itemId);
            item.Do();
            _itemGateway.Update(item);
        }
    }
}
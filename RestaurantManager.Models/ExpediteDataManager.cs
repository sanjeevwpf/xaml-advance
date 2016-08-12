using System.Collections.Generic;

namespace RestaurantManager.Models
{
    public class ExpediteDataManager : DataManager
    {
        public ExpediteDataManager()
        { }

        protected override void OnDataLoaded()
        {
            this.OrderItems = base.Repository.Orders;
            
        }

        public List<Order> OrderItems
        {
            get { return base.Repository.Orders; }
            set { this.OnPropertyChanged(); }
        }
    }
}

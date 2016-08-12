using System.Collections.Generic;

namespace RestaurantManager.Models
{
    public class OrderDataManager : DataManager
    {
        private bool iscurrentloaded = false;
        public OrderDataManager()
        {
            
            
        }

        protected override void OnDataLoaded()
        {
            this.MenuItems = base.Repository.StandardMenuItems;

            this.CurrentlySelectedMenuItems = new List<MenuItem>
            {
                this.MenuItems[3],
                this.MenuItems[5]
            };

            this.OnPropertyChanged("CurrentlySelectedMenuItems");
        }

        public List<MenuItem> MenuItems {get { return base.Repository.StandardMenuItems; } set {this.OnPropertyChanged() ; }
        }

        public List<MenuItem> CurrentlySelectedMenuItems {
            get; 
            set; 
            
        }
    }
}

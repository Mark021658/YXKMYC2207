using Abp.Domain.Entities;

namespace YT.Suofeiya.Core.Menu
{
    public class MenuEntity:Entity
    {
        public int MenuID { get; set; }
        public int ParentID { get; set; }
        public string Name { get; set; }
        public string PageType { get; set; }
        public string ImagePath { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YT.Suofeiya.Menu
{
    public class MenuDto
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string PageType { get; set; }
        // 父级菜单 
        //public int ParentID { get; set; }
        public List<MenuDto> Nodes { get; set; }

        public MenuDto()
        {
            Nodes = new List<MenuDto>();
        }

        public MenuDto GetMenu(int id, MenuDto rootNode)
        {
            if (rootNode.ID == id)
            {
                return rootNode;
            }
            else
            {
                foreach (var node in rootNode.Nodes)
                {
                    var value = GetMenu(id, node);
                    if (value != null)
                    {
                        return value;
                    }
                }
            }

            return null;
        }
    
    }
}

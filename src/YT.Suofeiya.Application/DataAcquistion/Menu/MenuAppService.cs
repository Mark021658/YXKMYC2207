using Abp.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YT.Suofeiya.Core.Menu;
using YT.Suofeiya.Core.PLC;

namespace YT.Suofeiya.Menu
{
    public class MenuAppService : SuofeiyaAppServiceBase, IMenuAppService
    {
        private IRepository<MenuEntity> _menuRepository;

        public MenuAppService(IRepository<MenuEntity> menuRepository)
        {
            _menuRepository = menuRepository;
        }

        public Task<MenuDto> GetMenu()
        {
            string strNamSpace = "YT.Suofeiya.UI.Page.";
            List<MenuEntity> menus = _menuRepository.GetAllList();

            int rootID = 0;

            MenuDto menuDto = new MenuDto()
            {
                ID = rootID,
            };

            foreach(MenuEntity menu in menus.Where(q => q.ParentID == 0).OrderBy(q => q.MenuID))
            {
                MenuDto menu1 = new MenuDto()
                {
                    ID = menu.MenuID,
                    Name = menu.Name,
                };

                foreach (MenuEntity submenu in menus.Where(q => q.ParentID == menu.MenuID).OrderBy(q => q.MenuID))
                {
                    MenuDto menu11 = new MenuDto()
                    {
                        ID = submenu.MenuID,
                        Name = submenu.Name,
                        PageType = strNamSpace + submenu.PageType
                    };
                    menu1.Nodes.Add(menu11);
                }
                menuDto.Nodes.Add(menu1);
            }

            return Task.FromResult(menuDto);
        }
       
    }

}

using AppMauiGallery.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppMauiGallery.Repositories
{
    public interface IGroupComponentRepository
    {
        List<GroupComponent> GetGroupComponents();

        List<Component> GetComponents();
    }
}

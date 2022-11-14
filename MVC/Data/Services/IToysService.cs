using MVC.Data.Base;
using MVC.Data.ViewModels;
using MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC.Data.Services
{
    public interface IToysService: IEntityBaseRepository<Toys>
    {
        Task<Toys> GetToysByIdAsync(int id);

        Task<NewToysDropDownVM> GetNewToysDropDownValues();

        Task AddNewToysAsync(newToysVM data);
        Task UpdateToysAsync(newToysVM data);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Domain;

namespace DemoBlazor.Services
{
    public interface IDomainService
    {

        Task LoadPersons();
        List<User> AvailablePersons { get; }
        Task DeleteLastPerson();
        Task LoadSavedList();
    }
}

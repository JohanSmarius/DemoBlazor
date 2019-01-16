using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Core.Domain;
using DemoBlazor.Proxy;
using Microsoft.AspNetCore.Blazor;

namespace DemoBlazor.Services
{
    public class DomainService : IDomainService
    {
        private readonly HttpClient _httpClient;

        public List<User> AvailablePersons { get; private set; } = new List<User>();

        public DomainService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }


        public async Task LoadPersons()
        {
            AvailablePersons.Clear();

            //AvailablePersons.Add(new User()
            //{
            //    Name = "Scott Hanselman",
            //    Email = "scott@microsoft.com",
            //    PhoneNumber = "12345468",
            //    Picture = "https://avatars0.githubusercontent.com/u/2892?s=460&v=4"
            //});

            //AvailablePersons.Add(new User()
            //{
            //    Name = "Scott Gutthrie",
            //    Email = "scott@microsoft.com",
            //    PhoneNumber = "12345468",
            //    Picture = "https://sec.ch9.ms/ch9/e6c4/ea6aa4d2-472a-46c1-a31e-b3d86daee6c4/scottguazurewebsitesendpoints_960.jpg?v=744001bc6a23bbf8533bfb48dc1e9372cfe8dbe985ae55b3f5e950865fce9395"
            //});

            var serviceResponse = await _httpClient.GetJsonAsync<List<User>>("http://blazortestclient.azurewebsites.net/api/persons");
            AvailablePersons.AddRange(serviceResponse);
        }
    }
}

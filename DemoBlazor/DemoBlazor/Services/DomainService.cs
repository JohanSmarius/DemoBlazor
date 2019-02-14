using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Core.Domain;
using DemoBlazor.Proxy;
using Microsoft.AspNetCore.Components;

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
            var serviceResponse = await _httpClient.GetJsonAsync<List<User>>("http://localhost:55322/api/persons");
            AvailablePersons.AddRange(serviceResponse);
        }

        public async Task DeleteLastPerson()
        {
            AvailablePersons.RemoveAt(AvailablePersons.Count - 1);
        }

    }
}

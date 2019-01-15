using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Domain;
using DemoBlazor.Pages;
using Microsoft.AspNetCore.Blazor.Components;

namespace DemoBlazor.Shared
{
    public class PersonDetailViewModel : BlazorComponent
    {
        [Parameter]
        protected User Person { get; set; }

        [Parameter]
        public Action<User> PersonSelected { get; set; }

        protected void SelectPerson()
        {
            Console.WriteLine("Handler called");
            PersonSelected?.Invoke(Person);
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Authentication.ExtendedProtection;
using System.Threading.Tasks;
using Core.Domain;
using DemoBlazor.Pages;
using Microsoft.AspNetCore.Components;

namespace DemoBlazor.Shared
{
    public class PersonDetailViewModel : ComponentBase
    {
        [Parameter]
        protected User Person { get; set; }

        [Parameter]
        internal Action<User> PersonSelected { get; set; }

        protected void SelectPerson()
        {
            Console.WriteLine("Handler called");
            PersonSelected?.Invoke(Person);
        }

    }
}

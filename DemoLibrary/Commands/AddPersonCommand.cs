using DemoLibrary.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary.Commands
{
    public record AddPersonCommand(string FirstName, string LastName) : IRequest<PersonModel>;
    //public  class AddPersonCommandClass: IRequest<PersonModel>
    //{
    //    public string FirstName { get; set; }
    //    public string LastName { get; set; }
    //    public AddPersonCommandClass(string firstName,string lastName)
    //    {
    //        FirstName = firstName;
    //        LastName = lastName;
    //    }
    //}
}

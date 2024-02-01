using DemoLibrary.Commands;
using DemoLibrary.DataAccess;
using DemoLibrary.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary.Handlers
{
    public class AddPersonHandler : IRequestHandler<AddPersonCommand, PersonModel>
    {
        private readonly IDataAccess _dataAccess;
        public AddPersonHandler(IDataAccess dataAccess)
        {
            _dataAccess = dataAccess;

        }
        public Task<PersonModel> Handle(AddPersonCommand request, CancellationToken cancellationToken)
        {
            return Task.FromResult( _dataAccess.AddPerson(request.FirstName, request.LastName));
        }
    }
}

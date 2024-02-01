using DemoLibrary.DataAccess;
using DemoLibrary.Models;
using DemoLibrary.Queries;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary.Handlers
{

    public class GetPersonListHandler : IRequestHandler<GetPersonListQuery, List<PersonModel>>
    {
        IDataAccess _dataAccess;
        public GetPersonListHandler(IDataAccess data)
        {
            _dataAccess = data;
        }
        public Task<List<PersonModel>> Handle(GetPersonListQuery request, CancellationToken cancellationToken)
        {
            //throw new NotImplementedException();
            return Task.FromResult(_dataAccess.GetPeople());
        }
    }
}

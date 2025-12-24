using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UditEdu.Core.Interfaces;
using UditEdu.Core.Models;

namespace UditEdu.Application.Queries
{
    public record GetJokeDataQuery:IRequest<JokeData>;

    public record GetJokeDataQueryHandler(IExternalVendorRepository ExternalVendorRepository) : IRequestHandler<GetJokeDataQuery, JokeData>
    {
        public async Task<JokeData> Handle(GetJokeDataQuery request, CancellationToken cancellationToken)
        {
            return await ExternalVendorRepository.GetJokeData();
        }
    }
}

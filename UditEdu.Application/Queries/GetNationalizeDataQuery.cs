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
    public record GetNationalizeDataQuery  : IRequest<NationalizeData>;

    public class GetNationalizeDataQueryHandler(IExternalVendorRepository externalVendorRepository) : IRequestHandler<GetNationalizeDataQuery, NationalizeData>
    {
        public async Task<NationalizeData> Handle(GetNationalizeDataQuery request, CancellationToken cancellationToken)
        {
            return await externalVendorRepository.GetNationalizeData();
        }
    }
}

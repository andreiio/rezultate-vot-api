﻿using System.Collections.Generic;
using System.Threading.Tasks;
using CSharpFunctionalExtensions;
using ElectionResults.Core.Entities;

namespace ElectionResults.Core.Repositories
{
    public interface ITerritoryRepository
    {
        Task<Result<List<County>>> GetCounties();
        Task<Result<List<Locality>>> GetLocalities(int? countyId, int? ballotId);
        Task<Result<List<Country>>> GetCountries(int? ballotId);
        Task<Result<Locality>> GetLocalityById(int? localityId, bool includeCounty = false);
        Task<Result<County>> GetCountyById(int? queryCountyId);
    }
}
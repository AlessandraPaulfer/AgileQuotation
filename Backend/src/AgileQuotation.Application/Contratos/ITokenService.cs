using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AgileQuotation.Application.Dtos;

namespace AgileQuotation.Application.Contratos
{
    public interface ITokenService
    {
        Task<string> CreateToken(UserUpdateDto userUpdateDto);
    }
}
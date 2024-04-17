using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AgileQuotation.Domain.Identity;
using AgileQuotation.Persistence.Contextos;
using AgileQuotation.Persistence.Contratos;

namespace AgileQuotation.Persistence
{
    public class UserPersist : GeralPersist, IUserPersist
    {
        private readonly AgileQuotationContext _context;

        public UserPersist(AgileQuotationContext context) : base(context)
        {
            _context = context;
        }

        public async Task<IEnumerable<User>> GetUsersAsync()
        {
            return await _context.Users.ToListAsync();
        }

        public async Task<User> GetUserByIdAsync(int id)
        {
            return await _context.Users.FindAsync(id);
        }

        public async Task<User> GetUserByUserNameAsync(string userName)
        {
            return await _context.Users
                                 .SingleOrDefaultAsync(user => user.UserName == userName.ToLower());
        }
    }
}
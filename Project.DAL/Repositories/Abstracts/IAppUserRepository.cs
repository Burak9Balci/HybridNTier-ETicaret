﻿using Microsoft.AspNetCore.Identity;
using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.DAL.Repositories.Abstracts
{
    public interface IAppUserRepository : IRepository<AppUser>
    {
        Task<IdentityResult> AddUserAsync(AppUser user);

        Task AddToRoleAsync(AppUser appUser, AppRole appRole);
        Task<bool> CheckPasswordAsync(AppUser appUser, string password);
        Task<IList<string>> GetRolesAsync(AppUser appUser);
    }
}

﻿using CleanArchitecture.ApplicationCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.ApplicationCore.Interfaces.Repositories
{
    public interface IUserRefreshTokenRepository : IRepository<UserRefreshToken>
    {
        Task DisableAllRefreshToken(string userId, string tokenId);
    }
}

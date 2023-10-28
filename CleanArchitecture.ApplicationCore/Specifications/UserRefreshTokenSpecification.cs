﻿using Ardalis.Specification;
using CleanArchitecture.ApplicationCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.ApplicationCore.Specifications
{
    public class UserRefreshTokenSpecification : Specification<UserRefreshToken>
    {
        public UserRefreshTokenSpecification(string refreshToken)
        {
            Query.Where(x => x.RefreshToken == refreshToken);
        }
    }
}

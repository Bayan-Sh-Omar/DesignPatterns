﻿using SmartCity.Core.DataAccess;
using SmartCity.Entities.Concrete;

namespace SmartCity.DataAccess.Abstract
{
    public interface IRequestDal : IEntityRepository<Request>
    {
    }
}

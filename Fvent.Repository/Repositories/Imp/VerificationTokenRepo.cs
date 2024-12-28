﻿using Fvent.BO.Entities;
using Fvent.Repository.Common;
using Fvent.Repository.Data;
using Fvent.Repository.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class VerificationTokenRepo(MyDbContext context) : BaseRepository<VerificationToken>(context), IVerificationTokenRepo
{
}


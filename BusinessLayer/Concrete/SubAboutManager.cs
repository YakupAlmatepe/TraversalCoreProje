﻿using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class SubAboutManager : ISubAboutService
    {
        ISubAboutDal _subAboutDal;

        public SubAboutManager(ISubAboutDal subAboutDal)
        {
            _subAboutDal = subAboutDal;
        }

        public void TDelete(SubAbout t)
        {
            throw new NotImplementedException();
        }

        public List<SubAbout> TGetList()
        {
            return _subAboutDal.GetList();
        }

        public void TInsert(SubAbout t)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(SubAbout t)
        {
            throw new NotImplementedException();
        }
        public void TAdd(SubAbout t)
        {
            throw new NotImplementedException();
        }
    }
}

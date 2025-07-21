﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReporterDay.BusinessLayer.Abstract;
using ReporterDay.DataAccessLayer.Abstract;
using ReporterDay.EntityLayer.Entities;

namespace ReporterDay.BusinessLayer.Concrete
{
    public class CommentManager : ICommentService
    {
        private readonly ICommentDal _commentDal;

        public CommentManager(ICommentDal commentDal)
        {
            _commentDal = commentDal;
        }

        public void TDelete(int id)
        {
            _commentDal.Delete(id);
        }

        public List<Comment> TGetAll()
        {
            return _commentDal.GetAll();
        }

        public Comment TGetById(int id)
        {
            return _commentDal.GetById(id);
        }

        public List<Comment> TGetCommentsByArticalsId(int id)
        {
            return _commentDal.GetCommentsByArticalsId(id);
        }

        public void TInsert(Comment entity)
        {
           _commentDal.Insert(entity);
        }

        public void TUpdate(Comment entity)
        {
           _commentDal.Update(entity);
        }
    }
}

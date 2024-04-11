﻿using FR.BusinessObjects.DataContext;
using FR.BusinessObjects.Models;
using FR.DataAccess.Base;
using FR.DataAccess.DAO;
using Microsoft.EntityFrameworkCore;

namespace FR.DataAccess.DAOimpl
{
    public class TableStatusDAO : BaseDAO<TableStatus>, ITableStatusDAO
    {
        public TableStatusDAO(DBContext context) : base(context)
        {
        }

        //public TableStatus GetTableStatusById(int id)
        //{
        //    return _context.TableStatus.SingleOrDefault(s => s.Id == id);
        //}
        //public List<TableStatus> GetAllTableStatus()
        //{
        //    return _context.TableStatus.ToList();
        //}
        public Task<TableStatus> GetTableStatusById(int id)
        {
            return _context.TableStatus.SingleOrDefaultAsync(s => s.Id == id);
        }
    }
}

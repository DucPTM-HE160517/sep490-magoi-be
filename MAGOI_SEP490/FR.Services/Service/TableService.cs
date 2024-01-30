﻿using FR.BusinessObjects.Models;
using FR.DataAccess;
using FR.Services.GraphQL.InputTypes;
using FR.Services.IService;

namespace FR.Services.Service
{
    public class TableService : ITableService
    {
        private readonly TableDAO _dao;
        public TableService(TableDAO dao)
        {
            _dao = dao;
        }

        public List<Table> GetTables()
        {
            return _dao.GetTables();
        }

        public Table GetTable(Guid id) {
            return _dao.GetTable(id);
	    }

        public void UpdateTableStatus(Guid tableId, TableStatusId statusId) {
            _dao.UpdateTableStatus(tableId, statusId);
	    }

        public void UpdateTableStatusWhenCreateOrder(Guid tableId)
        {
            Table table = GetTable(tableId);
            if (table.StatusId == (int)TableStatusId.Available)
            {
                UpdateTableStatus(tableId, TableStatusId.Serving);
            }
        }
    }
}

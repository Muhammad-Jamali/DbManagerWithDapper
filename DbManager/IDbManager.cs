using System;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
using Dapper;

namespace DbManager
{
    public interface IDbManager : IDisposable
    {
        public IDbConnection GetConnection();
        public IDbTransaction GetTransaction();
        public void OpenConnection();
        public void BeginTransaction();
        public void CommitTransaction();

        public void CommitTransactionAndDispose();
        public void RollbackTransaction();
        public void RollbackTransactionAndDispose();

        public void DisposeConnection();

        public Task<IEnumerable<T>> QueryListAsync<T>(string sql, DynamicParameters parameters = null,
            CommandType commandType = CommandType.StoredProcedure);

        public Task<IEnumerable<T>> QueryListWithOutTransactionAsync<T>(string sql, DynamicParameters parameters = null,
            CommandType commandType = CommandType.StoredProcedure);

        public IEnumerable<T> QueryListWithOutTransaction<T>(string sql, DynamicParameters parameters = null,
            CommandType commandType = CommandType.StoredProcedure);

        public IEnumerable<T> QueryList<T>(string sql, DynamicParameters parameters = null,
            CommandType commandType = CommandType.StoredProcedure);

        public Task<T> QueryAsync<T>(string sql, DynamicParameters parameters = null,
            CommandType commandType = CommandType.StoredProcedure);

        public Task<T> QueryWithOutTransactionAsync<T>(string sql, DynamicParameters parameters = null,
            CommandType commandType = CommandType.StoredProcedure);

        public T QueryWithOutTransaction<T>(string sql, DynamicParameters parameters = null,
            CommandType commandType = CommandType.StoredProcedure);

        public T Query<T>(string sql, DynamicParameters parameters = null,
            CommandType commandType = CommandType.StoredProcedure);

        public Task<bool> ExecuteAsync(string sp, DynamicParameters parameters = null,
            CommandType commandType = CommandType.StoredProcedure);
    }
}
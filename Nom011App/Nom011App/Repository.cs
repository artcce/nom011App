using System;
using System.Collections.Generic;

using SQLite;
using System.Threading.Tasks;
using System.Linq.Expressions;
using System.Linq;
using Nom011App.Database;
using Nom011App.Services;
using Xamarin.Forms;
using Nom011.ModelDatabase;

namespace Nom011
{
    public interface IRepository<T> where T : class, new()
    {
        List<T> Get();
        T Get(int id);
        List<T> Get<TValue>(Expression<Func<T, bool>> predicate = null, Expression<Func<T, TValue>> orderBy = null);
        T Get(Expression<Func<T, bool>> predicate);
        TableQuery<T> AsQueryable();
        int Insert(T entity);
        int Update(T entity);
        int Delete(T entity);
    }

    public class Repository<T> : IRepository<T> where T : class, new()
    {
        static readonly Lazy<SQLiteConnection> _databaseConnectionHolder = new Lazy<SQLiteConnection>(() =>
           DependencyService.Get<ISQLite>().GetConnection());
        static SQLiteConnection DatabaseConnection => _databaseConnectionHolder.Value;

        public Repository()
        {
        }

        public TableQuery<T> AsQueryable()
        {
            using (var db=DatabaseConnection)
            {
                return db.Table<T>();
            }
        }

        public List<T> Get()
        {
            using (var db = DatabaseConnection)
            {
                return db.Table<T>().ToList();
            }
        }

        public  List<T> Get<TValue>(Expression<Func<T, bool>> predicate = null, Expression<Func<T, TValue>> orderBy = null)
        {
            using (var db = DatabaseConnection)
            {
                var query = db.Table<T>();

                if (predicate != null)
                    query = query.Where(predicate);

                if (orderBy != null)
                    query = query.OrderBy<TValue>(orderBy);

                return query.ToList();
            }
        }

        public T Get(int id)
        {
            using (var db = DatabaseConnection)
            {
                return db.Find<T>(id);
            }
        }

        public T Get(Expression<Func<T, bool>> predicate)
        {
            using (var db = DatabaseConnection)
            {
                return db.Find<T>(predicate);
            }
        }

        public int Insert(T entity)
        {
            using (var db = DatabaseConnection)
            {

                try
                {
                    db.Insert(new Verificador()
                    {
                        NoId = "avc 2",
                        Nombre = "arturo 2 "
                    });
                }
                catch (Exception ex)
                {

                    int a = 0;
                }
                try
                {

                    return db.Insert(entity);
                }
                catch (Exception ex) 
                {
                    return 0;
                }

            }
        }

        public int Update(T entity)
        {
            using (var db = DatabaseConnection)
            {
                return db.Update(entity);
            }
        }

        public int Delete(T entity)
        {
            using (var db = DatabaseConnection)
            {
                return db.Delete(entity);
            }
        }
    }
}

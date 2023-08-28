using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace HR_DataBase

//اسم الوعاء الذي بداخله الداتا بيس كاملة  نجده في 
/*ملف الانتتي .edmx 
ثم ملف الانتتي .context.tt
ثم ملف الانتتي .context.cs */
{
    public class ClsCommander<TEntity> : ICommander<TEntity> where TEntity : class
    {
        public static SMART_HR_DB_2023Entities Context = new SMART_HR_DB_2023Entities();
        public void Delet_Data(TEntity entity)
        {
            Context.Set<TEntity>().Remove(entity);
            Context.SaveChanges();
        }

        public IEnumerable<TEntity> Get_All()
        {
            return Context.Set<TEntity>().ToList();
        }

        public IEnumerable<TEntity> Get_By(Expression<Func<TEntity, bool>> p)
        {
            return Context.Set<TEntity>().Where(p);
        }

        public void Insert_Data(TEntity entity)
        {
            Context.Set<TEntity>().Add(entity);
            Context.SaveChanges();
            //يعني خذ من الداتا بيس التي انتتي الي معرفو ك براميتر و ضفلو الانتتي 
            //السيت لتحديد اي جدول سنتعامل معه من الداتا يس
        }

        public IEnumerable<TEntity> Max_Id(Expression<Func<TEntity, bool>> p)
        {
            return Context.Set<TEntity>().Where(p);
        }

        public void Update_Data(TEntity entity)
        {
            Context.Set<TEntity>().AddOrUpdate(entity);
            Context.SaveChanges();
        }
    }
}

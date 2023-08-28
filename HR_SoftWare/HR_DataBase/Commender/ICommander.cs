using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;//من اجل الاكسبريشن

namespace HR_DataBase
{
    //الكومندر هو المحرك و الدينمو تبع الانتتي فريم ورك

    //الهدف منها عمل اوبجكت جاهزة لعمل كل شي نريد بنائه يكون موجود داخلها
    //فيها كل التوابع التي كننا ننشئها بالداتا سيت
    //insert/update/delete/max/getall/getby
    public interface ICommander<TEntity>
    {
        //نوع الداتا التي تمر داخل الانترفس هو Tentity
        //لاستخدام الانترفيس نعمل منها انستنس اوبجكت مثل الكلاس

        //Tentity   هو نوع جدول من الانتتي
        void Insert_Data(TEntity entity);//لايعيد قيمة و نرسل له براميتر من نوع تي انتتي
        void Update_Data(TEntity entity);
        void Delet_Data(TEntity entity);
        IEnumerable<TEntity> Get_All();//يعيد قيمة
                                       //ايمبريل
                                       //هذا النوع لانها تعيد قيمة هذه خاصة بالبيانات العائدة من النتتي فريمورك
        IEnumerable<TEntity> Get_By(Expression<Func<TEntity, bool>> p);
        //تابع يعيد قيمة من نوع تي انتتي
        //نمرر له اكسبريشن من نوع فانكشن خاص بالانتتي فريمورك و نوع الفانكشن تي انتتي
        //بوليان لنرى النتيجة هل  رجع داتا او لا
        // البي هي اسم الاكسبريشن
        IEnumerable<TEntity> Max_Id(Expression<Func<TEntity, bool>> p);
    }
}

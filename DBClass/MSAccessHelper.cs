using System.Data;
using System.Data.OleDb;
/*
 * SUM_STRING
DataSet.Expression = "ISNull([Family], '') + ' ' + ISNull([FirstName], '')+' '+ISNull([LastName], '')"

 * Parent
DataSet.Expression = "Parent([RK_Customer_Users]).[NameCust]"

 * Обеспечение целостности данных при NewAdd()
 * При создании новой записи в главной таблице создаются новые записи в подчиненных таблицах
 Нужно в схеме вручную установить значения инкремента для поля ID (по умолчанию -1; 
 поле ID из главной не передает значение в подчиненым)
 AutoIncrementSeed = 1 (начало)
 AutoIncrementStep = 1 (шаг)

* Отношения
Все отношения устанавливаем на уровне базы данных. В схеме НЕ дублируем

*/
namespace DBClass
{
    internal class MSAccessHelper
    {
        private readonly OleDbConnection con;

        public MSAccessHelper(string connectionStr)
        {
            con = new OleDbConnection(connectionStr);
        }

        public bool IsConnection // свойство объекта
        {
            get
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                return true;
            }
        }




    }
}

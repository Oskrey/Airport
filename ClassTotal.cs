using System.Data.SqlClient;

namespace Аэропорт
{
    public static class ClassTotal
    {
        public static string connectionString = @"Data Source=LapTop, 1433;Initial Catalog=Практика;User ID=testo;Password=testo;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";  //Строка подключения
        public static SqlConnection connection;
        public static int id;
        public static int idRole;
        public enum Mode { Просмотр, Редактирование, Добавление };
    }
}

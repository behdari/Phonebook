//using Dapper;
//using System.Data.SqlClient;

//namespace Phonebook.Resources
//{
//    public class CategoryRepository
//    {
//        private string connectionString = "Data Source=.;Initial Catalog=PhoneBookDb;Persist Security Info=True;User ID=sa;Password=12qwAS!@";

//        private static CategoryRepository _instance;
//        public static CategoryRepository Instance
//        {
//            get { return _instance ??= new CategoryRepository(); }
//        }

//        public List<Category> GetAllCategories()
//        {
//            var existQuery = $@"
//                            SELECT *
//                          FROM [PhoneBookDb].[dbo].[Category]";

//            List<Category> result;

//            using (var connection = new SqlConnection(connectionString))
//            {
//                result = connection.Query<Category>(existQuery).ToList();
//            }

//            return result;
//        }
//    }
//}

using Dapper;
using System.Data.SqlClient;

namespace Phonebook.Resources
{
    public class PhonebookRepository
    {
        private string connectionString = "Data Source=192.168.1.109,1433;Initial Catalog=PhoneBookDb;Persist Security Info=True;User ID=sa;Password=12qwAS!@";

        private static PhonebookRepository _instance;
        public static PhonebookRepository Instance
        {
            get { return _instance ??= new PhonebookRepository(); }
        }

        public bool IsExist(PhonebookRecord phonebookRecord)
        {
            return IsExist(phonebookRecord.MobileNumber);
        }

        public bool IsExist(string mobileNumber)
        {
            var existQuery = $@"
    SELECT *
  FROM [PhoneBookDb].[dbo].[PhoneBook]
  where MobileNumber = N'{mobileNumber}'";

            PhonebookRecord result;

            using (var connection = new SqlConnection(connectionString))
            {
                result = connection.QuerySingleOrDefault<PhonebookRecord>(existQuery);
            }

            return result != null;
        }

        public PhonebookRecord GetPhonebookRecordByMobileNumber(string mobileNumber)
        {
            var existQuery = $@"
    SELECT *
  FROM [PhoneBookDb].[dbo].[PhoneBook]
  where MobileNumber = N'{mobileNumber}'";

            PhonebookRecord result;

            using (var connection = new SqlConnection(connectionString))
            {
                result = connection.QuerySingleOrDefault<PhonebookRecord>(existQuery);
            }

            return result;
        }

        public PhonebookRecord GetPhonebookRecordById(Guid id)
        {
            var existQuery = $@"
    SELECT *
  FROM [PhoneBookDb].[dbo].[PhoneBook]
  where [Id] = N'{id}'";

            PhonebookRecord result;

            using (var connection = new SqlConnection(connectionString))
            {
                result = connection.QuerySingleOrDefault<PhonebookRecord>(existQuery);
            }

            return result;
        }

        public List<PhonebookRecord> GetTopPhonebookRecord(int number)
        {
            var existQuery = $@"
                            SELECT TOP ({number}) [Id]
                              ,[CategoryIds]
                              ,[FirstName]
                              ,[LastName]
                              ,[Organization]
                              ,[LandlineNumber]
                              ,[MobileNumber]
                              ,[FaxNumber]
                              ,[TelegramNumber]
                              ,[Description]
                          FROM [PhoneBookDb].[dbo].[PhoneBook]";

            List<PhonebookRecord> result;

            using (var connection = new SqlConnection(connectionString))
            {
                result = connection.Query<PhonebookRecord>(existQuery).ToList();
            }

            return result;
        }

        internal List<PhonebookRecord> SearchByWordAndCategoryIds(string text, List<int> categoryIds)
        {
            var categoryIdsString = string.Join(",", categoryIds);

            var existQuery = $@"SELECT 
                                  TOP (100) [Id], 
                                  [CategoryIds], 
                                  [FirstName], 
                                  [LastName], 
                                  [Organization], 
                                  [LandlineNumber], 
                                  [MobileNumber], 
                                  [FaxNumber], 
                                  [TelegramNumber], 
                                  [Description] 
                                FROM 
                                  [dbo].[PhoneBook] 
                                WHERE 
                                  id IN (
                                    SELECT 
                                      DISTINCT PhoneBookId 
                                    FROM 
                                      [dbo].[PhoneBookCategories] PC 
                                      INNER JOIN [dbo].[Category] C ON PC.CategoryId = C.Id 
                                    WHERE 
                                      C.Id IN ({categoryIdsString})
                                  ) 
                                  AND (
                                    [FirstName] like N'%{text}%' 
                                    OR [Id] like N'%{text}%' 
                                    OR [CategoryIds] like N'%{text}%' 
                                    OR [LastName] like N'%{text}%' 
                                    OR [Organization] like N'%{text}%' 
                                    OR [LandlineNumber] like N'%{text}%' 
                                    OR [MobileNumber] like N'%{text}%' 
                                    OR [FaxNumber] like N'%{text}%' 
                                    OR [TelegramNumber] like N'%{text}%' 
                                    OR [Description] like N'%{text}%'
                                  )";

            List<PhonebookRecord> result;

            using (var connection = new SqlConnection(connectionString))
            {
                result = connection.Query<PhonebookRecord>(existQuery).ToList();
            }

            return result;
        }

        internal void Add(PhonebookRecord entity)
        {
            var insertQuery = $@"
    INSERT INTO [dbo].[PhoneBook]
               ([Id]
              ,[CategoryIds]
              ,[FirstName]
              ,[LastName]
              ,[Organization]
              ,[LandlineNumber]
              ,[MobileNumber]
              ,[FaxNumber]
              ,[TelegramNumber]
              ,[Description])
         VALUES
               (@Id,
                @CategoryIds,
                @FirstName,
                @LastName,
                @Organization,
                @LandlineNumber,
                @MobileNumber,
                @FaxNumber,
                @TelegramNumber,
                @Description)";

            using (var connection = new SqlConnection(connectionString))
            {
                var result = connection.Execute(insertQuery, new
                {
                    entity.Id,
                    entity.CategoryIds,
                    entity.FirstName,
                    entity.LastName,
                    entity.Organization,
                    entity.LandlineNumber,
                    entity.MobileNumber,
                    entity.FaxNumber,
                    entity.TelegramNumber,
                    entity.Description,
                });
            }
        }

        internal void AddPhoneBookCategories(Guid phonebookId, string categoryIds)
        {
            var categoryIdList = categoryIds.Split(',');

            foreach (var categoryId in categoryIdList)
            {
                var insertQuery = @$"INSERT INTO[dbo].[PhoneBookCategories]
                                           ([CategoryId]
                                           ,[PhoneBookId])
                                     VALUES
                                           (@CategoryId,
                                            @PhoneBookId)";

                using (var connection = new SqlConnection(connectionString))
                {
                    var result = connection.Execute(insertQuery, new
                    {
                        categoryId,
                        phonebookId
                    });
                }
            }
        }

        internal void Delete(Guid id)
        {
            var deleteQuery = $@"
                            DELETE FROM [dbo].[PhoneBook]
                                  WHERE [Id] = @Id";

            using (var connection = new SqlConnection(connectionString))
            {
                var result = connection.Execute(deleteQuery, new
                {
                    id
                });
            }
        }

        internal void Update(PhonebookRecord entity)
        {
            var insertQuery = $@"
                        UPDATE [dbo].[PhoneBook]
                           SET [Id] = @Id
                              ,[CategoryIds] = @CategoryIds
                              ,[FirstName] = @FirstName
                              ,[LastName] = @LastName
                              ,[Organization] = @Organization
                              ,[LandlineNumber] = @LandlineNumber
                              ,[MobileNumber] = @MobileNumber
                              ,[FaxNumber] = @FaxNumber
                              ,[TelegramNumber] = @TelegramNumber
                              ,[Description] = @Description
                         WHERE [Id] = @Id";

            using (var connection = new SqlConnection(connectionString))
            {
                var result = connection.Execute(insertQuery, new
                {
                    entity.Id,
                    entity.CategoryIds,
                    entity.FirstName,
                    entity.LastName,
                    entity.Organization,
                    entity.LandlineNumber,
                    entity.MobileNumber,
                    entity.FaxNumber,
                    entity.TelegramNumber,
                    entity.Description,
                });
            }
        }

        internal void UpdatePhoneBookCategories(Guid phonebookId, string categoryIds)
        {
            var deleteQuery = $@"
                            DELETE FROM [dbo].[PhoneBookCategories]
                                  WHERE [PhoneBookId] = @PhoneBookId";

            using (var connection = new SqlConnection(connectionString))
            {
                var result = connection.Execute(deleteQuery, new
                {
                    PhoneBookId = phonebookId
                });
            }

            AddPhoneBookCategories(phonebookId, categoryIds);
        }
    }
}

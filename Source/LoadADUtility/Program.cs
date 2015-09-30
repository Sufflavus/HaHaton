using System;
using System.DirectoryServices.AccountManagement;
using MarksDal;
using MarksSite.Extensions;

namespace LoadADUtility
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var repository = new Repository();
            repository.CreateDatabase();
            using (var context = new PrincipalContext(ContextType.Domain, "infotecs-nt", "lr.knowledge.base", ",jrcnfgjx"))
            {
                UserPrincipal u = new UserPrincipal(context);
                PrincipalSearcher search = new PrincipalSearcher(u);
                foreach (UserPrincipal result in search.FindAll())
                {
                    repository.AddUsers(new[]
                    {
                        new User()
                        {
                            FirstName = result.DisplayName ?? string.Empty,
                            LastName = string.Empty,
                            MiddleName = string.Empty,
                            ActiveDirectoryId = @"infotecs-nt\" + result.SamAccountName,
                            IsManager = result.IsManager()
                        }
                    });
                    Console.WriteLine(string.Format("Добавлен пользователь: {0}", result.DisplayName));
                    repository.Save();
                }
            }
        }
    }
}

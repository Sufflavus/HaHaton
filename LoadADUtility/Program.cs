using MarksDal;
using MarksSite.Extensions;
using System;
using System.Collections.Generic;
using System.DirectoryServices.AccountManagement;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoadADUtility
{
    class Program
    {
        static void Main(string[] args)
        {
            var repository = new Repository();

            using (var context = new PrincipalContext(ContextType.Domain, "infotecs-nt", "lr.knowledge.base", ",jrcnfgjx"))
            {
                using (UserPrincipal userPrincipal = UserPrincipal.FindByIdentity(context, @"infotecs-nt\lyapin.nikita"))
                {
                    UserPrincipal u = new UserPrincipal(context);
                    PrincipalSearcher search = new PrincipalSearcher(u);
                    foreach (UserPrincipal result in search.FindAll())
                    {
                        repository.AddUsers(new[] { new User()
                        {
                            FirstName = result.DisplayName ?? string.Empty,
                            LastName = string.Empty,
                            MiddleName = string.Empty,
                            ActiveDirectoryId = @"infotecs-nt\"+result.SamAccountName,
                            IsManager = result.IsManager()
                        } });
                        Console.WriteLine(string.Format("Добавлен пользователь: {0}", result.DisplayName));
                        repository.Save();
                    }
                }
            }
        }
    }
}

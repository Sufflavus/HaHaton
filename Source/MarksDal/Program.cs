using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MarksDal
{
    class Program
    {
        static void Main(string[] args)
        {
            var repository = new Repository();
            repository.CreateDatabase();

            CreateUsersWithParent(repository);
            CreateMark(repository);
            CreateMarkRequest(repository);
        }

        private static void CreateMarkRequest(Repository repository)
        {
            //repository.AddUsers(new[] {new MarkRequest()
            //{
            //    AuthorId = repository.GetUsers().Where(i => i.Id == 2).First()
            //    //ActiveDirectoryId = "Infotecs-nt/dd",
            //    //FirstName = "dd",
            //    //LastName = "ddd",
            //    //MiddleName = "ddd",
            //    //Parent = repository.GetUsers().Where(i => i.Id == 2).First()
            //}});
            //repository.Save();

            //Console.WriteLine(repository.GetUsers().Count);
        }

        private static void CreateUsersWithParent(Repository repository)
        {
            repository.AddUsers(new[] {new User
            {
                ActiveDirectoryId = "Infotecs-nt/dd",
                FirstName = "dd",
                LastName = "ddd",
                MiddleName = "ddd",
                IsManager = false
               // Parent = repository.GetUsers().Where(i => i.Id == 2).First()
            }});
            repository.Save();

            Console.WriteLine(repository.GetUsers().Count);
        }

        private static void CreateMark(Repository repository)
        {
            repository.AddMarks(new[] {new Mark
            {
                Json = "bla-bla json",
                DateTime = DateTime.Now,
                From = repository.GetUsers().First(),
                To = repository.GetUsers().Last(),
            }});
            repository.Save();

            Console.WriteLine(repository.GetUsers().Count);
        }
    }
}

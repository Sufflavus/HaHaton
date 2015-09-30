using System.Collections.Generic;
using System.DirectoryServices;
using System.DirectoryServices.AccountManagement;
using System.Linq;

namespace MarksSite.Extensions
{
    public static class PrincipalExtensions
    {
        private static readonly List<string> managerGroups = new List<string>
            {
                "Project Management"
            };

        public static string GetDepartment(this Principal principal)
        {
            return principal.GetProperty("department");
        }

        public static string GetJobPosition(this Principal principal)
        {
            return principal.GetProperty("title");
        }

        public static string GetManager(this Principal principal)
        {
            return principal.GetProperty("manager");
        }

        public static PropertyCollection GetProperties(this Principal principal)
        {
            var directoryEntry = (DirectoryEntry) principal.GetUnderlyingObject();
            return directoryEntry.Properties;
        }

        public static string GetProperty(this Principal principal, string property)
        {
            var directoryEntry = (DirectoryEntry) principal.GetUnderlyingObject();
            if (directoryEntry.Properties.Contains(property))
            {
                return directoryEntry.Properties[property].Value.ToString();
            }
            return string.Empty;
        }

        public static bool IsManager(this Principal principal)
        {
            string distinguishedName = DistinguishedName(principal);
            return managerGroups.Any(distinguishedName.Contains);
        }

        private static string DistinguishedName(this Principal principal)
        {
            return principal.GetProperty("distinguishedName");
        }
    }
}
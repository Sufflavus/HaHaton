using System.Configuration;

namespace MarksSite
{
    public static class ConfigurationWrapper
    {
        public static string GetAdDomain()
        {
            return ConfigurationManager.AppSettings["AdDomain"];
        }

        public static string GetAdLogin()
        {
            return ConfigurationManager.AppSettings["AdLogin"];
        }
        
        public static string GetAdPassword()
        {
            return ConfigurationManager.AppSettings["AdPassword"];
        }
    }
}
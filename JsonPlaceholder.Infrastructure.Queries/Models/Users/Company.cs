using System;

namespace JsonPlaceholder.Infrastructure.Queries.Models.Users
{
    public class Company
    {
        public string Name { get; set; }
        public string CatchPhrase { get; set; }
        public string Bs { get; set; }

        public static Company From(Repositories.Users.Models.Company company)
        {
            return new Company
            {
                Name = company.Name,
                CatchPhrase = company.CatchPhrase,
                Bs = company.Bs
            };
        }
    }
}

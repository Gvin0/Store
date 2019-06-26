using Store.Domain.Domains;
using Store.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Services
{
    public class AdminUserService : BaseService<AdminUser, IAdminUserRepository>, IAdminUserService

    {
        private IAdminUserRepository _adminUserRepository;
        public AdminUserService(IAdminUserRepository adminUserRepository) : base(adminUserRepository)
        {
            _adminUserRepository = adminUserRepository ?? throw new ArgumentNullException("AdminUser Injection Failed");
        }
    }
}

using Store.Domain.Domains;
using Store.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Services {
	public class AdminUserService : BaseService<AdminUser, IAdminUserRepository>, IAdminUserService {
		public AdminUserService(IAdminUserRepository repository) : base(repository) {

		}
	}
}

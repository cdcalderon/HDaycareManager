using System.Collections.Generic;
using System.Threading.Tasks;
using HDaycareManager.Core.Model;

namespace HDaycareManager.Core.Contracts.Repository
{
	public interface IKidRepository
	{
		Task<List<Kid>> GetAllKids();
		Task<Kid> GetKidById(int kidId);
	}
}

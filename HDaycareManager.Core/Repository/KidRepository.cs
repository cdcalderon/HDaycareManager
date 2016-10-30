using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HDaycareManager.Core.Model;
using HDaycareManager.Core.Contracts.Repository;

namespace HDaycareManager.Core.Repository
{
	public class KidRepository : BaseRepository, IKidRepository
	{
		private static readonly List<Kid> AllKids = new List<Kid>
		{
			new Kid
			{
				FirstName = "Carlos",
				LastName = "Calderon"
			},
			new Kid
			{
				FirstName = "Lorena",
				LastName = "Legaspy"
			},
			new Kid
			{
				FirstName = "Coky",
				LastName = "Calderon"
			}
		};

		public async Task<List<Kid>> GetAllKids()
		{
			return await Task.FromResult(AllKids);
		}

		public async Task<Kid> GetKidById(int kidId)
		{
			return await Task.FromResult(AllKids.FirstOrDefault(k => k.KidId == kidId));
		}
	}
}

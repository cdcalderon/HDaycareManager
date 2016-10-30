using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using HDaycareManager.Core.Contracts.Services;
using HDaycareManager.Core.Model;
using HDaycareManager.Core.Contracts.Repository;

namespace HDaycareManager.Core.Service
{
	public class KidDataService : IKidDataService
	{
		private readonly IKidRepository _kidRepository;

		public KidDataService(IKidRepository kidRepository)
		{
			_kidRepository = kidRepository;
		}

		public virtual async Task<List<Kid>> GetKids()
		{
			return await _kidRepository.GetAllKids();
		}

	}
}

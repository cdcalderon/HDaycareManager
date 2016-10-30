using System;
using HDaycareManager.Core.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HDaycareManager.Core.Contracts.Services
{
	public interface IKidDataService
	{
		Task<List<Kid>> GetKids();
	}
}

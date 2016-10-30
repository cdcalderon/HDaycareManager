using System;
namespace HDaycareManager.Core.Model
{
	public class Kid
	{
		public int KidId
		{
			get;
			set;
		}

		public string FirstName
		{
			get;
			set;
		}

		public string LastName
		{
			get;
			set;
		}

		public override string ToString()
		{
			return string.Format("[Kid: KidId={0}, FirstName={1}, LastName={2}]", KidId, FirstName, LastName);
		}
	}
}

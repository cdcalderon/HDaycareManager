using System.Threading.Tasks;
namespace HDaycareManager.Core.Contracts.Services
{
	public interface IDialogService
	{
		Task ShowAlertAsync(string message, string title, string buttonText);
	}
}

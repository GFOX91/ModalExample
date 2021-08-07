using Blazored.Modal;
using Blazored.Modal.Services;
using Microsoft.AspNetCore.Components;
using ModalExample.Shared;

namespace ModalExample.Client.Pages.Modals
{
	public partial class AddOrganisation
	{
		[CascadingParameter]
		public BlazoredModalInstance ModalInstance { get; set; }

		[Parameter]
		public Organisation Organisation { get; set; }

		protected void Submit()
		{
			ModalInstance.CloseAsync(ModalResult.Ok(Organisation));
		}

		protected void Cancel()
		{
			ModalInstance.CancelAsync();
		}

	}
}

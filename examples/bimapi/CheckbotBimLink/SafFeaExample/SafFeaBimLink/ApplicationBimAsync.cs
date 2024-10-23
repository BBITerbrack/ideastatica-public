﻿using IdeaRS.OpenModel;
using IdeaStatiCa.Diagnostics;
using IdeaStatiCa.Plugin;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SafFeaBimLink
{
	internal abstract class ApplicationBIMAsync : ApplicationBIM
	{
		private static readonly IIdeaLogger _logger = IdeaDiagnostics.GetLogger("ideastatica.ideafemdesignplugin.applicationbimasync");

		public override void ActivateInBIM(List<BIMItemId> items)
		{
			try
			{
				ActivateInBIMAsync(items).GetAwaiter().GetResult();
			}
			catch (Exception e)
			{
				_logger.LogError("ActivateInBIM failed", e);
			}
		}

		protected override ModelBIM ImportActive(CountryCode countryCode, RequestedItemsType requestedType)
		{
			try
			{
				return ImportActiveAsync(countryCode, requestedType).GetAwaiter().GetResult();
			}
			catch (Exception e)
			{
				_logger.LogError("ImportActive failed", e);
			}

			return null;
		}

		protected override List<ModelBIM> ImportSelection(CountryCode countryCode, List<BIMItemsGroup> items)
		{
			try
			{
				List<ModelBIM> result = ImportSelectionAsync(countryCode, items).GetAwaiter().GetResult();

				if (result != null)
				{
					return result;
				}
				else
				{
					_logger.LogInformation("ImportSelectionAsync returned null");
				}
			}
			catch (Exception e)
			{
				_logger.LogError("ImportActive failed", e);
			}

			return new List<ModelBIM>();
		}

		protected abstract Task ActivateInBIMAsync(List<BIMItemId> items);

		protected abstract Task<ModelBIM> ImportActiveAsync(CountryCode countryCode, RequestedItemsType requestedType);

		protected abstract Task<List<ModelBIM>> ImportSelectionAsync(CountryCode countryCode, List<BIMItemsGroup> items);
	}
}

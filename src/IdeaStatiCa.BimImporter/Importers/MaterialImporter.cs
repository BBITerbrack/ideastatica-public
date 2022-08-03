﻿using IdeaRS.OpenModel;
using IdeaRS.OpenModel.Material;
using IdeaStatiCa.BimApi;
using IdeaStatiCa.Plugin;
using System;

namespace IdeaStatiCa.BimImporter.Importers
{
	internal class MaterialImporter : AbstractImporter<IIdeaMaterial>
	{
		private IImportContext contex;
		public MaterialImporter(IPluginLogger logger) : base(logger)
		{
		}

		protected override OpenElementId ImportInternal(IImportContext ctx, IIdeaMaterial material)
		{
			contex = ctx;
			switch (material)
			{
				case IIdeaMaterialByName materialByName:
					return CreateMaterialByName(materialByName);

				case IIdeaMaterialSteel matSteal:
					return CreateMaterialSteel(matSteal);

				case IIdeaMaterialConcrete matConcrete:
					return CreateMaterialConcrete(matConcrete);
			}

			Logger.LogError($"Material '{material.Id}' is of unsupported type '{material.GetType().Name}'.");
			throw new ConstraintException($"Material '{material.Id}' is of unsupported type '{material.GetType().Name}'.");
		}

		private OpenElementId CreateMaterialConcrete(IIdeaMaterialConcrete matConcrete)
		{
			Logger.LogTrace($"Importing concrete material '{matConcrete.Id}'.");

			MatConcrete mat = matConcrete.Material;

			if (mat.Name == null)
			{
				mat.Name = matConcrete.Name;
			}

			return mat;
		}

		private OpenElementId CreateMaterialSteel(IIdeaMaterialSteel matSteal)
		{
			Logger.LogTrace($"Importing steel material '{matSteal.Id}'.");

			MatSteel mat = matSteal.Material;

			if (mat.Name == null)
			{
				mat.Name = matSteal.Name;
			}

			return mat;
		}

		private OpenElementId CreateMaterialByName(IIdeaMaterialByName materialByName)
		{
			string name = materialByName.Name;
			MaterialType type = materialByName.MaterialType;

			Logger.LogTrace($"Importing material of type '{type}' by name '{materialByName.Id}'.");

			if (string.IsNullOrEmpty(name))
			{
				Logger.LogError($"Material '{materialByName.Id}' has empty/null name.");
				throw new ConstraintException($"Material '{materialByName.Id}' has empty/null name.");
			}

			Material mat = CreateMaterialFromType(materialByName.MaterialType);
			mat.LoadFromLibrary = true;
			mat.Name = name;

			return mat;
		}

		private Material CreateMaterialFromType(MaterialType matType)
		{
			// we use ECEN materials just as placeholders
			switch (matType)
			{
				case MaterialType.Concrete:
					{
						switch (contex.countryCode)
						{
							case CountryCode.India:
								return new MatConcreteIND();
							case CountryCode.SIA:
								return new MatConcreteSIA();
							case CountryCode.American:
								return new MatConcreteACI();
							case CountryCode.Canada:
								return new MatConcreteCAN();
							case CountryCode.Australia:
								return new MatConcreteAUS();
							case CountryCode.RUS:
								return new MatConcreteRUS();
							case CountryCode.CHN:
								return new MatConcreteCHN();
							case CountryCode.HKG:
								return new MatConcreteHKG();
							default:
								return new MatConcreteEc2();
						}
					}


				case MaterialType.Reinforcement:
					{
						switch (contex.countryCode)
						{
							case CountryCode.India:
								return new MatReinforcementIND();
							case CountryCode.American:
								return new MatReinforcementACI();
							case CountryCode.Canada:
								return new MatReinforcementCAN();
							case CountryCode.Australia:
								return new MatReinforcementAUS();
							case CountryCode.RUS:
								return new MatReinforcementRUS();
							case CountryCode.CHN:
								return new MatReinforcementCHN();
							case CountryCode.HKG:
								return new MatReinforcementHKG();
							default:
								return new MatReinforcementEc2();
						}

					}

				case MaterialType.Steel:
					{
						switch (contex.countryCode)
						{
							case CountryCode.India:
								return new MatSteelIND();
							case CountryCode.American:
								return new MatSteelAISC();
							case CountryCode.Canada:
								return new MatSteelCISC();
							case CountryCode.Australia:
								return new MatSteelAUS();
							case CountryCode.RUS:
								return new MatSteelRUS();
							case CountryCode.CHN:
								return new MatSteelCHN();
							case CountryCode.HKG:
								return new MatSteelHKG();
							default:
								return new MatSteelEc2();
						}
					}
			}

			// if we got here then someone forgot to implement something
			throw new NotImplementedException();
		}
	}
}
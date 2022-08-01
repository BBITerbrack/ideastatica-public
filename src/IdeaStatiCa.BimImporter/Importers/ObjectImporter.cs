﻿using IdeaRS.OpenModel;
using IdeaRS.OpenModel.Connection;
using IdeaStatiCa.BimApi;
using IdeaStatiCa.Plugin;
using System;

namespace IdeaStatiCa.BimImporter.Importers
{
	internal class ObjectImporter : IImporter<IIdeaObject>
	{
		private readonly IImporter<IIdeaNode> _nodeImporter;
		private readonly IImporter<IIdeaMaterial> _materialImporter;
		private readonly IImporter<IIdeaCrossSection> _crossSectionImporter;
		private readonly IImporter<IIdeaSegment3D> _segmentImporter;
		private readonly IImporter<IIdeaElement1D> _elementImporter;
		private readonly IImporter<IIdeaMember1D> _memberImporter;
		private readonly IImporter<IIdeaConnectionPoint> _connectionImporter;
		private readonly IImporter<IIdeaLoadCase> _loadCaseImporter;
		private readonly IImporter<IIdeaLoadGroup> _loadGroupImporter;
		private readonly IImporter<IIdeaCombiInput> _combiInputImporter;
		private readonly IImporter<IIdeaConnectedMember> _connectedMemberImporter;
		private readonly IImporter<IIdeaPlate> _plateImporter;
		private readonly IImporter<IIdeaConnectedMember> _beamImporter;
		private readonly IImporter<IIdeaWeld> _weldImporter;
		private readonly IImporter<IIdeaBoltGrid> _boltGridImporter;
		private readonly IImporter<IIdeaAnchorGrid> _anchorGridImporter;
		private readonly IImporter<IIdeaCut> _cutImporter;
		private readonly IImporter<IIdeaConcreteBlock> _concreteBlockImporter;
		private readonly IImporter<IIdeaFoldedPlate> _foldedPlateImporter;


		public ObjectImporter(IPluginLogger logger)
		{
			_nodeImporter = new NodeImporter(logger);
			_materialImporter = new MaterialImporter(logger);
			_crossSectionImporter = new CrossSectionImporter(logger);
			_segmentImporter = new SegmentImporter(logger);
			_elementImporter = new ElementImporter(logger);
			_memberImporter = new MemberImporter(logger);
			_loadCaseImporter = new LoadCaseImporter(logger);
			_loadGroupImporter = new LoadGroupImporter(logger);
			_combiInputImporter = new CombiInputImporter(logger);
			_connectionImporter = new ConnectionImporter(logger);
			_connectedMemberImporter = new ConnectedMemberImporter(logger);
			_plateImporter = new PlateImporter(logger);
			_beamImporter = new BeamImporter(logger);
			_boltGridImporter = new BoltGridImporter(logger);
			_weldImporter = new WeldImporter(logger);
			_cutImporter = new CutImporter(logger);
			_concreteBlockImporter = new ConcreteBlockImporter(logger);
			_anchorGridImporter = new AnchorGridImporter(logger);
			_foldedPlateImporter = new FoldedPlateImporter(logger);

		}

		public OpenElementId Import(IImportContext ctx, IIdeaObject obj)
		{
			switch (obj)
			{
				case IIdeaNode node:
					return _nodeImporter.Import(ctx, node);

				case IIdeaMaterial material:
					return _materialImporter.Import(ctx, material);

				case IIdeaCrossSection css:
					return _crossSectionImporter.Import(ctx, css);

				case IIdeaSegment3D segment:
					return _segmentImporter.Import(ctx, segment);

				case IIdeaElement1D element:
					return _elementImporter.Import(ctx, element);

				case IIdeaConnectedMember connectedMember:
					return _connectedMemberImporter.Import(ctx, connectedMember);

				case IIdeaMember1D member:
					return _memberImporter.Import(ctx, member);

				case IIdeaConnectionPoint connection:
					return _connectionImporter.Import(ctx, connection);

				case IIdeaLoadCase loadCase:
					return _loadCaseImporter.Import(ctx, loadCase);

				case IIdeaLoadGroup loadGroup:
					return _loadGroupImporter.Import(ctx, loadGroup);
				case IIdeaCombiInput combiInput:
					return _combiInputImporter.Import(ctx, combiInput);
			}

			throw new ArgumentException($"Unsupported object type '{obj.GetType()}'");
		}

		public object Import(IImportContext ctx, IIdeaObject obj, ConnectionData connectionData)
		{
			switch (obj)
			{

				case IIdeaNegativePlate nPlate:
					return _plateImporter.Import(ctx, nPlate, connectionData);
				case IIdeaPlate plate:
					return _plateImporter.Import(ctx, plate, connectionData);
				case IIdeaFoldedPlate foldedPlate:
					return _foldedPlateImporter.Import(ctx, foldedPlate, connectionData);
				case IIdeaConnectedMember member:
					return _beamImporter.Import(ctx, member, connectionData);
				case IIdeaAnchorGrid anchorGrid:
					return _anchorGridImporter.Import(ctx, anchorGrid, connectionData);
				case IIdeaBoltGrid boltGrid:
					return _boltGridImporter.Import(ctx, boltGrid, connectionData);
				case IIdeaConcreteBlock concreteBlock:
					return _concreteBlockImporter.Import(ctx, concreteBlock, connectionData);
				case IIdeaWeld weld:
					return _weldImporter.Import(ctx, weld, connectionData);
				case IIdeaCut cut:
					return _cutImporter.Import(ctx, cut, connectionData);
			}

			throw new ArgumentException($"Unsupported object type '{obj.GetType()}'");
		}
	}
}
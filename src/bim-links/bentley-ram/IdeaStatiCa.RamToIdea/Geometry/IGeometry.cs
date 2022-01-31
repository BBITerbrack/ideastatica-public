﻿using IdeaStatiCa.RamToIdea.BimApi;
using RAMDATAACCESSLib;
using System.Collections.Generic;

namespace IdeaStatiCa.RamToIdea.Geometry
{
	internal interface IGeometry
	{
		Line CreateLine(SCoordinate start, SCoordinate end, bool allowsIntermediateNodes);

		void AddNodeToLine(Line line, SCoordinate position);

		void Initialize(IEnumerable<INode> nodes);
	}
}
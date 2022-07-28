﻿using IdeaRS.OpenModel.Geometry2D;

namespace IdeaRS.OpenModel.CrossSection
{
	/// <summary>
	/// CrossSectionFactory
	/// </summary>
	public static partial class CrossSectionFactory
	{
		/// <summary>
		/// Fill parameters for cold formed Z section
		/// </summary>
		/// <param name="css">Parameters of CrossSectionParameter will be filled</param>
		/// <param name="Width">Css width</param>
		/// <param name="Height">Height of cross-section</param>
		/// <param name="Thickness">Thickness</param>
		/// <param name="Radius">Inside radius</param>
		/// <param name="Mirror">Mirrored shape</param>
		public static void FillColdFormedZ(CrossSectionParameter css, double Width, double Height, double Thickness, double Radius, bool Mirror)
		{
			css.CrossSectionType = CrossSectionType.CFZ;
			css.Parameters.Add(new ParameterDouble() { Name = "Width", Value = Width });
			css.Parameters.Add(new ParameterDouble() { Name = "Height", Value = Height });
			css.Parameters.Add(new ParameterDouble() { Name = "Thickness", Value = Thickness });
			css.Parameters.Add(new ParameterDouble() { Name = "Radius", Value = Radius });
			css.Parameters.Add(new ParameterBool() { Name = "Mirror", Value = Mirror });
		}

		/// <summary>
		/// Fill parameters for cold formed C section
		/// </summary>
		/// <param name="css">Parameters of CrossSectionParameter will be filled</param>
		/// <param name="Width">Css width</param>
		/// <param name="Height">Height of cross-section</param>
		/// <param name="Thickness">Thickness</param>
		/// <param name="Radius">Inside radius</param>
		/// <param name="lip">Lip length</param>
		public static void FillColdFormedC(CrossSectionParameter css, double Width, double Height, double Thickness, double Radius, double lip)
		{
			css.CrossSectionType = CrossSectionType.CFC;
			css.Parameters.Add(new ParameterDouble() { Name = "Width", Value = Width });
			css.Parameters.Add(new ParameterDouble() { Name = "Height", Value = Height });
			css.Parameters.Add(new ParameterDouble() { Name = "Thickness", Value = Thickness });
			css.Parameters.Add(new ParameterDouble() { Name = "Radius", Value = Radius });
			css.Parameters.Add(new ParameterDouble() { Name = "Lip", Value = lip });
		}

		/// <summary>
		/// Fill parameters for cold formed C channel
		/// </summary>
		/// <param name="css">Parameters of CrossSectionParameter will be filled</param>
		/// <param name="Width">Css width</param>
		/// <param name="Height">Height of cross-section</param>
		/// <param name="Thickness">Thickness</param>
		/// <param name="Radius">Inside radius</param>
		public static void FillColdFormedChannel(CrossSectionParameter css, double Width, double Height, double Thickness, double Radius)
		{
			css.CrossSectionType = CrossSectionType.CFU;
			css.Parameters.Add(new ParameterDouble() { Name = "Width", Value = Width });
			css.Parameters.Add(new ParameterDouble() { Name = "Height", Value = Height });
			css.Parameters.Add(new ParameterDouble() { Name = "Thickness", Value = Thickness });
			css.Parameters.Add(new ParameterDouble() { Name = "InsideRadius", Value = Radius });
		}

		/// <summary>
		/// Fill parameters for cold formed Z-ed section
		/// </summary>
		/// <param name="css">Parameters of CrossSectionParameter will be filled</param>
		/// <param name="Width">Css width</param>
		/// <param name="Height">Height of cross-section</param>
		/// <param name="Thickness">Thickness</param>
		/// <param name="Radius">Inside radius</param>
		/// <param name="Lip">Lip length</param>
		/// <param name="Mirror">Mirrored shape</param>
		public static void FillColdFormedZed(CrossSectionParameter css, double Width, double Height, double Thickness, double Radius, double Lip, bool Mirror)
		{
			css.CrossSectionType = CrossSectionType.CFZed;
			css.Parameters.Add(new ParameterDouble() { Name = "Width", Value = Width });
			css.Parameters.Add(new ParameterDouble() { Name = "Height", Value = Height });
			css.Parameters.Add(new ParameterDouble() { Name = "Thickness", Value = Thickness });
			css.Parameters.Add(new ParameterDouble() { Name = "Radius", Value = Radius });
			css.Parameters.Add(new ParameterDouble() { Name = "Lip", Value = Lip });
			css.Parameters.Add(new ParameterBool() { Name = "Mirror", Value = Mirror });
		}

		/// <summary>
		/// Fill parameters for cold formed Omega section
		/// </summary>
		/// <param name="css">Parameters of CrossSectionParameter will be filled</param>
		/// <param name="Width">Css width</param>
		/// <param name="Height">Height of cross-section</param>
		/// <param name="FlangeWidth">Flange width</param>
		/// <param name="Thickness">Thickness</param>
		/// <param name="Radius">Inside radius</param>
		public static void FillColdFormedOmega(CrossSectionParameter css, double Width, double Height, double FlangeWidth, double Thickness, double Radius)
		{
			css.CrossSectionType = CrossSectionType.CFOmega;
			css.Parameters.Add(new ParameterDouble() { Name = "Width", Value = Width });
			css.Parameters.Add(new ParameterDouble() { Name = "Height", Value = Height });
			css.Parameters.Add(new ParameterDouble() { Name = "FlangeWidth", Value = FlangeWidth });
			css.Parameters.Add(new ParameterDouble() { Name = "Thickness", Value = Thickness });
			css.Parameters.Add(new ParameterDouble() { Name = "Radius", Value = Radius });
		}

		/// <summary>
		/// Fill parameters for cold formed L section
		/// </summary>
		/// <param name="css">Parameters of CrossSectionParameter will be filled</param>
		/// <param name="Width">Horizontal leg length</param>
		/// <param name="Height">Vertical leg length</param>
		/// <param name="Thickness">Thickness</param>
		/// <param name="Radius">Inside radius</param>
		public static void FillColdFormedL(CrossSectionParameter css, double Width, double Height, double Thickness, double Radius)
		{
			css.CrossSectionType = CrossSectionType.CFL;
			css.Parameters.Add(new ParameterDouble() { Name = "Width", Value = Width });
			css.Parameters.Add(new ParameterDouble() { Name = "Height", Value = Height });
			css.Parameters.Add(new ParameterDouble() { Name = "Thickness", Value = Thickness });
			css.Parameters.Add(new ParameterDouble() { Name = "Radius", Value = Radius });
		}

		/// <summary>
		/// Fill parameters for cold formed L - gen section
		/// </summary>
		/// <param name="css">Parameters of CrossSectionParameter will be filled</param>
		/// <param name="Width">Horizontal leg length</param>
		/// <param name="Height">Vertical leg length</param>
		/// <param name="Angle">Angle between legs</param>
		/// <param name="Thickness">Thickness</param>
		/// <param name="Radius">Inside radius</param>
		public static void FillColdFormedLgen(CrossSectionParameter css, double Width, double Height, double Angle, double Thickness, double Radius)
		{
			css.CrossSectionType = CrossSectionType.CFLgen;
			css.Parameters.Add(new ParameterDouble() { Name = "Width", Value = Width });
			css.Parameters.Add(new ParameterDouble() { Name = "Height", Value = Height });
			css.Parameters.Add(new ParameterDouble() { Name = "Angle", Value = Angle });
			css.Parameters.Add(new ParameterDouble() { Name = "Thickness", Value = Thickness });
			css.Parameters.Add(new ParameterDouble() { Name = "Radius", Value = Radius });
		}

		/// <summary>
		/// Fill parameters for cold formed Regular polygon section
		/// </summary>
		/// <param name="css">Parameters of CrossSectionParameter will be filled</param>
		/// <param name="Radius">Radius</param>
		/// <param name="Number">Number</param>
		/// <param name="Thickness">Thickness</param>
		/// <param name="InsideRadius">Inside radius</param>
		public static void FillColdFormedRegularPolygon(CrossSectionParameter css, double Radius, int Number, double Thickness, double InsideRadius)
		{
			css.CrossSectionType = CrossSectionType.CFRegPolygon;
			css.Parameters.Add(new ParameterDouble() { Name = "Radius", Value = Radius });
			css.Parameters.Add(new ParameterInt() { Name = "Number", Value = Number });
			css.Parameters.Add(new ParameterDouble() { Name = "Thickness", Value = Thickness });
			css.Parameters.Add(new ParameterDouble() { Name = "InsideRadius", Value = InsideRadius });
		}

		/// <summary>
		/// Fill parameters for cold formed sigma section
		/// </summary>
		/// <param name="css">Parameters of CrossSectionParameter will be filled</param>
		/// <param name="Height">Height</param>
		/// <param name="Width">Width</param>
		/// <param name="Lip">Length of lip</param>
		/// <param name="Thickness">Thickness</param>
		/// <param name="InsideRadius">Inside radius</param>
		/// <param name="HeightMiddle">Height of middle part</param>
		/// <param name="HeightEdge">Height of edge part</param>
		/// <param name="Depth">Depth of web-fold</param>
		public static void FillColdFormedSigma(CrossSectionParameter css, double Height, double Width, double Lip, double Thickness, double InsideRadius, double HeightMiddle, double HeightEdge, double Depth)
		{
			css.CrossSectionType = CrossSectionType.CFSigma;
			css.Parameters.Add(new ParameterDouble() { Name = "Height", Value = Height });
			css.Parameters.Add(new ParameterDouble() { Name = "Width", Value = Width });
			css.Parameters.Add(new ParameterDouble() { Name = "Lip", Value = Lip });
			css.Parameters.Add(new ParameterDouble() { Name = "Thickness", Value = Thickness });
			css.Parameters.Add(new ParameterDouble() { Name = "InsideRadius", Value = InsideRadius });
			css.Parameters.Add(new ParameterDouble() { Name = "HeightMiddle", Value = HeightMiddle });
			css.Parameters.Add(new ParameterDouble() { Name = "HeightEdge", Value = HeightEdge });
			css.Parameters.Add(new ParameterDouble() { Name = "Depth", Value = Depth });
		}

		/// <summary>
		/// Fill parameters for cold formed RHS section
		/// </summary>
		/// <param name="css">Parameters of CrossSectionParameter will be filled</param>
		/// <param name="Height">Height</param>
		/// <param name="Width">Width</param>
		/// <param name="Thickness">Thickness</param>
		/// <param name="InsideRadius">Inside radius</param>
		public static void FillColdFormedRHS(CrossSectionParameter css, double Height, double Width, double Thickness, double InsideRadius)
		{
			css.CrossSectionType = CrossSectionType.RolledRHS;
			css.Parameters.Add(new ParameterDouble() { Name = "B", Value = Height });
			css.Parameters.Add(new ParameterDouble() { Name = "D", Value = Width });
			css.Parameters.Add(new ParameterDouble() { Name = "t", Value = Thickness });
			css.Parameters.Add(new ParameterDouble() { Name = "r1", Value = InsideRadius });
			css.Parameters.Add(new ParameterDouble() { Name = "r2", Value = InsideRadius * 2 });
			css.Parameters.Add(new ParameterDouble() { Name = "d", Value = 0.0 });
		}

		/// <summary>
		/// Fill center line for general cold formed css
		/// </summary>
		/// <param name="gcf"></param>
		/// <param name="region2D">We need PolyLine2D from region2D</param>
		/// <param name="Thickness">Thickness</param>
		/// <param name="InsideRadius">Inside radius</param>
		public static void FillColdFormedGeneral(CrossSectionGeneralColdFormed gcf, Region2D region2D, double Thickness, double InsideRadius)
		{
			gcf.Centerline = region2D.Outline;
			gcf.Thickness = Thickness;
			gcf.Radius = InsideRadius;
		}
	}
}
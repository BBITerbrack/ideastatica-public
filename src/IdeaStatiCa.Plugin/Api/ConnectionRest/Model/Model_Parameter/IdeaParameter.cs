﻿namespace IdeaStatiCa.Plugin.Api.ConnectionRest.Model.Model_Parameter
{
	public class IdeaParameter
	{
		public string Key { get; set; }

		public dynamic Value { get; set; }

		public string Unit { get; set; }

		public string ParameterType { get; set; }

		public string ValidationExpression { get; set; }

		public string Description { get; set; }

		public string ValidationStatus { get; set; } //OKAY, WARNING, ERROR 

		public bool IsVisible { get; set; }
	}
}

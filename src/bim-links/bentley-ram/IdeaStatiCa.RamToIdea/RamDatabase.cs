﻿using Autofac;
using IdeaStatiCa.RamToIdea.BimApi;
using IdeaStatiCa.RamToIdea.Factories;
using IdeaStatiCa.RamToIdea.Sections;
using IdeaStatiCa.RamToIdea.Utilities;
using RAMDATAACCESSLib;
using System;

namespace IdeaStatiCa.RamToIdea
{
	public class RamDatabase : IDisposable
	{
		private bool _disposed;
		private bool _isOpen;

		private readonly IDBIO1 _dbIo;
		private readonly IContainer _container;
		private readonly string _path;

		// RamDataAccess1 must be released after IDBIO1 so it cannot be a local variable
		private readonly RamDataAccess1 _ramDataAccess;

		public RamDatabase(string path)
		{
			_path = path;

			_ramDataAccess = new RamDataAccess1();

			ContainerBuilder builder = new ContainerBuilder();

			builder.RegisterType<ObjectFactory>().As<IObjectFactory>().SingleInstance();
			builder.RegisterType<MaterialFactory>().As<IMaterialFactory>().SingleInstance();
			builder.RegisterType<SectionFactory>().As<ISectionFactory>().SingleInstance();
			builder.RegisterType<SectionPropertiesConverter>().As<ISectionPropertiesConverter>().SingleInstance();

			builder.RegisterType<RamModel>().FindConstructorsWith(new AllConstructorFinder()).AsSelf();

			builder.Register(x => (IModel)_ramDataAccess.GetInterfacePointerByEnum(EINTERFACES.IModel_INT));
			builder.Register(x => (IMemberData1)_ramDataAccess.GetInterfacePointerByEnum(EINTERFACES.IMemberData_INT));

			_container = builder.Build();

			_dbIo = (IDBIO1)_ramDataAccess.GetInterfacePointerByEnum(EINTERFACES.IDBIO1_INT);
		}

		~RamDatabase()
		{
			Dispose(disposing: false);
		}

		protected virtual void Dispose(bool disposing)
		{
			if (_disposed)
			{
				return;
			}

			if (_isOpen)
			{
				_dbIo?.CloseDatabase();
				_isOpen = false;
			}

			_disposed = true;
		}

		public void Dispose()
		{
			Dispose(disposing: true);
			GC.SuppressFinalize(this);
		}

		public RamModel GetModel()
		{
			_dbIo.LoadDataBase(_path);
			_isOpen = true;
			return _container.Resolve<RamModel>();
		}

		public void GetLastError(out string shortError, out string longError, out int errorId)
		{
			shortError = null;
			longError = null;
			errorId = 0;
			_ramDataAccess.GetLastError(ref shortError, ref longError, ref errorId);
		}
	}
}
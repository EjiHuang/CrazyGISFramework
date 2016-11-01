﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CrazyGIS.CoordinateConversion;
using CrazyGIS.Graphical;
using CrazyGIS.Graphical.Models;
using System.IO;
//using CrazyGIS.CoordinateConversion.Models;

namespace CrazyGISFramework
{
	class Program
	{
		static void Main(string[] args)
		{
			//CoordinateTransform transform = new CoordinateTransform();
			//SpherePoint coor1 = new SpherePoint(112.97, 28.23);
			//SpherePoint result = transform.WGS84_To_GCJ02(coor1);

			//Console.WriteLine(result.lng + "," + result.lat);

			IconInputDatabase();
		}

		static void SevenParamsConversion()
		{
			//ConversionParameters parameters = new ConversionParameters();
			//// 七参数
			//SevenParameters sevenP = new SevenParameters();
			//sevenP.XaxisDeviation = 0;
			//sevenP.XaxisRotateRadian = 0;
			//sevenP.YaxisDeviation = 0;
			//sevenP.YaxisRotateRadian = 0;
			//sevenP.ZaxisDeviation = 0;
			//sevenP.ZaxisRotateRadian = 0;
			//sevenP.ScaleParameter = 0;

			//parameters.ConversionSevenParams = sevenP;
			//parameters.SourceCoordinateSystem = CoordinateSystemType.WGS84;
			//parameters.TargetCoordinateSystem = CoordinateSystemType.CGCS2000;
			//parameters.SourceCenterMeridian = 120;
			//parameters.TargetCenterMeridian = 120;
			//parameters.SourceCoordinateType = CoordinateType.Sphere;
			//parameters.TargetCoordinateType = CoordinateType.Sphere;

			//ConversionService conversionService = new ConversionService(parameters);

			//CrazyGIS.CoordinateConversion.Models.ICoordinate source = 
			//	new CrazyGIS.CoordinateConversion.Models.SpherePoint(120, 32);
			//Console.WriteLine("源：" + source.xAxis + "," + source.yAxis);
			//CrazyGIS.CoordinateConversion.Models.ICoordinate target = conversionService.SourceToTarget(source);
			//Console.WriteLine("目标：" + target.xAxis + "," + target.yAxis);

			//source = conversionService.TargetToSource(target);
			//Console.WriteLine("反算出来的源：" + source.xAxis + "," + source.yAxis);
		}

		static void IconInputDatabase()
		{
			string fileFolder = @"D:\Code\CJ\水上公安\HarborPoliceSolution\HarborPoliceWebApp\Content\police";
			string dbFileName = @"D:\Code\CJ\水上公安\HarborPoliceSolution\HarborPoliceWebApp\App_Data\HarborPolice.db";

			DirectoryInfo directoryInfo = new DirectoryInfo(fileFolder);
			foreach (FileInfo fileInfo in directoryInfo.GetFiles())
			{
				if(fileInfo.Extension == ".png" || fileInfo.Extension == ".jpg")
				{
					Console.WriteLine(fileInfo.FullName);
				}
			}

		}
	}
}

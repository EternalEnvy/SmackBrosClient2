using System;
using System.IO;

namespace NeptuneRenderEngine.Engine.Utilities
{
	public class Platform
	{
		public enum PlatformEnum
		{
			Windows,
			Linux,
			Mac
		}

		public static PlatformEnum RunningPlatform()
		{
			switch (Environment.OSVersion.Platform)
			{
			case PlatformID.Unix:
				// Well, there are chances MacOSX is reported as Unix instead of MacOSX.
				// Instead of platform check, we'll do a feature checks (Mac specific root folders)
				if (Directory.Exists("/Applications")
					& Directory.Exists("/System")
					& Directory.Exists("/Users")
					& Directory.Exists("/Volumes"))
					return PlatformEnum.Mac;
				else
					return PlatformEnum.Linux;

			case PlatformID.MacOSX:
				return PlatformEnum.Mac;

			default:
				return PlatformEnum.Windows;
			}
		}
	}
}


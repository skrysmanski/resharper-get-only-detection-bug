using System;
using JetBrains.Annotations;

namespace ReSharper_GetOnlyDetectionBug
{
	public static class SomeClass
	{
		[PublicAPI]
		public static void SomeMethod()
		{
			var langs = new LanguageInfo("English");
			Console.WriteLine(langs.LanguageNameInCulture);
		}
	}
}

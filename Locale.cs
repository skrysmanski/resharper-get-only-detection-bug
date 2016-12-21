using JetBrains.Annotations;

namespace ReSharper_GetOnlyDetectionBug
{
	public class LanguageInfo
	{
		public string LanguageNameInCulture { get; private set; }

		public string Culture { get; private set; }

		public LanguageInfo(string language)
		{
			LanguageNameInCulture = language;
			Culture = language;
		}
	}

	public static class Locale
	{
		[PublicAPI]
		public static string GetLanguageFromCulture(string culture)
		{
			var lang = new LanguageInfo("English");
			return lang.Culture;
		}
	}
}

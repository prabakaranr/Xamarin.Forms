using Xamarin.Forms.PlatformConfiguration.AndroidSpecific;

namespace Xamarin.Forms.Platform.Android
{
	public static class ElevationHelper
	{
		public static void SetElevation(global::Android.Views.View view, VisualElement element)
		{
			if (view == null || element == null || !Forms.IsLollipopOrNewer)
			{
				return;
			}

			var iec = element as IElementConfiguration<VisualElement>;
			var elevation = iec?.On<PlatformConfiguration.Android>().GetElevation();

			if (!elevation.HasValue)
			{
				return;
			}

			view.Elevation = elevation.Value;
		}

		internal static float? GetElevation(global::Android.Views.View view)
		{
			if (view == null || !Forms.IsLollipopOrNewer)
			{
				return null;
			}

			return view.Elevation;
		}

		internal static float? GetElevation(VisualElement element)
		{
			if (element == null || !Forms.IsLollipopOrNewer)
			{
				return null;
			}

			var iec = element as IElementConfiguration<VisualElement>;
			var elevation = iec?.On<PlatformConfiguration.Android>().GetElevation();

			return elevation;
		}
	}
}
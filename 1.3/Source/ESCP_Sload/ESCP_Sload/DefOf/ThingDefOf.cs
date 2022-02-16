using System;
using Verse;
using RimWorld;

namespace ESCP_Sload
{
	[DefOf]
	public static class ThingDefOf
	{

		static ThingDefOf()
		{
			DefOfHelper.EnsureInitializedInCtor(typeof(ThingDefOf));
		}

		public static ThingDef ESCP_Gas_ThrassianPlague;
		public static ThingDef ESCP_LeatherSload;
		public static ThingDef ESCP_SloadRace;
	}
}

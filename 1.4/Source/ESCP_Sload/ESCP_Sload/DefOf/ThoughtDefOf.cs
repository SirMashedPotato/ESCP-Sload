using System;
using Verse;
using RimWorld;

namespace ESCP_Sload
{
	[DefOf]
	public static class ThoughtDefOf
	{

		static ThoughtDefOf()
		{
			DefOfHelper.EnsureInitializedInCtor(typeof(ThoughtDefOf));
		}

		public static ThoughtDef ESCP_SloadThrallThought;
	}
}

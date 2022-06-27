using System;
using Verse;
using RimWorld;

namespace ESCP_Sload
{
	[DefOf]
	public static class HediffDefOf
	{

		static HediffDefOf()
		{
			DefOfHelper.EnsureInitializedInCtor(typeof(HediffDefOf));
		}

		public static HediffDef ESCP_ThrassianPlague;
		public static HediffDef ESCP_SloadThrallPassive;
		public static HediffDef ESCP_SloadDiseaseImmunity;
		public static HediffDef ESCP_SloadPlagueLord;
		public static HediffDef ESCP_SloadThrassianElixir_Thrall;
		public static HediffDef ESCP_SloadThrassianElixir_ThrallControl;
	}
}

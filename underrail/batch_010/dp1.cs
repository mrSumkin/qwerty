using System;

// Token: 0x02000BF4 RID: 3060
public sealed class dp1 : jn
{
	// Token: 0x060045AE RID: 17838 RVA: 0x001C5B50 File Offset: 0x001C3D50
	public dp1() : base("cc_acidMessenger", "creature\\characters\\support\\cc_acidMessenger")
	{
	}

	// Token: 0x060045AF RID: 17839 RVA: 0x001C5B64 File Offset: 0x001C3D64
	public override string b1(cyt A_0)
	{
		if (!A_0.r().GetPrimitivePropertyValue<bool>("cc_jkk_acidHunters_started", new bool?(false)).Value && A_0.r().GetPrimitivePropertyValue<bool>("faction_JKK_acceptedInFamily", new bool?(false)).Value && A_0.r().GetPrimitivePropertyValue<bool>("global_heardAboutAcidHunters", new bool?(false)).Value && !A_0.r().GetPrimitivePropertyValue<bool>("npc_cc_acidMessenger_met", new bool?(false)).Value && (string.Equals(A_0.c().b(), "cc1", StringComparison.OrdinalIgnoreCase) || string.Equals(A_0.c().b(), "cc_dock", StringComparison.OrdinalIgnoreCase) || string.Equals(A_0.c().b(), "cc10", StringComparison.OrdinalIgnoreCase)))
		{
			return A_0.c().b();
		}
		if (!A_0.r().GetPrimitivePropertyValue<bool>("cc_ct_acidHunters_started", new bool?(false)).Value && A_0.r().GetPrimitivePropertyValue<bool>("faction_Coretech_acceptedInFamily", new bool?(false)).Value && A_0.r().GetPrimitivePropertyValue<bool>("global_heardAboutAcidHunters", new bool?(false)).Value && !A_0.r().GetPrimitivePropertyValue<bool>("npc_cc_acidMessenger_met", new bool?(false)).Value && (string.Equals(A_0.c().b(), "cc1", StringComparison.OrdinalIgnoreCase) || string.Equals(A_0.c().b(), "cc_dock", StringComparison.OrdinalIgnoreCase) || string.Equals(A_0.c().b(), "cc10", StringComparison.OrdinalIgnoreCase)))
		{
			return A_0.c().b();
		}
		if (!A_0.r().GetPrimitivePropertyValue<bool>("cc_ps_acidHunters_started", new bool?(false)).Value && A_0.r().GetPrimitivePropertyValue<bool>("faction_Praetorian_acceptedInFamily", new bool?(false)).Value && A_0.r().GetPrimitivePropertyValue<bool>("global_heardAboutAcidHunters", new bool?(false)).Value && !A_0.r().GetPrimitivePropertyValue<bool>("npc_cc_acidMessenger_met", new bool?(false)).Value && (string.Equals(A_0.c().b(), "cc1", StringComparison.OrdinalIgnoreCase) || string.Equals(A_0.c().b(), "cc_dock", StringComparison.OrdinalIgnoreCase) || string.Equals(A_0.c().b(), "cc10", StringComparison.OrdinalIgnoreCase)))
		{
			return A_0.c().b();
		}
		return null;
	}
}

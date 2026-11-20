using System;
using TimelapseVertigo.Playfield.Locale;

// Token: 0x02000C0A RID: 3082
public sealed class bwe : jn
{
	// Token: 0x060045F9 RID: 17913 RVA: 0x001C98E0 File Offset: 0x001C7AE0
	public bwe() : base("xpbl_kaya", "creature\\characters\\xpbl\\kaya")
	{
	}

	// Token: 0x060045FA RID: 17914 RVA: 0x001C98F8 File Offset: 0x001C7AF8
	public override string b1(cyt A_0)
	{
		bq8 bq = A_0.e();
		if (bq == null || bq.GetClassPropertyValue<string>("loc_xpbl_ojyc_resolution") == null)
		{
			return "xpbl_ojyc3";
		}
		if (bq.GetClassPropertyValue<string>("loc_xpbl_ojyc_resolution").Equals("prot") || bq.GetClassPropertyValue<string>("loc_xpbl_ojyc_resolution").Equals("freed") || bq.GetClassPropertyValue<string>("loc_xpbl_ojyc_resolution").Equals("dead"))
		{
			return null;
		}
		if (bq.GetClassPropertyValue<string>("loc_xpbl_ojyc_resolution").Equals("reunited"))
		{
			return "xpbl_rig2";
		}
		if (bq.GetClassPropertyValue<string>("loc_xpbl_ojyc_resolution").Equals("freeDrone"))
		{
			return "lup_freeDroneBase";
		}
		return "xpbl_ojyc3";
	}

	// Token: 0x060045FB RID: 17915 RVA: 0x001C99C0 File Offset: 0x001C7BC0
	public override void cf(b0b A_0, cyt A_1, string A_2)
	{
		amc aspect = A_0.GetAspect<amc>();
		if (aspect != null)
		{
			if (string.Equals(A_2, "xpbl_rig2", StringComparison.OrdinalIgnoreCase))
			{
				aspect.aa().FactionId = asp.gg;
				aspect.aa().HostilityBroadcastMode = c2n.b;
				(A_0 as c5x).b("std");
				(A_0 as c5x).b("guards");
			}
			if (string.Equals(A_2, "lup_freeDroneBase", StringComparison.OrdinalIgnoreCase))
			{
				aspect.aa().FactionId = asp.dc;
				aspect.aa().HostilityBroadcastMode = c2n.d;
				bm6 aspect2 = A_0.GetAspect<bm6>();
				if (aspect2 != null)
				{
					aspect2.y6()[ddq.w] = CharacterState.Operating;
				}
			}
		}
	}
}

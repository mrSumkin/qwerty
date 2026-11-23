using System;

// Token: 0x02000C36 RID: 3126
public sealed class bx0 : jn
{
	// Token: 0x06004696 RID: 18070 RVA: 0x001D2274 File Offset: 0x001D0474
	public bx0() : base("maura", "creature\\characters\\maura")
	{
	}

	// Token: 0x06004697 RID: 18071 RVA: 0x001D2288 File Offset: 0x001D0488
	public override string b1(cyt A_0)
	{
		if (A_0.r().GetPrimitivePropertyValue<bool>("quest_jyrescueMission_mauraEscaped", new bool?(false)).Value)
		{
			return "lup_freeDroneBase";
		}
		if (A_0.r().GetPrimitivePropertyValue<bool>("npc_garren_toldAboutRescueMission", new bool?(false)).Value)
		{
			return null;
		}
		return "jye2";
	}

	// Token: 0x06004698 RID: 18072 RVA: 0x001D22E8 File Offset: 0x001D04E8
	public override void cf(b0b A_0, cyt A_1, string A_2)
	{
		if (A_0 != null)
		{
			amc aspect = A_0.GetAspect<amc>();
			if (aspect != null)
			{
				if (string.Equals(A_2, "lup_freeDroneBase", StringComparison.OrdinalIgnoreCase))
				{
					aspect.aa().FactionId = asp.dc;
					return;
				}
				aspect.aa().FactionId = asp.z;
			}
		}
	}
}

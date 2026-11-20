using System;

// Token: 0x02000C2A RID: 3114
public sealed class cx8 : jn
{
	// Token: 0x06004671 RID: 18033 RVA: 0x001D1078 File Offset: 0x001CF278
	public cx8() : base("ch_edgar", "creature\\characters\\ch_edgar")
	{
	}

	// Token: 0x06004672 RID: 18034 RVA: 0x001D108C File Offset: 0x001CF28C
	public override string b1(cyt A_0)
	{
		if (A_0.r().GetPrimitivePropertyValue<bool>("npc_edgar_wentToKillKing", new bool?(false)).Value || (A_0.r().GetPrimitivePropertyValue<bool>("npc_ch_edgar_wentTogetherToRathoundLair", new bool?(false)).Value && !A_0.r().GetPrimitivePropertyValue<bool>("npc_ch_edgar_survivedPlayerBetrayal", new bool?(false)).Value && !A_0.r().GetPrimitivePropertyValue<bool>("HathorKingSituationResolved", new bool?(false)).Value))
		{
			return "rkl2";
		}
		return "cv16";
	}

	// Token: 0x06004673 RID: 18035 RVA: 0x001D1130 File Offset: 0x001CF330
	public override void cf(b0b A_0, cyt A_1, string A_2)
	{
		if (A_0 != null)
		{
			bm6 aspect = A_0.GetAspect<bm6>();
			if (aspect != null)
			{
				if (string.Equals(A_2, "rkl2", StringComparison.OrdinalIgnoreCase))
				{
					aspect.y6()[ddq.ay] = new bt4("global:rathoundKing");
				}
				else
				{
					aspect.y6()[ddq.ay] = new bt4("global:ch_edgar");
				}
			}
			amc aspect2 = A_0.GetAspect<amc>();
			if (aspect2 != null)
			{
				if (string.Equals(A_2, "rkl2", StringComparison.OrdinalIgnoreCase))
				{
					aspect2.aa().FactionId = asp.cx;
					aspect2.aa().CustomProperties["healUpAfterCombat"] = true;
					return;
				}
				aspect2.aa().FactionId = asp.ct;
				if (aspect2.aa().CustomProperties.GetPrimitivePropertyValue<bool>("healUpAfterCombat", new bool?(false)).Value)
				{
					aspect2.aa().Defense.a(1000, null, null, false, false, false, null);
					aspect2.aa().CustomProperties.RemoveProperty("healUpAfterCombat");
				}
			}
		}
	}

	// Token: 0x06004674 RID: 18036 RVA: 0x001D1258 File Offset: 0x001CF458
	public override string ce(cyt A_0, string A_1)
	{
		if (string.Equals(A_1, "rkl2", StringComparison.OrdinalIgnoreCase) && A_0.r().GetPrimitivePropertyValue<bool>("npc_ch_edgar_wentTogetherToRathoundLair", new bool?(false)).Value)
		{
			return "showdown";
		}
		return null;
	}
}

using System;

// Token: 0x02000C2D RID: 3117
public sealed class ao8 : jn
{
	// Token: 0x0600467C RID: 18044 RVA: 0x001D17B8 File Offset: 0x001CF9B8
	public ao8() : base("ch_beck", "creature\\characters\\ch_beck")
	{
	}

	// Token: 0x0600467D RID: 18045 RVA: 0x001D17CC File Offset: 0x001CF9CC
	public override string b1(cyt A_0)
	{
		if (A_0.r().GetPrimitivePropertyValue<bool>("npc_ch_beck_survivedTheBattle", new bool?(false)).Value || A_0.r().GetPrimitivePropertyValue<bool>("HathorKingSituationResolved", new bool?(false)).Value)
		{
			return null;
		}
		if (A_0.r().GetPrimitivePropertyValue<bool>("npc_ch_sarine_captured", new bool?(false)).Value)
		{
			return "rkl2";
		}
		if (!A_0.r().GetPrimitivePropertyValue<bool>("beck_sarine_met", new bool?(false)).Value)
		{
			return "cv16";
		}
		return null;
	}

	// Token: 0x0600467E RID: 18046 RVA: 0x001D1874 File Offset: 0x001CFA74
	public override void cf(b0b A_0, cyt A_1, string A_2)
	{
		if (A_0 != null)
		{
			bm6 aspect = A_0.GetAspect<bm6>();
			if (aspect != null)
			{
				if (string.Equals(A_2, "rkl2", StringComparison.OrdinalIgnoreCase))
				{
					aspect.y6().RemoveProperty(ddq.ay);
				}
				else
				{
					aspect.y6()[ddq.ay] = new bt4("global:ch_beck");
				}
			}
			amc aspect2 = A_0.GetAspect<amc>();
			if (aspect2 != null)
			{
				if (string.Equals(A_2, "rkl2", StringComparison.OrdinalIgnoreCase))
				{
					aspect2.aa().FactionId = asp.cw;
					return;
				}
				aspect2.aa().FactionId = asp.ct;
			}
		}
	}
}

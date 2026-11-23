using System;

// Token: 0x02000BF0 RID: 3056
public sealed class d7e : jn
{
	// Token: 0x060045A5 RID: 17829 RVA: 0x001C5718 File Offset: 0x001C3918
	public d7e() : base("azif", "creature\\characters\\azif")
	{
	}

	// Token: 0x060045A6 RID: 17830 RVA: 0x001C572C File Offset: 0x001C392C
	public override string b1(cyt A_0)
	{
		if (A_0.r().GetPrimitivePropertyValue<bool>("npc_jackQuicksilver_sentYouToAzif", new bool?(false)).Value && !A_0.r().GetPrimitivePropertyValue<bool>("npc_azif_met", new bool?(false)).Value)
		{
			return "lux-b11";
		}
		if (A_0.r().GetPrimitivePropertyValue<bool>("npc_azif_ledYouInside", new bool?(false)).Value)
		{
			return "wa-mf";
		}
		if (!A_0.r().GetPrimitivePropertyValue<bool>("npc_azif_agreedToJoin", new bool?(false)).Value)
		{
			return null;
		}
		int value = A_0.r().GetPrimitivePropertyValue<int>("npc_azif_leadingPos", new int?(0)).Value;
		if (value == 0)
		{
			return "lux-b11";
		}
		if (value == 1)
		{
			return "lux-b17";
		}
		if (value == 2)
		{
			return "lux-b19";
		}
		return "lux-wa";
	}

	// Token: 0x060045A7 RID: 17831 RVA: 0x001C5820 File Offset: 0x001C3A20
	public override void cf(b0b A_0, cyt A_1, string A_2)
	{
		c5x c5x = A_0 as c5x;
		if (c5x != null)
		{
			bool value = A_1.r().GetPrimitivePropertyValue<bool>("npc_azif_agreedToJoin", new bool?(false)).Value;
			bool value2 = A_1.r().GetPrimitivePropertyValue<bool>("npc_azif_ledYouInside", new bool?(false)).Value;
			int value3 = A_1.r().GetPrimitivePropertyValue<int>("npc_azif_leadingPos", new int?(0)).Value;
			bm6 aspect = c5x.GetAspect<bm6>();
			if (aspect != null)
			{
				if (value && !value2 && value3 <= 2)
				{
					aspect.y6()[ddq.ay] = new bt4("azifExit");
				}
				else
				{
					aspect.y6()[ddq.ay] = new bt4("global:azif");
				}
				if (string.Equals(A_2, "wa-mf", StringComparison.OrdinalIgnoreCase))
				{
					aspect.y6()[ddq.bc] = "npc_azif_insideIntroduction";
				}
			}
			amc aspect2 = c5x.GetAspect<amc>();
			if (aspect2 != null)
			{
				if (string.Equals(A_2, "lux-b11", StringComparison.OrdinalIgnoreCase))
				{
					aspect2.aa().FactionId = "HangingRat_Bar";
					return;
				}
				aspect2.aa().FactionId = "watchers";
			}
		}
	}
}

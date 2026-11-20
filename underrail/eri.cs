using System;

// Token: 0x02000BDE RID: 3038
public sealed class eri : jn
{
	// Token: 0x0600456B RID: 17771 RVA: 0x001C3528 File Offset: 0x001C1728
	public eri() : base("tch_amelia", "creature\\characters\\tch_amelia")
	{
	}

	// Token: 0x0600456C RID: 17772 RVA: 0x001C353C File Offset: 0x001C173C
	public override string b1(cyt A_0)
	{
		cky cky = A_0.ac().abu(asp.a, asp.es);
		if (A_0.r().GetPrimitivePropertyValue<bool>("faction_tchortists_joined", new bool?(false)).Value || cky.a == h.a)
		{
			return "tch-off";
		}
		if (A_0.r().GetPrimitivePropertyValue<bool>("global_sawTchoristsSnatchCube", new bool?(false)).Value)
		{
			return "tch-entry";
		}
		return null;
	}

	// Token: 0x0600456D RID: 17773 RVA: 0x001C35C0 File Offset: 0x001C17C0
	public override string ce(cyt A_0, string A_1)
	{
		if (!string.Equals(A_1, "tch-entry", StringComparison.OrdinalIgnoreCase))
		{
			return null;
		}
		if (A_0.r().GetPrimitivePropertyValue<bool>("npc_tch_amelia_met", new bool?(false)).Value)
		{
			return "interview";
		}
		return "entryOut";
	}

	// Token: 0x0600456E RID: 17774 RVA: 0x001C3610 File Offset: 0x001C1810
	public override void cf(b0b A_0, cyt A_1, string A_2)
	{
		bm6 aspect = A_0.GetAspect<bm6>();
		if (aspect != null)
		{
			if (string.Equals(A_2, "tch-entry", StringComparison.OrdinalIgnoreCase))
			{
				if (!A_1.r().GetPrimitivePropertyValue<bool>("npc_tch_amelia_met", new bool?(false)).Value)
				{
					aspect.y6()[ddq.ay] = new bt4("globa:tch_amelia:entryOut");
					return;
				}
				aspect.y6()[ddq.ay] = new bt4("global:tch_amelia:interview");
				return;
			}
			else
			{
				aspect.y6()[ddq.ay] = new bt4("global:tch_amelia");
			}
		}
	}
}

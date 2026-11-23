using System;

// Token: 0x02000BDD RID: 3037
public sealed class akj : jn
{
	// Token: 0x06004567 RID: 17767 RVA: 0x001C33EC File Offset: 0x001C15EC
	public akj() : base("cc_johnnyFilth", "creature\\characters\\support\\cc_johnnyFilth")
	{
	}

	// Token: 0x06004568 RID: 17768 RVA: 0x001C3400 File Offset: 0x001C1600
	public override string b1(cyt A_0)
	{
		if (A_0.r().GetPrimitivePropertyValue<bool>("quests_tch_schteff_plantSecondTRayEmmiterStarted", new bool?(false)).Value)
		{
			return "up-cc";
		}
		return null;
	}

	// Token: 0x06004569 RID: 17769 RVA: 0x001C3438 File Offset: 0x001C1638
	public override string ce(cyt A_0, string A_1)
	{
		if (!string.Equals(A_1, "up-cc", StringComparison.OrdinalIgnoreCase))
		{
			return null;
		}
		if (A_0.r().GetPrimitivePropertyValue<bool>("quests_tch_schteff_plantSecondTRayEmmiter_planted", new bool?(false)).Value)
		{
			return "in";
		}
		return "out";
	}

	// Token: 0x0600456A RID: 17770 RVA: 0x001C3488 File Offset: 0x001C1688
	public override void cf(b0b A_0, cyt A_1, string A_2)
	{
		bm6 aspect = A_0.GetAspect<bm6>();
		if (aspect != null)
		{
			if (string.Equals(A_2, "up-cc", StringComparison.OrdinalIgnoreCase))
			{
				if (A_1.r().GetPrimitivePropertyValue<bool>("quests_tch_schteff_plantSecondTRayEmmiter_planted", new bool?(false)).Value)
				{
					aspect.y6()[ddq.ay] = new bt4("global:cc_johnnyFilth:in");
					return;
				}
				aspect.y6()[ddq.ay] = new bt4("global:cc_johnnyFilth:out");
				return;
			}
			else
			{
				aspect.y6()[ddq.ay] = new bt4("global:cc_johnnyFilth");
			}
		}
	}
}

using System;

// Token: 0x02000BDC RID: 3036
public sealed class b1h : jn
{
	// Token: 0x06004563 RID: 17763 RVA: 0x001C32B0 File Offset: 0x001C14B0
	public b1h() : base("cc_mullock", "creature\\characters\\support\\cc_mullock")
	{
	}

	// Token: 0x06004564 RID: 17764 RVA: 0x001C32C4 File Offset: 0x001C14C4
	public override string b1(cyt A_0)
	{
		if (A_0.r().GetPrimitivePropertyValue<bool>("quests_tch_schteff_plantSecondTRayEmmiterStarted", new bool?(false)).Value)
		{
			return "up-cc";
		}
		return null;
	}

	// Token: 0x06004565 RID: 17765 RVA: 0x001C32FC File Offset: 0x001C14FC
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

	// Token: 0x06004566 RID: 17766 RVA: 0x001C334C File Offset: 0x001C154C
	public override void cf(b0b A_0, cyt A_1, string A_2)
	{
		bm6 aspect = A_0.GetAspect<bm6>();
		if (aspect != null)
		{
			if (string.Equals(A_2, "up-cc", StringComparison.OrdinalIgnoreCase))
			{
				if (A_1.r().GetPrimitivePropertyValue<bool>("quests_tch_schteff_plantSecondTRayEmmiter_planted", new bool?(false)).Value)
				{
					aspect.y6()[ddq.ay] = new bt4("global:cc_mullock:in");
					return;
				}
				aspect.y6()[ddq.ay] = new bt4("global:cc_mullock:out");
				return;
			}
			else
			{
				aspect.y6()[ddq.ay] = new bt4("global:cc_mullock");
			}
		}
	}
}

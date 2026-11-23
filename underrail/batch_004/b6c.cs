using System;

// Token: 0x02000BDB RID: 3035
public sealed class b6c : jn
{
	// Token: 0x0600455F RID: 17759 RVA: 0x001C3174 File Offset: 0x001C1374
	public b6c() : base("cc_drek", "creature\\characters\\support\\cc_drek")
	{
	}

	// Token: 0x06004560 RID: 17760 RVA: 0x001C3188 File Offset: 0x001C1388
	public override string b1(cyt A_0)
	{
		if (A_0.r().GetPrimitivePropertyValue<bool>("quests_tch_schteff_plantSecondTRayEmmiterStarted", new bool?(false)).Value)
		{
			return "up-cc";
		}
		return null;
	}

	// Token: 0x06004561 RID: 17761 RVA: 0x001C31C0 File Offset: 0x001C13C0
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

	// Token: 0x06004562 RID: 17762 RVA: 0x001C3210 File Offset: 0x001C1410
	public override void cf(b0b A_0, cyt A_1, string A_2)
	{
		bm6 aspect = A_0.GetAspect<bm6>();
		if (aspect != null)
		{
			if (string.Equals(A_2, "up-cc", StringComparison.OrdinalIgnoreCase))
			{
				if (A_1.r().GetPrimitivePropertyValue<bool>("quests_tch_schteff_plantSecondTRayEmmiter_planted", new bool?(false)).Value)
				{
					aspect.y6()[ddq.ay] = new bt4("global:cc_drek:in");
					return;
				}
				aspect.y6()[ddq.ay] = new bt4("global:cc_drek:out");
				return;
			}
			else
			{
				aspect.y6()[ddq.ay] = new bt4("global:cc_drek");
			}
		}
	}
}

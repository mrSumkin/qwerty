using System;

// Token: 0x02000C54 RID: 3156
public sealed class arm : jn
{
	// Token: 0x060046F5 RID: 18165 RVA: 0x001D4A98 File Offset: 0x001D2C98
	public override string cc()
	{
		return "xpbl";
	}

	// Token: 0x060046F6 RID: 18166 RVA: 0x001D4AA0 File Offset: 0x001D2CA0
	public arm() : base("xpbl_aegis_guard2", "creature\\characters\\support\\xpbl\\aegis_guard2")
	{
	}

	// Token: 0x060046F7 RID: 18167 RVA: 0x001D4AB4 File Offset: 0x001D2CB4
	public override string b1(cyt A_0)
	{
		if (A_0.r().GetPrimitivePropertyValue<bool>("global_xpbl_expeditionDestroyed", new bool?(false)).Value || A_0.r().GetPrimitivePropertyValue<bool>("global_xpbl_expeditionUndeployed", new bool?(false)).Value || !A_0.r().GetPrimitivePropertyValue<bool>("global_beginExpedition", new bool?(false)).Value)
		{
			return null;
		}
		cky cky = (A_0.ac() as bv9).abu(asp.a, asp.f5);
		if (A_0.r().GetPrimitivePropertyValue<bool>("global_xpbl_le_philsImplantAcquired", new bool?(false)).Value)
		{
			if (A_0.r().GetPrimitivePropertyValue<bool>("loc_le_openedFort", new bool?(false)).Value && (A_0.r().GetPrimitivePropertyValue<bool>("loc_xpbl_fu_enteredWithAegis", new bool?(false)).Value || A_0.r().GetPrimitivePropertyValue<bool>("event_xpbl_enteringFort_enteredUp", new bool?(false)).Value))
			{
				return "xpbl_fu";
			}
			if (!A_0.r().GetPrimitivePropertyValue<bool>("global_xpbl_pirates_joined", new bool?(false)).Value && cky.a != h.a)
			{
				return "xpbl_e6";
			}
		}
		return null;
	}

	// Token: 0x060046F8 RID: 18168 RVA: 0x001D4C10 File Offset: 0x001D2E10
	public override string ce(cyt A_0, string A_1)
	{
		if (!string.Equals(A_1, "xpbl_fu", StringComparison.OrdinalIgnoreCase))
		{
			return null;
		}
		if (!A_0.r().GetPrimitivePropertyValue<bool>("loc_xpbl_fu_descended", new bool?(false)).Value)
		{
			return "up";
		}
		return "tun";
	}

	// Token: 0x060046F9 RID: 18169 RVA: 0x001D4C60 File Offset: 0x001D2E60
	public override void cf(b0b A_0, cyt A_1, string A_2)
	{
		bm6 aspect = A_0.GetAspect<bm6>();
		if (aspect != null)
		{
			if (string.Equals(A_2, "xpbl_fu", StringComparison.OrdinalIgnoreCase))
			{
				if (!A_1.r().GetPrimitivePropertyValue<bool>("loc_xpbl_fu_descended", new bool?(false)).Value)
				{
					aspect.y6()[ddq.ay] = new bt4("global:xpbl_aegis_guard2:up");
				}
				else
				{
					aspect.y6()[ddq.ay] = new bt4("global:xpbl_aegis_guard2:tun");
				}
			}
			else
			{
				aspect.y6()[ddq.ay] = new bt4("global:xpbl_aegis_guard2");
			}
		}
		bn5 bn = A_0.GetAspect<j7>() as bn5;
		if (bn == null)
		{
			bn = new bn5(A_0 as c5x);
			A_0.SetAspect<j7>(bn);
		}
		if (string.Equals(A_2, "xpbl_fu", StringComparison.OrdinalIgnoreCase))
		{
			if (A_1.r().GetPrimitivePropertyValue<bool>("loc_le_openedFort", new bool?(false)).Value && !A_1.r().GetPrimitivePropertyValue<bool>("global_xpbl_le_finishedFortEntrance", new bool?(false)).Value)
			{
				bn.a("guard");
				return;
			}
			bn.a("speaker");
		}
	}
}

using System;

// Token: 0x02000C53 RID: 3155
public sealed class arl : jn
{
	// Token: 0x060046F0 RID: 18160 RVA: 0x001D4784 File Offset: 0x001D2984
	public override string cc()
	{
		return "xpbl";
	}

	// Token: 0x060046F1 RID: 18161 RVA: 0x001D478C File Offset: 0x001D298C
	public arl() : base("xpbl_aegis_guard3", "creature\\characters\\support\\xpbl\\aegis_guard3")
	{
	}

	// Token: 0x060046F2 RID: 18162 RVA: 0x001D47A0 File Offset: 0x001D29A0
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

	// Token: 0x060046F3 RID: 18163 RVA: 0x001D48FC File Offset: 0x001D2AFC
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
		if (A_0.r().GetPrimitivePropertyValue<bool>("quests_xpbl_expedition_professorKidnapped", new bool?(false)).Value && !A_0.r().GetPrimitivePropertyValue<bool>("quests_xpbl_expedition_professorSaved", new bool?(false)).Value)
		{
			return "evac";
		}
		return "tun";
	}

	// Token: 0x060046F4 RID: 18164 RVA: 0x001D4998 File Offset: 0x001D2B98
	public override void cf(b0b A_0, cyt A_1, string A_2)
	{
		bm6 aspect = A_0.GetAspect<bm6>();
		if (aspect != null)
		{
			if (string.Equals(A_2, "xpbl_fu", StringComparison.OrdinalIgnoreCase))
			{
				if (!A_1.r().GetPrimitivePropertyValue<bool>("loc_xpbl_fu_descended", new bool?(false)).Value)
				{
					aspect.y6()[ddq.ay] = new bt4("global:xpbl_aegis_guard3:up");
					return;
				}
				if (A_1.r().GetPrimitivePropertyValue<bool>("quests_xpbl_expedition_professorKidnapped", new bool?(false)).Value && !A_1.r().GetPrimitivePropertyValue<bool>("quests_xpbl_expedition_professorSaved", new bool?(false)).Value)
				{
					aspect.y6()[ddq.ay] = new bt4("global:xpbl_aegis_guard3:evac");
					return;
				}
				aspect.y6()[ddq.ay] = new bt4("global:xpbl_aegis_guard3:tun");
				return;
			}
			else
			{
				aspect.y6()[ddq.ay] = new bt4("global:xpbl_aegis_guard3");
			}
		}
	}
}

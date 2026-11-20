using System;

// Token: 0x02000C55 RID: 3157
public sealed class arj : jn
{
	// Token: 0x060046FA RID: 18170 RVA: 0x001D4D9C File Offset: 0x001D2F9C
	public override string cc()
	{
		return "xpbl";
	}

	// Token: 0x060046FB RID: 18171 RVA: 0x001D4DA4 File Offset: 0x001D2FA4
	public arj() : base("xpbl_aegis_guard1", "creature\\characters\\support\\xpbl\\aegis_guard1")
	{
	}

	// Token: 0x060046FC RID: 18172 RVA: 0x001D4DB8 File Offset: 0x001D2FB8
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

	// Token: 0x060046FD RID: 18173 RVA: 0x001D4F14 File Offset: 0x001D3114
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

	// Token: 0x060046FE RID: 18174 RVA: 0x001D4FB0 File Offset: 0x001D31B0
	public override void cf(b0b A_0, cyt A_1, string A_2)
	{
		bm6 aspect = A_0.GetAspect<bm6>();
		if (aspect != null)
		{
			if (string.Equals(A_2, "xpbl_fu", StringComparison.OrdinalIgnoreCase))
			{
				if (!A_1.r().GetPrimitivePropertyValue<bool>("loc_xpbl_fu_descended", new bool?(false)).Value)
				{
					aspect.y6()[ddq.ay] = new bt4("global:xpbl_aegis_guard1:up");
				}
				else if (A_1.r().GetPrimitivePropertyValue<bool>("quests_xpbl_expedition_professorKidnapped", new bool?(false)).Value && !A_1.r().GetPrimitivePropertyValue<bool>("quests_xpbl_expedition_professorSaved", new bool?(false)).Value)
				{
					aspect.y6()[ddq.ay] = new bt4("global:xpbl_aegis_guard1:evac");
				}
				else
				{
					aspect.y6()[ddq.ay] = new bt4("global:xpbl_aegis_guard1:tun");
				}
			}
			else
			{
				aspect.y6()[ddq.ay] = new bt4("global:xpbl_aegis_guard1");
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
			if (A_1.r().GetPrimitivePropertyValue<bool>("quests_xpbl_expedition_professorKidnapped", new bool?(false)).Value && !A_1.r().GetPrimitivePropertyValue<bool>("quests_xpbl_expedition_saveTheProfessor_started", new bool?(false)).Value && !A_1.r().GetPrimitivePropertyValue<bool>("quests_xpbl_expedition_saveTheProfessor_completed", new bool?(false)).Value)
			{
				bn.a("guard");
				return;
			}
			bn.a("speaker");
		}
	}
}

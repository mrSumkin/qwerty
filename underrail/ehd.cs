using System;

// Token: 0x02000C05 RID: 3077
public sealed class ehd : jn
{
	// Token: 0x060045E3 RID: 17891 RVA: 0x001C7D08 File Offset: 0x001C5F08
	public ehd() : base("xpbl_gritz", "creature\\characters\\xpbl\\Gritz")
	{
	}

	// Token: 0x060045E4 RID: 17892 RVA: 0x001C7D20 File Offset: 0x001C5F20
	public override string b1(cyt A_0)
	{
		bq8 bq = A_0.e();
		if (bq.GetPrimitivePropertyValue<bool>("npc_xpbl_kirillHunters_allied", new bool?(false)).Value && !bq.GetPrimitivePropertyValue<bool>("npc_xpbl_kirill_dead", new bool?(false)).Value && bq.GetPrimitivePropertyValue<bool>("powSrc_pwrSrc_xpbl_kirillLabPower", new bool?(false)).Value && bq.GetPrimitivePropertyValue<bool>("loc_xpbl_kirillhunters_prepared", new bool?(false)).Value && bq.GetPrimitivePropertyValue<bool>("loc_xpbl_kirillhunters_goToBattle", new bool?(false)).Value)
		{
			return "xpbl_kirillLab3";
		}
		if (!bq.GetPrimitivePropertyValue<bool>("npc_xpbl_kirill_secondVoyage", new bool?(false)).Value)
		{
			return "xpbl_kirillLab2";
		}
		return null;
	}

	// Token: 0x060045E5 RID: 17893 RVA: 0x001C7DF8 File Offset: 0x001C5FF8
	public override string ce(cyt A_0, string A_1)
	{
		if (!string.Equals(A_1, "xpbl_kirillLab2", StringComparison.OrdinalIgnoreCase))
		{
			return null;
		}
		if (!A_0.r().GetPrimitivePropertyValue<bool>("powSrc_pwrSrc_xpbl_kirillLabPower", new bool?(false)).Value && !A_0.r().GetPrimitivePropertyValue<bool>("npc_xpbl_kirill_dead", new bool?(false)).Value && !A_0.r().GetPrimitivePropertyValue<bool>("npc_xpbl_kirillHunters_allied", new bool?(false)).Value)
		{
			return "default";
		}
		if (A_0.r().GetPrimitivePropertyValue<bool>("powSrc_pwrSrc_xpbl_kirillLabPower", new bool?(false)).Value && !A_0.r().GetPrimitivePropertyValue<bool>("npc_xpbl_kirill_dead", new bool?(false)).Value && A_0.r().GetPrimitivePropertyValue<bool>("npc_xpbl_kirillHunters_allied", new bool?(false)).Value)
		{
			return "preFight";
		}
		if (A_0.r().GetPrimitivePropertyValue<bool>("powSrc_pwrSrc_xpbl_kirillLabPower", new bool?(false)).Value && A_0.r().GetPrimitivePropertyValue<bool>("npc_xpbl_kirill_dead", new bool?(false)).Value && A_0.r().GetPrimitivePropertyValue<bool>("npc_xpbl_kirillHunters_allied", new bool?(false)).Value && A_0.r().GetPrimitivePropertyValue<bool>("loc_xpbl_kirillhunters_prepared", new bool?(false)).Value)
		{
			return "kirillDead";
		}
		return "default";
	}

	// Token: 0x060045E6 RID: 17894 RVA: 0x001C7F90 File Offset: 0x001C6190
	public override void cf(b0b A_0, cyt A_1, string A_2)
	{
		bm6 aspect = A_0.GetAspect<bm6>();
		string a_ = "characters\\xpbl\\Gritz";
		if (string.Equals(A_2, "xpbl_kirillLab2", StringComparison.OrdinalIgnoreCase) && aspect != null)
		{
			if (!A_1.r().GetPrimitivePropertyValue<bool>("powSrc_pwrSrc_xpbl_kirillLabPower", new bool?(false)).Value && !A_1.r().GetPrimitivePropertyValue<bool>("npc_xpbl_kirill_dead", new bool?(false)).Value && !A_1.r().GetPrimitivePropertyValue<bool>("npc_xpbl_kirillHunters_allied", new bool?(false)).Value)
			{
				aspect.y6()["GuardLoc"] = new bt4("global:xpbl_gritz:default");
			}
			else if (A_1.r().GetPrimitivePropertyValue<bool>("powSrc_pwrSrc_xpbl_kirillLabPower", new bool?(false)).Value && !A_1.r().GetPrimitivePropertyValue<bool>("npc_xpbl_kirill_dead", new bool?(false)).Value && A_1.r().GetPrimitivePropertyValue<bool>("npc_xpbl_kirillHunters_allied", new bool?(false)).Value)
			{
				if (!A_1.r().GetPrimitivePropertyValue<bool>("loc_xpbl_kirillhunters_prepared", new bool?(false)).Value)
				{
					a_ = "events\\xpbl\\kirill_preMutieHuntersBattle";
				}
				aspect.y6()["GuardLoc"] = new bt4("global:xpbl_gritz:preFight");
			}
			else if (A_1.r().GetPrimitivePropertyValue<bool>("powSrc_pwrSrc_xpbl_kirillLabPower", new bool?(false)).Value && A_1.r().GetPrimitivePropertyValue<bool>("npc_xpbl_kirill_dead", new bool?(false)).Value && A_1.r().GetPrimitivePropertyValue<bool>("npc_xpbl_kirillHunters_allied", new bool?(false)).Value && A_1.r().GetPrimitivePropertyValue<bool>("loc_xpbl_kirillhunters_prepared", new bool?(false)).Value)
			{
				a_ = "events\\xpbl\\kirill_postMutieHuntersBattle";
				aspect.y6()["GuardLoc"] = new bt4("global:xpbl_gritz:kirillDead");
			}
			else
			{
				aspect.y6()["GuardLoc"] = new bt4("global:xpbl_gritz:default");
			}
		}
		if (string.Equals(A_2, "xpbl_kirillLab3", StringComparison.OrdinalIgnoreCase) && aspect != null)
		{
			aspect.y6()["GuardLoc"] = new bt4("global:xpbl_gritz");
		}
		bn5 bn = A_0.GetAspect<j7>() as bn5;
		if (bn == null)
		{
			bn = new bn5(A_0 as c5x);
			bn.a(true);
			bn.b(true);
			A_0.SetAspect<j7>(bn);
		}
		bn.b(a_);
	}
}

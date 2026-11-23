using System;

// Token: 0x02000C08 RID: 3080
public sealed class b72 : jn
{
	// Token: 0x060045EF RID: 17903 RVA: 0x001C8C34 File Offset: 0x001C6E34
	public b72() : base("xpbl_senna", "creature\\characters\\xpbl\\senna")
	{
	}

	// Token: 0x060045F0 RID: 17904 RVA: 0x001C8C48 File Offset: 0x001C6E48
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

	// Token: 0x060045F1 RID: 17905 RVA: 0x001C8D20 File Offset: 0x001C6F20
	public override string ce(cyt A_0, string A_1)
	{
		if (!string.Equals(A_1, "xpbl_kirillLab2", StringComparison.OrdinalIgnoreCase))
		{
			return null;
		}
		if (A_0.r().GetPrimitivePropertyValue<bool>("powSrc_pwrSrc_xpbl_kirillLabPower", new bool?(false)).Value && !A_0.r().GetPrimitivePropertyValue<bool>("npc_xpbl_kirill_dead", new bool?(false)).Value && !A_0.r().GetPrimitivePropertyValue<bool>("npc_xpbl_kirillHunters_allied", new bool?(false)).Value)
		{
			return "fightKirill";
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

	// Token: 0x060045F2 RID: 17906 RVA: 0x001C8F24 File Offset: 0x001C7124
	public override void cf(b0b A_0, cyt A_1, string A_2)
	{
		bm6 aspect = A_0.GetAspect<bm6>();
		string a_ = "characters\\xpbl\\Senna";
		if (string.Equals(A_2, "xpbl_kirillLab2", StringComparison.OrdinalIgnoreCase) && aspect != null)
		{
			if (!A_1.r().GetPrimitivePropertyValue<bool>("powSrc_pwrSrc_xpbl_kirillLabPower", new bool?(false)).Value && !A_1.r().GetPrimitivePropertyValue<bool>("npc_xpbl_kirill_dead", new bool?(false)).Value && !A_1.r().GetPrimitivePropertyValue<bool>("npc_xpbl_kirillHunters_allied", new bool?(false)).Value)
			{
				aspect.y6()["GuardLoc"] = new bt4("global:xpbl_senna:default");
			}
			else if (A_1.r().GetPrimitivePropertyValue<bool>("powSrc_pwrSrc_xpbl_kirillLabPower", new bool?(false)).Value && !A_1.r().GetPrimitivePropertyValue<bool>("npc_xpbl_kirill_dead", new bool?(false)).Value && A_1.r().GetPrimitivePropertyValue<bool>("npc_xpbl_kirillHunters_allied", new bool?(false)).Value)
			{
				if (!A_1.r().GetPrimitivePropertyValue<bool>("loc_xpbl_kirillhunters_prepared", new bool?(false)).Value)
				{
					a_ = "events\\xpbl\\kirill_preMutieHuntersBattle";
				}
				aspect.y6()["GuardLoc"] = new bt4("global:xpbl_senna:preFight");
			}
			else if (A_1.r().GetPrimitivePropertyValue<bool>("powSrc_pwrSrc_xpbl_kirillLabPower", new bool?(false)).Value && A_1.r().GetPrimitivePropertyValue<bool>("npc_xpbl_kirill_dead", new bool?(false)).Value && A_1.r().GetPrimitivePropertyValue<bool>("npc_xpbl_kirillHunters_allied", new bool?(false)).Value && A_1.r().GetPrimitivePropertyValue<bool>("loc_xpbl_kirillhunters_prepared", new bool?(false)).Value)
			{
				a_ = "events\\xpbl\\kirill_postMutieHuntersBattle";
				aspect.y6()["GuardLoc"] = new bt4("global:xpbl_senna:kirillDead");
			}
			else
			{
				aspect.y6()["GuardLoc"] = new bt4("global:xpbl_senna:default");
			}
		}
		if (string.Equals(A_2, "xpbl_kirillLab3", StringComparison.OrdinalIgnoreCase) && aspect != null)
		{
			aspect.y6()["GuardLoc"] = new bt4("global:xpbl_senna");
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

using System;

// Token: 0x02000C04 RID: 3076
public sealed class e4i : jn
{
	// Token: 0x060045DF RID: 17887 RVA: 0x001C76CC File Offset: 0x001C58CC
	public e4i() : base("xpbl_juraj", "creature\\characters\\xpbl\\juraj")
	{
	}

	// Token: 0x060045E0 RID: 17888 RVA: 0x001C76E4 File Offset: 0x001C58E4
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

	// Token: 0x060045E1 RID: 17889 RVA: 0x001C77BC File Offset: 0x001C59BC
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

	// Token: 0x060045E2 RID: 17890 RVA: 0x001C79C0 File Offset: 0x001C5BC0
	public override void cf(b0b A_0, cyt A_1, string A_2)
	{
		bm6 aspect = A_0.GetAspect<bm6>();
		string a_ = "characters\\xpbl\\Juraj";
		if (string.Equals(A_2, "xpbl_kirillLab2", StringComparison.OrdinalIgnoreCase) && aspect != null)
		{
			amc aspect2 = A_0.GetAspect<amc>();
			if (aspect2 != null)
			{
				aspect2.aa().BaseSightRange = 5f;
				aspect2.aa().DetectionModifier = 0.1f;
			}
			if (!A_1.r().GetPrimitivePropertyValue<bool>("powSrc_pwrSrc_xpbl_kirillLabPower", new bool?(false)).Value && !A_1.r().GetPrimitivePropertyValue<bool>("npc_xpbl_kirill_dead", new bool?(false)).Value && !A_1.r().GetPrimitivePropertyValue<bool>("npc_xpbl_kirillHunters_allied", new bool?(false)).Value)
			{
				aspect.y6()["GuardLoc"] = new bt4("global:xpbl_juraj:default");
			}
			else if (A_1.r().GetPrimitivePropertyValue<bool>("powSrc_pwrSrc_xpbl_kirillLabPower", new bool?(false)).Value && !A_1.r().GetPrimitivePropertyValue<bool>("npc_xpbl_kirill_dead", new bool?(false)).Value && A_1.r().GetPrimitivePropertyValue<bool>("npc_xpbl_kirillHunters_allied", new bool?(false)).Value)
			{
				if (!A_1.r().GetPrimitivePropertyValue<bool>("loc_xpbl_kirillhunters_prepared", new bool?(false)).Value)
				{
					a_ = "events\\xpbl\\kirill_preMutieHuntersBattle";
				}
				aspect.y6()["GuardLoc"] = new bt4("global:xpbl_juraj:preFight");
			}
			else if (A_1.r().GetPrimitivePropertyValue<bool>("powSrc_pwrSrc_xpbl_kirillLabPower", new bool?(false)).Value && A_1.r().GetPrimitivePropertyValue<bool>("npc_xpbl_kirill_dead", new bool?(false)).Value && A_1.r().GetPrimitivePropertyValue<bool>("npc_xpbl_kirillHunters_allied", new bool?(false)).Value && A_1.r().GetPrimitivePropertyValue<bool>("loc_xpbl_kirillhunters_prepared", new bool?(false)).Value)
			{
				a_ = "events\\xpbl\\kirill_postMutieHuntersBattle";
				aspect.y6()["GuardLoc"] = new bt4("global:xpbl_juraj:kirillDead");
			}
			else if (A_1.r().GetPrimitivePropertyValue<bool>("pwrSrc_pwrSrc_xpbl_kirillLabPower", new bool?(false)).Value)
			{
				aspect.y6()["GuardLoc"] = new bt4("global:xpbl_juraj:fightKirill");
			}
			else
			{
				aspect.y6()["GuardLoc"] = new bt4("global:xpbl_juraj:default");
			}
		}
		if (string.Equals(A_2, "xpbl_kirillLab3", StringComparison.OrdinalIgnoreCase) && aspect != null)
		{
			amc aspect3 = A_0.GetAspect<amc>();
			if (aspect3 != null)
			{
				aspect3.aa().BaseSightRange = 12f;
				aspect3.aa().DetectionModifier = 1.2f;
			}
			aspect.y6()["GuardLoc"] = new bt4("global:xpbl_juraj");
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

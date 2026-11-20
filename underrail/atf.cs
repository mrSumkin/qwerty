using System;
using TimelapseVertigo.Rules;
using TimelapseVertigo.Rules.Characters;
using TimelapseVertigo.Rules.Items;

// Token: 0x02000C0B RID: 3083
public sealed class atf : jn
{
	// Token: 0x060045FC RID: 17916 RVA: 0x001C9A78 File Offset: 0x001C7C78
	public atf() : base("xpbl_lars", "creature\\characters\\xpbl\\lars")
	{
	}

	// Token: 0x060045FD RID: 17917 RVA: 0x001C9A90 File Offset: 0x001C7C90
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

	// Token: 0x060045FE RID: 17918 RVA: 0x001C9B68 File Offset: 0x001C7D68
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
		return "default";
	}

	// Token: 0x060045FF RID: 17919 RVA: 0x001C9C6C File Offset: 0x001C7E6C
	public override void cf(b0b A_0, cyt A_1, string A_2)
	{
		amc aspect = A_0.GetAspect<amc>();
		bm6 aspect2 = A_0.GetAspect<bm6>();
		string a_ = "characters\\xpbl\\Lars";
		if (aspect != null)
		{
			if (string.Equals(A_2, "xpbl_kirillLab2", StringComparison.OrdinalIgnoreCase))
			{
				if (A_1.ae() >= GameDifficulty.Hard)
				{
					cd1 cd = aspect.aa().Gear.j()[WeaponKey.Primary].Item;
					if (cd != null)
					{
						AmmoType item = AmmoType.ShotgunShell_3;
						cd.LoadedAmmo.Clear();
						for (int i = 0; i < cd.TypedDefinition.f(); i++)
						{
							cd.LoadedAmmo.Add(item);
						}
					}
				}
				if (!A_1.r().GetPrimitivePropertyValue<bool>("powSrc_pwrSrc_xpbl_kirillLabPower", new bool?(false)).Value && !A_1.r().GetPrimitivePropertyValue<bool>("npc_xpbl_kirill_dead", new bool?(false)).Value && !A_1.r().GetPrimitivePropertyValue<bool>("npc_xpbl_kirillHunters_allied", new bool?(false)).Value)
				{
					aspect2.y6()["GuardLoc"] = new bt4("global:xpbl_lars:default");
				}
				else if (A_1.r().GetPrimitivePropertyValue<bool>("powSrc_pwrSrc_xpbl_kirillLabPower", new bool?(false)).Value && !A_1.r().GetPrimitivePropertyValue<bool>("npc_xpbl_kirill_dead", new bool?(false)).Value && A_1.r().GetPrimitivePropertyValue<bool>("npc_xpbl_kirillHunters_allied", new bool?(false)).Value)
				{
					if (!A_1.r().GetPrimitivePropertyValue<bool>("loc_xpbl_kirillhunters_prepared", new bool?(false)).Value)
					{
						a_ = "events\\xpbl\\kirill_preMutieHuntersBattle";
					}
					aspect2.y6()["GuardLoc"] = new bt4("global:xpbl_lars:preFight");
				}
				else
				{
					aspect2.y6()["GuardLoc"] = new bt4("global:xpbl_lars:default");
				}
			}
			if (string.Equals(A_2, "xpbl_kirillLab3", StringComparison.OrdinalIgnoreCase) && aspect2 != null)
			{
				aspect2.y6()["GuardLoc"] = new bt4("global:xpbl_lars");
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
}

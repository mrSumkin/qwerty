using System;
using System.Linq;
using TimelapseVertigo.Rules;

// Token: 0x02000C06 RID: 3078
public sealed class ecu : jn
{
	// Token: 0x060045E7 RID: 17895 RVA: 0x001C8230 File Offset: 0x001C6430
	public ecu() : base("xpbl_kirill", "creature\\characters\\xpbl\\kirill")
	{
	}

	// Token: 0x060045E8 RID: 17896 RVA: 0x001C8244 File Offset: 0x001C6444
	public override string b1(cyt A_0)
	{
		bq8 bq = A_0.e();
		if (bq.GetPrimitivePropertyValue<bool>("npc_xpbl_kirill_secondVoyage", new bool?(false)).Value && !bq.GetPrimitivePropertyValue<bool>("npc_xpbl_kirill_refuge", new bool?(false)).Value)
		{
			return "xpbl_b6";
		}
		if (bq.GetPrimitivePropertyValue<bool>("npc_xpbl_kirill_refuge", new bool?(false)).Value)
		{
			return "xpbl_b7";
		}
		if (bq.GetPrimitivePropertyValue<bool>("npc_xpbl_kirillHunters_allied", new bool?(false)).Value && !bq.GetPrimitivePropertyValue<bool>("npc_xpbl_kirill_dead", new bool?(false)).Value && bq.GetPrimitivePropertyValue<bool>("powSrc_pwrSrc_xpbl_kirillLabPower", new bool?(false)).Value && bq.GetPrimitivePropertyValue<bool>("loc_xpbl_kirillhunters_prepared", new bool?(false)).Value)
		{
			return "xpbl_kirillLab3";
		}
		if (bq.GetPrimitivePropertyValue<bool>("npc_xpbl_kirill_firstVoyage", new bool?(false)).Value && bq.GetPrimitivePropertyValue<bool>("npc_xpbl_kirill_acidJump", new bool?(false)).Value)
		{
			return "xpbl_kirillLab2";
		}
		if (bq.GetPrimitivePropertyValue<bool>("npc_xpbl_kirill_firstVoyage", new bool?(false)).Value && !bq.GetPrimitivePropertyValue<bool>("npc_xpbl_kirill_acidJump", new bool?(false)).Value)
		{
			return "xpbl_kirillLab1";
		}
		if (!bq.GetPrimitivePropertyValue<bool>("npc_xpbl_kirill_firstVoyage", new bool?(false)).Value)
		{
			return "xpbl_cc_s2";
		}
		return null;
	}

	// Token: 0x060045E9 RID: 17897 RVA: 0x001C83E8 File Offset: 0x001C65E8
	public override string ce(cyt A_0, string A_1)
	{
		if (!string.Equals(A_1, "xpbl_kirillLab2", StringComparison.OrdinalIgnoreCase))
		{
			return null;
		}
		if (A_0.r().GetPrimitivePropertyValue<bool>("powSrc_pwrSrc_xpbl_kirillLabPower", new bool?(false)).Value && A_0.r().GetPrimitivePropertyValue<bool>("npc_xpbl_kirillAtLab", new bool?(false)).Value)
		{
			return "room";
		}
		if (A_0.r().GetPrimitivePropertyValue<bool>("npc_xpbl_kirillFeed", new bool?(false)).Value)
		{
			return "kirillEat";
		}
		return "limbo";
	}

	// Token: 0x060045EA RID: 17898 RVA: 0x001C8484 File Offset: 0x001C6684
	public override void cf(b0b A_0, cyt A_1, string A_2)
	{
		amc aspect = A_0.GetAspect<amc>();
		if (aspect != null)
		{
			if (aspect.aa().Gear.l().Item != null && aspect.aa().Gear.l().Item.fu().f() != null && aspect.aa().Gear.l().Item.fu().f().Count > 0)
			{
				aspect.aa().Gear.l().Item.fu().f().Clear();
			}
			if (aspect.aa().CustomProperties.GetPrimitivePropertyValue<bool>("BaseStatAdjusted", null) == null)
			{
				aspect.aa().CustomProperties["BaseStatAdjusted"] = false;
			}
			if (A_1.ae() >= GameDifficulty.Dominating)
			{
				bool? primitivePropertyValue = aspect.aa().CustomProperties.GetPrimitivePropertyValue<bool>("BaseStatAdjusted", null);
				bool flag = false;
				if (primitivePropertyValue.GetValueOrDefault() == flag & primitivePropertyValue != null)
				{
					aspect.aa().CustomProperties["BaseStatAdjusted"] = true;
					rs rs = aspect.aa().Skills.Get<rs>();
					rs.a(rs.f() + 45);
					axa axa = aspect.aa().BaseAbilities.Get<axa>();
					axa.a(axa.f() - 7);
				}
			}
			bm6 aspect2 = A_0.GetAspect<bm6>();
			if (string.Equals(A_2, "xpbl_kirillLab2", StringComparison.OrdinalIgnoreCase))
			{
				if (A_1.r().GetPrimitivePropertyValue<bool>("npc_xpbl_kirillFeed", new bool?(false)).Value)
				{
					aspect2.y6()[ddq.ay] = new bt4("global:xpbl_kirill:kirillEat");
				}
				else
				{
					aspect2.y6()[ddq.ay] = new bt4("global:xpbl_kirill:room");
				}
			}
			if (string.Equals(A_2, "xpbl_kirillLab3", StringComparison.OrdinalIgnoreCase) && aspect.aa().Gear.h().Item == null)
			{
				xm xm = new xm();
				xm.na(28);
				xm.nc(30);
				cgd cgd = Enumerable.FirstOrDefault<coh>(xm.np()) as cgd;
				if (cgd != null)
				{
					cgd.Battery = (double)cgd.MaxBattery;
					aspect.aa().Gear.h().a(cgd, true);
				}
			}
			if (string.Equals(A_2, "xpbl_b6", StringComparison.OrdinalIgnoreCase))
			{
				A_1.r()["npc_xpbl_kirill_refuge"] = true;
				aspect2.y6().RemoveProperty(ddq.w);
			}
			if (string.Equals(A_2, "xpbl_b7", StringComparison.OrdinalIgnoreCase))
			{
				aspect2.y6().RemoveProperty(ddq.bg);
			}
		}
	}
}

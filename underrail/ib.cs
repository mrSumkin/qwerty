using System;
using System.Linq;
using TimelapseVertigo.Rules.Characters;

// Token: 0x02000C4A RID: 3146
public sealed class ib : jn
{
	// Token: 0x060046CD RID: 18125 RVA: 0x001D33E0 File Offset: 0x001D15E0
	public ib() : base("gorsky", "creature\\characters\\gorsky")
	{
	}

	// Token: 0x060046CE RID: 18126 RVA: 0x001D33F4 File Offset: 0x001D15F4
	public override string b1(cyt A_0)
	{
		if (A_0.r().GetPrimitivePropertyValue<bool>("quest_cc_retakeOutpostForGorsky_started", new bool?(false)).Value)
		{
			if (A_0.r().GetPrimitivePropertyValue<bool>("quest_cc_retakeOutpostForGorsky_invaded", new bool?(false)).Value)
			{
				return "cc_abandoned";
			}
			return "cc16";
		}
		else if (A_0.r().GetPrimitivePropertyValue<bool>("facelessInvaded", new bool?(false)).Value)
		{
			if (!A_0.r().GetPrimitivePropertyValue<bool>("npc_tanner_talkedAboutInvasion", new bool?(false)).Value && !A_0.r().GetPrimitivePropertyValue<bool>("loc_cc_facelessRetreated", new bool?(false)).Value)
			{
				return "StationAlpha-Level3";
			}
			return "cc_bar";
		}
		else
		{
			if (A_0.r().GetPrimitivePropertyValue<bool>("npc_tanner_startedTalkingAboutGangSupport", new bool?(false)).Value && !A_0.r().GetPrimitivePropertyValue<bool>("npc_tanner_endedTalkingAboutGangSupport", new bool?(false)).Value)
			{
				return "StationAlpha-Level4";
			}
			if (!A_0.r().GetPrimitivePropertyValue<bool>("introDone", new bool?(false)).Value)
			{
				return "StationAlpha-Level3";
			}
			if (A_0.r().GetPrimitivePropertyValue<bool>("talkToBretForRoundupStart", new bool?(false)).Value && A_0.r().GetPrimitivePropertyValue<int>("quest_theVault_state", new int?(0)).Value <= 1)
			{
				return "GammaCompound1";
			}
			return "StationAlpha-Level2";
		}
	}

	// Token: 0x060046CF RID: 18127 RVA: 0x001D3590 File Offset: 0x001D1790
	public override void cf(b0b A_0, cyt A_1, string A_2)
	{
		string a_;
		string a_2;
		if (string.Equals(A_2, "cc_abandoned"))
		{
			if (A_1.r().GetPrimitivePropertyValue<bool>("quest_cc_retakeOutpostForGorsky_tidyUp", new bool?(false)).Value)
			{
				a_ = "global:gorsky:tidy";
			}
			else if (A_1.r().GetPrimitivePropertyValue<bool>("quest_cc_retakeOutpostForGorsky_unboarded", new bool?(false)).Value)
			{
				a_ = "global:gorsky:ub";
			}
			else
			{
				a_ = "global:gorsky";
			}
			a_2 = "characters\\gorsky1";
		}
		else if (string.Equals(A_2, "cc_bar", StringComparison.OrdinalIgnoreCase) || string.Equals(A_2, "cc16", StringComparison.OrdinalIgnoreCase))
		{
			a_ = "global:gorsky";
			a_2 = "characters\\gorsky1";
		}
		else if (A_2 == "StationAlpha-Level3" && A_1.r().GetPrimitivePropertyValue<bool>("facelessInvaded", new bool?(false)).Value && !A_1.r().GetPrimitivePropertyValue<bool>("npc_tanner_talkedAboutInvasion", new bool?(false)).Value)
		{
			a_2 = "events\\sgs_invasionMeeting";
			a_ = "global:gorsky";
		}
		else if (string.Equals(A_2, "GammaCompound1"))
		{
			a_2 = "characters\\gorsky_gms";
			a_ = "guard_gorsky";
		}
		else
		{
			a_2 = "characters\\gorsky1";
			a_ = "guard3";
		}
		bn5 bn = A_0.GetAspect<j7>() as bn5;
		if (bn == null)
		{
			bn = new bn5(A_0 as c5x);
			A_0.SetAspect<j7>(bn);
		}
		bm6 aspect = A_0.GetAspect<bm6>();
		if (aspect != null)
		{
			aspect.y6()[ddq.ay] = new bt4(a_);
		}
		bn.b(a_2);
		amc aspect2 = A_0.GetAspect<amc>();
		e3l e3l = A_0.GetAspect<e3l>();
		if (aspect2 != null)
		{
			if (A_2.ToLower().StartsWith("cc_"))
			{
				aspect2.aa().FactionId = asp.dw;
			}
			else
			{
				aspect2.aa().FactionId = asp.f;
			}
			if (string.Equals(A_2, "cc_bar", StringComparison.OrdinalIgnoreCase))
			{
				if (e3l == null)
				{
					e3l = new e3l(A_0 as c5x);
					A_0.SetAspect<e3l>(e3l);
				}
				if (!e3l.a.Contains("GotCocktail"))
				{
					aspect2.aa().Bag.z3(new d48(ez2.CreateDefinitonProvider<cv9>("Consumables\\Food\\Cocktails\\BloodyOligarch")), true);
					e3l.a.Add("GotCocktail");
				}
				if (!e3l.a.Contains("GotAssaultRifle"))
				{
					b2d b2d = new b2d();
					b2d.na(20);
					b2d.nc(20);
					b2d.d(100);
					foreach (coh coh in b2d.np())
					{
						if (coh is cd1)
						{
							euf.a(coh, null);
							aspect2.aa().Bag.z3(aspect2.aa().Gear.j()[WeaponKey.Primary].Item, true);
							aspect2.aa().Gear.j()[WeaponKey.Primary].a(coh as cd1, true);
						}
						else
						{
							aspect2.aa().Bag.z3(coh, true);
						}
					}
					e3l.a.Add("GotAssaultRifle");
				}
			}
			else if (string.Equals(A_2, "cc16", StringComparison.OrdinalIgnoreCase))
			{
				aspect2.aa().Bag.a("cocktail.bloodyOligarch", 99);
			}
			if (e3l != null && e3l.a.Contains("GotAssaultRifle") && !e3l.a.Contains("AssaultRifleFixed"))
			{
				foreach (coh coh2 in Enumerable.ToList<coh>(aspect2.aa().Bag.z2()))
				{
					if (coh2 is cd1 && (coh2 as cd1).TypedDefinition.e() == btz.c)
					{
						aspect2.aa().Bag.z5(coh2);
					}
				}
				e3l.a.Add("AssaultRifleFixed");
			}
		}
	}

	// Token: 0x060046D0 RID: 18128 RVA: 0x001D3A08 File Offset: 0x001D1C08
	public override string ce(cyt A_0, string A_1)
	{
		if (!string.Equals(A_1, "cc_abandoned", StringComparison.OrdinalIgnoreCase))
		{
			return null;
		}
		if (A_0.r().GetPrimitivePropertyValue<bool>("quest_cc_retakeOutpostForGorsky_tidyUp", new bool?(false)).Value)
		{
			return "tidy";
		}
		if (A_0.r().GetPrimitivePropertyValue<bool>("quest_cc_retakeOutpostForGorsky_unboarded", new bool?(false)).Value)
		{
			return "ub";
		}
		return null;
	}
}

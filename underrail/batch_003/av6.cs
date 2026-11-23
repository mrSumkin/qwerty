using System;
using System.Collections.Generic;
using System.Linq;
using TimelapseVertigo.Playfield.CustomLogic.Data;
using TimelapseVertigo.Rules.Characters;

// Token: 0x02000C09 RID: 3081
public sealed class av6 : jn
{
	// Token: 0x060045F3 RID: 17907 RVA: 0x001C91C4 File Offset: 0x001C73C4
	public override string cc()
	{
		return "xpbl";
	}

	// Token: 0x060045F4 RID: 17908 RVA: 0x001C91CC File Offset: 0x001C73CC
	public av6() : base("xpbl_ninja", "creature\\characters\\xpbl\\Ninja")
	{
	}

	// Token: 0x060045F5 RID: 17909 RVA: 0x001C91E4 File Offset: 0x001C73E4
	public override string b1(cyt A_0)
	{
		string classPropertyValue = A_0.r().GetClassPropertyValue<string>("global_xpbl_acorn_gaveTo");
		if (!A_0.r().GetPrimitivePropertyValue<bool>("npc_xpbl_ninja_leftForGood", new bool?(false)).Value && (classPropertyValue == null || (classPropertyValue != null && classPropertyValue != "oldfield")))
		{
			this.a(A_0);
			if (A_0.r().GetPrimitivePropertyValue<bool>("npc_xpbl_ninja_stalkingPlayer", new bool?(false)).Value)
			{
				TimeSpan? primitivePropertyValue = A_0.r().GetPrimitivePropertyValue<TimeSpan>("npc_xpbl_ninja_nextAmbush", null);
				int num = 20;
				if (primitivePropertyValue == null || primitivePropertyValue.Value <= A_0.p())
				{
					string text;
					if (d39.a(A_0, null).TryGetValue(PlayerHouseElement.MainFloorDebris, out text) && text != null && text == "cleared" && !A_0.r().GetPrimitivePropertyValue<bool>("loc_cc_ph_hasOccupants", new bool?(false)).Value && A_0.r().GetPrimitivePropertyValue<int>("loc_cc_ph_securityLevel", new int?(0)).Value < 5)
					{
						A_0.r()["npc_xpbl_ninja_nextAmbush"] = A_0.p() + TimeSpan.FromMinutes((double)num);
						return "cc_ph";
					}
					if (Enumerable.Any<string>(new List<string>
					{
						"up_tch",
						"lu-b12",
						"up-lift",
						"up5",
						"up9",
						"lu-b22",
						"lu-b23",
						"lu-b25"
					}, new Func<string, bool>(A_0.c().b().Contains)))
					{
						A_0.r()["npc_xpbl_ninja_nextAmbush"] = A_0.p() + TimeSpan.FromMinutes((double)num);
						return A_0.c().b();
					}
				}
				return null;
			}
			if (A_0.r().GetPrimitivePropertyValue<bool>("playerEnteredBlackSea", new bool?(false)).Value)
			{
				return "cc-res";
			}
		}
		A_0.r()["npc_xpbl_ninja_inDominatingBar"] = false;
		return null;
	}

	// Token: 0x060045F6 RID: 17910 RVA: 0x001C9444 File Offset: 0x001C7644
	public override string ce(cyt A_0, string A_1)
	{
		if (!string.Equals(A_1, "cc_ph", StringComparison.OrdinalIgnoreCase))
		{
			return null;
		}
		string text;
		if (d39.a(A_0, null).TryGetValue(PlayerHouseElement.LowerFloorDebris, out text) && text != null && text == "cleared")
		{
			return "basement";
		}
		return "livingRoom";
	}

	// Token: 0x060045F7 RID: 17911 RVA: 0x001C949C File Offset: 0x001C769C
	public override void cf(b0b A_0, cyt A_1, string A_2)
	{
		Dictionary<PlayerHouseElement, string> dictionary = d39.a(A_1, null);
		amc aspect = A_0.GetAspect<amc>();
		if (aspect != null)
		{
			if (string.Equals(A_2, "cc-res", StringComparison.OrdinalIgnoreCase))
			{
				aspect.aa().SpecialAbilities.a(dgk.Get<e5b>());
				aspect.aa().FactionId = asp.di;
				A_1.r()["npc_xpbl_ninja_inDominatingBar"] = true;
			}
			else
			{
				if (!aspect.aa().SpecialAbilities.a(typeof(e5b)))
				{
					aspect.aa().SpecialAbilities.b(dgk.Get<e5b>());
				}
				aspect.aa().FactionId = asp.fb;
				A_1.r()["npc_xpbl_ninja_inDominatingBar"] = false;
			}
			if (A_1.r().GetPrimitivePropertyValue<bool>("npc_xpbl_ninja_stalkingPlayer", new bool?(false)).Value)
			{
				aspect.aa().Defense.a(10000, null, null, false, false, false, null);
				aspect.aa().Offense.a(WeaponKey.Primary);
				if (aspect.aa().Gear.h().Item != null)
				{
					aspect.aa().Gear.h().Item.Battery = (double)aspect.aa().Gear.h().Item.MaxBattery;
				}
			}
		}
		bm6 aspect2 = A_0.GetAspect<bm6>();
		if (aspect2 != null)
		{
			if (A_1.r().GetPrimitivePropertyValue<bool>("xpbl_ds3_acornTaken", new bool?(false)).Value)
			{
				aspect2.y6()[ddq.bc] = "npc_xpbl_ninja_met";
			}
			if (string.Equals(A_2, "cc-res", StringComparison.OrdinalIgnoreCase))
			{
				aspect2.y6()[ddq.bs] = new exw(d6n.c, 0.0, false, null);
			}
			else
			{
				aspect2.y6().RemoveProperty(ddq.bs);
			}
			if (string.Equals(A_2, "cc_ph", StringComparison.OrdinalIgnoreCase))
			{
				string text;
				if (dictionary.TryGetValue(PlayerHouseElement.LowerFloorDebris, out text) && text != null && text == "cleared")
				{
					aspect2.y6()[ddq.ay] = new bt4("global:xpbl_ninja:basement");
				}
				else
				{
					aspect2.y6()[ddq.ay] = new bt4("global:xpbl_ninja:livingRoom");
				}
				A_1.r()["loc_cc_ph_hasOccupants"] = true;
				A_1.r()["loc_cc_ph_hadTrespassers"] = true;
				return;
			}
			aspect2.y6()[ddq.ay] = new bt4("global:xpbl_ninja");
		}
	}

	// Token: 0x060045F8 RID: 17912 RVA: 0x001C9768 File Offset: 0x001C7968
	private void a(cyt A_0)
	{
		if (A_0.r().GetPrimitivePropertyValue<bool>("xpbl_ds3_acornTaken", new bool?(false)).Value && !A_0.r().GetPrimitivePropertyValue<bool>("npc_xpbl_ninja_stalkingPlayer", new bool?(false)).Value)
		{
			TimeSpan? primitivePropertyValue = A_0.r().GetPrimitivePropertyValue<TimeSpan>("npc_xpbl_ninja_waitTillStalking", null);
			if (primitivePropertyValue != null && primitivePropertyValue.Value <= A_0.p())
			{
				A_0.r()["npc_xpbl_ninja_stalkingPlayer"] = true;
				return;
			}
			if (A_0.r().GetPrimitivePropertyValue<bool>("npc_cc_jonTheBeautiful_talkedNinja", new bool?(false)).Value && !A_0.r().GetPrimitivePropertyValue<bool>("npc_xpbl_ninja_met", new bool?(false)).Value && primitivePropertyValue == null)
			{
				A_0.r()["npc_xpbl_ninja_waitTillStalking"] = A_0.p() + TimeSpan.FromMinutes(40.0);
				A_0.r()["npc_cc_dave_shouldMentionNinjaWasHere"] = true;
			}
			if ((A_0.ac() as bv9).abu(asp.di, asp.a).a == h.a)
			{
				A_0.r()["npc_xpbl_ninja_stalkingPlayer"] = true;
			}
		}
	}
}

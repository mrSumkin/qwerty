using System;
using TimelapseVertigo.Rules.Characters;
using TimelapseVertigo.Rules.Items;

// Token: 0x02000C2C RID: 3116
public sealed class ady : jn
{
	// Token: 0x06004678 RID: 18040 RVA: 0x001D1318 File Offset: 0x001CF518
	public ady() : base("ch_sarine", "creature\\characters\\ch_sarine")
	{
	}

	// Token: 0x06004679 RID: 18041 RVA: 0x001D132C File Offset: 0x001CF52C
	public override string b1(cyt A_0)
	{
		if (A_0.r().GetPrimitivePropertyValue<bool>("npc_ch_beck_survivedTheBattle", new bool?(false)).Value || (A_0.r().GetPrimitivePropertyValue<bool>("HathorKingSituationResolved", new bool?(false)).Value && !A_0.r().GetPrimitivePropertyValue<bool>("npc_ch_sarine_captured", new bool?(false)).Value) || (A_0.r().GetPrimitivePropertyValue<bool>("npc_ch_sarine_captured", new bool?(false)).Value && A_0.r().GetPrimitivePropertyValue<bool>("loc_rkl2_sarineDoorUnlocked", new bool?(false)).Value))
		{
			return null;
		}
		if (A_0.r().GetPrimitivePropertyValue<bool>("npc_ch_sarine_captured", new bool?(false)).Value)
		{
			return "rkl2";
		}
		if (A_0.r().GetPrimitivePropertyValue<bool>("npc_ch_sarine_jealous", new bool?(false)).Value || A_0.r().GetPrimitivePropertyValue<bool>("npc_ch_sarine_toldHopsy", new bool?(false)).Value)
		{
			return "cv15";
		}
		return "cv16";
	}

	// Token: 0x0600467A RID: 18042 RVA: 0x001D1464 File Offset: 0x001CF664
	public override void cf(b0b A_0, cyt A_1, string A_2)
	{
		if (A_0 != null)
		{
			bm6 aspect = A_0.GetAspect<bm6>();
			if (aspect != null)
			{
				if (string.Equals(A_2, "cv16", StringComparison.OrdinalIgnoreCase))
				{
					if (!A_1.r().GetPrimitivePropertyValue<bool>("beck_sarine_met", new bool?(false)).Value)
					{
						aspect.y6()["GuardLoc"] = new bt4("global:ch_sarine:withBeck");
					}
					else
					{
						aspect.y6()["GuardLoc"] = new bt4("global:ch_sarine:atHome");
					}
				}
				else
				{
					aspect.y6()["GuardLoc"] = new bt4("global:ch_sarine");
					aspect.y6().RemoveProperty(ddq.bg);
				}
				if (string.Equals(A_2, "rkl2", StringComparison.OrdinalIgnoreCase))
				{
					aspect.y6()["VigilanceSettings"] = new exw(d6n.a, 0.0, false, null);
				}
				else
				{
					aspect.y6().RemoveProperty(ddq.bs);
				}
			}
			amc aspect2 = A_0.GetAspect<amc>();
			if (aspect2 != null)
			{
				if (string.Equals(A_2, "cv16", StringComparison.OrdinalIgnoreCase))
				{
					aspect2.aa().HostilityBroadcastMode = c2n.c;
					if (aspect2.aa().SpecialStates.c || aspect2.aa().SpecialStates.a)
					{
						aspect2.aa().StatusEffects.c();
						aspect2.aa().FactionId = asp.ct;
						eaq eaq = new eaq();
						eaq.b(asp.a);
						eaq.a(asp.ct);
						eaq.a(h.a);
						eaq.a(true);
						eaq.ym(null, null, null);
					}
				}
				else
				{
					aspect2.aa().HostilityBroadcastMode = c2n.b;
				}
				if (string.Equals(A_2, "rkl2", StringComparison.OrdinalIgnoreCase))
				{
					if (A_1.r().GetPrimitivePropertyValue<bool>("npc_rathoundKingDies", new bool?(false)).Value)
					{
						a3f a3f = A_0.GetAspect<a3f>();
						if (a3f == null)
						{
							a3f = new a3f(A_0);
							A_0.SetAspect<a3f>(a3f);
						}
						a3f.a()["BloodlessDeath"] = true;
						aspect2.aa().a(null, null, false);
					}
					aspect2.aa().StatusEffects.c();
					aspect2.aa().Defense.a(1000, null, null, false, false, false, null);
					aspect2.aa().FactionId = "campHathor_sarine";
					ItemSlot<coh>[] array = aspect2.aa().Gear.d();
					for (int i = 0; i < array.Length; i++)
					{
						array[i].a(null, true);
					}
					aspect2.aa().Gear.j()[WeaponKey.Primary].a(null, true);
					aspect2.aa().Gear.j()[WeaponKey.Secondary].a(null, true);
					aspect2.aa().Bag.z7();
				}
			}
		}
	}

	// Token: 0x0600467B RID: 18043 RVA: 0x001D1768 File Offset: 0x001CF968
	public override string ce(cyt A_0, string A_1)
	{
		if (!string.Equals(A_1, "cv16", StringComparison.OrdinalIgnoreCase))
		{
			return null;
		}
		if (!A_0.r().GetPrimitivePropertyValue<bool>("beck_sarine_met", new bool?(false)).Value)
		{
			return "withBeck";
		}
		return "atHome";
	}
}

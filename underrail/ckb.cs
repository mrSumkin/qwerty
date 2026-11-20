using System;
using TimelapseVertigo.Rules.Characters;

// Token: 0x02000BEB RID: 3051
public sealed class ckb : jn
{
	// Token: 0x06004596 RID: 17814 RVA: 0x001C4A94 File Offset: 0x001C2C94
	public ckb() : base("RahmUmbra", "creature\\characters\\RahmUmbra")
	{
	}

	// Token: 0x06004597 RID: 17815 RVA: 0x001C4AA8 File Offset: 0x001C2CA8
	public override bool cd()
	{
		return true;
	}

	// Token: 0x06004598 RID: 17816 RVA: 0x001C4AB0 File Offset: 0x001C2CB0
	public override string b1(cyt A_0)
	{
		if (A_0.r().GetPrimitivePropertyValue<bool>("loc_tch_invasionStarted", new bool?(false)).Value && !A_0.r().GetPrimitivePropertyValue<bool>("npc_rahm-umbra_metInDeepCaverns", new bool?(false)).Value && !A_0.r().GetPrimitivePropertyValue<bool>("loc_dc_gateOpened", new bool?(false)).Value)
		{
			return "dc-entry";
		}
		if (A_0.r().GetPrimitivePropertyValue<bool>("global_sawTchoristsSnatchCube", new bool?(false)).Value && !A_0.r().GetPrimitivePropertyValue<bool>("npc_rahm-umbra_metAtInstitute", new bool?(false)).Value && !A_0.r().GetPrimitivePropertyValue<bool>("loc_tch_invasionStarted", new bool?(false)).Value)
		{
			return "tch-wwg";
		}
		if (!A_0.r().GetPrimitivePropertyValue<bool>("global_sawTchoristsSnatchCube", new bool?(false)).Value && A_0.r().GetPrimitivePropertyValue<bool>("global_heardAboutAcidHunters", new bool?(false)).Value)
		{
			return "wa-lower";
		}
		return null;
	}

	// Token: 0x06004599 RID: 17817 RVA: 0x001C4BE8 File Offset: 0x001C2DE8
	public override void cf(b0b A_0, cyt A_1, string A_2)
	{
		if (A_0 != null)
		{
			amc aspect = A_0.GetAspect<amc>();
			if (aspect != null)
			{
				aspect.aa().Immunities |= CharacterImmunities.TemporalEffects;
				aspect.aa().Attributes |= d8o.v;
				if (string.Equals(A_2, "wa-lower", StringComparison.OrdinalIgnoreCase))
				{
					aspect.aa().FactionId = asp.l;
				}
				else if (string.Equals(A_2, "dc-entry", StringComparison.OrdinalIgnoreCase) && !A_1.r().GetPrimitivePropertyValue<bool>("npc_rahmUmbra_checkHostile", new bool?(false)).Value)
				{
					A_1.r()["npc_rahmUmbra_checkHostile"] = true;
					aspect.aa().FactionId = asp.er;
					bv9 bv = A_1.ac() as bv9;
					bv.abu(asp.er, asp.a);
					aspect.aa().c(asp.a);
					bv.a(asp.er, asp.a, h.c, null, true, false, false);
				}
				else
				{
					aspect.aa().FactionId = asp.er;
				}
			}
			bm6 aspect2 = A_0.GetAspect<bm6>();
			if (aspect2 != null)
			{
				if (string.Equals(A_2, "tch-wwg", StringComparison.OrdinalIgnoreCase))
				{
					aspect2.y6()[ddq.bc] = "npc_rahm-umbra_metAtInstitute";
					aspect2.y6()[ddq.bd] = 12.0;
					return;
				}
				if (string.Equals(A_2, "dc-entry", StringComparison.OrdinalIgnoreCase))
				{
					aspect2.y6()[ddq.bc] = "npc_rahm-umbra_metInDeepCaverns";
					aspect2.y6()[ddq.bd] = 8.0;
					return;
				}
				aspect2.y6().RemoveProperty(ddq.bc);
				aspect2.y6().RemoveProperty(ddq.bd);
			}
		}
	}
}

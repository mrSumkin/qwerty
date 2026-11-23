using System;

// Token: 0x02000BFC RID: 3068
public sealed class dz9 : jn
{
	// Token: 0x060045C6 RID: 17862 RVA: 0x001C68D8 File Offset: 0x001C4AD8
	public dz9() : base("cc_jonTheBeautiful", "creature\\characters\\cc_jonTheBeautiful")
	{
	}

	// Token: 0x060045C7 RID: 17863 RVA: 0x001C68EC File Offset: 0x001C4AEC
	public override string b1(cyt A_0)
	{
		if (A_0.r().GetPrimitivePropertyValue<bool>("npc_cc_jonBeautiful_met", new bool?(false)).Value)
		{
			if (A_0.r().GetPrimitivePropertyValue<bool>("xpbl_ds3_acornTaken", new bool?(false)).Value && !A_0.r().GetPrimitivePropertyValue<bool>("npc_xpbl_ninja_leftForGood", new bool?(false)).Value && !A_0.r().GetPrimitivePropertyValue<bool>("npc_cc_jonTheBeautiful_talkedNinja", new bool?(false)).Value && !A_0.r().GetPrimitivePropertyValue<bool>("npc_xpbl_ninja_stalkingPlayer", new bool?(false)).Value)
			{
				string classPropertyValue = A_0.r().GetClassPropertyValue<string>("global_xpbl_acorn_gaveTo");
				if (classPropertyValue == null || (classPropertyValue != null && classPropertyValue != "oldfield"))
				{
					A_0.r()["npc_cc_jonTheBeautiful_shouldTellAboutNinja"] = true;
					if (string.Equals(A_0.c().b(), "cc1", StringComparison.OrdinalIgnoreCase) || string.Equals(A_0.c().b(), "cc_dock", StringComparison.OrdinalIgnoreCase))
					{
						return A_0.c().b();
					}
				}
				else if (A_0.r().GetPrimitivePropertyValue<bool>("npc_cc_jonTheBeautiful_shouldTellAboutNinja", new bool?(false)).Value)
				{
					A_0.r()["npc_cc_jonTheBeautiful_shouldTellAboutNinja"] = false;
				}
			}
			return "cc12";
		}
		if (string.Equals(A_0.c().b(), "cc1", StringComparison.OrdinalIgnoreCase) || string.Equals(A_0.c().b(), "cc_dock", StringComparison.OrdinalIgnoreCase))
		{
			return A_0.c().b();
		}
		return "cc1";
	}

	// Token: 0x060045C8 RID: 17864 RVA: 0x001C6AB4 File Offset: 0x001C4CB4
	public override void cf(b0b A_0, cyt A_1, string A_2)
	{
		base.cf(A_0, A_1, A_2);
		bm6 aspect = A_0.GetAspect<bm6>();
		if (aspect != null)
		{
			if (A_1.r().GetPrimitivePropertyValue<bool>("npc_cc_jonTheBeautiful_shouldTellAboutNinja", new bool?(false)).Value && !A_1.r().GetPrimitivePropertyValue<bool>("npc_cc_jonTheBeautiful_talkedNinja", new bool?(false)).Value)
			{
				aspect.y6()[ddq.bc] = "npc_cc_jonTheBeautiful_talkedNinja";
			}
			else
			{
				aspect.y6()[ddq.bc] = "npc_cc_jonBeautiful_met";
			}
		}
		amc aspect2 = A_0.GetAspect<amc>();
		if (aspect2 != null && aspect2.am() != "jon")
		{
			aspect2.a("jon");
		}
	}
}

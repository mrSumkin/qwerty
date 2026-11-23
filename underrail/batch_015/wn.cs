using System;

// Token: 0x02000C35 RID: 3125
public sealed class wn : jn
{
	// Token: 0x06004693 RID: 18067 RVA: 0x001D2108 File Offset: 0x001D0308
	public wn() : base("jy_garren", "creature\\characters\\jy_garren")
	{
	}

	// Token: 0x06004694 RID: 18068 RVA: 0x001D211C File Offset: 0x001D031C
	public override string b1(cyt A_0)
	{
		if (A_0.r().GetPrimitivePropertyValue<bool>("quest_fd_AttackSROCompleted", new bool?(false)).Value)
		{
			return "jye3";
		}
		if (A_0.r().GetPrimitivePropertyValue<bool>("quest_jygarrenAbramShowdown_started", new bool?(false)).Value && !A_0.r().GetPrimitivePropertyValue<bool>("quest_jygarrenAbramShowdown_finished", new bool?(false)).Value)
		{
			return "jyt5";
		}
		return "jy3";
	}

	// Token: 0x06004695 RID: 18069 RVA: 0x001D21A4 File Offset: 0x001D03A4
	public override void cf(b0b A_0, cyt A_1, string A_2)
	{
		if (A_0 != null)
		{
			bm6 aspect = A_0.GetAspect<bm6>();
			if (aspect != null)
			{
				if (A_2 == "jy3")
				{
					if (!A_1.r().GetPrimitivePropertyValue<bool>("npc_garren_movedInside", new bool?(false)).Value || A_1.r().GetPrimitivePropertyValue<bool>("quest_jygarrenAbramShowdown_finished", new bool?(false)).Value)
					{
						aspect.y6()["GuardLoc"] = new bt4("global:jy_garren");
						return;
					}
					aspect.y6()["GuardLoc"] = new bt4("GarrenInside");
					return;
				}
				else if (A_2 == "jyt5")
				{
					aspect.y6()["GuardLoc"] = null;
				}
			}
		}
	}
}

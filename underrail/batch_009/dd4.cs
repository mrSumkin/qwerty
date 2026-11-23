using System;
using System.Linq;

// Token: 0x02000881 RID: 2177
public sealed class dd4 : el4
{
	// Token: 0x060035BE RID: 13758 RVA: 0x00147D98 File Offset: 0x00145F98
	protected override esj a3()
	{
		return new esj(12, 6);
	}

	// Token: 0x060035BF RID: 13759 RVA: 0x00147DA4 File Offset: 0x00145FA4
	public override string a4()
	{
		return "Xpbl_WW_FLJ_VS_BLJ_X";
	}

	// Token: 0x060035C0 RID: 13760 RVA: 0x00147DAC File Offset: 0x00145FAC
	public override string a5()
	{
		return "Freelooters vs Black Eels Jet-to-jet Battle X";
	}

	// Token: 0x060035C1 RID: 13761 RVA: 0x00147DB4 File Offset: 0x00145FB4
	public override bool e2(cyt A_0, c1a A_1, bop A_2)
	{
		return base.e2(A_0, A_1, A_2) && (A_0.r().GetPrimitivePropertyValue<bool>("faction_xpbl_pirates_defeated", new bool?(false)).Value || A_0.r().GetPrimitivePropertyValue<bool>("npc_xpbl_pir_grim_dead", new bool?(false)).Value || !A_0.r().GetPrimitivePropertyValue<bool>("quests_xpbl_pirates_secondRaid_shipCleared", new bool?(false)).Value || !A_0.r().GetPrimitivePropertyValue<bool>("loc_xpbl_rig_sonarDestroyed", new bool?(false)).Value);
	}

	// Token: 0x060035C2 RID: 13762 RVA: 0x00147E60 File Offset: 0x00146060
	public override double ke()
	{
		return e3a.c;
	}

	// Token: 0x060035C3 RID: 13763 RVA: 0x00147E68 File Offset: 0x00146068
	protected override bool a6()
	{
		return true;
	}

	// Token: 0x060035C4 RID: 13764 RVA: 0x00147E6C File Offset: 0x0014606C
	protected override TimeSpan? a8()
	{
		return new TimeSpan?(TimeSpan.FromMinutes(5.0));
	}

	// Token: 0x060035C5 RID: 13765 RVA: 0x00147E84 File Offset: 0x00146084
	protected override bool kf()
	{
		return true;
	}

	// Token: 0x060035C6 RID: 13766 RVA: 0x00147E88 File Offset: 0x00146088
	public dd4() : base(new string[]
	{
		ega.bn,
		ega.bl,
		ega.bi,
		ega.bq
	})
	{
	}

	// Token: 0x060035C7 RID: 13767 RVA: 0x00147EB8 File Offset: 0x001460B8
	public override void ov(cyt A_0, c1a A_1, bop A_2)
	{
		base.ov(A_0, A_1, A_2);
		gx gx = new gx();
		string value = "_group1";
		string value2 = "_group2";
		if (cuo.a.Next(0, 2) == 0)
		{
			value = "_group2";
			value2 = "_group1";
		}
		foreach (csd csd in Enumerable.ToList<csd>(A_1.Waypoints))
		{
			c5x c5x = null;
			if (csd.Name.Contains(value))
			{
				c5x = gx.a(csd, new int?(20), "Generic_Jetski", "Чёрный угорь", asp.ae, "Sailors", "support\\xpbl\\jy_eel_jet1", true, null, false);
			}
			if (csd.Name.Contains(value2))
			{
				c5x = gx.a(csd, new int?(15), "Generic_Jetski", "Флибустьер", asp.ar, "Sailors", null, true, null, false);
			}
			if (c5x != null)
			{
				base.iy(c5x);
			}
		}
	}
}

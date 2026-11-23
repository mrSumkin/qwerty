using System;
using System.Linq;

// Token: 0x02000880 RID: 2176
public sealed class a3d : el4
{
	// Token: 0x060035B4 RID: 13748 RVA: 0x00147B58 File Offset: 0x00145D58
	protected override esj a3()
	{
		return new esj(6, 12);
	}

	// Token: 0x060035B5 RID: 13749 RVA: 0x00147B64 File Offset: 0x00145D64
	public override string a4()
	{
		return "Xpbl_WW_FLJ_VS_BLJ_Y";
	}

	// Token: 0x060035B6 RID: 13750 RVA: 0x00147B6C File Offset: 0x00145D6C
	public override string a5()
	{
		return "Freelooters vs Black Eels Jet-to-jet Battle Y";
	}

	// Token: 0x060035B7 RID: 13751 RVA: 0x00147B74 File Offset: 0x00145D74
	public override bool e2(cyt A_0, c1a A_1, bop A_2)
	{
		return base.e2(A_0, A_1, A_2) && (A_0.r().GetPrimitivePropertyValue<bool>("faction_xpbl_pirates_defeated", new bool?(false)).Value || A_0.r().GetPrimitivePropertyValue<bool>("npc_xpbl_pir_grim_dead", new bool?(false)).Value || !A_0.r().GetPrimitivePropertyValue<bool>("quests_xpbl_pirates_secondRaid_shipCleared", new bool?(false)).Value || !A_0.r().GetPrimitivePropertyValue<bool>("loc_xpbl_rig_sonarDestroyed", new bool?(false)).Value);
	}

	// Token: 0x060035B8 RID: 13752 RVA: 0x00147C20 File Offset: 0x00145E20
	public override double ke()
	{
		return e3a.c;
	}

	// Token: 0x060035B9 RID: 13753 RVA: 0x00147C28 File Offset: 0x00145E28
	protected override bool a6()
	{
		return true;
	}

	// Token: 0x060035BA RID: 13754 RVA: 0x00147C2C File Offset: 0x00145E2C
	protected override TimeSpan? a8()
	{
		return new TimeSpan?(TimeSpan.FromMinutes(5.0));
	}

	// Token: 0x060035BB RID: 13755 RVA: 0x00147C44 File Offset: 0x00145E44
	protected override bool kf()
	{
		return true;
	}

	// Token: 0x060035BC RID: 13756 RVA: 0x00147C48 File Offset: 0x00145E48
	public a3d() : base(new string[]
	{
		ega.bn,
		ega.bl,
		ega.bi,
		ega.br
	})
	{
	}

	// Token: 0x060035BD RID: 13757 RVA: 0x00147C78 File Offset: 0x00145E78
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

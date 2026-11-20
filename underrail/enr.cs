using System;
using System.Linq;

// Token: 0x0200087E RID: 2174
public sealed class enr : el4
{
	// Token: 0x060035A0 RID: 13728 RVA: 0x00147648 File Offset: 0x00145848
	protected override esj a3()
	{
		return new esj(6, 12);
	}

	// Token: 0x060035A1 RID: 13729 RVA: 0x00147654 File Offset: 0x00145854
	public override string a4()
	{
		return "Xpbl_WW_PIRJ_VS_BLJ_Y";
	}

	// Token: 0x060035A2 RID: 13730 RVA: 0x0014765C File Offset: 0x0014585C
	public override string a5()
	{
		return "Pirates vs Black Eels Jet-to-jet Battle Y";
	}

	// Token: 0x060035A3 RID: 13731 RVA: 0x00147664 File Offset: 0x00145864
	public override bool e2(cyt A_0, c1a A_1, bop A_2)
	{
		return base.e2(A_0, A_1, A_2) && (!A_0.r().GetPrimitivePropertyValue<bool>("faction_xpbl_pirates_defeated", new bool?(false)).Value && !A_0.r().GetPrimitivePropertyValue<bool>("npc_xpbl_pir_grim_dead", new bool?(false)).Value && A_0.r().GetPrimitivePropertyValue<bool>("quests_xpbl_pirates_secondRaid_shipCleared", new bool?(false)).Value && A_0.r().GetPrimitivePropertyValue<bool>("loc_xpbl_rig_sonarDestroyed", new bool?(false)).Value);
	}

	// Token: 0x060035A4 RID: 13732 RVA: 0x00147710 File Offset: 0x00145910
	public override double ke()
	{
		return e3a.b;
	}

	// Token: 0x060035A5 RID: 13733 RVA: 0x00147718 File Offset: 0x00145918
	protected override bool a6()
	{
		return true;
	}

	// Token: 0x060035A6 RID: 13734 RVA: 0x0014771C File Offset: 0x0014591C
	protected override TimeSpan? a8()
	{
		return new TimeSpan?(TimeSpan.FromMinutes(5.0));
	}

	// Token: 0x060035A7 RID: 13735 RVA: 0x00147734 File Offset: 0x00145934
	protected override bool kf()
	{
		return true;
	}

	// Token: 0x060035A8 RID: 13736 RVA: 0x00147738 File Offset: 0x00145938
	public enr() : base(new string[]
	{
		ega.bl,
		ega.bk,
		ega.bh,
		ega.br
	})
	{
	}

	// Token: 0x060035A9 RID: 13737 RVA: 0x00147768 File Offset: 0x00145968
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
				c5x = gx.a(csd, new int?(15), "Generic_Jetski", "Чёрный угорь", asp.ae, "Sailors", "support\\xpbl\\jy_eel_jet1", true, null, false);
			}
			if (csd.Name.Contains(value2))
			{
				c5x = gx.a(csd, new int?(10), "Pirates_Jetski", null, asp.fw, null, "support\\xpbl\\pir_raiders", false, null, false);
			}
			if (c5x != null)
			{
				if (c5x.h.b != null && c5x.h.b.aa().FactionId == asp.fw)
				{
					c5x.h.b.aa().HostilityBroadcastMode = c2n.c;
				}
				base.iy(c5x);
			}
		}
	}
}

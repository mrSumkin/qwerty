using System;
using System.Linq;

// Token: 0x0200087F RID: 2175
public sealed class enq : el4
{
	// Token: 0x060035AA RID: 13738 RVA: 0x001478D0 File Offset: 0x00145AD0
	protected override esj a3()
	{
		return new esj(12, 6);
	}

	// Token: 0x060035AB RID: 13739 RVA: 0x001478DC File Offset: 0x00145ADC
	public override string a4()
	{
		return "Xpbl_WW_PIRJ_VS_BLJ_X";
	}

	// Token: 0x060035AC RID: 13740 RVA: 0x001478E4 File Offset: 0x00145AE4
	public override string a5()
	{
		return "Pirates vs Black Eels Jet-to-jet Battle X";
	}

	// Token: 0x060035AD RID: 13741 RVA: 0x001478EC File Offset: 0x00145AEC
	public override bool e2(cyt A_0, c1a A_1, bop A_2)
	{
		return base.e2(A_0, A_1, A_2) && (!A_0.r().GetPrimitivePropertyValue<bool>("faction_xpbl_pirates_defeated", new bool?(false)).Value && !A_0.r().GetPrimitivePropertyValue<bool>("npc_xpbl_pir_grim_dead", new bool?(false)).Value && A_0.r().GetPrimitivePropertyValue<bool>("quests_xpbl_pirates_secondRaid_shipCleared", new bool?(false)).Value && A_0.r().GetPrimitivePropertyValue<bool>("loc_xpbl_rig_sonarDestroyed", new bool?(false)).Value);
	}

	// Token: 0x060035AE RID: 13742 RVA: 0x00147998 File Offset: 0x00145B98
	public override double ke()
	{
		return e3a.b;
	}

	// Token: 0x060035AF RID: 13743 RVA: 0x001479A0 File Offset: 0x00145BA0
	protected override bool a6()
	{
		return true;
	}

	// Token: 0x060035B0 RID: 13744 RVA: 0x001479A4 File Offset: 0x00145BA4
	protected override TimeSpan? a8()
	{
		return new TimeSpan?(TimeSpan.FromMinutes(5.0));
	}

	// Token: 0x060035B1 RID: 13745 RVA: 0x001479BC File Offset: 0x00145BBC
	protected override bool kf()
	{
		return true;
	}

	// Token: 0x060035B2 RID: 13746 RVA: 0x001479C0 File Offset: 0x00145BC0
	public enq() : base(new string[]
	{
		ega.bl,
		ega.bk,
		ega.bh,
		ega.bq
	})
	{
	}

	// Token: 0x060035B3 RID: 13747 RVA: 0x001479F0 File Offset: 0x00145BF0
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

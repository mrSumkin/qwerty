using System;
using System.Collections.Generic;
using TimelapseVertigo.Rules.Capabilities;
using TimelapseVertigo.Rules.Combat;

// Token: 0x02001EEE RID: 7918
[ayj("ThreadBotFlamethrowerAttack")]
public sealed class dw7 : c0z
{
	// Token: 0x0600B4B3 RID: 46259 RVA: 0x00408CDC File Offset: 0x00406EDC
	public override string y8()
	{
		return "Огнемёт";
	}

	// Token: 0x0600B4B4 RID: 46260 RVA: 0x00408CE4 File Offset: 0x00406EE4
	public override string os()
	{
		return "ThreadBotFlamethrowerAttack";
	}

	// Token: 0x0600B4B5 RID: 46261 RVA: 0x00408CEC File Offset: 0x00406EEC
	public override ci8 bg()
	{
		return ci8.c;
	}

	// Token: 0x0600B4B6 RID: 46262 RVA: 0x00408CF0 File Offset: 0x00406EF0
	public override int e8()
	{
		return 1;
	}

	// Token: 0x0600B4B7 RID: 46263 RVA: 0x00408CF4 File Offset: 0x00406EF4
	public override a3b c0()
	{
		return new a3b
		{
			a = c0e.a,
			c = c0e.g,
			e = c0e.h
		};
	}

	// Token: 0x0600B4B8 RID: 46264 RVA: 0x00408D1C File Offset: 0x00406F1C
	public override string c1()
	{
		return "Огнемёт";
	}

	// Token: 0x0600B4B9 RID: 46265 RVA: 0x00408D24 File Offset: 0x00406F24
	public dw7()
	{
		this.g = new List<string>();
		this.g.Add("SA.ThreadBotFlamethrowerAttack");
	}

	// Token: 0x0600B4BA RID: 46266 RVA: 0x00408D48 File Offset: 0x00406F48
	public override string bm(cnm A_0)
	{
		return null;
	}

	// Token: 0x0600B4BB RID: 46267 RVA: 0x00408D4C File Offset: 0x00406F4C
	public override SpellTargetType bn(cnm A_0)
	{
		return SpellTargetType.DiscoveredPenetrableSpot;
	}

	// Token: 0x0600B4BC RID: 46268 RVA: 0x00408D50 File Offset: 0x00406F50
	public override string bo(cnm A_0)
	{
		return null;
	}

	// Token: 0x0600B4BD RID: 46269 RVA: 0x00408D54 File Offset: 0x00406F54
	public override IList<cfd> bq(cnm A_0, v5 A_1)
	{
		return new List<cfd>
		{
			new cfd("SA.ThreadBotFlamethrowerAttack", dw7.b, false, false)
		};
	}

	// Token: 0x0600B4BE RID: 46270 RVA: 0x00408D74 File Offset: 0x00406F74
	public override IList<string> bi()
	{
		return this.g;
	}

	// Token: 0x0600B4BF RID: 46271 RVA: 0x00408D80 File Offset: 0x00406F80
	public new static a1q a(cnm A_0)
	{
		int num = 135;
		return new a1q
		{
			DamageType = DamageType.Heat,
			LowerBoundary = Convert.ToInt32(5.0 + 0.1 * (double)num),
			UpperBoundary = Convert.ToInt32(6.0 + 0.2 * (double)num)
		};
	}

	// Token: 0x0600B4C0 RID: 46272 RVA: 0x00408DE8 File Offset: 0x00406FE8
	protected override float f0(cnm A_0)
	{
		return 6f;
	}

	// Token: 0x0600B4C1 RID: 46273 RVA: 0x00408DF0 File Offset: 0x00406FF0
	protected override int hi(cnm A_0)
	{
		return 20;
	}

	// Token: 0x0600B4C2 RID: 46274 RVA: 0x00408DF4 File Offset: 0x00406FF4
	protected override int ma(cnm A_0)
	{
		return 1400;
	}

	// Token: 0x0600B4C3 RID: 46275 RVA: 0x00408DFC File Offset: 0x00406FFC
	protected override int mb(cnm A_0)
	{
		return 70;
	}

	// Token: 0x040041EC RID: 16876
	private new const string a = "SA.ThreadBotFlamethrowerAttack";

	// Token: 0x040041ED RID: 16877
	private static readonly int b = d0u.b;

	// Token: 0x040041EE RID: 16878
	private const double c = 5.0;

	// Token: 0x040041EF RID: 16879
	private const double d = 0.1;

	// Token: 0x040041F0 RID: 16880
	private new const double e = 0.2;

	// Token: 0x040041F1 RID: 16881
	public static double f = 0.2;

	// Token: 0x040041F2 RID: 16882
	private new List<string> g;
}

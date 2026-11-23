using System;
using System.Collections.Generic;
using TimelapseVertigo.Rules.Capabilities;

// Token: 0x0200183D RID: 6205
[ayj("QuickDrawAttack")]
public sealed class dxn : bon
{
	// Token: 0x06008452 RID: 33874 RVA: 0x00371BCC File Offset: 0x0036FDCC
	public override string y8()
	{
		return "Быстрый выхват";
	}

	// Token: 0x06008453 RID: 33875 RVA: 0x00371BD4 File Offset: 0x0036FDD4
	public override string os()
	{
		return "QuickDrawAttack";
	}

	// Token: 0x06008454 RID: 33876 RVA: 0x00371BDC File Offset: 0x0036FDDC
	public override ci8 bg()
	{
		return ci8.c;
	}

	// Token: 0x06008455 RID: 33877 RVA: 0x00371BE0 File Offset: 0x0036FDE0
	public override bool cs()
	{
		return false;
	}

	// Token: 0x06008456 RID: 33878 RVA: 0x00371BE4 File Offset: 0x0036FDE4
	public override int ct()
	{
		return 2;
	}

	// Token: 0x06008457 RID: 33879 RVA: 0x00371BE8 File Offset: 0x0036FDE8
	public override bool j7()
	{
		return false;
	}

	// Token: 0x06008458 RID: 33880 RVA: 0x00371BEC File Offset: 0x0036FDEC
	public override bool bk()
	{
		return true;
	}

	// Token: 0x06008459 RID: 33881 RVA: 0x00371BF0 File Offset: 0x0036FDF0
	public override bool i2()
	{
		return true;
	}

	// Token: 0x0600845A RID: 33882 RVA: 0x00371BF4 File Offset: 0x0036FDF4
	public dxn()
	{
		this.d = new List<string>();
		this.d.Add(d7f.a);
		this.d.Add("SAt.QuickDrawAttack");
	}

	// Token: 0x0600845B RID: 33883 RVA: 0x00371C28 File Offset: 0x0036FE28
	public override string bm(cnm A_0)
	{
		return "Attacks.42";
	}

	// Token: 0x0600845C RID: 33884 RVA: 0x00371C30 File Offset: 0x0036FE30
	public override SpellTargetType bn(cnm A_0)
	{
		return SpellTargetType.CreatureNotSelf;
	}

	// Token: 0x0600845D RID: 33885 RVA: 0x00371C34 File Offset: 0x0036FE34
	public override string bo(cnm A_0)
	{
		return qv.a("SpecialAttacks/QuickDraw", new object[]
		{
			Convert.ToInt32(dxn.c * 100.0)
		});
	}

	// Token: 0x0600845E RID: 33886 RVA: 0x00371C64 File Offset: 0x0036FE64
	public override string bp(cnm A_0)
	{
		return this.bo(A_0);
	}

	// Token: 0x0600845F RID: 33887 RVA: 0x00371C70 File Offset: 0x0036FE70
	private new static double a(cnm A_0)
	{
		double num = 1.0;
		if (A_0 != null && A_0.b8() != null)
		{
			num = Math.Max(0.0, num - dxn.c * (double)A_0.b8().Offense.ay());
		}
		return num;
	}

	// Token: 0x06008460 RID: 33888 RVA: 0x00371CC4 File Offset: 0x0036FEC4
	public override IList<cfd> bq(cnm A_0, v5 A_1)
	{
		List<cfd> list = new List<cfd>();
		if (A_1 == v5.b)
		{
			list.Add(new cfd(d7f.a, d7f.g, true, false));
		}
		list.Add(new cfd("SAt.QuickDrawAttack", dxn.b, false, false));
		return list;
	}

	// Token: 0x06008461 RID: 33889 RVA: 0x00371D10 File Offset: 0x0036FF10
	public override IList<string> bi()
	{
		return this.d;
	}

	// Token: 0x06008462 RID: 33890 RVA: 0x00371D18 File Offset: 0x0036FF18
	protected override int br(cnm A_0)
	{
		return 500;
	}

	// Token: 0x06008463 RID: 33891 RVA: 0x00371D20 File Offset: 0x0036FF20
	protected override int hi(cnm A_0)
	{
		return (int)((double)base.hi(A_0) * dxn.a(A_0));
	}

	// Token: 0x040032BA RID: 12986
	private new const string a = "SAt.QuickDrawAttack";

	// Token: 0x040032BB RID: 12987
	public static readonly int b = 5 * d0u.b;

	// Token: 0x040032BC RID: 12988
	public static readonly double c = 0.05;

	// Token: 0x040032BD RID: 12989
	private List<string> d;
}

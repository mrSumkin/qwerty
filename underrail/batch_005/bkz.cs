using System;
using System.Collections.Generic;
using TimelapseVertigo.Common;
using TimelapseVertigo.Rules.Capabilities;
using TimelapseVertigo.Rules.Combat;

// Token: 0x02001F48 RID: 8008
[ayj("throwStoneBolas")]
public sealed class bkz : c0r, bix
{
	// Token: 0x0600BACA RID: 47818 RVA: 0x004138E4 File Offset: 0x00411AE4
	public override string y8()
	{
		return "Бросок болы";
	}

	// Token: 0x0600BACB RID: 47819 RVA: 0x004138EC File Offset: 0x00411AEC
	public override string os()
	{
		return "throwStoneBolas";
	}

	// Token: 0x0600BACC RID: 47820 RVA: 0x004138F4 File Offset: 0x00411AF4
	public override string c1()
	{
		return "Бросает";
	}

	// Token: 0x0600BACD RID: 47821 RVA: 0x004138FC File Offset: 0x00411AFC
	public override SpellTargetType bn(cnm A_0)
	{
		return SpellTargetType.CreatureNotSelf;
	}

	// Token: 0x0600BACE RID: 47822 RVA: 0x00413900 File Offset: 0x00411B00
	public override ci8 bg()
	{
		return ci8.c;
	}

	// Token: 0x0600BACF RID: 47823 RVA: 0x00413904 File Offset: 0x00411B04
	public override a3b c0()
	{
		return new a3b
		{
			a = c0e.i,
			b = new int?(int.MaxValue),
			c = c0e.i
		};
	}

	// Token: 0x0600BAD0 RID: 47824 RVA: 0x00413934 File Offset: 0x00411B34
	public override TimelapseCursor? bj()
	{
		return new TimelapseCursor?(TimelapseCursor.InvokeHostileSpellWithChance);
	}

	// Token: 0x0600BAD1 RID: 47825 RVA: 0x00413940 File Offset: 0x00411B40
	public bkz()
	{
		this.e = new List<string>
		{
			"throwStoneBolas"
		};
	}

	// Token: 0x0600BAD2 RID: 47826 RVA: 0x00413960 File Offset: 0x00411B60
	public override string bo(cnm A_0)
	{
		return string.Empty;
	}

	// Token: 0x0600BAD3 RID: 47827 RVA: 0x00413968 File Offset: 0x00411B68
	public override string bp(cnm A_0)
	{
		return qv.a("Items\\Utilities/StoneBolas", new object[]
		{
			bkz.d.a(true),
			l4.a(10000.0, false),
			(int)(bsx.b * 100.0),
			l4.a(bsx.d, false),
			bsx.c
		});
	}

	// Token: 0x0600BAD4 RID: 47828 RVA: 0x004139DC File Offset: 0x00411BDC
	public override string bm(cnm A_0)
	{
		return "xpbl_Weapons.207";
	}

	// Token: 0x0600BAD5 RID: 47829 RVA: 0x004139E8 File Offset: 0x00411BE8
	public static int a(efk A_0)
	{
		return (int)(d05.b(0.25, 1.0 - (double)(A_0.BaseAbilities.Strength - 6) * 0.1, 1.0) * 10000.0);
	}

	// Token: 0x0600BAD6 RID: 47830 RVA: 0x00413A3C File Offset: 0x00411C3C
	public bg3 bs(cnm A_0, efk A_1, double A_2, double A_3, bool A_4, bool A_5, c3u A_6)
	{
		bg3 bg = new bg3();
		if (A_0 != null && A_0.b8() != null && A_1 != null)
		{
			int num = A_0.b8().Skills.Get<dei>().g();
			double value = 1.0 - qw.a((double)num, (double)A_1.Defense.z());
			bg.a = Math.Round(value, 2);
		}
		return bg;
	}

	// Token: 0x0600BAD7 RID: 47831 RVA: 0x00413AA8 File Offset: 0x00411CA8
	public override IList<cfd> bq(cnm A_0, v5 A_1)
	{
		return new List<cfd>
		{
			new cfd("throwStoneBolas", 20000, false, false)
		};
	}

	// Token: 0x0600BAD8 RID: 47832 RVA: 0x00413AC8 File Offset: 0x00411CC8
	public override IList<string> bi()
	{
		return this.e;
	}

	// Token: 0x0600BAD9 RID: 47833 RVA: 0x00413AD0 File Offset: 0x00411CD0
	protected override int br(cnm A_0)
	{
		return dgk.Get<d1n>().n(A_0);
	}

	// Token: 0x0600BADA RID: 47834 RVA: 0x00413AE0 File Offset: 0x00411CE0
	protected override float f0(cnm A_0)
	{
		return dgk.Get<d1n>().afi(A_0) * 0.75f;
	}

	// Token: 0x0600BADB RID: 47835 RVA: 0x00413AF4 File Offset: 0x00411CF4
	public override dsk cv(cnm A_0)
	{
		return dsk.b;
	}

	// Token: 0x0600BADC RID: 47836 RVA: 0x00413AF8 File Offset: 0x00411CF8
	protected override int hi(cnm A_0)
	{
		return 10;
	}

	// Token: 0x040043D0 RID: 17360
	private new const string a = "throwStoneBolas";

	// Token: 0x040043D1 RID: 17361
	private const int b = 20000;

	// Token: 0x040043D2 RID: 17362
	private const int c = 10000;

	// Token: 0x040043D3 RID: 17363
	public static readonly a1q d = new a1q(DamageType.Mechanical, 20, 40);

	// Token: 0x040043D4 RID: 17364
	private new List<string> e;
}

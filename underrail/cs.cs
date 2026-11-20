using System;
using System.Collections.Generic;
using TimelapseVertigo.Common;
using TimelapseVertigo.Rules.Capabilities;
using TimelapseVertigo.Rules.Combat;

// Token: 0x02001F49 RID: 8009
[ayj("throwBarbedNet")]
public sealed class cs : c0r, bix
{
	// Token: 0x0600BADE RID: 47838 RVA: 0x00413B10 File Offset: 0x00411D10
	public override string y8()
	{
		return "Бросок сети";
	}

	// Token: 0x0600BADF RID: 47839 RVA: 0x00413B18 File Offset: 0x00411D18
	public override string os()
	{
		return "throwBarbedNet";
	}

	// Token: 0x0600BAE0 RID: 47840 RVA: 0x00413B20 File Offset: 0x00411D20
	public override string c1()
	{
		return "Бросает";
	}

	// Token: 0x0600BAE1 RID: 47841 RVA: 0x00413B28 File Offset: 0x00411D28
	public override SpellTargetType bn(cnm A_0)
	{
		return SpellTargetType.CreatureNotSelf;
	}

	// Token: 0x0600BAE2 RID: 47842 RVA: 0x00413B2C File Offset: 0x00411D2C
	public override ci8 bg()
	{
		return ci8.c;
	}

	// Token: 0x0600BAE3 RID: 47843 RVA: 0x00413B30 File Offset: 0x00411D30
	public override a3b c0()
	{
		return new a3b
		{
			a = c0e.i,
			b = new int?(int.MaxValue),
			c = c0e.i
		};
	}

	// Token: 0x0600BAE4 RID: 47844 RVA: 0x00413B60 File Offset: 0x00411D60
	public override TimelapseCursor? bj()
	{
		return new TimelapseCursor?(TimelapseCursor.InvokeHostileSpellWithChance);
	}

	// Token: 0x0600BAE5 RID: 47845 RVA: 0x00413B6C File Offset: 0x00411D6C
	public cs()
	{
		this.f = new List<string>
		{
			"throwNet"
		};
	}

	// Token: 0x0600BAE6 RID: 47846 RVA: 0x00413B8C File Offset: 0x00411D8C
	public override string bo(cnm A_0)
	{
		return string.Empty;
	}

	// Token: 0x0600BAE7 RID: 47847 RVA: 0x00413B98 File Offset: 0x00411D98
	public override string bp(cnm A_0)
	{
		return qv.a("Items\\Utilities/BarbedThrowingNet", new object[]
		{
			cs.d.a(true),
			Convert.ToInt32(cs.e * 100.0),
			l4.a((double)cs.c, false)
		});
	}

	// Token: 0x0600BAE8 RID: 47848 RVA: 0x00413BF4 File Offset: 0x00411DF4
	public override string bm(cnm A_0)
	{
		return "Misc.0";
	}

	// Token: 0x0600BAE9 RID: 47849 RVA: 0x00413BFC File Offset: 0x00411DFC
	public static int a(efk A_0)
	{
		return (int)(d05.b(0.25, 1.0 - (double)(A_0.BaseAbilities.Strength - 5) * 0.07, 1.0) * (double)cs.c);
	}

	// Token: 0x0600BAEA RID: 47850 RVA: 0x00413C4C File Offset: 0x00411E4C
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

	// Token: 0x0600BAEB RID: 47851 RVA: 0x00413CB8 File Offset: 0x00411EB8
	public override IList<cfd> bq(cnm A_0, v5 A_1)
	{
		return new List<cfd>
		{
			new cfd("throwNet", cs.b, false, false)
		};
	}

	// Token: 0x0600BAEC RID: 47852 RVA: 0x00413CD8 File Offset: 0x00411ED8
	public override IList<string> bi()
	{
		return this.f;
	}

	// Token: 0x0600BAED RID: 47853 RVA: 0x00413CE0 File Offset: 0x00411EE0
	protected override int br(cnm A_0)
	{
		return dgk.Get<d1n>().n(A_0);
	}

	// Token: 0x0600BAEE RID: 47854 RVA: 0x00413CF0 File Offset: 0x00411EF0
	protected override float f0(cnm A_0)
	{
		return dgk.Get<d1n>().afi(A_0) * 0.75f;
	}

	// Token: 0x0600BAEF RID: 47855 RVA: 0x00413D04 File Offset: 0x00411F04
	public override dsk cv(cnm A_0)
	{
		return dsk.b;
	}

	// Token: 0x0600BAF0 RID: 47856 RVA: 0x00413D08 File Offset: 0x00411F08
	protected override int hi(cnm A_0)
	{
		return 10;
	}

	// Token: 0x040043D5 RID: 17365
	private new const string a = "throwNet";

	// Token: 0x040043D6 RID: 17366
	private static readonly int b = 4 * d0u.b;

	// Token: 0x040043D7 RID: 17367
	private static readonly int c = 3 * d0u.b;

	// Token: 0x040043D8 RID: 17368
	public static readonly a1q d = new a1q(DamageType.Mechanical, 20, 40);

	// Token: 0x040043D9 RID: 17369
	public new static readonly double e = 2.0;

	// Token: 0x040043DA RID: 17370
	private List<string> f;
}

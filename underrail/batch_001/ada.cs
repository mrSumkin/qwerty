using System;
using System.Collections.Generic;
using TimelapseVertigo.Common;
using TimelapseVertigo.Rules.Capabilities;

// Token: 0x02001F63 RID: 8035
[ayj("tnet")]
public sealed class ada : c0r, bix
{
	// Token: 0x0600BBB9 RID: 48057 RVA: 0x00415278 File Offset: 0x00413478
	public override string y8()
	{
		return "Бросок сети";
	}

	// Token: 0x0600BBBA RID: 48058 RVA: 0x00415280 File Offset: 0x00413480
	public override string os()
	{
		return "tnet";
	}

	// Token: 0x0600BBBB RID: 48059 RVA: 0x00415288 File Offset: 0x00413488
	public override string c1()
	{
		return "Бросает";
	}

	// Token: 0x0600BBBC RID: 48060 RVA: 0x00415290 File Offset: 0x00413490
	public override SpellTargetType bn(cnm A_0)
	{
		return SpellTargetType.CreatureNotSelf;
	}

	// Token: 0x0600BBBD RID: 48061 RVA: 0x00415294 File Offset: 0x00413494
	public override ci8 bg()
	{
		return ci8.c;
	}

	// Token: 0x0600BBBE RID: 48062 RVA: 0x00415298 File Offset: 0x00413498
	public override a3b c0()
	{
		return new a3b
		{
			a = c0e.i,
			b = new int?(int.MaxValue),
			c = c0e.i
		};
	}

	// Token: 0x0600BBBF RID: 48063 RVA: 0x004152C8 File Offset: 0x004134C8
	public override TimelapseCursor? bj()
	{
		return new TimelapseCursor?(TimelapseCursor.InvokeHostileSpellWithChance);
	}

	// Token: 0x0600BBC0 RID: 48064 RVA: 0x004152D4 File Offset: 0x004134D4
	public ada()
	{
		this.d = new List<string>
		{
			"throwNet"
		};
	}

	// Token: 0x0600BBC1 RID: 48065 RVA: 0x004152F4 File Offset: 0x004134F4
	public override string bo(cnm A_0)
	{
		return string.Empty;
	}

	// Token: 0x0600BBC2 RID: 48066 RVA: 0x004152FC File Offset: 0x004134FC
	public override string bp(cnm A_0)
	{
		return qv.a("Items\\Utilities/ThrowingNet", new object[]
		{
			l4.a(10000.0, false)
		});
	}

	// Token: 0x0600BBC3 RID: 48067 RVA: 0x00415320 File Offset: 0x00413520
	public override string bm(cnm A_0)
	{
		return "Devices.21";
	}

	// Token: 0x0600BBC4 RID: 48068 RVA: 0x00415328 File Offset: 0x00413528
	public static int a(efk A_0)
	{
		return (int)(d05.b(0.25, 1.0 - (double)(A_0.BaseAbilities.Strength - 4) * 0.1, 1.0) * 10000.0);
	}

	// Token: 0x0600BBC5 RID: 48069 RVA: 0x0041537C File Offset: 0x0041357C
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

	// Token: 0x0600BBC6 RID: 48070 RVA: 0x004153E8 File Offset: 0x004135E8
	public override IList<cfd> bq(cnm A_0, v5 A_1)
	{
		return new List<cfd>
		{
			new cfd("throwNet", 20000, false, false)
		};
	}

	// Token: 0x0600BBC7 RID: 48071 RVA: 0x00415408 File Offset: 0x00413608
	public override IList<string> bi()
	{
		return this.d;
	}

	// Token: 0x0600BBC8 RID: 48072 RVA: 0x00415410 File Offset: 0x00413610
	protected override int br(cnm A_0)
	{
		return dgk.Get<d1n>().n(A_0);
	}

	// Token: 0x0600BBC9 RID: 48073 RVA: 0x00415420 File Offset: 0x00413620
	protected override float f0(cnm A_0)
	{
		return dgk.Get<d1n>().afi(A_0) * 0.75f;
	}

	// Token: 0x0600BBCA RID: 48074 RVA: 0x00415434 File Offset: 0x00413634
	public override dsk cv(cnm A_0)
	{
		return dsk.b;
	}

	// Token: 0x0600BBCB RID: 48075 RVA: 0x00415438 File Offset: 0x00413638
	protected override int hi(cnm A_0)
	{
		return 10;
	}

	// Token: 0x040043EA RID: 17386
	private new const string a = "throwNet";

	// Token: 0x040043EB RID: 17387
	private const int b = 20000;

	// Token: 0x040043EC RID: 17388
	private const int c = 10000;

	// Token: 0x040043ED RID: 17389
	private List<string> d;
}

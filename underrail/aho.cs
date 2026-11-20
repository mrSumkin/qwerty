using System;
using System.Collections.Generic;
using TimelapseVertigo.Rules.Capabilities;
using TimelapseVertigo.Rules.Combat;
using TimelapseVertigo.Rules.Items;

// Token: 0x02001EE1 RID: 7905
[ayj("SkerderShieldhandBash")]
public sealed class aho : c0z
{
	// Token: 0x0600B3B7 RID: 46007 RVA: 0x00406DCC File Offset: 0x00404FCC
	public override string y8()
	{
		return "Удар щитом";
	}

	// Token: 0x0600B3B8 RID: 46008 RVA: 0x00406DD4 File Offset: 0x00404FD4
	public override string os()
	{
		return "SkerderShieldhandBash";
	}

	// Token: 0x0600B3B9 RID: 46009 RVA: 0x00406DDC File Offset: 0x00404FDC
	public override ci8 bg()
	{
		return ci8.c;
	}

	// Token: 0x0600B3BA RID: 46010 RVA: 0x00406DE0 File Offset: 0x00404FE0
	public override int e8()
	{
		return 1;
	}

	// Token: 0x0600B3BB RID: 46011 RVA: 0x00406DE4 File Offset: 0x00404FE4
	public override a3b c0()
	{
		return new a3b
		{
			a = c0e.c,
			b = new int?(int.MaxValue)
		};
	}

	// Token: 0x0600B3BC RID: 46012 RVA: 0x00406E08 File Offset: 0x00405008
	public override IList<string> bi()
	{
		return this.c;
	}

	// Token: 0x0600B3BD RID: 46013 RVA: 0x00406E10 File Offset: 0x00405010
	public override string c1()
	{
		return "Удар щитом";
	}

	// Token: 0x0600B3BE RID: 46014 RVA: 0x00406E18 File Offset: 0x00405018
	public aho()
	{
		this.c = new List<string>();
		this.c.Add(aho.a);
	}

	// Token: 0x0600B3BF RID: 46015 RVA: 0x00406E3C File Offset: 0x0040503C
	public override string bm(cnm A_0)
	{
		return "Misc.0";
	}

	// Token: 0x0600B3C0 RID: 46016 RVA: 0x00406E44 File Offset: 0x00405044
	public override SpellTargetType bn(cnm A_0)
	{
		return SpellTargetType.CreatureNotSelf;
	}

	// Token: 0x0600B3C1 RID: 46017 RVA: 0x00406E48 File Offset: 0x00405048
	public override string bo(cnm A_0)
	{
		return string.Empty;
	}

	// Token: 0x0600B3C2 RID: 46018 RVA: 0x00406E50 File Offset: 0x00405050
	public override IList<cfd> bq(cnm A_0, v5 A_1)
	{
		return new List<cfd>
		{
			new cfd(aho.a, aho.b, false, false)
		};
	}

	// Token: 0x0600B3C3 RID: 46019 RVA: 0x00406E74 File Offset: 0x00405074
	public static cd1 a()
	{
		bke bke = new bke();
		bke.g("Shield-hand");
		bke.a(AmmoType.Sledgehammer);
		bke.c(true);
		bke.g(true);
		bke.c(as3.bk);
		bke.l().Add(new a1q(DamageType.Mechanical, 50, 80));
		bke.a(esu.f);
		bke.a(ImpactSpeed.VeryLow);
		bke.a(btz.g);
		bke.a(new WeaponSubtype?(WeaponSubtype.Sledgehammer));
		bke.b(10);
		bke.f(0.02);
		bke.aa().Add(new edm("daze", 1.0, 2, true));
		return new cd1(new IndependentItemDefinitionProvider<bke>(bke));
	}

	// Token: 0x0600B3C4 RID: 46020 RVA: 0x00406F30 File Offset: 0x00405130
	protected override int br(cnm A_0)
	{
		return 1000;
	}

	// Token: 0x0600B3C5 RID: 46021 RVA: 0x00406F38 File Offset: 0x00405138
	protected override float f0(cnm A_0)
	{
		return as3.bk;
	}

	// Token: 0x0600B3C6 RID: 46022 RVA: 0x00406F40 File Offset: 0x00405140
	protected override int hi(cnm A_0)
	{
		return 10;
	}

	// Token: 0x040041A2 RID: 16802
	private new static readonly string a = "SkerderShieldhandBash";

	// Token: 0x040041A3 RID: 16803
	private static readonly int b = 2 * d0u.b;

	// Token: 0x040041A4 RID: 16804
	private List<string> c;
}

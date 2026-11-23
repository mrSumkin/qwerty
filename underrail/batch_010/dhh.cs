using System;
using System.Collections.Generic;
using TimelapseVertigo.Rules.Capabilities;
using TimelapseVertigo.Rules.Combat;
using TimelapseVertigo.Rules.Items;

// Token: 0x02001EDF RID: 7903
[ayj("SkerderAcidBlobLauncherShoot")]
public sealed class dhh : c0z
{
	// Token: 0x0600B395 RID: 45973 RVA: 0x00406A4C File Offset: 0x00404C4C
	public override string y8()
	{
		return "Выстрел кислотой";
	}

	// Token: 0x0600B396 RID: 45974 RVA: 0x00406A54 File Offset: 0x00404C54
	public override string os()
	{
		return "SkerderAcidBlobLauncherShoot";
	}

	// Token: 0x0600B397 RID: 45975 RVA: 0x00406A5C File Offset: 0x00404C5C
	public override ci8 bg()
	{
		return ci8.c;
	}

	// Token: 0x0600B398 RID: 45976 RVA: 0x00406A60 File Offset: 0x00404C60
	public override int e8()
	{
		return 1;
	}

	// Token: 0x0600B399 RID: 45977 RVA: 0x00406A64 File Offset: 0x00404C64
	public override a3b c0()
	{
		return new a3b
		{
			a = c0e.a,
			b = new int?(int.MaxValue)
		};
	}

	// Token: 0x0600B39A RID: 45978 RVA: 0x00406A88 File Offset: 0x00404C88
	public override IList<string> bi()
	{
		return this.c;
	}

	// Token: 0x0600B39B RID: 45979 RVA: 0x00406A90 File Offset: 0x00404C90
	public override string c1()
	{
		return "Выстрел кислотой";
	}

	// Token: 0x0600B39C RID: 45980 RVA: 0x00406A98 File Offset: 0x00404C98
	public dhh()
	{
		this.c = new List<string>();
		this.c.Add(dhh.a);
	}

	// Token: 0x0600B39D RID: 45981 RVA: 0x00406ABC File Offset: 0x00404CBC
	public override string bm(cnm A_0)
	{
		return "Misc.0";
	}

	// Token: 0x0600B39E RID: 45982 RVA: 0x00406AC4 File Offset: 0x00404CC4
	public override SpellTargetType bn(cnm A_0)
	{
		return SpellTargetType.CreatureNotSelf;
	}

	// Token: 0x0600B39F RID: 45983 RVA: 0x00406AC8 File Offset: 0x00404CC8
	public override string bo(cnm A_0)
	{
		return string.Empty;
	}

	// Token: 0x0600B3A0 RID: 45984 RVA: 0x00406AD0 File Offset: 0x00404CD0
	public override IList<cfd> bq(cnm A_0, v5 A_1)
	{
		return new List<cfd>
		{
			new cfd(dhh.a, dhh.b, false, false)
		};
	}

	// Token: 0x0600B3A1 RID: 45985 RVA: 0x00406AF4 File Offset: 0x00404CF4
	public static cd1 a()
	{
		bke bke = new bke();
		bke.g("Tentacles-hand");
		bke.a(AmmoType.Vial_Acid_Rusting);
		bke.c(true);
		bke.g(true);
		bke.c(9f);
		bke.d(6f);
		bke.l().Add(new a1q(DamageType.Acid, 50, 100));
		bke.a(esu.k);
		bke.a(ImpactSpeed.Low);
		bke.a(btz.a);
		bke.b(12);
		bke.f(0.05);
		bke.aa().Add(new edm("rustingAcidSplashAndSpill", 1.0, 1, true));
		bke.aa().Add(new edm("acidicEntanglement", 1.0, 100, true));
		return new cd1(new IndependentItemDefinitionProvider<bke>(bke));
	}

	// Token: 0x0600B3A2 RID: 45986 RVA: 0x00406BD0 File Offset: 0x00404DD0
	protected override int br(cnm A_0)
	{
		return 1000;
	}

	// Token: 0x0600B3A3 RID: 45987 RVA: 0x00406BD8 File Offset: 0x00404DD8
	protected override float f0(cnm A_0)
	{
		return dhh.a().TypedDefinition.ad();
	}

	// Token: 0x0600B3A4 RID: 45988 RVA: 0x00406BEC File Offset: 0x00404DEC
	protected override int hi(cnm A_0)
	{
		return 15;
	}

	// Token: 0x0400419C RID: 16796
	private new static readonly string a = "SkerderAcidBlobLauncherShoot";

	// Token: 0x0400419D RID: 16797
	private static readonly int b = 3 * d0u.b;

	// Token: 0x0400419E RID: 16798
	private List<string> c;
}

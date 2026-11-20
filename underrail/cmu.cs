using System;
using System.Collections.Generic;
using TimelapseVertigo.Rules.Capabilities;
using TimelapseVertigo.Rules.Combat;
using TimelapseVertigo.Rules.Items;

// Token: 0x02001EE0 RID: 7904
[ayj("SkerderTentacleshandSlap")]
public sealed class cmu : c0z
{
	// Token: 0x0600B3A6 RID: 45990 RVA: 0x00406C08 File Offset: 0x00404E08
	public override string y8()
	{
		return "Удар щупальцем";
	}

	// Token: 0x0600B3A7 RID: 45991 RVA: 0x00406C10 File Offset: 0x00404E10
	public override string os()
	{
		return "SkerderTentacleshandSlap";
	}

	// Token: 0x0600B3A8 RID: 45992 RVA: 0x00406C18 File Offset: 0x00404E18
	public override ci8 bg()
	{
		return ci8.c;
	}

	// Token: 0x0600B3A9 RID: 45993 RVA: 0x00406C1C File Offset: 0x00404E1C
	public override int e8()
	{
		return 1;
	}

	// Token: 0x0600B3AA RID: 45994 RVA: 0x00406C20 File Offset: 0x00404E20
	public override a3b c0()
	{
		return new a3b
		{
			a = c0e.a,
			b = new int?(int.MaxValue)
		};
	}

	// Token: 0x0600B3AB RID: 45995 RVA: 0x00406C44 File Offset: 0x00404E44
	public override IList<string> bi()
	{
		return this.c;
	}

	// Token: 0x0600B3AC RID: 45996 RVA: 0x00406C4C File Offset: 0x00404E4C
	public override string c1()
	{
		return "Удар щупальцем";
	}

	// Token: 0x0600B3AD RID: 45997 RVA: 0x00406C54 File Offset: 0x00404E54
	public cmu()
	{
		this.c = new List<string>();
		this.c.Add(cmu.a);
	}

	// Token: 0x0600B3AE RID: 45998 RVA: 0x00406C78 File Offset: 0x00404E78
	public override string bm(cnm A_0)
	{
		return "Misc.0";
	}

	// Token: 0x0600B3AF RID: 45999 RVA: 0x00406C80 File Offset: 0x00404E80
	public override SpellTargetType bn(cnm A_0)
	{
		return SpellTargetType.CreatureNotSelf;
	}

	// Token: 0x0600B3B0 RID: 46000 RVA: 0x00406C84 File Offset: 0x00404E84
	public override string bo(cnm A_0)
	{
		return string.Empty;
	}

	// Token: 0x0600B3B1 RID: 46001 RVA: 0x00406C8C File Offset: 0x00404E8C
	public override IList<cfd> bq(cnm A_0, v5 A_1)
	{
		return new List<cfd>
		{
			new cfd(cmu.a, cmu.b, false, false)
		};
	}

	// Token: 0x0600B3B2 RID: 46002 RVA: 0x00406CB0 File Offset: 0x00404EB0
	public static cd1 a()
	{
		bke bke = new bke();
		bke.g("Tentacles-hand");
		bke.a(AmmoType.None);
		bke.c(true);
		bke.g(true);
		bke.c(as3.bk);
		bke.l().Add(new a1q(DamageType.Mechanical, 20, 40));
		bke.l().Add(new a1q(DamageType.Bio, 30, 60));
		bke.a(esu.h);
		bke.a(ImpactSpeed.VeryLow);
		bke.a(btz.g);
		bke.a(new WeaponSubtype?(WeaponSubtype.Unarmed));
		bke.b(12);
		bke.f(0.02);
		bke.aa().Add(new edm("contaminate", 1.0, 1, true));
		bke.aa().Add(new edm("contaminate", 1.0, 1, true));
		return new cd1(new IndependentItemDefinitionProvider<bke>(bke));
	}

	// Token: 0x0600B3B3 RID: 46003 RVA: 0x00406DA0 File Offset: 0x00404FA0
	protected override int br(cnm A_0)
	{
		return 1000;
	}

	// Token: 0x0600B3B4 RID: 46004 RVA: 0x00406DA8 File Offset: 0x00404FA8
	protected override float f0(cnm A_0)
	{
		return as3.bk;
	}

	// Token: 0x0600B3B5 RID: 46005 RVA: 0x00406DB0 File Offset: 0x00404FB0
	protected override int hi(cnm A_0)
	{
		return 15;
	}

	// Token: 0x0400419F RID: 16799
	private new static readonly string a = "SkerderTentacleshandSlap";

	// Token: 0x040041A0 RID: 16800
	private static readonly int b = d0u.b;

	// Token: 0x040041A1 RID: 16801
	private List<string> c;
}

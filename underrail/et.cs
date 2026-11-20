using System;
using System.Collections.Generic;
using TimelapseVertigo.Rules.Capabilities;
using TimelapseVertigo.Rules.Combat;
using TimelapseVertigo.Rules.Items;

// Token: 0x02001EE3 RID: 7907
[ayj("SkerderMacehandSlam")]
public sealed class et : c0z
{
	// Token: 0x0600B3D9 RID: 46041 RVA: 0x004070FC File Offset: 0x004052FC
	public override string y8()
	{
		return "Взмах кувалдой";
	}

	// Token: 0x0600B3DA RID: 46042 RVA: 0x00407104 File Offset: 0x00405304
	public override string os()
	{
		return "SkerderMacehandSlam";
	}

	// Token: 0x0600B3DB RID: 46043 RVA: 0x0040710C File Offset: 0x0040530C
	public override ci8 bg()
	{
		return ci8.c;
	}

	// Token: 0x0600B3DC RID: 46044 RVA: 0x00407110 File Offset: 0x00405310
	public override int e8()
	{
		return 1;
	}

	// Token: 0x0600B3DD RID: 46045 RVA: 0x00407114 File Offset: 0x00405314
	public override a3b c0()
	{
		return new a3b
		{
			a = c0e.c,
			b = new int?(int.MaxValue)
		};
	}

	// Token: 0x0600B3DE RID: 46046 RVA: 0x00407138 File Offset: 0x00405338
	public override IList<string> bi()
	{
		return this.c;
	}

	// Token: 0x0600B3DF RID: 46047 RVA: 0x00407140 File Offset: 0x00405340
	public override string c1()
	{
		return "Взмах кувалдой";
	}

	// Token: 0x0600B3E0 RID: 46048 RVA: 0x00407148 File Offset: 0x00405348
	public et()
	{
		this.c = new List<string>();
		this.c.Add(et.a);
	}

	// Token: 0x0600B3E1 RID: 46049 RVA: 0x0040716C File Offset: 0x0040536C
	public override string bm(cnm A_0)
	{
		return "Misc.0";
	}

	// Token: 0x0600B3E2 RID: 46050 RVA: 0x00407174 File Offset: 0x00405374
	public override SpellTargetType bn(cnm A_0)
	{
		return SpellTargetType.CreatureNotSelf;
	}

	// Token: 0x0600B3E3 RID: 46051 RVA: 0x00407178 File Offset: 0x00405378
	public override string bo(cnm A_0)
	{
		return string.Empty;
	}

	// Token: 0x0600B3E4 RID: 46052 RVA: 0x00407180 File Offset: 0x00405380
	public override IList<cfd> bq(cnm A_0, v5 A_1)
	{
		return new List<cfd>
		{
			new cfd(et.a, et.b, false, false)
		};
	}

	// Token: 0x0600B3E5 RID: 46053 RVA: 0x004071A0 File Offset: 0x004053A0
	public static cd1 a()
	{
		bke bke = new bke();
		bke.g("Mace-hand");
		bke.a(AmmoType.Sledgehammer);
		bke.c(true);
		bke.g(true);
		bke.c(as3.bk);
		bke.l().Add(new a1q(DamageType.Mechanical, 75, 150));
		bke.a(esu.f);
		bke.a(ImpactSpeed.VeryLow);
		bke.a(btz.g);
		bke.a(new WeaponSubtype?(WeaponSubtype.Sledgehammer));
		bke.b(12);
		bke.f(0.02);
		bke.aa().Add(new edm("ST", 1.0, 1, true));
		return new cd1(new IndependentItemDefinitionProvider<bke>(bke));
	}

	// Token: 0x0600B3E6 RID: 46054 RVA: 0x0040725C File Offset: 0x0040545C
	protected override int br(cnm A_0)
	{
		return 1000;
	}

	// Token: 0x0600B3E7 RID: 46055 RVA: 0x00407264 File Offset: 0x00405464
	protected override float f0(cnm A_0)
	{
		return as3.bk;
	}

	// Token: 0x0600B3E8 RID: 46056 RVA: 0x0040726C File Offset: 0x0040546C
	protected override int hi(cnm A_0)
	{
		return 35;
	}

	// Token: 0x040041A8 RID: 16808
	private new static readonly string a = "SkerderMacehandSlam";

	// Token: 0x040041A9 RID: 16809
	private static readonly int b = 2 * d0u.b;

	// Token: 0x040041AA RID: 16810
	private List<string> c;
}

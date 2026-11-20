using System;
using System.Collections.Generic;
using TimelapseVertigo.Rules.Capabilities;
using TimelapseVertigo.Rules.Combat;
using TimelapseVertigo.Rules.Items;

// Token: 0x02001EE2 RID: 7906
[ayj("SkerderSwordhandSlash")]
public sealed class btf : c0z
{
	// Token: 0x0600B3C8 RID: 46024 RVA: 0x00406F5C File Offset: 0x0040515C
	public override string y8()
	{
		return "Рассечение мечом";
	}

	// Token: 0x0600B3C9 RID: 46025 RVA: 0x00406F64 File Offset: 0x00405164
	public override string os()
	{
		return "SkerderSwordhandSlash";
	}

	// Token: 0x0600B3CA RID: 46026 RVA: 0x00406F6C File Offset: 0x0040516C
	public override ci8 bg()
	{
		return ci8.c;
	}

	// Token: 0x0600B3CB RID: 46027 RVA: 0x00406F70 File Offset: 0x00405170
	public override int e8()
	{
		return 1;
	}

	// Token: 0x0600B3CC RID: 46028 RVA: 0x00406F74 File Offset: 0x00405174
	public override a3b c0()
	{
		return new a3b
		{
			a = c0e.c,
			b = new int?(int.MaxValue)
		};
	}

	// Token: 0x0600B3CD RID: 46029 RVA: 0x00406F98 File Offset: 0x00405198
	public override IList<string> bi()
	{
		return this.c;
	}

	// Token: 0x0600B3CE RID: 46030 RVA: 0x00406FA0 File Offset: 0x004051A0
	public override string c1()
	{
		return "Рассечение мечом";
	}

	// Token: 0x0600B3CF RID: 46031 RVA: 0x00406FA8 File Offset: 0x004051A8
	public btf()
	{
		this.c = new List<string>();
		this.c.Add(btf.a);
	}

	// Token: 0x0600B3D0 RID: 46032 RVA: 0x00406FCC File Offset: 0x004051CC
	public override string bm(cnm A_0)
	{
		return "Misc.0";
	}

	// Token: 0x0600B3D1 RID: 46033 RVA: 0x00406FD4 File Offset: 0x004051D4
	public override SpellTargetType bn(cnm A_0)
	{
		return SpellTargetType.CreatureNotSelf;
	}

	// Token: 0x0600B3D2 RID: 46034 RVA: 0x00406FD8 File Offset: 0x004051D8
	public override string bo(cnm A_0)
	{
		return string.Empty;
	}

	// Token: 0x0600B3D3 RID: 46035 RVA: 0x00406FE0 File Offset: 0x004051E0
	public override IList<cfd> bq(cnm A_0, v5 A_1)
	{
		return new List<cfd>
		{
			new cfd(btf.a, btf.b, false, false)
		};
	}

	// Token: 0x0600B3D4 RID: 46036 RVA: 0x00407000 File Offset: 0x00405200
	public static cd1 a()
	{
		bke bke = new bke();
		bke.g("Sword-hand");
		bke.a(AmmoType.Sword);
		bke.c(true);
		bke.g(true);
		bke.c(as3.bk);
		bke.l().Add(new a1q(DamageType.Mechanical, 40, 75));
		bke.a(esu.b);
		bke.a(ImpactSpeed.VeryLow);
		bke.a(btz.g);
		bke.a(new WeaponSubtype?(WeaponSubtype.Sword));
		bke.b(8);
		bke.f(0.05);
		bke.c(1.5);
		bke.aa().Add(new edm("bleedingWound", 1.0, 200, true));
		return new cd1(new IndependentItemDefinitionProvider<bke>(bke));
	}

	// Token: 0x0600B3D5 RID: 46037 RVA: 0x004070D0 File Offset: 0x004052D0
	protected override int br(cnm A_0)
	{
		return 1000;
	}

	// Token: 0x0600B3D6 RID: 46038 RVA: 0x004070D8 File Offset: 0x004052D8
	protected override float f0(cnm A_0)
	{
		return as3.bk;
	}

	// Token: 0x0600B3D7 RID: 46039 RVA: 0x004070E0 File Offset: 0x004052E0
	protected override int hi(cnm A_0)
	{
		return 35;
	}

	// Token: 0x040041A5 RID: 16805
	private new static readonly string a = "SkerderSwordhandSlash";

	// Token: 0x040041A6 RID: 16806
	private static readonly int b = 2 * d0u.b;

	// Token: 0x040041A7 RID: 16807
	private List<string> c;
}

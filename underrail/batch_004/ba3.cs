using System;
using System.Collections.Generic;
using TimelapseVertigo.Common;
using TimelapseVertigo.Rules.Capabilities;
using TimelapseVertigo.Rules.Combat;
using TimelapseVertigo.Rules.Items;

// Token: 0x02001EE5 RID: 7909
[ayj("ShootGlowJetskiLaserGun")]
public sealed class ba3 : elr, bix
{
	// Token: 0x0600B405 RID: 46085 RVA: 0x00407780 File Offset: 0x00405980
	public override string y8()
	{
		return "Очередь из лазера";
	}

	// Token: 0x0600B406 RID: 46086 RVA: 0x00407788 File Offset: 0x00405988
	public override string os()
	{
		return "ShootGlowJetskiLaserGun";
	}

	// Token: 0x0600B407 RID: 46087 RVA: 0x00407790 File Offset: 0x00405990
	public override ci8 bg()
	{
		return ci8.c;
	}

	// Token: 0x0600B408 RID: 46088 RVA: 0x00407794 File Offset: 0x00405994
	public override int e8()
	{
		return 1;
	}

	// Token: 0x0600B409 RID: 46089 RVA: 0x00407798 File Offset: 0x00405998
	public override bool hl()
	{
		return true;
	}

	// Token: 0x0600B40A RID: 46090 RVA: 0x0040779C File Offset: 0x0040599C
	public override TimelapseCursor? bj()
	{
		return new TimelapseCursor?(TimelapseCursor.InvokeHostileSpellWithChance);
	}

	// Token: 0x0600B40B RID: 46091 RVA: 0x004077A8 File Offset: 0x004059A8
	public override IList<string> bi()
	{
		return this.f;
	}

	// Token: 0x0600B40C RID: 46092 RVA: 0x004077B0 File Offset: 0x004059B0
	public ba3()
	{
		this.f = new List<string>();
	}

	// Token: 0x0600B40D RID: 46093 RVA: 0x004077C4 File Offset: 0x004059C4
	public override string bm(cnm A_0)
	{
		return "xpbl_Abilities.2";
	}

	// Token: 0x0600B40E RID: 46094 RVA: 0x004077CC File Offset: 0x004059CC
	public override SpellTargetType bn(cnm A_0)
	{
		return SpellTargetType.CreatureNotSelf;
	}

	// Token: 0x0600B40F RID: 46095 RVA: 0x004077D4 File Offset: 0x004059D4
	public override string bo(cnm A_0)
	{
		return qv.a("SpecialAbilities/ShootGlowJetskiLaserGun", new object[]
		{
			ba3.d,
			ba3.b(A_0, 1.0).a(true),
			ba3.e
		});
	}

	// Token: 0x0600B410 RID: 46096 RVA: 0x00407828 File Offset: 0x00405A28
	public override IList<cfd> bq(cnm A_0, v5 A_1)
	{
		return new List<cfd>();
	}

	// Token: 0x0600B411 RID: 46097 RVA: 0x00407834 File Offset: 0x00405A34
	public override bool hm(cnm A_0)
	{
		return base.hm(A_0) && (A_0 != null && A_0.b8() != null && A_0.b8().Vehicle != null && A_0.b8().Vehicle.g() >= (double)ba3.e);
	}

	// Token: 0x0600B412 RID: 46098 RVA: 0x00407890 File Offset: 0x00405A90
	public static a1q b(cnm A_0, double A_1 = 1.0)
	{
		a1q result = new a1q(DamageType.Energy, ba3.a, ba3.b);
		euf.a(A_0, ref result);
		return result;
	}

	// Token: 0x0600B413 RID: 46099 RVA: 0x004078B8 File Offset: 0x00405AB8
	public static List<csk> a(cnm A_0, double A_1)
	{
		return new List<csk>
		{
			euf.a(ba3.b(A_0, 1.0), A_1)
		};
	}

	// Token: 0x0600B414 RID: 46100 RVA: 0x004078DC File Offset: 0x00405ADC
	public bg3 bs(cnm A_0, efk A_1, double A_2, double A_3, bool A_4, bool A_5, c3u A_6)
	{
		if (A_0 != null && A_0.b8() != null && A_1 != null)
		{
			cmn cmn = new cmn();
			cmn.a |= A_6;
			return euf.a(A_0.b8(), A_1, A_2, A_3, A_0.b8().Darkvision, AmmoType.None, false, 1.0, cmn, ba3.a(A_0), new int?(euf.a(A_0.b8(), false)));
		}
		return null;
	}

	// Token: 0x0600B415 RID: 46101 RVA: 0x00407954 File Offset: 0x00405B54
	public new static cd1 a(cnm A_0)
	{
		bke bke = new bke();
		bke.a(btz.a);
		bke.a(new WeaponSubtype?(WeaponSubtype.Pistol_Laser));
		bke.g("Laser Gun");
		bke.a(AmmoType.Energy);
		bke.c(true);
		bke.g(true);
		bke.c((float)ba3.c);
		bke.d((float)(ba3.c - 3));
		bke.l().Add(ba3.b(A_0, 1.0));
		bke.a(esu.g);
		bke.a(ImpactSpeed.VeryHigh);
		bke.g(0.15);
		bke.b(true);
		return new cd1(new IndependentItemDefinitionProvider<bke>(bke));
	}

	// Token: 0x0600B416 RID: 46102 RVA: 0x00407A00 File Offset: 0x00405C00
	protected override int br(cnm A_0)
	{
		return 0;
	}

	// Token: 0x0600B417 RID: 46103 RVA: 0x00407A04 File Offset: 0x00405C04
	protected override float f0(cnm A_0)
	{
		return (float)ba3.c;
	}

	// Token: 0x0600B418 RID: 46104 RVA: 0x00407A0C File Offset: 0x00405C0C
	protected override int hi(cnm A_0)
	{
		return 25;
	}

	// Token: 0x040041B4 RID: 16820
	private new static readonly int a = 40;

	// Token: 0x040041B5 RID: 16821
	private static readonly int b = 65;

	// Token: 0x040041B6 RID: 16822
	public static readonly int c = 11;

	// Token: 0x040041B7 RID: 16823
	public static readonly int d = 4;

	// Token: 0x040041B8 RID: 16824
	public new static readonly int e = 5 * ba3.d;

	// Token: 0x040041B9 RID: 16825
	private List<string> f;
}

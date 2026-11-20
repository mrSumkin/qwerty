using System;
using System.Collections.Generic;
using TimelapseVertigo.Common;
using TimelapseVertigo.Rules.Capabilities;
using TimelapseVertigo.Rules.Combat;
using TimelapseVertigo.Rules.Items;

// Token: 0x02001EE7 RID: 7911
[ayj("ShootLeviatorPlasmaCannon")]
public sealed class b0o : elr, bix
{
	// Token: 0x0600B431 RID: 46129 RVA: 0x00407D30 File Offset: 0x00405F30
	public override string y8()
	{
		return "Выстрел из плазменной пушки";
	}

	// Token: 0x0600B432 RID: 46130 RVA: 0x00407D38 File Offset: 0x00405F38
	public override string os()
	{
		return "ShootLeviatorPlasmaCannon";
	}

	// Token: 0x0600B433 RID: 46131 RVA: 0x00407D40 File Offset: 0x00405F40
	public override ci8 bg()
	{
		return ci8.c;
	}

	// Token: 0x0600B434 RID: 46132 RVA: 0x00407D44 File Offset: 0x00405F44
	public override int e8()
	{
		return 1;
	}

	// Token: 0x0600B435 RID: 46133 RVA: 0x00407D48 File Offset: 0x00405F48
	public override bool hl()
	{
		return true;
	}

	// Token: 0x0600B436 RID: 46134 RVA: 0x00407D4C File Offset: 0x00405F4C
	public override TimelapseCursor? bj()
	{
		return new TimelapseCursor?(TimelapseCursor.InvokeHostileSpellWithChance);
	}

	// Token: 0x0600B437 RID: 46135 RVA: 0x00407D58 File Offset: 0x00405F58
	public override IList<string> bi()
	{
		return this.g;
	}

	// Token: 0x0600B438 RID: 46136 RVA: 0x00407D60 File Offset: 0x00405F60
	public b0o()
	{
		this.g = new List<string>();
	}

	// Token: 0x0600B439 RID: 46137 RVA: 0x00407D74 File Offset: 0x00405F74
	public override string bm(cnm A_0)
	{
		return "xpbl_Abilities.1";
	}

	// Token: 0x0600B43A RID: 46138 RVA: 0x00407D7C File Offset: 0x00405F7C
	public override SpellTargetType bn(cnm A_0)
	{
		return SpellTargetType.CreatureNotSelf;
	}

	// Token: 0x0600B43B RID: 46139 RVA: 0x00407D84 File Offset: 0x00405F84
	public override string bo(cnm A_0)
	{
		return qv.a("SpecialAbilities/ShootLeviatorPlasmaCannon", new object[]
		{
			b0o.c(A_0, 1.0).a(true),
			b0o.b(A_0, 1.0).a(true),
			b0o.f
		});
	}

	// Token: 0x0600B43C RID: 46140 RVA: 0x00407DE4 File Offset: 0x00405FE4
	public override IList<cfd> bq(cnm A_0, v5 A_1)
	{
		return new List<cfd>();
	}

	// Token: 0x0600B43D RID: 46141 RVA: 0x00407DEC File Offset: 0x00405FEC
	public override bool hm(cnm A_0)
	{
		return base.hm(A_0) && (A_0 != null && A_0.b8() != null && A_0.b8().Vehicle != null && A_0.b8().Vehicle.g() >= (double)b0o.f);
	}

	// Token: 0x0600B43E RID: 46142 RVA: 0x00407E48 File Offset: 0x00406048
	public static a1q c(cnm A_0, double A_1 = 1.0)
	{
		a1q result = new a1q(DamageType.Energy, b0o.a, b0o.b);
		euf.a(A_0, ref result);
		return result;
	}

	// Token: 0x0600B43F RID: 46143 RVA: 0x00407E70 File Offset: 0x00406070
	public static a1q b(cnm A_0, double A_1 = 1.0)
	{
		a1q result = new a1q(DamageType.Heat, b0o.c, b0o.d);
		euf.a(A_0, ref result);
		return result;
	}

	// Token: 0x0600B440 RID: 46144 RVA: 0x00407E98 File Offset: 0x00406098
	public static List<csk> a(cnm A_0, double A_1)
	{
		return new List<csk>
		{
			euf.a(b0o.c(A_0, 1.0), A_1),
			euf.a(b0o.b(A_0, 1.0), A_1)
		};
	}

	// Token: 0x0600B441 RID: 46145 RVA: 0x00407ED8 File Offset: 0x004060D8
	public bg3 bs(cnm A_0, efk A_1, double A_2, double A_3, bool A_4, bool A_5, c3u A_6)
	{
		if (A_0 != null && A_0.b8() != null && A_1 != null)
		{
			cmn cmn = new cmn();
			cmn.a |= A_6;
			return euf.a(A_0.b8(), A_1, A_2, A_3, A_0.b8().Darkvision, AmmoType.None, false, 1.0, cmn, b0o.a(A_0), new int?(euf.a(A_0.b8(), true)));
		}
		return null;
	}

	// Token: 0x0600B442 RID: 46146 RVA: 0x00407F50 File Offset: 0x00406150
	public new static cd1 a(cnm A_0)
	{
		bke bke = new bke();
		bke.a(btz.a);
		bke.a(new WeaponSubtype?(WeaponSubtype.Pistol_Plasma));
		bke.g("Plasma Cannon");
		bke.a(AmmoType.Energy);
		bke.c(true);
		bke.g(true);
		bke.c((float)b0o.e);
		bke.d((float)(b0o.e - 3));
		bke.l().Add(b0o.c(A_0, 1.0));
		bke.l().Add(b0o.b(A_0, 1.0));
		bke.a(esu.l);
		bke.a(ImpactSpeed.VeryHigh);
		bke.b(true);
		bke.g(0.1);
		return new cd1(new IndependentItemDefinitionProvider<bke>(bke));
	}

	// Token: 0x0600B443 RID: 46147 RVA: 0x00408018 File Offset: 0x00406218
	protected override int br(cnm A_0)
	{
		return 0;
	}

	// Token: 0x0600B444 RID: 46148 RVA: 0x0040801C File Offset: 0x0040621C
	protected override float f0(cnm A_0)
	{
		return (float)b0o.e;
	}

	// Token: 0x0600B445 RID: 46149 RVA: 0x00408024 File Offset: 0x00406224
	protected override int hi(cnm A_0)
	{
		return 25;
	}

	// Token: 0x040041C2 RID: 16834
	private new static readonly int a = 115;

	// Token: 0x040041C3 RID: 16835
	private static readonly int b = 170;

	// Token: 0x040041C4 RID: 16836
	private static readonly int c = 115;

	// Token: 0x040041C5 RID: 16837
	private static readonly int d = 170;

	// Token: 0x040041C6 RID: 16838
	public new static readonly int e = 10;

	// Token: 0x040041C7 RID: 16839
	public static readonly int f = 35;

	// Token: 0x040041C8 RID: 16840
	private new List<string> g;
}

using System;
using System.Collections.Generic;
using TimelapseVertigo.Common;
using TimelapseVertigo.Rules.Capabilities;
using TimelapseVertigo.Rules.Combat;
using TimelapseVertigo.Rules.Items;

// Token: 0x02001EE4 RID: 7908
[ayj("ShootLemurianSpear")]
public sealed class es : c0z, bix
{
	// Token: 0x0600B3EA RID: 46058 RVA: 0x00407288 File Offset: 0x00405488
	public override string y8()
	{
		return "Выстрел из лемурианского копья";
	}

	// Token: 0x0600B3EB RID: 46059 RVA: 0x00407290 File Offset: 0x00405490
	public override string os()
	{
		return "ShootLemurianSpear";
	}

	// Token: 0x0600B3EC RID: 46060 RVA: 0x00407298 File Offset: 0x00405498
	public override ci8 bg()
	{
		return ci8.c;
	}

	// Token: 0x0600B3ED RID: 46061 RVA: 0x0040729C File Offset: 0x0040549C
	public override int e8()
	{
		return 1;
	}

	// Token: 0x0600B3EE RID: 46062 RVA: 0x004072A0 File Offset: 0x004054A0
	public override a3b c0()
	{
		return new a3b
		{
			a = c0e.c
		};
	}

	// Token: 0x0600B3EF RID: 46063 RVA: 0x004072B4 File Offset: 0x004054B4
	public override bool hl()
	{
		return true;
	}

	// Token: 0x0600B3F0 RID: 46064 RVA: 0x004072B8 File Offset: 0x004054B8
	public override TimelapseCursor? bj()
	{
		return new TimelapseCursor?(TimelapseCursor.InvokeHostileSpellWithChance);
	}

	// Token: 0x0600B3F1 RID: 46065 RVA: 0x004072C4 File Offset: 0x004054C4
	public override IList<string> bi()
	{
		return this.i;
	}

	// Token: 0x0600B3F2 RID: 46066 RVA: 0x004072CC File Offset: 0x004054CC
	public override bool bk()
	{
		return true;
	}

	// Token: 0x0600B3F3 RID: 46067 RVA: 0x004072D0 File Offset: 0x004054D0
	public es()
	{
		this.i = new List<string>();
		this.i.Add(es.g);
	}

	// Token: 0x0600B3F4 RID: 46068 RVA: 0x004072F4 File Offset: 0x004054F4
	public override string bm(cnm A_0)
	{
		return "xpbl_Abilities.20";
	}

	// Token: 0x0600B3F5 RID: 46069 RVA: 0x004072FC File Offset: 0x004054FC
	public override SpellTargetType bn(cnm A_0)
	{
		return SpellTargetType.CreatureNotSelf;
	}

	// Token: 0x0600B3F6 RID: 46070 RVA: 0x00407304 File Offset: 0x00405504
	public override string bo(cnm A_0)
	{
		string format;
		if (A_0 != null && A_0.b8() != null && A_0.b8().Feats.Contains<n4>())
		{
			format = qv.b("SpecialAbilities/ShootLemurianSpear_HT");
		}
		else
		{
			format = qv.b("SpecialAbilities/ShootLemurianSpear");
		}
		return string.Format(format, es.c(A_0, 1.0).a(true), es.b(A_0, 1.0).a(true), es.f);
	}

	// Token: 0x0600B3F7 RID: 46071 RVA: 0x00407394 File Offset: 0x00405594
	public override string bp(cnm A_0)
	{
		return this.bo(A_0);
	}

	// Token: 0x0600B3F8 RID: 46072 RVA: 0x004073A0 File Offset: 0x004055A0
	public override IList<cfd> bq(cnm A_0, v5 A_1)
	{
		return new List<cfd>
		{
			new cfd(es.g, es.h, false, false)
		};
	}

	// Token: 0x0600B3F9 RID: 46073 RVA: 0x004073C4 File Offset: 0x004055C4
	public override bool hm(cnm A_0)
	{
		return base.hm(A_0) && A_0 != null && A_0.b8() != null && A_0.b8().Offense.u() != null && A_0.b8().Offense.u().TypedDefinition != null && A_0.b8().Offense.u().Battery >= (double)es.f && A_0.b8().Offense.u().TypedDefinition.e("ShootLemurianSpear");
	}

	// Token: 0x0600B3FA RID: 46074 RVA: 0x00407460 File Offset: 0x00405660
	public override bool cu(cnm A_0)
	{
		return A_0 != null && A_0.b8() != null && A_0.b8().Offense.u() != null && A_0.b8().Offense.u().TypedDefinition != null && A_0.b8().Offense.u().Battery >= (double)es.f && A_0.b8().Offense.u().TypedDefinition.e("ShootLemurianSpear");
	}

	// Token: 0x0600B3FB RID: 46075 RVA: 0x004074F0 File Offset: 0x004056F0
	public static a1q c(cnm A_0, double A_1 = 1.0)
	{
		a1q result = new a1q(DamageType.Energy, es.a, es.b);
		es.a(A_0, ref result);
		return result;
	}

	// Token: 0x0600B3FC RID: 46076 RVA: 0x00407518 File Offset: 0x00405718
	public static a1q b(cnm A_0, double A_1 = 1.0)
	{
		a1q result = new a1q(DamageType.Heat, es.c, es.d);
		es.a(A_0, ref result);
		return result;
	}

	// Token: 0x0600B3FD RID: 46077 RVA: 0x00407540 File Offset: 0x00405740
	private static void a(cnm A_0, ref a1q A_1)
	{
		if (A_0 != null && A_0.b8() != null && A_0.b8().Feats.Contains<n4>())
		{
			double num = n4.a(A_0.b8());
			A_1 = a1q.a(A_1, 1.0 + num);
		}
	}

	// Token: 0x0600B3FE RID: 46078 RVA: 0x0040759C File Offset: 0x0040579C
	public static List<csk> a(cnm A_0, double A_1)
	{
		return new List<csk>
		{
			euf.a(es.c(A_0, 1.0), A_1),
			euf.a(es.b(A_0, 1.0), A_1)
		};
	}

	// Token: 0x0600B3FF RID: 46079 RVA: 0x004075DC File Offset: 0x004057DC
	public bg3 bs(cnm A_0, efk A_1, double A_2, double A_3, bool A_4, bool A_5, c3u A_6)
	{
		if (A_0 != null && A_0.b8() != null && A_1 != null)
		{
			cmn cmn = new cmn();
			cmn.a |= A_6;
			int? a_ = null;
			if (A_2 <= 2.0)
			{
				a_ = new int?(A_0.b8().Skills.Get<jk>().g());
			}
			return euf.a(A_0.b8(), A_1, A_2, A_3, A_0.b8().Darkvision, AmmoType.None, false, 1.0, cmn, es.a(A_0), a_);
		}
		return null;
	}

	// Token: 0x0600B400 RID: 46080 RVA: 0x00407678 File Offset: 0x00405878
	public new static cd1 a(cnm A_0)
	{
		bke bke = new bke();
		bke.g("Plasma Cannon");
		bke.a(AmmoType.Energy);
		bke.c(true);
		bke.g(true);
		bke.c((float)es.e);
		bke.d((float)(es.e - 3));
		bke.l().Add(es.c(A_0, 1.0));
		bke.l().Add(es.b(A_0, 1.0));
		bke.a(esu.l);
		bke.a(ImpactSpeed.VeryHigh);
		bke.b(true);
		return new cd1(new IndependentItemDefinitionProvider<bke>(bke));
	}

	// Token: 0x0600B401 RID: 46081 RVA: 0x0040771C File Offset: 0x0040591C
	protected override int br(cnm A_0)
	{
		return 0;
	}

	// Token: 0x0600B402 RID: 46082 RVA: 0x00407720 File Offset: 0x00405920
	protected override float f0(cnm A_0)
	{
		return (float)es.e;
	}

	// Token: 0x0600B403 RID: 46083 RVA: 0x00407728 File Offset: 0x00405928
	protected override int hi(cnm A_0)
	{
		return 15;
	}

	// Token: 0x040041AB RID: 16811
	private new static readonly int a = 50;

	// Token: 0x040041AC RID: 16812
	private static readonly int b = 100;

	// Token: 0x040041AD RID: 16813
	private static readonly int c = 50;

	// Token: 0x040041AE RID: 16814
	private static readonly int d = 100;

	// Token: 0x040041AF RID: 16815
	public new static readonly int e = 10;

	// Token: 0x040041B0 RID: 16816
	public static readonly int f = 25;

	// Token: 0x040041B1 RID: 16817
	private new static readonly string g = "shootLemurianSpear";

	// Token: 0x040041B2 RID: 16818
	private new static readonly int h = 3 * d0u.b;

	// Token: 0x040041B3 RID: 16819
	private new List<string> i;
}

using System;
using System.Collections.Generic;
using TimelapseVertigo.Common;
using TimelapseVertigo.Rules.Capabilities;
using TimelapseVertigo.Rules.Combat;
using TimelapseVertigo.Rules.Items;

// Token: 0x02001E9C RID: 7836
[ayj("ShieldBash")]
public sealed class a5p : c0z, bix
{
	// Token: 0x0600AF9B RID: 44955 RVA: 0x003FE380 File Offset: 0x003FC580
	public override string y8()
	{
		return "Удар щитом";
	}

	// Token: 0x0600AF9C RID: 44956 RVA: 0x003FE388 File Offset: 0x003FC588
	public override string os()
	{
		return "ShieldBash";
	}

	// Token: 0x0600AF9D RID: 44957 RVA: 0x003FE390 File Offset: 0x003FC590
	public override ci8 bg()
	{
		return ci8.c;
	}

	// Token: 0x0600AF9E RID: 44958 RVA: 0x003FE394 File Offset: 0x003FC594
	public override int e8()
	{
		return 1;
	}

	// Token: 0x0600AF9F RID: 44959 RVA: 0x003FE398 File Offset: 0x003FC598
	public override a3b c0()
	{
		return new a3b
		{
			a = c0e.o,
			b = new int?(int.MaxValue),
			c = c0e.o,
			d = new int?(70)
		};
	}

	// Token: 0x0600AFA0 RID: 44960 RVA: 0x003FE3D4 File Offset: 0x003FC5D4
	public override TimelapseCursor? bj()
	{
		return new TimelapseCursor?(TimelapseCursor.InvokeHostileSpellWithChance);
	}

	// Token: 0x0600AFA1 RID: 44961 RVA: 0x003FE3E0 File Offset: 0x003FC5E0
	public override bool hl()
	{
		return false;
	}

	// Token: 0x0600AFA2 RID: 44962 RVA: 0x003FE3E4 File Offset: 0x003FC5E4
	public a5p()
	{
		this.g = new List<string>();
		this.g.Add(a5p.f);
	}

	// Token: 0x0600AFA3 RID: 44963 RVA: 0x003FE408 File Offset: 0x003FC608
	public override string bm(cnm A_0)
	{
		return "xpbl_Attacks.40";
	}

	// Token: 0x0600AFA4 RID: 44964 RVA: 0x003FE410 File Offset: 0x003FC610
	public override SpellTargetType bn(cnm A_0)
	{
		return SpellTargetType.CreatureNotSelf;
	}

	// Token: 0x0600AFA5 RID: 44965 RVA: 0x003FE418 File Offset: 0x003FC618
	public override string bo(cnm A_0)
	{
		return qv.a("SpecialAttacks/ShieldBash", new object[]
		{
			a5p.b(A_0).a(true),
			l4.a(a5p.e, false)
		});
	}

	// Token: 0x0600AFA6 RID: 44966 RVA: 0x003FE458 File Offset: 0x003FC658
	public static b1j d(cnm A_0)
	{
		double num = a5p.a;
		double num2 = a5p.b;
		if (A_0 != null && A_0.b8() != null)
		{
			num += (double)A_0.b8().GetSpecializationValue<ese>(true) * ese.a;
			num2 += (double)A_0.b8().GetSpecializationValue<ese>(true) * ese.a;
		}
		return new b1j(num, num2);
	}

	// Token: 0x0600AFA7 RID: 44967 RVA: 0x003FE4B8 File Offset: 0x003FC6B8
	public override IList<cfd> bq(cnm A_0, v5 A_1)
	{
		List<cfd> list = new List<cfd>();
		int num = a5p.d;
		if (A_0 != null && A_0.b8() != null)
		{
			num -= (int)((double)A_0.b8().GetSpecializationValue<ao0>(true) * ao0.a);
		}
		list.Add(new cfd(a5p.f, num * d0u.b, false, false));
		return list;
	}

	// Token: 0x0600AFA8 RID: 44968 RVA: 0x003FE514 File Offset: 0x003FC714
	public override IList<string> bi()
	{
		return this.g;
	}

	// Token: 0x0600AFA9 RID: 44969 RVA: 0x003FE51C File Offset: 0x003FC71C
	public override bool hm(cnm A_0)
	{
		return base.hm(A_0) && a5p.a(A_0) > 0;
	}

	// Token: 0x0600AFAA RID: 44970 RVA: 0x003FE538 File Offset: 0x003FC738
	public bg3 bs(cnm A_0, efk A_1, double A_2, double A_3, bool A_4, bool A_5, c3u A_6)
	{
		if (A_0 != null && A_0.b8() != null)
		{
			cmn a_ = new cmn();
			return euf.a(A_0.b8(), A_1, a_, 1.0, a5p.c(A_0));
		}
		return null;
	}

	// Token: 0x0600AFAB RID: 44971 RVA: 0x003FE57C File Offset: 0x003FC77C
	public static cd1 c(cnm A_0)
	{
		bke bke = new bke();
		bke.g("Shield");
		bke.a(AmmoType.None);
		bke.c(true);
		bke.g(true);
		bke.c(as3.bk);
		bke.l().Add(a5p.b(A_0));
		bke.b(true);
		bke.a(esu.f);
		bke.a(ImpactSpeed.VeryLow);
		bke.a(btz.g);
		bke.b(6);
		bke.f(0.05);
		bke.aa().Add(new edm("daze", 1.0, a5p.e, true));
		return new cd1(new IndependentItemDefinitionProvider<bke>(bke));
	}

	// Token: 0x0600AFAC RID: 44972 RVA: 0x003FE62C File Offset: 0x003FC82C
	public static a1q b(cnm A_0)
	{
		b1j b1j = a5p.d(A_0);
		int num = a5p.a(A_0);
		return new a1q(DamageType.Mechanical, Convert.ToInt32(b1j.b * (double)num), Convert.ToInt32(b1j.c * (double)num));
	}

	// Token: 0x0600AFAD RID: 44973 RVA: 0x003FE66C File Offset: 0x003FC86C
	public new static int a(cnm A_0)
	{
		if (A_0 != null && A_0.b8() != null)
		{
			return euf.b(A_0.b8());
		}
		return 0;
	}

	// Token: 0x0600AFAE RID: 44974 RVA: 0x003FE68C File Offset: 0x003FC88C
	protected override int br(cnm A_0)
	{
		return 1000;
	}

	// Token: 0x0600AFAF RID: 44975 RVA: 0x003FE694 File Offset: 0x003FC894
	protected override float f0(cnm A_0)
	{
		return as3.bk;
	}

	// Token: 0x0600AFB0 RID: 44976 RVA: 0x003FE69C File Offset: 0x003FC89C
	protected override int hi(cnm A_0)
	{
		int num = a5p.c;
		if (A_0 != null && A_0.b8() != null)
		{
			num -= A_0.b8().GetSpecializationValue<cv0>(true) * cv0.a;
		}
		return num;
	}

	// Token: 0x040040B2 RID: 16562
	public new static readonly double a = 0.75;

	// Token: 0x040040B3 RID: 16563
	public static readonly double b = 1.25;

	// Token: 0x040040B4 RID: 16564
	public static readonly int c = 15;

	// Token: 0x040040B5 RID: 16565
	public static readonly int d = 2;

	// Token: 0x040040B6 RID: 16566
	public new static readonly int e = 1;

	// Token: 0x040040B7 RID: 16567
	private static readonly string f = "SA.ShieldBash";

	// Token: 0x040040B8 RID: 16568
	private new List<string> g;
}

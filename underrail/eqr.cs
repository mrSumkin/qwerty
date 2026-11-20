using System;
using System.Collections.Generic;
using TimelapseVertigo.Rules.Capabilities;
using TimelapseVertigo.Rules.Capabilities.Psi;
using TimelapseVertigo.Rules.Combat;

// Token: 0x02001F18 RID: 7960
[ayj("TemporaryRewind")]
public sealed class eqr : ce5
{
	// Token: 0x0600B75A RID: 46938 RVA: 0x0040D840 File Offset: 0x0040BA40
	public override string y8()
	{
		return "Перемотка времени";
	}

	// Token: 0x0600B75B RID: 46939 RVA: 0x0040D848 File Offset: 0x0040BA48
	public override string os()
	{
		return "TemporaryRewind";
	}

	// Token: 0x0600B75C RID: 46940 RVA: 0x0040D850 File Offset: 0x0040BA50
	public override ci8 bg()
	{
		return ci8.b;
	}

	// Token: 0x0600B75D RID: 46941 RVA: 0x0040D854 File Offset: 0x0040BA54
	public override PsiSchool ch()
	{
		return PsiSchool.TemporalManipulation;
	}

	// Token: 0x0600B75E RID: 46942 RVA: 0x0040D858 File Offset: 0x0040BA58
	public override int ci()
	{
		return 6;
	}

	// Token: 0x0600B75F RID: 46943 RVA: 0x0040D860 File Offset: 0x0040BA60
	public eqr()
	{
		this.h = new List<string>
		{
			d7f.b,
			"TemporaryRewind"
		};
	}

	// Token: 0x0600B760 RID: 46944 RVA: 0x0040D894 File Offset: 0x0040BA94
	public override List<brl> ck()
	{
		return new List<brl>
		{
			new b4k(new Type[]
			{
				typeof(c3v)
			}),
			new bap(60, new Type[]
			{
				typeof(p5)
			})
		};
	}

	// Token: 0x0600B761 RID: 46945 RVA: 0x0040D8E8 File Offset: 0x0040BAE8
	public override SpellTargetType bn(cnm A_0)
	{
		return SpellTargetType.CreatureWithLastDamage;
	}

	// Token: 0x0600B762 RID: 46946 RVA: 0x0040D8EC File Offset: 0x0040BAEC
	public override IList<string> bi()
	{
		return this.h;
	}

	// Token: 0x0600B763 RID: 46947 RVA: 0x0040D8F8 File Offset: 0x0040BAF8
	public override IList<cfd> bq(cnm A_0, v5 A_1)
	{
		List<cfd> list = new List<cfd>();
		if (A_1 == v5.b)
		{
			list.Add(new cfd(d7f.b, d7f.g, true, false));
		}
		int num = eqr.f;
		if (A_0 != null && A_0.b8() != null && A_0.b8().Feats.Contains<ank>())
		{
			num = Math.Max(0, num - ank.b);
		}
		if (num > 0)
		{
			list.Add(new cfd("TemporaryRewind", num * d0u.b, false, false));
		}
		return list;
	}

	// Token: 0x0600B764 RID: 46948 RVA: 0x0040D984 File Offset: 0x0040BB84
	public override string bo(cnm A_0)
	{
		return qv.a("Psi/TemporaryRewind", new object[]
		{
			eqr.a(A_0)
		});
	}

	// Token: 0x0600B765 RID: 46949 RVA: 0x0040D9A4 File Offset: 0x0040BBA4
	public new static int a(cnm A_0)
	{
		if (A_0 != null && A_0.b8() != null)
		{
			p5 p = A_0.b8().Skills.Get<p5>();
			if (p != null)
			{
				return 20 + 2 * p.g();
			}
		}
		return 0;
	}

	// Token: 0x0600B766 RID: 46950 RVA: 0x0040D9E8 File Offset: 0x0040BBE8
	protected override int hi(cnm A_0)
	{
		int num = 20;
		if (A_0 != null && A_0.b8() != null && A_0.b8().Feats.Contains<ank>())
		{
			num += ank.a(A_0);
		}
		return num;
	}

	// Token: 0x0600B767 RID: 46951 RVA: 0x0040DA28 File Offset: 0x0040BC28
	protected override float f0(cnm A_0)
	{
		return 10f;
	}

	// Token: 0x0600B768 RID: 46952 RVA: 0x0040DA30 File Offset: 0x0040BC30
	protected override float cj(cnm A_0)
	{
		return 40f;
	}

	// Token: 0x0600B769 RID: 46953 RVA: 0x0040DA38 File Offset: 0x0040BC38
	protected override int br(cnm A_0)
	{
		return 1500;
	}

	// Token: 0x0600B76A RID: 46954 RVA: 0x0040DA40 File Offset: 0x0040BC40
	protected override PsiAbilityCategories cm(cnm A_0)
	{
		return PsiAbilityCategories.NonDamaging;
	}

	// Token: 0x0400429D RID: 17053
	private new const string a = "Temporary Rewind";

	// Token: 0x0400429E RID: 17054
	private const string b = "TemporaryRewind";

	// Token: 0x0400429F RID: 17055
	private const string c = "TemporaryRewind";

	// Token: 0x040042A0 RID: 17056
	private const int d = 20;

	// Token: 0x040042A1 RID: 17057
	private new const int e = 2;

	// Token: 0x040042A2 RID: 17058
	public new static readonly int f = 6;

	// Token: 0x040042A3 RID: 17059
	public new static readonly int g = 4;

	// Token: 0x040042A4 RID: 17060
	private new List<string> h;
}

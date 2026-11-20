using System;
using System.Collections.Generic;
using TimelapseVertigo.Rules.Capabilities;
using TimelapseVertigo.Rules.Capabilities.Psi;
using TimelapseVertigo.Rules.Combat;

// Token: 0x02001F19 RID: 7961
[ayj("LimitedTemporalIncrement")]
public sealed class e6g : ce5
{
	// Token: 0x0600B76C RID: 46956 RVA: 0x0040DA54 File Offset: 0x0040BC54
	public override string y8()
	{
		return "Ограничение задержки времени";
	}

	// Token: 0x0600B76D RID: 46957 RVA: 0x0040DA5C File Offset: 0x0040BC5C
	public override string os()
	{
		return "LimitedTemporalIncrement";
	}

	// Token: 0x0600B76E RID: 46958 RVA: 0x0040DA64 File Offset: 0x0040BC64
	public override ci8 bg()
	{
		return ci8.b;
	}

	// Token: 0x0600B76F RID: 46959 RVA: 0x0040DA68 File Offset: 0x0040BC68
	public override PsiSchool ch()
	{
		return PsiSchool.TemporalManipulation;
	}

	// Token: 0x0600B770 RID: 46960 RVA: 0x0040DA6C File Offset: 0x0040BC6C
	public override int ci()
	{
		return 3;
	}

	// Token: 0x0600B771 RID: 46961 RVA: 0x0040DA74 File Offset: 0x0040BC74
	public e6g()
	{
		this.f = new List<string>
		{
			d7f.b,
			e6g.c
		};
	}

	// Token: 0x0600B772 RID: 46962 RVA: 0x0040DAA8 File Offset: 0x0040BCA8
	public override List<brl> ck()
	{
		return new List<brl>
		{
			new b4k(new Type[]
			{
				typeof(c3v)
			}),
			new bap(35, new Type[]
			{
				typeof(p5)
			})
		};
	}

	// Token: 0x0600B773 RID: 46963 RVA: 0x0040DAFC File Offset: 0x0040BCFC
	public override SpellTargetType bn(cnm A_0)
	{
		return SpellTargetType.Self;
	}

	// Token: 0x0600B774 RID: 46964 RVA: 0x0040DB00 File Offset: 0x0040BD00
	public override IList<string> bi()
	{
		return this.f;
	}

	// Token: 0x0600B775 RID: 46965 RVA: 0x0040DB0C File Offset: 0x0040BD0C
	public override IList<cfd> bq(cnm A_0, v5 A_1)
	{
		List<cfd> list = new List<cfd>();
		if (A_1 == v5.b)
		{
			list.Add(new cfd(d7f.b, d7f.g, true, false));
		}
		int num = e6g.e;
		if (A_0 != null && A_0.b8() != null && A_0.b8().Feats.Contains<ank>())
		{
			num = Math.Max(0, num - ank.b);
		}
		if (num > 0)
		{
			list.Add(new cfd(e6g.c, num * d0u.b, false, false));
		}
		return list;
	}

	// Token: 0x0600B776 RID: 46966 RVA: 0x0040DB98 File Offset: 0x0040BD98
	public override string bo(cnm A_0)
	{
		return qv.a("Psi/LimitedTemporalIncrement", new object[]
		{
			l4.a(e6g.d, false)
		});
	}

	// Token: 0x0600B777 RID: 46967 RVA: 0x0040DBB8 File Offset: 0x0040BDB8
	protected override int hi(cnm A_0)
	{
		int num = 5;
		if (A_0 != null && A_0.b8() != null && A_0.b8().Feats.Contains<ank>())
		{
			num += ank.a(A_0);
		}
		return num;
	}

	// Token: 0x0600B778 RID: 46968 RVA: 0x0040DBF8 File Offset: 0x0040BDF8
	protected override float cj(cnm A_0)
	{
		return 35f;
	}

	// Token: 0x0600B779 RID: 46969 RVA: 0x0040DC00 File Offset: 0x0040BE00
	protected override int br(cnm A_0)
	{
		return 1500;
	}

	// Token: 0x0600B77A RID: 46970 RVA: 0x0040DC08 File Offset: 0x0040BE08
	protected override PsiAbilityCategories cm(cnm A_0)
	{
		return PsiAbilityCategories.NonDamaging;
	}

	// Token: 0x040042A5 RID: 17061
	private new const string a = "Limited Temporal Increment";

	// Token: 0x040042A6 RID: 17062
	private const string b = "LimitedTemporalIncrement";

	// Token: 0x040042A7 RID: 17063
	public static readonly string c = "LimitedTemporalIncrement";

	// Token: 0x040042A8 RID: 17064
	public static readonly int d = 1;

	// Token: 0x040042A9 RID: 17065
	public new static readonly int e = 3;

	// Token: 0x040042AA RID: 17066
	private new List<string> f;
}

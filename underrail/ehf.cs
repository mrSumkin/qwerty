using System;
using System.Collections.Generic;
using TimelapseVertigo.Rules.Capabilities;
using TimelapseVertigo.Rules.Capabilities.Psi;
using TimelapseVertigo.Rules.Combat;

// Token: 0x02001F23 RID: 7971
[ayj("ElectrokineticImprint")]
public sealed class ehf : ce5
{
	// Token: 0x0600B827 RID: 47143 RVA: 0x0040F3D0 File Offset: 0x0040D5D0
	public override string y8()
	{
		return "Электрокинетический отпечаток";
	}

	// Token: 0x0600B828 RID: 47144 RVA: 0x0040F3D8 File Offset: 0x0040D5D8
	public override string os()
	{
		return "ElectrokineticImprint";
	}

	// Token: 0x0600B829 RID: 47145 RVA: 0x0040F3E0 File Offset: 0x0040D5E0
	public override ci8 bg()
	{
		return ci8.c;
	}

	// Token: 0x0600B82A RID: 47146 RVA: 0x0040F3E4 File Offset: 0x0040D5E4
	public override PsiSchool ch()
	{
		return PsiSchool.Psychokinesis;
	}

	// Token: 0x0600B82B RID: 47147 RVA: 0x0040F3E8 File Offset: 0x0040D5E8
	public override int ci()
	{
		return 6;
	}

	// Token: 0x0600B82C RID: 47148 RVA: 0x0040F3EC File Offset: 0x0040D5EC
	public ehf()
	{
		this.g = new List<string>
		{
			d7f.b,
			ehf.a
		};
	}

	// Token: 0x0600B82D RID: 47149 RVA: 0x0040F420 File Offset: 0x0040D620
	public override SpellTargetType bn(cnm A_0)
	{
		return SpellTargetType.TrappableSpot;
	}

	// Token: 0x0600B82E RID: 47150 RVA: 0x0040F424 File Offset: 0x0040D624
	public override IList<string> bi()
	{
		return this.g;
	}

	// Token: 0x0600B82F RID: 47151 RVA: 0x0040F42C File Offset: 0x0040D62C
	public override IList<cfd> bq(cnm A_0, v5 A_1)
	{
		List<cfd> list = new List<cfd>();
		if (A_1 == v5.b)
		{
			list.Add(new cfd(d7f.b, d7f.g, true, false));
		}
		list.Add(new cfd(ehf.a, ehf.b * d0u.b, false, false));
		return list;
	}

	// Token: 0x0600B830 RID: 47152 RVA: 0x0040F47C File Offset: 0x0040D67C
	public override string bo(cnm A_0)
	{
		return qv.a("Psi/ElectrokineticImprint", new object[]
		{
			ehf.a(A_0).a(true),
			l4.a(ehf.f, false)
		});
	}

	// Token: 0x0600B831 RID: 47153 RVA: 0x0040F4BC File Offset: 0x0040D6BC
	public new static a1q a(cnm A_0)
	{
		if (A_0 == null || A_0.b8() == null)
		{
			return new a1q(DamageType.Heat, 0, 0);
		}
		int a_ = 0;
		fd fd = A_0.b8().Skills.Get<fd>();
		if (fd != null)
		{
			a_ = fd.g();
		}
		return ehf.a(a_);
	}

	// Token: 0x0600B832 RID: 47154 RVA: 0x0040F50C File Offset: 0x0040D70C
	public static a1q a(int A_0)
	{
		return new a1q
		{
			DamageType = DamageType.Electricity,
			LowerBoundary = Convert.ToInt32(20.0 + 0.4 * (double)A_0),
			UpperBoundary = Convert.ToInt32(21.0 + 1.2 * (double)A_0)
		};
	}

	// Token: 0x0600B833 RID: 47155 RVA: 0x0040F570 File Offset: 0x0040D770
	protected override int hi(cnm A_0)
	{
		return 10;
	}

	// Token: 0x0600B834 RID: 47156 RVA: 0x0040F574 File Offset: 0x0040D774
	protected override int br(cnm A_0)
	{
		return 1000;
	}

	// Token: 0x0600B835 RID: 47157 RVA: 0x0040F57C File Offset: 0x0040D77C
	protected override float f0(cnm A_0)
	{
		return 5f;
	}

	// Token: 0x0600B836 RID: 47158 RVA: 0x0040F584 File Offset: 0x0040D784
	protected override float cj(cnm A_0)
	{
		return 15f;
	}

	// Token: 0x0600B837 RID: 47159 RVA: 0x0040F58C File Offset: 0x0040D78C
	public override List<brl> ck()
	{
		return new List<brl>
		{
			new b4k(new Type[]
			{
				typeof(c3v)
			}),
			new bap(45, new Type[]
			{
				typeof(fd)
			})
		};
	}

	// Token: 0x0600B838 RID: 47160 RVA: 0x0040F5E0 File Offset: 0x0040D7E0
	protected override PsiAbilityCategories cm(cnm A_0)
	{
		return PsiAbilityCategories.Damaging;
	}

	// Token: 0x04004309 RID: 17161
	public new static readonly string a = "Psi.ElectrokineticImprint";

	// Token: 0x0400430A RID: 17162
	private static readonly int b = 3;

	// Token: 0x0400430B RID: 17163
	private const double c = 20.0;

	// Token: 0x0400430C RID: 17164
	private const double d = 0.4;

	// Token: 0x0400430D RID: 17165
	private new const double e = 1.2;

	// Token: 0x0400430E RID: 17166
	public new static readonly int f = 2;

	// Token: 0x0400430F RID: 17167
	private new List<string> g;
}

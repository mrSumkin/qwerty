using System;
using System.Collections.Generic;
using TimelapseVertigo.Rules.Capabilities;
using TimelapseVertigo.Rules.Capabilities.Psi;
using TimelapseVertigo.Rules.Combat;

// Token: 0x02001F11 RID: 7953
[ayj("TelekineticGrounding")]
public sealed class bfk : ce5
{
	// Token: 0x0600B6F3 RID: 46835 RVA: 0x0040CAAC File Offset: 0x0040ACAC
	public override string y8()
	{
		return "Телекинетическое заземление";
	}

	// Token: 0x0600B6F4 RID: 46836 RVA: 0x0040CAB4 File Offset: 0x0040ACB4
	public override string os()
	{
		return "TelekineticGrounding";
	}

	// Token: 0x0600B6F5 RID: 46837 RVA: 0x0040CABC File Offset: 0x0040ACBC
	public override ci8 bg()
	{
		return ci8.c;
	}

	// Token: 0x0600B6F6 RID: 46838 RVA: 0x0040CAC0 File Offset: 0x0040ACC0
	public override PsiSchool ch()
	{
		return PsiSchool.Psychokinesis;
	}

	// Token: 0x0600B6F7 RID: 46839 RVA: 0x0040CAC4 File Offset: 0x0040ACC4
	public override int ci()
	{
		return 3;
	}

	// Token: 0x0600B6F8 RID: 46840 RVA: 0x0040CAC8 File Offset: 0x0040ACC8
	public bfk()
	{
		this.d = new List<string>
		{
			d7f.b,
			bfk.a
		};
	}

	// Token: 0x0600B6F9 RID: 46841 RVA: 0x0040CAFC File Offset: 0x0040ACFC
	public override List<brl> ck()
	{
		return new List<brl>
		{
			new b4k(new Type[]
			{
				typeof(c3v)
			}),
			new bap(30, new Type[]
			{
				typeof(fd)
			})
		};
	}

	// Token: 0x0600B6FA RID: 46842 RVA: 0x0040CB50 File Offset: 0x0040AD50
	public override SpellTargetType bn(cnm A_0)
	{
		return SpellTargetType.CreatureNotSelf;
	}

	// Token: 0x0600B6FB RID: 46843 RVA: 0x0040CB54 File Offset: 0x0040AD54
	public override IList<string> bi()
	{
		return this.d;
	}

	// Token: 0x0600B6FC RID: 46844 RVA: 0x0040CB60 File Offset: 0x0040AD60
	public override IList<cfd> bq(cnm A_0, v5 A_1)
	{
		List<cfd> list = new List<cfd>();
		if (A_1 == v5.b)
		{
			list.Add(new cfd(d7f.b, d7f.g, true, false));
		}
		list.Add(new cfd(bfk.a, bfk.b, false, false));
		return list;
	}

	// Token: 0x0600B6FD RID: 46845 RVA: 0x0040CBAC File Offset: 0x0040ADAC
	public override string bo(cnm A_0)
	{
		return qv.a("Psi/TelekineticGrounding", new object[]
		{
			l4.a((double)bfk.a(A_0), false)
		});
	}

	// Token: 0x0600B6FE RID: 46846 RVA: 0x0040CBD0 File Offset: 0x0040ADD0
	public new static int a(cnm A_0)
	{
		return bfk.c;
	}

	// Token: 0x0600B6FF RID: 46847 RVA: 0x0040CBD8 File Offset: 0x0040ADD8
	protected override int hi(cnm A_0)
	{
		return 15;
	}

	// Token: 0x0600B700 RID: 46848 RVA: 0x0040CBDC File Offset: 0x0040ADDC
	protected override int br(cnm A_0)
	{
		return 1000;
	}

	// Token: 0x0600B701 RID: 46849 RVA: 0x0040CBE4 File Offset: 0x0040ADE4
	protected override float f0(cnm A_0)
	{
		return 6f;
	}

	// Token: 0x0600B702 RID: 46850 RVA: 0x0040CBEC File Offset: 0x0040ADEC
	protected override float cj(cnm A_0)
	{
		return 20f;
	}

	// Token: 0x0600B703 RID: 46851 RVA: 0x0040CBF4 File Offset: 0x0040ADF4
	protected override PsiAbilityCategories cm(cnm A_0)
	{
		return PsiAbilityCategories.NonDamaging | PsiAbilityCategories.Telekinetic;
	}

	// Token: 0x0400427F RID: 17023
	public new static readonly string a = "Psi.TelekineticGrounding";

	// Token: 0x04004280 RID: 17024
	public static readonly int b = 8 * d0u.b;

	// Token: 0x04004281 RID: 17025
	private static readonly int c = 5 * d0u.b;

	// Token: 0x04004282 RID: 17026
	private List<string> d;
}

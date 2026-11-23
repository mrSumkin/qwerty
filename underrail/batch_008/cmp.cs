using System;
using System.Collections.Generic;
using TimelapseVertigo.Rules.Capabilities;
using TimelapseVertigo.Rules.Capabilities.Psi;
using TimelapseVertigo.Rules.Combat;

// Token: 0x02001F33 RID: 7987
[ayj("Cryostasis")]
public sealed class cmp : ce5
{
	// Token: 0x0600B94E RID: 47438 RVA: 0x004118CC File Offset: 0x0040FACC
	public override string y8()
	{
		return "Криостазис";
	}

	// Token: 0x0600B94F RID: 47439 RVA: 0x004118D4 File Offset: 0x0040FAD4
	public override string os()
	{
		return "Cryostasis";
	}

	// Token: 0x0600B950 RID: 47440 RVA: 0x004118DC File Offset: 0x0040FADC
	public override ci8 bg()
	{
		return ci8.c;
	}

	// Token: 0x0600B951 RID: 47441 RVA: 0x004118E0 File Offset: 0x0040FAE0
	public override PsiSchool ch()
	{
		return PsiSchool.Metathermics;
	}

	// Token: 0x0600B952 RID: 47442 RVA: 0x004118E4 File Offset: 0x0040FAE4
	public override int ci()
	{
		return 3;
	}

	// Token: 0x0600B953 RID: 47443 RVA: 0x004118E8 File Offset: 0x0040FAE8
	public cmp()
	{
		this.f = new List<string>
		{
			"Psi.Cryostasis"
		};
	}

	// Token: 0x0600B954 RID: 47444 RVA: 0x00411908 File Offset: 0x0040FB08
	public override SpellTargetType bn(cnm A_0)
	{
		return SpellTargetType.CreatureNotSelf;
	}

	// Token: 0x0600B955 RID: 47445 RVA: 0x0041190C File Offset: 0x0040FB0C
	public override IList<string> bi()
	{
		return this.f;
	}

	// Token: 0x0600B956 RID: 47446 RVA: 0x00411914 File Offset: 0x0040FB14
	public override IList<cfd> bq(cnm A_0, v5 A_1)
	{
		return new List<cfd>
		{
			new cfd("Psi.Cryostasis", 40000, false, false)
		};
	}

	// Token: 0x0600B957 RID: 47447 RVA: 0x00411934 File Offset: 0x0040FB34
	public override string bo(cnm A_0)
	{
		string text = qv.b("Psi/Cryostasis");
		string result = string.Empty;
		if (!string.IsNullOrEmpty(text))
		{
			try
			{
				result = string.Format(text, l4.a((double)cmp.a(A_0, 0)));
			}
			catch
			{
			}
		}
		return result;
	}

	// Token: 0x0600B958 RID: 47448 RVA: 0x00411994 File Offset: 0x0040FB94
	public static int a(cnm A_0, int A_1)
	{
		return 10000 + A_1 * 5000 + euf.a(A_0);
	}

	// Token: 0x0600B959 RID: 47449 RVA: 0x004119AC File Offset: 0x0040FBAC
	protected override float f0(cnm A_0)
	{
		return 6f;
	}

	// Token: 0x0600B95A RID: 47450 RVA: 0x004119B4 File Offset: 0x0040FBB4
	protected override float cj(cnm A_0)
	{
		return 65f;
	}

	// Token: 0x0600B95B RID: 47451 RVA: 0x004119BC File Offset: 0x0040FBBC
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
				typeof(rs)
			})
		};
	}

	// Token: 0x0600B95C RID: 47452 RVA: 0x00411A10 File Offset: 0x0040FC10
	protected override float cl(cnm A_0)
	{
		float num = base.cl(A_0);
		if ((A_0.b8().bb & eom.c) != eom.a)
		{
			num *= (float)(1.0 - dyi.a(A_0.b8()));
		}
		return num;
	}

	// Token: 0x0600B95D RID: 47453 RVA: 0x00411A54 File Offset: 0x0040FC54
	protected override int hi(cnm A_0)
	{
		return 10;
	}

	// Token: 0x0600B95E RID: 47454 RVA: 0x00411A58 File Offset: 0x0040FC58
	protected override PsiAbilityCategories cm(cnm A_0)
	{
		return PsiAbilityCategories.NonDamaging;
	}

	// Token: 0x04004373 RID: 17267
	public new const string a = "Psi.Cryostasis";

	// Token: 0x04004374 RID: 17268
	private const string b = "Cryostasis";

	// Token: 0x04004375 RID: 17269
	private const int c = 10000;

	// Token: 0x04004376 RID: 17270
	private const int d = 5000;

	// Token: 0x04004377 RID: 17271
	private new const int e = 40000;

	// Token: 0x04004378 RID: 17272
	private new List<string> f;
}

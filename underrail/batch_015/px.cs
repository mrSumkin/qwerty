using System;
using System.Collections.Generic;
using TimelapseVertigo.Rules.Capabilities;
using TimelapseVertigo.Rules.Capabilities.Psi;
using TimelapseVertigo.Rules.Combat;

// Token: 0x02001F26 RID: 7974
[ayj("PsiCognitiveInterruption")]
public sealed class px : ce5
{
	// Token: 0x0600B85E RID: 47198 RVA: 0x0040F984 File Offset: 0x0040DB84
	public override string y8()
	{
		return "Пси-когнитивное прерывание";
	}

	// Token: 0x0600B85F RID: 47199 RVA: 0x0040F98C File Offset: 0x0040DB8C
	public override string os()
	{
		return "PsiCognitiveInterruption";
	}

	// Token: 0x0600B860 RID: 47200 RVA: 0x0040F994 File Offset: 0x0040DB94
	public override ci8 bg()
	{
		return ci8.c;
	}

	// Token: 0x0600B861 RID: 47201 RVA: 0x0040F998 File Offset: 0x0040DB98
	public override PsiSchool ch()
	{
		return PsiSchool.ThoughtControl;
	}

	// Token: 0x0600B862 RID: 47202 RVA: 0x0040F99C File Offset: 0x0040DB9C
	public override int ci()
	{
		return 6;
	}

	// Token: 0x0600B863 RID: 47203 RVA: 0x0040F9A0 File Offset: 0x0040DBA0
	public px()
	{
		this.j = new List<string>
		{
			d7f.b,
			"Psi.PsiCognitiveInterruption"
		};
	}

	// Token: 0x0600B864 RID: 47204 RVA: 0x0040F9D4 File Offset: 0x0040DBD4
	public override List<brl> ck()
	{
		return new List<brl>
		{
			new b4k(new Type[]
			{
				typeof(c3v)
			}),
			new bap(55, new Type[]
			{
				typeof(dql)
			})
		};
	}

	// Token: 0x0600B865 RID: 47205 RVA: 0x0040FA28 File Offset: 0x0040DC28
	public override SpellTargetType bn(cnm A_0)
	{
		if (A_0 != null && A_0.b8() != null && A_0.b8().StatusEffects.a(bgo.a))
		{
			return SpellTargetType.DiscoveredPenetrableSpot;
		}
		return SpellTargetType.CreatureNotSelf;
	}

	// Token: 0x0600B866 RID: 47206 RVA: 0x0040FA5C File Offset: 0x0040DC5C
	public override IList<string> bi()
	{
		return this.j;
	}

	// Token: 0x0600B867 RID: 47207 RVA: 0x0040FA64 File Offset: 0x0040DC64
	public override IList<cfd> bq(cnm A_0, v5 A_1)
	{
		return new List<cfd>
		{
			new cfd("Psi.PsiCognitiveInterruption", 5 * d0u.b, false, false)
		};
	}

	// Token: 0x0600B868 RID: 47208 RVA: 0x0040FA84 File Offset: 0x0040DC84
	public override string bo(cnm A_0)
	{
		b1j b1j = px.c(A_0);
		double num = px.b(A_0);
		return qv.a("Psi/PsiCognitiveInterruption", new object[]
		{
			(int)b1j.b,
			(int)b1j.c,
			(int)(num * 100.0),
			l4.a(px.i, false)
		});
	}

	// Token: 0x0600B869 RID: 47209 RVA: 0x0040FAF0 File Offset: 0x0040DCF0
	public static b1j c(cnm A_0)
	{
		return new b1j((double)px.e, (double)px.f);
	}

	// Token: 0x0600B86A RID: 47210 RVA: 0x0040FB08 File Offset: 0x0040DD08
	public static double b(cnm A_0)
	{
		int effectivePsiSkillLevel = ce5.GetEffectivePsiSkillLevel<dql>(A_0);
		return px.g + px.h * (double)effectivePsiSkillLevel;
	}

	// Token: 0x0600B86B RID: 47211 RVA: 0x0040FB2C File Offset: 0x0040DD2C
	public new static int a(cnm A_0)
	{
		return ce5.GetEffectivePsiSkillLevel<dql>(A_0);
	}

	// Token: 0x0600B86C RID: 47212 RVA: 0x0040FB34 File Offset: 0x0040DD34
	protected override int hi(cnm A_0)
	{
		return 20;
	}

	// Token: 0x0600B86D RID: 47213 RVA: 0x0040FB38 File Offset: 0x0040DD38
	protected override int d2(cnm A_0)
	{
		if (A_0 != null && A_0.b8() != null && A_0.b8().StatusEffects.a(bgo.a))
		{
			return bgo.b;
		}
		return 0;
	}

	// Token: 0x0600B86E RID: 47214 RVA: 0x0040FB6C File Offset: 0x0040DD6C
	protected override float f0(cnm A_0)
	{
		return 10f;
	}

	// Token: 0x0600B86F RID: 47215 RVA: 0x0040FB74 File Offset: 0x0040DD74
	protected override float cj(cnm A_0)
	{
		return 25f;
	}

	// Token: 0x0600B870 RID: 47216 RVA: 0x0040FB7C File Offset: 0x0040DD7C
	protected override int br(cnm A_0)
	{
		return 1500;
	}

	// Token: 0x0600B871 RID: 47217 RVA: 0x0040FB84 File Offset: 0x0040DD84
	protected override PsiAbilityCategories cm(cnm A_0)
	{
		return PsiAbilityCategories.Damaging;
	}

	// Token: 0x0400431F RID: 17183
	public new const string a = "Psi.PsiCognitiveInterruption";

	// Token: 0x04004320 RID: 17184
	private const int b = 5;

	// Token: 0x04004321 RID: 17185
	private const string c = "Psi-cognitive Interruption";

	// Token: 0x04004322 RID: 17186
	private const string d = "PsiCognitiveInterruption";

	// Token: 0x04004323 RID: 17187
	private new static readonly int e = 25;

	// Token: 0x04004324 RID: 17188
	private new static readonly int f = 75;

	// Token: 0x04004325 RID: 17189
	private new static readonly double g = 0.5;

	// Token: 0x04004326 RID: 17190
	private new static readonly double h = 0.01;

	// Token: 0x04004327 RID: 17191
	public new static readonly int i = 3;

	// Token: 0x04004328 RID: 17192
	private new List<string> j;
}

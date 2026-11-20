using System;
using System.Collections.Generic;
using TimelapseVertigo.Rules.Capabilities;
using TimelapseVertigo.Rules.Capabilities.Psi;
using TimelapseVertigo.Rules.Combat;

// Token: 0x02001F25 RID: 7973
[ayj("PseudoSpatialProjection")]
public sealed class d97 : ce5
{
	// Token: 0x0600B84D RID: 47181 RVA: 0x0040F7F8 File Offset: 0x0040D9F8
	public override string y8()
	{
		return "Псевдо-пространственная проекция";
	}

	// Token: 0x0600B84E RID: 47182 RVA: 0x0040F800 File Offset: 0x0040DA00
	public override string os()
	{
		return "PseudoSpatialProjection";
	}

	// Token: 0x0600B84F RID: 47183 RVA: 0x0040F808 File Offset: 0x0040DA08
	public override ci8 bg()
	{
		return ci8.b;
	}

	// Token: 0x0600B850 RID: 47184 RVA: 0x0040F80C File Offset: 0x0040DA0C
	public override PsiSchool ch()
	{
		return PsiSchool.ThoughtControl;
	}

	// Token: 0x0600B851 RID: 47185 RVA: 0x0040F810 File Offset: 0x0040DA10
	public override int ci()
	{
		return 7;
	}

	// Token: 0x0600B852 RID: 47186 RVA: 0x0040F818 File Offset: 0x0040DA18
	public d97()
	{
		this.h = new List<string>
		{
			d7f.b,
			"Psi.PseudoSpatialProjection"
		};
	}

	// Token: 0x0600B853 RID: 47187 RVA: 0x0040F84C File Offset: 0x0040DA4C
	public override List<brl> ck()
	{
		return new List<brl>
		{
			new b4k(new Type[]
			{
				typeof(c3v)
			}),
			new bap(65, new Type[]
			{
				typeof(dql)
			})
		};
	}

	// Token: 0x0600B854 RID: 47188 RVA: 0x0040F8A0 File Offset: 0x0040DAA0
	public override SpellTargetType bn(cnm A_0)
	{
		return SpellTargetType.Self;
	}

	// Token: 0x0600B855 RID: 47189 RVA: 0x0040F8A4 File Offset: 0x0040DAA4
	public override IList<string> bi()
	{
		return this.h;
	}

	// Token: 0x0600B856 RID: 47190 RVA: 0x0040F8B0 File Offset: 0x0040DAB0
	public override IList<cfd> bq(cnm A_0, v5 A_1)
	{
		int num = uf.a(8 * d0u.b, A_0, new CooldownCategory[]
		{
			CooldownCategory.PseudoSpatialProjection
		});
		List<cfd> list = new List<cfd>();
		if (num > 0)
		{
			list.Add(new cfd("Psi.PseudoSpatialProjection", num, false, false));
		}
		else
		{
			list.Add(new cfd("Psi.PseudoSpatialProjection", 8 * d0u.b, false, false));
		}
		return list;
	}

	// Token: 0x0600B857 RID: 47191 RVA: 0x0040F918 File Offset: 0x0040DB18
	public override string bo(cnm A_0)
	{
		return qv.a("Psi/PseudoSpatialProjection", new object[]
		{
			d97.a(A_0),
			l4.a(d97.g, false)
		});
	}

	// Token: 0x0600B858 RID: 47192 RVA: 0x0040F948 File Offset: 0x0040DB48
	public new static int a(cnm A_0)
	{
		int effectivePsiSkillLevel = ce5.GetEffectivePsiSkillLevel<dql>(A_0);
		return 2 + effectivePsiSkillLevel / 40;
	}

	// Token: 0x0600B859 RID: 47193 RVA: 0x0040F964 File Offset: 0x0040DB64
	protected override int hi(cnm A_0)
	{
		return 30;
	}

	// Token: 0x0600B85A RID: 47194 RVA: 0x0040F968 File Offset: 0x0040DB68
	protected override float cj(cnm A_0)
	{
		return 25f;
	}

	// Token: 0x0600B85B RID: 47195 RVA: 0x0040F970 File Offset: 0x0040DB70
	protected override int br(cnm A_0)
	{
		return 1500;
	}

	// Token: 0x0600B85C RID: 47196 RVA: 0x0040F978 File Offset: 0x0040DB78
	protected override PsiAbilityCategories cm(cnm A_0)
	{
		return PsiAbilityCategories.NonDamaging;
	}

	// Token: 0x04004317 RID: 17175
	public new const string a = "Psi.PseudoSpatialProjection";

	// Token: 0x04004318 RID: 17176
	private const int b = 8;

	// Token: 0x04004319 RID: 17177
	private const string c = "Pseudo-spatial Projection";

	// Token: 0x0400431A RID: 17178
	private const string d = "PseudoSpatialProjection";

	// Token: 0x0400431B RID: 17179
	private new const int e = 2;

	// Token: 0x0400431C RID: 17180
	private new const int f = 40;

	// Token: 0x0400431D RID: 17181
	public new static readonly int g = 5;

	// Token: 0x0400431E RID: 17182
	private new List<string> h;
}

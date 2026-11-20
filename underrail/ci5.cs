using System;
using System.Collections.Generic;
using TimelapseVertigo.Rules.Capabilities;
using TimelapseVertigo.Rules.Capabilities.Psi;
using TimelapseVertigo.Rules.Combat;

// Token: 0x02001F2A RID: 7978
[ayj("TelekineticProxy")]
public sealed class ci5 : ce5
{
	// Token: 0x0600B8AD RID: 47277 RVA: 0x004102F0 File Offset: 0x0040E4F0
	public override string y8()
	{
		return "Телекинетический двойник";
	}

	// Token: 0x0600B8AE RID: 47278 RVA: 0x004102F8 File Offset: 0x0040E4F8
	public override string os()
	{
		return "TelekineticProxy";
	}

	// Token: 0x0600B8AF RID: 47279 RVA: 0x00410300 File Offset: 0x0040E500
	public override ci8 bg()
	{
		return ci8.c;
	}

	// Token: 0x0600B8B0 RID: 47280 RVA: 0x00410304 File Offset: 0x0040E504
	public override PsiSchool ch()
	{
		return PsiSchool.Psychokinesis;
	}

	// Token: 0x0600B8B1 RID: 47281 RVA: 0x00410308 File Offset: 0x0040E508
	public override int ci()
	{
		return 7;
	}

	// Token: 0x0600B8B2 RID: 47282 RVA: 0x0041030C File Offset: 0x0040E50C
	public override bool ds()
	{
		return true;
	}

	// Token: 0x0600B8B3 RID: 47283 RVA: 0x00410310 File Offset: 0x0040E510
	public ci5()
	{
		this.h = new List<string>
		{
			d7f.b,
			ci5.a
		};
	}

	// Token: 0x0600B8B4 RID: 47284 RVA: 0x00410344 File Offset: 0x0040E544
	public override SpellTargetType bn(cnm A_0)
	{
		return SpellTargetType.DiscoveredTraversableSpot;
	}

	// Token: 0x0600B8B5 RID: 47285 RVA: 0x00410348 File Offset: 0x0040E548
	public override IList<string> bi()
	{
		return this.h;
	}

	// Token: 0x0600B8B6 RID: 47286 RVA: 0x00410350 File Offset: 0x0040E550
	public override IList<cfd> bq(cnm A_0, v5 A_1)
	{
		List<cfd> list = new List<cfd>();
		if (A_1 == v5.b)
		{
			list.Add(new cfd(d7f.b, d7f.g, true, false));
		}
		list.Add(new cfd(ci5.a, 5000, false, false));
		return list;
	}

	// Token: 0x0600B8B7 RID: 47287 RVA: 0x0041039C File Offset: 0x0040E59C
	public override string bo(cnm A_0)
	{
		a1q a1q = ci5.a(A_0);
		string text = qv.b("Psi/TelekineticProxy");
		string result = string.Empty;
		if (!string.IsNullOrEmpty(text))
		{
			try
			{
				result = string.Format(text, a1q.a(true), l4.a(ci5.f, false));
			}
			catch
			{
			}
		}
		return result;
	}

	// Token: 0x0600B8B8 RID: 47288 RVA: 0x00410404 File Offset: 0x0040E604
	public new static a1q a(cnm A_0)
	{
		a1q result = default(a1q);
		result.DamageType = DamageType.Mechanical;
		if (A_0 != null && A_0.b8() != null)
		{
			fd fd = A_0.b8().Skills.Get<fd>();
			double num = 1.0;
			if (A_0.b8().Feats.Contains<d6t>() && A_0.b8().BaseAbilities.Strength > d6t.b)
			{
				num *= 1.0 + (d6t.a + (double)A_0.b8().GetSpecializationValue<e31>(true) * e31.a) * (double)(A_0.b8().BaseAbilities.Strength - d6t.b);
			}
			if (fd != null)
			{
				result.LowerBoundary = (int)((10.0 + 0.3 * (double)fd.g()) * num);
				result.UpperBoundary = (int)((11.0 + 0.5 * (double)fd.g()) * num);
			}
		}
		return result;
	}

	// Token: 0x0600B8B9 RID: 47289 RVA: 0x0041050C File Offset: 0x0040E70C
	protected override int hi(cnm A_0)
	{
		return 10;
	}

	// Token: 0x0600B8BA RID: 47290 RVA: 0x00410510 File Offset: 0x0040E710
	protected override int br(cnm A_0)
	{
		return 1000;
	}

	// Token: 0x0600B8BB RID: 47291 RVA: 0x00410518 File Offset: 0x0040E718
	protected override float f0(cnm A_0)
	{
		return 10f;
	}

	// Token: 0x0600B8BC RID: 47292 RVA: 0x00410520 File Offset: 0x0040E720
	protected override float cj(cnm A_0)
	{
		return 15f;
	}

	// Token: 0x0600B8BD RID: 47293 RVA: 0x00410528 File Offset: 0x0040E728
	protected override int d2(cnm A_0)
	{
		return ci5.g;
	}

	// Token: 0x0600B8BE RID: 47294 RVA: 0x00410530 File Offset: 0x0040E730
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
				typeof(fd)
			})
		};
	}

	// Token: 0x0600B8BF RID: 47295 RVA: 0x00410584 File Offset: 0x0040E784
	protected override PsiAbilityCategories cm(cnm A_0)
	{
		return PsiAbilityCategories.Damaging | PsiAbilityCategories.Telekinetic;
	}

	// Token: 0x0400433D RID: 17213
	public new static readonly string a = "Psi.TelekineticProxy";

	// Token: 0x0400433E RID: 17214
	private const double b = 10.0;

	// Token: 0x0400433F RID: 17215
	private const double c = 0.3;

	// Token: 0x04004340 RID: 17216
	private const double d = 0.5;

	// Token: 0x04004341 RID: 17217
	private new const int e = 5000;

	// Token: 0x04004342 RID: 17218
	public new static readonly int f = 3;

	// Token: 0x04004343 RID: 17219
	public new static readonly int g = 3;

	// Token: 0x04004344 RID: 17220
	private new List<string> h;
}

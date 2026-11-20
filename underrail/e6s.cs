using System;
using System.Collections.Generic;
using TimelapseVertigo.Rules.Capabilities;
using TimelapseVertigo.Rules.Capabilities.Psi;
using TimelapseVertigo.Rules.Combat;

// Token: 0x02001F1C RID: 7964
[ayj("EntropicRecurrence")]
public sealed class e6s : ce5
{
	// Token: 0x0600B7A6 RID: 47014 RVA: 0x0040E304 File Offset: 0x0040C504
	public override string y8()
	{
		return "Энтропийный повтор";
	}

	// Token: 0x0600B7A7 RID: 47015 RVA: 0x0040E30C File Offset: 0x0040C50C
	public override string os()
	{
		return "EntropicRecurrence";
	}

	// Token: 0x0600B7A8 RID: 47016 RVA: 0x0040E314 File Offset: 0x0040C514
	public override ci8 bg()
	{
		return ci8.c;
	}

	// Token: 0x0600B7A9 RID: 47017 RVA: 0x0040E318 File Offset: 0x0040C518
	public override PsiSchool ch()
	{
		return PsiSchool.TemporalManipulation;
	}

	// Token: 0x0600B7AA RID: 47018 RVA: 0x0040E31C File Offset: 0x0040C51C
	public override int ci()
	{
		return 4;
	}

	// Token: 0x0600B7AB RID: 47019 RVA: 0x0040E320 File Offset: 0x0040C520
	public e6s()
	{
		this.n = new List<string>
		{
			d7f.b,
			"EntropicRecurrence"
		};
	}

	// Token: 0x0600B7AC RID: 47020 RVA: 0x0040E354 File Offset: 0x0040C554
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
				typeof(p5)
			})
		};
	}

	// Token: 0x0600B7AD RID: 47021 RVA: 0x0040E3A8 File Offset: 0x0040C5A8
	public override SpellTargetType bn(cnm A_0)
	{
		return SpellTargetType.CreatureNotSelfWithLastDamage;
	}

	// Token: 0x0600B7AE RID: 47022 RVA: 0x0040E3AC File Offset: 0x0040C5AC
	public override IList<string> bi()
	{
		return this.n;
	}

	// Token: 0x0600B7AF RID: 47023 RVA: 0x0040E3B8 File Offset: 0x0040C5B8
	public override IList<cfd> bq(cnm A_0, v5 A_1)
	{
		List<cfd> list = new List<cfd>();
		if (A_1 == v5.b)
		{
			list.Add(new cfd(d7f.b, d7f.g, true, false));
		}
		int num = e6s.m;
		if (A_0 != null && A_0.b8() != null && A_0.b8().Feats.Contains<ank>())
		{
			num = Math.Max(0, num - ank.b);
		}
		if (num > 0)
		{
			list.Add(new cfd("EntropicRecurrence", num * d0u.b, false, false));
		}
		return list;
	}

	// Token: 0x0600B7B0 RID: 47024 RVA: 0x0040E444 File Offset: 0x0040C644
	public override string bo(cnm A_0)
	{
		double num = e6s.a(A_0);
		return qv.a("Psi/EntropicRecurrence", new object[]
		{
			(int)(num * 100.0),
			l4.a(e6s.l, false)
		});
	}

	// Token: 0x0600B7B1 RID: 47025 RVA: 0x0040E48C File Offset: 0x0040C68C
	public new static double a(cnm A_0)
	{
		if (A_0 != null && A_0.b8() != null)
		{
			p5 p = A_0.b8().Skills.Get<p5>();
			if (p != null)
			{
				double num = e6s.d;
				int num2 = Math.Max(0, Math.Min(e6s.f, p.g()));
				int num3 = Math.Max(0, Math.Min(e6s.h - e6s.f, p.g() - e6s.f));
				int num4 = Math.Max(0, Math.Min(e6s.j - e6s.h, p.g() - e6s.h));
				int num5 = Math.Max(0, p.g() - e6s.j);
				return num + ((double)num2 * e6s.e + (double)num3 * e6s.g + (double)num4 * e6s.i + (double)num5 * e6s.k);
			}
		}
		return e6s.d;
	}

	// Token: 0x0600B7B2 RID: 47026 RVA: 0x0040E564 File Offset: 0x0040C764
	protected override int hi(cnm A_0)
	{
		int num = 10;
		if (A_0 != null && A_0.b8() != null && A_0.b8().Feats.Contains<ank>())
		{
			num += ank.a(A_0);
		}
		return num;
	}

	// Token: 0x0600B7B3 RID: 47027 RVA: 0x0040E5A4 File Offset: 0x0040C7A4
	protected override float f0(cnm A_0)
	{
		return 7f;
	}

	// Token: 0x0600B7B4 RID: 47028 RVA: 0x0040E5AC File Offset: 0x0040C7AC
	protected override float cj(cnm A_0)
	{
		return 15f;
	}

	// Token: 0x0600B7B5 RID: 47029 RVA: 0x0040E5B4 File Offset: 0x0040C7B4
	protected override int br(cnm A_0)
	{
		return 1500;
	}

	// Token: 0x0600B7B6 RID: 47030 RVA: 0x0040E5BC File Offset: 0x0040C7BC
	protected override PsiAbilityCategories cm(cnm A_0)
	{
		return PsiAbilityCategories.Damaging;
	}

	// Token: 0x040042C6 RID: 17094
	private new const string a = "Entropic Recurrence";

	// Token: 0x040042C7 RID: 17095
	private const string b = "EntropicRecurrence";

	// Token: 0x040042C8 RID: 17096
	private const string c = "EntropicRecurrence";

	// Token: 0x040042C9 RID: 17097
	private static readonly double d = 0.4;

	// Token: 0x040042CA RID: 17098
	private new static readonly double e = 0.015;

	// Token: 0x040042CB RID: 17099
	private new static readonly int f = 50;

	// Token: 0x040042CC RID: 17100
	private new static readonly double g = 0.01;

	// Token: 0x040042CD RID: 17101
	private new static readonly int h = 100;

	// Token: 0x040042CE RID: 17102
	private new static readonly double i = 0.005;

	// Token: 0x040042CF RID: 17103
	private new static readonly int j = 150;

	// Token: 0x040042D0 RID: 17104
	private new static readonly double k = 0.0025;

	// Token: 0x040042D1 RID: 17105
	public new static readonly int l = 4;

	// Token: 0x040042D2 RID: 17106
	public new static readonly int m = 5;

	// Token: 0x040042D3 RID: 17107
	private new List<string> n;
}

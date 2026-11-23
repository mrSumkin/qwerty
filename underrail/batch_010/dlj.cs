using System;
using System.Collections.Generic;
using TimelapseVertigo.Rules.Capabilities;
using TimelapseVertigo.Rules.Capabilities.Psi;
using TimelapseVertigo.Rules.Combat;

// Token: 0x02001F17 RID: 7959
[ayj("Stasis")]
public sealed class dlj : ce5
{
	// Token: 0x0600B749 RID: 46921 RVA: 0x0040D5FC File Offset: 0x0040B7FC
	public override string y8()
	{
		return "Стазис";
	}

	// Token: 0x0600B74A RID: 46922 RVA: 0x0040D604 File Offset: 0x0040B804
	public override string os()
	{
		return "Stasis";
	}

	// Token: 0x0600B74B RID: 46923 RVA: 0x0040D60C File Offset: 0x0040B80C
	public override ci8 bg()
	{
		return ci8.a;
	}

	// Token: 0x0600B74C RID: 46924 RVA: 0x0040D610 File Offset: 0x0040B810
	public override PsiSchool ch()
	{
		return PsiSchool.TemporalManipulation;
	}

	// Token: 0x0600B74D RID: 46925 RVA: 0x0040D614 File Offset: 0x0040B814
	public override int ci()
	{
		return 8;
	}

	// Token: 0x0600B74E RID: 46926 RVA: 0x0040D618 File Offset: 0x0040B818
	public dlj()
	{
		this.g = new List<string>
		{
			"Stasis",
			"Stasis"
		};
	}

	// Token: 0x0600B74F RID: 46927 RVA: 0x0040D64C File Offset: 0x0040B84C
	public override List<brl> ck()
	{
		return new List<brl>
		{
			new b4k(new Type[]
			{
				typeof(c3v)
			}),
			new bap(70, new Type[]
			{
				typeof(p5)
			})
		};
	}

	// Token: 0x0600B750 RID: 46928 RVA: 0x0040D6A0 File Offset: 0x0040B8A0
	public override SpellTargetType bn(cnm A_0)
	{
		return SpellTargetType.Creature;
	}

	// Token: 0x0600B751 RID: 46929 RVA: 0x0040D6A4 File Offset: 0x0040B8A4
	public override IList<string> bi()
	{
		return this.g;
	}

	// Token: 0x0600B752 RID: 46930 RVA: 0x0040D6B0 File Offset: 0x0040B8B0
	public override IList<cfd> bq(cnm A_0, v5 A_1)
	{
		List<cfd> list = new List<cfd>();
		if (A_1 == v5.b)
		{
			list.Add(new cfd(d7f.b, d7f.g, true, false));
		}
		int num = dlj.d;
		if (A_0 != null && A_0.b8() != null && A_0.b8().Feats.Contains<ank>())
		{
			num = Math.Max(0, num - ank.b);
		}
		if (num > 0)
		{
			list.Add(new cfd("Stasis", num * d0u.b, false, false));
		}
		return list;
	}

	// Token: 0x0600B753 RID: 46931 RVA: 0x0040D73C File Offset: 0x0040B93C
	public override string bo(cnm A_0)
	{
		int? num;
		if (A_0 == null)
		{
			num = null;
		}
		else
		{
			efk efk = A_0.b8();
			num = ((efk != null) ? new int?(efk.Offense.ag()[PsiSchool.TemporalManipulation].b()) : null);
		}
		int? num2 = num;
		int num3 = num2.GetValueOrDefault(1) * dlj.f;
		return qv.a("Psi/Stasis", new object[]
		{
			l4.a(dlj.e, false),
			num3
		});
	}

	// Token: 0x0600B754 RID: 46932 RVA: 0x0040D7CC File Offset: 0x0040B9CC
	protected override int hi(cnm A_0)
	{
		int num = 15;
		if (A_0 != null && A_0.b8() != null && A_0.b8().Feats.Contains<ank>())
		{
			num += ank.a(A_0);
		}
		return num;
	}

	// Token: 0x0600B755 RID: 46933 RVA: 0x0040D80C File Offset: 0x0040BA0C
	protected override float f0(cnm A_0)
	{
		return 5f;
	}

	// Token: 0x0600B756 RID: 46934 RVA: 0x0040D814 File Offset: 0x0040BA14
	protected override float cj(cnm A_0)
	{
		return 40f;
	}

	// Token: 0x0600B757 RID: 46935 RVA: 0x0040D81C File Offset: 0x0040BA1C
	protected override int br(cnm A_0)
	{
		return 1500;
	}

	// Token: 0x0600B758 RID: 46936 RVA: 0x0040D824 File Offset: 0x0040BA24
	protected override PsiAbilityCategories cm(cnm A_0)
	{
		return PsiAbilityCategories.NonDamaging;
	}

	// Token: 0x04004296 RID: 17046
	private new const string a = "Stasis";

	// Token: 0x04004297 RID: 17047
	private const string b = "Stasis";

	// Token: 0x04004298 RID: 17048
	private const string c = "Stasis";

	// Token: 0x04004299 RID: 17049
	public static readonly int d = 10;

	// Token: 0x0400429A RID: 17050
	public new static readonly int e = 2;

	// Token: 0x0400429B RID: 17051
	public new static readonly int f = 10;

	// Token: 0x0400429C RID: 17052
	private new List<string> g;
}

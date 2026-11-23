using System;
using System.Collections.Generic;
using TimelapseVertigo.Rules.Capabilities;

// Token: 0x02001F06 RID: 7942
[ayj("Sprint")]
public sealed class bbc : c0z
{
	// Token: 0x0600B631 RID: 46641 RVA: 0x0040AAFC File Offset: 0x00408CFC
	public override string y8()
	{
		return "Спринт";
	}

	// Token: 0x0600B632 RID: 46642 RVA: 0x0040AB04 File Offset: 0x00408D04
	public override string os()
	{
		return "Sprint";
	}

	// Token: 0x0600B633 RID: 46643 RVA: 0x0040AB0C File Offset: 0x00408D0C
	public override ci8 bg()
	{
		return ci8.b;
	}

	// Token: 0x0600B634 RID: 46644 RVA: 0x0040AB10 File Offset: 0x00408D10
	public override int e8()
	{
		return 1;
	}

	// Token: 0x0600B635 RID: 46645 RVA: 0x0040AB14 File Offset: 0x00408D14
	public override bool hl()
	{
		return false;
	}

	// Token: 0x0600B636 RID: 46646 RVA: 0x0040AB18 File Offset: 0x00408D18
	public bbc()
	{
		this.g = new List<string>();
		this.g.Add("SA.Sprint");
	}

	// Token: 0x0600B637 RID: 46647 RVA: 0x0040AB3C File Offset: 0x00408D3C
	public override string bm(cnm A_0)
	{
		if (A_0 != null && A_0.b8() != null && A_0.b8().Feats.Contains<aaf>())
		{
			return "ImprovedSprint";
		}
		return "Sprint";
	}

	// Token: 0x0600B638 RID: 46648 RVA: 0x0040AB70 File Offset: 0x00408D70
	public override SpellTargetType bn(cnm A_0)
	{
		return SpellTargetType.Self;
	}

	// Token: 0x0600B639 RID: 46649 RVA: 0x0040AB74 File Offset: 0x00408D74
	public override string bo(cnm A_0)
	{
		if (A_0 != null && A_0.b8() != null && A_0.b8().Feats.Contains<aaf>())
		{
			return qv.a("SpecialAbilities/ImprovedSprint", new object[]
			{
				bbc.b(A_0),
				aaf.a,
				l4.a((double)bbc.f, false)
			});
		}
		return qv.a("SpecialAbilities/Sprint", new object[]
		{
			bbc.b(A_0),
			l4.a((double)bbc.f, false)
		});
	}

	// Token: 0x0600B63A RID: 46650 RVA: 0x0040AC10 File Offset: 0x00408E10
	public static int b(cnm A_0)
	{
		int num = bbc.e;
		if (A_0 != null && A_0.b8() != null)
		{
			num += A_0.b8().GetSpecializationValue<da0>(true) * da0.a;
		}
		return num;
	}

	// Token: 0x0600B63B RID: 46651 RVA: 0x0040AC4C File Offset: 0x00408E4C
	public override IList<cfd> bq(cnm A_0, v5 A_1)
	{
		int num = uf.a(bbc.d, A_0, new CooldownCategory[]
		{
			CooldownCategory.Sprint
		});
		List<cfd> list = new List<cfd>();
		if (num > 0)
		{
			list.Add(new cfd("SA.Sprint", num, false, false));
		}
		return list;
	}

	// Token: 0x0600B63C RID: 46652 RVA: 0x0040AC90 File Offset: 0x00408E90
	public override IList<string> bi()
	{
		return this.g;
	}

	// Token: 0x0600B63D RID: 46653 RVA: 0x0040AC98 File Offset: 0x00408E98
	public new static els a(cnm A_0)
	{
		if (A_0 != null && A_0.b8() != null && A_0.b8().Feats.Contains<aaf>())
		{
			return new dn9(0.5f, bbc.b(A_0))
			{
				Duration = bbc.f
			};
		}
		return new a7k(0.5f, bbc.b(A_0))
		{
			Duration = bbc.f
		};
	}

	// Token: 0x0600B63E RID: 46654 RVA: 0x0040AD04 File Offset: 0x00408F04
	public override dsk cv(cnm A_0)
	{
		return dsk.a;
	}

	// Token: 0x0600B63F RID: 46655 RVA: 0x0040AD0C File Offset: 0x00408F0C
	public override bool hm(cnm A_0)
	{
		return base.hm(A_0) && (A_0 == null || A_0.b8() == null || !A_0.b8().SpecialStates.g || A_0.b8().SpecialStates.b);
	}

	// Token: 0x0600B640 RID: 46656 RVA: 0x0040AD68 File Offset: 0x00408F68
	public override bool gz(cnm A_0)
	{
		return false;
	}

	// Token: 0x0600B641 RID: 46657 RVA: 0x0040AD6C File Offset: 0x00408F6C
	protected override int hi(cnm A_0)
	{
		return 0;
	}

	// Token: 0x0400423E RID: 16958
	private new const string a = "Sprint";

	// Token: 0x0400423F RID: 16959
	private const string b = "SA.Sprint";

	// Token: 0x04004240 RID: 16960
	private const float c = 0.5f;

	// Token: 0x04004241 RID: 16961
	public static readonly int d = 10 * d0u.b;

	// Token: 0x04004242 RID: 16962
	public new static readonly int e = 30;

	// Token: 0x04004243 RID: 16963
	public static readonly int f = 7000;

	// Token: 0x04004244 RID: 16964
	private new List<string> g;
}

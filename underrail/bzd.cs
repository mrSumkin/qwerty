using System;
using System.Collections.Generic;

// Token: 0x02001F0A RID: 7946
[ayj("PersonalCloaking")]
public sealed class bzd : cx6
{
	// Token: 0x0600B674 RID: 46708 RVA: 0x0040B2F4 File Offset: 0x004094F4
	public override string y8()
	{
		return "Personal Cloaking";
	}

	// Token: 0x0600B675 RID: 46709 RVA: 0x0040B2FC File Offset: 0x004094FC
	public override string os()
	{
		return "PersonalCloaking";
	}

	// Token: 0x0600B676 RID: 46710 RVA: 0x0040B304 File Offset: 0x00409504
	public override ci8 bg()
	{
		return ci8.b;
	}

	// Token: 0x0600B677 RID: 46711 RVA: 0x0040B308 File Offset: 0x00409508
	public override IList<string> bi()
	{
		return new List<string>
		{
			bzd.d
		};
	}

	// Token: 0x0600B678 RID: 46712 RVA: 0x0040B31C File Offset: 0x0040951C
	public override int bh()
	{
		return int.MinValue;
	}

	// Token: 0x0600B679 RID: 46713 RVA: 0x0040B324 File Offset: 0x00409524
	public override v5 c2()
	{
		return v5.b;
	}

	// Token: 0x0600B67A RID: 46714 RVA: 0x0040B328 File Offset: 0x00409528
	public override string bm(cnm A_0)
	{
		return "Abilities.0";
	}

	// Token: 0x0600B67B RID: 46715 RVA: 0x0040B334 File Offset: 0x00409534
	public override string bo(cnm A_0)
	{
		coh a_ = (A_0 != null) ? (A_0.b9() as coh) : null;
		return qv.a("Items\\Utilities/PersonalCloaking", new object[]
		{
			bzd.d(a_),
			bzd.c(a_),
			bzd.a(a_),
			bzd.b(a_),
			d0u.b / 1000
		});
	}

	// Token: 0x0600B67C RID: 46716 RVA: 0x0040B3B4 File Offset: 0x004095B4
	public override string bp(cnm A_0)
	{
		return this.bo(A_0);
	}

	// Token: 0x0600B67D RID: 46717 RVA: 0x0040B3C0 File Offset: 0x004095C0
	public override IList<cfd> bq(cnm A_0, v5 A_1)
	{
		return new List<cfd>
		{
			new cfd(bzd.d, 10000, false, false)
		};
	}

	// Token: 0x0600B67E RID: 46718 RVA: 0x0040B3E0 File Offset: 0x004095E0
	public override List<els> j8(cnm A_0)
	{
		coh coh = (A_0 != null) ? (A_0.b9() as coh) : null;
		return new List<els>
		{
			new efb(bzd.d(coh), bzd.c(coh), coh, bzd.b(coh))
		};
	}

	// Token: 0x0600B67F RID: 46719 RVA: 0x0040B428 File Offset: 0x00409628
	public static int d(coh A_0)
	{
		if (A_0 != null && A_0.Definition != null)
		{
			return A_0.Definition.a7().GetPrimitivePropertyValue<int>("StealthBonus", new int?(1)).Value;
		}
		return 1;
	}

	// Token: 0x0600B680 RID: 46720 RVA: 0x0040B46C File Offset: 0x0040966C
	public static int c(coh A_0)
	{
		if (A_0 != null && A_0.Definition != null)
		{
			return A_0.Definition.a7().GetPrimitivePropertyValue<int>("EvasionBonus", new int?(1)).Value;
		}
		return 1;
	}

	// Token: 0x0600B681 RID: 46721 RVA: 0x0040B4B0 File Offset: 0x004096B0
	public static double b(coh A_0)
	{
		if (A_0 != null && A_0.Definition != null)
		{
			return Math.Round(A_0.Definition.a7().GetPrimitivePropertyValue<double>("PowerPerTurnCost", new double?((double)1)).Value, 2);
		}
		return 1.0;
	}

	// Token: 0x0600B682 RID: 46722 RVA: 0x0040B504 File Offset: 0x00409704
	public static double a(coh A_0)
	{
		if (A_0 != null && A_0.Definition != null)
		{
			return Math.Round(A_0.Definition.a7().GetPrimitivePropertyValue<double>("PowerOnCost", new double?((double)1)).Value, 2);
		}
		return 5.0;
	}

	// Token: 0x0600B683 RID: 46723 RVA: 0x0040B558 File Offset: 0x00409758
	public override bool hm(cnm A_0)
	{
		if (!base.hm(A_0))
		{
			return false;
		}
		coh coh = (A_0 != null) ? (A_0.b9() as coh) : null;
		if (coh != null)
		{
			double num = bzd.a(coh);
			return coh.Battery >= num;
		}
		return false;
	}

	// Token: 0x0600B684 RID: 46724 RVA: 0x0040B5A8 File Offset: 0x004097A8
	public override bool cu(cnm A_0)
	{
		if (!base.cu(A_0))
		{
			return false;
		}
		coh coh = (A_0 != null) ? (A_0.b9() as coh) : null;
		if (coh != null)
		{
			double num = bzd.b(coh);
			return coh.Battery >= num;
		}
		return false;
	}

	// Token: 0x0600B685 RID: 46725 RVA: 0x0040B5F8 File Offset: 0x004097F8
	protected override int hi(cnm A_0)
	{
		return 0;
	}

	// Token: 0x0400424C RID: 16972
	private new const string a = "Personal Cloaking";

	// Token: 0x0400424D RID: 16973
	private const string b = "PersonalCloaking";

	// Token: 0x0400424E RID: 16974
	private const int c = 10000;

	// Token: 0x0400424F RID: 16975
	public static readonly string d = "personalCloaking";
}

using System;
using System.Collections.Generic;

// Token: 0x02001F09 RID: 7945
[ayj("Nightvision")]
public sealed class sk : cx6
{
	// Token: 0x0600B662 RID: 46690 RVA: 0x0040B084 File Offset: 0x00409284
	public override string y8()
	{
		return "Ночное видение";
	}

	// Token: 0x0600B663 RID: 46691 RVA: 0x0040B08C File Offset: 0x0040928C
	public override string os()
	{
		return "Nightvision";
	}

	// Token: 0x0600B664 RID: 46692 RVA: 0x0040B094 File Offset: 0x00409294
	public override ci8 bg()
	{
		return ci8.b;
	}

	// Token: 0x0600B665 RID: 46693 RVA: 0x0040B098 File Offset: 0x00409298
	public override IList<string> bi()
	{
		return new List<string>
		{
			sk.d
		};
	}

	// Token: 0x0600B666 RID: 46694 RVA: 0x0040B0AC File Offset: 0x004092AC
	public override int bh()
	{
		return int.MinValue;
	}

	// Token: 0x0600B667 RID: 46695 RVA: 0x0040B0B4 File Offset: 0x004092B4
	public override v5 c2()
	{
		return v5.b;
	}

	// Token: 0x0600B668 RID: 46696 RVA: 0x0040B0B8 File Offset: 0x004092B8
	public override string bm(cnm A_0)
	{
		return "Status.Nightvision";
	}

	// Token: 0x0600B669 RID: 46697 RVA: 0x0040B0C4 File Offset: 0x004092C4
	public override string bo(cnm A_0)
	{
		coh a_ = (A_0 != null) ? (A_0.b9() as coh) : null;
		return qv.a("Items\\Utilities/Nightvision", new object[]
		{
			sk.a(a_),
			sk.b(a_),
			d0u.b / 1000
		});
	}

	// Token: 0x0600B66A RID: 46698 RVA: 0x0040B128 File Offset: 0x00409328
	public override string bp(cnm A_0)
	{
		return this.bo(A_0);
	}

	// Token: 0x0600B66B RID: 46699 RVA: 0x0040B134 File Offset: 0x00409334
	public override IList<cfd> bq(cnm A_0, v5 A_1)
	{
		return new List<cfd>
		{
			new cfd(sk.d, 5000, false, false)
		};
	}

	// Token: 0x0600B66C RID: 46700 RVA: 0x0040B154 File Offset: 0x00409354
	public override List<els> j8(cnm A_0)
	{
		coh a_ = (A_0 != null) ? (A_0.b9() as coh) : null;
		return new List<els>
		{
			new ame(a_, sk.b(a_))
		};
	}

	// Token: 0x0600B66D RID: 46701 RVA: 0x0040B190 File Offset: 0x00409390
	public static double b(coh A_0)
	{
		if (A_0 != null && A_0.Definition != null)
		{
			return Math.Round(A_0.Definition.a7().GetPrimitivePropertyValue<double>("PowerPerTurnCost", new double?((double)1)).Value, 2);
		}
		return 1.0;
	}

	// Token: 0x0600B66E RID: 46702 RVA: 0x0040B1E4 File Offset: 0x004093E4
	public static double a(coh A_0)
	{
		if (A_0 != null && A_0.Definition != null)
		{
			return Math.Round(A_0.Definition.a7().GetPrimitivePropertyValue<double>("PowerOnCost", new double?(sk.b(A_0))).Value, 2);
		}
		return 5.0;
	}

	// Token: 0x0600B66F RID: 46703 RVA: 0x0040B23C File Offset: 0x0040943C
	public override bool hm(cnm A_0)
	{
		if (!base.hm(A_0))
		{
			return false;
		}
		coh coh = (A_0 != null) ? (A_0.b9() as coh) : null;
		if (coh != null)
		{
			double num = sk.a(coh);
			return coh.Battery >= num;
		}
		return false;
	}

	// Token: 0x0600B670 RID: 46704 RVA: 0x0040B28C File Offset: 0x0040948C
	public override bool cu(cnm A_0)
	{
		if (!base.cu(A_0))
		{
			return false;
		}
		coh coh = (A_0 != null) ? (A_0.b9() as coh) : null;
		if (coh != null)
		{
			double num = sk.b(coh);
			return coh.Battery >= num;
		}
		return false;
	}

	// Token: 0x0600B671 RID: 46705 RVA: 0x0040B2DC File Offset: 0x004094DC
	protected override int hi(cnm A_0)
	{
		return 0;
	}

	// Token: 0x04004248 RID: 16968
	private new const string a = "Night Vision";

	// Token: 0x04004249 RID: 16969
	private const string b = "Nightvision";

	// Token: 0x0400424A RID: 16970
	private const int c = 5000;

	// Token: 0x0400424B RID: 16971
	public static readonly string d = "nightvision";
}

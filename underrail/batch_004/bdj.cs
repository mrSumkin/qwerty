using System;
using System.Collections.Generic;
using TimelapseVertigo.Rules.Capabilities;

// Token: 0x02001E83 RID: 7811
[ayj("SHRC")]
public sealed class bdj : m0
{
	// Token: 0x0600AE86 RID: 44678 RVA: 0x003FC348 File Offset: 0x003FA548
	public override string y8()
	{
		return "Зарядник щита";
	}

	// Token: 0x0600AE87 RID: 44679 RVA: 0x003FC350 File Offset: 0x003FA550
	public override string c1()
	{
		return "Заряжает";
	}

	// Token: 0x0600AE88 RID: 44680 RVA: 0x003FC358 File Offset: 0x003FA558
	public override string os()
	{
		return "SHRC";
	}

	// Token: 0x0600AE89 RID: 44681 RVA: 0x003FC360 File Offset: 0x003FA560
	public override ci8 bg()
	{
		return ci8.b;
	}

	// Token: 0x0600AE8A RID: 44682 RVA: 0x003FC364 File Offset: 0x003FA564
	public bdj()
	{
		this.e = new List<string>();
		this.e.Add("shieldRecharger");
	}

	// Token: 0x0600AE8B RID: 44683 RVA: 0x003FC388 File Offset: 0x003FA588
	public override string bm(cnm A_0)
	{
		return null;
	}

	// Token: 0x0600AE8C RID: 44684 RVA: 0x003FC38C File Offset: 0x003FA58C
	public override SpellTargetType bn(cnm A_0)
	{
		return SpellTargetType.Creature;
	}

	// Token: 0x0600AE8D RID: 44685 RVA: 0x003FC390 File Offset: 0x003FA590
	public override string bo(cnm A_0)
	{
		return string.Empty;
	}

	// Token: 0x0600AE8E RID: 44686 RVA: 0x003FC39C File Offset: 0x003FA59C
	public override string bp(cnm A_0)
	{
		int num = base.s(A_0);
		int num2 = bdj.b(A_0);
		int num3 = (int)((double)num2 * bdj.c(A_0));
		double num4 = Math.Round((double)num2 * base.q(A_0), 2);
		return qv.a("Items\\Utilities/ShieldRecharger", new object[]
		{
			num3,
			Math.Round((double)num / 1000.0, 2),
			num4
		});
	}

	// Token: 0x0600AE8F RID: 44687 RVA: 0x003FC410 File Offset: 0x003FA610
	public override IList<cfd> bq(cnm A_0, v5 A_1)
	{
		return new List<cfd>
		{
			new cfd("shieldRecharger", 60000, false, false)
		};
	}

	// Token: 0x0600AE90 RID: 44688 RVA: 0x003FC430 File Offset: 0x003FA630
	public override IList<string> bi()
	{
		return this.e;
	}

	// Token: 0x0600AE91 RID: 44689 RVA: 0x003FC438 File Offset: 0x003FA638
	public override dsk cv(cnm A_0)
	{
		return dsk.a;
	}

	// Token: 0x0600AE92 RID: 44690 RVA: 0x003FC43C File Offset: 0x003FA63C
	public static double c(cnm A_0)
	{
		coh coh = ehl.a(A_0);
		double result = 1.0;
		if (coh != null && coh.CustomProperties != null)
		{
			result = coh.CustomProperties.GetPrimitivePropertyValue<double>(vo.b, new double?((double)1)).Value;
		}
		return result;
	}

	// Token: 0x0600AE93 RID: 44691 RVA: 0x003FC48C File Offset: 0x003FA68C
	public static int b(cnm A_0)
	{
		coh coh = ehl.a(A_0);
		int result = 10;
		if (coh != null && coh.CustomProperties != null)
		{
			result = coh.CustomProperties.GetPrimitivePropertyValue<int>(vo.a, new int?(10)).Value;
		}
		return result;
	}

	// Token: 0x0600AE94 RID: 44692 RVA: 0x003FC4D8 File Offset: 0x003FA6D8
	public new static int a(cnm A_0)
	{
		coh coh = ehl.a(A_0);
		int result = 500;
		if (coh != null && coh.CustomProperties != null)
		{
			result = coh.CustomProperties.GetPrimitivePropertyValue<int>(vo.c, new int?(500)).Value;
		}
		return result;
	}

	// Token: 0x0600AE95 RID: 44693 RVA: 0x003FC528 File Offset: 0x003FA728
	protected override float f0(cnm A_0)
	{
		return 5f;
	}

	// Token: 0x0600AE96 RID: 44694 RVA: 0x003FC530 File Offset: 0x003FA730
	protected override int ma(cnm A_0)
	{
		return bdj.b(A_0) * this.mb(A_0);
	}

	// Token: 0x0600AE97 RID: 44695 RVA: 0x003FC540 File Offset: 0x003FA740
	protected override int mb(cnm A_0)
	{
		return bdj.a(A_0);
	}

	// Token: 0x0600AE98 RID: 44696 RVA: 0x003FC54C File Offset: 0x003FA74C
	protected override double xe(cnm A_0)
	{
		coh coh = ehl.a(A_0);
		double result = 0.0;
		if (coh != null && coh.CustomProperties != null)
		{
			result = coh.CustomProperties.GetPrimitivePropertyValue<double>(vo.d, new double?(0.0)).Value;
		}
		return result;
	}

	// Token: 0x0400407D RID: 16509
	private new const string a = "shieldRecharger";

	// Token: 0x0400407E RID: 16510
	private const int b = 500;

	// Token: 0x0400407F RID: 16511
	private const int c = 1;

	// Token: 0x04004080 RID: 16512
	private const int d = 10;

	// Token: 0x04004081 RID: 16513
	private new List<string> e;
}

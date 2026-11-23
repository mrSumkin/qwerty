using System;
using System.Collections.Generic;

// Token: 0x02001CDD RID: 7389
[d29("BulletTrance", "Bullet Trance")]
public sealed class ap6 : ai8
{
	// Token: 0x0600A236 RID: 41526 RVA: 0x003E8B90 File Offset: 0x003E6D90
	public override bool ap()
	{
		return false;
	}

	// Token: 0x0600A237 RID: 41527 RVA: 0x003E8B94 File Offset: 0x003E6D94
	public override string au()
	{
		return "xphw";
	}

	// Token: 0x0600A238 RID: 41528 RVA: 0x003E8B9C File Offset: 0x003E6D9C
	public ap6() : base("胫Пулевой транс")
	{
	}

	// Token: 0x0600A239 RID: 41529 RVA: 0x003E8BAC File Offset: 0x003E6DAC
	public override object[] at()
	{
		return new object[]
		{
			Convert.ToInt32(ap6.b * 100.0),
			l4.a(ap6.c, false),
			ap6.a
		};
	}

	// Token: 0x0600A23A RID: 41530 RVA: 0x003E8BEC File Offset: 0x003E6DEC
	public static double c(efk A_0)
	{
		double num = ap6.b;
		if (A_0 != null)
		{
			num = Math.Round(num + (double)A_0.GetSpecializationValue<dod>(true) * dod.a, 2);
		}
		return num;
	}

	// Token: 0x0600A23B RID: 41531 RVA: 0x003E8C20 File Offset: 0x003E6E20
	public static int b(efk A_0)
	{
		int num = ap6.c;
		if (A_0 != null)
		{
			num = (int)((double)num + (double)A_0.GetSpecializationValue<dlu>(true) * dlu.a);
		}
		return num * d0u.b;
	}

	// Token: 0x0600A23C RID: 41532 RVA: 0x003E8C54 File Offset: 0x003E6E54
	public static int a(efk A_0)
	{
		int num = ap6.a;
		if (A_0 != null)
		{
			num += A_0.GetSpecializationValue<ej8>(true);
		}
		return num;
	}

	// Token: 0x0600A23D RID: 41533 RVA: 0x003E8C78 File Offset: 0x003E6E78
	public override List<brl> j0()
	{
		return new List<brl>
		{
			new awr(typeof(axr), 5),
			new bap(50, new Type[]
			{
				typeof(e8k)
			})
		};
	}

	// Token: 0x04003E2B RID: 15915
	public new static readonly int a = 5;

	// Token: 0x04003E2C RID: 15916
	public new static readonly double b = 0.05;

	// Token: 0x04003E2D RID: 15917
	public static readonly int c = 2;
}

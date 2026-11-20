using System;
using System.Collections.Generic;

// Token: 0x02001CDC RID: 7388
[d29("HeavyMetal", "Heavy Metal")]
public sealed class cvk : ai8
{
	// Token: 0x0600A22D RID: 41517 RVA: 0x003E89F8 File Offset: 0x003E6BF8
	public override bool ap()
	{
		return false;
	}

	// Token: 0x0600A22E RID: 41518 RVA: 0x003E89FC File Offset: 0x003E6BFC
	public override string au()
	{
		return "xphw";
	}

	// Token: 0x0600A22F RID: 41519 RVA: 0x003E8A04 File Offset: 0x003E6C04
	public cvk() : base("肤Тяжёлый металл")
	{
	}

	// Token: 0x0600A230 RID: 41520 RVA: 0x003E8A14 File Offset: 0x003E6C14
	public override object[] at()
	{
		return new object[]
		{
			Convert.ToInt32(cvk.a * 100.0),
			Convert.ToInt32(cvk.b * 100.0)
		};
	}

	// Token: 0x0600A231 RID: 41521 RVA: 0x003E8A58 File Offset: 0x003E6C58
	public override List<brl> j0()
	{
		return new List<brl>
		{
			new awr(typeof(d3m), 10),
			new bap(60, new Type[]
			{
				typeof(e8k)
			})
		};
	}

	// Token: 0x0600A232 RID: 41522 RVA: 0x003E8AA4 File Offset: 0x003E6CA4
	public override List<d3e> cy(efk A_0)
	{
		return new List<d3e>
		{
			new mc()
		};
	}

	// Token: 0x0600A233 RID: 41523 RVA: 0x003E8ABC File Offset: 0x003E6CBC
	public static double b(efk A_0)
	{
		if (A_0 != null)
		{
			double num = A_0.Defense.aj() * (cvk.a + c6j.a * (double)A_0.GetSpecializationValue<c6j>(true));
			if (A_0.Offense.u().TypedDefinition.e() == btz.l)
			{
				num *= 0.5;
			}
			return num;
		}
		return 0.0;
	}

	// Token: 0x0600A234 RID: 41524 RVA: 0x003E8B24 File Offset: 0x003E6D24
	public static double a(efk A_0)
	{
		if (A_0 != null)
		{
			return (double)A_0.Offense.u().TypedDefinition.i() * (0.01 + das.a * (double)A_0.GetSpecializationValue<das>(true));
		}
		return 0.0;
	}

	// Token: 0x04003E29 RID: 15913
	public new static readonly double a = 0.5;

	// Token: 0x04003E2A RID: 15914
	public new static readonly double b = 0.5;
}

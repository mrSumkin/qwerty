using System;
using System.Collections.Generic;

// Token: 0x02001CDE RID: 7390
[d29("DemolitionMan", "Demolition Man")]
public sealed class d3h : ai8
{
	// Token: 0x0600A23F RID: 41535 RVA: 0x003E8CE0 File Offset: 0x003E6EE0
	public override bool ap()
	{
		return false;
	}

	// Token: 0x0600A240 RID: 41536 RVA: 0x003E8CE4 File Offset: 0x003E6EE4
	public override string au()
	{
		return "xphw";
	}

	// Token: 0x0600A241 RID: 41537 RVA: 0x003E8CEC File Offset: 0x003E6EEC
	public d3h() : base("胬Взрыв разрушений")
	{
	}

	// Token: 0x0600A242 RID: 41538 RVA: 0x003E8CFC File Offset: 0x003E6EFC
	public override object[] at()
	{
		return new object[]
		{
			Convert.ToInt32(d3h.a * 100.0),
			l4.a(d3h.c, false),
			d3h.b
		};
	}

	// Token: 0x0600A243 RID: 41539 RVA: 0x003E8D3C File Offset: 0x003E6F3C
	public override List<brl> j0()
	{
		return new List<brl>
		{
			new awr(typeof(axa), 5),
			new bap(100, new Type[]
			{
				typeof(ct7),
				typeof(e8k)
			})
		};
	}

	// Token: 0x0600A244 RID: 41540 RVA: 0x003E8D94 File Offset: 0x003E6F94
	public static double c(efk A_0)
	{
		double num = d3h.a;
		if (A_0 != null)
		{
			num = Math.Round(num + (double)A_0.GetSpecializationValue<ow>(true) * ow.a, 4);
		}
		return num;
	}

	// Token: 0x0600A245 RID: 41541 RVA: 0x003E8DC8 File Offset: 0x003E6FC8
	public static int b(efk A_0)
	{
		double num = (double)d3h.c;
		if (A_0 != null)
		{
			num += (double)A_0.GetSpecializationValue<xf>(true) * xf.a;
		}
		return (int)num * d0u.b;
	}

	// Token: 0x0600A246 RID: 41542 RVA: 0x003E8DFC File Offset: 0x003E6FFC
	public static int a(efk A_0)
	{
		int num = d3h.b;
		if (A_0 != null)
		{
			num += A_0.GetSpecializationValue<aj2>(true);
		}
		return num;
	}

	// Token: 0x04003E2E RID: 15918
	public new static readonly double a = 0.05;

	// Token: 0x04003E2F RID: 15919
	public new static readonly int b = 5;

	// Token: 0x04003E30 RID: 15920
	public static readonly int c = 3;
}

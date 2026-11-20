using System;
using System.Collections.Generic;

// Token: 0x02001CB4 RID: 7348
[d29("Versatility", "Versatility")]
public sealed class a3p : ai8
{
	// Token: 0x0600A10D RID: 41229 RVA: 0x003E6E40 File Offset: 0x003E5040
	public a3p() : base("肂Универсальность")
	{
	}

	// Token: 0x0600A10E RID: 41230 RVA: 0x003E6E50 File Offset: 0x003E5050
	public override void ar(efk A_0)
	{
	}

	// Token: 0x0600A10F RID: 41231 RVA: 0x003E6E54 File Offset: 0x003E5054
	public override void @as(efk A_0)
	{
	}

	// Token: 0x0600A110 RID: 41232 RVA: 0x003E6E58 File Offset: 0x003E5058
	public override object[] at()
	{
		return new object[]
		{
			(int)(a3p.a * 100.0)
		};
	}

	// Token: 0x0600A111 RID: 41233 RVA: 0x003E6E78 File Offset: 0x003E5078
	public override List<brl> j0()
	{
		return new List<brl>
		{
			new awr(typeof(av8), 5)
		};
	}

	// Token: 0x0600A112 RID: 41234 RVA: 0x003E6E98 File Offset: 0x003E5098
	public override List<d3e> cy(efk A_0)
	{
		return new List<d3e>
		{
			new dtp()
		};
	}

	// Token: 0x0600A113 RID: 41235 RVA: 0x003E6EAC File Offset: 0x003E50AC
	protected override string nq()
	{
		if (dk2.e())
		{
			return "XPHW";
		}
		return null;
	}

	// Token: 0x04003DF9 RID: 15865
	public new static readonly double a = 0.6;
}

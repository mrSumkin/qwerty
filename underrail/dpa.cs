using System;
using System.Collections.Generic;

// Token: 0x02001CC3 RID: 7363
[d29("Philosophy1", "Philosophy")]
public sealed class dpa : ai8
{
	// Token: 0x0600A17F RID: 41343 RVA: 0x003E78C0 File Offset: 0x003E5AC0
	public override string au()
	{
		return "xpbl";
	}

	// Token: 0x0600A180 RID: 41344 RVA: 0x003E78C8 File Offset: 0x003E5AC8
	public override bool aq()
	{
		return false;
	}

	// Token: 0x0600A181 RID: 41345 RVA: 0x003E78CC File Offset: 0x003E5ACC
	public override bool ap()
	{
		return false;
	}

	// Token: 0x0600A182 RID: 41346 RVA: 0x003E78D0 File Offset: 0x003E5AD0
	public dpa() : base("Философия")
	{
	}

	// Token: 0x0600A183 RID: 41347 RVA: 0x003E78E0 File Offset: 0x003E5AE0
	public override void ar(efk A_0)
	{
	}

	// Token: 0x0600A184 RID: 41348 RVA: 0x003E78E4 File Offset: 0x003E5AE4
	public override void @as(efk A_0)
	{
	}

	// Token: 0x0600A185 RID: 41349 RVA: 0x003E78E8 File Offset: 0x003E5AE8
	public override object[] at()
	{
		return new object[]
		{
			dpa.a,
			dpa.b
		};
	}

	// Token: 0x0600A186 RID: 41350 RVA: 0x003E790C File Offset: 0x003E5B0C
	public override List<d3e> cy(efk A_0)
	{
		return new List<d3e>
		{
			new ciw(dpa.a),
			new d72(dpa.b)
		};
	}

	// Token: 0x0600A187 RID: 41351 RVA: 0x003E7934 File Offset: 0x003E5B34
	public override List<brl> j0()
	{
		return new List<brl>();
	}

	// Token: 0x04003E11 RID: 15889
	public new static readonly int a = 15;

	// Token: 0x04003E12 RID: 15890
	public new static readonly int b = 5;
}

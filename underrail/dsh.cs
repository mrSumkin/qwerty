using System;
using System.Collections.Generic;

// Token: 0x02001CC2 RID: 7362
[d29("Philosophy2", "Philosophy II")]
public sealed class dsh : ai8
{
	// Token: 0x0600A176 RID: 41334 RVA: 0x003E783C File Offset: 0x003E5A3C
	public override string au()
	{
		return "xpbl";
	}

	// Token: 0x0600A177 RID: 41335 RVA: 0x003E7844 File Offset: 0x003E5A44
	public override bool aq()
	{
		return false;
	}

	// Token: 0x0600A178 RID: 41336 RVA: 0x003E7848 File Offset: 0x003E5A48
	public override bool ap()
	{
		return false;
	}

	// Token: 0x0600A179 RID: 41337 RVA: 0x003E784C File Offset: 0x003E5A4C
	public dsh() : base("Философия II")
	{
	}

	// Token: 0x0600A17A RID: 41338 RVA: 0x003E785C File Offset: 0x003E5A5C
	public override void ar(efk A_0)
	{
	}

	// Token: 0x0600A17B RID: 41339 RVA: 0x003E7860 File Offset: 0x003E5A60
	public override void @as(efk A_0)
	{
	}

	// Token: 0x0600A17C RID: 41340 RVA: 0x003E7864 File Offset: 0x003E5A64
	public override object[] at()
	{
		return new object[]
		{
			dpa.a * 2,
			dpa.b * 2
		};
	}

	// Token: 0x0600A17D RID: 41341 RVA: 0x003E788C File Offset: 0x003E5A8C
	public override List<d3e> cy(efk A_0)
	{
		return new List<d3e>
		{
			new ciw(dpa.a * 2),
			new d72(dpa.b * 2)
		};
	}

	// Token: 0x0600A17E RID: 41342 RVA: 0x003E78B8 File Offset: 0x003E5AB8
	public override List<brl> j0()
	{
		return new List<brl>();
	}
}

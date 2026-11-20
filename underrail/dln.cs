using System;
using System.Collections.Generic;

// Token: 0x02001CC1 RID: 7361
[d29("Philosophy3", "Philosophy III")]
public sealed class dln : ai8
{
	// Token: 0x0600A16D RID: 41325 RVA: 0x003E77B8 File Offset: 0x003E59B8
	public override string au()
	{
		return "xpbl";
	}

	// Token: 0x0600A16E RID: 41326 RVA: 0x003E77C0 File Offset: 0x003E59C0
	public override bool aq()
	{
		return false;
	}

	// Token: 0x0600A16F RID: 41327 RVA: 0x003E77C4 File Offset: 0x003E59C4
	public override bool ap()
	{
		return false;
	}

	// Token: 0x0600A170 RID: 41328 RVA: 0x003E77C8 File Offset: 0x003E59C8
	public dln() : base("Философия III")
	{
	}

	// Token: 0x0600A171 RID: 41329 RVA: 0x003E77D8 File Offset: 0x003E59D8
	public override void ar(efk A_0)
	{
	}

	// Token: 0x0600A172 RID: 41330 RVA: 0x003E77DC File Offset: 0x003E59DC
	public override void @as(efk A_0)
	{
	}

	// Token: 0x0600A173 RID: 41331 RVA: 0x003E77E0 File Offset: 0x003E59E0
	public override object[] at()
	{
		return new object[]
		{
			dpa.a * 3,
			dpa.b * 3
		};
	}

	// Token: 0x0600A174 RID: 41332 RVA: 0x003E7808 File Offset: 0x003E5A08
	public override List<d3e> cy(efk A_0)
	{
		return new List<d3e>
		{
			new ciw(dpa.a * 3),
			new d72(dpa.b * 3)
		};
	}

	// Token: 0x0600A175 RID: 41333 RVA: 0x003E7834 File Offset: 0x003E5A34
	public override List<brl> j0()
	{
		return new List<brl>();
	}
}

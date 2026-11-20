using System;
using System.Collections.Generic;

// Token: 0x02001CB3 RID: 7347
[d29("BarrelStare", "Barrel Stare")]
public sealed class afn : ai8
{
	// Token: 0x0600A105 RID: 41221 RVA: 0x003E6DB4 File Offset: 0x003E4FB4
	public override string au()
	{
		return "xpbl";
	}

	// Token: 0x0600A106 RID: 41222 RVA: 0x003E6DBC File Offset: 0x003E4FBC
	public override bool ap()
	{
		return false;
	}

	// Token: 0x0600A107 RID: 41223 RVA: 0x003E6DC0 File Offset: 0x003E4FC0
	public afn() : base("膒Прицеливание по стволу")
	{
	}

	// Token: 0x0600A108 RID: 41224 RVA: 0x003E6DD0 File Offset: 0x003E4FD0
	public override void ar(efk A_0)
	{
	}

	// Token: 0x0600A109 RID: 41225 RVA: 0x003E6DD4 File Offset: 0x003E4FD4
	public override void @as(efk A_0)
	{
	}

	// Token: 0x0600A10A RID: 41226 RVA: 0x003E6DD8 File Offset: 0x003E4FD8
	public override object[] at()
	{
		return new object[]
		{
			(int)(afn.a * 100.0)
		};
	}

	// Token: 0x0600A10B RID: 41227 RVA: 0x003E6DFC File Offset: 0x003E4FFC
	public override List<brl> j0()
	{
		return new List<brl>
		{
			new bap(50, new Type[]
			{
				typeof(ct7)
			})
		};
	}

	// Token: 0x04003DF8 RID: 15864
	public new static readonly double a = 0.2;
}

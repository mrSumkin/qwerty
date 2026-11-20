using System;
using System.Collections.Generic;

// Token: 0x02001CC4 RID: 7364
[d29("PelletMayhem", "Pellet Mayhem")]
public sealed class etq : ai8
{
	// Token: 0x0600A189 RID: 41353 RVA: 0x003E794C File Offset: 0x003E5B4C
	public override string au()
	{
		return "xpbl";
	}

	// Token: 0x0600A18A RID: 41354 RVA: 0x003E7954 File Offset: 0x003E5B54
	public override bool ap()
	{
		return false;
	}

	// Token: 0x0600A18B RID: 41355 RVA: 0x003E7958 File Offset: 0x003E5B58
	public etq() : base("膑Семя раздора")
	{
	}

	// Token: 0x0600A18C RID: 41356 RVA: 0x003E7968 File Offset: 0x003E5B68
	public override void ar(efk A_0)
	{
	}

	// Token: 0x0600A18D RID: 41357 RVA: 0x003E796C File Offset: 0x003E5B6C
	public override void @as(efk A_0)
	{
	}

	// Token: 0x0600A18E RID: 41358 RVA: 0x003E7970 File Offset: 0x003E5B70
	public override object[] at()
	{
		return new object[]
		{
			(int)(etq.a * 100.0)
		};
	}

	// Token: 0x0600A18F RID: 41359 RVA: 0x003E7994 File Offset: 0x003E5B94
	public override List<brl> j0()
	{
		return new List<brl>
		{
			new bap(40, new Type[]
			{
				typeof(ct7)
			})
		};
	}

	// Token: 0x04003E13 RID: 15891
	public new static readonly double a = 0.03;
}

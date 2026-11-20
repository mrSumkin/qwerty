using System;
using System.Collections.Generic;

// Token: 0x02001CDB RID: 7387
[d29("BruteAim", "Brute Aim")]
public sealed class biv : ai8
{
	// Token: 0x0600A227 RID: 41511 RVA: 0x003E8970 File Offset: 0x003E6B70
	public override bool ap()
	{
		return false;
	}

	// Token: 0x0600A228 RID: 41512 RVA: 0x003E8974 File Offset: 0x003E6B74
	public override string au()
	{
		return "xphw";
	}

	// Token: 0x0600A229 RID: 41513 RVA: 0x003E897C File Offset: 0x003E6B7C
	public biv() : base("胫Брутальная стрельба")
	{
	}

	// Token: 0x0600A22A RID: 41514 RVA: 0x003E898C File Offset: 0x003E6B8C
	public override object[] at()
	{
		return new object[]
		{
			biv.a
		};
	}

	// Token: 0x0600A22B RID: 41515 RVA: 0x003E89A4 File Offset: 0x003E6BA4
	public override List<brl> j0()
	{
		return new List<brl>
		{
			new awr(typeof(d3m), 11),
			new bap(30, new Type[]
			{
				typeof(e8k)
			})
		};
	}

	// Token: 0x04003E28 RID: 15912
	public new static readonly int a = 3;
}

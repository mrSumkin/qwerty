using System;
using System.Collections.Generic;

// Token: 0x02001CCA RID: 7370
[d29("Onslaught", "Onslaught")]
public sealed class e8 : ai8
{
	// Token: 0x0600A1B6 RID: 41398 RVA: 0x003E7D5C File Offset: 0x003E5F5C
	public e8() : base("膨Натиск")
	{
	}

	// Token: 0x0600A1B7 RID: 41399 RVA: 0x003E7D6C File Offset: 0x003E5F6C
	public override string au()
	{
		return "xpbl";
	}

	// Token: 0x0600A1B8 RID: 41400 RVA: 0x003E7D74 File Offset: 0x003E5F74
	public override bool ap()
	{
		return false;
	}

	// Token: 0x0600A1B9 RID: 41401 RVA: 0x003E7D78 File Offset: 0x003E5F78
	public override object[] at()
	{
		return new object[]
		{
			(int)(dqq.b * 100.0),
			l4.a((double)dqq.c, false),
			dqq.a
		};
	}

	// Token: 0x0600A1BA RID: 41402 RVA: 0x003E7DB8 File Offset: 0x003E5FB8
	public override List<brl> j0()
	{
		return new List<brl>
		{
			new bap(75, new Type[]
			{
				typeof(jk)
			})
		};
	}
}

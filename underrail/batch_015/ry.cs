using System;
using System.Collections.Generic;

// Token: 0x02001C83 RID: 7299
[d29("DeadlySnares", "Deadly Snares")]
public sealed class ry : ai8
{
	// Token: 0x06009FF1 RID: 40945 RVA: 0x003E499C File Offset: 0x003E2B9C
	public override bool ap()
	{
		return false;
	}

	// Token: 0x06009FF2 RID: 40946 RVA: 0x003E49A0 File Offset: 0x003E2BA0
	public ry() : base("膉Смертоносные ловушки")
	{
	}

	// Token: 0x06009FF3 RID: 40947 RVA: 0x003E49B0 File Offset: 0x003E2BB0
	public override List<brl> j0()
	{
		return new List<brl>
		{
			new awr(typeof(eav), 10),
			new bap(75, new Type[]
			{
				typeof(e5n)
			}),
			new bap(50, new Type[]
			{
				typeof(c0b)
			})
		};
	}
}

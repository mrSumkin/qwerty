using System;
using System.Collections.Generic;

// Token: 0x02001C50 RID: 7248
public abstract class aw2 : ai8
{
	// Token: 0x06009F07 RID: 40711 RVA: 0x003E3164 File Offset: 0x003E1364
	public override bool sq()
	{
		return true;
	}

	// Token: 0x06009F08 RID: 40712 RVA: 0x003E3168 File Offset: 0x003E1368
	protected aw2(string A_0) : base(A_0)
	{
	}

	// Token: 0x06009F09 RID: 40713 RVA: 0x003E3174 File Offset: 0x003E1374
	public override List<brl> j0()
	{
		return new List<brl>
		{
			new azy(aiy.bk + 1)
		};
	}
}

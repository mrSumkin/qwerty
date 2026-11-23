using System;
using System.Collections.Generic;

// Token: 0x02001C26 RID: 7206
[d29("Commando", "Commando")]
public sealed class bt7 : ai8
{
	// Token: 0x06009E45 RID: 40517 RVA: 0x003E1B8C File Offset: 0x003DFD8C
	public bt7() : base("胨Коммандо")
	{
	}

	// Token: 0x06009E46 RID: 40518 RVA: 0x003E1B9C File Offset: 0x003DFD9C
	public override bool ap()
	{
		return false;
	}

	// Token: 0x06009E47 RID: 40519 RVA: 0x003E1BA0 File Offset: 0x003DFDA0
	public override void ar(efk A_0)
	{
	}

	// Token: 0x06009E48 RID: 40520 RVA: 0x003E1BA4 File Offset: 0x003DFDA4
	public override void @as(efk A_0)
	{
	}

	// Token: 0x06009E49 RID: 40521 RVA: 0x003E1BAC File Offset: 0x003DFDAC
	public override List<brl> j0()
	{
		return new List<brl>
		{
			new bap(80, new Type[]
			{
				typeof(ct7)
			})
		};
	}

	// Token: 0x04003D64 RID: 15716
	public new static readonly string a = "Commando";
}

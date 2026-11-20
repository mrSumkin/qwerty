using System;
using System.Collections.Generic;

// Token: 0x02001E05 RID: 7685
[d29("DS", "Marksman")]
public sealed class d95 : ai8
{
	// Token: 0x0600AA2C RID: 43564 RVA: 0x003F3620 File Offset: 0x003F1820
	public override bool ap()
	{
		return false;
	}

	// Token: 0x0600AA2D RID: 43565 RVA: 0x003F3624 File Offset: 0x003F1824
	public d95() : base("膅Стрелок")
	{
	}

	// Token: 0x0600AA2E RID: 43566 RVA: 0x003F3634 File Offset: 0x003F1834
	public override void ar(efk A_0)
	{
	}

	// Token: 0x0600AA2F RID: 43567 RVA: 0x003F3638 File Offset: 0x003F1838
	public override void @as(efk A_0)
	{
	}

	// Token: 0x0600AA30 RID: 43568 RVA: 0x003F3640 File Offset: 0x003F1840
	public override List<brl> j0()
	{
		List<brl> list = base.j0();
		if (list == null)
		{
			list = new List<brl>();
		}
		list.Add(new awr(typeof(cwu), 5));
		list.Add(new bap(15, new Type[]
		{
			typeof(e5n)
		}));
		return list;
	}
}

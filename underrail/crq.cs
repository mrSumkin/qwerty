using System;
using System.Collections.Generic;

// Token: 0x02001DF4 RID: 7668
[d29("FullAuto", "Full-Auto")]
public sealed class crq : ai8
{
	// Token: 0x0600A9BC RID: 43452 RVA: 0x003F25A0 File Offset: 0x003F07A0
	public override bool ap()
	{
		return false;
	}

	// Token: 0x0600A9BD RID: 43453 RVA: 0x003F25A4 File Offset: 0x003F07A4
	public crq() : base("胢Автоматический огонь")
	{
	}

	// Token: 0x0600A9BE RID: 43454 RVA: 0x003F25B4 File Offset: 0x003F07B4
	public override void ar(efk A_0)
	{
	}

	// Token: 0x0600A9BF RID: 43455 RVA: 0x003F25B8 File Offset: 0x003F07B8
	public override void @as(efk A_0)
	{
	}

	// Token: 0x0600A9C0 RID: 43456 RVA: 0x003F25BC File Offset: 0x003F07BC
	public override List<brl> j0()
	{
		return new List<brl>
		{
			new awr(typeof(d3m), 7),
			new bap(40, new Type[]
			{
				typeof(ct7),
				typeof(e8k)
			})
		};
	}

	// Token: 0x0600A9C1 RID: 43457 RVA: 0x003F2614 File Offset: 0x003F0814
	protected override string nq()
	{
		string text = "";
		if (dk2.f())
		{
			text += "XPBL";
		}
		if (dk2.e())
		{
			text += "XPHW";
		}
		return text;
	}
}

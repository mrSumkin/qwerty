using System;
using System.Collections.Generic;

// Token: 0x02001C2A RID: 7210
[d29("Ballistics", "Ballistics")]
public sealed class e : ai8
{
	// Token: 0x06009E5F RID: 40543 RVA: 0x003E1DCC File Offset: 0x003DFFCC
	public override bool ap()
	{
		return false;
	}

	// Token: 0x06009E60 RID: 40544 RVA: 0x003E1DD0 File Offset: 0x003DFFD0
	public e() : base("肠Баллистика")
	{
	}

	// Token: 0x06009E61 RID: 40545 RVA: 0x003E1DE0 File Offset: 0x003DFFE0
	public override void ar(efk A_0)
	{
	}

	// Token: 0x06009E62 RID: 40546 RVA: 0x003E1DE4 File Offset: 0x003DFFE4
	public override void @as(efk A_0)
	{
	}

	// Token: 0x06009E63 RID: 40547 RVA: 0x003E1DE8 File Offset: 0x003DFFE8
	public override object[] at()
	{
		return new object[]
		{
			global::e.a
		};
	}

	// Token: 0x06009E64 RID: 40548 RVA: 0x003E1E00 File Offset: 0x003E0000
	public override List<brl> j0()
	{
		return new List<brl>
		{
			new awr(typeof(av8), 6),
			new bap(35, new Type[]
			{
				typeof(qr)
			})
		};
	}

	// Token: 0x04003D67 RID: 15719
	public new static readonly int a = 3;
}

using System;
using System.Collections.Generic;

// Token: 0x02001C7F RID: 7295
[d29("Weaponsmith", "Weaponsmith")]
public sealed class e8m : ai8
{
	// Token: 0x06009FD6 RID: 40918 RVA: 0x003E4738 File Offset: 0x003E2938
	public override bool ap()
	{
		return false;
	}

	// Token: 0x06009FD7 RID: 40919 RVA: 0x003E473C File Offset: 0x003E293C
	public e8m() : base("膰Кузнец")
	{
	}

	// Token: 0x06009FD8 RID: 40920 RVA: 0x003E474C File Offset: 0x003E294C
	public override void ar(efk A_0)
	{
	}

	// Token: 0x06009FD9 RID: 40921 RVA: 0x003E4750 File Offset: 0x003E2950
	public override void @as(efk A_0)
	{
	}

	// Token: 0x06009FDA RID: 40922 RVA: 0x003E4754 File Offset: 0x003E2954
	public override object[] at()
	{
		return new object[]
		{
			(int)(e8m.a * 100.0)
		};
	}

	// Token: 0x06009FDB RID: 40923 RVA: 0x003E4774 File Offset: 0x003E2974
	public override List<brl> j0()
	{
		return new List<brl>
		{
			new awr(typeof(av8), 6),
			new bap(25, new Type[]
			{
				typeof(eq1)
			})
		};
	}

	// Token: 0x04003DB8 RID: 15800
	public new static readonly double a = 0.05;
}

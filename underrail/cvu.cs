using System;
using System.Collections.Generic;

// Token: 0x02001C67 RID: 7271
[d29("Neurology", "Neurology")]
public sealed class cvu : ai8
{
	// Token: 0x06009F6F RID: 40815 RVA: 0x003E3BA0 File Offset: 0x003E1DA0
	public override bool ap()
	{
		return false;
	}

	// Token: 0x06009F70 RID: 40816 RVA: 0x003E3BA4 File Offset: 0x003E1DA4
	public cvu() : base("臐Нейрология")
	{
	}

	// Token: 0x06009F71 RID: 40817 RVA: 0x003E3BB4 File Offset: 0x003E1DB4
	public override void ar(efk A_0)
	{
	}

	// Token: 0x06009F72 RID: 40818 RVA: 0x003E3BB8 File Offset: 0x003E1DB8
	public override void @as(efk A_0)
	{
	}

	// Token: 0x06009F73 RID: 40819 RVA: 0x003E3BBC File Offset: 0x003E1DBC
	public override object[] at()
	{
		return new object[]
		{
			cvu.a
		};
	}

	// Token: 0x06009F74 RID: 40820 RVA: 0x003E3BD4 File Offset: 0x003E1DD4
	public override List<brl> j0()
	{
		return new List<brl>
		{
			new awr(typeof(av8), 7),
			new bap(35, new Type[]
			{
				typeof(b6s)
			})
		};
	}

	// Token: 0x04003DA1 RID: 15777
	public new static readonly int a = 15;
}

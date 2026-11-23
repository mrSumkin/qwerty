using System;
using System.Collections.Generic;

// Token: 0x02001C68 RID: 7272
[d29("PracticalPhysicist", "Practical Physicist")]
public sealed class cnz : ai8
{
	// Token: 0x06009F76 RID: 40822 RVA: 0x003E3C2C File Offset: 0x003E1E2C
	public override bool ap()
	{
		return false;
	}

	// Token: 0x06009F77 RID: 40823 RVA: 0x003E3C30 File Offset: 0x003E1E30
	public cnz() : base("胱Физик-практик")
	{
	}

	// Token: 0x06009F78 RID: 40824 RVA: 0x003E3C40 File Offset: 0x003E1E40
	public override void ar(efk A_0)
	{
	}

	// Token: 0x06009F79 RID: 40825 RVA: 0x003E3C44 File Offset: 0x003E1E44
	public override void @as(efk A_0)
	{
	}

	// Token: 0x06009F7A RID: 40826 RVA: 0x003E3C48 File Offset: 0x003E1E48
	public override object[] at()
	{
		return new object[]
		{
			(int)(cnz.a * 100.0)
		};
	}

	// Token: 0x06009F7B RID: 40827 RVA: 0x003E3C6C File Offset: 0x003E1E6C
	public override List<brl> j0()
	{
		return new List<brl>
		{
			new awr(typeof(av8), 7),
			new bap(35, new Type[]
			{
				typeof(ij)
			})
		};
	}

	// Token: 0x04003DA2 RID: 15778
	public new static readonly double a = 0.25;
}

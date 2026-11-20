using System;
using System.Collections.Generic;

// Token: 0x02001C23 RID: 7203
[d29("MonstrousYell", "Monstrous Yell")]
public sealed class dcv : ai8
{
	// Token: 0x06009E32 RID: 40498 RVA: 0x003E1944 File Offset: 0x003DFB44
	public override bool aq()
	{
		return false;
	}

	// Token: 0x06009E33 RID: 40499 RVA: 0x003E1948 File Offset: 0x003DFB48
	public dcv() : base("Чудовищный вопль")
	{
	}

	// Token: 0x06009E34 RID: 40500 RVA: 0x003E1958 File Offset: 0x003DFB58
	public override void ar(efk A_0)
	{
	}

	// Token: 0x06009E35 RID: 40501 RVA: 0x003E195C File Offset: 0x003DFB5C
	public override void @as(efk A_0)
	{
	}

	// Token: 0x06009E36 RID: 40502 RVA: 0x003E1960 File Offset: 0x003DFB60
	public override object[] at()
	{
		return new object[]
		{
			Convert.ToInt32(dcv.a * 100.0),
			l4.a(dcv.b, false)
		};
	}

	// Token: 0x06009E37 RID: 40503 RVA: 0x003E1994 File Offset: 0x003DFB94
	public override List<brl> j0()
	{
		return new List<brl>
		{
			new b4k(new Type[]
			{
				typeof(er5)
			})
		};
	}

	// Token: 0x04003D5C RID: 15708
	public new static readonly double a = 0.3;

	// Token: 0x04003D5D RID: 15709
	public new static readonly int b = 1;
}

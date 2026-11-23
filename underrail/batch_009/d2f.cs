using System;
using System.Collections.Generic;

// Token: 0x02001C93 RID: 7315
[d29("FatalThrow", "Fatal Throw")]
public sealed class d2f : ai8
{
	// Token: 0x0600A051 RID: 41041 RVA: 0x003E55BC File Offset: 0x003E37BC
	public override bool ap()
	{
		return false;
	}

	// Token: 0x0600A052 RID: 41042 RVA: 0x003E55C0 File Offset: 0x003E37C0
	public d2f() : base("膠Смертельный бросок")
	{
	}

	// Token: 0x0600A053 RID: 41043 RVA: 0x003E55D0 File Offset: 0x003E37D0
	public override void ar(efk A_0)
	{
	}

	// Token: 0x0600A054 RID: 41044 RVA: 0x003E55D4 File Offset: 0x003E37D4
	public override void @as(efk A_0)
	{
	}

	// Token: 0x0600A055 RID: 41045 RVA: 0x003E55D8 File Offset: 0x003E37D8
	public override object[] at()
	{
		return new object[]
		{
			(int)(d2f.a * 100.0),
			d2f.b
		};
	}

	// Token: 0x0600A056 RID: 41046 RVA: 0x003E5608 File Offset: 0x003E3808
	public override List<brl> j0()
	{
		return new List<brl>
		{
			new awr(typeof(cwu), 8),
			new bap(50, new Type[]
			{
				typeof(dei)
			})
		};
	}

	// Token: 0x04003DCA RID: 15818
	public new static readonly double a = 0.25;

	// Token: 0x04003DCB RID: 15819
	public new static readonly int b = 18;

	// Token: 0x04003DCC RID: 15820
	public static readonly string c = "FatalThrow";

	// Token: 0x04003DCD RID: 15821
	public new static readonly int d = 1;
}

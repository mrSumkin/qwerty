using System;
using System.Collections.Generic;

// Token: 0x02001CD0 RID: 7376
[d29("Brutality", "Brutality")]
public sealed class avq : ai8
{
	// Token: 0x0600A1DD RID: 41437 RVA: 0x003E825C File Offset: 0x003E645C
	public override string au()
	{
		return "xpbl";
	}

	// Token: 0x0600A1DE RID: 41438 RVA: 0x003E8264 File Offset: 0x003E6464
	public avq() : base("膵Жестокость")
	{
	}

	// Token: 0x0600A1DF RID: 41439 RVA: 0x003E8274 File Offset: 0x003E6474
	public override void ar(efk A_0)
	{
	}

	// Token: 0x0600A1E0 RID: 41440 RVA: 0x003E8278 File Offset: 0x003E6478
	public override void @as(efk A_0)
	{
	}

	// Token: 0x0600A1E1 RID: 41441 RVA: 0x003E827C File Offset: 0x003E647C
	public override object[] at()
	{
		return new object[]
		{
			(int)(avq.a * 100.0),
			l4.a(avq.b, false)
		};
	}

	// Token: 0x0600A1E2 RID: 41442 RVA: 0x003E82AC File Offset: 0x003E64AC
	public override List<brl> j0()
	{
		return new List<brl>
		{
			new bap(75, new Type[]
			{
				typeof(bec)
			}),
			new bap(50, new Type[]
			{
				typeof(jk)
			})
		};
	}

	// Token: 0x04003E18 RID: 15896
	public new static readonly double a = 0.15;

	// Token: 0x04003E19 RID: 15897
	public new static readonly int b = 1;
}

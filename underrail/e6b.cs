using System;
using System.Collections.Generic;

// Token: 0x02001CE3 RID: 7395
[d29("MagDump", "Mag Dump")]
public sealed class e6b : ai8
{
	// Token: 0x0600A26B RID: 41579 RVA: 0x003E934C File Offset: 0x003E754C
	public override bool ap()
	{
		return false;
	}

	// Token: 0x0600A26C RID: 41580 RVA: 0x003E9350 File Offset: 0x003E7550
	public override string au()
	{
		return "xphw";
	}

	// Token: 0x0600A26D RID: 41581 RVA: 0x003E9358 File Offset: 0x003E7558
	public e6b() : base("胪Сброс патронажа")
	{
	}

	// Token: 0x0600A26E RID: 41582 RVA: 0x003E9368 File Offset: 0x003E7568
	public override object[] at()
	{
		return new object[]
		{
			e6b.a,
			e6b.b
		};
	}

	// Token: 0x0600A26F RID: 41583 RVA: 0x003E938C File Offset: 0x003E758C
	public override List<brl> j0()
	{
		return new List<brl>
		{
			new awr(typeof(d3m), 8),
			new bap(80, new Type[]
			{
				typeof(e8k)
			}),
			new b4k(new Type[]
			{
				typeof(crq)
			})
		};
	}

	// Token: 0x04003E3A RID: 15930
	public new static readonly int a = 2;

	// Token: 0x04003E3B RID: 15931
	public new static readonly double b = 0.5;
}

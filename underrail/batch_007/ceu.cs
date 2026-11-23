using System;
using System.Collections.Generic;

// Token: 0x02001C66 RID: 7270
[d29("ElementalBolts", "Elemental Bolts")]
public sealed class ceu : ai8
{
	// Token: 0x06009F69 RID: 40809 RVA: 0x003E3B14 File Offset: 0x003E1D14
	public override bool ap()
	{
		return false;
	}

	// Token: 0x06009F6A RID: 40810 RVA: 0x003E3B18 File Offset: 0x003E1D18
	public ceu() : base("膈Элементальные болты")
	{
	}

	// Token: 0x06009F6B RID: 40811 RVA: 0x003E3B28 File Offset: 0x003E1D28
	public override List<brl> j0()
	{
		return new List<brl>
		{
			new bap(75, new Type[]
			{
				typeof(e5n)
			})
		};
	}

	// Token: 0x06009F6C RID: 40812 RVA: 0x003E3B5C File Offset: 0x003E1D5C
	public override object[] at()
	{
		return new object[]
		{
			(int)(ceu.a * 100.0)
		};
	}

	// Token: 0x06009F6D RID: 40813 RVA: 0x003E3B7C File Offset: 0x003E1D7C
	protected override string nq()
	{
		if (dk2.f())
		{
			return "XPBL";
		}
		return null;
	}

	// Token: 0x04003DA0 RID: 15776
	public new static readonly double a = 1.0;
}

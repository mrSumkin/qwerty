using System;
using System.Collections.Generic;

// Token: 0x02001CC5 RID: 7365
[d29("FragmentedChaos", "Fragmented Chaos")]
public sealed class e24 : ai8
{
	// Token: 0x0600A191 RID: 41361 RVA: 0x003E79D8 File Offset: 0x003E5BD8
	public override string au()
	{
		return "xpbl";
	}

	// Token: 0x0600A192 RID: 41362 RVA: 0x003E79E0 File Offset: 0x003E5BE0
	public override bool ap()
	{
		return false;
	}

	// Token: 0x0600A193 RID: 41363 RVA: 0x003E79E4 File Offset: 0x003E5BE4
	public e24() : base("膕Фрагментированный хаос")
	{
	}

	// Token: 0x0600A194 RID: 41364 RVA: 0x003E79F4 File Offset: 0x003E5BF4
	public override void ar(efk A_0)
	{
	}

	// Token: 0x0600A195 RID: 41365 RVA: 0x003E79F8 File Offset: 0x003E5BF8
	public override void @as(efk A_0)
	{
	}

	// Token: 0x0600A196 RID: 41366 RVA: 0x003E79FC File Offset: 0x003E5BFC
	public override object[] at()
	{
		return new object[]
		{
			(int)(e24.a * 100.0)
		};
	}

	// Token: 0x0600A197 RID: 41367 RVA: 0x003E7A20 File Offset: 0x003E5C20
	public override List<brl> j0()
	{
		return new List<brl>
		{
			new awr(typeof(eav), 9),
			new bap(70, new Type[]
			{
				typeof(ct7)
			})
		};
	}

	// Token: 0x04003E14 RID: 15892
	public new static readonly double a = 2.5;
}

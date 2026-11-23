using System;
using System.Collections.Generic;

// Token: 0x02001CC7 RID: 7367
[d29("LeadingShot", "Leading Shot")]
public sealed class g4 : ai8
{
	// Token: 0x0600A1A1 RID: 41377 RVA: 0x003E7B24 File Offset: 0x003E5D24
	public override string au()
	{
		return "xpbl";
	}

	// Token: 0x0600A1A2 RID: 41378 RVA: 0x003E7B2C File Offset: 0x003E5D2C
	public override bool ap()
	{
		return false;
	}

	// Token: 0x0600A1A3 RID: 41379 RVA: 0x003E7B30 File Offset: 0x003E5D30
	public g4() : base("膔Ведущий выстрел")
	{
	}

	// Token: 0x0600A1A4 RID: 41380 RVA: 0x003E7B40 File Offset: 0x003E5D40
	public override void ar(efk A_0)
	{
	}

	// Token: 0x0600A1A5 RID: 41381 RVA: 0x003E7B44 File Offset: 0x003E5D44
	public override void @as(efk A_0)
	{
	}

	// Token: 0x0600A1A6 RID: 41382 RVA: 0x003E7B48 File Offset: 0x003E5D48
	public override object[] at()
	{
		return new object[]
		{
			(int)(g4.a * 100.0)
		};
	}

	// Token: 0x0600A1A7 RID: 41383 RVA: 0x003E7B6C File Offset: 0x003E5D6C
	public override List<brl> j0()
	{
		return new List<brl>
		{
			new awr(typeof(cwu), 5),
			new bap(35, new Type[]
			{
				typeof(ct7)
			})
		};
	}

	// Token: 0x04003E16 RID: 15894
	public new static readonly double a = 0.65;
}

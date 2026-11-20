using System;
using System.Collections.Generic;

// Token: 0x02001C90 RID: 7312
[d29("CriticalPower", "Critical Power")]
public sealed class cd7 : ai8
{
	// Token: 0x0600A03C RID: 41020 RVA: 0x003E5308 File Offset: 0x003E3508
	public cd7() : base("肁Критическая мощь")
	{
	}

	// Token: 0x0600A03D RID: 41021 RVA: 0x003E5318 File Offset: 0x003E3518
	public override void ar(efk A_0)
	{
	}

	// Token: 0x0600A03E RID: 41022 RVA: 0x003E531C File Offset: 0x003E351C
	public override void @as(efk A_0)
	{
	}

	// Token: 0x0600A03F RID: 41023 RVA: 0x003E5320 File Offset: 0x003E3520
	public override object[] at()
	{
		return new object[]
		{
			(int)(cd7.b * 100.0),
			(int)(cd7.c * 100.0),
			Convert.ToInt32(cd7.a * 100.0)
		};
	}

	// Token: 0x0600A040 RID: 41024 RVA: 0x003E5380 File Offset: 0x003E3580
	public override List<d3e> cy(efk A_0)
	{
		return new List<d3e>
		{
			new ade
			{
				Priority = int.MaxValue
			}
		};
	}

	// Token: 0x0600A041 RID: 41025 RVA: 0x003E53A0 File Offset: 0x003E35A0
	public override List<brl> j0()
	{
		return new List<brl>
		{
			new bap(75, new Type[]
			{
				typeof(jk),
				typeof(ct7),
				typeof(e8k),
				typeof(e5n)
			})
		};
	}

	// Token: 0x04003DC5 RID: 15813
	public new static readonly double a = 0.01;

	// Token: 0x04003DC6 RID: 15814
	public new static readonly double b = 0.01;

	// Token: 0x04003DC7 RID: 15815
	public static readonly double c = 1.0;
}

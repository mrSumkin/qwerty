using System;
using System.Collections.Generic;

// Token: 0x02001CBF RID: 7359
[d29("NavalCombat", "Naval Combat")]
public sealed class ej3 : ai8
{
	// Token: 0x0600A15E RID: 41310 RVA: 0x003E7608 File Offset: 0x003E5808
	public override string au()
	{
		return "xpbl";
	}

	// Token: 0x0600A15F RID: 41311 RVA: 0x003E7610 File Offset: 0x003E5810
	public override bool aq()
	{
		return false;
	}

	// Token: 0x0600A160 RID: 41312 RVA: 0x003E7614 File Offset: 0x003E5814
	public override bool ap()
	{
		return false;
	}

	// Token: 0x0600A161 RID: 41313 RVA: 0x003E7618 File Offset: 0x003E5818
	public ej3() : base("Морской бой")
	{
	}

	// Token: 0x0600A162 RID: 41314 RVA: 0x003E7628 File Offset: 0x003E5828
	public override void ar(efk A_0)
	{
	}

	// Token: 0x0600A163 RID: 41315 RVA: 0x003E762C File Offset: 0x003E582C
	public override void @as(efk A_0)
	{
	}

	// Token: 0x0600A164 RID: 41316 RVA: 0x003E7630 File Offset: 0x003E5830
	public override object[] at()
	{
		return new object[]
		{
			(int)(ej3.a * 100.0),
			(int)(ej3.b * 100.0),
			ej3.c
		};
	}

	// Token: 0x0600A165 RID: 41317 RVA: 0x003E7680 File Offset: 0x003E5880
	public override List<brl> j0()
	{
		return new List<brl>();
	}

	// Token: 0x04003E08 RID: 15880
	public new static readonly double a = 0.15;

	// Token: 0x04003E09 RID: 15881
	public new static readonly double b = 0.1;

	// Token: 0x04003E0A RID: 15882
	public static readonly int c = 10;

	// Token: 0x04003E0B RID: 15883
	public new static readonly int d = 50;
}

using System;
using System.Collections.Generic;

// Token: 0x02001C9B RID: 7323
[d29("Hunter", "Hunter")]
public sealed class d7v : ai8
{
	// Token: 0x0600A07D RID: 41085 RVA: 0x003E5AC4 File Offset: 0x003E3CC4
	public override bool ap()
	{
		return false;
	}

	// Token: 0x0600A07E RID: 41086 RVA: 0x003E5AC8 File Offset: 0x003E3CC8
	public d7v() : base("Охотник")
	{
	}

	// Token: 0x0600A07F RID: 41087 RVA: 0x003E5AD8 File Offset: 0x003E3CD8
	public override bool aq()
	{
		return false;
	}

	// Token: 0x0600A080 RID: 41088 RVA: 0x003E5ADC File Offset: 0x003E3CDC
	protected override string nq()
	{
		if (dk2.f())
		{
			return "XPBL";
		}
		return null;
	}

	// Token: 0x0600A081 RID: 41089 RVA: 0x003E5AF0 File Offset: 0x003E3CF0
	public override void ar(efk A_0)
	{
	}

	// Token: 0x0600A082 RID: 41090 RVA: 0x003E5AF4 File Offset: 0x003E3CF4
	public override void @as(efk A_0)
	{
	}

	// Token: 0x0600A083 RID: 41091 RVA: 0x003E5AF8 File Offset: 0x003E3CF8
	public override object[] at()
	{
		return new object[]
		{
			(int)(d7v.a * 100.0)
		};
	}

	// Token: 0x0600A084 RID: 41092 RVA: 0x003E5B18 File Offset: 0x003E3D18
	public override List<brl> j0()
	{
		return new List<brl>();
	}

	// Token: 0x04003DD4 RID: 15828
	public new static readonly double a = 0.2;
}

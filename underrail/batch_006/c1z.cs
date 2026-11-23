using System;

// Token: 0x02001CDA RID: 7386
[d29("Firebranded", "Firebranded")]
public sealed class c1z : ai8
{
	// Token: 0x0600A221 RID: 41505 RVA: 0x003E8918 File Offset: 0x003E6B18
	public override bool ap()
	{
		return true;
	}

	// Token: 0x0600A222 RID: 41506 RVA: 0x003E891C File Offset: 0x003E6B1C
	public override string au()
	{
		return "xphw";
	}

	// Token: 0x0600A223 RID: 41507 RVA: 0x003E8924 File Offset: 0x003E6B24
	public override bool aq()
	{
		return false;
	}

	// Token: 0x0600A224 RID: 41508 RVA: 0x003E8928 File Offset: 0x003E6B28
	public c1z() : base("Клеймённый")
	{
	}

	// Token: 0x0600A225 RID: 41509 RVA: 0x003E8938 File Offset: 0x003E6B38
	public override object[] at()
	{
		return new object[]
		{
			c1z.a.ToString("P0")
		};
	}

	// Token: 0x04003E27 RID: 15911
	public new static readonly double a = 0.009999999776482582;
}

using System;

// Token: 0x02001C20 RID: 7200
[d29("BeyondCold", "Beyond Cold")]
public sealed class a2k : ai8
{
	// Token: 0x06009E1E RID: 40478 RVA: 0x003E170C File Offset: 0x003DF90C
	public override bool ap()
	{
		return true;
	}

	// Token: 0x06009E1F RID: 40479 RVA: 0x003E1710 File Offset: 0x003DF910
	public override bool aq()
	{
		return false;
	}

	// Token: 0x06009E20 RID: 40480 RVA: 0x003E1714 File Offset: 0x003DF914
	public a2k() : base("По ту сторону холода")
	{
	}

	// Token: 0x06009E21 RID: 40481 RVA: 0x003E1724 File Offset: 0x003DF924
	public override object[] at()
	{
		return new object[]
		{
			Convert.ToInt32(a2k.a * 100.0),
			Convert.ToInt32(a2k.b * 100.0),
			l4.a(a2k.c, false),
			l4.a(a2k.d, false),
			a2k.f
		};
	}

	// Token: 0x04003D54 RID: 15700
	public new static readonly double a = 0.4000000059604645;

	// Token: 0x04003D55 RID: 15701
	public new static readonly double b = 0.15000000596046448;

	// Token: 0x04003D56 RID: 15702
	public static readonly int c = 3;

	// Token: 0x04003D57 RID: 15703
	public new static readonly int d = 10;

	// Token: 0x04003D58 RID: 15704
	public new static readonly string e = "BeyondCold";

	// Token: 0x04003D59 RID: 15705
	public static readonly int f = 1;
}

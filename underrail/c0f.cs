using System;

// Token: 0x02001D27 RID: 7463
public sealed class c0f : apq
{
	// Token: 0x0600A444 RID: 42052 RVA: 0x003EB87C File Offset: 0x003E9A7C
	public override Type e3()
	{
		return typeof(n4);
	}

	// Token: 0x0600A445 RID: 42053 RVA: 0x003EB888 File Offset: 0x003E9A88
	public override string e4()
	{
		return "HighTechnicalitiesDamage";
	}

	// Token: 0x0600A446 RID: 42054 RVA: 0x003EB890 File Offset: 0x003E9A90
	public override string e5()
	{
		return "Высокотехнологичность";
	}

	// Token: 0x0600A447 RID: 42055 RVA: 0x003EB898 File Offset: 0x003E9A98
	public override int e6()
	{
		return 5;
	}

	// Token: 0x0600A448 RID: 42056 RVA: 0x003EB89C File Offset: 0x003E9A9C
	public override object[] e7()
	{
		return new object[]
		{
			Math.Round(c0f.a * 100.0, 1),
			n4.b
		};
	}

	// Token: 0x04003E80 RID: 16000
	public new static readonly double a = 0.004;
}

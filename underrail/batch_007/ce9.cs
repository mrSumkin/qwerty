using System;

// Token: 0x02001D08 RID: 7432
public sealed class ce9 : apq
{
	// Token: 0x0600A36C RID: 41836 RVA: 0x003EAE5C File Offset: 0x003E905C
	public override Type e3()
	{
		return typeof(jh);
	}

	// Token: 0x0600A36D RID: 41837 RVA: 0x003EAE68 File Offset: 0x003E9068
	public override string e4()
	{
		return "RemoteSurgeon";
	}

	// Token: 0x0600A36E RID: 41838 RVA: 0x003EAE70 File Offset: 0x003E9070
	public override string e5()
	{
		return "Дистанционный хирург";
	}

	// Token: 0x0600A36F RID: 41839 RVA: 0x003EAE78 File Offset: 0x003E9078
	public override int e6()
	{
		return ce9.b;
	}

	// Token: 0x0600A370 RID: 41840 RVA: 0x003EAE80 File Offset: 0x003E9080
	public override object[] e7()
	{
		return new object[]
		{
			Convert.ToInt32(ce9.a * 100.0)
		};
	}

	// Token: 0x04003E61 RID: 15969
	public new static readonly double a = 0.1;

	// Token: 0x04003E62 RID: 15970
	public static readonly int b = 5;
}

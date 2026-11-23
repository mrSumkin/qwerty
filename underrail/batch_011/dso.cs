using System;

// Token: 0x02001D97 RID: 7575
public sealed class dso : apq
{
	// Token: 0x0600A748 RID: 42824 RVA: 0x003EDDA4 File Offset: 0x003EBFA4
	public override Type e3()
	{
		return typeof(e7f);
	}

	// Token: 0x0600A749 RID: 42825 RVA: 0x003EDDB0 File Offset: 0x003EBFB0
	public override string e4()
	{
		return "PowerManagementCapacity";
	}

	// Token: 0x0600A74A RID: 42826 RVA: 0x003EDDB8 File Offset: 0x003EBFB8
	public override string e5()
	{
		return "Управление питанием";
	}

	// Token: 0x0600A74B RID: 42827 RVA: 0x003EDDC0 File Offset: 0x003EBFC0
	public override int e6()
	{
		return 5;
	}

	// Token: 0x0600A74C RID: 42828 RVA: 0x003EDDC4 File Offset: 0x003EBFC4
	public override object[] e7()
	{
		return new object[]
		{
			(int)(dso.a * 100.0)
		};
	}

	// Token: 0x04003EEC RID: 16108
	public new static readonly double a = 0.02;
}

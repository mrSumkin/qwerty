using System;

// Token: 0x02001DB7 RID: 7607
public sealed class ee6 : apq
{
	// Token: 0x0600A828 RID: 43048 RVA: 0x003EE818 File Offset: 0x003ECA18
	public override Type e3()
	{
		return typeof(dyn);
	}

	// Token: 0x0600A829 RID: 43049 RVA: 0x003EE824 File Offset: 0x003ECA24
	public override string e4()
	{
		return "GuardBlockChance";
	}

	// Token: 0x0600A82A RID: 43050 RVA: 0x003EE82C File Offset: 0x003ECA2C
	public override string e5()
	{
		return "Стойка: шанс блока";
	}

	// Token: 0x0600A82B RID: 43051 RVA: 0x003EE834 File Offset: 0x003ECA34
	public override int e6()
	{
		return 10;
	}

	// Token: 0x0600A82C RID: 43052 RVA: 0x003EE838 File Offset: 0x003ECA38
	public override object[] e7()
	{
		return new object[]
		{
			(int)(ee6.a * 100.0)
		};
	}

	// Token: 0x04003F0D RID: 16141
	public new static readonly double a = 0.01;
}

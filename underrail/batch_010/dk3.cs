using System;

// Token: 0x02001DB8 RID: 7608
public sealed class dk3 : apq
{
	// Token: 0x0600A82F RID: 43055 RVA: 0x003EE870 File Offset: 0x003ECA70
	public override Type e3()
	{
		return typeof(a9z);
	}

	// Token: 0x0600A830 RID: 43056 RVA: 0x003EE87C File Offset: 0x003ECA7C
	public override string e4()
	{
		return "ForceUserDamage";
	}

	// Token: 0x0600A831 RID: 43057 RVA: 0x003EE884 File Offset: 0x003ECA84
	public override string e5()
	{
		return "Сила с тобой: урон";
	}

	// Token: 0x0600A832 RID: 43058 RVA: 0x003EE88C File Offset: 0x003ECA8C
	public override int e6()
	{
		return 10;
	}

	// Token: 0x0600A833 RID: 43059 RVA: 0x003EE890 File Offset: 0x003ECA90
	public override object[] e7()
	{
		return new object[]
		{
			(int)(dk3.a * 100.0)
		};
	}

	// Token: 0x04003F0E RID: 16142
	public new static readonly double a = 0.05;
}

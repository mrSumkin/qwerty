using System;

// Token: 0x02001D56 RID: 7510
public sealed class c8y : apq
{
	// Token: 0x0600A58D RID: 42381 RVA: 0x003EC85C File Offset: 0x003EAA5C
	public override Type e3()
	{
		return typeof(e2c);
	}

	// Token: 0x0600A58E RID: 42382 RVA: 0x003EC868 File Offset: 0x003EAA68
	public override string e4()
	{
		return "ShieldArmBlockChance";
	}

	// Token: 0x0600A58F RID: 42383 RVA: 0x003EC870 File Offset: 0x003EAA70
	public override string e5()
	{
		return "Ручной щит: шанс блока";
	}

	// Token: 0x0600A590 RID: 42384 RVA: 0x003EC878 File Offset: 0x003EAA78
	public override int e6()
	{
		return 5;
	}

	// Token: 0x0600A591 RID: 42385 RVA: 0x003EC87C File Offset: 0x003EAA7C
	public override object[] e7()
	{
		return new object[]
		{
			(int)(c8y.a * 100.0)
		};
	}

	// Token: 0x04003EB0 RID: 16048
	public new static readonly double a = 0.01;
}

using System;

// Token: 0x02001D55 RID: 7509
public sealed class ai1 : apq
{
	// Token: 0x0600A586 RID: 42374 RVA: 0x003EC804 File Offset: 0x003EAA04
	public override Type e3()
	{
		return typeof(e2c);
	}

	// Token: 0x0600A587 RID: 42375 RVA: 0x003EC810 File Offset: 0x003EAA10
	public override string e4()
	{
		return "ShieldArmBlockAmount";
	}

	// Token: 0x0600A588 RID: 42376 RVA: 0x003EC818 File Offset: 0x003EAA18
	public override string e5()
	{
		return "Ручной щит: кол-во блока";
	}

	// Token: 0x0600A589 RID: 42377 RVA: 0x003EC820 File Offset: 0x003EAA20
	public override int e6()
	{
		return 10;
	}

	// Token: 0x0600A58A RID: 42378 RVA: 0x003EC824 File Offset: 0x003EAA24
	public override object[] e7()
	{
		return new object[]
		{
			(int)(ai1.a * 100.0)
		};
	}

	// Token: 0x04003EAF RID: 16047
	public new static readonly double a = 0.02;
}

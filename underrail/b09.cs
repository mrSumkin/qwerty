using System;

// Token: 0x02001D70 RID: 7536
public sealed class b09 : apq
{
	// Token: 0x0600A637 RID: 42551 RVA: 0x003ED044 File Offset: 0x003EB244
	public override Type e3()
	{
		return typeof(c6t);
	}

	// Token: 0x0600A638 RID: 42552 RVA: 0x003ED050 File Offset: 0x003EB250
	public override string e4()
	{
		return "VileWeaponryHealingReduction";
	}

	// Token: 0x0600A639 RID: 42553 RVA: 0x003ED058 File Offset: 0x003EB258
	public override string e5()
	{
		return "Запрещённое оружие: меньше лечение";
	}

	// Token: 0x0600A63A RID: 42554 RVA: 0x003ED060 File Offset: 0x003EB260
	public override int e6()
	{
		return 2;
	}

	// Token: 0x0600A63B RID: 42555 RVA: 0x003ED064 File Offset: 0x003EB264
	public override object[] e7()
	{
		return new object[]
		{
			Math.Round(b09.a * 100.0, 1)
		};
	}

	// Token: 0x04003EC4 RID: 16068
	public new static readonly double a = 0.025;
}

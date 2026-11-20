using System;

// Token: 0x02001D90 RID: 7568
public sealed class bhr : apq
{
	// Token: 0x0600A717 RID: 42775 RVA: 0x003EDB4C File Offset: 0x003EBD4C
	public override Type e3()
	{
		return typeof(c80);
	}

	// Token: 0x0600A718 RID: 42776 RVA: 0x003EDB58 File Offset: 0x003EBD58
	public override string e4()
	{
		return "PsychosisCritChance";
	}

	// Token: 0x0600A719 RID: 42777 RVA: 0x003EDB60 File Offset: 0x003EBD60
	public override string e5()
	{
		return "Психоз: крит. шанс";
	}

	// Token: 0x0600A71A RID: 42778 RVA: 0x003EDB68 File Offset: 0x003EBD68
	public override int e6()
	{
		return 10;
	}

	// Token: 0x0600A71B RID: 42779 RVA: 0x003EDB6C File Offset: 0x003EBD6C
	public override object[] e7()
	{
		return new object[]
		{
			(int)(bhr.a * 100.0)
		};
	}

	// Token: 0x04003EE5 RID: 16101
	public new static readonly double a = 0.01;
}

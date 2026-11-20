using System;

// Token: 0x02001D83 RID: 7555
public sealed class cjp : apq
{
	// Token: 0x0600A6BC RID: 42684 RVA: 0x003ED6AC File Offset: 0x003EB8AC
	public override Type e3()
	{
		return typeof(bbn);
	}

	// Token: 0x0600A6BD RID: 42685 RVA: 0x003ED6B8 File Offset: 0x003EB8B8
	public override string e4()
	{
		return "SnipeDamage";
	}

	// Token: 0x0600A6BE RID: 42686 RVA: 0x003ED6C0 File Offset: 0x003EB8C0
	public override string e5()
	{
		return "Снайперский выстрел";
	}

	// Token: 0x0600A6BF RID: 42687 RVA: 0x003ED6C8 File Offset: 0x003EB8C8
	public override int e6()
	{
		return 10;
	}

	// Token: 0x0600A6C0 RID: 42688 RVA: 0x003ED6CC File Offset: 0x003EB8CC
	public override object[] e7()
	{
		return new object[]
		{
			Math.Round(cjp.a * 100.0, 1)
		};
	}

	// Token: 0x04003ED7 RID: 16087
	public new static readonly double a = 0.001;
}

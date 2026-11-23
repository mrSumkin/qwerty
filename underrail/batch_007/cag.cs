using System;

// Token: 0x02001DAF RID: 7599
public sealed class cag : apq
{
	// Token: 0x0600A7F0 RID: 42992 RVA: 0x003EE574 File Offset: 0x003EC774
	public override Type e3()
	{
		return typeof(c4y);
	}

	// Token: 0x0600A7F1 RID: 42993 RVA: 0x003EE580 File Offset: 0x003EC780
	public override string e4()
	{
		return "InterloperMovement";
	}

	// Token: 0x0600A7F2 RID: 42994 RVA: 0x003EE588 File Offset: 0x003EC788
	public override string e5()
	{
		return "Нарушитель";
	}

	// Token: 0x0600A7F3 RID: 42995 RVA: 0x003EE590 File Offset: 0x003EC790
	public override int e6()
	{
		return 10;
	}

	// Token: 0x0600A7F4 RID: 42996 RVA: 0x003EE594 File Offset: 0x003EC794
	public override object[] e7()
	{
		return new object[]
		{
			Math.Round(cag.a * 100.0, 1),
			cag.b
		};
	}

	// Token: 0x04003F04 RID: 16132
	public new static readonly double a = 0.015;

	// Token: 0x04003F05 RID: 16133
	public static readonly int b = 2;
}

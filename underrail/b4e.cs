using System;

// Token: 0x02001CFE RID: 7422
public sealed class b4e : apq
{
	// Token: 0x0600A326 RID: 41766 RVA: 0x003EAB08 File Offset: 0x003E8D08
	public override Type e3()
	{
		return typeof(dcs);
	}

	// Token: 0x0600A327 RID: 41767 RVA: 0x003EAB14 File Offset: 0x003E8D14
	public override string e4()
	{
		return "ArmorSloping";
	}

	// Token: 0x0600A328 RID: 41768 RVA: 0x003EAB1C File Offset: 0x003E8D1C
	public override string e5()
	{
		return "Наклонная броня";
	}

	// Token: 0x0600A329 RID: 41769 RVA: 0x003EAB24 File Offset: 0x003E8D24
	public override int e6()
	{
		return 2;
	}

	// Token: 0x0600A32A RID: 41770 RVA: 0x003EAB28 File Offset: 0x003E8D28
	public override object[] e7()
	{
		return new object[]
		{
			(int)(b4e.a * 100.0)
		};
	}

	// Token: 0x04003E57 RID: 15959
	public new static readonly double a = 0.025;
}

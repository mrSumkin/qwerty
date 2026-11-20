using System;

// Token: 0x02001DCF RID: 7631
public sealed class er : apq
{
	// Token: 0x0600A8D0 RID: 43216 RVA: 0x003EEFDC File Offset: 0x003ED1DC
	public override Type e3()
	{
		return typeof(cd7);
	}

	// Token: 0x0600A8D1 RID: 43217 RVA: 0x003EEFE8 File Offset: 0x003ED1E8
	public override string e4()
	{
		return "CriticalPowerCritDamage";
	}

	// Token: 0x0600A8D2 RID: 43218 RVA: 0x003EEFF0 File Offset: 0x003ED1F0
	public override string e5()
	{
		return "Критическая мощь";
	}

	// Token: 0x0600A8D3 RID: 43219 RVA: 0x003EEFF8 File Offset: 0x003ED1F8
	public override int e6()
	{
		return 10;
	}

	// Token: 0x0600A8D4 RID: 43220 RVA: 0x003EEFFC File Offset: 0x003ED1FC
	public override object[] e7()
	{
		return new object[]
		{
			Math.Round(er.a * 100.0, 1)
		};
	}

	// Token: 0x04003F25 RID: 16165
	public new static readonly double a = 0.001;
}

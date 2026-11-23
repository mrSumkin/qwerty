using System;

// Token: 0x02001D71 RID: 7537
public sealed class del : apq
{
	// Token: 0x0600A63E RID: 42558 RVA: 0x003ED0A4 File Offset: 0x003EB2A4
	public override Type e3()
	{
		return typeof(c6t);
	}

	// Token: 0x0600A63F RID: 42559 RVA: 0x003ED0B0 File Offset: 0x003EB2B0
	public override string e4()
	{
		return "VileWeaponryDamage";
	}

	// Token: 0x0600A640 RID: 42560 RVA: 0x003ED0B8 File Offset: 0x003EB2B8
	public override string e5()
	{
		return "Запрещённое оружие: урон";
	}

	// Token: 0x0600A641 RID: 42561 RVA: 0x003ED0C0 File Offset: 0x003EB2C0
	public override int e6()
	{
		return 5;
	}

	// Token: 0x0600A642 RID: 42562 RVA: 0x003ED0C4 File Offset: 0x003EB2C4
	public override object[] e7()
	{
		return new object[]
		{
			(int)(del.a * 100.0)
		};
	}

	// Token: 0x04003EC5 RID: 16069
	public new static readonly double a = 0.01;
}

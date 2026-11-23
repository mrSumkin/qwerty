using System;

// Token: 0x02001D1F RID: 7455
public sealed class e3z : apq
{
	// Token: 0x0600A40C RID: 41996 RVA: 0x003EB5CC File Offset: 0x003E97CC
	public override Type e3()
	{
		return typeof(bkv);
	}

	// Token: 0x0600A40D RID: 41997 RVA: 0x003EB5D8 File Offset: 0x003E97D8
	public override string e4()
	{
		return "CookedShotDamage";
	}

	// Token: 0x0600A40E RID: 41998 RVA: 0x003EB5E0 File Offset: 0x003E97E0
	public override string e5()
	{
		return "Подготовленный выстрел: урон";
	}

	// Token: 0x0600A40F RID: 41999 RVA: 0x003EB5E8 File Offset: 0x003E97E8
	public override int e6()
	{
		return 10;
	}

	// Token: 0x0600A410 RID: 42000 RVA: 0x003EB5EC File Offset: 0x003E97EC
	public override object[] e7()
	{
		return new object[]
		{
			(int)(e3z.a * 100.0)
		};
	}

	// Token: 0x04003E78 RID: 15992
	public new static readonly double a = 0.05;
}

using System;

// Token: 0x02001D5A RID: 7514
public sealed class dod : apq
{
	// Token: 0x0600A5A9 RID: 42409 RVA: 0x003EC9AC File Offset: 0x003EABAC
	public override Type e3()
	{
		return typeof(ap6);
	}

	// Token: 0x0600A5AA RID: 42410 RVA: 0x003EC9B8 File Offset: 0x003EABB8
	public override string e4()
	{
		return "BulletTranceDamage";
	}

	// Token: 0x0600A5AB RID: 42411 RVA: 0x003EC9C0 File Offset: 0x003EABC0
	public override string e5()
	{
		return "Пулевой транс: урон";
	}

	// Token: 0x0600A5AC RID: 42412 RVA: 0x003EC9C8 File Offset: 0x003EABC8
	public override int e6()
	{
		return 5;
	}

	// Token: 0x0600A5AD RID: 42413 RVA: 0x003EC9CC File Offset: 0x003EABCC
	public override object[] e7()
	{
		return new object[]
		{
			Convert.ToInt32(dod.a * 100.0)
		};
	}

	// Token: 0x04003EB4 RID: 16052
	public new static readonly double a = 0.01;
}

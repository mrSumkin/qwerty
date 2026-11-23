using System;

// Token: 0x02001D00 RID: 7424
public sealed class cjz : apq
{
	// Token: 0x0600A334 RID: 41780 RVA: 0x003EABBC File Offset: 0x003E8DBC
	public override Type e3()
	{
		return typeof(ku);
	}

	// Token: 0x0600A335 RID: 41781 RVA: 0x003EABC8 File Offset: 0x003E8DC8
	public override string e4()
	{
		return "HeavyPunchDamage";
	}

	// Token: 0x0600A336 RID: 41782 RVA: 0x003EABD0 File Offset: 0x003E8DD0
	public override string e5()
	{
		return "Тяжёлая рука: урон";
	}

	// Token: 0x0600A337 RID: 41783 RVA: 0x003EABD8 File Offset: 0x003E8DD8
	public override int e6()
	{
		return 10;
	}

	// Token: 0x0600A338 RID: 41784 RVA: 0x003EABDC File Offset: 0x003E8DDC
	public override object[] e7()
	{
		return new object[]
		{
			(int)(cjz.a * 100.0)
		};
	}

	// Token: 0x04003E59 RID: 15961
	public new static readonly double a = 0.1;
}

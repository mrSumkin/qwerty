using System;

// Token: 0x02001D1A RID: 7450
public sealed class c4u : apq
{
	// Token: 0x0600A3E9 RID: 41961 RVA: 0x003EB424 File Offset: 0x003E9624
	public override Type e3()
	{
		return typeof(egq);
	}

	// Token: 0x0600A3EA RID: 41962 RVA: 0x003EB430 File Offset: 0x003E9630
	public override string e4()
	{
		return "ComboStunChance";
	}

	// Token: 0x0600A3EB RID: 41963 RVA: 0x003EB438 File Offset: 0x003E9638
	public override string e5()
	{
		return "Комбо: шанс оглушения";
	}

	// Token: 0x0600A3EC RID: 41964 RVA: 0x003EB440 File Offset: 0x003E9640
	public override int e6()
	{
		return 5;
	}

	// Token: 0x0600A3ED RID: 41965 RVA: 0x003EB444 File Offset: 0x003E9644
	public override object[] e7()
	{
		return new object[]
		{
			(int)(c4u.a * 100.0)
		};
	}

	// Token: 0x04003E73 RID: 15987
	public new static readonly double a = 0.02;
}

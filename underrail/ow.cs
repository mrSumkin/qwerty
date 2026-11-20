using System;

// Token: 0x02001D63 RID: 7523
public sealed class ow : apq
{
	// Token: 0x0600A5E0 RID: 42464 RVA: 0x003ECC24 File Offset: 0x003EAE24
	public override Type e3()
	{
		return typeof(d3h);
	}

	// Token: 0x0600A5E1 RID: 42465 RVA: 0x003ECC30 File Offset: 0x003EAE30
	public override string e4()
	{
		return "DemolitionManDamageBonus";
	}

	// Token: 0x0600A5E2 RID: 42466 RVA: 0x003ECC38 File Offset: 0x003EAE38
	public override string e5()
	{
		return "Взрыв разрушений: доп. урон";
	}

	// Token: 0x0600A5E3 RID: 42467 RVA: 0x003ECC40 File Offset: 0x003EAE40
	public override int e6()
	{
		return 5;
	}

	// Token: 0x0600A5E4 RID: 42468 RVA: 0x003ECC44 File Offset: 0x003EAE44
	public override object[] e7()
	{
		return new object[]
		{
			Convert.ToInt32(ow.a * 100.0)
		};
	}

	// Token: 0x04003EB9 RID: 16057
	public new static readonly double a = 0.01;
}

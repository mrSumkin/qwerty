using System;

// Token: 0x02001D24 RID: 7460
public sealed class bu1 : apq
{
	// Token: 0x0600A42F RID: 42031 RVA: 0x003EB778 File Offset: 0x003E9978
	public override Type e3()
	{
		return typeof(alo);
	}

	// Token: 0x0600A430 RID: 42032 RVA: 0x003EB784 File Offset: 0x003E9984
	public override string e4()
	{
		return "ImprovedUnarmedCombatDamage";
	}

	// Token: 0x0600A431 RID: 42033 RVA: 0x003EB78C File Offset: 0x003E998C
	public override string e5()
	{
		return "Улучш. рукопашный бой: урон";
	}

	// Token: 0x0600A432 RID: 42034 RVA: 0x003EB794 File Offset: 0x003E9994
	public override int e6()
	{
		return 5;
	}

	// Token: 0x0600A433 RID: 42035 RVA: 0x003EB798 File Offset: 0x003E9998
	public override object[] e7()
	{
		return new object[]
		{
			Convert.ToInt32(bu1.a * 100.0)
		};
	}

	// Token: 0x04003E7D RID: 15997
	public new static readonly double a = 0.02;
}

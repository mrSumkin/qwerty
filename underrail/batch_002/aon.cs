using System;

// Token: 0x02001D69 RID: 7529
public sealed class aon : apq
{
	// Token: 0x0600A606 RID: 42502 RVA: 0x003ECDDC File Offset: 0x003EAFDC
	public override Type e3()
	{
		return typeof(chc);
	}

	// Token: 0x0600A607 RID: 42503 RVA: 0x003ECDE8 File Offset: 0x003EAFE8
	public override string e4()
	{
		return "TrickyTrajectoryDamageBonus";
	}

	// Token: 0x0600A608 RID: 42504 RVA: 0x003ECDF0 File Offset: 0x003EAFF0
	public override string e5()
	{
		return "Замысловатая траектория: доп. урон";
	}

	// Token: 0x0600A609 RID: 42505 RVA: 0x003ECDF8 File Offset: 0x003EAFF8
	public override int e6()
	{
		return 5;
	}

	// Token: 0x0600A60A RID: 42506 RVA: 0x003ECDFC File Offset: 0x003EAFFC
	public override object[] e7()
	{
		return new object[]
		{
			Convert.ToInt32(aon.a * 100.0)
		};
	}

	// Token: 0x04003EBD RID: 16061
	public new static readonly double a = 0.02;
}

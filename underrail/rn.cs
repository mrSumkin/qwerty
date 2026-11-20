using System;

// Token: 0x02001D7A RID: 7546
public sealed class rn : apq
{
	// Token: 0x0600A67D RID: 42621 RVA: 0x003ED3B4 File Offset: 0x003EB5B4
	public override Type e3()
	{
		return typeof(er4);
	}

	// Token: 0x0600A67E RID: 42622 RVA: 0x003ED3C0 File Offset: 0x003EB5C0
	public override string e4()
	{
		return "SurvivalInstinctsCritChance";
	}

	// Token: 0x0600A67F RID: 42623 RVA: 0x003ED3C8 File Offset: 0x003EB5C8
	public override string e5()
	{
		return "Инстинкт выживания: крит. шанс";
	}

	// Token: 0x0600A680 RID: 42624 RVA: 0x003ED3D0 File Offset: 0x003EB5D0
	public override int e6()
	{
		return 10;
	}

	// Token: 0x0600A681 RID: 42625 RVA: 0x003ED3D4 File Offset: 0x003EB5D4
	public override object[] e7()
	{
		return new object[]
		{
			(int)(rn.a * 100.0)
		};
	}

	// Token: 0x04003ECE RID: 16078
	public new static readonly double a = 0.01;
}

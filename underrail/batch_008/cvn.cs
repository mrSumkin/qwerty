using System;

// Token: 0x02001D85 RID: 7557
public sealed class cvn : apq
{
	// Token: 0x0600A6CA RID: 42698 RVA: 0x003ED764 File Offset: 0x003EB964
	public override Type e3()
	{
		return typeof(b03);
	}

	// Token: 0x0600A6CB RID: 42699 RVA: 0x003ED770 File Offset: 0x003EB970
	public override string e4()
	{
		return "SharpshooterCritDamage";
	}

	// Token: 0x0600A6CC RID: 42700 RVA: 0x003ED778 File Offset: 0x003EB978
	public override string e5()
	{
		return "Снайпер";
	}

	// Token: 0x0600A6CD RID: 42701 RVA: 0x003ED780 File Offset: 0x003EB980
	public override int e6()
	{
		return 5;
	}

	// Token: 0x0600A6CE RID: 42702 RVA: 0x003ED784 File Offset: 0x003EB984
	public override object[] e7()
	{
		return new object[]
		{
			(int)(cvn.a * 100.0)
		};
	}

	// Token: 0x04003ED9 RID: 16089
	public new static readonly double a = 0.02;
}

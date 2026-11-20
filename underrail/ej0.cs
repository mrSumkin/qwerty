using System;

// Token: 0x02000361 RID: 865
public sealed class ej0 : d24
{
	// Token: 0x0600183C RID: 6204 RVA: 0x0007B368 File Offset: 0x00079568
	public ej0(Action<ej0> A_0)
	{
		this.a = A_0;
	}

	// Token: 0x0600183D RID: 6205 RVA: 0x0007B378 File Offset: 0x00079578
	public ej0()
	{
	}

	// Token: 0x0600183E RID: 6206 RVA: 0x0007B380 File Offset: 0x00079580
	public override abg f7()
	{
		if (this.a != null)
		{
			this.a(this);
		}
		return base.f7();
	}

	// Token: 0x04000E3A RID: 3642
	public new Action<ej0> a;
}

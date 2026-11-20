using System;

// Token: 0x0200035D RID: 861
public sealed class a6w : t7
{
	// Token: 0x06001833 RID: 6195 RVA: 0x0007B1D4 File Offset: 0x000793D4
	public a6w(Func<a6w, cst> A_0 = null)
	{
		this.a = A_0;
	}

	// Token: 0x06001834 RID: 6196 RVA: 0x0007B1E4 File Offset: 0x000793E4
	protected override cst ip()
	{
		if (this.a != null)
		{
			return this.a(this);
		}
		return null;
	}

	// Token: 0x04000E34 RID: 3636
	public new Func<a6w, cst> a;
}

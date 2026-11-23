using System;

// Token: 0x02000359 RID: 857
public sealed class vw : d24
{
	// Token: 0x0600182B RID: 6187 RVA: 0x0007A934 File Offset: 0x00078B34
	public vw(params string[] A_0)
	{
		this.a = A_0;
	}

	// Token: 0x0600182C RID: 6188 RVA: 0x0007A948 File Offset: 0x00078B48
	public override abg f7()
	{
		if (this.a != null && this.a.Length != 0)
		{
			if (this.b == null)
			{
				this.b = base.b().c().b(this.a);
				return null;
			}
			if (!this.b.a())
			{
				return null;
			}
			this.b = null;
		}
		return base.f7();
	}

	// Token: 0x04000E2A RID: 3626
	private new string[] a;

	// Token: 0x04000E2B RID: 3627
	private bkp b;
}

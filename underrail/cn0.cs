using System;

// Token: 0x0200062A RID: 1578
public sealed class cn0 : lu
{
	// Token: 0x0600288A RID: 10378 RVA: 0x000E9094 File Offset: 0x000E7294
	public override bcw c5()
	{
		return bcw.b;
	}

	// Token: 0x0600288B RID: 10379 RVA: 0x000E9098 File Offset: 0x000E7298
	public override bool cg(object A_0)
	{
		if (A_0 == null)
		{
			return false;
		}
		c5x c5x = A_0 as c5x;
		return c5x != null && c5x.s.b != null && c5x.s.b.ab();
	}
}

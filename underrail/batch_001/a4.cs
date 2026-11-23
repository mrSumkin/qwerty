using System;

// Token: 0x0200062C RID: 1580
public sealed class a4 : lu
{
	// Token: 0x06002892 RID: 10386 RVA: 0x000E9304 File Offset: 0x000E7504
	public override bcw c5()
	{
		return bcw.b;
	}

	// Token: 0x06002893 RID: 10387 RVA: 0x000E9308 File Offset: 0x000E7508
	public override bool cg(object A_0)
	{
		if (A_0 == null)
		{
			return false;
		}
		b0b b0b = A_0 as b0b;
		return b0b != null && b0b.GetAspect<c7j>() != null;
	}
}

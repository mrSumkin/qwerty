using System;

// Token: 0x02000646 RID: 1606
public sealed class c5d : d0m
{
	// Token: 0x060028EE RID: 10478 RVA: 0x000EA034 File Offset: 0x000E8234
	public override bool f8(b0b A_0)
	{
		j7 aspect = A_0.GetAspect<j7>();
		return aspect != null && !string.IsNullOrEmpty(aspect.fd());
	}
}

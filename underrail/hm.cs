using System;

// Token: 0x02000629 RID: 1577
public sealed class hm : emk
{
	// Token: 0x06002888 RID: 10376 RVA: 0x000E9034 File Offset: 0x000E7234
	public hm(av A_0) : base(A_0)
	{
	}

	// Token: 0x06002889 RID: 10377 RVA: 0x000E9040 File Offset: 0x000E7240
	public override bool f8(b0b A_0)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		amc aspect = A_0.GetAspect<amc>();
		return A_0 != serviceOrThrow.aqu().v().b() && aspect != null && aspect.aa() != null && !aspect.aa().Dead;
	}
}

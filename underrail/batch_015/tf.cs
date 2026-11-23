using System;

// Token: 0x02000636 RID: 1590
public sealed class tf : aa8
{
	// Token: 0x060028C2 RID: 10434 RVA: 0x000E9848 File Offset: 0x000E7A48
	public void lj(bad A_0)
	{
		czh.a(A_0, "command");
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		A_0.f1(serviceOrThrow.aqw());
	}
}

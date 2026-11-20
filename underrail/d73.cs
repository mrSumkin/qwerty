using System;
using TimelapseVertigo.Rules.Capabilities;

// Token: 0x0200062E RID: 1582
[e7l(SpellTargetType.Self)]
public sealed class d73 : emk
{
	// Token: 0x06002897 RID: 10391 RVA: 0x000E9358 File Offset: 0x000E7558
	public d73(av A_0) : base(A_0)
	{
	}

	// Token: 0x06002898 RID: 10392 RVA: 0x000E9364 File Offset: 0x000E7564
	public override bool f8(b0b A_0)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		return A_0 == serviceOrThrow.aqu().v().b();
	}
}

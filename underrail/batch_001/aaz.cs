using System;
using TimelapseVertigo.Rules.Capabilities;

// Token: 0x02000627 RID: 1575
[e7l(SpellTargetType.LockableObject)]
public sealed class aaz : emk
{
	// Token: 0x06002884 RID: 10372 RVA: 0x000E8FF0 File Offset: 0x000E71F0
	public aaz(av A_0) : base(A_0)
	{
	}

	// Token: 0x06002885 RID: 10373 RVA: 0x000E8FFC File Offset: 0x000E71FC
	public override bool f8(b0b A_0)
	{
		return A_0.GetAspect<d2b>() != null;
	}
}

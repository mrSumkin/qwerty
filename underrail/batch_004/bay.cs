using System;
using TimelapseVertigo.Rules.Capabilities;

// Token: 0x0200062D RID: 1581
[e7l(SpellTargetType.Creature)]
public sealed class bay : emk
{
	// Token: 0x06002895 RID: 10389 RVA: 0x000E9340 File Offset: 0x000E7540
	public bay(av A_0) : base(A_0)
	{
	}

	// Token: 0x06002896 RID: 10390 RVA: 0x000E934C File Offset: 0x000E754C
	public override bool f8(b0b A_0)
	{
		return A_0.GetAspect<amc>() != null;
	}
}

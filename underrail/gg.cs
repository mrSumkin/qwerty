using System;
using TimelapseVertigo.Rules.Capabilities;

// Token: 0x02000626 RID: 1574
[e7l(SpellTargetType.HackableObject)]
public sealed class gg : emk
{
	// Token: 0x06002882 RID: 10370 RVA: 0x000E8FD8 File Offset: 0x000E71D8
	public gg(av A_0) : base(A_0)
	{
	}

	// Token: 0x06002883 RID: 10371 RVA: 0x000E8FE4 File Offset: 0x000E71E4
	public override bool f8(b0b A_0)
	{
		return A_0.GetAspect<d2b>() != null;
	}
}

using System;
using TimelapseVertigo.Rules.Capabilities;

// Token: 0x02000612 RID: 1554
[e7l(SpellTargetType.DamagedCoilSpiderWeb)]
public sealed class cmx : lu
{
	// Token: 0x06002847 RID: 10311 RVA: 0x000E8134 File Offset: 0x000E6334
	public override bcw c5()
	{
		return bcw.b;
	}

	// Token: 0x06002849 RID: 10313 RVA: 0x000E8144 File Offset: 0x000E6344
	public override bool cg(object A_0)
	{
		if (A_0 == null)
		{
			return false;
		}
		b0b b0b = A_0 as b0b;
		return b0b != null && b0b.GetAspect<b2x>() != null;
	}
}

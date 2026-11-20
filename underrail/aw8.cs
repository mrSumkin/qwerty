using System;
using TimelapseVertigo.Rules.Capabilities;

// Token: 0x020005FF RID: 1535
[e7l(SpellTargetType.DeployedGasGrenade)]
public sealed class aw8 : emk
{
	// Token: 0x0600281C RID: 10268 RVA: 0x000E7B34 File Offset: 0x000E5D34
	public aw8(av A_0) : base(A_0)
	{
	}

	// Token: 0x0600281D RID: 10269 RVA: 0x000E7B40 File Offset: 0x000E5D40
	public override bool f8(b0b A_0)
	{
		c5x c5x = A_0 as c5x;
		return c5x != null && c5x.s.b is yp;
	}
}

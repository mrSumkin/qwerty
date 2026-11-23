using System;
using TimelapseVertigo.Rules.Capabilities;

// Token: 0x02000608 RID: 1544
[e7l(SpellTargetType.Fireplace)]
public sealed class bs3 : emk
{
	// Token: 0x06002830 RID: 10288 RVA: 0x000E7D98 File Offset: 0x000E5F98
	public bs3(av A_0) : base(A_0)
	{
	}

	// Token: 0x06002831 RID: 10289 RVA: 0x000E7DA4 File Offset: 0x000E5FA4
	public override bool f8(b0b A_0)
	{
		return A_0.GetAspect<bim>() is eks;
	}
}

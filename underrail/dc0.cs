using System;
using System.Collections.Generic;
using TimelapseVertigo.Rules.Capabilities;

// Token: 0x0200060E RID: 1550
[e7l(SpellTargetType.DisembarkableSpot)]
public sealed class dc0 : ep5
{
	// Token: 0x0600283E RID: 10302 RVA: 0x000E7F64 File Offset: 0x000E6164
	public dc0(av A_0) : base(A_0)
	{
	}

	// Token: 0x0600283F RID: 10303 RVA: 0x000E7F70 File Offset: 0x000E6170
	public override bool ajz(ak1 A_0)
	{
		if (!base.ajz(A_0))
		{
			return false;
		}
		if (A_0.f(null) == 0L)
		{
			List<ya> list = A_0.a(typeof(dsz));
			return list != null && list.Count > 0;
		}
		return false;
	}
}

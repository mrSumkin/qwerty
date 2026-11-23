using System;
using System.Collections.Generic;

// Token: 0x020005D0 RID: 1488
public sealed class c5a : ce8
{
	// Token: 0x06002767 RID: 10087 RVA: 0x000E50F0 File Offset: 0x000E32F0
	public override string[] c6()
	{
		return new string[]
		{
			"playerKill",
			"pkill",
			"pk"
		};
	}

	// Token: 0x06002769 RID: 10089 RVA: 0x000E511C File Offset: 0x000E331C
	public override lu c7(List<object> A_0)
	{
		if (A_0 == null || A_0.Count == 0)
		{
			cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
			if (serviceOrThrow.aqu() != null && serviceOrThrow.aqu().v() != null)
			{
				serviceOrThrow.aqu().v().a(null, null, false);
			}
		}
		else
		{
			base.b();
		}
		return null;
	}
}

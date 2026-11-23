using System;
using System.Collections.Generic;

// Token: 0x02000360 RID: 864
public sealed class aij : d24
{
	// Token: 0x0600183A RID: 6202 RVA: 0x0007B2A4 File Offset: 0x000794A4
	public override abg f7()
	{
		base.b().c().y6().RemoveProperty(ddq.bt);
		foreach (Action<aij> action in this.a)
		{
			if (action != null)
			{
				action(this);
			}
		}
		d4n d4n = base.b().h().ahu(base.b().g().aa());
		if (d4n != null)
		{
			d4n.f();
		}
		return this.a;
	}

	// Token: 0x04000E39 RID: 3641
	public new List<Action<aij>> a = new List<Action<aij>>();
}

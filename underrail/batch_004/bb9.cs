using System;
using System.Collections.Generic;

// Token: 0x02000453 RID: 1107
public sealed class bb9 : pd
{
	// Token: 0x06001CE4 RID: 7396 RVA: 0x000A0A80 File Offset: 0x0009EC80
	public bb9(string A_0) : base(A_0)
	{
	}

	// Token: 0x06001CE5 RID: 7397 RVA: 0x000A0A8C File Offset: 0x0009EC8C
	public bb9(string A_0, IEnumerable<c96> A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06001CE6 RID: 7398 RVA: 0x000A0A98 File Offset: 0x0009EC98
	public override bool acj(TimeSpan A_0, double A_1)
	{
		if (this.Subject != null)
		{
			bzv bzv = new bzv(this.Subject.y6());
			return bzv.c() + bzv.f() > 0;
		}
		return false;
	}
}

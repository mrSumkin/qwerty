using System;
using Microsoft.Xna.Framework;

// Token: 0x02001FFF RID: 8191
public sealed class ap3 : bbd
{
	// Token: 0x0600C13E RID: 49470 RVA: 0x0042FE48 File Offset: 0x0042E048
	public ap3(c8r A_0, int A_1 = 60) : base(A_0, A_1)
	{
		this.i = true;
		this.g = new Rectangle?(A_0.e);
		this.h = cab.c;
		this.f = cab.a;
	}

	// Token: 0x0600C13F RID: 49471 RVA: 0x0042FE78 File Offset: 0x0042E078
	protected override string ri()
	{
		return "Shift";
	}

	// Token: 0x0600C140 RID: 49472 RVA: 0x0042FE80 File Offset: 0x0042E080
	protected override bool rj()
	{
		return this.e != null && this.e.k;
	}
}

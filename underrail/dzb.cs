using System;
using Microsoft.Xna.Framework;

// Token: 0x02001FD6 RID: 8150
public sealed class dzb : bbd
{
	// Token: 0x0600BF5B RID: 48987 RVA: 0x00423C94 File Offset: 0x00421E94
	public dzb(c8r A_0, int A_1 = 60) : base(A_0, A_1)
	{
		this.i = true;
		this.g = new Rectangle?(A_0.f);
		this.h = cab.c;
		this.f = cab.a;
	}

	// Token: 0x0600BF5C RID: 48988 RVA: 0x00423CC4 File Offset: 0x00421EC4
	protected override string ri()
	{
		return "Enter";
	}
}

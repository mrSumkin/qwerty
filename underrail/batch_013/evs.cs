using System;
using Microsoft.Xna.Framework;

// Token: 0x02001886 RID: 6278
public sealed class evs : btm
{
	// Token: 0x06008551 RID: 34129 RVA: 0x0037602C File Offset: 0x0037422C
	public evs(esj A_0, eyp A_1, string A_2, string A_3, Color? A_4, Color? A_5, string A_6, string A_7, params cpk[] A_8) : base(null)
	{
		this.a = A_0;
		this.b = A_1;
		this.c = A_2;
		this.d = A_3;
		this.f = A_4;
		this.g = A_5;
		this.e = A_8;
		this.h = A_6;
		this.i = A_7;
	}

	// Token: 0x06008552 RID: 34130 RVA: 0x00376088 File Offset: 0x00374288
	protected override bool b4(e6d A_0)
	{
		bnr.a(this.a, this.b, this.c, this.d, this.h, this.i, this.f, this.g, 0, this.e, null, null);
		return true;
	}

	// Token: 0x0400330E RID: 13070
	private esj a;

	// Token: 0x0400330F RID: 13071
	private eyp b;

	// Token: 0x04003310 RID: 13072
	private string c;

	// Token: 0x04003311 RID: 13073
	private new string d;

	// Token: 0x04003312 RID: 13074
	private new cpk[] e;

	// Token: 0x04003313 RID: 13075
	private new Color? f;

	// Token: 0x04003314 RID: 13076
	private new Color? g;

	// Token: 0x04003315 RID: 13077
	private string h;

	// Token: 0x04003316 RID: 13078
	private string i;
}

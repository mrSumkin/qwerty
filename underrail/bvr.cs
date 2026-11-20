using System;
using Microsoft.Xna.Framework;

// Token: 0x0200207C RID: 8316
internal abstract class bvr : euz
{
	// Token: 0x0600C69F RID: 50847 RVA: 0x00459348 File Offset: 0x00457548
	protected a9m d()
	{
		return this.a;
	}

	// Token: 0x0600C6A0 RID: 50848 RVA: 0x00459350 File Offset: 0x00457550
	protected e3q c()
	{
		return this.b;
	}

	// Token: 0x0600C6A1 RID: 50849 RVA: 0x00459358 File Offset: 0x00457558
	protected bvr(e3q A_0, a9m A_1)
	{
		czh.a(A_0, "character");
		wj wj = wj.a();
		this.b = A_0;
		this.a = A_1;
		if (wj.c())
		{
			base.Location = new Point(0, 20);
			base.Size = new esj(930, 650);
			return;
		}
		base.Location = Point.Zero;
		base.Size = wj.fu;
	}

	// Token: 0x04004924 RID: 18724
	private new a9m a;

	// Token: 0x04004925 RID: 18725
	private new e3q b;
}

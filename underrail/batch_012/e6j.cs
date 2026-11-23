using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;

// Token: 0x0200033F RID: 831
[ajo("ZoC")]
public sealed class e6j : dj4
{
	// Token: 0x0600177A RID: 6010 RVA: 0x00076FA4 File Offset: 0x000751A4
	public override bool abf()
	{
		return true;
	}

	// Token: 0x0600177B RID: 6011 RVA: 0x00076FA8 File Offset: 0x000751A8
	public override void abi(cte A_0, TimeSpan A_1, TimeSpan A_2)
	{
	}

	// Token: 0x0600177C RID: 6012 RVA: 0x00076FAC File Offset: 0x000751AC
	public override void age(cte A_0, TimeSpan A_1, TimeSpan A_2)
	{
		this.b = new HashSet<r0>();
		this.c = new Dictionary<aud, int>();
	}

	// Token: 0x0600177D RID: 6013 RVA: 0x00076FC8 File Offset: 0x000751C8
	public override void akn(cte A_0, ak1 A_1)
	{
		r0 r = new r0(this.a(A_1.Area), new Vector2((float)A_1.Location.X, (float)A_1.Location.Y));
		this.b.Add(r);
	}

	// Token: 0x0600177E RID: 6014 RVA: 0x00077014 File Offset: 0x00075214
	public override void agf(cte A_0, TimeSpan A_1, TimeSpan A_2)
	{
		new bzv(A_0.y6()).a(this.b);
	}

	// Token: 0x0600177F RID: 6015 RVA: 0x00077030 File Offset: 0x00075230
	private int a(aud A_0)
	{
		int num;
		if (!this.c.TryGetValue(A_0, out num))
		{
			num = A_0.c();
			this.c[A_0] = num;
		}
		return num;
	}

	// Token: 0x04000E02 RID: 3586
	public new static readonly string a = "ZoC";

	// Token: 0x04000E03 RID: 3587
	private HashSet<r0> b = new HashSet<r0>();

	// Token: 0x04000E04 RID: 3588
	private Dictionary<aud, int> c = new Dictionary<aud, int>();
}

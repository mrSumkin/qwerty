using System;
using Microsoft.Xna.Framework;

// Token: 0x020005A0 RID: 1440
public sealed class ckj : a9t
{
	// Token: 0x0600263F RID: 9791 RVA: 0x000D8400 File Offset: 0x000D6600
	public ckj()
	{
		this.a();
	}

	// Token: 0x06002640 RID: 9792 RVA: 0x000D8410 File Offset: 0x000D6610
	private void a()
	{
		base.Text = "Диковинки";
		esj esj = a2x.a();
		wj wj = wj.a();
		axd axd;
		if (wj.c())
		{
			esj esj2 = new esj((int)Math.Min(700.0, (double)esj.c * 0.45), (int)((double)esj.d * 0.7));
			if (esj2.d % 2 != 0)
			{
				esj2.d++;
			}
			base.Size = esj2;
			axd = new axd(new esj(base.Size.c - 15, base.Size.d - 40));
			axd.Location = new Point(10, 30);
		}
		else
		{
			esj esj3 = new esj((int)Math.Min((double)wj.d1, (double)esj.c * 0.4), (int)((double)esj.d * 0.7));
			axd = new axd(new esj(esj3.c - 15, esj3.d - wj.ci.d - 15));
			axd.Location = new Point(10, wj.ci.d + 5);
			axd.b();
			esj3 = new esj(axd.Size.c + 15, axd.Size.d + wj.ci.d + 15);
			esj3.d += wj.g - esj3.d % wj.g;
			base.Size = esj3;
		}
		this.aox(axd);
	}
}

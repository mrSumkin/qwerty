using System;
using Microsoft.Xna.Framework;

// Token: 0x02001FE4 RID: 8164
public sealed class c1y : bdl
{
	// Token: 0x0600BFCC RID: 49100 RVA: 0x004274A0 File Offset: 0x004256A0
	public c1y()
	{
		wj wj = wj.a();
		this.a.d = null;
		this.a.r = wj.f;
		this.a.t = wj.bn;
		this.a.s = new esj?(wj.bo);
		this.b.d = null;
		this.b.r = wj.f;
		this.b.t = new Point(wj.bn.X, wj.bn.Y + 2 * wj.bo.d);
		this.b.s = new esj?(wj.bo);
		this.c.d = wj.f;
		this.c.r = null;
		this.c.f = new Point(wj.bn.X, wj.bn.Y + wj.bo.d);
		this.c.e = new esj?(esj.a(wj.bo, 3.0));
		this.d.d = wj.f;
		this.d.r = null;
		this.d.f = new Point(wj.bn.X, wj.bn.Y + 3 * wj.bo.d);
		this.d.e = new esj?(esj.a(wj.bo, 3.0));
		e4z.c(base.d());
		e4z.c(base.e());
		e4z.d(base.h());
	}

	// Token: 0x0600BFCD RID: 49101 RVA: 0x00427670 File Offset: 0x00425870
	protected override void ju()
	{
		this.a.Size = (this.a.s ?? new esj(base.Size.c, base.Size.c));
		this.b.Size = (this.b.s ?? new esj(base.Size.c, base.Size.c));
		this.a.Location = Point.Zero;
		this.b.Location = new Point(0, base.Size.d - this.b.Size.d);
		this.c.Location = new Point(0, this.a.Size.d);
		this.c.Size = new esj(base.Size.c, base.Size.d - this.a.Size.d - this.b.Size.d);
		this.d.Size = this.a.Size;
		int num = this.c.Size.d - this.d.Size.d - 4;
		float num2 = Math.Max(1f, (float)(base.k() - base.j()));
		float num3 = 0f;
		if (num2 > 0f)
		{
			num3 = (float)(base.l() - base.j()) / num2;
		}
		if (!base.g())
		{
			this.d.Location = new Point(0, this.b.Size.d + 2 + (int)(num3 * (float)num));
		}
	}

	// Token: 0x0600BFCE RID: 49102 RVA: 0x00427860 File Offset: 0x00425A60
	public override void ag5(e6d A_0)
	{
		base.ag5(A_0);
		if (base.g())
		{
			Point point = base.at();
			Point point2 = new Point(0, A_0.b().Y - point.Y - this.d.Size.d / 2);
			int num = this.a.Size.d + 2;
			int num2 = base.Size.d - (this.b.Size.d + this.d.Size.d + 2);
			if (point2.Y < num)
			{
				point2.Y = num;
			}
			if (point2.Y > num2)
			{
				point2.Y = num2;
			}
			this.d.Location = point2;
			int num3 = this.c.Size.d - this.d.Size.d - 4;
			int a_ = (int)((float)base.j() + (float)(this.d.Location.Y - num) / (float)num3 * (float)(base.k() - base.j()));
			base.e(a_);
		}
	}
}

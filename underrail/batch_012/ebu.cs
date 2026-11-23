using System;
using Microsoft.Xna.Framework;

// Token: 0x02001FE0 RID: 8160
public sealed class ebu : oz
{
	// Token: 0x0600BFAA RID: 49066 RVA: 0x00426768 File Offset: 0x00424968
	public ebu()
	{
		wj wj = wj.a();
		this.a.d = null;
		this.a.r = wj.f;
		this.a.t = wj.bp;
		this.a.s = new esj?(wj.bq);
		this.a.z = true;
		this.b.d = null;
		this.b.r = wj.f;
		this.b.t = new Point(wj.bp.X + 2 * wj.bq.c, wj.bp.Y);
		this.b.s = new esj?(wj.bq);
		this.b.z = true;
		this.c.d = wj.f;
		this.c.r = null;
		this.c.f = new Point(wj.bp.X + wj.bq.c, wj.bp.Y);
		this.c.e = new esj?(esj.a(wj.bq, 3.0));
		this.c.z = true;
		this.d.d = wj.f;
		this.d.r = null;
		this.d.f = new Point(wj.bp.X + 3 * wj.bq.c, wj.bp.Y);
		this.d.e = new esj?(esj.a(wj.bq, 3.0));
		this.d.z = true;
		e4z.c(base.b());
		e4z.c(base.c());
		e4z.d(base.h());
	}

	// Token: 0x0600BFAB RID: 49067 RVA: 0x00426968 File Offset: 0x00424B68
	protected override void ju()
	{
		this.a.Size = (this.a.s ?? new esj(base.Size.c, base.Size.c));
		this.b.Size = (this.b.s ?? new esj(base.Size.c, base.Size.c));
		this.a.Location = Point.Zero;
		this.b.Location = new Point(base.Size.c - this.b.Size.c, 0);
		this.c.Location = new Point(this.a.Size.c, 0);
		this.c.Size = new esj(base.Size.c - this.a.Size.c - this.b.Size.c, base.Size.d);
		this.d.Size = this.a.Size;
		int num = this.c.Size.c - this.d.Size.c - 4;
		float num2 = Math.Max(1f, (float)(base.k() - base.j()));
		float num3 = 0f;
		if (num2 > 0f)
		{
			num3 = (float)(base.l() - base.j()) / num2;
		}
		if (!base.g())
		{
			this.d.Location = new Point(this.b.Size.c + 2 + (int)(num3 * (float)num), 0);
		}
	}

	// Token: 0x0600BFAC RID: 49068 RVA: 0x00426B58 File Offset: 0x00424D58
	public override void ag5(e6d A_0)
	{
		base.ag5(A_0);
		if (base.g())
		{
			Point point = base.at();
			Point point2 = new Point(A_0.b().X - point.X - this.d.Size.c / 2, 0);
			int num = this.a.Size.c + 2;
			int num2 = base.Size.c - (this.b.Size.c + this.d.Size.c + 2);
			if (point2.X < num)
			{
				point2.X = num;
			}
			if (point2.X > num2)
			{
				point2.X = num2;
			}
			this.d.Location = point2;
			int num3 = this.c.Size.c - 4 - this.d.Size.c;
			int num5;
			if (this.b)
			{
				double num4 = (double)((float)(this.d.Location.X - num) / (float)num3 * (float)(base.k() - base.j()));
				num4 = Math.Round(num4);
				num5 = Convert.ToInt32((double)base.j() + num4);
				num5 = d05.a(base.j(), num5, base.k());
			}
			else
			{
				num5 = (int)((float)base.j() + (float)(this.d.Location.X - num) / (float)num3 * (float)(base.k() - base.j()));
			}
			base.e(num5);
		}
	}
}

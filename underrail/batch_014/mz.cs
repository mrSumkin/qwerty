using System;
using System.Linq;
using Microsoft.Xna.Framework;

// Token: 0x0200205A RID: 8282
public sealed class mz : ec9
{
	// Token: 0x0600C4B7 RID: 50359 RVA: 0x00446814 File Offset: 0x00444A14
	public new int d()
	{
		return this.a;
	}

	// Token: 0x0600C4B8 RID: 50360 RVA: 0x0044681C File Offset: 0x00444A1C
	public void a(int A_0)
	{
		if (this.a != A_0)
		{
			this.a = A_0;
			this.e();
		}
	}

	// Token: 0x0600C4B9 RID: 50361 RVA: 0x00446838 File Offset: 0x00444A38
	public int f()
	{
		return this.b;
	}

	// Token: 0x0600C4BA RID: 50362 RVA: 0x00446840 File Offset: 0x00444A40
	public void b(int A_0)
	{
		if (this.b != A_0)
		{
			this.b = A_0;
			this.e();
		}
	}

	// Token: 0x0600C4BB RID: 50363 RVA: 0x0044685C File Offset: 0x00444A5C
	public ecs g()
	{
		return this.c;
	}

	// Token: 0x0600C4BC RID: 50364 RVA: 0x00446864 File Offset: 0x00444A64
	public void a(ecs A_0)
	{
		this.c = A_0;
		this.e();
	}

	// Token: 0x0600C4BD RID: 50365 RVA: 0x00446874 File Offset: 0x00444A74
	public mz()
	{
		this.c();
	}

	// Token: 0x0600C4BE RID: 50366 RVA: 0x00446898 File Offset: 0x00444A98
	public new void e()
	{
		if (this.c != null)
		{
			this.e = Enumerable.FirstOrDefault<ecs>(this.c.a(base.Size.c - (2 * this.b + this.d.Size.c), 0));
			if (this.e != null)
			{
				if (this.e.a.Count > this.a)
				{
					this.d.Visible = true;
					this.d.a(this.e.a.Count - this.a);
					if (this.d.l() > this.d.k())
					{
						this.d.e(this.d.k());
					}
				}
				else
				{
					this.d.e(0);
					this.d.Visible = false;
				}
			}
		}
		else
		{
			this.d.e(0);
			this.d.Visible = false;
			this.e = null;
		}
		this.a();
	}

	// Token: 0x0600C4BF RID: 50367 RVA: 0x004469B8 File Offset: 0x00444BB8
	public override void iv(e6d A_0, cp9 A_1)
	{
		base.iv(A_0, A_1);
		if (this.f != null)
		{
			Point point = base.at();
			this.f.a(new Point(point.X + this.b, point.Y + this.b), A_1, null, 1f);
		}
	}

	// Token: 0x0600C4C0 RID: 50368 RVA: 0x00446A10 File Offset: 0x00444C10
	private new void c()
	{
		this.d = new se();
		this.d.IsPrivateComponent = true;
		this.d.c(1);
		this.d.d(3);
		this.d.f(new EventHandler<c1>(this.a));
		this.aox(this.d);
	}

	// Token: 0x0600C4C1 RID: 50369 RVA: 0x00446A70 File Offset: 0x00444C70
	private void b()
	{
		this.d.Size = new esj(se.a, base.Size.d - 2 * this.b);
		this.d.Location = new Point(base.Size.c - (this.d.Size.c + this.b), this.b);
	}

	// Token: 0x0600C4C2 RID: 50370 RVA: 0x00446AE0 File Offset: 0x00444CE0
	private void a()
	{
		if (this.e != null)
		{
			ecs ecs;
			if (this.d.k() > 0)
			{
				ecs = new ecs();
				for (int i = 0; i < this.a; i++)
				{
					if (this.d.l() + i >= this.e.a.Count)
					{
						break;
					}
					ecs.a.Add(this.e.a[this.d.l() + i]);
				}
			}
			else
			{
				ecs = this.e;
			}
			this.f = ecs.b();
			return;
		}
		this.f = null;
	}

	// Token: 0x0600C4C3 RID: 50371 RVA: 0x00446B90 File Offset: 0x00444D90
	protected override void jq(object A_0, c1 A_1)
	{
		base.jq(A_0, A_1);
		this.e();
		this.b();
	}

	// Token: 0x0600C4C4 RID: 50372 RVA: 0x00446BA8 File Offset: 0x00444DA8
	private void a(object A_0, c1 A_1)
	{
		this.a();
	}

	// Token: 0x040047BC RID: 18364
	private new int a = 10;

	// Token: 0x040047BD RID: 18365
	private new int b = 10;

	// Token: 0x040047BE RID: 18366
	private new ecs c;

	// Token: 0x040047BF RID: 18367
	private new se d;

	// Token: 0x040047C0 RID: 18368
	private new ecs e;

	// Token: 0x040047C1 RID: 18369
	private new dn3 f;
}

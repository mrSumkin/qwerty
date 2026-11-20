using System;
using Microsoft.Xna.Framework;

// Token: 0x02002033 RID: 8243
public sealed class pz : ec9
{
	// Token: 0x0600C311 RID: 49937 RVA: 0x00437E34 File Offset: 0x00436034
	public new string d()
	{
		return this.d;
	}

	// Token: 0x0600C312 RID: 49938 RVA: 0x00437E3C File Offset: 0x0043603C
	public void a(string A_0)
	{
		if (this.d != A_0)
		{
			this.d = A_0;
			this.a();
		}
	}

	// Token: 0x0600C313 RID: 49939 RVA: 0x00437E5C File Offset: 0x0043605C
	public new Rectangle c()
	{
		return this.e;
	}

	// Token: 0x0600C314 RID: 49940 RVA: 0x00437E64 File Offset: 0x00436064
	public void a(Rectangle A_0)
	{
		if (this.e != A_0)
		{
			this.e = A_0;
			this.a();
		}
	}

	// Token: 0x0600C315 RID: 49941 RVA: 0x00437E84 File Offset: 0x00436084
	public new Point e()
	{
		return this.h;
	}

	// Token: 0x0600C316 RID: 49942 RVA: 0x00437E8C File Offset: 0x0043608C
	public void a(Point A_0)
	{
		if (this.h != A_0)
		{
			this.h = A_0;
			this.a();
		}
	}

	// Token: 0x0600C317 RID: 49943 RVA: 0x00437EAC File Offset: 0x004360AC
	public bool b()
	{
		return this.f;
	}

	// Token: 0x0600C318 RID: 49944 RVA: 0x00437EB4 File Offset: 0x004360B4
	public void a(bool A_0)
	{
		this.f = A_0;
	}

	// Token: 0x0600C319 RID: 49945 RVA: 0x00437EC0 File Offset: 0x004360C0
	public bool f()
	{
		return this.g;
	}

	// Token: 0x0600C31A RID: 49946 RVA: 0x00437ECC File Offset: 0x004360CC
	public pz()
	{
		wj wj = wj.a();
		if (wj.c())
		{
			this.c = bo1.s;
			base.Size = pz.a;
		}
		else
		{
			this.c = wj.f;
			this.e = wj.ca;
			this.d = new esj?(wj.cb);
			base.Size = wj.al;
			this.h = wj.ai;
			this.i = 10;
		}
		this.b = new bg1();
		this.b.IsPrivateComponent = true;
		this.b.Size = new esj(this.e.Width, this.e.Height);
		this.b.Color = adi.a;
		this.aox(this.b);
		this.c = new avo();
		this.c.IsPrivateComponent = true;
		if (wj.c())
		{
			this.c.a(egg.b);
		}
		else
		{
			this.c.a(wj.ah);
		}
		this.c.Color = adi.a;
		this.c.a(cab.a);
		this.c.a(ad4.b);
		this.aox(this.c);
		this.a();
	}

	// Token: 0x0600C31B RID: 49947 RVA: 0x00438060 File Offset: 0x00436260
	private void a()
	{
		if (this.b == null)
		{
			return;
		}
		int y = (base.Size.d - this.e.Height) / 2;
		if (wj.a().c())
		{
			this.b.Location = new Point(this.i, y);
		}
		else
		{
			this.b.Location = new Point(this.e.Width / 2, y);
		}
		this.b.b = this.d;
		this.b.d = new Rectangle?(this.e);
		this.b.Size = new esj(this.e.Width, this.e.Height);
		this.c.Location = new Point(this.b.Location.X + this.b.Size.c + this.h.X, this.h.Y);
		this.c.Size = new esj(base.Size.c - this.c.Location.X, base.Size.d);
		this.c.Text = base.Text;
	}

	// Token: 0x0600C31C RID: 49948 RVA: 0x004381BC File Offset: 0x004363BC
	public override void iv(e6d A_0, cp9 A_1)
	{
		if (this.f)
		{
			d0p.a(A_1, new Color(0, 0, 0, 128), true, true);
		}
		this.g = true;
		base.iv(A_0, A_1);
	}

	// Token: 0x0600C31D RID: 49949 RVA: 0x004381F0 File Offset: 0x004363F0
	protected override void jq(object A_0, c1 A_1)
	{
		base.jq(A_0, A_1);
		this.a();
	}

	// Token: 0x0600C31E RID: 49950 RVA: 0x00438200 File Offset: 0x00436400
	protected override void j5(object A_0, c1 A_1)
	{
		base.j5(A_0, A_1);
		this.a();
	}

	// Token: 0x040046C7 RID: 18119
	private new static readonly esj a = new esj(300, 50);

	// Token: 0x040046C8 RID: 18120
	private new bg1 b;

	// Token: 0x040046C9 RID: 18121
	private new avo c;

	// Token: 0x040046CA RID: 18122
	private new string d;

	// Token: 0x040046CB RID: 18123
	private new Rectangle e = new Rectangle(0, 0, 40, 40);

	// Token: 0x040046CC RID: 18124
	private new bool f = true;

	// Token: 0x040046CD RID: 18125
	private new bool g;

	// Token: 0x040046CE RID: 18126
	private Point h = new Point(15, 6);

	// Token: 0x040046CF RID: 18127
	private int i = 5;
}

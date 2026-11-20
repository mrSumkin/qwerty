using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;

// Token: 0x02001FF8 RID: 8184
public class a1r : dak
{
	// Token: 0x0600C0E9 RID: 49385 RVA: 0x0042D71C File Offset: 0x0042B91C
	public override bool et()
	{
		return base.IsMousedOver || (this.c != null && this.c.IsMousedOver);
	}

	// Token: 0x0600C0EA RID: 49386 RVA: 0x0042D744 File Offset: 0x0042B944
	public new ecs g()
	{
		return this.a;
	}

	// Token: 0x0600C0EB RID: 49387 RVA: 0x0042D74C File Offset: 0x0042B94C
	public void a(ecs A_0)
	{
		if (this.a != A_0)
		{
			this.a = A_0;
			this.f = this.a();
			this.b();
		}
	}

	// Token: 0x0600C0EC RID: 49388 RVA: 0x0042D774 File Offset: 0x0042B974
	public new string e()
	{
		return this.b;
	}

	// Token: 0x0600C0ED RID: 49389 RVA: 0x0042D77C File Offset: 0x0042B97C
	public void a(string A_0)
	{
		if (this.e() != A_0)
		{
			this.b = A_0;
			this.b();
		}
	}

	// Token: 0x0600C0EE RID: 49390 RVA: 0x0042D79C File Offset: 0x0042B99C
	public new int d()
	{
		return this.e;
	}

	// Token: 0x0600C0EF RID: 49391 RVA: 0x0042D7A4 File Offset: 0x0042B9A4
	public void a(int A_0)
	{
		this.e = A_0;
	}

	// Token: 0x0600C0F0 RID: 49392 RVA: 0x0042D7B0 File Offset: 0x0042B9B0
	public new Point f()
	{
		return this.d;
	}

	// Token: 0x0600C0F1 RID: 49393 RVA: 0x0042D7B8 File Offset: 0x0042B9B8
	public void a(Point A_0)
	{
		if (this.d != A_0)
		{
			this.d = A_0;
			this.b();
		}
	}

	// Token: 0x0600C0F2 RID: 49394 RVA: 0x0042D7DC File Offset: 0x0042B9DC
	public a1r(string A_0, string A_1, int A_2, int A_3, ecs A_4, Point A_5)
	{
		this.b = A_1;
		this.d = A_5;
		this.a = A_4;
		this.f = this.a();
		base.Size = new esj(A_2, A_3);
		this.d = A_0;
		this.c();
	}

	// Token: 0x0600C0F3 RID: 49395 RVA: 0x0042D838 File Offset: 0x0042BA38
	public a1r() : this(bo1.z, "p1", 300, 50, new ecs(), new Point(5, 5))
	{
	}

	// Token: 0x0600C0F4 RID: 49396 RVA: 0x0042D868 File Offset: 0x0042BA68
	private void c()
	{
		this.c = new apw(bd8.a);
		this.c.Location = this.d;
		this.c.a(this.b);
		this.c.IsPrivateComponent = true;
		this.c.a(false);
		this.aox(this.c);
		this.b();
	}

	// Token: 0x0600C0F5 RID: 49397 RVA: 0x0042D8D0 File Offset: 0x0042BAD0
	private void b()
	{
		this.c.a(this.b);
		this.c.Location = this.d;
	}

	// Token: 0x0600C0F6 RID: 49398 RVA: 0x0042D8F8 File Offset: 0x0042BAF8
	private dn3 a()
	{
		dn3 result = null;
		if (this.a != null)
		{
			List<ecs> list = this.a.a(base.Size.c, 0);
			if (list != null && list.Count > 0)
			{
				result = list[0].b();
			}
		}
		return result;
	}

	// Token: 0x0600C0F7 RID: 49399 RVA: 0x0042D94C File Offset: 0x0042BB4C
	public override void iv(e6d A_0, cp9 A_1)
	{
		base.iv(A_0, A_1);
		if (this.f != null)
		{
			Point point = base.at();
			this.f.a(new Point(point.X + this.c.Location.X + this.c.Size.c + this.e, point.Y + this.c.Location.Y + 10), A_1, null, 1f);
		}
	}

	// Token: 0x040045BD RID: 17853
	private new ecs a;

	// Token: 0x040045BE RID: 17854
	private new string b = "p1";

	// Token: 0x040045BF RID: 17855
	private new apw c;

	// Token: 0x040045C0 RID: 17856
	private new Point d;

	// Token: 0x040045C1 RID: 17857
	private new int e;

	// Token: 0x040045C2 RID: 17858
	private new dn3 f;
}

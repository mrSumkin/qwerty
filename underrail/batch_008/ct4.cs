using System;
using Microsoft.Xna.Framework;

// Token: 0x0200203A RID: 8250
public sealed class ct4 : au6
{
	// Token: 0x0600C37F RID: 50047 RVA: 0x0043AA98 File Offset: 0x00438C98
	public cwp d()
	{
		return this.c;
	}

	// Token: 0x0600C380 RID: 50048 RVA: 0x0043AAA0 File Offset: 0x00438CA0
	public void a(cwp A_0)
	{
		this.c = A_0;
		this.a();
	}

	// Token: 0x0600C381 RID: 50049 RVA: 0x0043AAB0 File Offset: 0x00438CB0
	public ct4()
	{
		this.c();
	}

	// Token: 0x0600C382 RID: 50050 RVA: 0x0043AAC0 File Offset: 0x00438CC0
	public override void ag5(e6d A_0)
	{
		if (this.a != null)
		{
			this.a.a(cq4.d());
		}
		if (this.b != null)
		{
			this.b.a(cq4.c());
		}
		base.ag5(A_0);
	}

	// Token: 0x0600C383 RID: 50051 RVA: 0x0043AB00 File Offset: 0x00438D00
	private void c()
	{
		wj wj = wj.a();
		if (wj.c())
		{
			base.b(bo1.t);
		}
		else
		{
			base.b(wj.f);
			this.n = wj.d5;
			this.o = new esj?(wj.d6);
		}
		this.Focusable = false;
		this.a = new avo();
		this.a.a(cq4.d());
		this.a.Location = new Point(15, 15);
		this.a.a(cab.a);
		this.a.a(ad4.a);
		this.a.IsPrivateComponent = true;
		this.b = new avo();
		this.b.a(cq4.c());
		this.b.Color = adi.a;
		this.b.Location = new Point(15, 50);
		this.b.a(cab.a);
		this.b.a(ad4.a);
		this.b.IsPrivateComponent = true;
		this.aox(this.a);
		this.aox(this.b);
		this.b();
		this.a();
	}

	// Token: 0x0600C384 RID: 50052 RVA: 0x0043AC3C File Offset: 0x00438E3C
	private void b()
	{
		if (this.a != null)
		{
			this.a.Size = new esj(base.Size.c - 2 * this.b.Location.X, 30);
		}
		if (this.b != null)
		{
			this.b.Size = new esj(base.Size.c - 2 * this.b.Location.X, base.Size.d - base.Location.Y);
		}
	}

	// Token: 0x0600C385 RID: 50053 RVA: 0x0043ACD4 File Offset: 0x00438ED4
	private void a()
	{
		if (this.c == null)
		{
			this.a.Text = "";
			this.b.Text = "";
			return;
		}
		this.a.Text = this.c.LocalizedName;
		try
		{
			this.b.Text = this.c.xi();
		}
		catch
		{
			this.b.Text = "<Произошла ошибка>";
			throw;
		}
	}

	// Token: 0x0600C386 RID: 50054 RVA: 0x0043AD64 File Offset: 0x00438F64
	protected override void jq(object A_0, c1 A_1)
	{
		base.jq(A_0, A_1);
		this.b();
	}

	// Token: 0x040046FE RID: 18174
	private new avo a;

	// Token: 0x040046FF RID: 18175
	private new avo b;

	// Token: 0x04004700 RID: 18176
	private new cwp c;
}

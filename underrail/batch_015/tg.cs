using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;

// Token: 0x0200205E RID: 8286
public sealed class tg : ec9
{
	// Token: 0x0600C4E8 RID: 50408 RVA: 0x00448230 File Offset: 0x00446430
	public int g()
	{
		return this.g;
	}

	// Token: 0x0600C4E9 RID: 50409 RVA: 0x00448238 File Offset: 0x00446438
	public new int e()
	{
		return this.g - this.d.l();
	}

	// Token: 0x0600C4EA RID: 50410 RVA: 0x0044824C File Offset: 0x0044644C
	public int f()
	{
		return this.d.l();
	}

	// Token: 0x0600C4EB RID: 50411 RVA: 0x0044825C File Offset: 0x0044645C
	[CompilerGenerated]
	public new void c(EventHandler<EventArgs> A_0)
	{
		EventHandler<EventArgs> eventHandler = this.j;
		EventHandler<EventArgs> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<EventArgs> value = (EventHandler<EventArgs>)Delegate.Combine(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler<EventArgs>>(ref this.j, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x0600C4EC RID: 50412 RVA: 0x00448294 File Offset: 0x00446494
	[CompilerGenerated]
	public void a(EventHandler<EventArgs> A_0)
	{
		EventHandler<EventArgs> eventHandler = this.j;
		EventHandler<EventArgs> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<EventArgs> value = (EventHandler<EventArgs>)Delegate.Remove(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler<EventArgs>>(ref this.j, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x0600C4ED RID: 50413 RVA: 0x004482CC File Offset: 0x004464CC
	[CompilerGenerated]
	public void b(EventHandler<EventArgs> A_0)
	{
		EventHandler<EventArgs> eventHandler = this.k;
		EventHandler<EventArgs> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<EventArgs> value = (EventHandler<EventArgs>)Delegate.Combine(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler<EventArgs>>(ref this.k, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x0600C4EE RID: 50414 RVA: 0x00448304 File Offset: 0x00446504
	[CompilerGenerated]
	public new void d(EventHandler<EventArgs> A_0)
	{
		EventHandler<EventArgs> eventHandler = this.k;
		EventHandler<EventArgs> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<EventArgs> value = (EventHandler<EventArgs>)Delegate.Remove(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler<EventArgs>>(ref this.k, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x0600C4EF RID: 50415 RVA: 0x0044833C File Offset: 0x0044653C
	public tg(int A_0)
	{
		this.Focusable = true;
		this.g = A_0;
		this.d();
	}

	// Token: 0x0600C4F0 RID: 50416 RVA: 0x00448360 File Offset: 0x00446560
	private new void d()
	{
		wj wj = wj.a();
		this.Focusable = true;
		if (wj.c())
		{
			this.c = bo1.q;
			base.Size = new esj(320, 56);
		}
		else
		{
			this.a = wj.ii;
			this.c = wj.f;
			this.e = wj.il;
			this.d = new esj?(wj.im);
			base.Size = wj.ih;
			base.Color = Color.White * 0.9f;
		}
		this.e = new zt();
		if (wj.c())
		{
			this.e.Size = new esj(110, 18);
			this.e.Location = new Point(this.a, 30);
			this.e.Font = (egg.v ? egg.n : egg.ad);
		}
		else
		{
			this.e.Size = new esj((base.Size.c - 3 * this.a) / 2, wj.ik);
			this.e.Location = new Point(this.a, base.Size.d - this.e.Size.d - this.a);
			this.e.Font = wj.ij;
		}
		this.e.TextLabelOffset = new Point(0, egg.b(this.e.Font));
		this.e.IsPrivateComponent = true;
		this.e.Text = "Разделить";
		this.e.c(new EventHandler<b25>(this.a));
		this.aox(this.e);
		this.f = new zt();
		if (wj.c())
		{
			this.f.Size = new esj(110, 18);
			this.f.Location = new Point(base.Size.c - (this.a + this.f.Size.c), 30);
			this.f.Font = (egg.v ? egg.n : egg.ad);
		}
		else
		{
			this.f.Size = this.e.Size;
			this.f.Location = new Point(base.Size.c - this.f.Size.c - this.a, base.Size.d - this.f.Size.d - this.a);
			this.f.Font = wj.ij;
		}
		this.f.TextLabelOffset = new Point(0, egg.b(this.e.Font));
		this.f.IsPrivateComponent = true;
		this.f.Text = "Отмена";
		this.f.c(new EventHandler<b25>(this.b));
		this.aox(this.f);
		this.b = new avo();
		if (wj.c())
		{
			this.b.Location = new Point(this.a * 2, this.a);
			this.b.Size = new esj(75, 25);
			this.b.a(egg.n);
			this.b.Location = new Point(this.b.Location.X, this.b.Location.Y + egg.b(this.b.g()));
		}
		else
		{
			this.b.a(wj.ij);
			this.b.Size = new esj(base.Size.c / 6, base.Size.d - 3 * this.a - this.e.Size.d);
			int num = (base.Size.d - this.e.Size.d - this.a - this.b.Size.d) / 2;
			this.b.Location = new Point(this.b.Location.X, num + egg.b(this.b.g()));
		}
		this.b.IsPrivateComponent = true;
		this.b.a(cab.c);
		this.aox(this.b);
		this.c = new c68();
		if (wj.c())
		{
			this.c.Size = new esj(80, 25);
			this.c.Location = new Point(base.Size.c - (this.a * 2 + this.c.Size.c), this.a);
			this.c.a(egg.n);
			this.c.e = bo1.b;
			this.c.a(new Point(5, 0));
		}
		else
		{
			this.c.Size = new esj(base.Size.c / 6, base.Size.d - 3 * this.a - this.e.Size.d);
			this.c.Location = new Point(base.Size.c - (this.a * 2 + this.c.Size.c), this.a);
			this.c.a(this.b.g());
			this.c.a(new Point(5, egg.b(this.c.c())));
			this.c.e = wj.f;
			this.c.f = wj.fg;
			this.c.g = new esj?(wj.fh);
		}
		this.c.b = Color.Gray;
		this.c.b(9);
		c68 c = this.c;
		c.h = (Func<object, Keys, List<Keys>, bool, bool>)Delegate.Combine(c.h, new Func<object, Keys, List<Keys>, bool, bool>(this.a));
		this.c.o(new EventHandler<c1>(this.a));
		this.c.e(new EventHandler(this.a));
		this.aox(this.c);
		if (wj.c())
		{
			this.d = new c8b();
			this.d.Location = new Point(this.b.Location.X + this.b.Size.c + 5, this.a);
			this.d.Size = new esj(this.c.Location.X - this.d.Location.X, 27);
		}
		else
		{
			this.d = new ebu();
			this.d.Location = new Point(this.b.Location.X + this.b.Size.c + this.a, (base.Size.d - this.a - this.e.Size.d - wj.bq.d) / 2);
			this.d.Size = new esj(this.c.Location.X - this.d.Location.X - this.a, wj.bq.d);
		}
		this.d.b(1);
		this.d.a(this.g - 1);
		this.d.e((this.d.j() + this.d.k()) / 2);
		this.d.IsPrivateComponent = true;
		this.d.f(new EventHandler<c1>(this.b));
		this.aox(this.d);
		this.c();
	}

	// Token: 0x0600C4F1 RID: 50417 RVA: 0x00448BE4 File Offset: 0x00446DE4
	public override void iv(e6d A_0, cp9 A_1)
	{
		d0p.a(A_1, Color.Black * 0.75f, true, false);
		base.iv(A_0, A_1);
	}

	// Token: 0x0600C4F2 RID: 50418 RVA: 0x00448C08 File Offset: 0x00446E08
	public override void ag5(e6d A_0)
	{
		base.ag5(A_0);
		this.c.b = (this.i ? Color.White : Color.LightGreen);
		if (!this.h && !this.c.IsFocus && !bl9.a(this.c))
		{
			this.c.a9();
		}
	}

	// Token: 0x0600C4F3 RID: 50419 RVA: 0x00448C78 File Offset: 0x00446E78
	private new void c()
	{
		this.b.Text = this.e().ToString();
		this.c.Text = this.f().ToString();
	}

	// Token: 0x0600C4F4 RID: 50420 RVA: 0x00448CB8 File Offset: 0x00446EB8
	private void b()
	{
		this.h = true;
		base.z();
		if (this.j != null)
		{
			this.j(this, new EventArgs());
		}
	}

	// Token: 0x0600C4F5 RID: 50421 RVA: 0x00448CE4 File Offset: 0x00446EE4
	private void a()
	{
		this.h = true;
		base.z();
		if (this.k != null)
		{
			this.k(this, new EventArgs());
		}
	}

	// Token: 0x0600C4F6 RID: 50422 RVA: 0x00448D14 File Offset: 0x00446F14
	private bool a(object A_0, Keys A_1, List<Keys> A_2, bool A_3)
	{
		if (A_1 != Keys.Back && A_1 != Keys.Delete && (A_1 < Keys.D0 || A_1 > Keys.D9) && (A_1 < Keys.NumPad0 || A_1 > Keys.NumPad9))
		{
			if (A_1 == Keys.Escape)
			{
				this.a();
			}
			else if (A_1 == Keys.Enter)
			{
				this.b();
			}
			this.i = true;
			return true;
		}
		if (!this.i && ((A_1 >= Keys.D0 && A_1 <= Keys.D9) || (A_1 >= Keys.NumPad0 && A_1 <= Keys.NumPad9)))
		{
			this.i = true;
			this.c.Text = "";
			return false;
		}
		this.i = true;
		return false;
	}

	// Token: 0x0600C4F7 RID: 50423 RVA: 0x00448DC8 File Offset: 0x00446FC8
	protected override void g6(object A_0, ane A_1)
	{
		base.g6(A_0, A_1);
		if (A_1.a == Keys.Escape)
		{
			this.a();
			return;
		}
		if (A_1.a == Keys.Enter)
		{
			this.b();
		}
	}

	// Token: 0x0600C4F8 RID: 50424 RVA: 0x00448DFC File Offset: 0x00446FFC
	private void b(object A_0, b25 A_1)
	{
		this.a();
	}

	// Token: 0x0600C4F9 RID: 50425 RVA: 0x00448E04 File Offset: 0x00447004
	private void a(object A_0, b25 A_1)
	{
		this.b();
	}

	// Token: 0x0600C4FA RID: 50426 RVA: 0x00448E0C File Offset: 0x0044700C
	private void b(object A_0, c1 A_1)
	{
		this.i = true;
		this.c();
	}

	// Token: 0x0600C4FB RID: 50427 RVA: 0x00448E20 File Offset: 0x00447020
	private void a(object A_0, c1 A_1)
	{
		int a_;
		if (int.TryParse(this.c.Text, out a_))
		{
			int num = d05.a(this.d.j(), a_, this.d.k());
			if (this.d.l() != num)
			{
				this.d.e(num);
			}
		}
	}

	// Token: 0x0600C4FC RID: 50428 RVA: 0x00448E80 File Offset: 0x00447080
	private void a(object A_0, EventArgs A_1)
	{
		bl9.a(this.c, aqo.b, null);
	}

	// Token: 0x040047E6 RID: 18406
	private new int a = 5;

	// Token: 0x040047E7 RID: 18407
	private new avo b;

	// Token: 0x040047E8 RID: 18408
	private new c68 c;

	// Token: 0x040047E9 RID: 18409
	private new oz d;

	// Token: 0x040047EA RID: 18410
	private new zt e;

	// Token: 0x040047EB RID: 18411
	private new zt f;

	// Token: 0x040047EC RID: 18412
	private new int g;

	// Token: 0x040047ED RID: 18413
	private bool h;

	// Token: 0x040047EE RID: 18414
	private bool i;

	// Token: 0x040047EF RID: 18415
	[CompilerGenerated]
	private new EventHandler<EventArgs> j;

	// Token: 0x040047F0 RID: 18416
	[CompilerGenerated]
	private new EventHandler<EventArgs> k;
}

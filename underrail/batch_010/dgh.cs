using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using Microsoft.Xna.Framework;
using TimelapseVertigo.Rules.Characters;

// Token: 0x02002051 RID: 8273
public sealed class dgh : euz
{
	// Token: 0x0600C445 RID: 50245 RVA: 0x00442238 File Offset: 0x00440438
	public string e()
	{
		return this.g;
	}

	// Token: 0x0600C446 RID: 50246 RVA: 0x00442240 File Offset: 0x00440440
	public void a(string A_0)
	{
		string a_ = this.g;
		this.g = A_0;
		if (a_ != A_0)
		{
			if (this.a != null)
			{
				this.a.a(A_0);
			}
			if (this.j != null)
			{
				this.j(this, new c1(a_, A_0));
			}
		}
	}

	// Token: 0x0600C447 RID: 50247 RVA: 0x0044229C File Offset: 0x0044049C
	public Gender f()
	{
		return this.f;
	}

	// Token: 0x0600C448 RID: 50248 RVA: 0x004422A4 File Offset: 0x004404A4
	public void b(Gender A_0)
	{
		this.f = A_0;
	}

	// Token: 0x0600C449 RID: 50249 RVA: 0x004422B0 File Offset: 0x004404B0
	public bool g()
	{
		return this.h;
	}

	// Token: 0x0600C44A RID: 50250 RVA: 0x004422B8 File Offset: 0x004404B8
	public void a(bool A_0)
	{
		if (this.h != A_0)
		{
			this.h = A_0;
			this.b();
		}
	}

	// Token: 0x0600C44B RID: 50251 RVA: 0x004422D4 File Offset: 0x004404D4
	[CompilerGenerated]
	public void b(EventHandler<c1> A_0)
	{
		EventHandler<c1> eventHandler = this.j;
		EventHandler<c1> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<c1> value = (EventHandler<c1>)Delegate.Combine(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler<c1>>(ref this.j, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x0600C44C RID: 50252 RVA: 0x0044230C File Offset: 0x0044050C
	[CompilerGenerated]
	public void a(EventHandler<c1> A_0)
	{
		EventHandler<c1> eventHandler = this.j;
		EventHandler<c1> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<c1> value = (EventHandler<c1>)Delegate.Remove(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler<c1>>(ref this.j, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x0600C44D RID: 50253 RVA: 0x00442344 File Offset: 0x00440544
	public dgh()
	{
		this.d();
	}

	// Token: 0x0600C44E RID: 50254 RVA: 0x00442354 File Offset: 0x00440554
	protected override void jq(object A_0, c1 A_1)
	{
		base.jq(A_0, A_1);
		this.b();
	}

	// Token: 0x0600C44F RID: 50255 RVA: 0x00442368 File Offset: 0x00440568
	private void d()
	{
		wj wj = wj.a();
		this.c();
		this.b();
		this.a(Gender.Male);
		if (!wj.c())
		{
			base.Size = new esj(this.a.Size.c + wj.f6 + wj.gx.c, this.a.Size.d + wj.f6 + wj.gz.d);
		}
	}

	// Token: 0x0600C450 RID: 50256 RVA: 0x004423EC File Offset: 0x004405EC
	private void c()
	{
		wj wj = wj.a();
		if (wj.c())
		{
			this.a = new apw(bd8.b);
		}
		else
		{
			this.a = new apw((bd8)wj.f2);
		}
		this.a.b("Default");
		this.a.IsPrivateComponent = true;
		this.b = new aqw();
		this.b.IsPrivateComponent = true;
		if (wj.c())
		{
			this.b.a = bo1.a7;
			this.b.c = new esj(36, 37);
			this.b.b = new Point(0, 0);
		}
		else
		{
			this.b.a = wj.f;
			this.b.b = wj.gw;
			this.b.c = wj.gx;
		}
		this.b.Size = this.b.c;
		this.b.p(new EventHandler<b25>(this.c));
		e4z.f(this.b);
		this.c = new aqw();
		this.c.IsPrivateComponent = true;
		if (wj.c())
		{
			this.c.a = bo1.a7;
			this.c.c = new esj(36, 37);
			this.c.b = new Point(0, this.c.c.d);
		}
		else
		{
			this.c.a = wj.f;
			this.c.b = new Point(wj.gw.X, wj.gw.Y + wj.gx.d);
			this.c.c = wj.gx;
		}
		this.c.Size = this.c.c;
		this.c.p(new EventHandler<b25>(this.d));
		e4z.f(this.c);
		this.d = new aqw();
		this.d.IsPrivateComponent = true;
		if (wj.c())
		{
			this.d.a = bo1.a6;
		}
		else
		{
			this.d.a = wj.f;
			this.d.b = wj.gy;
			this.d.c = wj.gz;
		}
		this.d.Size = this.d.c;
		this.d.b = new Point(this.d.b.X, this.d.b.Y + this.d.c.d * 2);
		this.d.p(new EventHandler<b25>(this.a));
		e4z.f(this.d);
		this.e = new aqw();
		this.e.IsPrivateComponent = true;
		if (wj.c())
		{
			this.e.a = bo1.a6;
		}
		else
		{
			this.e.a = wj.f;
			this.e.b = wj.gy;
			this.e.c = wj.gz;
		}
		this.e.Size = this.e.c;
		this.e.b = new Point(this.e.b.X, this.e.b.Y + this.e.c.d * 3);
		this.e.p(new EventHandler<b25>(this.b));
		e4z.f(this.e);
		this.aox(this.a);
		this.aox(this.b);
		this.aox(this.c);
		this.aox(this.d);
		this.aox(this.e);
	}

	// Token: 0x0600C451 RID: 50257 RVA: 0x00442814 File Offset: 0x00440A14
	private void b()
	{
		wj wj = wj.a();
		if (wj.c())
		{
			if (this.a != null)
			{
				this.a.Location = new Point(this.h ? ((base.Size.c - this.a.Size.c) / 2) : 0, base.Size.d / 2 - this.a.Size.d / 2);
			}
			if (this.b != null)
			{
				this.b.Visible = !this.h;
				this.b.Location = new Point(this.a.Location.X + this.a.Size.c + 10, this.a.Location.Y + 15);
			}
			if (this.c != null)
			{
				this.c.Visible = !this.h;
				this.c.Location = new Point(this.a.Location.X + this.a.Size.c + 10, this.a.Location.Y + this.a.Size.d - this.c.Size.d - 15);
			}
			if (this.d != null)
			{
				this.d.Visible = !this.h;
				this.d.Location = new Point(this.a.Location.X + 15, this.a.Location.Y + this.a.Size.d + 5);
			}
			if (this.e != null)
			{
				this.e.Visible = !this.h;
				this.e.Location = new Point(this.a.Location.X + this.a.Size.c - this.e.Size.c - 15, this.d.Location.Y);
				return;
			}
		}
		else
		{
			if (this.a == null)
			{
				return;
			}
			this.b.Visible = (this.c.Visible = (this.d.Visible = (this.e.Visible = !this.h)));
			this.a.Location = new Point(0, 0);
			this.b.Location = new Point(this.a.Location.X + this.a.Size.c + wj.f6, this.a.Location.Y + this.a.Size.d / 2 - (int)((float)this.b.Size.d * 1.15f));
			this.c.Location = new Point(this.b.Location.X, this.b.Location.Y + (int)((float)this.b.Size.d * 1.3f));
			this.d.Location = new Point(this.a.Location.X + this.a.Size.c / 2 - (int)((float)this.d.Size.c * 1.25f), this.a.Location.Y + this.a.Size.d + wj.f6);
			this.e.Location = new Point(this.d.Location.X + (int)((float)this.d.Size.c * 1.5f), this.d.Location.Y);
		}
	}

	// Token: 0x0600C452 RID: 50258 RVA: 0x00442C3C File Offset: 0x00440E3C
	private void a(Gender A_0)
	{
		this.c.Checked = (A_0 == Gender.Female);
		this.b.Checked = (A_0 == Gender.Male);
		this.f = A_0;
		this.a();
	}

	// Token: 0x0600C453 RID: 50259 RVA: 0x00442C6C File Offset: 0x00440E6C
	private void a()
	{
		List<dxs> list;
		if (this.f == Gender.Male)
		{
			list = d37.e();
		}
		else
		{
			list = d37.d();
		}
		if (this.i < 0)
		{
			this.i = list.Count - 1;
		}
		else if (this.i >= list.Count)
		{
			this.i = 0;
		}
		if (this.i >= 0 && this.i < list.Count)
		{
			dxs dxs = list[this.i];
			this.a(dxs.c);
			return;
		}
		this.a(null);
	}

	// Token: 0x0600C454 RID: 50260 RVA: 0x00442D0C File Offset: 0x00440F0C
	private void d(object A_0, b25 A_1)
	{
		this.a(Gender.Female);
	}

	// Token: 0x0600C455 RID: 50261 RVA: 0x00442D18 File Offset: 0x00440F18
	private void c(object A_0, b25 A_1)
	{
		this.a(Gender.Male);
	}

	// Token: 0x0600C456 RID: 50262 RVA: 0x00442D24 File Offset: 0x00440F24
	private void b(object A_0, b25 A_1)
	{
		this.i++;
		this.a();
	}

	// Token: 0x0600C457 RID: 50263 RVA: 0x00442D3C File Offset: 0x00440F3C
	private void a(object A_0, b25 A_1)
	{
		this.i--;
		this.a();
	}

	// Token: 0x04004789 RID: 18313
	private new apw a;

	// Token: 0x0400478A RID: 18314
	private new aqw b;

	// Token: 0x0400478B RID: 18315
	private new aqw c;

	// Token: 0x0400478C RID: 18316
	private new aqw d;

	// Token: 0x0400478D RID: 18317
	private new aqw e;

	// Token: 0x0400478E RID: 18318
	private new Gender f;

	// Token: 0x0400478F RID: 18319
	private new string g;

	// Token: 0x04004790 RID: 18320
	private bool h;

	// Token: 0x04004791 RID: 18321
	private int i;

	// Token: 0x04004792 RID: 18322
	[CompilerGenerated]
	private new EventHandler<c1> j;
}

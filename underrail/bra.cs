using System;
using System.Runtime.CompilerServices;
using System.Threading;
using Microsoft.Xna.Framework;

// Token: 0x0200017A RID: 378
public abstract class bra : amm, abp
{
	// Token: 0x060009E4 RID: 2532 RVA: 0x00028C54 File Offset: 0x00026E54
	public Point aae()
	{
		return this.a;
	}

	// Token: 0x060009E5 RID: 2533 RVA: 0x00028C5C File Offset: 0x00026E5C
	public void a(Point A_0)
	{
		if (A_0 != this.a)
		{
			object a_ = this.a;
			this.a = A_0;
			if (this.e != null)
			{
				this.e(this, new c1(a_, A_0));
			}
		}
	}

	// Token: 0x060009E6 RID: 2534 RVA: 0x00028CB0 File Offset: 0x00026EB0
	public esj q()
	{
		return this.b;
	}

	// Token: 0x060009E7 RID: 2535 RVA: 0x00028CB8 File Offset: 0x00026EB8
	protected void c(esj A_0)
	{
		if (esj.c(A_0, this.b))
		{
			object a_ = this.b;
			this.b = A_0;
			if (this.h != null)
			{
				this.h(this, new c1(a_, A_0));
			}
		}
	}

	// Token: 0x060009E8 RID: 2536 RVA: 0x00028D0C File Offset: 0x00026F0C
	public esj o()
	{
		return this.c;
	}

	// Token: 0x060009E9 RID: 2537 RVA: 0x00028D14 File Offset: 0x00026F14
	public void b(esj A_0)
	{
		if (esj.c(A_0, this.c))
		{
			object a_ = this.c;
			this.c = A_0;
			if (this.f != null)
			{
				this.f(this, new c1(a_, A_0));
			}
		}
	}

	// Token: 0x060009EA RID: 2538 RVA: 0x00028D68 File Offset: 0x00026F68
	public bool r()
	{
		return this.d;
	}

	// Token: 0x060009EB RID: 2539 RVA: 0x00028D70 File Offset: 0x00026F70
	public void d(bool A_0)
	{
		if (A_0 != this.d)
		{
			object a_ = this.d;
			this.d = A_0;
			if (this.g != null)
			{
				this.g(this, new c1(a_, A_0));
			}
		}
	}

	// Token: 0x060009EC RID: 2540 RVA: 0x00028DC0 File Offset: 0x00026FC0
	protected bra()
	{
		this.f(new EventHandler<c1>(this.h));
		this.g(new EventHandler<c1>(this.f));
		this.h(new EventHandler<c1>(this.i));
		this.l(new EventHandler<c1>(this.sm));
	}

	// Token: 0x060009ED RID: 2541 RVA: 0x00028E28 File Offset: 0x00027028
	[CompilerGenerated]
	public void f(EventHandler<c1> A_0)
	{
		EventHandler<c1> eventHandler = this.e;
		EventHandler<c1> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<c1> value = (EventHandler<c1>)Delegate.Combine(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler<c1>>(ref this.e, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x060009EE RID: 2542 RVA: 0x00028E60 File Offset: 0x00027060
	[CompilerGenerated]
	public void i(EventHandler<c1> A_0)
	{
		EventHandler<c1> eventHandler = this.e;
		EventHandler<c1> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<c1> value = (EventHandler<c1>)Delegate.Remove(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler<c1>>(ref this.e, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x060009EF RID: 2543 RVA: 0x00028E98 File Offset: 0x00027098
	[CompilerGenerated]
	public void g(EventHandler<c1> A_0)
	{
		EventHandler<c1> eventHandler = this.f;
		EventHandler<c1> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<c1> value = (EventHandler<c1>)Delegate.Combine(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler<c1>>(ref this.f, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x060009F0 RID: 2544 RVA: 0x00028ED0 File Offset: 0x000270D0
	[CompilerGenerated]
	public void j(EventHandler<c1> A_0)
	{
		EventHandler<c1> eventHandler = this.f;
		EventHandler<c1> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<c1> value = (EventHandler<c1>)Delegate.Remove(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler<c1>>(ref this.f, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x060009F1 RID: 2545 RVA: 0x00028F08 File Offset: 0x00027108
	[CompilerGenerated]
	public void h(EventHandler<c1> A_0)
	{
		EventHandler<c1> eventHandler = this.g;
		EventHandler<c1> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<c1> value = (EventHandler<c1>)Delegate.Combine(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler<c1>>(ref this.g, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x060009F2 RID: 2546 RVA: 0x00028F40 File Offset: 0x00027140
	[CompilerGenerated]
	public void e(EventHandler<c1> A_0)
	{
		EventHandler<c1> eventHandler = this.g;
		EventHandler<c1> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<c1> value = (EventHandler<c1>)Delegate.Remove(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler<c1>>(ref this.g, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x060009F3 RID: 2547 RVA: 0x00028F78 File Offset: 0x00027178
	[CompilerGenerated]
	public void l(EventHandler<c1> A_0)
	{
		EventHandler<c1> eventHandler = this.h;
		EventHandler<c1> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<c1> value = (EventHandler<c1>)Delegate.Combine(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler<c1>>(ref this.h, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x060009F4 RID: 2548 RVA: 0x00028FB0 File Offset: 0x000271B0
	[CompilerGenerated]
	public void k(EventHandler<c1> A_0)
	{
		EventHandler<c1> eventHandler = this.h;
		EventHandler<c1> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<c1> value = (EventHandler<c1>)Delegate.Remove(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler<c1>>(ref this.h, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x060009F5 RID: 2549 RVA: 0x00028FE8 File Offset: 0x000271E8
	protected virtual void h(object A_0, c1 A_1)
	{
		base.e("ViewpointChanged");
	}

	// Token: 0x060009F6 RID: 2550 RVA: 0x00028FF8 File Offset: 0x000271F8
	protected virtual void f(object A_0, c1 A_1)
	{
		base.e("TotalSizeChanged");
		this.c(esj.b(this.o(), base.Size).c());
	}

	// Token: 0x060009F7 RID: 2551 RVA: 0x00029030 File Offset: 0x00027230
	protected override void jq(object A_0, c1 A_1)
	{
		base.jq(A_0, A_1);
		this.c(esj.b(this.o(), base.Size).c());
		if (this.r())
		{
			this.p();
		}
	}

	// Token: 0x060009F8 RID: 2552 RVA: 0x00029078 File Offset: 0x00027278
	protected virtual void i(object A_0, c1 A_1)
	{
		base.e("AutoDetermineTotalSizeChanged");
	}

	// Token: 0x060009F9 RID: 2553 RVA: 0x00029088 File Offset: 0x00027288
	protected virtual void e(object A_0, c1 A_1)
	{
		if (this.r())
		{
			this.p();
		}
	}

	// Token: 0x060009FA RID: 2554 RVA: 0x0002909C File Offset: 0x0002729C
	protected virtual void g(object A_0, c1 A_1)
	{
		if (this.r())
		{
			this.p();
		}
	}

	// Token: 0x060009FB RID: 2555 RVA: 0x000290B0 File Offset: 0x000272B0
	protected virtual void sm(object A_0, c1 A_1)
	{
		base.e("ScrollSizeChanged");
		if (this.aae().X > this.q().c)
		{
			this.a(new Point(this.q().c, this.aae().Y));
		}
		if (this.aae().Y > this.q().d)
		{
			this.a(new Point(this.aae().X, this.q().d));
		}
	}

	// Token: 0x060009FC RID: 2556 RVA: 0x00029140 File Offset: 0x00027340
	protected override void aaf(object A_0, d71 A_1)
	{
		base.aaf(A_0, A_1);
		if (!A_1.a().IsPrivateComponent)
		{
			A_1.a().q(new EventHandler<c1>(this.g));
			A_1.a().p(new EventHandler<c1>(this.e));
			if (this.r())
			{
				this.p();
			}
		}
	}

	// Token: 0x060009FD RID: 2557 RVA: 0x000291A8 File Offset: 0x000273A8
	protected override void aag(object A_0, d71 A_1)
	{
		base.aag(A_0, A_1);
		if (!A_1.a().IsPrivateComponent)
		{
			A_1.a().s(new EventHandler<c1>(this.g));
			A_1.a().m(new EventHandler<c1>(this.e));
			if (this.r())
			{
				this.p();
			}
		}
	}

	// Token: 0x060009FE RID: 2558 RVA: 0x00029210 File Offset: 0x00027410
	private esj a()
	{
		Point point = new Point(base.Size.c, base.Size.d);
		try
		{
			foreach (euz euz in base.Controls)
			{
				if (!euz.IsPrivateComponent)
				{
					Point point2 = new Point(euz.Location.X + euz.Size.c, euz.Location.Y + euz.Size.d);
					if (point2.X > point.X)
					{
						point.X = point2.X;
					}
					if (point2.Y > point.Y)
					{
						point.Y = point2.Y;
					}
				}
			}
		}
		catch
		{
		}
		return new esj(point.X, point.Y);
	}

	// Token: 0x060009FF RID: 2559 RVA: 0x00029324 File Offset: 0x00027524
	protected virtual void p()
	{
		this.b(this.a());
	}

	// Token: 0x0400064C RID: 1612
	private new Point a;

	// Token: 0x0400064D RID: 1613
	private new esj b;

	// Token: 0x0400064E RID: 1614
	private new esj c;

	// Token: 0x0400064F RID: 1615
	private new bool d = true;

	// Token: 0x04000650 RID: 1616
	[CompilerGenerated]
	private new EventHandler<c1> e;

	// Token: 0x04000651 RID: 1617
	[CompilerGenerated]
	private new EventHandler<c1> f;

	// Token: 0x04000652 RID: 1618
	[CompilerGenerated]
	private new EventHandler<c1> g;

	// Token: 0x04000653 RID: 1619
	[CompilerGenerated]
	private EventHandler<c1> h;
}

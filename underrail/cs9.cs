using System;
using System.Runtime.CompilerServices;
using System.Threading;

// Token: 0x0200017B RID: 379
public abstract class cs9 : euz
{
	// Token: 0x06000A00 RID: 2560 RVA: 0x00029334 File Offset: 0x00027534
	public int j()
	{
		return this.a;
	}

	// Token: 0x06000A01 RID: 2561 RVA: 0x00029340 File Offset: 0x00027540
	public void b(int A_0)
	{
		if (this.a != A_0)
		{
			object a_ = this.a;
			this.a = A_0;
			if (this.h != null)
			{
				this.h(this, new c1(a_, A_0));
			}
		}
	}

	// Token: 0x06000A02 RID: 2562 RVA: 0x00029390 File Offset: 0x00027590
	public int k()
	{
		return this.b;
	}

	// Token: 0x06000A03 RID: 2563 RVA: 0x0002939C File Offset: 0x0002759C
	public void a(int A_0)
	{
		if (this.b != A_0)
		{
			object a_ = this.b;
			this.b = A_0;
			if (this.g != null)
			{
				this.g(this, new c1(a_, A_0));
			}
		}
	}

	// Token: 0x06000A04 RID: 2564 RVA: 0x000293EC File Offset: 0x000275EC
	public int l()
	{
		return this.c;
	}

	// Token: 0x06000A05 RID: 2565 RVA: 0x000293F8 File Offset: 0x000275F8
	public void e(int A_0)
	{
		int num = this.c;
		this.c = A_0;
		this.a();
		if (this.c != num && this.f != null)
		{
			this.f(this, new c1(num, this.c));
		}
	}

	// Token: 0x06000A06 RID: 2566 RVA: 0x00029454 File Offset: 0x00027654
	public int m()
	{
		return this.d;
	}

	// Token: 0x06000A07 RID: 2567 RVA: 0x0002945C File Offset: 0x0002765C
	public void c(int A_0)
	{
		this.d = A_0;
	}

	// Token: 0x06000A08 RID: 2568 RVA: 0x00029468 File Offset: 0x00027668
	public int i()
	{
		return this.e;
	}

	// Token: 0x06000A09 RID: 2569 RVA: 0x00029470 File Offset: 0x00027670
	public void d(int A_0)
	{
		this.e = A_0;
	}

	// Token: 0x06000A0A RID: 2570 RVA: 0x0002947C File Offset: 0x0002767C
	protected cs9()
	{
		this.f(new EventHandler<c1>(this.jr));
		this.d(new EventHandler<c1>(this.jt));
		this.e(new EventHandler<c1>(this.js));
	}

	// Token: 0x06000A0B RID: 2571 RVA: 0x000294D8 File Offset: 0x000276D8
	[CompilerGenerated]
	public void f(EventHandler<c1> A_0)
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

	// Token: 0x06000A0C RID: 2572 RVA: 0x00029510 File Offset: 0x00027710
	[CompilerGenerated]
	public void a(EventHandler<c1> A_0)
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

	// Token: 0x06000A0D RID: 2573 RVA: 0x00029548 File Offset: 0x00027748
	[CompilerGenerated]
	public void e(EventHandler<c1> A_0)
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

	// Token: 0x06000A0E RID: 2574 RVA: 0x00029580 File Offset: 0x00027780
	[CompilerGenerated]
	public void c(EventHandler<c1> A_0)
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

	// Token: 0x06000A0F RID: 2575 RVA: 0x000295B8 File Offset: 0x000277B8
	[CompilerGenerated]
	public void d(EventHandler<c1> A_0)
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

	// Token: 0x06000A10 RID: 2576 RVA: 0x000295F0 File Offset: 0x000277F0
	[CompilerGenerated]
	public void b(EventHandler<c1> A_0)
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

	// Token: 0x06000A11 RID: 2577 RVA: 0x00029628 File Offset: 0x00027828
	protected virtual void jr(object A_0, c1 A_1)
	{
		base.e("ValueChanged");
	}

	// Token: 0x06000A12 RID: 2578 RVA: 0x00029638 File Offset: 0x00027838
	protected virtual void js(object A_0, c1 A_1)
	{
		base.e("MaximumChanged");
	}

	// Token: 0x06000A13 RID: 2579 RVA: 0x00029648 File Offset: 0x00027848
	protected virtual void jt(object A_0, c1 A_1)
	{
		base.e("MinimumChanged");
	}

	// Token: 0x06000A14 RID: 2580 RVA: 0x00029658 File Offset: 0x00027858
	protected void b(bool A_0)
	{
		int a_ = this.l() + (A_0 ? 1 : -1) * this.m();
		this.e(a_);
	}

	// Token: 0x06000A15 RID: 2581 RVA: 0x00029688 File Offset: 0x00027888
	protected void a(bool A_0)
	{
		int a_ = this.l() + (A_0 ? 1 : -1) * this.i();
		this.e(a_);
	}

	// Token: 0x06000A16 RID: 2582 RVA: 0x000296B8 File Offset: 0x000278B8
	private void a()
	{
		if (this.c < this.a)
		{
			this.c = this.a;
		}
		if (this.c > this.b)
		{
			this.c = this.b;
		}
	}

	// Token: 0x04000654 RID: 1620
	private new int a;

	// Token: 0x04000655 RID: 1621
	private new int b;

	// Token: 0x04000656 RID: 1622
	private new int c;

	// Token: 0x04000657 RID: 1623
	private new int d = 1;

	// Token: 0x04000658 RID: 1624
	private new int e = 5;

	// Token: 0x04000659 RID: 1625
	[CompilerGenerated]
	private new EventHandler<c1> f;

	// Token: 0x0400065A RID: 1626
	[CompilerGenerated]
	private new EventHandler<c1> g;

	// Token: 0x0400065B RID: 1627
	[CompilerGenerated]
	private EventHandler<c1> h;
}

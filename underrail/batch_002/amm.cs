using System;
using System.Runtime.CompilerServices;
using System.Threading;

// Token: 0x02000065 RID: 101
public abstract class amm : euz
{
	// Token: 0x06000187 RID: 391 RVA: 0x00009044 File Offset: 0x00007244
	public cku w()
	{
		return this.a;
	}

	// Token: 0x06000188 RID: 392 RVA: 0x0000904C File Offset: 0x0000724C
	protected void a(cku A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06000189 RID: 393 RVA: 0x00009058 File Offset: 0x00007258
	public object y()
	{
		return this.b;
	}

	// Token: 0x0600018A RID: 394 RVA: 0x00009060 File Offset: 0x00007260
	protected void d(object A_0)
	{
		this.b = A_0;
	}

	// Token: 0x0600018B RID: 395 RVA: 0x0000906C File Offset: 0x0000726C
	[CompilerGenerated]
	public void a(EventHandler<ddj> A_0)
	{
		EventHandler<ddj> eventHandler = this.c;
		EventHandler<ddj> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<ddj> value = (EventHandler<ddj>)Delegate.Combine(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler<ddj>>(ref this.c, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x0600018C RID: 396 RVA: 0x000090A4 File Offset: 0x000072A4
	[CompilerGenerated]
	public void b(EventHandler<ddj> A_0)
	{
		EventHandler<ddj> eventHandler = this.c;
		EventHandler<ddj> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<ddj> value = (EventHandler<ddj>)Delegate.Remove(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler<ddj>>(ref this.c, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x0600018D RID: 397 RVA: 0x000090DC File Offset: 0x000072DC
	[CompilerGenerated]
	public void a(EventHandler<el5> A_0)
	{
		EventHandler<el5> eventHandler = this.d;
		EventHandler<el5> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<el5> value = (EventHandler<el5>)Delegate.Combine(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler<el5>>(ref this.d, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x0600018E RID: 398 RVA: 0x00009114 File Offset: 0x00007314
	[CompilerGenerated]
	public void b(EventHandler<el5> A_0)
	{
		EventHandler<el5> eventHandler = this.d;
		EventHandler<el5> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<el5> value = (EventHandler<el5>)Delegate.Remove(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler<el5>>(ref this.d, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x0600018F RID: 399 RVA: 0x0000914C File Offset: 0x0000734C
	public amm()
	{
		this.a();
	}

	// Token: 0x06000190 RID: 400 RVA: 0x0000915C File Offset: 0x0000735C
	public void z()
	{
		ddj ddj = new ddj(this.a);
		if (this.c != null)
		{
			this.c(this, ddj);
		}
		if (!ddj.b())
		{
			this.x();
			if (this.d != null)
			{
				this.d(this, new el5(this.a));
			}
		}
	}

	// Token: 0x06000191 RID: 401 RVA: 0x000091C0 File Offset: 0x000073C0
	protected virtual void x()
	{
		base.bp();
		if (base.Parent != null)
		{
			base.Parent.g(this);
		}
	}

	// Token: 0x06000192 RID: 402 RVA: 0x000091E0 File Offset: 0x000073E0
	private void a()
	{
		this.a(new EventHandler<ddj>(this.aei));
		this.a(new EventHandler<el5>(this.r4));
	}

	// Token: 0x06000193 RID: 403 RVA: 0x00009208 File Offset: 0x00007408
	protected virtual void r4(object A_0, el5 A_1)
	{
		base.e("FormClosed");
	}

	// Token: 0x06000194 RID: 404 RVA: 0x00009218 File Offset: 0x00007418
	protected virtual void aei(object A_0, ddj A_1)
	{
		base.e("FormClosing");
	}

	// Token: 0x04000344 RID: 836
	private new cku a;

	// Token: 0x04000345 RID: 837
	private new object b;

	// Token: 0x04000346 RID: 838
	[CompilerGenerated]
	private new EventHandler<ddj> c;

	// Token: 0x04000347 RID: 839
	[CompilerGenerated]
	private new EventHandler<el5> d;
}

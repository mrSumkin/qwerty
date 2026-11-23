using System;
using System.Runtime.CompilerServices;
using System.Threading;
using Microsoft.Xna.Framework.Input;

// Token: 0x02000180 RID: 384
public abstract class clf : cao
{
	// Token: 0x06000A78 RID: 2680 RVA: 0x0002AE00 File Offset: 0x00029000
	public Keys s()
	{
		return this.b;
	}

	// Token: 0x06000A79 RID: 2681 RVA: 0x0002AE0C File Offset: 0x0002900C
	public void a(Keys A_0)
	{
		if (this.b != A_0)
		{
			Keys keys = this.b;
			this.b = A_0;
			if (this.c != null)
			{
				this.c(this, new c1(keys, this.b));
			}
		}
	}

	// Token: 0x06000A7A RID: 2682 RVA: 0x0002AE60 File Offset: 0x00029060
	protected bool t()
	{
		return this.a;
	}

	// Token: 0x06000A7B RID: 2683 RVA: 0x0002AE68 File Offset: 0x00029068
	[CompilerGenerated]
	public void a(EventHandler<c1> A_0)
	{
		EventHandler<c1> eventHandler = this.c;
		EventHandler<c1> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<c1> value = (EventHandler<c1>)Delegate.Combine(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler<c1>>(ref this.c, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x06000A7C RID: 2684 RVA: 0x0002AEA0 File Offset: 0x000290A0
	[CompilerGenerated]
	public void b(EventHandler<c1> A_0)
	{
		EventHandler<c1> eventHandler = this.c;
		EventHandler<c1> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<c1> value = (EventHandler<c1>)Delegate.Remove(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler<c1>>(ref this.c, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x06000A7D RID: 2685 RVA: 0x0002AED8 File Offset: 0x000290D8
	[CompilerGenerated]
	public void a(EventHandler<EventArgs> A_0)
	{
		EventHandler<EventArgs> eventHandler = this.d;
		EventHandler<EventArgs> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<EventArgs> value = (EventHandler<EventArgs>)Delegate.Combine(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler<EventArgs>>(ref this.d, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x06000A7E RID: 2686 RVA: 0x0002AF10 File Offset: 0x00029110
	[CompilerGenerated]
	public void b(EventHandler<EventArgs> A_0)
	{
		EventHandler<EventArgs> eventHandler = this.d;
		EventHandler<EventArgs> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<EventArgs> value = (EventHandler<EventArgs>)Delegate.Remove(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler<EventArgs>>(ref this.d, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x06000A7F RID: 2687 RVA: 0x0002AF48 File Offset: 0x00029148
	protected clf()
	{
		this.a(new EventHandler<c1>(this.a));
	}

	// Token: 0x06000A80 RID: 2688 RVA: 0x0002AF64 File Offset: 0x00029164
	protected virtual void a(object A_0, c1 A_1)
	{
		if (this.b == Keys.None)
		{
			base.Text = "";
			return;
		}
		if (this.b != Keys.Space)
		{
			char c = b5u.a(this.b, false, true);
			if (c != '\0')
			{
				base.Text = c.ToString().ToUpperInvariant();
				return;
			}
		}
		base.Text = this.b.ToString().ToUpperInvariant();
	}

	// Token: 0x06000A81 RID: 2689 RVA: 0x0002AFD8 File Offset: 0x000291D8
	protected override void rd(object A_0, b25 A_1)
	{
		base.rd(A_0, A_1);
		this.a = !this.a;
		if (!this.a)
		{
			base.bp();
			this.a();
		}
	}

	// Token: 0x06000A82 RID: 2690 RVA: 0x0002B008 File Offset: 0x00029208
	protected override void vx(object A_0, ane A_1)
	{
		base.vx(A_0, A_1);
		if (A_1.a == Keys.Escape)
		{
			this.a = false;
			base.bp();
			this.a();
			return;
		}
		if (this.a)
		{
			if (A_1.a == Keys.Delete)
			{
				this.a(Keys.None);
				this.a = false;
				base.bp();
				this.a();
				return;
			}
			int num = (int)A_1.a;
			bool flag = (num >= 8 && num <= 13) || (num >= 32 && num <= 90) || (num >= 96 && num <= 135) || b5u.a(A_1.a, false, true) > '\0';
			if (flag)
			{
				this.a(A_1.a);
				this.a = false;
				base.bp();
				this.a();
			}
		}
	}

	// Token: 0x06000A83 RID: 2691 RVA: 0x0002B0EC File Offset: 0x000292EC
	protected override void afy(object A_0, EventArgs A_1)
	{
		base.afy(A_0, A_1);
		this.a = false;
	}

	// Token: 0x06000A84 RID: 2692 RVA: 0x0002B100 File Offset: 0x00029300
	private void a()
	{
		if (this.d != null)
		{
			this.d(this, new EventArgs());
		}
	}

	// Token: 0x0400067F RID: 1663
	private new bool a;

	// Token: 0x04000680 RID: 1664
	private new Keys b;

	// Token: 0x04000681 RID: 1665
	[CompilerGenerated]
	private new EventHandler<c1> c;

	// Token: 0x04000682 RID: 1666
	[CompilerGenerated]
	private new EventHandler<EventArgs> d;
}

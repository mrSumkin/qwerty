using System;
using System.Runtime.CompilerServices;
using System.Threading;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using TimelapseVertigo.Common.Settings;

// Token: 0x02001FDB RID: 8155
public sealed class cbx : euz
{
	// Token: 0x0600BF7B RID: 49019 RVA: 0x0042568C File Offset: 0x0042388C
	public Hotkey c()
	{
		return this.c;
	}

	// Token: 0x0600BF7C RID: 49020 RVA: 0x00425694 File Offset: 0x00423894
	public Keys d()
	{
		return this.b.s();
	}

	// Token: 0x0600BF7D RID: 49021 RVA: 0x004256A4 File Offset: 0x004238A4
	[CompilerGenerated]
	public void a(EventHandler<c1> A_0)
	{
		EventHandler<c1> eventHandler = this.d;
		EventHandler<c1> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<c1> value = (EventHandler<c1>)Delegate.Combine(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler<c1>>(ref this.d, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x0600BF7E RID: 49022 RVA: 0x004256DC File Offset: 0x004238DC
	[CompilerGenerated]
	public void b(EventHandler<c1> A_0)
	{
		EventHandler<c1> eventHandler = this.d;
		EventHandler<c1> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<c1> value = (EventHandler<c1>)Delegate.Remove(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler<c1>>(ref this.d, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x0600BF7F RID: 49023 RVA: 0x00425714 File Offset: 0x00423914
	[CompilerGenerated]
	public void a(EventHandler<EventArgs> A_0)
	{
		EventHandler<EventArgs> eventHandler = this.e;
		EventHandler<EventArgs> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<EventArgs> value = (EventHandler<EventArgs>)Delegate.Combine(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler<EventArgs>>(ref this.e, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x0600BF80 RID: 49024 RVA: 0x0042574C File Offset: 0x0042394C
	[CompilerGenerated]
	public void b(EventHandler<EventArgs> A_0)
	{
		EventHandler<EventArgs> eventHandler = this.e;
		EventHandler<EventArgs> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<EventArgs> value = (EventHandler<EventArgs>)Delegate.Remove(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler<EventArgs>>(ref this.e, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x0600BF81 RID: 49025 RVA: 0x00425784 File Offset: 0x00423984
	public cbx(Hotkey A_0)
	{
		this.c = A_0;
		this.b();
	}

	// Token: 0x0600BF82 RID: 49026 RVA: 0x0042579C File Offset: 0x0042399C
	private void b()
	{
		wj wj = wj.a();
		this.b = new ek3();
		if (wj.c())
		{
			this.b.Size = new esj(140, 25);
			if (egg.v)
			{
				this.b.b(egg.r);
			}
			else
			{
				this.b.b(egg.am);
			}
		}
		else
		{
			this.b.Size = new esj(wj.hn / 4, wj.hr + 5);
			this.b.b(wj.hh);
		}
		this.b.a(bo1.aa);
		this.b.a(new Point(0, egg.b(this.b.l())));
		this.b.j(Color.White);
		this.b.Focusable = true;
		this.b.IsPrivateComponent = true;
		this.b.PropagateMouseScrollEvent = true;
		this.b.a(new EventHandler<c1>(this.a));
		this.b.a(new EventHandler<EventArgs>(this.a));
		e4z.a(this.b);
		bpo.GetServiceOrThrow<cnk>();
		this.b.a(d1o.a(this.c));
		this.aox(this.b);
		this.a = new avo();
		if (wj.c())
		{
			if (egg.v)
			{
				this.a.a(egg.a);
			}
			else
			{
				this.a.a(egg.ap);
			}
		}
		else
		{
			this.a.a(wj.hh);
		}
		this.a.Color = adi.a;
		this.a.IsPrivateComponent = true;
		this.a.PropagateMouseScrollEvent = true;
		this.a.Text = d1o.c(this.c);
		this.aox(this.a);
		if (wj.c())
		{
			base.Size = new esj(300, 25);
			return;
		}
		base.Size = new esj(this.b.Size.c * 2, this.b.Size.d);
	}

	// Token: 0x0600BF83 RID: 49027 RVA: 0x004259FC File Offset: 0x00423BFC
	private void a(object A_0, EventArgs A_1)
	{
		if (this.e != null)
		{
			this.e(this, new EventArgs());
		}
	}

	// Token: 0x0600BF84 RID: 49028 RVA: 0x00425A1C File Offset: 0x00423C1C
	private void a(object A_0, c1 A_1)
	{
		if (this.d != null)
		{
			this.d(this, A_1);
		}
	}

	// Token: 0x0600BF85 RID: 49029 RVA: 0x00425A3C File Offset: 0x00423C3C
	public void a(ls A_0)
	{
		A_0.e().c()[this.c] = this.d();
	}

	// Token: 0x0600BF86 RID: 49030 RVA: 0x00425A68 File Offset: 0x00423C68
	private void a()
	{
		wj wj = wj.a();
		if (wj.c())
		{
			this.b.Size = new esj(140, base.Size.d);
			this.a.Size = new esj(base.Size.c - this.b.Size.c - 20, base.Size.d);
			this.b.Location = new Point(this.a.Size.c + 20, 0);
			return;
		}
		this.b.Size = new esj(wj.hn / 4, base.Size.d);
		this.a.Size = new esj(base.Size.c - this.b.Size.c - 20, base.Size.d);
		this.b.Location = new Point(this.a.Size.c + 20, 0);
	}

	// Token: 0x0600BF87 RID: 49031 RVA: 0x00425B88 File Offset: 0x00423D88
	protected override void jq(object A_0, c1 A_1)
	{
		base.jq(A_0, A_1);
		this.a();
	}

	// Token: 0x0600BF88 RID: 49032 RVA: 0x00425B98 File Offset: 0x00423D98
	public void a(Keys A_0)
	{
		this.b.a(A_0);
	}

	// Token: 0x040044EF RID: 17647
	private new avo a;

	// Token: 0x040044F0 RID: 17648
	private new ek3 b;

	// Token: 0x040044F1 RID: 17649
	private new Hotkey c;

	// Token: 0x040044F2 RID: 17650
	[CompilerGenerated]
	private new EventHandler<c1> d;

	// Token: 0x040044F3 RID: 17651
	[CompilerGenerated]
	private new EventHandler<EventArgs> e;
}

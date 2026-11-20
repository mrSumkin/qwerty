using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading;
using Microsoft.Xna.Framework;

// Token: 0x02000173 RID: 371
public abstract class cao : euz
{
	// Token: 0x06000969 RID: 2409 RVA: 0x00026D6C File Offset: 0x00024F6C
	protected cao()
	{
		this.b(new EventHandler<b25>(this.c));
		this.c(new EventHandler<b25>(this.rd));
		this.c(new EventHandler<c1>(this.c));
	}

	// Token: 0x17000040 RID: 64
	// (get) Token: 0x0600096A RID: 2410 RVA: 0x00026DB8 File Offset: 0x00024FB8
	public double PressedDuration
	{
		get
		{
			return this.e;
		}
	}

	// Token: 0x17000041 RID: 65
	// (get) Token: 0x0600096B RID: 2411 RVA: 0x00026DC0 File Offset: 0x00024FC0
	// (set) Token: 0x0600096C RID: 2412 RVA: 0x00026DE4 File Offset: 0x00024FE4
	public bool Pressed
	{
		get
		{
			return this.d || (this.a && this.IsMousedOver);
		}
		set
		{
			this.a = value;
		}
	}

	// Token: 0x17000042 RID: 66
	// (get) Token: 0x0600096D RID: 2413 RVA: 0x00026DF0 File Offset: 0x00024FF0
	// (set) Token: 0x0600096E RID: 2414 RVA: 0x00026DFC File Offset: 0x00024FFC
	[Category("Behavior")]
	public bool Checked
	{
		get
		{
			return this.b;
		}
		set
		{
			if (value != this.b)
			{
				object a_ = this.b;
				this.b = value;
				if (this.h != null)
				{
					this.h(this, new c1(a_, value));
				}
			}
		}
	}

	// Token: 0x17000043 RID: 67
	// (get) Token: 0x0600096F RID: 2415 RVA: 0x00026E4C File Offset: 0x0002504C
	// (set) Token: 0x06000970 RID: 2416 RVA: 0x00026E54 File Offset: 0x00025054
	[Category("Behavior")]
	public virtual bool CheckOnClick
	{
		get
		{
			return this.c;
		}
		set
		{
			this.c = value;
		}
	}

	// Token: 0x17000044 RID: 68
	// (get) Token: 0x06000971 RID: 2417 RVA: 0x00026E60 File Offset: 0x00025060
	// (set) Token: 0x06000972 RID: 2418 RVA: 0x00026E68 File Offset: 0x00025068
	[Browsable(false)]
	public bool ArtificiallyPressed
	{
		get
		{
			return this.d;
		}
		set
		{
			if (this.d != value)
			{
				this.d = value;
				if (!this.d)
				{
					base.c(new b25(Point.Zero, eoo.b));
					return;
				}
				base.e(new b25(Point.Zero, eoo.b));
			}
		}
	}

	// Token: 0x06000973 RID: 2419 RVA: 0x00026EB8 File Offset: 0x000250B8
	[CompilerGenerated]
	public void c(EventHandler<b25> A_0)
	{
		EventHandler<b25> eventHandler = this.f;
		EventHandler<b25> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<b25> value = (EventHandler<b25>)Delegate.Combine(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler<b25>>(ref this.f, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x06000974 RID: 2420 RVA: 0x00026EF0 File Offset: 0x000250F0
	[CompilerGenerated]
	public void d(EventHandler<b25> A_0)
	{
		EventHandler<b25> eventHandler = this.f;
		EventHandler<b25> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<b25> value = (EventHandler<b25>)Delegate.Remove(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler<b25>>(ref this.f, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x06000975 RID: 2421 RVA: 0x00026F28 File Offset: 0x00025128
	[CompilerGenerated]
	public void b(EventHandler<b25> A_0)
	{
		EventHandler<b25> eventHandler = this.g;
		EventHandler<b25> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<b25> value = (EventHandler<b25>)Delegate.Combine(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler<b25>>(ref this.g, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x06000976 RID: 2422 RVA: 0x00026F60 File Offset: 0x00025160
	[CompilerGenerated]
	public void a(EventHandler<b25> A_0)
	{
		EventHandler<b25> eventHandler = this.g;
		EventHandler<b25> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<b25> value = (EventHandler<b25>)Delegate.Remove(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler<b25>>(ref this.g, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x06000977 RID: 2423 RVA: 0x00026F98 File Offset: 0x00025198
	[CompilerGenerated]
	public void c(EventHandler<c1> A_0)
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

	// Token: 0x06000978 RID: 2424 RVA: 0x00026FD0 File Offset: 0x000251D0
	[CompilerGenerated]
	public void d(EventHandler<c1> A_0)
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

	// Token: 0x06000979 RID: 2425 RVA: 0x00027008 File Offset: 0x00025208
	protected virtual void rd(object A_0, b25 A_1)
	{
		base.e("LeftClick");
	}

	// Token: 0x0600097A RID: 2426 RVA: 0x00027018 File Offset: 0x00025218
	protected override void vt(object A_0, b25 A_1)
	{
		if (A_1.b() == eoo.b)
		{
			this.a = true;
			if (this.g != null)
			{
				this.g(this, A_1);
			}
			base.b(A_1.b(), d7i.ak);
		}
		base.vt(A_0, A_1);
	}

	// Token: 0x0600097B RID: 2427 RVA: 0x00027070 File Offset: 0x00025270
	protected override void vu(object A_0, b25 A_1)
	{
		if (A_1.b() == eoo.b)
		{
			this.a = false;
		}
		base.vu(A_0, A_1);
	}

	// Token: 0x0600097C RID: 2428 RVA: 0x00027090 File Offset: 0x00025290
	protected override void lq(object A_0, b25 A_1)
	{
		base.lq(A_0, A_1);
		if (A_1.b() == eoo.b && this.f != null)
		{
			this.f(this, A_1);
		}
		if (this.CheckOnClick)
		{
			this.Checked = !this.Checked;
		}
	}

	// Token: 0x0600097D RID: 2429 RVA: 0x000270E4 File Offset: 0x000252E4
	protected virtual void c(object A_0, b25 A_1)
	{
		base.e("MousePress");
	}

	// Token: 0x0600097E RID: 2430 RVA: 0x000270F4 File Offset: 0x000252F4
	protected virtual void c(object A_0, c1 A_1)
	{
		base.e("CheckedChanged");
	}

	// Token: 0x0600097F RID: 2431 RVA: 0x00027104 File Offset: 0x00025304
	public override void ag5(e6d A_0)
	{
		base.ag5(A_0);
		if (this.Pressed)
		{
			this.e += A_0.a().ElapsedGameTime.TotalMilliseconds;
			if (base.a(eoo.b, A_0.a().ElapsedGameTime))
			{
				Point point = base.at();
				b25 b = new b25(new Point(A_0.b().X - point.X, A_0.b().Y - point.Y), 0, eoo.b);
				if (this.g != null)
				{
					this.g(this, b);
				}
				base.b(eoo.b, d7i.al);
				return;
			}
		}
		else
		{
			this.e = 0.0;
		}
	}

	// Token: 0x04000603 RID: 1539
	private new bool a;

	// Token: 0x04000604 RID: 1540
	private new bool b;

	// Token: 0x04000605 RID: 1541
	private new bool c;

	// Token: 0x04000606 RID: 1542
	private new bool d;

	// Token: 0x04000607 RID: 1543
	private new double e;

	// Token: 0x04000608 RID: 1544
	[CompilerGenerated]
	private new EventHandler<b25> f;

	// Token: 0x04000609 RID: 1545
	[CompilerGenerated]
	private new EventHandler<b25> g;

	// Token: 0x0400060A RID: 1546
	[CompilerGenerated]
	private EventHandler<c1> h;
}

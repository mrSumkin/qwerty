using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using Microsoft.Xna.Framework;

// Token: 0x02002035 RID: 8245
public class eko : euz, dyo
{
	// Token: 0x170002E0 RID: 736
	// (get) Token: 0x0600C344 RID: 49988 RVA: 0x00439A9C File Offset: 0x00437C9C
	public string Code
	{
		get
		{
			return this.j;
		}
	}

	// Token: 0x170002E1 RID: 737
	// (get) Token: 0x0600C345 RID: 49989 RVA: 0x00439AA4 File Offset: 0x00437CA4
	// (set) Token: 0x0600C346 RID: 49990 RVA: 0x00439AAC File Offset: 0x00437CAC
	public ecs ButtonText
	{
		get
		{
			return this.a;
		}
		set
		{
			this.a = value;
		}
	}

	// Token: 0x170002E2 RID: 738
	// (get) Token: 0x0600C347 RID: 49991 RVA: 0x00439AB8 File Offset: 0x00437CB8
	// (set) Token: 0x0600C348 RID: 49992 RVA: 0x00439AC0 File Offset: 0x00437CC0
	public ecs AdditionalInfo
	{
		get
		{
			return this.b;
		}
		set
		{
			if (this.b != value)
			{
				this.b = value;
				this.i = this.a(this.b, this.d);
				this.a();
			}
		}
	}

	// Token: 0x170002E3 RID: 739
	// (get) Token: 0x0600C349 RID: 49993 RVA: 0x00439AF4 File Offset: 0x00437CF4
	// (set) Token: 0x0600C34A RID: 49994 RVA: 0x00439AFC File Offset: 0x00437CFC
	public esj AddtionalInfoTextPadding
	{
		get
		{
			return this.d;
		}
		set
		{
			if (esj.c(this.d, value))
			{
				this.d = value;
				this.i = this.a(this.b, this.d);
				this.a();
			}
		}
	}

	// Token: 0x170002E4 RID: 740
	// (get) Token: 0x0600C34B RID: 49995 RVA: 0x00439B34 File Offset: 0x00437D34
	// (set) Token: 0x0600C34C RID: 49996 RVA: 0x00439B3C File Offset: 0x00437D3C
	public bool IsColapsed
	{
		get
		{
			return this.f;
		}
		set
		{
			if (this.f != value)
			{
				this.f = value;
				this.a();
			}
		}
	}

	// Token: 0x0600C34D RID: 49997 RVA: 0x00439B58 File Offset: 0x00437D58
	[CompilerGenerated]
	public void a(EventHandler<EventArgs> A_0)
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

	// Token: 0x0600C34E RID: 49998 RVA: 0x00439B90 File Offset: 0x00437D90
	[CompilerGenerated]
	public void b(EventHandler<EventArgs> A_0)
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

	// Token: 0x0600C34F RID: 49999 RVA: 0x00439BC8 File Offset: 0x00437DC8
	public eko(string A_0, int A_1, int A_2, string A_3, ecs A_4, ecs A_5)
	{
		this.j = A_0;
		base.Size = new esj(A_1, A_2);
		this.e = new esj(A_1, A_2);
		this.a = A_4;
		this.h = this.a(this.a, esj.a());
		this.b = A_5;
		this.i = this.a(this.b, this.d);
		this.g = A_3;
		this.b();
	}

	// Token: 0x0600C350 RID: 50000 RVA: 0x00439C54 File Offset: 0x00437E54
	private void b()
	{
		this.c = new a1r(bo1.av, this.g, this.e.c, this.e.d, this.a, new Point(5, 5));
		this.c.a(10);
		this.c.Size = new esj(base.Size.c, base.Size.d);
		this.c.Location = Point.Zero;
		this.c.IsPrivateComponent = true;
		this.c.c(new EventHandler<b25>(this.a));
		this.c.PropagateMouseScrollEvent = true;
		this.aox(this.c);
		this.a();
	}

	// Token: 0x0600C351 RID: 50001 RVA: 0x00439D20 File Offset: 0x00437F20
	private void a()
	{
		if (this.c != null)
		{
			this.c.Checked = !this.f;
			if (this.f)
			{
				this.c.Size = this.e;
				if (esj.c(base.Size, this.e))
				{
					base.Size = this.e;
					return;
				}
			}
			else
			{
				this.c.Size = new esj(this.e.c, Math.Max(base.Size.d, this.i.b.d + 10 + this.d.d + this.e.d));
				if (esj.c(base.Size, this.c.Size))
				{
					base.Size = this.c.Size;
				}
			}
		}
	}

	// Token: 0x0600C352 RID: 50002 RVA: 0x00439E10 File Offset: 0x00438010
	private dn3 a(ecs A_0, esj A_1)
	{
		dn3 result = null;
		if (A_0 != null)
		{
			List<ecs> list = A_0.a(base.Size.c - 2 * A_1.c, 0);
			if (list != null && list.Count > 0)
			{
				result = list[0].b();
			}
		}
		return result;
	}

	// Token: 0x0600C353 RID: 50003 RVA: 0x00439E64 File Offset: 0x00438064
	public void ata(int A_0)
	{
		if (this.c != null)
		{
			this.c.Size = new esj(this.c.Size.c, A_0);
			base.Size = this.c.Size;
		}
	}

	// Token: 0x0600C354 RID: 50004 RVA: 0x00439EB0 File Offset: 0x004380B0
	public override void iv(e6d A_0, cp9 A_1)
	{
		base.iv(A_0, A_1);
		Point point = base.at();
		if (!this.f && this.i != null)
		{
			this.i.a(new Point(point.X + this.d.c, point.Y + this.e.d + this.d.d), A_1, null, 1f);
		}
	}

	// Token: 0x0600C355 RID: 50005 RVA: 0x00439F2C File Offset: 0x0043812C
	public void b(bool A_0)
	{
		this.c.d = (A_0 ? bo1.aw : bo1.av);
	}

	// Token: 0x0600C356 RID: 50006 RVA: 0x00439F50 File Offset: 0x00438150
	private void a(object A_0, b25 A_1)
	{
		this.f = !this.f;
		this.a();
		if (this.k != null)
		{
			this.k(this, new EventArgs());
		}
	}

	// Token: 0x0600C357 RID: 50007 RVA: 0x00439F84 File Offset: 0x00438184
	protected override void jq(object A_0, c1 A_1)
	{
		base.jq(A_0, A_1);
		this.e = new esj(base.Size.c, this.e.d);
		this.a();
	}

	// Token: 0x040046E4 RID: 18148
	private new ecs a;

	// Token: 0x040046E5 RID: 18149
	private new ecs b;

	// Token: 0x040046E6 RID: 18150
	private new a1r c;

	// Token: 0x040046E7 RID: 18151
	private new esj d;

	// Token: 0x040046E8 RID: 18152
	private new esj e;

	// Token: 0x040046E9 RID: 18153
	private new bool f;

	// Token: 0x040046EA RID: 18154
	private new string g = "p1";

	// Token: 0x040046EB RID: 18155
	private dn3 h;

	// Token: 0x040046EC RID: 18156
	private dn3 i;

	// Token: 0x040046ED RID: 18157
	private new string j;

	// Token: 0x040046EE RID: 18158
	[CompilerGenerated]
	private new EventHandler<EventArgs> k;
}

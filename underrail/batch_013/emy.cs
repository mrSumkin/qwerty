using System;
using System.Runtime.CompilerServices;
using System.Threading;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using TimelapseVertigo.Common;

// Token: 0x02002001 RID: 8193
public sealed class emy : cqy
{
	// Token: 0x170002BD RID: 701
	// (get) Token: 0x0600C14C RID: 49484 RVA: 0x0042FF20 File Offset: 0x0042E120
	public override coh Item
	{
		get
		{
			return this.c;
		}
	}

	// Token: 0x170002BE RID: 702
	// (get) Token: 0x0600C14D RID: 49485 RVA: 0x0042FF28 File Offset: 0x0042E128
	public cgo Slot
	{
		get
		{
			return this.b;
		}
	}

	// Token: 0x170002BF RID: 703
	// (get) Token: 0x0600C14E RID: 49486 RVA: 0x0042FF30 File Offset: 0x0042E130
	public string ComponentName
	{
		get
		{
			return this.d;
		}
	}

	// Token: 0x0600C14F RID: 49487 RVA: 0x0042FF38 File Offset: 0x0042E138
	protected override bool x7()
	{
		return true;
	}

	// Token: 0x170002C0 RID: 704
	// (get) Token: 0x0600C150 RID: 49488 RVA: 0x0042FF40 File Offset: 0x0042E140
	// (set) Token: 0x0600C151 RID: 49489 RVA: 0x0042FF5C File Offset: 0x0042E15C
	public override string ItemExchangeParty
	{
		get
		{
			return TimelapseVertigo.Common.ItemExchangeParty.CraftingComponent.ToString();
		}
		set
		{
		}
	}

	// Token: 0x170002C1 RID: 705
	// (get) Token: 0x0600C152 RID: 49490 RVA: 0x0042FF60 File Offset: 0x0042E160
	public override bool SpecialState
	{
		get
		{
			return this.b != null && this.c != null && this.c.Stacks < this.b.d;
		}
	}

	// Token: 0x0600C153 RID: 49491 RVA: 0x0042FF94 File Offset: 0x0042E194
	[CompilerGenerated]
	public new void b(EventHandler A_0)
	{
		EventHandler eventHandler = this.e;
		EventHandler eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler value = (EventHandler)Delegate.Combine(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.e, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x0600C154 RID: 49492 RVA: 0x0042FFCC File Offset: 0x0042E1CC
	[CompilerGenerated]
	public new void a(EventHandler A_0)
	{
		EventHandler eventHandler = this.e;
		EventHandler eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler value = (EventHandler)Delegate.Remove(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.e, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x0600C155 RID: 49493 RVA: 0x00430004 File Offset: 0x0042E204
	public emy(string A_0, cgo A_1) : base(emy.a(), emy.b())
	{
		this.d = A_0;
		this.b = A_1;
		wj wj = wj.a();
		if (wj.c())
		{
			if (this.b != null && this.b.b)
			{
				this.d = bo1.bb;
			}
			else
			{
				this.d = bo1.ba;
			}
		}
		else
		{
			this.d = wj.f;
			this.f = wj.eb;
			if (this.b != null && this.b.b)
			{
				this.e = wj.ed;
			}
			else
			{
				this.e = wj.ec;
			}
			this.h = new Vector2?(wj.w);
			this.i = wj.x;
			this.r = wj.s;
		}
		this.f = emy.a();
		base.e(false);
	}

	// Token: 0x0600C156 RID: 49494 RVA: 0x00430108 File Offset: 0x0042E308
	public new static esj b()
	{
		wj wj = wj.a();
		if (wj.c())
		{
			return bj8.a;
		}
		return wj.o;
	}

	// Token: 0x0600C157 RID: 49495 RVA: 0x00430134 File Offset: 0x0042E334
	public new static esj a()
	{
		wj wj = wj.a();
		if (wj.c())
		{
			return emy.a;
		}
		return wj.eb;
	}

	// Token: 0x0600C158 RID: 49496 RVA: 0x00430160 File Offset: 0x0042E360
	public override void iv(e6d A_0, cp9 A_1)
	{
		if (this.x6() == null && this.b != null && this.b.a != null && A_1.a != null)
		{
			c3i c3i = ejh.b("ComponentSlots." + this.b.a.aha().ToString(), A_1.a);
			Vector2 vector = base.at().b();
			chr service = bpo.GetService<chr>();
			Color a_;
			Color a_2;
			if (bpo.GetServiceOrThrow<d1a>().aa8() == this && service != null && service.ax() != null && this.iq(service.ax()))
			{
				a_ = new Color(108, 108, 108);
				a_2 = new Color(200, 200, 200);
			}
			else
			{
				a_ = new Color(45, 45, 45);
				a_2 = new Color(100, 100, 100);
			}
			wj wj = wj.a();
			if (c3i != null)
			{
				if (wj.c())
				{
					c3i.a(A_1, new Vector2(vector.X + (float)((this.f.c - bj8.a.c) / 2), vector.Y + (float)((this.f.d - bj8.a.d) / 2)), a_, 1f, 0, null);
				}
				else
				{
					Point point = new Point((base.Size.c - wj.o.c) / 2, (base.Size.d - wj.o.d) / 2);
					Rectangle a_3 = new Rectangle((int)(vector.X + (float)point.X), (int)(vector.Y + (float)point.X), wj.o.c, wj.o.d);
					c3i.a(A_1, a_3, a_, 0, null);
				}
			}
			if (this.b.d > 1)
			{
				if (wj.c())
				{
					string n = egg.n;
					SpriteFont resource = A_1.a.GetResource<SpriteFont>(n, null);
					if (resource != null)
					{
						string text = "x" + this.b.d.ToString();
						Vector2 vector2 = resource.MeasureString(text);
						Vector2 a_4 = new Vector2(vector.X + ((float)base.Size.c - vector2.X - 5f), vector.Y + ((float)base.Size.d - vector2.Y - 5f) + (float)egg.b(n));
						A_1.b().xb(resource, text, a_4, a_2);
					}
				}
				else if (!string.IsNullOrEmpty(this.r))
				{
					SpriteFont resource2 = A_1.a.GetResource<SpriteFont>(this.r, null);
					if (resource2 != null)
					{
						string text2 = this.b.d.ToString();
						Vector2 vector3 = resource2.MeasureString(text2);
						esj esj = new esj((base.Size.c - this.g.c) / 2, (base.Size.d - this.g.d) / 2);
						Vector2 a_5 = new Vector2(vector.X + (float)base.Size.c - (float)esj.c - vector3.X - 3f, vector.Y + (float)base.Size.d - (float)esj.d - vector3.Y - 3f);
						A_1.b().xb(resource2, text2, a_5, a_2);
					}
				}
			}
		}
		base.iv(A_0, A_1);
	}

	// Token: 0x0600C159 RID: 49497 RVA: 0x0043053C File Offset: 0x0042E73C
	public override bool iq(e08 A_0)
	{
		if (!this.x7())
		{
			return false;
		}
		coh coh = A_0.c() as coh;
		ebk ebk = A_0.a() as ebk;
		return coh != null && ebk != null && this.ye(ebk, coh) && (this.x6() == null || ebk.ye(this, this.x6()));
	}

	// Token: 0x0600C15A RID: 49498 RVA: 0x004305A4 File Offset: 0x0042E7A4
	public override coh yb(coh A_0, bool A_1 = false)
	{
		coh result = this.c;
		this.c = A_0;
		if (this.e != null)
		{
			this.e(this, new EventArgs());
		}
		return result;
	}

	// Token: 0x0600C15B RID: 49499 RVA: 0x004305D0 File Offset: 0x0042E7D0
	public override void yc(coh A_0, int A_1, int A_2)
	{
		base.yc(A_0, A_1, A_2);
		if (this.e != null)
		{
			this.e(this, new EventArgs());
		}
	}

	// Token: 0x0600C15C RID: 49500 RVA: 0x004305F8 File Offset: 0x0042E7F8
	public new void a(coh A_0)
	{
		this.c = A_0;
	}

	// Token: 0x0600C15D RID: 49501 RVA: 0x00430604 File Offset: 0x0042E804
	public override coh yd()
	{
		coh result = this.c;
		this.c = null;
		if (this.e != null)
		{
			this.e(this, new EventArgs());
		}
		return result;
	}

	// Token: 0x0600C15E RID: 49502 RVA: 0x00430630 File Offset: 0x0042E830
	public override bool ye(ebk A_0, coh A_1)
	{
		return this.b != null && this.b.a != null && this.b.a.ahb(A_1);
	}

	// Token: 0x0600C15F RID: 49503 RVA: 0x00430664 File Offset: 0x0042E864
	public override ecs yf(euz A_0)
	{
		ecs ecs = base.yf(A_0);
		if (ecs == null)
		{
			ecs = cq4.a(this.b);
		}
		return ecs;
	}

	// Token: 0x0600C160 RID: 49504 RVA: 0x0043068C File Offset: 0x0042E88C
	public override bool yg(ebk A_0)
	{
		return A_0 != this && base.yg(A_0);
	}

	// Token: 0x0600C161 RID: 49505 RVA: 0x004306A0 File Offset: 0x0042E8A0
	protected override object yh()
	{
		return new emy.a(this);
	}

	// Token: 0x040045F2 RID: 17906
	public new static readonly esj a = new esj(41, 41);

	// Token: 0x040045F3 RID: 17907
	private new cgo b;

	// Token: 0x040045F4 RID: 17908
	private new coh c;

	// Token: 0x040045F5 RID: 17909
	private new string d;

	// Token: 0x040045F6 RID: 17910
	[CompilerGenerated]
	private new EventHandler e;

	// Token: 0x02002002 RID: 8194
	private new class a : ebk
	{
		// Token: 0x0600C163 RID: 49507 RVA: 0x004306B8 File Offset: 0x0042E8B8
		public a(emy A_0)
		{
			this.a = A_0;
			this.b = A_0.x6();
		}

		// Token: 0x0600C164 RID: 49508 RVA: 0x004306D4 File Offset: 0x0042E8D4
		public string x8()
		{
			return this.a.x8();
		}

		// Token: 0x0600C165 RID: 49509 RVA: 0x004306E4 File Offset: 0x0042E8E4
		public bool ye(ebk A_0, coh A_1)
		{
			return true;
		}

		// Token: 0x0600C166 RID: 49510 RVA: 0x004306E8 File Offset: 0x0042E8E8
		public bool yg(ebk A_0)
		{
			return this.a.yg(A_0);
		}

		// Token: 0x0600C167 RID: 49511 RVA: 0x004306F8 File Offset: 0x0042E8F8
		public coh yd()
		{
			return this.a.yd();
		}

		// Token: 0x0600C168 RID: 49512 RVA: 0x00430708 File Offset: 0x0042E908
		public coh yb(coh A_0, bool A_1 = false)
		{
			if (this.a.ye(null, A_0))
			{
				return this.a.yb(A_0, A_1);
			}
			cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
			if (serviceOrThrow.aqu() != null && serviceOrThrow.aqu().v() != null)
			{
				serviceOrThrow.aqu().v().Bag.z3(A_0, true);
			}
			return null;
		}

		// Token: 0x0600C169 RID: 49513 RVA: 0x00430770 File Offset: 0x0042E970
		public void yc(coh A_0, int A_1, int A_2)
		{
			this.a.yc(A_0, A_1, A_2);
		}

		// Token: 0x0600C16A RID: 49514 RVA: 0x00430780 File Offset: 0x0042E980
		public coh yx()
		{
			return this.b;
		}

		// Token: 0x0600C16B RID: 49515 RVA: 0x00430788 File Offset: 0x0042E988
		public bool yy()
		{
			return true;
		}

		// Token: 0x040045F7 RID: 17911
		private emy a;

		// Token: 0x040045F8 RID: 17912
		private coh b;
	}
}

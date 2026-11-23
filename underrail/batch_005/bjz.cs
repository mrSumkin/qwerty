using System;
using System.Runtime.CompilerServices;
using System.Threading;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using TimelapseVertigo.Common;
using TimelapseVertigo.Rules.Vehicles;

// Token: 0x02001FF0 RID: 8176
public sealed class bjz : cqy
{
	// Token: 0x0600C058 RID: 49240 RVA: 0x0042A76C File Offset: 0x0042896C
	[CompilerGenerated]
	public new void b(EventHandler A_0)
	{
		EventHandler eventHandler = this.f;
		EventHandler eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler value = (EventHandler)Delegate.Combine(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.f, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x0600C059 RID: 49241 RVA: 0x0042A7A4 File Offset: 0x004289A4
	[CompilerGenerated]
	public new void a(EventHandler A_0)
	{
		EventHandler eventHandler = this.f;
		EventHandler eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler value = (EventHandler)Delegate.Remove(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.f, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x0600C05A RID: 49242 RVA: 0x0042A7DC File Offset: 0x004289DC
	public override coh x6()
	{
		return this.c;
	}

	// Token: 0x0600C05B RID: 49243 RVA: 0x0042A7E4 File Offset: 0x004289E4
	public new c38 a()
	{
		return this.b;
	}

	// Token: 0x0600C05C RID: 49244 RVA: 0x0042A7EC File Offset: 0x004289EC
	protected override bool x7()
	{
		return true;
	}

	// Token: 0x0600C05D RID: 49245 RVA: 0x0042A7F0 File Offset: 0x004289F0
	public override string x8()
	{
		return ItemExchangeParty.VehiclePart.ToString();
	}

	// Token: 0x0600C05E RID: 49246 RVA: 0x0042A80C File Offset: 0x00428A0C
	public override void x9(string A_0)
	{
	}

	// Token: 0x0600C05F RID: 49247 RVA: 0x0042A810 File Offset: 0x00428A10
	public override bool ya()
	{
		return this.e;
	}

	// Token: 0x0600C060 RID: 49248 RVA: 0x0042A81C File Offset: 0x00428A1C
	public bjz(bcx A_0, c38 A_1, bool A_2)
	{
		wj wj = wj.a();
		if (wj.c())
		{
			this.d = bo1.bc;
			this.f = bjz.a;
		}
		else
		{
			this.d = wj.f;
			this.e = wj.cr;
			this.f = wj.cs;
			this.g = wj.o;
			base.Size = this.f;
			this.h = new Vector2?(wj.w);
			this.i = wj.x;
			base.Color = new Color(0, 74, 34);
			base.a(Color.Black);
		}
		this.d = A_0;
		this.b = A_1;
		base.e(false);
		this.e = A_2;
	}

	// Token: 0x0600C061 RID: 49249 RVA: 0x0042A8EC File Offset: 0x00428AEC
	public override void iv(e6d A_0, cp9 A_1)
	{
		base.iv(A_0, A_1);
		if (this.x6() == null && this.b != null && A_1.a != null)
		{
			Vector2 vector = base.at().b();
			chr service = bpo.GetService<chr>();
			Color color;
			if (bpo.GetServiceOrThrow<d1a>().aa8() == this && service != null && service.ax() != null && this.iq(service.ax()))
			{
				color = new Color(0, 117, 58);
			}
			else
			{
				color = new Color(0, 74, 37);
			}
			wj wj = wj.a();
			if (wj.c())
			{
				c3i c3i = ejh.b("VehiclePartSlot." + this.b.c().ToString() + "." + this.b.a().ToString(), A_1.a);
				if (c3i != null)
				{
					c3i.a(A_1, new Vector2(vector.X + (float)((this.f.c - bj8.a.c) / 2), vector.Y + (float)((this.f.d - bj8.a.d) / 2)), color, 1f, 0, null);
					return;
				}
			}
			else
			{
				Texture2D texture2D = A_1.a.us(wj.f, null);
				if (texture2D != null)
				{
					int num;
					int num2;
					if (this.b.c() == VehiclePartType.Harp1Rocket)
					{
						num = 3;
						num2 = 0;
					}
					else
					{
						num = this.b.c() - VehiclePartType.Engine;
						num2 = this.b.a() - 1;
					}
					Rectangle value = new Rectangle(wj.it.X + num2 * wj.iu.c, wj.it.Y + num * wj.iu.d, wj.iu.c, wj.iu.d);
					Vector2 a_ = new Vector2(vector.X + (float)((this.f.c - wj.iu.c) / 2), vector.Y + (float)((this.f.d - wj.iu.d) / 2));
					A_1.b().w5(texture2D, a_, new Rectangle?(value), color);
				}
			}
		}
	}

	// Token: 0x0600C062 RID: 49250 RVA: 0x0042AB5C File Offset: 0x00428D5C
	public override bool iq(e08 A_0)
	{
		if (!this.e)
		{
			return false;
		}
		if (!this.x7())
		{
			return false;
		}
		coh coh = A_0.c() as coh;
		ebk ebk = A_0.a() as ebk;
		return coh != null && ebk != null && this.ye(ebk, coh);
	}

	// Token: 0x0600C063 RID: 49251 RVA: 0x0042ABB4 File Offset: 0x00428DB4
	public override coh yb(coh A_0, bool A_1 = false)
	{
		coh result = this.c;
		this.a(A_0);
		if (this.f != null)
		{
			this.f(this, new EventArgs());
		}
		return result;
	}

	// Token: 0x0600C064 RID: 49252 RVA: 0x0042ABE0 File Offset: 0x00428DE0
	public override void yc(coh A_0, int A_1, int A_2)
	{
		base.yc(A_0, A_1, A_2);
		if (this.f != null)
		{
			this.f(this, new EventArgs());
		}
	}

	// Token: 0x0600C065 RID: 49253 RVA: 0x0042AC08 File Offset: 0x00428E08
	public new void b(coh A_0)
	{
		this.a(A_0);
	}

	// Token: 0x0600C066 RID: 49254 RVA: 0x0042AC14 File Offset: 0x00428E14
	public override coh yd()
	{
		coh result = this.c;
		this.a(null);
		if (this.f != null)
		{
			this.f(this, new EventArgs());
		}
		return result;
	}

	// Token: 0x0600C067 RID: 49255 RVA: 0x0042AC40 File Offset: 0x00428E40
	public override bool ye(ebk A_0, coh A_1)
	{
		if (this.b != null)
		{
			agt agt = A_1 as agt;
			return agt != null && agt.fu().qp() == this.b.c() && (this.b.a() == 0 || agt.fu().l() <= this.b.a());
		}
		return false;
	}

	// Token: 0x0600C068 RID: 49256 RVA: 0x0042ACB4 File Offset: 0x00428EB4
	public override ecs yf(euz A_0)
	{
		ecs ecs = base.yf(A_0);
		if (ecs == null)
		{
			ecs = cq4.a(this.b);
		}
		return ecs;
	}

	// Token: 0x0600C069 RID: 49257 RVA: 0x0042ACDC File Offset: 0x00428EDC
	public override bool yg(ebk A_0)
	{
		return A_0 != this && base.yg(A_0);
	}

	// Token: 0x0600C06A RID: 49258 RVA: 0x0042ACF0 File Offset: 0x00428EF0
	protected override object yh()
	{
		return new bjz.a(this);
	}

	// Token: 0x0600C06B RID: 49259 RVA: 0x0042ACFC File Offset: 0x00428EFC
	private new void a(coh A_0)
	{
		this.c = A_0;
		if (this.d != null)
		{
			agt value = A_0 as agt;
			this.d.o()[this.b.h()] = value;
			this.d.k();
		}
	}

	// Token: 0x04004582 RID: 17794
	public new static readonly esj a = new esj(41, 41);

	// Token: 0x04004583 RID: 17795
	private new c38 b;

	// Token: 0x04004584 RID: 17796
	private new coh c;

	// Token: 0x04004585 RID: 17797
	private new bcx d;

	// Token: 0x04004586 RID: 17798
	private new bool e;

	// Token: 0x04004587 RID: 17799
	[CompilerGenerated]
	private new EventHandler f;

	// Token: 0x02001FF1 RID: 8177
	private new class a : ebk
	{
		// Token: 0x0600C06D RID: 49261 RVA: 0x0042AD5C File Offset: 0x00428F5C
		public a(bjz A_0)
		{
			this.a = A_0;
			this.b = A_0.x6();
		}

		// Token: 0x0600C06E RID: 49262 RVA: 0x0042AD78 File Offset: 0x00428F78
		public string x8()
		{
			return this.a.x8();
		}

		// Token: 0x0600C06F RID: 49263 RVA: 0x0042AD88 File Offset: 0x00428F88
		public bool ye(ebk A_0, coh A_1)
		{
			return true;
		}

		// Token: 0x0600C070 RID: 49264 RVA: 0x0042AD8C File Offset: 0x00428F8C
		public bool yg(ebk A_0)
		{
			return this.a.yg(A_0);
		}

		// Token: 0x0600C071 RID: 49265 RVA: 0x0042AD9C File Offset: 0x00428F9C
		public coh yd()
		{
			return this.a.yd();
		}

		// Token: 0x0600C072 RID: 49266 RVA: 0x0042ADAC File Offset: 0x00428FAC
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

		// Token: 0x0600C073 RID: 49267 RVA: 0x0042AE14 File Offset: 0x00429014
		public void yc(coh A_0, int A_1, int A_2)
		{
			this.a.yc(A_0, A_1, A_2);
		}

		// Token: 0x0600C074 RID: 49268 RVA: 0x0042AE24 File Offset: 0x00429024
		public coh yx()
		{
			return this.b;
		}

		// Token: 0x0600C075 RID: 49269 RVA: 0x0042AE2C File Offset: 0x0042902C
		public bool yy()
		{
			return true;
		}

		// Token: 0x04004588 RID: 17800
		private bjz a;

		// Token: 0x04004589 RID: 17801
		private coh b;
	}
}

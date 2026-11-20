using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using TimelapseVertigo.Common;

// Token: 0x02002061 RID: 8289
public sealed class c9p : euz, amj
{
	// Token: 0x0600C513 RID: 50451 RVA: 0x0044AFF4 File Offset: 0x004491F4
	public bd8 c()
	{
		return this.f;
	}

	// Token: 0x0600C514 RID: 50452 RVA: 0x0044B000 File Offset: 0x00449200
	[CompilerGenerated]
	public void a(EventHandler<b25> A_0)
	{
		EventHandler<b25> eventHandler = this.j;
		EventHandler<b25> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<b25> value = (EventHandler<b25>)Delegate.Combine(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler<b25>>(ref this.j, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x0600C515 RID: 50453 RVA: 0x0044B038 File Offset: 0x00449238
	[CompilerGenerated]
	public void b(EventHandler<b25> A_0)
	{
		EventHandler<b25> eventHandler = this.j;
		EventHandler<b25> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<b25> value = (EventHandler<b25>)Delegate.Remove(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler<b25>>(ref this.j, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x0600C516 RID: 50454 RVA: 0x0044B070 File Offset: 0x00449270
	public c9p(efk A_0, bd8 A_1)
	{
		this.e = A_0;
		this.f = A_1;
		this.b();
	}

	// Token: 0x0600C517 RID: 50455 RVA: 0x0044B090 File Offset: 0x00449290
	private void b()
	{
		wj wj = wj.a();
		this.g = new dz(this.f);
		this.g.h = new Func<string>(this.a);
		this.g.j(new EventHandler<b25>(this.b));
		this.g.l(new EventHandler<b25>(this.c));
		this.g.g(new EventHandler<b25>(this.d));
		this.g.p(new EventHandler<b25>(this.a));
		this.aox(this.g);
		dz.a[] array;
		if (wj.c())
		{
			array = dz.i;
		}
		else
		{
			array = dz.j;
		}
		dz.a a = array[(int)this.f];
		this.b = new esj(a.c, a.b);
		this.a = a.d;
		this.c = a.a;
		base.Size = new esj(this.g.Size.c + 2 * this.a + 2 * this.b.c, this.g.Size.d);
		this.h = new dsy(this, this, esj.a(), 0, null, null, 300, false, false);
		this.i = new dsy(this.g, this, esj.a(), 0, null, null, 300, false, false);
	}

	// Token: 0x0600C518 RID: 50456 RVA: 0x0044B22C File Offset: 0x0044942C
	public override void ag5(e6d A_0)
	{
		base.ag5(A_0);
		if (this.d != null && this.d.j == cgy.b && this.g != null)
		{
			this.g.a(this.d.Lightning);
		}
		if (this.e != null && this.e.Vehicle != null)
		{
			this.g.a(this.e.Vehicle.ah());
			return;
		}
		this.g.a(null);
	}

	// Token: 0x0600C519 RID: 50457 RVA: 0x0044B2C0 File Offset: 0x004494C0
	public override void iv(e6d A_0, cp9 A_1)
	{
		base.iv(A_0, A_1);
		if (this.e != null && this.e.Vehicle != null)
		{
			Texture2D texture2D = A_1.a.us(bo1.az + this.c, null);
			if (texture2D != null)
			{
				Vector2 value = base.at().b();
				Vector2 vector = value + new Vector2((float)(this.g.Size.c + this.a), 0f);
				double num = Math.Min(1.0, this.e.Vehicle.ag() / (double)Math.Max(1, this.e.Vehicle.v()));
				A_1.b().w5(texture2D, vector, new Rectangle?(new Rectangle(3 * this.b.c, 0, this.b.c, this.b.d)), Color.White);
				if (num > 0.0)
				{
					int num2 = (int)Math.Max(3.0, (double)this.b.d * num);
					A_1.b().w5(texture2D, vector + new Vector2(0f, (float)(this.b.d - num2)), new Rectangle?(new Rectangle(4 * this.b.c, this.b.d - num2, this.b.c, num2)), Color.White);
				}
				A_1.b().w5(texture2D, vector, new Rectangle?(new Rectangle(5 * this.b.c, 0, this.b.c, this.b.d)), Color.White);
				Vector2 vector2 = value + new Vector2((float)(this.g.Size.c + this.a * 2 + this.b.c), 0f);
				double num3 = Math.Min(1.0, this.e.Vehicle.g() / (double)Math.Max(1, this.e.Vehicle.am()));
				A_1.b().w5(texture2D, vector2, new Rectangle?(new Rectangle(0, 0, this.b.c, this.b.d)), Color.White);
				if (num3 > 0.0)
				{
					int num4 = (int)Math.Max(3.0, (double)this.b.d * num3);
					A_1.b().w5(texture2D, vector2 + new Vector2(0f, (float)(this.b.d - num4)), new Rectangle?(new Rectangle(this.b.c, this.b.d - num4, this.b.c, num4)), Color.White);
				}
				A_1.b().w5(texture2D, vector2, new Rectangle?(new Rectangle(2 * this.b.c, 0, this.b.c, this.b.d)), Color.White);
			}
			this.h.a(A_0);
			this.i.a(A_0);
		}
	}

	// Token: 0x0600C51A RID: 50458 RVA: 0x0044B624 File Offset: 0x00449824
	public ecs yf(euz A_0)
	{
		if (this.e != null && this.e.Vehicle != null && this.e.Vehicle.an() != null)
		{
			MouseState state = Mouse.GetState();
			Point a_ = new Point(state.X, state.Y);
			Point a_2 = base.at();
			Point point = d05.a(a_, a_2, true);
			if (point.X < this.g.Size.c)
			{
				return new ecs(new List<dl6>
				{
					new dl6(new List<bph>
					{
						new bph(new d22(cq4.c(), Color.White), this.e.Vehicle.an().d(), null)
					})
				});
			}
			if (point.X >= this.g.Size.c + this.a && point.X < this.g.Size.c + this.a + this.b.c)
			{
				return new ecs(new List<dl6>
				{
					new dl6(new List<bph>
					{
						new bph(new d22(cq4.c(), Color.White), "Прочность: ", null),
						new bph(new d22(cq4.c(), Color.White), ((int)Math.Ceiling(this.e.Vehicle.ag())).ToString(), null),
						new bph(new d22(cq4.c(), Color.White), " / ", null),
						new bph(new d22(cq4.c(), Color.LightGray), this.e.Vehicle.v().ToString(), null)
					})
				});
			}
			if (point.X >= this.g.Size.c + 2 * this.a + this.b.c && point.X < this.g.Size.c + 2 * this.a + 2 * this.b.c)
			{
				Color red;
				if (this.e.Vehicle.g() == 0.0)
				{
					red = Color.Red;
				}
				else
				{
					red = adi.c;
				}
				return new ecs(new List<dl6>
				{
					new dl6(new List<bph>
					{
						new bph(new d22(cq4.c(), Color.White), "Батарея: ", null),
						new bph(new d22(cq4.c(), red), ((int)Math.Ceiling(this.e.Vehicle.g())).ToString(), null),
						new bph(new d22(cq4.c(), Color.White), " / ", null),
						new bph(new d22(cq4.c(), Color.LightGray), this.e.Vehicle.am().ToString(), null)
					})
				});
			}
		}
		return null;
	}

	// Token: 0x0600C51B RID: 50459 RVA: 0x0044B960 File Offset: 0x00449B60
	private string a()
	{
		bi3 service = bpo.GetService<bi3>();
		if (service != null && service.aij() != null && service.aij().eg() != null)
		{
			if (this.d != null && service.aij().eg().cg(this.d))
			{
				return TimelapseCursor.InvokeSpell.ToString();
			}
			return TimelapseCursor.Impossible.ToString();
		}
		else
		{
			c5x c5x = this.d as c5x;
			if (c5x != null && c5x.IsPlayer)
			{
				return TimelapseCursor.Use.ToString();
			}
			return TimelapseCursor.Default.ToString();
		}
	}

	// Token: 0x0600C51C RID: 50460 RVA: 0x0044BA18 File Offset: 0x00449C18
	private void d(object A_0, b25 A_1)
	{
		this.i.b();
	}

	// Token: 0x0600C51D RID: 50461 RVA: 0x0044BA28 File Offset: 0x00449C28
	private void c(object A_0, b25 A_1)
	{
		this.i.b();
	}

	// Token: 0x0600C51E RID: 50462 RVA: 0x0044BA38 File Offset: 0x00449C38
	private void b(object A_0, b25 A_1)
	{
		this.i.b();
	}

	// Token: 0x0600C51F RID: 50463 RVA: 0x0044BA48 File Offset: 0x00449C48
	private void a(object A_0, b25 A_1)
	{
		if (this.j != null)
		{
			this.j(this, A_1);
		}
	}

	// Token: 0x0600C520 RID: 50464 RVA: 0x0044BA64 File Offset: 0x00449C64
	protected override void ik(object A_0, b25 A_1)
	{
		base.ik(A_0, A_1);
		this.h.b();
	}

	// Token: 0x0600C521 RID: 50465 RVA: 0x0044BA7C File Offset: 0x00449C7C
	protected override void nr(object A_0, b25 A_1)
	{
		base.nr(A_0, A_1);
		this.h.b();
	}

	// Token: 0x0600C522 RID: 50466 RVA: 0x0044BA94 File Offset: 0x00449C94
	protected override void ns(object A_0, b25 A_1)
	{
		base.ns(A_0, A_1);
		this.h.b();
	}

	// Token: 0x0400481A RID: 18458
	private new int a;

	// Token: 0x0400481B RID: 18459
	private new esj b;

	// Token: 0x0400481C RID: 18460
	private new string c;

	// Token: 0x0400481D RID: 18461
	public new b0b d;

	// Token: 0x0400481E RID: 18462
	public new efk e;

	// Token: 0x0400481F RID: 18463
	private new bd8 f;

	// Token: 0x04004820 RID: 18464
	private new dz g;

	// Token: 0x04004821 RID: 18465
	private dsy h;

	// Token: 0x04004822 RID: 18466
	private dsy i;

	// Token: 0x04004823 RID: 18467
	[CompilerGenerated]
	private new EventHandler<b25> j;
}

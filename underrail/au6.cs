using System;
using System.Runtime.CompilerServices;
using System.Threading;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Ouroboros.Core.Logging;

// Token: 0x02000179 RID: 377
[dmo(DisplayName = "Classic Panel", Description = "A classic panel control that is usually used to hold other controls.", InitialWidth = 150, InitialHeight = 150)]
public class au6 : bra
{
	// Token: 0x060009C7 RID: 2503 RVA: 0x00028420 File Offset: 0x00026620
	public cs9 m()
	{
		return this.e;
	}

	// Token: 0x060009C8 RID: 2504 RVA: 0x00028428 File Offset: 0x00026628
	public cs9 h()
	{
		return this.f;
	}

	// Token: 0x060009C9 RID: 2505 RVA: 0x00028430 File Offset: 0x00026630
	public string l()
	{
		return this.m;
	}

	// Token: 0x060009CA RID: 2506 RVA: 0x00028438 File Offset: 0x00026638
	public void b(string A_0)
	{
		if (this.m != A_0)
		{
			this.l = true;
		}
		this.m = A_0;
	}

	// Token: 0x060009CB RID: 2507 RVA: 0x0002845C File Offset: 0x0002665C
	public bp k()
	{
		return this.p;
	}

	// Token: 0x060009CC RID: 2508 RVA: 0x00028468 File Offset: 0x00026668
	public void a(bp A_0)
	{
		if (A_0 != this.p)
		{
			object a_ = this.p;
			this.p = A_0;
			if (this.r != null)
			{
				this.r(this, new c1(a_, A_0));
			}
		}
	}

	// Token: 0x060009CD RID: 2509 RVA: 0x000284B8 File Offset: 0x000266B8
	public bool g()
	{
		return this.q;
	}

	// Token: 0x060009CE RID: 2510 RVA: 0x000284C4 File Offset: 0x000266C4
	public void c(bool A_0)
	{
		if (A_0 != this.q)
		{
			object a_ = this.q;
			this.q = A_0;
			if (this.s != null)
			{
				this.s(this, new c1(a_, A_0));
			}
		}
	}

	// Token: 0x060009CF RID: 2511 RVA: 0x00028514 File Offset: 0x00026714
	public int n()
	{
		return this.e.m();
	}

	// Token: 0x060009D0 RID: 2512 RVA: 0x00028524 File Offset: 0x00026724
	public void a(int A_0)
	{
		this.e.c(A_0);
		this.f.c(A_0);
	}

	// Token: 0x060009D1 RID: 2513 RVA: 0x00028540 File Offset: 0x00026740
	public int i()
	{
		return this.e.i();
	}

	// Token: 0x060009D2 RID: 2514 RVA: 0x00028550 File Offset: 0x00026750
	public void b(int A_0)
	{
		this.e.d(A_0);
		this.f.d(A_0);
	}

	// Token: 0x060009D3 RID: 2515 RVA: 0x0002856C File Offset: 0x0002676C
	public au6() : this("GUI\\ClassicPanel", null, null)
	{
	}

	// Token: 0x060009D4 RID: 2516 RVA: 0x0002857C File Offset: 0x0002677C
	public au6(string A_0, cs9 A_1 = null, cs9 A_2 = null)
	{
		this.m = A_0;
		this.Focusable = true;
		this.Gravity = axy.a;
		if (A_1 != null)
		{
			this.e = A_1;
		}
		else
		{
			this.e = new oz();
		}
		this.e.Visible = false;
		this.e.Gravity = axy.c;
		this.e.IsPrivateComponent = true;
		if (A_2 != null)
		{
			this.f = A_2;
		}
		else
		{
			this.f = new oz();
		}
		this.f.Visible = false;
		this.f.Gravity = axy.c;
		this.f.IsPrivateComponent = true;
		this.e.f(new EventHandler<c1>(this.a));
		this.f.f(new EventHandler<c1>(this.b));
		this.b(new EventHandler<c1>(this.c));
		this.d(new EventHandler<c1>(this.d));
		this.aox(this.e);
		this.aox(this.f);
		this.a(30);
		this.b(100);
	}

	// Token: 0x060009D5 RID: 2517 RVA: 0x000286C4 File Offset: 0x000268C4
	[CompilerGenerated]
	public void b(EventHandler<c1> A_0)
	{
		EventHandler<c1> eventHandler = this.r;
		EventHandler<c1> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<c1> value = (EventHandler<c1>)Delegate.Combine(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler<c1>>(ref this.r, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x060009D6 RID: 2518 RVA: 0x000286FC File Offset: 0x000268FC
	[CompilerGenerated]
	public void a(EventHandler<c1> A_0)
	{
		EventHandler<c1> eventHandler = this.r;
		EventHandler<c1> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<c1> value = (EventHandler<c1>)Delegate.Remove(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler<c1>>(ref this.r, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x060009D7 RID: 2519 RVA: 0x00028734 File Offset: 0x00026934
	[CompilerGenerated]
	public void d(EventHandler<c1> A_0)
	{
		EventHandler<c1> eventHandler = this.s;
		EventHandler<c1> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<c1> value = (EventHandler<c1>)Delegate.Combine(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler<c1>>(ref this.s, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x060009D8 RID: 2520 RVA: 0x0002876C File Offset: 0x0002696C
	[CompilerGenerated]
	public void c(EventHandler<c1> A_0)
	{
		EventHandler<c1> eventHandler = this.s;
		EventHandler<c1> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<c1> value = (EventHandler<c1>)Delegate.Remove(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler<c1>>(ref this.s, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x060009D9 RID: 2521 RVA: 0x000287A4 File Offset: 0x000269A4
	protected virtual void c(object A_0, c1 A_1)
	{
		base.e("ScrollBarsChanged");
	}

	// Token: 0x060009DA RID: 2522 RVA: 0x000287B4 File Offset: 0x000269B4
	protected virtual void d(object A_0, c1 A_1)
	{
		base.e("AlwaysShowScrollBarsChanged");
	}

	// Token: 0x060009DB RID: 2523 RVA: 0x000287C4 File Offset: 0x000269C4
	private void b(object A_0, c1 A_1)
	{
		base.a(new Point(base.aae().X, this.f.l()));
	}

	// Token: 0x060009DC RID: 2524 RVA: 0x000287E8 File Offset: 0x000269E8
	private void a(object A_0, c1 A_1)
	{
		base.a(new Point(this.e.l(), base.aae().Y));
	}

	// Token: 0x060009DD RID: 2525 RVA: 0x0002880C File Offset: 0x00026A0C
	protected override void jq(object A_0, c1 A_1)
	{
		base.jq(A_0, A_1);
		this.j();
	}

	// Token: 0x060009DE RID: 2526 RVA: 0x0002881C File Offset: 0x00026A1C
	protected override void sm(object A_0, c1 A_1)
	{
		base.sm(A_0, A_1);
		this.j();
	}

	// Token: 0x060009DF RID: 2527 RVA: 0x00028830 File Offset: 0x00026A30
	protected void j()
	{
		bool flag = base.q().c > 0;
		bool flag2 = base.q().d > 0;
		if (flag)
		{
			this.e.Visible = true;
			this.e.Location = new Point(this.i, base.Size.d - this.g - this.h);
			this.e.Size = new esj(base.Size.c - (flag2 ? this.g : 0) - this.i * 2, this.g);
			this.e.a(base.q().c + (flag2 ? this.g : this.j));
		}
		else
		{
			this.e.Visible = false;
		}
		if (flag2)
		{
			this.f.Visible = true;
			this.f.Location = new Point(base.Size.c - this.g - this.i, this.h);
			this.f.Size = new esj(this.g, base.Size.d - (flag ? this.g : 0) - this.h * 2);
			this.f.a(base.q().d + (flag ? this.g : this.j));
			return;
		}
		this.f.Visible = false;
	}

	// Token: 0x060009E0 RID: 2528 RVA: 0x000289D4 File Offset: 0x00026BD4
	protected override void it(object A_0, b25 A_1)
	{
		base.it(A_0, A_1);
		if (this.f != null && this.f.Visible && this.f.Enabled)
		{
			cs9 cs = this.f;
			cs.e(cs.l() - this.f.m() * Math.Sign(A_1.c()));
		}
	}

	// Token: 0x060009E1 RID: 2529 RVA: 0x00028A40 File Offset: 0x00026C40
	public override void iv(e6d A_0, cp9 A_1)
	{
		cvq cvq = dr3.e();
		Point point = base.at();
		try
		{
			cne cne = dr3.a();
			if (cne != null)
			{
				Texture2D texture2D = null;
				if (!string.IsNullOrEmpty(this.m))
				{
					texture2D = cne.GetResource<Texture2D>(this.m, null);
				}
				if (texture2D != null)
				{
					esj a_;
					if (this.o != null)
					{
						a_ = this.o.Value;
					}
					else
					{
						a_ = this.a(texture2D);
					}
					c4o.b(A_1, texture2D, a_, Point.Zero, new Rectangle(point.X, point.Y, base.Size.c, base.Size.d), base.Color, true, new Point?(this.n));
				}
			}
		}
		catch (Exception ex)
		{
			if (cvq != null && cvq.n8() && cvq.n9(LogSeverity.Verbose, 110))
			{
				string a_2 = "[GUI] - Failed to render Classic Panel. Exception: " + ex.ToString();
				cvq.n7(LogSeverity.Verbose, 110, a_2);
			}
		}
		base.iv(A_0, A_1);
	}

	// Token: 0x060009E2 RID: 2530 RVA: 0x00028B68 File Offset: 0x00026D68
	protected override Rectangle rv()
	{
		Rectangle result = base.rv();
		result.X += this.j;
		result.Y += this.j;
		result.Width -= this.j;
		result.Height -= this.j;
		if (this.f.Visible)
		{
			result.Width -= this.g;
		}
		else
		{
			result.Width -= this.j;
		}
		if (this.e.Visible)
		{
			result.Height -= this.g;
		}
		else
		{
			result.Height -= this.j;
		}
		return result;
	}

	// Token: 0x060009E3 RID: 2531 RVA: 0x00028C30 File Offset: 0x00026E30
	public esj a(Texture2D A_0)
	{
		if (this.l)
		{
			this.k = c4o.a(A_0, 3, 3);
		}
		return this.k;
	}

	// Token: 0x04000639 RID: 1593
	private new const int a = 3;

	// Token: 0x0400063A RID: 1594
	private new const int b = 3;

	// Token: 0x0400063B RID: 1595
	private new const int c = 30;

	// Token: 0x0400063C RID: 1596
	private new const int d = 100;

	// Token: 0x0400063D RID: 1597
	private new cs9 e;

	// Token: 0x0400063E RID: 1598
	private new cs9 f;

	// Token: 0x0400063F RID: 1599
	public new int g = 16;

	// Token: 0x04000640 RID: 1600
	public new int h;

	// Token: 0x04000641 RID: 1601
	public new int i;

	// Token: 0x04000642 RID: 1602
	public new int j = 3;

	// Token: 0x04000643 RID: 1603
	private new esj k;

	// Token: 0x04000644 RID: 1604
	private new bool l = true;

	// Token: 0x04000645 RID: 1605
	private new string m;

	// Token: 0x04000646 RID: 1606
	public Point n;

	// Token: 0x04000647 RID: 1607
	public esj? o;

	// Token: 0x04000648 RID: 1608
	private new bp p = global::bp.d;

	// Token: 0x04000649 RID: 1609
	private bool q;

	// Token: 0x0400064A RID: 1610
	[CompilerGenerated]
	private EventHandler<c1> r;

	// Token: 0x0400064B RID: 1611
	[CompilerGenerated]
	private EventHandler<c1> s;
}

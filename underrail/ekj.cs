using System;
using System.Runtime.CompilerServices;
using System.Threading;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using TimelapseVertigo.Common.Settings;

// Token: 0x020005B1 RID: 1457
public sealed class ekj : amm
{
	// Token: 0x060026E9 RID: 9961 RVA: 0x000E2898 File Offset: 0x000E0A98
	[CompilerGenerated]
	public void b(EventHandler<EventArgs> A_0)
	{
		EventHandler<EventArgs> eventHandler = this.j;
		EventHandler<EventArgs> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<EventArgs> value = (EventHandler<EventArgs>)Delegate.Combine(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler<EventArgs>>(ref this.j, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x060026EA RID: 9962 RVA: 0x000E28D0 File Offset: 0x000E0AD0
	[CompilerGenerated]
	public void a(EventHandler<EventArgs> A_0)
	{
		EventHandler<EventArgs> eventHandler = this.j;
		EventHandler<EventArgs> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<EventArgs> value = (EventHandler<EventArgs>)Delegate.Remove(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler<EventArgs>>(ref this.j, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x060026EB RID: 9963 RVA: 0x000E2908 File Offset: 0x000E0B08
	public ekj()
	{
		this.a();
	}

	// Token: 0x060026EC RID: 9964 RVA: 0x000E293C File Offset: 0x000E0B3C
	public override void iv(e6d A_0, cp9 A_1)
	{
		Point point = base.at();
		if (A_1.a != null)
		{
			wj wj = wj.a();
			if (wj.d == UiSize.Classic)
			{
				Texture2D resource = A_1.a.GetResource<Texture2D>(bo1.ak, null);
				if (resource != null)
				{
					Rectangle a_ = new Rectangle(point.X, point.Y, base.Size.c, base.Size.d);
					c4o.a(A_1, resource, new esj(50, 50), Point.Zero, a_, Color.White * 0.6f, true, null);
				}
			}
			else
			{
				Texture2D resource2 = A_1.a.GetResource<Texture2D>(wj.f, null);
				if (resource2 != null)
				{
					Rectangle a_2 = new Rectangle(point.X, point.Y, base.Size.c, base.Size.d);
					c4o.a(A_1, resource2, wj.b0, Point.Zero, a_2, Color.White * 0.6f, true, new Point?(wj.bz));
				}
			}
		}
		base.iv(A_0, A_1);
	}

	// Token: 0x060026ED RID: 9965 RVA: 0x000E2A70 File Offset: 0x000E0C70
	private void a()
	{
		wj wj = wj.a();
		if (wj.d != UiSize.Classic)
		{
			this.h = wj.b2;
			this.a = wj.b3;
			this.b = wj.b4;
			this.i = wj.b5;
		}
		int num = 8;
		int num2 = 0;
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		ekj.a(serviceOrThrow.aqu().v().SpecialAttacks, ref num);
		ekj.a(serviceOrThrow.aqu().v().SpecialAbilities, ref num);
		ekj.a(serviceOrThrow.aqu().v().PsiAbilities, ref num);
		ekj.a(serviceOrThrow.aqu().v().EquippedCapabilities, ref num);
		num = Math.Min(16, num);
		num2 += this.a;
		this.a(serviceOrThrow.aqu().v().SpecialAttacks, num, ref num2, false, false);
		this.a(serviceOrThrow.aqu().v().EquippedCapabilities, num, ref num2, false, false);
		this.a(serviceOrThrow.aqu().v().SpecialAbilities, num, ref num2, false, false);
		this.a(serviceOrThrow.aqu().v().PsiAbilities, num, ref num2, false, dm9.f);
		num2 += this.a;
		base.Size = new esj(2 * this.a + num * (this.h.c + this.b) - this.b, num2);
	}

	// Token: 0x060026EE RID: 9966 RVA: 0x000E2BE0 File Offset: 0x000E0DE0
	private static void a(cyr A_0, ref int A_1)
	{
		if (A_0.a() == 0)
		{
			return;
		}
		A_1 = Math.Max(A_1, (int)Math.Ceiling((double)A_0.a() / 2.0));
	}

	// Token: 0x060026EF RID: 9967 RVA: 0x000E2C10 File Offset: 0x000E0E10
	private static void a(cyr[] A_0, ref int A_1)
	{
		int num = 0;
		if (A_0 != null && A_0.Length != 0)
		{
			foreach (cyr cyr in A_0)
			{
				num += cyr.a();
			}
		}
		if (num > 0)
		{
			A_1 = Math.Max(A_1, (int)Math.Ceiling((double)num / 2.0));
		}
	}

	// Token: 0x060026F0 RID: 9968 RVA: 0x000E2C74 File Offset: 0x000E0E74
	private void a(cyr A_0, int A_1, ref int A_2, bool A_3 = false, bool A_4 = false)
	{
		wj wj = wj.a();
		if (A_0.a() == 0)
		{
			return;
		}
		int num = A_2;
		if (num != this.a)
		{
			num += 13;
		}
		avo avo = new avo();
		avo.Location = new Point(this.a, num);
		avo.a(true);
		avo.a(this.i);
		avo.Color = ekj.e;
		avo.Text = A_0.y8();
		num += avo.Size.d + 5;
		int num2 = 0;
		au2 au = ces.c();
		int num3 = 0;
		for (int i = 0; i < A_0.a(); i++)
		{
			num2 = num3 / A_1;
			int num4 = num3 - num2 * A_1;
			c3n c3n = A_0.a(i);
			if (!A_4 || au == null || au.Offense.a(c3n.TechnicalName))
			{
				dlb dlb;
				if (wj.d == UiSize.Classic)
				{
					dlb = new dlb();
					dlb.Size = this.h;
					dlb.c(bo1.ae);
				}
				else
				{
					dlb = new dlb(wj.b2, wj.o);
					dlb.c(wj.f);
				}
				dlb.Location = new Point(this.a + num4 * (this.h.c + this.b), num + num2 * (this.h.d + this.b));
				dlb.a(ecf.a(c3n, new dsx(), null));
				dlb.e(epu.a);
				dlb.h(Color.Orange);
				dlb.Color = epu.a;
				dlb.g(adi.a * 0.5f);
				dlb.f(adi.a * 0.5f);
				dlb.a(new Color(0, 0, 255) * 0.5f);
				dlb.d(new Color(255, 0, 0) * 0.5f);
				dlb.a(0);
				dlb.c(Color.Purple * 0.45f);
				dlb.p(new EventHandler<b25>(this.a));
				this.aox(dlb);
				num3++;
			}
		}
		if (num3 > 0)
		{
			this.aox(avo);
			num += (num2 + 1) * (this.h.d + this.b) - this.b;
			A_2 = num;
		}
	}

	// Token: 0x060026F1 RID: 9969 RVA: 0x000E2F00 File Offset: 0x000E1100
	private void a(object A_0, b25 A_1)
	{
		if (A_1.b() == eoo.b)
		{
			eb1 eb = A_0 as eb1;
			if (eb.zc() != null && eb.zc().yw())
			{
				if (this.j != null)
				{
					this.j(A_0, new EventArgs());
				}
				base.z();
				return;
			}
		}
		else if (A_1.b() == eoo.d)
		{
			base.z();
		}
	}

	// Token: 0x060026F2 RID: 9970 RVA: 0x000E2F70 File Offset: 0x000E1170
	protected override void vt(object A_0, b25 A_1)
	{
		base.vt(A_0, A_1);
		if (A_1.b() == eoo.d)
		{
			base.z();
		}
	}

	// Token: 0x0400162F RID: 5679
	private new int a = 20;

	// Token: 0x04001630 RID: 5680
	private new int b = 5;

	// Token: 0x04001631 RID: 5681
	private new const int c = 13;

	// Token: 0x04001632 RID: 5682
	private new const int d = 5;

	// Token: 0x04001633 RID: 5683
	private new static readonly Color e = adi.a;

	// Token: 0x04001634 RID: 5684
	private new const int f = 8;

	// Token: 0x04001635 RID: 5685
	private new const int g = 16;

	// Token: 0x04001636 RID: 5686
	private esj h = eb1.a;

	// Token: 0x04001637 RID: 5687
	private string i = egg.ap;

	// Token: 0x04001638 RID: 5688
	[CompilerGenerated]
	private new EventHandler<EventArgs> j;
}

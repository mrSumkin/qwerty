using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;

// Token: 0x02000598 RID: 1432
public sealed class c15 : a9t, amj
{
	// Token: 0x0600251E RID: 9502 RVA: 0x000D2854 File Offset: 0x000D0A54
	public c15(dbi A_0, ebk A_1, csy A_2, bool A_3)
	{
		czh.a(A_0, "container");
		this.i = A_3;
		this.d = A_0;
		this.e = A_1;
		this.f = A_2;
		this.b();
	}

	// Token: 0x0600251F RID: 9503 RVA: 0x000D288C File Offset: 0x000D0A8C
	public new void d()
	{
		this.a();
		if (this.a.k() == null || this.a.k() == c65.b())
		{
			base.z();
		}
	}

	// Token: 0x06002520 RID: 9504 RVA: 0x000D28C0 File Offset: 0x000D0AC0
	public void c()
	{
		this.a.v();
	}

	// Token: 0x06002521 RID: 9505 RVA: 0x000D28D0 File Offset: 0x000D0AD0
	public override void iv(e6d A_0, cp9 A_1)
	{
		base.iv(A_0, A_1);
		if (this.k != null)
		{
			this.k.a(A_0);
		}
	}

	// Token: 0x06002522 RID: 9506 RVA: 0x000D28F4 File Offset: 0x000D0AF4
	public override void ag5(e6d A_0)
	{
		base.ag5(A_0);
		if (this.i)
		{
			rc rc = this.f as rc;
			if (rc != null && rc.c() != null && rc.d() != null)
			{
				this.g.wk(Math.Min(1.5f, (float)rc.c().aa().Suspicion));
				if (this.j != null && this.j.x6() != null)
				{
					double a_ = 1.0;
					if (rc.d().aa().Feats.Contains<b1w>())
					{
						bm6 bm = rc.c().a8().t.b;
						if (bm != null && !bm.a(rc.d()))
						{
							a_ = 1.0 - ((double)b1w.b + (double)rc.d().aa().GetSpecializationValue<bh5>(true) * bh5.a);
						}
					}
					double num = b87.a(rc.d().aa(), rc.c().aa(), this.j.x6(), a_);
					double num2 = rc.c().aa().Suspicion + num;
					this.h.wk(Math.Min(1.5f, (float)num2));
					if (num2 >= 1.5)
					{
						this.h.Color = Color.Red * 0.5f;
						return;
					}
					this.h.Color = Color.Yellow * 0.5f;
					return;
				}
				else
				{
					this.h.Color = Color.Yellow * 0.5f;
					this.h.wk(0f);
				}
			}
		}
	}

	// Token: 0x06002523 RID: 9507 RVA: 0x000D2ABC File Offset: 0x000D0CBC
	public ecs yf(euz A_0)
	{
		if (A_0 == this.g)
		{
			ecs ecs = new ecs();
			dl6 item = new dl6(new List<bph>
			{
				new bph(new d22(cq4.d(), Color.Yellow), "Подозрение", null)
			});
			dl6 item2 = new dl6(new List<bph>
			{
				new bph(new d22(cq4.c(), Color.LightGray), "Эта полоска заполняется, когда вы воруете предметы. Если она заполнится до конца, ваша кража будет обнаружена.", null)
			});
			ecs.a.Add(item);
			ecs.a.Add(item2);
			return ecs;
		}
		return null;
	}

	// Token: 0x06002524 RID: 9508 RVA: 0x000D2B4C File Offset: 0x000D0D4C
	private void b()
	{
		wj wj = wj.a();
		this.a = new b3w(this.d, this.f, false, !this.i, false, false, 0, false);
		if (wj.c())
		{
			this.a.Location = new Point(10, 40);
			this.a.b(8, this.i ? 3 : 6);
		}
		else
		{
			this.a.Location = new Point(10, wj.ci.d + 10);
			if (this.i)
			{
				this.a.a(wj.dk);
			}
			else
			{
				this.a.a(wj.dj);
			}
		}
		this.a.d(new EventHandler<b25>(this.e));
		this.a.a(new EventHandler<b25>(this.d));
		this.a.c(!this.i);
		this.a.Gravity = axy.c;
		if (this.i)
		{
			this.a.a(new ao2());
			this.a.a(new Func<ebk, coh, bool>(c15.a.a.a));
		}
		this.aox(this.a);
		if (this.i)
		{
			base.Size = new esj(this.a.Size.c + 20, this.a.Size.d + 75);
			this.h = new bam();
			this.h.wi(1.5f);
			this.h.Color = Color.Yellow * 0.5f;
			if (wj.c())
			{
				this.h.Location = new Point(10, base.Size.d - 25);
				this.h.Size = new esj(base.Size.c - 20, 15);
				this.h.a(bo1.i);
			}
			else
			{
				this.h.Size = new esj(base.Size.c - 20, wj.bt.d);
				this.h.Location = new Point(10, this.a.Location.Y + this.a.Size.d + 10);
			}
			this.aox(this.h);
			this.g = new bam();
			this.g.g = false;
			this.g.wi(1.5f);
			this.g.Color = Color.Yellow;
			if (wj.c())
			{
				this.g.Location = new Point(10, base.Size.d - 25);
				this.g.Size = new esj(base.Size.c - 20, 15);
				this.g.a(bo1.i);
			}
			else
			{
				this.g.Size = this.h.Size;
				this.g.Location = this.h.Location;
			}
			this.g.j(new EventHandler<b25>(this.a));
			this.g.l(new EventHandler<b25>(this.b));
			this.aox(this.g);
			this.k = new dsy(this.g, this, esj.a(), 300, null, null, 300, false, false);
			this.a.c(new EventHandler<b25>(this.c));
			if (!wj.c())
			{
				esj esj = new esj(this.a.Size.c + (int)(1.5 * (double)this.a.Location.X), this.a.Location.Y + this.a.Size.d + 20 + this.h.Size.d);
				esj.d += wj.g - esj.d % wj.g;
				base.Size = esj;
				return;
			}
		}
		else
		{
			this.c = new dak();
			this.c.Text = "Упорядочить";
			this.a(wj, this.c);
			this.c.h = Color.Black;
			this.c.i = Color.Black;
			this.c.g = adi.a;
			this.c.j = adi.b;
			this.c.Enabled = (this.e != null);
			this.c.Gravity = axy.b;
			this.c.c(new EventHandler<b25>(this.f));
			e4z.j(this.c);
			this.aox(this.c);
			this.b = new dak();
			this.b.Text = "Взять всё";
			this.a(wj, this.b);
			this.b.h = Color.Black;
			this.b.i = Color.Black;
			this.b.g = adi.a;
			this.b.j = adi.b;
			this.b.Enabled = (this.e != null);
			this.b.Gravity = axy.b;
			this.b.c(new EventHandler<b25>(this.g));
			e4z.j(this.b);
			this.aox(this.b);
			if (wj.c())
			{
				base.Size = new esj(this.a.Size.c + 25, this.a.Size.d + this.b.Size.d + 68);
				if (base.Size.d % 2 != 0)
				{
					base.Size = new esj(base.Size.c, base.Size.d + 1);
				}
			}
			else
			{
				esj esj2 = new esj(this.a.Size.c + (int)(1.5 * (double)this.a.Location.X), this.a.Location.Y + this.a.Size.d + 20 + this.c.Size.d);
				esj2.d += wj.g - esj2.d % wj.g;
				base.Size = esj2;
			}
			this.c.Location = new Point((base.Size.c - (this.c.Size.c + this.b.Size.c + 10)) / 2, this.a.Location.Y + this.a.Size.d + 10);
			this.b.Location = new Point(this.c.Location.X + this.c.Size.c + 10, this.c.Location.Y);
		}
	}

	// Token: 0x06002525 RID: 9509 RVA: 0x000D3310 File Offset: 0x000D1510
	private void a(wj A_0, dak A_1)
	{
		if (A_0.c())
		{
			if (egg.v)
			{
				A_1.Font = egg.a;
				A_1.TextLabelOffset = new Point(0, 6);
			}
			else
			{
				A_1.Font = egg.ap;
				A_1.TextLabelOffset = new Point(0, egg.b(A_1.Font));
			}
			A_1.Size = new esj(155, 25);
			A_1.d = bo1.z;
			return;
		}
		A_1.Font = A_0.c5;
		A_1.TextLabelOffset = new Point(0, egg.b(A_1.Font));
		A_1.Size = A_0.dl;
		A_1.d = A_0.f;
		A_1.f = A_0.e7;
		A_1.e = new esj?(A_0.e8);
	}

	// Token: 0x06002526 RID: 9510 RVA: 0x000D33E8 File Offset: 0x000D15E8
	private void a()
	{
		object a_ = this.a.m();
		foreach (coh coh in Enumerable.ToList<coh>(this.a.x().z2()))
		{
			if (this.a.x() == null)
			{
				break;
			}
			if (this.a.s() != null && !this.a.s().kj(this.a.x(), coh, a_))
			{
				break;
			}
			this.a.x().z5(coh);
			c69.a(this.a, this.e, coh, true);
			if (this.a.s() != null)
			{
				this.a.s().kl(this.a.x(), coh, a_);
			}
		}
	}

	// Token: 0x06002527 RID: 9511 RVA: 0x000D34F8 File Offset: 0x000D16F8
	private void a(cqy A_0)
	{
		if (A_0.yx() != null && (this.a.s() == null || this.a.s().kj(this.a.x(), A_0.yx(), this.a.m())) && c69.a(A_0, this.e, A_0.x6(), true))
		{
			e4z.c();
		}
	}

	// Token: 0x06002528 RID: 9512 RVA: 0x000D3570 File Offset: 0x000D1770
	private new void g(object A_0, b25 A_1)
	{
		this.d();
	}

	// Token: 0x06002529 RID: 9513 RVA: 0x000D3578 File Offset: 0x000D1778
	private new void f(object A_0, b25 A_1)
	{
		this.c();
	}

	// Token: 0x0600252A RID: 9514 RVA: 0x000D3584 File Offset: 0x000D1784
	private new void e(object A_0, b25 A_1)
	{
		if (A_1.b() == eoo.d && this.e != null)
		{
			cqy cqy = A_0 as cqy;
			if (cqy != null)
			{
				this.a(cqy);
			}
		}
		if (A_1.b() == eoo.b)
		{
			KeyboardState state = Keyboard.GetState();
			if ((state.IsKeyDown(Keys.LeftAlt) || state.IsKeyDown(Keys.RightAlt)) && this.e != null)
			{
				cqy cqy2 = A_0 as cqy;
				if (cqy2 != null)
				{
					this.a(cqy2);
				}
			}
		}
	}

	// Token: 0x0600252B RID: 9515 RVA: 0x000D3610 File Offset: 0x000D1810
	private new void d(object A_0, b25 A_1)
	{
		if (A_1.b() == eoo.b && this.e != null)
		{
			cqy cqy = A_0 as cqy;
			if (cqy != null)
			{
				this.a(cqy);
			}
		}
	}

	// Token: 0x0600252C RID: 9516 RVA: 0x000D3648 File Offset: 0x000D1848
	private void c(object A_0, b25 A_1)
	{
		this.j = (A_0 as cqy);
	}

	// Token: 0x0600252D RID: 9517 RVA: 0x000D3658 File Offset: 0x000D1858
	private void b(object A_0, b25 A_1)
	{
		this.k.b();
	}

	// Token: 0x0600252E RID: 9518 RVA: 0x000D3668 File Offset: 0x000D1868
	private void a(object A_0, b25 A_1)
	{
		this.k.b();
	}

	// Token: 0x04001589 RID: 5513
	public new b3w a;

	// Token: 0x0400158A RID: 5514
	private new dak b;

	// Token: 0x0400158B RID: 5515
	private new dak c;

	// Token: 0x0400158C RID: 5516
	private new dbi d;

	// Token: 0x0400158D RID: 5517
	private new ebk e;

	// Token: 0x0400158E RID: 5518
	private new csy f;

	// Token: 0x0400158F RID: 5519
	private new bam g;

	// Token: 0x04001590 RID: 5520
	private new bam h;

	// Token: 0x04001591 RID: 5521
	private new bool i;

	// Token: 0x04001592 RID: 5522
	private new cqy j;

	// Token: 0x04001593 RID: 5523
	private new dsy k;

	// Token: 0x02002031 RID: 8241
	[CompilerGenerated]
	[Serializable]
	private new sealed class a
	{
		// Token: 0x0600C309 RID: 49929 RVA: 0x00437CEC File Offset: 0x00435EEC
		internal bool a(ebk A_0, coh A_1)
		{
			return false;
		}

		// Token: 0x040046C3 RID: 18115
		public static readonly c15.a a = new c15.a();

		// Token: 0x040046C4 RID: 18116
		public static Func<ebk, coh, bool> b;
	}
}

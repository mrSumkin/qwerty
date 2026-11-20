using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using Microsoft.Xna.Framework;

// Token: 0x02002069 RID: 8297
public sealed class eis : ec9
{
	// Token: 0x0600C5CE RID: 50638 RVA: 0x00451AD0 File Offset: 0x0044FCD0
	[CompilerGenerated]
	public void b(EventHandler A_0)
	{
		EventHandler eventHandler = this.m;
		EventHandler eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler value = (EventHandler)Delegate.Combine(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.m, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x0600C5CF RID: 50639 RVA: 0x00451B08 File Offset: 0x0044FD08
	[CompilerGenerated]
	public new void c(EventHandler A_0)
	{
		EventHandler eventHandler = this.m;
		EventHandler eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler value = (EventHandler)Delegate.Remove(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.m, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x0600C5D0 RID: 50640 RVA: 0x00451B40 File Offset: 0x0044FD40
	[CompilerGenerated]
	public new void d(EventHandler A_0)
	{
		EventHandler eventHandler = this.n;
		EventHandler eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler value = (EventHandler)Delegate.Combine(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.n, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x0600C5D1 RID: 50641 RVA: 0x00451B78 File Offset: 0x0044FD78
	[CompilerGenerated]
	public void a(EventHandler A_0)
	{
		EventHandler eventHandler = this.n;
		EventHandler eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler value = (EventHandler)Delegate.Remove(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.n, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x0600C5D2 RID: 50642 RVA: 0x00451BB0 File Offset: 0x0044FDB0
	public bool g()
	{
		return this.h.Checked;
	}

	// Token: 0x0600C5D3 RID: 50643 RVA: 0x00451BC0 File Offset: 0x0044FDC0
	public void a(bool A_0)
	{
		if (this.h.Checked != A_0)
		{
			this.h.Checked = A_0;
		}
	}

	// Token: 0x0600C5D4 RID: 50644 RVA: 0x00451BE4 File Offset: 0x0044FDE4
	public eis(an2 A_0, bool A_1)
	{
		czh.a(A_0, "feats");
		wj wj = wj.a();
		this.f = A_0;
		this.k = A_1;
		this.l = (this.f.re() as e3q);
		if (wj.c())
		{
			this.c = bo1.r;
		}
		else
		{
			this.c = wj.f;
			this.e = wj.b8;
			this.d = new esj?(wj.b9);
		}
		if (wj.c())
		{
			this.g = new bdl();
		}
		else
		{
			this.g = new dg8();
			this.d = wj.bm.c;
			this.a = wj.gp;
			this.c = wj.gq;
			this.b = wj.gr;
		}
		this.g.Gravity = axy.c;
		this.g.IsPrivateComponent = true;
		this.g.c(1);
		this.g.d(5);
		this.g.e(0);
		this.g.f(new EventHandler<c1>(this.f));
		e4z.c(this.g.d());
		e4z.c(this.g.e());
		e4z.d(this.g.h());
		this.aox(this.g);
		if (wj.c())
		{
			eki eki = new eki();
			eki.IsPrivateComponent = true;
			eki.Checked = false;
			eki.b(egg.b);
			eki.Location = new Point(40, 570);
			eki.a(new Point(10, 6));
			eki.a(true);
			eki.a(adi.a);
			eki.c(adi.b);
			this.h = eki;
		}
		else
		{
			aad aad = new aad();
			aad.IsPrivateComponent = true;
			aad.Checked = false;
			aad.a(wj.gm);
			aad.a(new Point(this.c, wj.gn));
			aad.a(true);
			aad.a(adi.a);
			aad.c(adi.b);
			this.h = aad;
		}
		this.h.Text = "Показать все умения";
		this.h.c(new EventHandler<c1>(this.d));
		e4z.g(this.h);
		this.aox(this.h);
		this.i = new avo();
		this.i.Location = new Point(40, 550);
		this.i.Text = "Фильтр:";
		if (wj.c())
		{
			this.i.a(egg.b);
		}
		else
		{
			this.i.a(wj.gm);
		}
		this.i.a(true);
		this.i.Color = adi.a;
		this.i.IsPrivateComponent = true;
		this.aox(this.i);
		this.j = new c68();
		if (wj.c())
		{
			this.j.e = bo1.b;
			this.j.a(egg.b);
			this.j.b(20);
			this.j.a(new Point(15, 6));
			this.j.Size = new esj(305, 33);
		}
		else
		{
			this.j.e = wj.f;
			this.j.f = wj.fg;
			this.j.g = new esj?(wj.fh);
			this.j.a(wj.gu);
			this.j.k = true;
			this.j.a(new Point(this.c, wj.gv));
			this.j.a(true);
			this.j.Size = new esj(305, wj.gk);
		}
		this.j.o(new EventHandler<c1>(this.a));
		this.j.e(new EventHandler(this.a));
		this.j.j = "[пусто]";
		this.j.a(new Vector2(32f, 1105f));
		for (int i = 91; i <= 96; i++)
		{
			this.j.q().Add((char)i);
		}
		bl9.a(this.j);
		this.j.m().Add(' ');
		this.j.m().Add('-');
		this.j.m().Add('\'');
		this.aox(this.j);
		this.f();
		this.d();
		this.c();
	}

	// Token: 0x0600C5D5 RID: 50645 RVA: 0x00452104 File Offset: 0x00450304
	private void f()
	{
		this.e = new SortedList<ai8, bdv>(new eis.b(this.l));
		foreach (ai8 ai in ck.b())
		{
			if (ai.Enabled && ai.Visible && (ai.Purchasable || this.l.Feats.a(ai)) && (this.l.Level > aiy.bk || !ai.Veteran) && (ai.DLC == null || dk2.b(ai.DLC)) && (ai.IsAvailableToMutant || !this.l.b(d8o.t)))
			{
				this.e.Add(ai, this.a(ai));
			}
		}
	}

	// Token: 0x0600C5D6 RID: 50646 RVA: 0x00452214 File Offset: 0x00450414
	private bdv a(ai8 A_0)
	{
		bdv bdv = new bdv(A_0.GetType(), eis.a(this.l, A_0, true));
		bdv.Size = new esj(1, this.a);
		bdv.Location = new Point(this.c, 10);
		bdv.j(new EventHandler<b25>(this.b));
		bdv.c(new EventHandler<c1>(this.e));
		bdv.t(new EventHandler<b25>(this.a));
		return bdv;
	}

	// Token: 0x0600C5D7 RID: 50647 RVA: 0x00452294 File Offset: 0x00450494
	private new void e()
	{
		using (List<ai8>.Enumerator enumerator = Enumerable.ToList<ai8>(this.f).GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				eis.a a = new eis.a();
				a.a = enumerator.Current;
				if (!a.a.d(this.f.re()))
				{
					bdv bdv = Enumerable.FirstOrDefault<bdv>(Enumerable.Where<bdv>(this.e.Values, new Func<bdv, bool>(a.a)));
					if (bdv != null)
					{
						bdv.Checked = false;
					}
				}
			}
		}
	}

	// Token: 0x0600C5D8 RID: 50648 RVA: 0x00452340 File Offset: 0x00450540
	private new void d()
	{
		if (this.l != null && this.e != null)
		{
			foreach (bdv bdv in this.e.Values)
			{
				ai8 a_ = ck.b(bdv.FeatType);
				if (!bdv.Checked && bdv.FeatAvailability != c7s.a)
				{
					if (this.l.j() <= 0)
					{
						bdv.FeatAvailability = c7s.c;
					}
					else
					{
						bdv.FeatAvailability = eis.a(this.l, a_, false);
					}
				}
			}
		}
		this.c();
	}

	// Token: 0x0600C5D9 RID: 50649 RVA: 0x00452404 File Offset: 0x00450604
	private void b(Type A_0)
	{
		if (this.l != null)
		{
			e3q e3q = this.l;
			int num = e3q.j();
			e3q.f(num - 1);
		}
		this.f.d(A_0);
		if (this.l != null)
		{
			this.l.bl();
		}
	}

	// Token: 0x0600C5DA RID: 50650 RVA: 0x00452454 File Offset: 0x00450654
	private void a(Type A_0)
	{
		if (this.l != null)
		{
			e3q e3q = this.l;
			int num = e3q.j();
			e3q.f(num + 1);
		}
		this.f.b(A_0);
		if (this.l != null)
		{
			this.l.bl();
		}
	}

	// Token: 0x0600C5DB RID: 50651 RVA: 0x004524A4 File Offset: 0x004506A4
	private new void c()
	{
		wj wj = wj.a();
		if (wj.c())
		{
			this.h.Location = new Point(this.c, base.Size.d - (this.c + this.h.Size.d));
			this.i.Location = new Point(this.c, this.h.Location.Y - this.i.Size.d);
			this.j.Location = new Point(this.i.Location.X + this.i.Size.c + 5, this.i.Location.Y - 7);
		}
		int num = (base.Size.d - 3 * this.c + this.b - this.h.Size.d - this.i.Size.d) / (this.a + this.b);
		List<bdv> list = null;
		if (this.k)
		{
			if (this.h.Checked)
			{
				list = new List<bdv>(Enumerable.ToList<bdv>(Enumerable.Where<bdv>(this.e.Values, new Func<bdv, bool>(this.d))));
			}
			else
			{
				list = Enumerable.ToList<bdv>(Enumerable.Where<bdv>(this.e.Values, new Func<bdv, bool>(this.c)));
			}
		}
		else if (this.h.Checked)
		{
			list = new List<bdv>(Enumerable.ToList<bdv>(Enumerable.Where<bdv>(this.e.Values, new Func<bdv, bool>(this.b))));
		}
		else
		{
			list = Enumerable.ToList<bdv>(Enumerable.Where<bdv>(this.e.Values, new Func<bdv, bool>(this.a)));
		}
		if (list.Count > num)
		{
			this.g.Visible = true;
			this.g.a(list.Count - num);
			this.g.Location = new Point(base.Size.c - this.d, 0);
			this.g.Size = new esj(this.d, base.Size.d - 1);
			this.g.b(0);
			if (this.g.l() > this.g.k())
			{
				this.g.e(this.g.k());
			}
		}
		else
		{
			this.g.e(0);
			this.g.Visible = false;
		}
		foreach (bdv a_ in Enumerable.ToList<bdv>(Enumerable.OfType<bdv>(base.Controls)))
		{
			this.g(a_);
		}
		int num2 = 0;
		while (num2 < num && num2 + this.g.l() < list.Count)
		{
			euz euz = list[num2 + this.g.l()];
			euz.Location = new Point(this.c, this.c + num2 * (this.a + this.b));
			euz.Size = new esj(base.Size.c - 2 * this.c - (this.g.Visible ? this.d : 0), this.a);
			this.aox(euz);
			num2++;
		}
		if (!wj.c())
		{
			this.h.Location = new Point(this.c, base.Size.d - this.h.Size.d - this.c);
			this.i.Location = new Point(this.h.Location.X, this.h.Location.Y - this.i.Size.d);
			int num3 = (this.j.Size.d - this.i.Size.d) / 2;
			this.j.Location = new Point(this.i.Location.X + this.i.Size.c + this.c / 2, this.i.Location.Y - num3 - this.j.e().Y);
			this.j.Size = new esj(base.Size.c - this.j.Location.X - 2 * this.c, this.j.Size.d);
		}
	}

	// Token: 0x0600C5DC RID: 50652 RVA: 0x004529BC File Offset: 0x00450BBC
	private new bool e(bdv A_0)
	{
		ai8 ai = ck.b(A_0.FeatType);
		if (ai == null)
		{
			return false;
		}
		string value = (this.j.Text ?? "").Trim().ToLowerInvariant();
		if (string.IsNullOrWhiteSpace(value))
		{
			return !ai.Veteran || dk2.d() > 0;
		}
		if (!ai.Purchasable && "trained".Contains(value))
		{
			return true;
		}
		if (ai.Veteran && "veteran".Contains(value))
		{
			return true;
		}
		if (ai8.a(ai).ToLowerInvariant().Contains(value))
		{
			return true;
		}
		if (!string.IsNullOrEmpty(ai.DLC) && dk2.c(ai.DLC).ToLowerInvariant().Contains(value))
		{
			return true;
		}
		string text = qv.a("Feats/" + ai.wn(), ai.at());
		if (!string.IsNullOrEmpty(text) && text.ToLowerInvariant().Contains(value))
		{
			return true;
		}
		List<brl> list = ai.j0();
		if (list != null)
		{
			using (List<brl>.Enumerator enumerator = list.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current.ToString().ToLowerInvariant().Contains(value))
					{
						return true;
					}
				}
			}
			return false;
		}
		return false;
	}

	// Token: 0x0600C5DD RID: 50653 RVA: 0x00452B4C File Offset: 0x00450D4C
	private static c7s a(e3q A_0, ai8 A_1, bool A_2)
	{
		if (A_0 == null)
		{
			return c7s.c;
		}
		if (A_2 && A_0.Feats != null && A_0.Feats.a(A_1))
		{
			return c7s.a;
		}
		if (A_1.Purchasable && A_1.d(A_0) && (A_0.Level > aiy.bk || !A_1.Veteran) && (A_1.DLC == null || dk2.b(A_1.DLC)))
		{
			return c7s.b;
		}
		return c7s.c;
	}

	// Token: 0x0600C5DE RID: 50654 RVA: 0x00452BD8 File Offset: 0x00450DD8
	private void b()
	{
		if (this.l != null)
		{
			this.l.Skills.b(new EventHandler<c1>(this.c));
			this.l.BaseAbilities.b(new EventHandler<c1>(this.b));
			this.l.Feats.b(new EventHandler<EventArgs>(this.c));
			this.l.Feats.a(new EventHandler<EventArgs>(this.b));
		}
	}

	// Token: 0x0600C5DF RID: 50655 RVA: 0x00452C60 File Offset: 0x00450E60
	private void a()
	{
		if (this.l != null)
		{
			this.l.Skills.a(new EventHandler<c1>(this.c));
			this.l.BaseAbilities.a(new EventHandler<c1>(this.b));
			this.l.Feats.c(new EventHandler<EventArgs>(this.c));
			this.l.Feats.d(new EventHandler<EventArgs>(this.b));
		}
	}

	// Token: 0x0600C5E0 RID: 50656 RVA: 0x00452CE8 File Offset: 0x00450EE8
	protected override void i0()
	{
		base.i0();
		this.b();
	}

	// Token: 0x0600C5E1 RID: 50657 RVA: 0x00452CF8 File Offset: 0x00450EF8
	protected override void i1()
	{
		base.i1();
		this.a();
	}

	// Token: 0x0600C5E2 RID: 50658 RVA: 0x00452D08 File Offset: 0x00450F08
	protected override void jq(object A_0, c1 A_1)
	{
		base.jq(A_0, A_1);
		this.c();
	}

	// Token: 0x0600C5E3 RID: 50659 RVA: 0x00452D18 File Offset: 0x00450F18
	private void f(object A_0, c1 A_1)
	{
		this.c();
	}

	// Token: 0x0600C5E4 RID: 50660 RVA: 0x00452D20 File Offset: 0x00450F20
	private void b(object A_0, b25 A_1)
	{
		if (this.n != null)
		{
			this.n(A_0, new EventArgs());
		}
	}

	// Token: 0x0600C5E5 RID: 50661 RVA: 0x00452D40 File Offset: 0x00450F40
	private new void e(object A_0, c1 A_1)
	{
		bdv bdv = A_0 as bdv;
		if ((bool)A_1.a())
		{
			this.b(bdv.FeatType);
		}
		else
		{
			this.a(bdv.FeatType);
		}
		if (this.m != null)
		{
			this.m(this, new EventArgs());
		}
	}

	// Token: 0x0600C5E6 RID: 50662 RVA: 0x00452DA0 File Offset: 0x00450FA0
	private void a(object A_0, b25 A_1)
	{
		bdl bdl = this.g;
		bdl.e(bdl.l() - this.g.m() * Math.Sign(A_1.c()));
		this.c();
	}

	// Token: 0x0600C5E7 RID: 50663 RVA: 0x00452DDC File Offset: 0x00450FDC
	private new void d(object A_0, c1 A_1)
	{
		this.c();
	}

	// Token: 0x0600C5E8 RID: 50664 RVA: 0x00452DE4 File Offset: 0x00450FE4
	private new void c(object A_0, c1 A_1)
	{
		if ((int)A_1.a() < (int)A_1.b())
		{
			this.e();
		}
		this.d();
	}

	// Token: 0x0600C5E9 RID: 50665 RVA: 0x00452E10 File Offset: 0x00451010
	private void b(object A_0, c1 A_1)
	{
		if ((int)A_1.a() < (int)A_1.b())
		{
			this.e();
		}
		this.d();
	}

	// Token: 0x0600C5EA RID: 50666 RVA: 0x00452E3C File Offset: 0x0045103C
	private new void c(object A_0, EventArgs A_1)
	{
		this.d();
	}

	// Token: 0x0600C5EB RID: 50667 RVA: 0x00452E44 File Offset: 0x00451044
	private void b(object A_0, EventArgs A_1)
	{
		this.e();
		this.d();
	}

	// Token: 0x0600C5EC RID: 50668 RVA: 0x00452E54 File Offset: 0x00451054
	protected override void it(object A_0, b25 A_1)
	{
		base.it(A_0, A_1);
		bdl bdl = this.g;
		bdl.e(bdl.l() - this.g.m() * Math.Sign(A_1.c()));
		this.c();
	}

	// Token: 0x0600C5ED RID: 50669 RVA: 0x00452E98 File Offset: 0x00451098
	private void a(object A_0, c1 A_1)
	{
		this.c();
	}

	// Token: 0x0600C5EE RID: 50670 RVA: 0x00452EA0 File Offset: 0x004510A0
	private void a(object A_0, EventArgs A_1)
	{
		bl9.a(this.j, aqo.a, new Point?(new Point(10000, 0)));
	}

	// Token: 0x0600C5EF RID: 50671 RVA: 0x00452EC0 File Offset: 0x004510C0
	[CompilerGenerated]
	private new bool d(bdv A_0)
	{
		return this.e(A_0);
	}

	// Token: 0x0600C5F0 RID: 50672 RVA: 0x00452ECC File Offset: 0x004510CC
	[CompilerGenerated]
	private new bool c(bdv A_0)
	{
		return A_0.FeatAvailability == c7s.a && this.e(A_0);
	}

	// Token: 0x0600C5F1 RID: 50673 RVA: 0x00452EE4 File Offset: 0x004510E4
	[CompilerGenerated]
	private bool b(bdv A_0)
	{
		return this.e(A_0);
	}

	// Token: 0x0600C5F2 RID: 50674 RVA: 0x00452EF0 File Offset: 0x004510F0
	[CompilerGenerated]
	private bool a(bdv A_0)
	{
		return A_0.FeatAvailability != c7s.c && this.e(A_0);
	}

	// Token: 0x04004890 RID: 18576
	private new int a = 46;

	// Token: 0x04004891 RID: 18577
	private new int b = 3;

	// Token: 0x04004892 RID: 18578
	private new int c = 10;

	// Token: 0x04004893 RID: 18579
	private new int d = 26;

	// Token: 0x04004894 RID: 18580
	private new SortedList<ai8, bdv> e;

	// Token: 0x04004895 RID: 18581
	private new an2 f;

	// Token: 0x04004896 RID: 18582
	private new bdl g;

	// Token: 0x04004897 RID: 18583
	private cao h;

	// Token: 0x04004898 RID: 18584
	private avo i;

	// Token: 0x04004899 RID: 18585
	private new c68 j;

	// Token: 0x0400489A RID: 18586
	private new bool k;

	// Token: 0x0400489B RID: 18587
	private new e3q l;

	// Token: 0x0400489C RID: 18588
	[CompilerGenerated]
	private new EventHandler m;

	// Token: 0x0400489D RID: 18589
	[CompilerGenerated]
	private EventHandler n;

	// Token: 0x0200206A RID: 8298
	private new class b : IComparer<ai8>
	{
		// Token: 0x0600C5F3 RID: 50675 RVA: 0x00452F08 File Offset: 0x00451108
		public b(e3q A_0)
		{
			czh.a(A_0, "owner");
			this.a = A_0;
		}

		// Token: 0x0600C5F4 RID: 50676 RVA: 0x00452F24 File Offset: 0x00451124
		public int Compare(ai8 x, ai8 y)
		{
			czh.a(x, "x");
			czh.a(y, "y");
			c7s c7s = eis.a(this.a, x, true);
			c7s c7s2 = eis.a(this.a, y, true);
			int num = eis.b.a(x);
			int num2 = eis.b.a(y);
			if (x.Name != y.Name)
			{
				return x.Name.CompareTo(y.Name);
			}
			return 0;
		}

		// Token: 0x0600C5F5 RID: 50677 RVA: 0x00452FC8 File Offset: 0x004511C8
		private static int a(ai8 A_0)
		{
			int num = A_0.MinimalLevel;
			if (!A_0.Purchasable)
			{
				num += 1000;
			}
			if (A_0.Veteran)
			{
				num += 100000;
			}
			return num;
		}

		// Token: 0x0400489E RID: 18590
		private e3q a;
	}

	// Token: 0x0200206B RID: 8299
	[CompilerGenerated]
	private new sealed class a
	{
		// Token: 0x0600C5F7 RID: 50679 RVA: 0x0045300C File Offset: 0x0045120C
		internal bool a(bdv A_0)
		{
			return A_0.FeatType == this.a.GetType();
		}

		// Token: 0x0400489F RID: 18591
		public ai8 a;
	}
}

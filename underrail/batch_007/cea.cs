using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using Microsoft.Xna.Framework;

// Token: 0x02002044 RID: 8260
public sealed class cea : ec9
{
	// Token: 0x0600C3C7 RID: 50119 RVA: 0x0043E4A0 File Offset: 0x0043C6A0
	[CompilerGenerated]
	public new void d(EventHandler A_0)
	{
		EventHandler eventHandler = this.k;
		EventHandler eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler value = (EventHandler)Delegate.Combine(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.k, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x0600C3C8 RID: 50120 RVA: 0x0043E4D8 File Offset: 0x0043C6D8
	[CompilerGenerated]
	public new void c(EventHandler A_0)
	{
		EventHandler eventHandler = this.k;
		EventHandler eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler value = (EventHandler)Delegate.Remove(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.k, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x0600C3C9 RID: 50121 RVA: 0x0043E510 File Offset: 0x0043C710
	[CompilerGenerated]
	public void a(EventHandler A_0)
	{
		EventHandler eventHandler = this.l;
		EventHandler eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler value = (EventHandler)Delegate.Combine(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.l, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x0600C3CA RID: 50122 RVA: 0x0043E548 File Offset: 0x0043C748
	[CompilerGenerated]
	public void b(EventHandler A_0)
	{
		EventHandler eventHandler = this.l;
		EventHandler eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler value = (EventHandler)Delegate.Remove(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.l, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x0600C3CB RID: 50123 RVA: 0x0043E580 File Offset: 0x0043C780
	public override bool et()
	{
		if (!base.IsMousedOver)
		{
			return Enumerable.Any<euz>(base.Controls, new Func<euz, bool>(cea.a.a.a));
		}
		return true;
	}

	// Token: 0x0600C3CC RID: 50124 RVA: 0x0043E5BC File Offset: 0x0043C7BC
	public bool g()
	{
		return this.g.Checked;
	}

	// Token: 0x0600C3CD RID: 50125 RVA: 0x0043E5CC File Offset: 0x0043C7CC
	public void a(bool A_0)
	{
		if (this.g.Checked != A_0)
		{
			this.g.Checked = A_0;
		}
	}

	// Token: 0x0600C3CE RID: 50126 RVA: 0x0043E5EC File Offset: 0x0043C7EC
	public cea(e3q A_0, bool A_1)
	{
		this.e = A_0;
		this.j = A_1;
		this.f();
	}

	// Token: 0x0600C3CF RID: 50127 RVA: 0x0043E624 File Offset: 0x0043C824
	private void f()
	{
		wj wj = wj.a();
		if (wj.c())
		{
			this.c = bo1.r;
			this.f = new bdl();
		}
		else
		{
			this.c = wj.f;
			this.e = wj.b8;
			this.d = new esj?(wj.b9);
			this.f = new dg8();
			this.a = wj.gs;
			this.b = wj.gt;
			this.c = wj.bm.c;
		}
		this.f.Gravity = axy.c;
		this.f.IsPrivateComponent = true;
		this.f.c(1);
		this.f.d(5);
		this.f.e(0);
		this.f.f(new EventHandler<c1>(this.d));
		e4z.c(this.f.d());
		e4z.c(this.f.e());
		e4z.d(this.f.h());
		this.aox(this.f);
		if (wj.c())
		{
			eki eki = new eki();
			eki = new eki();
			eki.IsPrivateComponent = true;
			eki.Checked = false;
			eki.b(egg.b);
			eki.Location = new Point(40, 570);
			eki.a(new Point(10, 6));
			eki.a(true);
			eki.a(adi.a);
			eki.c(adi.b);
			this.g = eki;
		}
		else
		{
			aad aad = new aad();
			aad.IsPrivateComponent = true;
			aad.Checked = false;
			aad.a(wj.gu);
			aad.a(new Point(this.b, wj.gv));
			aad.a(true);
			aad.a(adi.a);
			aad.c(adi.b);
			this.g = aad;
		}
		this.g.Text = "Показать все";
		this.g.c(new EventHandler<c1>(this.a));
		e4z.g(this.g);
		this.aox(this.g);
		this.h = new avo();
		this.h.Location = new Point(40, 550);
		this.h.Text = "Фильтр:";
		if (wj.c())
		{
			this.h.a(egg.b);
		}
		else
		{
			this.h.a(wj.gu);
		}
		this.h.a(true);
		this.h.Color = adi.a;
		this.h.IsPrivateComponent = true;
		this.aox(this.h);
		this.i = new c68();
		if (wj.c())
		{
			this.i.e = bo1.b;
			this.i.a(egg.b);
			this.i.b(20);
			this.i.Size = new esj(305, 33);
			this.i.a(new Point(15, 6));
		}
		else
		{
			this.i.e = wj.f;
			this.i.f = wj.fg;
			this.i.g = new esj?(wj.fh);
			this.i.a(wj.gu);
			this.i.k = true;
			this.i.a(new Point(this.b, wj.gv));
			this.i.a(true);
			this.i.Size = new esj(305, wj.gs);
		}
		this.i.o(new EventHandler<c1>(this.b));
		this.i.e(new EventHandler(this.a));
		this.i.j = "[пусто]";
		this.i.a(new Vector2(32f, 1105f));
		for (int i = 91; i <= 96; i++)
		{
			this.i.q().Add((char)i);
		}
		this.i.m().Add(' ');
		this.i.m().Add('-');
		this.i.m().Add('\'');
		this.aox(this.i);
		this.e();
		this.d();
	}

	// Token: 0x0600C3D0 RID: 50128 RVA: 0x0043EACC File Offset: 0x0043CCCC
	private new void e()
	{
		this.d = new SortedList<apq, a53>(new cea.b(this.e));
		if (this.e != null)
		{
			foreach (apq apq in ac8.b())
			{
				ai8 ai = ck.b(apq.e3());
				if (ai != null && (ai.DLC == null || dk2.b(ai.DLC)) && (apq.a() == null || dk2.b(apq.a())))
				{
					this.d.Add(apq, this.b(apq));
				}
			}
		}
	}

	// Token: 0x0600C3D1 RID: 50129 RVA: 0x0043EB98 File Offset: 0x0043CD98
	private a53 b(apq A_0)
	{
		wj wj = wj.a();
		eoc eoc = new eoc(this.e, A_0.e4());
		a53 a = new a53();
		a.Text = this.a(A_0);
		a.e(eoc.f());
		if (wj.c())
		{
			a.Font = egg.b;
			a.d = bo1.b;
		}
		else
		{
			a.Font = wj.gu;
			a.d = wj.f;
			a.e = wj.fg;
			a.f = new esj?(wj.fh);
		}
		a.Size = new esj(10, this.a);
		a.a(eoc);
		a.b(cea.a(this.e, A_0.e4()));
		a.d(true);
		a.a(false);
		a.c(new Point(355, 7));
		a.b(30);
		a.c(true);
		a.b(new Point(400, 7));
		a.d(90);
		a.d(adi.a);
		a.c(Color.White);
		a.c(475);
		a.f(5);
		a.a = adi.a;
		a.c = adi.b;
		a.HorizontalAlignment = cab.a;
		a.VerticalAlignment = ad4.b;
		a.TextLabelOffset = new Point(10, 7);
		a.h = new Color(255, 255, 255, 255);
		a.e(this.j);
		a.a(new EventHandler<c1>(this.c));
		a.j(new EventHandler<b25>(this.a));
		return a;
	}

	// Token: 0x0600C3D2 RID: 50130 RVA: 0x0043ED5C File Offset: 0x0043CF5C
	protected override void jq(object A_0, c1 A_1)
	{
		base.jq(A_0, A_1);
		this.d();
	}

	// Token: 0x0600C3D3 RID: 50131 RVA: 0x0043ED6C File Offset: 0x0043CF6C
	private new void d(object A_0, c1 A_1)
	{
		this.d();
	}

	// Token: 0x0600C3D4 RID: 50132 RVA: 0x0043ED74 File Offset: 0x0043CF74
	private new void c(object A_0, c1 A_1)
	{
		if (this.k != null)
		{
			this.k(this, new EventArgs());
		}
	}

	// Token: 0x0600C3D5 RID: 50133 RVA: 0x0043ED94 File Offset: 0x0043CF94
	private void a(object A_0, b25 A_1)
	{
		if (this.l != null)
		{
			this.l(A_0, new EventArgs());
		}
	}

	// Token: 0x0600C3D6 RID: 50134 RVA: 0x0043EDB8 File Offset: 0x0043CFB8
	protected override void it(object A_0, b25 A_1)
	{
		base.it(A_0, A_1);
		bdl bdl = this.f;
		bdl.e(bdl.l() - this.f.m() * Math.Sign(A_1.c()));
		this.d();
	}

	// Token: 0x0600C3D7 RID: 50135 RVA: 0x0043EDFC File Offset: 0x0043CFFC
	protected override void i0()
	{
		base.i0();
		this.c();
	}

	// Token: 0x0600C3D8 RID: 50136 RVA: 0x0043EE0C File Offset: 0x0043D00C
	protected override void i1()
	{
		base.i1();
		this.b();
	}

	// Token: 0x0600C3D9 RID: 50137 RVA: 0x0043EE1C File Offset: 0x0043D01C
	private string a(apq A_0)
	{
		string result;
		if (A_0.e5().Length > 24)
		{
			if (A_0.e5().IndexOf(":") > 18)
			{
				string[] array = A_0.e5().Split(new string[]
				{
					":"
				}, StringSplitOptions.None);
				int length = array[0].Length;
				int length2 = array[1].Length;
				int num = Math.Min(length, 11);
				int num2 = Math.Min(length2, Math.Max(24 - num, 12));
				result = string.Format("{0}{1}:{2}{3}", new object[]
				{
					array[0].Substring(0, num),
					(num2 < length) ? "." : "",
					array[1].Substring(0, num2),
					(num2 < length2) ? "." : ""
				});
			}
			else
			{
				result = A_0.e5().Substring(0, 24) + ".";
			}
		}
		else
		{
			result = A_0.e5();
		}
		return result;
	}

	// Token: 0x0600C3DA RID: 50138 RVA: 0x0043EF3C File Offset: 0x0043D13C
	private new void d()
	{
		wj wj = wj.a();
		if (wj.c())
		{
			this.g.Location = new Point(this.b, base.Size.d - (this.b + this.g.Size.d));
			this.h.Location = new Point(this.b, this.g.Location.Y - this.h.Size.d);
			this.i.Location = new Point(this.h.Location.X + this.h.Size.c + 5, this.h.Location.Y - 7);
		}
		int num = (base.Size.d - 3 * this.b + 4 - this.g.Size.d - this.h.Size.d) / this.a;
		List<a53> list = null;
		if (this.j)
		{
			if (this.g.Checked)
			{
				list = new List<a53>(Enumerable.ToList<a53>(Enumerable.Where<a53>(this.d.Values, new Func<a53, bool>(this.d))));
			}
			else
			{
				list = Enumerable.ToList<a53>(Enumerable.Where<a53>(this.d.Values, new Func<a53, bool>(this.c)));
			}
		}
		else if (this.g.Checked)
		{
			list = new List<a53>(Enumerable.ToList<a53>(Enumerable.Where<a53>(this.d.Values, new Func<a53, bool>(this.b))));
		}
		else
		{
			list = Enumerable.ToList<a53>(Enumerable.Where<a53>(this.d.Values, new Func<a53, bool>(this.a)));
		}
		if (list.Count > num)
		{
			this.f.Visible = true;
			this.f.a(list.Count - num);
			this.f.Location = new Point(base.Size.c - this.c, 0);
			this.f.Size = new esj(this.c, base.Size.d - 1);
			this.f.b(0);
			if (this.f.l() > this.f.k())
			{
				this.f.e(this.f.k());
			}
		}
		else
		{
			this.f.e(0);
			this.f.Visible = false;
		}
		foreach (a53 a_ in Enumerable.ToList<a53>(Enumerable.OfType<a53>(base.Controls)))
		{
			this.g(a_);
		}
		int num2 = 0;
		while (num2 < num && num2 + this.f.l() < list.Count)
		{
			a53 a = list[num2 + this.f.l()];
			a.Location = new Point(this.b, this.b + num2 * this.a);
			a.Size = new esj(base.Size.c - 2 * this.b, this.a);
			if (!wj.c())
			{
				a.TextLabelOffset = new Point(10, wj.gv);
				a.c(new Point((int)((float)base.Size.c * 0.525f), wj.gv));
				a.b((int)((float)base.Size.c * 0.125f));
				a.b(new Point((int)((float)base.Size.c * 0.675f), wj.gv));
				a.d((int)((float)base.Size.c * 0.15f));
				a.c((int)((float)base.Size.c * 0.81f));
				a.f((int)((float)wj.gz.c * 0.33f));
			}
			this.aox(a);
			num2++;
		}
		if (!wj.c())
		{
			this.g.Location = new Point(this.b, base.Size.d - this.g.Size.d - this.b);
			this.h.Location = new Point(this.g.Location.X, this.g.Location.Y - this.h.Size.d);
			int num3 = (this.i.Size.d - this.h.Size.d) / 2;
			this.i.Location = new Point(this.h.Location.X + this.h.Size.c + this.b / 2, this.h.Location.Y - wj.gv - num3);
			this.i.Size = new esj(base.Size.c - this.i.Location.X - 2 * this.b, this.i.Size.d);
		}
	}

	// Token: 0x0600C3DB RID: 50139 RVA: 0x0043F4EC File Offset: 0x0043D6EC
	private new void c()
	{
		if (this.e != null)
		{
			this.e.Feats.b(new EventHandler<EventArgs>(this.c));
			this.e.Feats.a(new EventHandler<EventArgs>(this.b));
		}
	}

	// Token: 0x0600C3DC RID: 50140 RVA: 0x0043F53C File Offset: 0x0043D73C
	private void b()
	{
		if (this.e != null)
		{
			this.e.Feats.c(new EventHandler<EventArgs>(this.c));
			this.e.Feats.d(new EventHandler<EventArgs>(this.b));
		}
	}

	// Token: 0x0600C3DD RID: 50141 RVA: 0x0043F58C File Offset: 0x0043D78C
	private new void c(object A_0, EventArgs A_1)
	{
		this.a();
		this.d();
	}

	// Token: 0x0600C3DE RID: 50142 RVA: 0x0043F59C File Offset: 0x0043D79C
	private void b(object A_0, EventArgs A_1)
	{
		this.a();
		this.d();
	}

	// Token: 0x0600C3DF RID: 50143 RVA: 0x0043F5AC File Offset: 0x0043D7AC
	private void a()
	{
		foreach (a53 a in this.d.Values)
		{
			eoc eoc = a.j() as eoc;
			if (eoc != null)
			{
				bool flag = a.u();
				a.b(cea.a(this.e, eoc.a()));
				if (!a.u() && flag)
				{
					int num = Math.Max(0, a.j().f() - a.v());
					if (num > 0)
					{
						a.j().a(a.v());
						e3q e3q = this.e;
						e3q.a(e3q.f() + num);
						if (this.k != null)
						{
							this.k(this, new EventArgs());
						}
					}
				}
			}
		}
	}

	// Token: 0x0600C3E0 RID: 50144 RVA: 0x0043F6A8 File Offset: 0x0043D8A8
	private static bool a(efk A_0, string A_1)
	{
		apq apq = ac8.a(A_1);
		return apq != null && A_0.Feats.c(apq.e3());
	}

	// Token: 0x0600C3E1 RID: 50145 RVA: 0x0043F6D8 File Offset: 0x0043D8D8
	private void b(object A_0, c1 A_1)
	{
		this.d();
	}

	// Token: 0x0600C3E2 RID: 50146 RVA: 0x0043F6E0 File Offset: 0x0043D8E0
	private void a(object A_0, EventArgs A_1)
	{
		bl9.a(this.i, aqo.a, new Point?(new Point(10000, 0)));
	}

	// Token: 0x0600C3E3 RID: 50147 RVA: 0x0043F700 File Offset: 0x0043D900
	private void a(object A_0, c1 A_1)
	{
		this.d();
	}

	// Token: 0x0600C3E4 RID: 50148 RVA: 0x0043F70C File Offset: 0x0043D90C
	private new bool e(a53 A_0)
	{
		eoc eoc = A_0.j() as eoc;
		if (eoc != null)
		{
			apq apq = ac8.a(eoc.a());
			if (apq != null)
			{
				ai8 ai = ck.b(apq.e3());
				string value = (this.i.Text ?? "").Trim().ToLowerInvariant();
				if (string.IsNullOrWhiteSpace(value))
				{
					return ai != null && (!ai.Veteran || dk2.d() > 0);
				}
				if (apq.e5().ToLowerInvariant().Contains(value))
				{
					return true;
				}
				if (ai != null && !string.IsNullOrEmpty(ai.DLC) && dk2.c(ai.DLC).ToLowerInvariant().Contains(value))
				{
					return true;
				}
				string text = qv.a("Specialization/" + apq.e4(), apq.e7());
				return !string.IsNullOrEmpty(text) && text.ToLowerInvariant().Contains(value);
			}
		}
		return false;
	}

	// Token: 0x0600C3E5 RID: 50149 RVA: 0x0043F824 File Offset: 0x0043DA24
	[CompilerGenerated]
	private new bool d(a53 A_0)
	{
		return this.e(A_0);
	}

	// Token: 0x0600C3E6 RID: 50150 RVA: 0x0043F830 File Offset: 0x0043DA30
	[CompilerGenerated]
	private new bool c(a53 A_0)
	{
		return A_0.j().f() > 0 && this.e(A_0);
	}

	// Token: 0x0600C3E7 RID: 50151 RVA: 0x0043F84C File Offset: 0x0043DA4C
	[CompilerGenerated]
	private bool b(a53 A_0)
	{
		return this.e(A_0);
	}

	// Token: 0x0600C3E8 RID: 50152 RVA: 0x0043F858 File Offset: 0x0043DA58
	[CompilerGenerated]
	private bool a(a53 A_0)
	{
		return A_0.u() && this.e(A_0);
	}

	// Token: 0x0400473F RID: 18239
	private new int a = 30;

	// Token: 0x04004740 RID: 18240
	private new int b = 10;

	// Token: 0x04004741 RID: 18241
	private new int c = 26;

	// Token: 0x04004742 RID: 18242
	private new SortedList<apq, a53> d;

	// Token: 0x04004743 RID: 18243
	private new e3q e;

	// Token: 0x04004744 RID: 18244
	private new bdl f;

	// Token: 0x04004745 RID: 18245
	private new cao g;

	// Token: 0x04004746 RID: 18246
	private avo h;

	// Token: 0x04004747 RID: 18247
	private c68 i;

	// Token: 0x04004748 RID: 18248
	private new bool j;

	// Token: 0x04004749 RID: 18249
	[CompilerGenerated]
	private new EventHandler k;

	// Token: 0x0400474A RID: 18250
	[CompilerGenerated]
	private new EventHandler l;

	// Token: 0x02002045 RID: 8261
	private new class b : IComparer<apq>
	{
		// Token: 0x0600C3E9 RID: 50153 RVA: 0x0043F870 File Offset: 0x0043DA70
		public b(e3q A_0)
		{
			czh.a(A_0, "owner");
			this.a = A_0;
		}

		// Token: 0x0600C3EA RID: 50154 RVA: 0x0043F88C File Offset: 0x0043DA8C
		public int Compare(apq x, apq y)
		{
			czh.a(x, "x");
			czh.a(y, "y");
			int num = this.a.a(x, false);
			int num2 = this.a.a(y, false);
			if ((num == 0 || num2 == 0) && num != num2)
			{
				return num2.CompareTo(num);
			}
			bool flag = cea.a(this.a, x.e4());
			bool flag2 = cea.a(this.a, y.e4());
			if (flag != flag2)
			{
				return flag2.CompareTo(flag);
			}
			if (x.e5() != y.e5())
			{
				return x.e5().CompareTo(y.e5());
			}
			return 0;
		}

		// Token: 0x0400474B RID: 18251
		private e3q a;
	}

	// Token: 0x02002046 RID: 8262
	[CompilerGenerated]
	[Serializable]
	private new sealed class a
	{
		// Token: 0x0600C3ED RID: 50157 RVA: 0x0043F958 File Offset: 0x0043DB58
		internal bool a(euz A_0)
		{
			return A_0.IsMousedOver;
		}

		// Token: 0x0400474C RID: 18252
		public static readonly cea.a a = new cea.a();

		// Token: 0x0400474D RID: 18253
		public static Func<euz, bool> b;
	}
}

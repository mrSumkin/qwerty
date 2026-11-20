using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using TimelapseVertigo.Common.Settings;
using TimelapseVertigo.Rules.Characters;

// Token: 0x02002034 RID: 8244
public sealed class ek7 : euz, amj
{
	// Token: 0x0600C320 RID: 49952 RVA: 0x00438224 File Offset: 0x00436424
	public doz k()
	{
		return this.h;
	}

	// Token: 0x0600C321 RID: 49953 RVA: 0x0043822C File Offset: 0x0043642C
	public doz l()
	{
		return this.i;
	}

	// Token: 0x0600C322 RID: 49954 RVA: 0x00438234 File Offset: 0x00436434
	public doz j()
	{
		return this.j;
	}

	// Token: 0x0600C323 RID: 49955 RVA: 0x00438240 File Offset: 0x00436440
	[CompilerGenerated]
	public void b(EventHandler<EventArgs> A_0)
	{
		EventHandler<EventArgs> eventHandler = this.t;
		EventHandler<EventArgs> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<EventArgs> value = (EventHandler<EventArgs>)Delegate.Combine(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler<EventArgs>>(ref this.t, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x0600C324 RID: 49956 RVA: 0x00438278 File Offset: 0x00436478
	[CompilerGenerated]
	public void a(EventHandler<EventArgs> A_0)
	{
		EventHandler<EventArgs> eventHandler = this.t;
		EventHandler<EventArgs> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<EventArgs> value = (EventHandler<EventArgs>)Delegate.Remove(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler<EventArgs>>(ref this.t, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x0600C325 RID: 49957 RVA: 0x004382B0 File Offset: 0x004364B0
	public ek7(efk A_0)
	{
		czh.a(A_0, "character");
		this.g = A_0;
		this.h();
		this.o = new dsy(this.h, this, esj.a(), 250, null, null, 3000, false, false);
		this.p = new dsy(this.i, this, esj.a(), 250, null, null, 3000, false, false);
		this.q = new dsy(this.j, this, esj.a(), 250, null, null, 3000, false, false);
	}

	// Token: 0x0600C326 RID: 49958 RVA: 0x0043839C File Offset: 0x0043659C
	public override void ag5(e6d A_0)
	{
		this.g();
		this.f();
		Keys[] pressedKeys = A_0.c().GetPressedKeys();
		if (Enumerable.Contains<Keys>(pressedKeys, Keys.LeftShift) || Enumerable.Contains<Keys>(pressedKeys, Keys.RightShift))
		{
			if (this.n != Keys.LeftShift)
			{
				this.a(Keys.LeftShift);
			}
		}
		else if (Enumerable.Contains<Keys>(pressedKeys, Keys.LeftControl) || Enumerable.Contains<Keys>(pressedKeys, Keys.RightControl))
		{
			if (this.n != Keys.LeftControl)
			{
				this.a(Keys.LeftControl);
			}
		}
		else if (this.n != Keys.None)
		{
			this.a(Keys.None);
		}
		base.ag5(A_0);
	}

	// Token: 0x0600C327 RID: 49959 RVA: 0x00438460 File Offset: 0x00436660
	public void c(int A_0)
	{
		this.k[this.n][A_0 - 1].ArtificiallyPressed = true;
	}

	// Token: 0x0600C328 RID: 49960 RVA: 0x00438484 File Offset: 0x00436684
	public void e(int A_0)
	{
		if (this.m.Count > A_0)
		{
			cao cao;
			if (this.n == Keys.LeftShift)
			{
				cao = this.m[A_0];
			}
			else
			{
				cao = this.l[A_0];
			}
			if (cao.Enabled)
			{
				cao.ArtificiallyPressed = true;
			}
		}
	}

	// Token: 0x0600C329 RID: 49961 RVA: 0x004384E4 File Offset: 0x004366E4
	public void d(int A_0)
	{
		foreach (KeyValuePair<Keys, List<cqn>> keyValuePair in this.k)
		{
			keyValuePair.Value[A_0 - 1].ArtificiallyPressed = false;
		}
	}

	// Token: 0x0600C32A RID: 49962 RVA: 0x0043854C File Offset: 0x0043674C
	public void f(int A_0)
	{
		if (this.m.Count > A_0)
		{
			this.l[A_0].ArtificiallyPressed = false;
			this.m[A_0].ArtificiallyPressed = false;
		}
	}

	// Token: 0x0600C32B RID: 49963 RVA: 0x00438590 File Offset: 0x00436790
	public ecs yf(euz A_0)
	{
		string text = null;
		string a_ = null;
		string a_2 = null;
		if (A_0 == this.h)
		{
			text = "Быстрый вызов";
			a_ = d1o.b(Hotkey.QuickInvoker);
			a_2 = "Вызывает панель, на которой перечислены все специальные атаки и способности вашего персонажа. Вы можете использовать их прямо оттуда или перетащить на панель действий.";
		}
		else if (A_0 == this.i)
		{
			text = "Зафиксировать кнопки действий";
			a_ = "Ctrl+L";
			a_2 = "Блокирует кнопки действий, не давая случайно удалить назначенные команды.";
		}
		else if (A_0 == this.j)
		{
			text = "Предотвращение взаимодействия в бою";
			a_ = "Ctrl+P";
			a_2 = "Отключает взаимодействие со всеми типами контейнеров и используемых объектов в пошаговом режиме. Это может помочь предотвратить случайный осмотр останков противника или открытие контейнеров вместо того, чтобы предпринять боевое действие.";
		}
		if (text == null)
		{
			return null;
		}
		return cq4.a(text, a_, a_2);
	}

	// Token: 0x0600C32C RID: 49964 RVA: 0x0043861C File Offset: 0x0043681C
	public override void iv(e6d A_0, cp9 A_1)
	{
		base.iv(A_0, A_1);
		this.o.a(A_0);
		this.p.a(A_0);
		this.q.a(A_0);
	}

	// Token: 0x0600C32D RID: 49965 RVA: 0x00438658 File Offset: 0x00436858
	public cl7 i()
	{
		cl7 cl = new cl7();
		cl.a = new Dictionary<Keys, List<av>>();
		cl.b = this.i.Checked;
		cl.c = this.j.Checked;
		if (this.k != null)
		{
			foreach (KeyValuePair<Keys, List<cqn>> keyValuePair in this.k)
			{
				if (keyValuePair.Value != null)
				{
					List<av> list = new List<av>();
					foreach (cqn cqn in keyValuePair.Value)
					{
						list.Add(cqn.zc());
					}
					cl.a.Add(keyValuePair.Key, list);
				}
			}
		}
		return cl;
	}

	// Token: 0x0600C32E RID: 49966 RVA: 0x00438760 File Offset: 0x00436960
	public void a(cl7 A_0)
	{
		if (this.k == null || A_0 == null)
		{
			return;
		}
		this.i.Checked = A_0.b;
		this.j.Checked = A_0.c;
		if (A_0.a != null)
		{
			foreach (KeyValuePair<Keys, List<av>> keyValuePair in A_0.a)
			{
				if (keyValuePair.Value != null)
				{
					List<cqn> list;
					this.k.TryGetValue(keyValuePair.Key, out list);
					if (list != null)
					{
						for (int i = 0; i < keyValuePair.Value.Count; i++)
						{
							if (list.Count > i)
							{
								list[i].a(keyValuePair.Value[i]);
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600C32F RID: 49967 RVA: 0x00438858 File Offset: 0x00436A58
	private void h()
	{
		wj wj = wj.a();
		if (wj.d == UiSize.Classic)
		{
			base.Size = new esj(564 + 6 * (eb1.a.c + 2) - 2 + 25, 41);
		}
		else
		{
			base.Size = new esj(wj.n.c * 18 + wj.t.c + wj.v.c * 2 + wj.p * 20, wj.n.d);
		}
		this.c();
		this.e();
		this.d();
		this.b();
		this.a();
	}

	// Token: 0x0600C330 RID: 49968 RVA: 0x00438908 File Offset: 0x00436B08
	private void g()
	{
		if (this.o != null && this.p != null && this.q != null)
		{
			cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
			int num = 250;
			if (serviceOrThrow.aq1().b().g() == InterfaceElementSize2.Huge)
			{
				num = (int)((double)num * 2.5);
			}
			else if (serviceOrThrow.aq1().b().g() == InterfaceElementSize2.ExtraLarge)
			{
				num *= 2;
			}
			else if (serviceOrThrow.aq1().b().g() == InterfaceElementSize2.Large)
			{
				num = (int)((double)num * 1.5);
			}
			this.o.a(num);
			this.p.a(num);
			this.q.a(num);
		}
	}

	// Token: 0x0600C331 RID: 49969 RVA: 0x004389D4 File Offset: 0x00436BD4
	private void f()
	{
		foreach (Keys keys in new Keys[]
		{
			Keys.None,
			Keys.LeftControl,
			Keys.LeftShift
		})
		{
			for (int j = 0; j < 9; j++)
			{
				this.k[keys][j].Text = d1o.b(Hotkey.ActionButton1 + j).ToUpperInvariant();
				if (keys == Keys.LeftControl)
				{
					if (!string.IsNullOrEmpty(this.k[keys][j].Text))
					{
						this.k[keys][j].Text = "C" + this.k[keys][j].Text;
					}
				}
				else if (keys == Keys.LeftShift && !string.IsNullOrEmpty(this.k[keys][j].Text))
				{
					this.k[keys][j].Text = "S" + this.k[keys][j].Text;
				}
			}
		}
		for (int k = 0; k < 6; k++)
		{
			this.l[k].Text = d1o.b(Hotkey.QuickButton1 + k).ToUpperInvariant();
			this.m[k].Text = "S" + d1o.b(Hotkey.QuickButton1 + k).ToUpperInvariant();
		}
	}

	// Token: 0x0600C332 RID: 49970 RVA: 0x00438B74 File Offset: 0x00436D74
	private void e()
	{
		this.k[Keys.None] = new List<cqn>();
		this.k[Keys.LeftShift] = new List<cqn>();
		this.k[Keys.LeftControl] = new List<cqn>();
		for (int i = 0; i < 9; i++)
		{
			this.a(i, Keys.None);
			this.a(i, Keys.LeftShift);
			this.a(i, Keys.LeftControl);
		}
	}

	// Token: 0x0600C333 RID: 49971 RVA: 0x00438BF0 File Offset: 0x00436DF0
	private void d()
	{
		wj wj = wj.a();
		tt tt;
		tt tt2;
		if (wj.d == UiSize.Classic)
		{
			tt = new tt(this.g, WeaponKey.Primary);
			tt.Location = new Point(435, 0);
			tt2 = new tt(this.g, WeaponKey.Secondary);
			tt2.Location = new Point(435 + eb1.a.c + 2, 0);
			this.r = new efq(this.g);
			this.r.Location = new Point(435 + (eb1.a.c + 2) * 2, 0);
			this.s = new dvx(this.g);
			this.s.Location = new Point(435 + (eb1.a.c + 2) * 2, 0);
			this.s.Visible = false;
		}
		else
		{
			int num = this.h.Location.X + this.h.Size.c + wj.p;
			tt = new tt(this.g, WeaponKey.Primary, wj.n, wj.o);
			tt.Location = new Point(num, 0);
			tt.d = wj.f;
			tt.b = wj.r;
			tt2 = new tt(this.g, WeaponKey.Secondary, wj.n, wj.o);
			tt2.Location = new Point(num + wj.n.c + wj.p, 0);
			tt2.d = wj.f;
			tt2.b = wj.r;
			this.r = new efq(this.g, wj.n, wj.o);
			this.r.Location = new Point(num + (wj.n.c + wj.p) * 2, 0);
			this.r.d = wj.f;
			this.s = new dvx(this.g, wj.n, wj.o);
			this.s.Location = this.r.Location;
			this.s.Visible = false;
			this.s.c(wj.f);
		}
		this.aox(tt);
		this.aox(tt2);
		this.aox(this.r);
		this.aox(this.s);
	}

	// Token: 0x0600C334 RID: 49972 RVA: 0x00438E5C File Offset: 0x0043705C
	private cqn a(int A_0, Keys A_1)
	{
		wj wj = wj.a();
		cqn cqn;
		if (wj.d == UiSize.Classic)
		{
			cqn = new cqn();
			cqn.Location = new Point(25 + A_0 * (eb1.a.c + 2), 0);
		}
		else
		{
			cqn = new cqn(wj.n, wj.o);
			int num = wj.v.c + wj.p;
			cqn.Location = new Point(num + A_0 * (wj.n.c + wj.p), 0);
			cqn.c(wj.f);
			cqn.g = wj.q;
			cqn.i = wj.r;
			cqn.h = wj.s;
			cqn.j = new Vector2?(wj.w);
			cqn.k = wj.x;
		}
		cqn.e(adi.a);
		cqn.h(Color.Orange);
		cqn.Color = new Color(82, 84, 121);
		cqn.f(new Color(110, 112, 162));
		cqn.g(adi.c);
		cqn.a(new Color(0, 0, 255) * 0.5f);
		cqn.d(new Color(255, 0, 0) * 0.5f);
		cqn.IsPrivateComponent = true;
		cqn.p(new EventHandler<b25>(this.g));
		cqn.Locked = this.i.Checked;
		cqn.Visible = (this.n == A_1);
		this.aox(cqn);
		this.k[A_1].Add(cqn);
		return cqn;
	}

	// Token: 0x0600C335 RID: 49973 RVA: 0x0043900C File Offset: 0x0043720C
	private void c()
	{
		this.h = new doz();
		this.i = new doz();
		this.j = new doz();
		wj wj = wj.a();
		if (wj.d == UiSize.Classic)
		{
			this.h.Location = new Point(412, 0);
			this.h.a(bo1.bn);
			this.h.a(new Point(0, 0));
			this.h.Size = new esj(21, 41);
			this.i.Location = new Point(0, 10);
			this.i.a(bo1.bn);
			this.i.a(new Point(21, 0));
			this.i.Size = new esj(21, 21);
			this.j.Location = new Point(base.Size.c - 21, 10);
			this.j.a(bo1.bn);
			this.j.a(new Point(42, 0));
			this.j.Size = new esj(21, 21);
		}
		else
		{
			int x = wj.v.c + 2 + 9 * (wj.n.c + wj.p);
			this.h.a(wj.f);
			this.h.Size = wj.t;
			this.h.Location = new Point(x, (base.Size.d - this.h.Size.d) / 2);
			this.h.a(wj.u);
			this.i.a(wj.f);
			this.i.Size = wj.v;
			this.i.Location = new Point(0, (base.Size.d - wj.v.d) / 2);
			this.i.a(new Point(wj.u.X + wj.t.c, wj.u.Y));
			this.j.a(wj.f);
			this.j.Size = wj.v;
			this.j.Location = new Point(base.Size.c - wj.v.c, (base.Size.d - wj.v.d) / 2);
			this.j.a(new Point(wj.u.X + wj.t.c + wj.v.c, wj.u.Y));
		}
		this.h.j(new EventHandler<b25>(this.e));
		this.h.l(new EventHandler<b25>(this.f));
		this.aox(this.h);
		this.i.CheckOnClick = true;
		this.i.Checked = false;
		this.i.Gravity = axy.c;
		this.i.c(new EventHandler<c1>(this.b));
		this.i.j(new EventHandler<b25>(this.c));
		this.i.l(new EventHandler<b25>(this.d));
		e4z.f(this.i);
		this.aox(this.i);
		this.j.CheckOnClick = true;
		this.j.Checked = false;
		this.j.Gravity = axy.c;
		this.j.c(new EventHandler<c1>(this.a));
		this.j.j(new EventHandler<b25>(this.a));
		this.j.l(new EventHandler<b25>(this.b));
		e4z.f(this.j);
		this.aox(this.j);
	}

	// Token: 0x0600C336 RID: 49974 RVA: 0x00439420 File Offset: 0x00437620
	private void b()
	{
		for (int i = 0; i < 6; i++)
		{
			this.b(i);
		}
	}

	// Token: 0x0600C337 RID: 49975 RVA: 0x00439444 File Offset: 0x00437644
	private void a()
	{
		for (int i = 0; i < 6; i++)
		{
			this.a(i).Visible = false;
		}
	}

	// Token: 0x0600C338 RID: 49976 RVA: 0x00439470 File Offset: 0x00437670
	private eb1 b(int A_0)
	{
		wj wj = wj.a();
		boq boq;
		if (wj.d == UiSize.Classic)
		{
			boq = new boq(this.g, A_0);
			boq.Location = new Point(564 + A_0 * (eb1.a.c + 2), 0);
		}
		else
		{
			boq = new boq(this.g, A_0, wj.n, wj.o);
			int num = this.r.Location.X + this.r.Size.c + wj.p;
			boq.Location = new Point(num + A_0 * (wj.n.c + 2), 0);
			boq.c(wj.f);
			boq.g = wj.q;
			boq.i = wj.r;
			boq.h = wj.s;
			boq.j = new Vector2?(wj.w);
			boq.k = wj.x;
		}
		boq.IsPrivateComponent = true;
		boq.e(adi.a);
		boq.h(Color.Orange);
		boq.Color = new Color(200, 0, 0, 255);
		boq.g(new Color(200, 0, 0, 255));
		boq.f(Color.Red);
		boq.a(new Color(0, 0, 255) * 0.5f);
		boq.b(new Color(0, 0, 0, 100));
		boq.d(new Color(255, 0, 0) * 0.5f);
		boq.p(new EventHandler<b25>(this.g));
		this.aox(boq);
		this.l.Add(boq);
		return boq;
	}

	// Token: 0x0600C339 RID: 49977 RVA: 0x00439634 File Offset: 0x00437834
	private eb1 a(int A_0)
	{
		wj wj = wj.a();
		dho dho;
		if (wj.d == UiSize.Classic)
		{
			dho = new dho(this.g, A_0 + 1);
			dho.Location = new Point(564 + A_0 * (eb1.a.c + 2), 0);
		}
		else
		{
			dho = new dho(this.g, A_0 + 1, wj.n, wj.o);
			int num = this.r.Location.X + this.r.Size.c + wj.p;
			dho.Location = new Point(num + A_0 * (wj.n.c + 2), 0);
			dho.c(wj.f);
			dho.g = wj.q;
			dho.i = wj.r;
			dho.h = wj.s;
		}
		dho.IsPrivateComponent = true;
		dho.e(adi.a);
		dho.h(Color.Orange);
		dho.Color = new Color(65, 115, 65);
		dho.g(new Color(200, 0, 0, 255));
		dho.f(new Color(82, 146, 82));
		dho.a(new Color(0, 0, 255) * 0.5f);
		dho.b(new Color(0, 0, 0, 0));
		dho.d(new Color(255, 0, 0) * 0.5f);
		dho.p(new EventHandler<b25>(this.g));
		dho.e(false);
		dho.a(new Color?(Color.Black));
		dho.b(true);
		this.aox(dho);
		this.m.Add(dho);
		return dho;
	}

	// Token: 0x0600C33A RID: 49978 RVA: 0x00439800 File Offset: 0x00437A00
	private void a(Keys A_0)
	{
		foreach (KeyValuePair<Keys, List<cqn>> keyValuePair in this.k)
		{
			bool a_ = keyValuePair.Key == A_0;
			foreach (cqn cqn in keyValuePair.Value)
			{
				cqn.Visible = a_;
			}
		}
		if (A_0 == Keys.LeftShift ^ this.n == Keys.LeftShift)
		{
			bool flag = A_0 == Keys.LeftShift;
			for (int i = 0; i < this.m.Count; i++)
			{
				this.m[i].Visible = flag;
				this.l[i].Visible = !flag;
			}
			this.r.Visible = !flag;
			this.s.Visible = flag;
		}
		this.n = A_0;
	}

	// Token: 0x0600C33B RID: 49979 RVA: 0x00439938 File Offset: 0x00437B38
	private void g(object A_0, b25 A_1)
	{
		if (d4f.b())
		{
			if (A_1.b() == eoo.b)
			{
				ta ta = A_0 as ta;
				if (ta != null && ta.zf())
				{
					d4f.b(ta);
					return;
				}
			}
			else if (A_1.b() == eoo.d)
			{
				d4f.a();
				return;
			}
		}
		else if (A_1.b() == eoo.b)
		{
			eb1 eb = A_0 as eb1;
			if (eb.zc() != null && eb.aka() && this.t != null)
			{
				this.t(A_0, new EventArgs());
			}
		}
	}

	// Token: 0x0600C33C RID: 49980 RVA: 0x004399D4 File Offset: 0x00437BD4
	private void b(object A_0, c1 A_1)
	{
		foreach (cqn cqn in Enumerable.OfType<cqn>(base.Controls))
		{
			cqn.Locked = this.i.Checked;
		}
	}

	// Token: 0x0600C33D RID: 49981 RVA: 0x00439A38 File Offset: 0x00437C38
	private void f(object A_0, b25 A_1)
	{
		this.o.b();
	}

	// Token: 0x0600C33E RID: 49982 RVA: 0x00439A48 File Offset: 0x00437C48
	private void e(object A_0, b25 A_1)
	{
		this.o.b();
	}

	// Token: 0x0600C33F RID: 49983 RVA: 0x00439A58 File Offset: 0x00437C58
	private void d(object A_0, b25 A_1)
	{
		this.p.b();
	}

	// Token: 0x0600C340 RID: 49984 RVA: 0x00439A68 File Offset: 0x00437C68
	private void c(object A_0, b25 A_1)
	{
		this.p.b();
	}

	// Token: 0x0600C341 RID: 49985 RVA: 0x00439A78 File Offset: 0x00437C78
	private void a(object A_0, c1 A_1)
	{
	}

	// Token: 0x0600C342 RID: 49986 RVA: 0x00439A7C File Offset: 0x00437C7C
	private void b(object A_0, b25 A_1)
	{
		this.q.b();
	}

	// Token: 0x0600C343 RID: 49987 RVA: 0x00439A8C File Offset: 0x00437C8C
	private void a(object A_0, b25 A_1)
	{
		this.q.b();
	}

	// Token: 0x040046D0 RID: 18128
	private new const int a = 25;

	// Token: 0x040046D1 RID: 18129
	private new const int b = 25;

	// Token: 0x040046D2 RID: 18130
	private new const int c = 564;

	// Token: 0x040046D3 RID: 18131
	private new const int d = 435;

	// Token: 0x040046D4 RID: 18132
	private new const int e = 412;

	// Token: 0x040046D5 RID: 18133
	private new const int f = 2;

	// Token: 0x040046D6 RID: 18134
	private new efk g;

	// Token: 0x040046D7 RID: 18135
	private doz h;

	// Token: 0x040046D8 RID: 18136
	private doz i;

	// Token: 0x040046D9 RID: 18137
	private new doz j;

	// Token: 0x040046DA RID: 18138
	private new Dictionary<Keys, List<cqn>> k = new Dictionary<Keys, List<cqn>>();

	// Token: 0x040046DB RID: 18139
	private new List<boq> l = new List<boq>();

	// Token: 0x040046DC RID: 18140
	private new List<dho> m = new List<dho>();

	// Token: 0x040046DD RID: 18141
	private Keys n;

	// Token: 0x040046DE RID: 18142
	private dsy o;

	// Token: 0x040046DF RID: 18143
	private dsy p;

	// Token: 0x040046E0 RID: 18144
	private dsy q;

	// Token: 0x040046E1 RID: 18145
	public efq r;

	// Token: 0x040046E2 RID: 18146
	public dvx s;

	// Token: 0x040046E3 RID: 18147
	[CompilerGenerated]
	private EventHandler<EventArgs> t;
}

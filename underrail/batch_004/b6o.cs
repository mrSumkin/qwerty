using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using TimelapseVertigo.Common;

// Token: 0x0200057E RID: 1406
public sealed class b6o : a9t, c73
{
	// Token: 0x06002443 RID: 9283 RVA: 0x000CAE00 File Offset: 0x000C9000
	public b6o(eg A_0, ble A_1)
	{
		this.c = A_0;
		this.d = A_1;
		this.h();
		this.g();
	}

	// Token: 0x06002444 RID: 9284 RVA: 0x000CAE44 File Offset: 0x000C9044
	private new void h()
	{
		wj wj = wj.a();
		esj esj = a2x.a();
		esj esj2;
		if (wj.c())
		{
			esj2 = new esj((int)Math.Min(700.0, (double)esj.c * 0.5), (int)Math.Max(490.0, (double)esj.d * 0.6));
		}
		else
		{
			esj2 = new esj((int)Math.Min((double)wj.d1, (double)esj.c * 0.45), (int)Math.Max((double)wj.d2, (double)esj.d * 0.75));
			esj2.d += wj.g - esj2.d % wj.g;
		}
		if (this.d != null)
		{
			base.Text = "Торговец: " + this.d.ActorName;
			if (wj.c())
			{
				this.j = new apw(bd8.a);
				this.j.Location = new Point(15, 35);
			}
			else
			{
				this.j = new apw((bd8)wj.id);
				this.j.Location = new Point(this.b, wj.ci.d + this.b);
			}
			this.j.a(false);
			this.j.a(this.d.ActorPortrait);
			this.aox(this.j);
		}
		if (this.c != null && this.c.ap7() != null)
		{
			this.c.ap7().aad();
			this.e = new b3w(this.c.ap7(), null, false, true, false, false, 0, false);
			this.e.a(ItemExchangeParty.MerchantInventory.ToString());
			int a_;
			if (wj.c())
			{
				this.e.Location = new Point(15, 110);
				a_ = esj2.d - 330;
			}
			else
			{
				this.e.Location = new Point(this.b, this.j.Location.Y + this.j.Size.d + 2 * this.b);
				a_ = (int)((float)(esj2.d - this.e.Location.Y - this.b) * 0.6f);
			}
			esj esj3 = this.e.a(esj2.c - 2 * this.b, a_);
			this.e.b(esj3.c, esj3.d);
			this.e.a(new Func<ebk, bool>(b6o.a.a.a));
			this.e.a(new Func<ebk, coh, bool>(b6o.a.a.a));
			this.e.Gravity = axy.c;
			this.e.a(new EventHandler<b25>(this.d));
			this.e.d(new EventHandler<b25>(this.c));
			this.aox(this.e);
			int num = this.e.Location.X + this.e.Size.c;
			esj esj4;
			if (wj.c())
			{
				esj4 = new esj((esj3.c - 2) / 2, 3);
			}
			else
			{
				esj4 = new esj((esj3.c - 1) / 2, 3);
			}
			this.f = new b3w(new dcw(), null, false, true, false, false, 0, false);
			this.f.a(ItemExchangeParty.RequestedItems.ToString());
			this.f.b(esj4.c, esj4.d);
			if (wj.c())
			{
				this.f.Location = new Point(15, this.e.Location.Y + this.e.Size.d + 30);
			}
			else
			{
				this.f.Location = new Point(15, this.e.Location.Y + this.e.Size.d + this.b + egg.a(wj.ic));
			}
			this.f.c(false);
			this.f.b(true);
			this.f.a(new Func<ebk, bool>(b6o.a.a.c));
			this.f.a(new Func<ebk, coh, bool>(b6o.a.a.b));
			this.f.a(new EventHandler<b25>(this.f));
			this.f.d(new EventHandler<b25>(this.e));
			this.aox(this.f);
			this.g = new b3w(new dcw(), null, false, true, false, true, 0, false);
			this.g.a(ItemExchangeParty.OfferedItems.ToString());
			this.g.b(esj4.c, esj4.d);
			if (wj.c())
			{
				this.g.Location = new Point(15 + this.e.Size.c - this.f.Size.c, this.e.Location.Y + this.e.Size.d + 30);
			}
			else
			{
				this.g.Location = new Point(15 + this.e.Size.c - this.f.Size.c, this.f.Location.Y);
			}
			this.g.c(false);
			this.g.a(new Func<ebk, bool>(b6o.a.a.b));
			this.g.a(new Func<ebk, coh, bool>(this.a));
			this.g.a(new EventHandler<b25>(this.a));
			this.g.d(new EventHandler<b25>(this.b));
			this.aox(this.g);
			this.h = new avo();
			this.h.Text = "Покупка";
			if (wj.c())
			{
				this.h.Location = new Point(this.f.Location.X, this.f.Location.Y - 20);
				this.h.Size = new esj(this.f.Size.c, 25);
				if (egg.v)
				{
					this.h.a(egg.a);
				}
				else
				{
					this.h.a(egg.@as);
				}
			}
			else
			{
				this.h.Size = new esj(this.f.Size.c, egg.a(wj.ic));
				this.h.Location = new Point(this.f.Location.X, this.f.Location.Y - this.h.Size.d);
				this.h.a(wj.ic);
			}
			this.h.Color = adi.a;
			this.h.a(cab.b);
			this.aox(this.h);
			this.i = new avo();
			this.i.Text = "Предложение";
			if (wj.c())
			{
				this.i.Location = new Point(this.g.Location.X, this.g.Location.Y - 20);
				this.i.Size = new esj(this.g.Size.c, 25);
				if (egg.v)
				{
					this.i.a(egg.a);
				}
				else
				{
					this.i.a(egg.@as);
				}
			}
			else
			{
				this.i.Size = new esj(this.g.Size.c, egg.a(wj.ic));
				this.i.Location = new Point(this.g.Location.X, this.g.Location.Y - this.i.Size.d);
				this.i.a(wj.ic);
			}
			this.i.Color = adi.a;
			this.i.a(cab.b);
			this.aox(this.i);
			this.o = new avo();
			this.o.a(true);
			if (wj.c())
			{
				this.o.Location = new Point(15, this.g.Location.Y + this.g.Size.d + 14);
				if (egg.v)
				{
					this.o.a(egg.a);
					this.o.Location = new Point(this.o.Location.X, this.o.Location.Y + 6);
				}
				else
				{
					this.o.a(egg.@as);
					this.o.Location = new Point(this.o.Location.X, this.o.Location.Y + 2);
				}
			}
			else
			{
				this.o.a(wj.ic);
				this.o.Location = new Point(this.b, this.g.Location.Y + this.g.Size.d + this.b);
			}
			this.o.Color = adi.a;
			this.o.Text = "Не пойдёт";
			this.aox(this.o);
			this.p = new avo();
			this.p.a(true);
			this.p.Text = "По рукам";
			if (wj.c())
			{
				this.p.Location = new Point(this.e.Location.X * 2 + this.e.Size.c - 100, this.o.Location.Y);
				if (egg.v)
				{
					this.p.a(egg.a);
				}
				else
				{
					this.p.a(egg.@as);
				}
			}
			else
			{
				this.p.a(wj.ic);
				this.p.Location = new Point(num - this.p.Size.c, this.o.Location.Y);
			}
			this.p.Color = adi.a;
			this.aox(this.p);
			cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
			this.q = this.c.aqd(serviceOrThrow.aqu().v());
			this.e.a(new double?((double)this.q));
			this.f.a(new double?((double)this.q));
			this.g.a(new double?(Convert.ToDouble(this.d())));
			this.r = new HashSet<string>(this.c.aqa() ?? new List<string>());
			this.n = new c94();
			this.n.e = 0f;
			this.n.f = 2f;
			if (wj.c())
			{
				this.n.Size = new esj(this.e.Location.X * 2 + this.e.Size.c - 215, this.n.Size.d);
				int num2 = (this.p.Size.d - this.n.Size.d) / 2 + egg.b(this.p.g());
				this.n.Location = new Point(this.o.Location.X + this.o.Size.c + this.b, this.o.Location.Y + num2);
			}
			else
			{
				this.n.Size = new esj(this.p.Location.X - (this.o.Location.X + this.o.Size.c) - 2 * this.b, this.n.Size.d);
				int num3 = (this.p.Size.d - this.n.Size.d) / 2 + egg.b(this.p.g());
				this.n.Location = new Point(this.o.Location.X + this.o.Size.c + this.b, this.o.Location.Y + num3);
			}
			this.n.g = 1f;
			this.n.j = new Color(175, 0, 0);
			this.n.k = new Color(0, 135, 0);
			this.aox(this.n);
			int num4;
			if (wj.c())
			{
				num4 = this.p.Location.Y + 67;
			}
			else
			{
				num4 = this.p.Location.Y + this.p.Size.d + 2 * this.b + wj.c2.d;
			}
			if (wj.c())
			{
				if (num4 % 2 != 0)
				{
					num4++;
				}
			}
			else
			{
				wj.a(ref num4);
			}
			base.Size = new esj(this.e.Size.c + 2 * this.b, num4);
			this.k = b6o.b();
			this.k.Text = "Обменять";
			this.k.Location = new Point(base.Size.c - (this.k.Size.c + this.b), base.Size.d - (this.k.Size.d + this.b));
			this.k.c(new EventHandler<b25>(this.h));
			e4z.j(this.k);
			this.aox(this.k);
			this.m = b6o.b();
			this.m.Text = "Сбросить";
			this.m.Location = new Point(this.b, base.Size.d - (this.m.Size.d + this.b));
			this.m.c(new EventHandler<b25>(this.i));
			e4z.j(this.m);
			this.aox(this.m);
			this.l = b6o.b();
			this.l.Text = "Авто";
			this.l.Location = new Point(this.m.Location.X + this.m.Size.c + (this.k.Location.X - (this.m.Location.X + this.m.Size.c)) / 2 - this.l.Size.c / 2, this.k.Location.Y);
			this.l.c(new EventHandler<b25>(this.g));
			e4z.j(this.l);
			this.aox(this.l);
		}
		this.f();
		this.e();
	}

	// Token: 0x06002445 RID: 9285 RVA: 0x000CBF90 File Offset: 0x000CA190
	private new void g()
	{
		float num = (float)this.g.x().z9(this.r, this.d());
		float num2 = (float)this.f.x().z9(this.r, this.q);
		if (num == 0f && num2 == 0f)
		{
			this.n.i = false;
		}
		else
		{
			this.n.i = true;
			if (num == 0f)
			{
				this.n.a(this.n.e);
			}
			else if (num2 == 0f)
			{
				this.n.a(this.n.f);
			}
			else
			{
				this.n.a(num / num2);
			}
		}
		bool flag = this.g.x().z2().Count > 0 && this.f.x().z2().Count > 0;
		bool flag2 = false;
		if (this != null)
		{
		}
		this.k.Enabled = (flag && num >= num2 && !flag2);
		this.l.Enabled = (num != num2);
	}

	// Token: 0x06002446 RID: 9286 RVA: 0x000CC0DC File Offset: 0x000CA2DC
	public override void iv(e6d A_0, cp9 A_1)
	{
		base.iv(A_0, A_1);
		if (this.s != null)
		{
			int y = 0;
			if (this.s.b.d < this.j.Size.d)
			{
				y = (this.j.Size.d - this.s.b.d) / 2;
			}
			Point a_ = d05.a(this.j.at(), new Point(this.j.Size.c + this.b, y), false);
			this.s.a(a_, A_1, null, 1f);
		}
	}

	// Token: 0x06002447 RID: 9287 RVA: 0x000CC18C File Offset: 0x000CA38C
	public bool aeg(coh A_0)
	{
		return true;
	}

	// Token: 0x06002448 RID: 9288 RVA: 0x000CC208 File Offset: 0x000CA408
	public bool aeh(coh A_0)
	{
		return A_0 != null && !this.u.Contains(A_0);
	}

	// Token: 0x06002449 RID: 9289 RVA: 0x000CC224 File Offset: 0x000CA424
	private new void f()
	{
		this.t.Clear();
		if (this.c != null)
		{
			foreach (a0 a in this.c.aqb().Keys)
			{
				this.t.Add(a);
			}
		}
	}

	// Token: 0x0600244A RID: 9290 RVA: 0x000CC2A4 File Offset: 0x000CA4A4
	private new void e()
	{
		wj wj = wj.a();
		string a_;
		if (wj.c())
		{
			if (egg.v)
			{
				a_ = egg.p;
			}
			else if (base.Size.c > 600)
			{
				a_ = egg.ag;
			}
			else
			{
				a_ = egg.z;
			}
		}
		else
		{
			a_ = wj.ic;
		}
		int a_2 = base.Size.c - 2 * this.b - (this.j.Location.X + this.j.Size.c);
		this.s = null;
		if (this.c != null)
		{
			ecs ecs = new ecs();
			dl6 dl = new dl6();
			if (this.c.aqb() != null && this.c.aqb().Count > 0)
			{
				List<a0> list = Enumerable.ToList<a0>(Enumerable.Select<KeyValuePair<a0, int>, a0>(Enumerable.Where<KeyValuePair<a0, int>>(this.c.aqb(), new Func<KeyValuePair<a0, int>, bool>(b6o.a.a.b)), new Func<KeyValuePair<a0, int>, a0>(b6o.a.a.c)));
				List<KeyValuePair<a0, int>> list2 = Enumerable.ToList<KeyValuePair<a0, int>>(Enumerable.Where<KeyValuePair<a0, int>>(this.c.aqb(), new Func<KeyValuePair<a0, int>, bool>(b6o.a.a.a)));
				if (list2.Count > 0)
				{
					dl.a.Add(new bph(new d22(a_, Color.White), "Вот список, того что я покупаю. ", null));
					for (int i = 0; i < list2.Count; i++)
					{
						if (i != 0 && list2.Count > 2)
						{
							if (i == list2.Count - 1)
							{
								dl.a.Add(new bph(new d22(a_, Color.White), ", и ", null));
							}
							else
							{
								dl.a.Add(new bph(new d22(a_, Color.White), ", ", null));
							}
						}
						else if (i != 0 && list2.Count == 2)
						{
							dl.a.Add(new bph(new d22(a_, Color.White), " и ", null));
						}
						string arg = "<missing>";
						if (anh.a.ContainsKey(list2[i].Key))
						{
							if (list2[i].Value > 1)
							{
								arg = anh.a[list2[i].Key].b;
							}
							else
							{
								arg = anh.a[list2[i].Key].a;
							}
						}
						dl.a.Add(new bph(new d22(a_, b6o.a), string.Format("{1}: {0}", list2[i].Value, arg), null));
					}
					dl.a.Add(new bph(new d22(a_, Color.White), ".", null));
				}
				if (list.Count > 0)
				{
					if (list2.Count > 0)
					{
						dl.a.Add(new bph(new d22(a_, Color.White), " Всегда покупаю ", null));
					}
					else
					{
						dl.a.Add(new bph(new d22(a_, Color.White), "Вот что я покупаю: ", null));
					}
					for (int j = 0; j < list.Count; j++)
					{
						if (j != 0 && list.Count > 2)
						{
							if (j == list.Count - 1)
							{
								dl.a.Add(new bph(new d22(a_, Color.White), ", и ", null));
							}
							else
							{
								dl.a.Add(new bph(new d22(a_, Color.White), ", ", null));
							}
						}
						else if (j != 0 && list.Count == 2)
						{
							dl.a.Add(new bph(new d22(a_, Color.White), " и ", null));
						}
						if (anh.a.ContainsKey(list[j]))
						{
							dl.a.Add(new bph(new d22(a_, b6o.a), anh.a[list[j]].b, null));
						}
						else
						{
							dl.a.Add(new bph(new d22(a_, b6o.a), "<missing>", null));
						}
					}
					dl.a.Add(new bph(new d22(a_, Color.White), ".", null));
				}
			}
			else if (this.d.ActorId == "muteFish")
			{
				dl.a.Add(new bph(new d22(a_, adi.h), "Похоже, он не заинтересован в покупке чего-либо.", null));
			}
			else
			{
				dl.a.Add(new bph(new d22(a_, Color.White), "Сейчас я ничего не покупаю. Заходите позже.", null));
			}
			ecs.a.Add(dl);
			ecs ecs2 = Enumerable.FirstOrDefault<ecs>(ecs.a(a_2, int.MaxValue));
			if (ecs2 != null)
			{
				this.s = ecs2.b();
			}
		}
	}

	// Token: 0x0600244B RID: 9291 RVA: 0x000CC858 File Offset: 0x000CAA58
	private void a(object A_0, by0 A_1)
	{
		this.g();
	}

	// Token: 0x0600244C RID: 9292 RVA: 0x000CC860 File Offset: 0x000CAA60
	private new float d()
	{
		if (bpo.GetServiceOrThrow<cnk>().aqu() != null)
		{
			return euf.b().SoldItemValueModifier;
		}
		return 1f;
	}

	// Token: 0x0600244D RID: 9293 RVA: 0x000CC884 File Offset: 0x000CAA84
	private bool c()
	{
		bool result = false;
		this.u.Clear();
		if (this.c != null)
		{
			Dictionary<a0, int> dictionary = new Dictionary<a0, int>(this.c.aqb());
			foreach (coh coh in this.g.l().z2())
			{
				if (!this.r.Contains(coh.Definition.a5()) && coh.Definition.bi() != global::a0.b)
				{
					int num;
					if (!dictionary.TryGetValue(coh.Definition.bi(), out num))
					{
						result = true;
						this.u.Add(coh);
					}
					else if (num != -1)
					{
						if (coh.Stacks > num)
						{
							result = true;
							this.u.Add(coh);
						}
						else
						{
							num -= coh.Stacks;
							if (num == 0)
							{
								dictionary.Remove(coh.Definition.bi());
							}
							else
							{
								dictionary[coh.Definition.bi()] = num;
							}
						}
					}
				}
			}
		}
		return result;
	}

	// Token: 0x0600244E RID: 9294 RVA: 0x000CC9CC File Offset: 0x000CABCC
	private static dak b()
	{
		wj wj = wj.a();
		dak dak = new dak();
		if (wj.c())
		{
			dak.Size = new esj(120, 25);
			if (egg.v)
			{
				dak.Font = egg.a;
				dak.TextLabelOffset = new Point(0, 6);
			}
			else
			{
				dak.Font = egg.aq;
				dak.TextLabelOffset = new Point(0, egg.b(dak.Font));
			}
			dak.d = bo1.z;
		}
		else
		{
			dak.Size = wj.c2;
			dak.Font = wj.c5;
			dak.TextLabelOffset = new Point(0, egg.b(dak.Font));
			dak.d = wj.f;
			dak.f = wj.e7;
			dak.e = new esj?(wj.e8);
		}
		dak.g = adi.a;
		dak.j = adi.b;
		return dak;
	}

	// Token: 0x0600244F RID: 9295 RVA: 0x000CCAC8 File Offset: 0x000CACC8
	private void a()
	{
		if (this.c != null && this.c.ap7() != null)
		{
			foreach (coh a_ in this.f.x().z2())
			{
				this.c.ap7().z3(a_, false);
			}
			this.f.x().z7();
		}
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null && serviceOrThrow.aqu().v() != null)
		{
			foreach (coh a_2 in this.g.x().z2())
			{
				serviceOrThrow.aqu().v().Bag.z3(a_2, false);
			}
			this.g.x().z7();
		}
	}

	// Token: 0x06002450 RID: 9296 RVA: 0x000CCBF4 File Offset: 0x000CADF4
	private Dictionary<string, int> b(dbi A_0, HashSet<string> A_1)
	{
		Dictionary<string, int> dictionary = new Dictionary<string, int>();
		foreach (coh coh in A_0.z2())
		{
			if (coh.Definition.a5() != null && A_1.Contains(coh.Definition.a5()))
			{
				if (dictionary.ContainsKey(coh.Definition.a5()))
				{
					Dictionary<string, int> dictionary2 = dictionary;
					string key = coh.Definition.a5();
					dictionary2[key] += coh.Stacks;
				}
				else
				{
					dictionary[coh.Definition.a5()] = coh.Stacks;
				}
			}
		}
		return dictionary;
	}

	// Token: 0x06002451 RID: 9297 RVA: 0x000CCCD0 File Offset: 0x000CAED0
	private List<coh> a(dbi A_0, HashSet<string> A_1)
	{
		SortedList<coh, coh> sortedList = new SortedList<coh, coh>(new b6o.b(A_1));
		foreach (coh coh in A_0.z2())
		{
			if (coh.SingleItemValue > 0 && coh.Definition.a5() != null && A_1.Contains(coh.Definition.a5()) && this.c.aqe(coh))
			{
				sortedList.Add(coh, coh);
			}
		}
		return new List<coh>(sortedList.Values);
	}

	// Token: 0x06002452 RID: 9298 RVA: 0x000CCD84 File Offset: 0x000CAF84
	private void a(cqy A_0)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null && serviceOrThrow.aqu().v() != null && A_0 != null && A_0.x6() != null)
		{
			serviceOrThrow.aqu().v().Bag.z3(A_0.x6(), false);
			this.g.l().z5(A_0.x6());
			e4z.c();
		}
	}

	// Token: 0x06002453 RID: 9299 RVA: 0x000CCDFC File Offset: 0x000CAFFC
	protected override void i0()
	{
		base.i0();
		if (this.f != null)
		{
			(this.f.x() as bqr).a().zw(new EventHandler<by0>(this.a));
			(this.f.x() as bqr).a().zy(new EventHandler<by0>(this.a));
		}
		if (this.g != null)
		{
			(this.g.x() as bqr).a().zw(new EventHandler<by0>(this.a));
			(this.g.x() as bqr).a().zy(new EventHandler<by0>(this.a));
		}
		bpo.RegisterService<c73>(this);
	}

	// Token: 0x06002454 RID: 9300 RVA: 0x000CCEC4 File Offset: 0x000CB0C4
	protected override void i1()
	{
		base.i1();
		if (this.f != null)
		{
			(this.f.x() as bqr).a().zx(new EventHandler<by0>(this.a));
			(this.f.x() as bqr).a().zz(new EventHandler<by0>(this.a));
		}
		if (this.g != null)
		{
			(this.g.x() as bqr).a().zx(new EventHandler<by0>(this.a));
			(this.g.x() as bqr).a().zz(new EventHandler<by0>(this.a));
		}
		bpo.UnregisterService<c73>();
	}

	// Token: 0x06002455 RID: 9301 RVA: 0x000CCF8C File Offset: 0x000CB18C
	protected override void aei(object A_0, ddj A_1)
	{
		base.aei(A_0, A_1);
		this.a();
	}

	// Token: 0x06002456 RID: 9302 RVA: 0x000CCF9C File Offset: 0x000CB19C
	private new void i(object A_0, b25 A_1)
	{
		this.a();
	}

	// Token: 0x06002457 RID: 9303 RVA: 0x000CCFA8 File Offset: 0x000CB1A8
	private new void h(object A_0, b25 A_1)
	{
		if (this.c != null)
		{
			foreach (coh coh in this.g.x().z2())
			{
				this.e.x().z3(coh, true);
				a7v.a(new e4v(coh));
				int num;
				if (!this.r.Contains(coh.Definition.a5()) && coh.Definition.bi() != global::a0.b && this.c.aqb().TryGetValue(coh.Definition.bi(), out num) && num != -1)
				{
					num -= coh.Stacks;
					if (num <= 0)
					{
						this.c.aqb().Remove(coh.Definition.bi());
					}
					else
					{
						this.c.aqb()[coh.Definition.bi()] = num;
					}
				}
			}
			this.g.x().z7();
			cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
			foreach (coh coh2 in this.f.x().z2())
			{
				coh2.CustomProperties.RemoveProperty(vo.h);
				serviceOrThrow.aqu().v().Bag.z3(coh2, true);
				a7v.a(new beh(coh2));
			}
			this.f.x().z7();
			this.e();
			this.f();
		}
	}

	// Token: 0x06002458 RID: 9304 RVA: 0x000CD188 File Offset: 0x000CB388
	private new void g(object A_0, b25 A_1)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null && serviceOrThrow.aqu().v() != null)
		{
			HashSet<string> hashSet = new HashSet<string>(this.c.aqa() ?? new List<string>());
			foreach (string a_ in hashSet)
			{
				coh coh = this.g.l().a(a_, int.MaxValue);
				if (coh != null)
				{
					serviceOrThrow.aqu().v().Bag.z3(coh, true);
				}
				coh coh2 = this.f.l().a(a_, int.MaxValue);
				if (coh2 != null)
				{
					this.e.l().z3(coh2, true);
				}
			}
			float num = (float)this.g.x().z9(this.r, this.d());
			float num2 = (float)this.f.x().z9(this.r, this.q);
			float num3 = num;
			float num4 = num2;
			List<coh> list = this.a(serviceOrThrow.aqu().v().Bag, hashSet);
			if (list.Count > 0)
			{
				while (list.Count > 0 && num3 < num4)
				{
					int index = this.a(list, num3, num4);
					coh coh3 = list[index];
					coh coh4 = coh3.fy();
					coh4.Stacks = 1;
					this.g.l().z3(coh4, true);
					num3 += (float)coh4.ItemValue;
					coh coh5 = coh3;
					int num5 = coh5.Stacks;
					coh5.Stacks = num5 - 1;
					if (coh3.Stacks <= 0)
					{
						serviceOrThrow.aqu().v().Bag.z5(coh3);
						list.RemoveAt(index);
					}
				}
			}
			list = this.a(this.e.l(), hashSet);
			if (list.Count > 0)
			{
				while (list.Count > 0)
				{
					coh coh6 = list[0].fy();
					coh6.Stacks = 1;
					num4 += (float)e7a.a(new coh[]
					{
						coh6
					}, this.r, this.q);
					if (num4 > num3)
					{
						break;
					}
					this.f.l().z3(coh6, true);
					coh coh7 = list[0];
					int num5 = coh7.Stacks;
					coh7.Stacks = num5 - 1;
					if (list[0].Stacks <= 0)
					{
						this.e.l().z5(list[0]);
						list.RemoveAt(0);
					}
				}
			}
			Dictionary<string, int> dictionary = this.b(this.g.l(), this.r);
			Dictionary<string, int> dictionary2 = this.b(this.f.l(), this.r);
			foreach (KeyValuePair<string, int> keyValuePair in dictionary)
			{
				int val;
				if (dictionary2.TryGetValue(keyValuePair.Key, out val))
				{
					int a_2 = Math.Min(val, keyValuePair.Value);
					coh coh8 = this.g.l().a(keyValuePair.Key, a_2);
					if (coh8 != null)
					{
						serviceOrThrow.aqu().v().Bag.z3(coh8, true);
					}
					coh coh9 = this.f.l().a(keyValuePair.Key, a_2);
					if (coh9 != null)
					{
						this.e.l().z3(coh9, true);
					}
				}
			}
		}
		this.g();
	}

	// Token: 0x06002459 RID: 9305 RVA: 0x000CD56C File Offset: 0x000CB76C
	private int a(List<coh> A_0, float A_1, float A_2)
	{
		int result = 0;
		A_0[0].SingleItemValue;
		int num = this.c.aqa().IndexOf(A_0[0].Definition.a5());
		for (int i = 1; i < A_0.Count; i++)
		{
			int num2 = this.c.aqa().IndexOf(A_0[1].Definition.a5());
			if (num2 < num)
			{
				num = num2;
				A_0[i].SingleItemValue;
				result = i;
			}
		}
		return result;
	}

	// Token: 0x0600245A RID: 9306 RVA: 0x000CD5FC File Offset: 0x000CB7FC
	private new void f(object A_0, b25 A_1)
	{
		cqy cqy = A_0 as cqy;
		if (cqy != null && cqy.x6() != null && c69.a(cqy, this.e, cqy.x6(), true))
		{
			e4z.c();
		}
	}

	// Token: 0x0600245B RID: 9307 RVA: 0x000CD640 File Offset: 0x000CB840
	private new void e(object A_0, b25 A_1)
	{
		cqy cqy = A_0 as cqy;
		if (cqy != null && cqy.x6() != null)
		{
			KeyboardState state = Keyboard.GetState();
			if (A_1.b() == eoo.b && (state.IsKeyDown(Keys.LeftAlt) || state.IsKeyDown(Keys.RightAlt)) && c69.a(cqy, this.e, cqy.x6(), true))
			{
				e4z.c();
			}
		}
	}

	// Token: 0x0600245C RID: 9308 RVA: 0x000CD6B8 File Offset: 0x000CB8B8
	private new void d(object A_0, b25 A_1)
	{
		cqy cqy = A_0 as cqy;
		if (cqy != null && cqy.x6() != null && c69.a(cqy, this.f, cqy.x6(), true))
		{
			e4z.c();
		}
	}

	// Token: 0x0600245D RID: 9309 RVA: 0x000CD6FC File Offset: 0x000CB8FC
	private void c(object A_0, b25 A_1)
	{
		cqy cqy = A_0 as cqy;
		if (cqy != null && cqy.x6() != null)
		{
			KeyboardState state = Keyboard.GetState();
			if (A_1.b() == eoo.b && (state.IsKeyDown(Keys.LeftAlt) || state.IsKeyDown(Keys.RightAlt)) && c69.a(cqy, this.f, cqy.x6(), true))
			{
				e4z.c();
			}
		}
	}

	// Token: 0x0600245E RID: 9310 RVA: 0x000CD774 File Offset: 0x000CB974
	private void b(object A_0, b25 A_1)
	{
		KeyboardState state = Keyboard.GetState();
		if ((state.IsKeyDown(Keys.LeftAlt) || state.IsKeyDown(Keys.RightAlt)) && A_1.b() == eoo.b)
		{
			cqy a_ = A_0 as cqy;
			this.a(a_);
		}
	}

	// Token: 0x0600245F RID: 9311 RVA: 0x000CD7C4 File Offset: 0x000CB9C4
	private void a(object A_0, b25 A_1)
	{
		if (A_1.b() == eoo.b)
		{
			cqy a_ = A_0 as cqy;
			this.a(a_);
		}
	}

	// Token: 0x06002461 RID: 9313 RVA: 0x000CD7FC File Offset: 0x000CB9FC
	[CompilerGenerated]
	private bool a(ebk A_0, coh A_1)
	{
		return A_0 != null && (A_0.x8() == ItemExchangeParty.PlayerInventory.ToString() || A_0.x8() == ItemExchangeParty.PlayerGear.ToString()) && A_1 != null && A_1.ItemValue > 0 && this.c.aqe(A_1);
	}

	// Token: 0x0400150A RID: 5386
	private new static readonly Color a = Color.Goldenrod;

	// Token: 0x0400150B RID: 5387
	private new int b = 15;

	// Token: 0x0400150C RID: 5388
	private new eg c;

	// Token: 0x0400150D RID: 5389
	private new ble d;

	// Token: 0x0400150E RID: 5390
	private new b3w e;

	// Token: 0x0400150F RID: 5391
	private new b3w f;

	// Token: 0x04001510 RID: 5392
	public new b3w g;

	// Token: 0x04001511 RID: 5393
	private new avo h;

	// Token: 0x04001512 RID: 5394
	private new avo i;

	// Token: 0x04001513 RID: 5395
	private new apw j;

	// Token: 0x04001514 RID: 5396
	private new dak k;

	// Token: 0x04001515 RID: 5397
	private new dak l;

	// Token: 0x04001516 RID: 5398
	private new dak m;

	// Token: 0x04001517 RID: 5399
	private c94 n;

	// Token: 0x04001518 RID: 5400
	private avo o;

	// Token: 0x04001519 RID: 5401
	private avo p;

	// Token: 0x0400151A RID: 5402
	private float q;

	// Token: 0x0400151B RID: 5403
	private HashSet<string> r;

	// Token: 0x0400151C RID: 5404
	private dn3 s;

	// Token: 0x0400151D RID: 5405
	private HashSet<a0> t = new HashSet<a0>();

	// Token: 0x0400151E RID: 5406
	private HashSet<coh> u = new HashSet<coh>();

	// Token: 0x02002025 RID: 8229
	private new sealed class b : IComparer<coh>
	{
		// Token: 0x0600C2D2 RID: 49874 RVA: 0x00436F18 File Offset: 0x00435118
		public b(HashSet<string> A_0)
		{
			this.a = A_0;
		}

		// Token: 0x0600C2D3 RID: 49875 RVA: 0x00436F2C File Offset: 0x0043512C
		public int Compare(coh x, coh y)
		{
			if (x.Definition.a5() != null && this.a.Contains(x.Definition.a5()))
			{
				if (y.Definition.a5() == null || !this.a.Contains(y.Definition.a5()))
				{
					return -1;
				}
				if (x.SingleItemValue < y.SingleItemValue)
				{
					return -1;
				}
				return 1;
			}
			else
			{
				if (y.Definition.a5() != null && this.a.Contains(y.Definition.a5()))
				{
					return 1;
				}
				if (x.SingleItemValue < y.SingleItemValue)
				{
					return -1;
				}
				return 1;
			}
		}

		// Token: 0x04004698 RID: 18072
		private HashSet<string> a;
	}

	// Token: 0x02002026 RID: 8230
	[CompilerGenerated]
	[Serializable]
	private new sealed class a
	{
		// Token: 0x0600C2D6 RID: 49878 RVA: 0x00437000 File Offset: 0x00435200
		internal bool a(ebk A_0)
		{
			return A_0 != null && A_0.x8() == ItemExchangeParty.RequestedItems.ToString();
		}

		// Token: 0x0600C2D7 RID: 49879 RVA: 0x00437030 File Offset: 0x00435230
		internal bool a(ebk A_0, coh A_1)
		{
			return A_0 != null && A_0.x8() == ItemExchangeParty.RequestedItems.ToString();
		}

		// Token: 0x0600C2D8 RID: 49880 RVA: 0x00437060 File Offset: 0x00435260
		internal bool c(ebk A_0)
		{
			return A_0 != null && A_0.x8() == ItemExchangeParty.MerchantInventory.ToString();
		}

		// Token: 0x0600C2D9 RID: 49881 RVA: 0x00437090 File Offset: 0x00435290
		internal bool b(ebk A_0, coh A_1)
		{
			return A_0 != null && A_0.x8() == ItemExchangeParty.MerchantInventory.ToString() && A_1 != null && A_1.ItemValue > 0;
		}

		// Token: 0x0600C2DA RID: 49882 RVA: 0x004370D4 File Offset: 0x004352D4
		internal bool b(ebk A_0)
		{
			return A_0 != null && (A_0.x8() == ItemExchangeParty.PlayerInventory.ToString() || A_0.x8() == ItemExchangeParty.PlayerGear.ToString());
		}

		// Token: 0x0600C2DB RID: 49883 RVA: 0x00437124 File Offset: 0x00435324
		internal bool b(KeyValuePair<a0, int> A_0)
		{
			return A_0.Value == -1;
		}

		// Token: 0x0600C2DC RID: 49884 RVA: 0x00437130 File Offset: 0x00435330
		internal a0 c(KeyValuePair<a0, int> A_0)
		{
			return A_0.Key;
		}

		// Token: 0x0600C2DD RID: 49885 RVA: 0x0043713C File Offset: 0x0043533C
		internal bool a(KeyValuePair<a0, int> A_0)
		{
			return A_0.Value != -1;
		}

		// Token: 0x04004699 RID: 18073
		public static readonly b6o.a a = new b6o.a();

		// Token: 0x0400469A RID: 18074
		public static Func<ebk, bool> b;

		// Token: 0x0400469B RID: 18075
		public static Func<ebk, coh, bool> c;

		// Token: 0x0400469C RID: 18076
		public static Func<ebk, bool> d;

		// Token: 0x0400469D RID: 18077
		public static Func<ebk, coh, bool> e;

		// Token: 0x0400469E RID: 18078
		public static Func<ebk, bool> f;

		// Token: 0x0400469F RID: 18079
		public static Func<KeyValuePair<a0, int>, bool> g;

		// Token: 0x040046A0 RID: 18080
		public static Func<KeyValuePair<a0, int>, a0> h;

		// Token: 0x040046A1 RID: 18081
		public static Func<KeyValuePair<a0, int>, bool> i;
	}
}

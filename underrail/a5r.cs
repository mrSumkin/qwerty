using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using TimelapseVertigo.Game.Data;

// Token: 0x020005A6 RID: 1446
public sealed class a5r : a9t, amj, dpp
{
	// Token: 0x0600265A RID: 9818 RVA: 0x000D924C File Offset: 0x000D744C
	public override bool et()
	{
		return base.IsMousedOver || this.c.IsMousedOver || this.d.IsMousedOver || (this.g != null && this.g.IsMousedOver) || (this.f != null && this.f.IsMousedOver);
	}

	// Token: 0x0600265B RID: 9819 RVA: 0x000D92BC File Offset: 0x000D74BC
	public b0b u7()
	{
		return this.j;
	}

	// Token: 0x0600265C RID: 9820 RVA: 0x000D92C4 File Offset: 0x000D74C4
	public double u8()
	{
		return this.i;
	}

	// Token: 0x0600265D RID: 9821 RVA: 0x000D92CC File Offset: 0x000D74CC
	public a5r()
	{
		this.b();
	}

	// Token: 0x0600265E RID: 9822 RVA: 0x000D92DC File Offset: 0x000D74DC
	private void b()
	{
		wj wj = wj.a();
		if (wj.c())
		{
			this.d = bo1.r;
		}
		else
		{
			this.d = wj.f;
			this.e = wj.b8;
			this.f = wj.b9;
		}
		base.Text = "Глобальная карта";
		esj esj = a2x.a();
		esj a_ = new esj((int)((double)esj.c * 0.8), (int)((double)esj.d * 0.8));
		base.Size = a_;
		base.Location = new Point((esj.c - base.Size.c) / 2, (esj.d - base.Size.d) / 2);
		e5f serviceOrThrow = bpo.GetServiceOrThrow<e5f>();
		cnk serviceOrThrow2 = bpo.GetServiceOrThrow<cnk>();
		GlobalMap value;
		Vector3? a_2;
		if (serviceOrThrow2.aqu() != null && !serviceOrThrow2.aqu().q().c && serviceOrThrow2.aqu().q().a != null)
		{
			value = serviceOrThrow2.aqu().q().a.Value;
			a_2 = serviceOrThrow2.aqu().q().a(value);
		}
		else
		{
			this.a(out value, out a_2);
		}
		dj1 dj = new dj1();
		if (wj.c())
		{
			dj.Location = new Point(3, 28);
			dj.Size = new esj(base.Size.c - dj.Location.X * 2, base.Size.d - 31);
		}
		else
		{
			dj.Location = new Point(5, wj.ci.d + 1);
			dj.Size = new esj(base.Size.c - dj.Location.X * 2, base.Size.d - dj.Location.Y - 5);
		}
		dj.Gravity = axy.b;
		this.aox(dj);
		li serviceOrThrow3 = bpo.GetServiceOrThrow<li>();
		this.a = new d69(serviceOrThrow3.ka());
		this.a.ak = 3;
		this.a.ai = 3;
		this.a.Size = dj.Size;
		this.a.Gravity = axy.b;
		this.a.aoa(new bw7());
		this.a.an9().t9(true);
		this.a.an9().t5(new Vector2(0f, 0f));
		this.a.an9().t7(new Vector2(1f, 1f));
		this.a.d.a(false);
		this.a.d.c(false);
		this.a.a(true);
		this.a.d.a(20);
		this.a.d.a(0.3f);
		this.a.h.a = edg.a;
		this.a.g.a(brh.b);
		if (!wj.c())
		{
			if (serviceOrThrow2.aq1().g().d)
			{
				this.a.an9().ub(a5r.k);
				this.a.an9().uf(3f);
				this.a.an9().ud(0.75f);
				this.a.e.a = true;
				this.a.e.b = 0.25f;
				this.f = new doz();
				this.f.Gravity = axy.c;
				this.f.Size = wj.a0;
				this.f.a(wj.f);
				this.f.a(wj.a1);
				this.f.Location = new Point(this.f.Size.c / 2, base.Size.d - (int)((double)this.f.Size.d * 1.5));
				this.f.c(new EventHandler<b25>(this.b));
				e4z.f(this.f);
				this.aox(this.f);
				this.g = new doz();
				this.g.Gravity = axy.c;
				this.g.Size = wj.a0;
				this.g.a(wj.f);
				this.g.a(new Point(wj.a1.X + wj.a0.c, wj.a1.Y));
				this.g.Location = new Point(this.f.Location.X + wj.a0.c, this.f.Location.Y);
				this.g.c(new EventHandler<b25>(this.a));
				e4z.f(this.g);
				this.aox(this.g);
			}
			else
			{
				a5r.k = efw.a(serviceOrThrow2.aq1().g().a).h;
				this.a.an9().ub(a5r.k);
				this.a.e.a = false;
			}
		}
		else
		{
			a5r.k = 1f;
		}
		dj.aox(this.a);
		this.a.f();
		this.a.aoh(new EventHandler<a3x>(this.a));
		avo avo = new avo();
		avo.Color = adi.a;
		avo.a(true);
		avo.Text = "Карта";
		if (wj.c())
		{
			avo.a(egg.aq);
			avo.Location = new Point(12, 35);
		}
		else
		{
			avo.a(wj.fc);
			avo.Location = new Point(wj.ci.d / 2, 0);
		}
		this.aox(avo);
		this.b = new aw9(serviceOrThrow.asa(), new Func<object, string>(a5r.a), new Func<object, bool>(a5r.b));
		this.b.b(value);
		if (wj.c())
		{
			this.b.Size = new esj(Math.Min(base.Size.c - 20, 300), 25);
			this.b.a(egg.aq);
			this.b.Location = new Point(avo.Location.X + avo.Size.c + 10, avo.Location.Y - 3);
		}
		else
		{
			this.b.Size = new esj(Math.Min(base.Size.c - 20, 300), wj.fb);
			this.b.Location = new Point(avo.Location.X + avo.Size.c + 10, (int)((float)wj.ci.d * 1.25f));
			avo.Location = new Point(avo.Location.X, this.b.Location.Y + (this.b.Size.d - avo.Size.d) / 2);
		}
		this.b.Gravity = axy.c;
		this.b.a(new EventHandler<c1>(this.a));
		this.aox(this.b);
		this.c = new doz();
		if (wj.c())
		{
			this.c.a(bo1.bs);
			this.c.a(new Point(0, 0));
			this.c.Size = new esj(25, 25);
			this.c.Location = new Point(this.b.Location.X + this.b.Size.c + 5, this.b.Location.Y);
		}
		else
		{
			this.c.a(wj.f);
			this.c.a(wj.fs);
			this.c.Size = wj.ft;
			this.c.Location = new Point(this.b.Location.X + this.b.Size.c + 5, this.b.Location.Y + (this.c.Size.d - this.c.Size.d) / 2);
		}
		this.c.c(new EventHandler<b25>(this.h));
		this.c.j(new EventHandler<b25>(this.c));
		this.c.l(new EventHandler<b25>(this.d));
		e4z.j(this.c);
		this.aox(this.c);
		this.d = new doz();
		if (wj.c())
		{
			this.d.Location = new Point(this.c.Location.X + this.c.Size.c + 5, this.c.Location.Y);
			this.d.a(bo1.bs);
			this.d.a(new Point(25, 0));
			this.d.Size = new esj(25, 25);
		}
		else
		{
			this.d.Location = new Point(this.c.Location.X + this.c.Size.c + 5, this.c.Location.Y);
			this.d.a(wj.f);
			this.d.a(new Point(wj.fs.X + wj.ft.c, wj.fs.Y));
			this.d.Size = wj.ft;
		}
		this.d.c(new EventHandler<b25>(this.g));
		this.d.j(new EventHandler<b25>(this.e));
		this.d.l(new EventHandler<b25>(this.f));
		this.d.Checked = serviceOrThrow2.aqu().q().c;
		e4z.j(this.d);
		this.aox(this.d);
		if (!wj.c())
		{
			int num = (this.c.Size.d - this.b.Size.d) / 2;
			if (num > 0)
			{
				this.b.d(0, num);
				avo.d(0, num);
			}
		}
		this.a(value, a_2);
		this.h = new dsy(this, this, esj.a(), cq4.a(400), null, null, 3000, true, true);
		this.a();
	}

	// Token: 0x0600265F RID: 9823 RVA: 0x000D9EAC File Offset: 0x000D80AC
	private static bool b(object A_0)
	{
		if (A_0 is GlobalMap)
		{
			GlobalMap a_ = (GlobalMap)A_0;
			return bpo.GetServiceOrThrow<e5f>().ask(a_);
		}
		return false;
	}

	// Token: 0x06002660 RID: 9824 RVA: 0x000D9ED8 File Offset: 0x000D80D8
	private void a()
	{
		if (this.h != null)
		{
			Point point = base.at();
			this.h.a(cq4.a(300));
			this.h.a(new Point?(new Point(point.X + base.Size.c - 10, point.Y + base.Size.d - 10)));
		}
	}

	// Token: 0x06002661 RID: 9825 RVA: 0x000D9F4C File Offset: 0x000D814C
	private new void h(object A_0, b25 A_1)
	{
		this.u9();
	}

	// Token: 0x06002662 RID: 9826 RVA: 0x000D9F58 File Offset: 0x000D8158
	private new void g(object A_0, b25 A_1)
	{
		if (!this.d.Checked)
		{
			this.u9();
			this.d.Checked = true;
		}
		else
		{
			this.d.Checked = false;
		}
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null)
		{
			serviceOrThrow.aqu().q().c = this.d.Checked;
		}
	}

	// Token: 0x06002663 RID: 9827 RVA: 0x000D9FC4 File Offset: 0x000D81C4
	private static string a(object A_0)
	{
		if (A_0 == null)
		{
			return "";
		}
		return A_0.ToString().a();
	}

	// Token: 0x06002664 RID: 9828 RVA: 0x000D9FE0 File Offset: 0x000D81E0
	private void a(GlobalMap A_0, Vector3? A_1)
	{
		e5f serviceOrThrow = bpo.GetServiceOrThrow<e5f>();
		string a_ = serviceOrThrow.asb()[A_0];
		aud aud = serviceOrThrow.ar9().n(a_);
		Vector3 value;
		if (A_1 != null)
		{
			value = A_1.Value;
		}
		else
		{
			value = new Vector3((float)aud.Size.c / 2f, (float)aud.Size.d / 2f, 0f);
		}
		this.a.an0(aud);
		this.a.an9().t7(new Vector2((float)aud.Size.c, (float)aud.Size.d));
		this.a.an9().t2(value);
		cnk serviceOrThrow2 = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow2.aqu() != null)
		{
			serviceOrThrow2.aqu().q().a = new GlobalMap?(A_0);
		}
	}

	// Token: 0x06002665 RID: 9829 RVA: 0x000DA0C8 File Offset: 0x000D82C8
	private void a(out GlobalMap A_0, out Vector3? A_1)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		e5f serviceOrThrow2 = bpo.GetServiceOrThrow<e5f>();
		if (serviceOrThrow.aqu() != null)
		{
			string text = serviceOrThrow.aqu().c().b();
			if (serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("dungeon_" + text, new bool?(false)).Value)
			{
				string classPropertyValue = serviceOrThrow.aqu().r().GetClassPropertyValue<string>(string.Format("dungeon_{0}_sourceLocale", text));
				if (!string.IsNullOrEmpty(classPropertyValue))
				{
					text = classPropertyValue;
				}
			}
			text = text.ToLowerInvariant();
			d60 addon = serviceOrThrow2.ar9().GetAddon<d60>();
			List<b0b> list = addon.ab4(new string[]
			{
				string.Format("LocaleRepresenter_{0}", text)
			});
			if (list != null && list.Count > 0)
			{
				b0b b0b = Enumerable.First<b0b>(list);
				GlobalMap globalMap;
				Vector3 value;
				if (b0b != null && this.a(b0b, out globalMap, out value))
				{
					A_0 = globalMap;
					A_1 = new Vector3?(value);
					return;
				}
			}
			List<b0b> list2 = addon.ab4(new string[]
			{
				string.Format("LocaleContainer_{0}", text)
			});
			if (list2 != null && list2.Count > 0)
			{
				b0b b0b2 = Enumerable.First<b0b>(list2);
				GlobalMap globalMap2;
				Vector3 value2;
				if (b0b2 != null && this.a(b0b2, out globalMap2, out value2))
				{
					A_0 = globalMap2;
					A_1 = new Vector3?(value2);
					return;
				}
			}
		}
		A_0 = GlobalMap.Unknown;
		A_1 = new Vector3?(new Vector3(1.5f, 1.5f, 0f));
	}

	// Token: 0x06002666 RID: 9830 RVA: 0x000DA258 File Offset: 0x000D8458
	private bool a(b0b A_0, out GlobalMap A_1, out Vector3 A_2)
	{
		e5f serviceOrThrow = bpo.GetServiceOrThrow<e5f>();
		A_2 = new Vector3(A_0.Location.X + A_0.Size.X / 2f, A_0.Location.Y + A_0.Size.Y / 2f, 0f);
		if (A_0.Location.Z != 0f)
		{
			A_2 -= A_0.Location.Z * new Vector3(0.5f, 0.5f, 0f);
		}
		return serviceOrThrow.asc().TryGetValue(A_0.Area.y8(), out A_1);
	}

	// Token: 0x06002667 RID: 9831 RVA: 0x000DA31C File Offset: 0x000D851C
	private void a(GlobalMap A_0, Vector3 A_1)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null)
		{
			serviceOrThrow.aqu().q().b[A_0] = A_1;
		}
	}

	// Token: 0x06002668 RID: 9832 RVA: 0x000DA354 File Offset: 0x000D8554
	public override void ag5(e6d A_0)
	{
		this.a();
		this.h.b();
		if (this.i > 0.0)
		{
			this.i = Math.Max(0.0, this.i - A_0.a().ElapsedGameTime.TotalMilliseconds);
		}
		else
		{
			this.j = null;
		}
		if (this.a != null)
		{
			a5r.k = this.a.any();
		}
		base.ag5(A_0);
	}

	// Token: 0x06002669 RID: 9833 RVA: 0x000DA3E4 File Offset: 0x000D85E4
	public override void iv(e6d A_0, cp9 A_1)
	{
		base.iv(A_0, A_1);
		this.h.a(A_0);
	}

	// Token: 0x0600266A RID: 9834 RVA: 0x000DA3FC File Offset: 0x000D85FC
	public ecs yf(euz A_0)
	{
		string text = null;
		string text2 = null;
		string a_ = null;
		if (this.c.IsMousedOver)
		{
			text = "Центрировать на игрока";
			a_ = "Перейти к области, в которой сейчас находится игрок.";
		}
		else if (this.d.IsMousedOver)
		{
			text = "Следовать за игроком";
			a_ = "При открытии карта будет автоматически переключаться на область, в которой находится игрок.";
		}
		else if (this.g != null && this.g.IsMousedOver)
		{
			text = "Приблизить";
			text2 = "SHIFT+Колесо мыши вверх";
			a_ = "Увеличить масштаб.";
		}
		else if (this.f != null && this.f.IsMousedOver)
		{
			text = "Отдалить";
			text2 = "SHIFT+Колесо мыши вниз";
			a_ = "Уменьшить масштаб.";
		}
		if (text != null)
		{
			ecs ecs = new ecs(new List<dl6>());
			dl6 dl = new dl6();
			dl.a.Add(new bph(new d22(cq4.d(), adi.c), text + ((text2 != null) ? " (" : ""), null));
			if (text2 != null)
			{
				dl.a.Add(new bph(new d22(cq4.d(), Color.White), text2, null));
				dl.a.Add(new bph(new d22(cq4.d(), adi.c), ")", null));
			}
			ecs.a.Add(dl);
			ecs.a.Add(new dl6(new List<bph>
			{
				new bph(new d22(cq4.c(), Color.White), null, null)
			}));
			ecs.a.Add(new dl6(new List<bph>
			{
				new bph(new d22(cq4.c(), Color.LightGray), a_, null)
			}));
			return ecs;
		}
		return null;
	}

	// Token: 0x0600266B RID: 9835 RVA: 0x000DA5C0 File Offset: 0x000D87C0
	public void u9()
	{
		GlobalMap globalMap;
		Vector3? a_;
		this.a(out globalMap, out a_);
		this.b.b(globalMap);
		this.a(globalMap, a_);
	}

	// Token: 0x0600266C RID: 9836 RVA: 0x000DA5F0 File Offset: 0x000D87F0
	public void va()
	{
		e5f serviceOrThrow = bpo.GetServiceOrThrow<e5f>();
		this.b.a(serviceOrThrow.asa(), new Func<object, bool>(a5r.b));
	}

	// Token: 0x0600266D RID: 9837 RVA: 0x000DA620 File Offset: 0x000D8820
	protected override void i0()
	{
		base.i0();
		bpo.UnregisterService<dpp>();
		bpo.RegisterService<dpp>(this);
	}

	// Token: 0x0600266E RID: 9838 RVA: 0x000DA634 File Offset: 0x000D8834
	protected override void i1()
	{
		base.i1();
		if (this.e != null)
		{
			this.e.z();
			this.e = null;
		}
		bpo.UnregisterService<dpp>();
	}

	// Token: 0x0600266F RID: 9839 RVA: 0x000DA664 File Offset: 0x000D8864
	protected override void r4(object A_0, el5 A_1)
	{
		base.r4(A_0, A_1);
		if (this.e != null)
		{
			this.e.z();
			this.e = null;
		}
		if (bpo.GetServiceOrThrow<cnk>().aqu() != null && this.b.l() is GlobalMap)
		{
			GlobalMap a_ = (GlobalMap)this.b.l();
			this.a(a_, this.a.an9().t1());
		}
	}

	// Token: 0x06002670 RID: 9840 RVA: 0x000DA6E4 File Offset: 0x000D88E4
	private void a(object A_0, c1 A_1)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null)
		{
			if (A_1.b() is GlobalMap)
			{
				GlobalMap a_ = (GlobalMap)A_1.b();
				this.a(a_, this.a.an9().t1());
			}
			if (this.b.l() is GlobalMap)
			{
				GlobalMap a_2 = (GlobalMap)this.b.l();
				this.a(a_2, serviceOrThrow.aqu().q().a(a_2));
			}
		}
	}

	// Token: 0x06002671 RID: 9841 RVA: 0x000DA774 File Offset: 0x000D8974
	private new void f(object A_0, b25 A_1)
	{
		this.h.b();
	}

	// Token: 0x06002672 RID: 9842 RVA: 0x000DA784 File Offset: 0x000D8984
	private new void e(object A_0, b25 A_1)
	{
		this.h.b();
	}

	// Token: 0x06002673 RID: 9843 RVA: 0x000DA794 File Offset: 0x000D8994
	private new void d(object A_0, b25 A_1)
	{
		this.h.b();
	}

	// Token: 0x06002674 RID: 9844 RVA: 0x000DA7A4 File Offset: 0x000D89A4
	private void c(object A_0, b25 A_1)
	{
		this.h.b();
	}

	// Token: 0x06002675 RID: 9845 RVA: 0x000DA7B4 File Offset: 0x000D89B4
	private void a(object A_0, a3x A_1)
	{
		if (A_1.b() == eoo.b)
		{
			KeyboardState state = Keyboard.GetState();
			if (A_1.a() != null)
			{
				dy9 aspect = A_1.a().GetAspect<dy9>();
				if (aspect != null && aspect.a() != MapNodeState.Obscured && (state.IsKeyDown(Keys.LeftShift) || state.IsKeyDown(Keys.LeftShift)))
				{
					this.e = new c6a(A_1.a(), base.Size.c);
					this.e.Location = new Point((base.Size.c - this.e.Size.c) / 2, (base.Size.d - this.e.Size.d) / 2);
					this.e.a(new EventHandler<el5>(this.a));
					this.aox(this.e);
					this.e.bj();
					return;
				}
				djr aspect2 = A_1.a().GetAspect<djr>();
				if (aspect2 != null && !string.IsNullOrWhiteSpace(aspect2.b()))
				{
					dy9 aspect3 = A_1.a().GetAspect<dy9>();
					ay0 aspect4 = A_1.a().GetAspect<ay0>();
					bool flag = false;
					if (aspect3 != null && aspect3.a() == MapNodeState.Revealed)
					{
						flag = true;
					}
					else if (aspect4 != null && aspect4.a() == MapNodeState.Revealed)
					{
						flag = true;
					}
					if (flag)
					{
						e5f serviceOrThrow = bpo.GetServiceOrThrow<e5f>();
						if (serviceOrThrow.asj(A_1.a()))
						{
							aud aud = serviceOrThrow.ar9().n(aspect2.b());
							if (aud != null)
							{
								b0b b0b = aud.a(aspect2.d());
								if (b0b != null)
								{
									GlobalMap globalMap;
									Vector3 value;
									this.a(b0b, out globalMap, out value);
									this.b.b(globalMap);
									this.a(globalMap, new Vector3?(value));
									e4z.j();
									this.j = (b0b as c5x);
									this.i = 1250.0;
								}
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06002676 RID: 9846 RVA: 0x000DA9C4 File Offset: 0x000D8BC4
	private void a(object A_0, el5 A_1)
	{
		if (this.e != null)
		{
			this.e.bp();
			this.e = null;
		}
	}

	// Token: 0x06002677 RID: 9847 RVA: 0x000DA9E4 File Offset: 0x000D8BE4
	private void b(object A_0, b25 A_1)
	{
		a5r.k = d05.b(1f, a5r.k - 0.25f, 3f);
		this.a.an9().ub(a5r.k);
	}

	// Token: 0x06002678 RID: 9848 RVA: 0x000DAA1C File Offset: 0x000D8C1C
	private void a(object A_0, b25 A_1)
	{
		a5r.k = d05.b(1f, a5r.k + 0.25f, 3f);
		this.a.an9().ub(a5r.k);
	}

	// Token: 0x040015D1 RID: 5585
	private new d69 a;

	// Token: 0x040015D2 RID: 5586
	private new aw9 b;

	// Token: 0x040015D3 RID: 5587
	private new doz c;

	// Token: 0x040015D4 RID: 5588
	private new doz d;

	// Token: 0x040015D5 RID: 5589
	private new c6a e;

	// Token: 0x040015D6 RID: 5590
	private new doz f;

	// Token: 0x040015D7 RID: 5591
	private new doz g;

	// Token: 0x040015D8 RID: 5592
	private new dsy h;

	// Token: 0x040015D9 RID: 5593
	private new double i;

	// Token: 0x040015DA RID: 5594
	private new c5x j;

	// Token: 0x040015DB RID: 5595
	private new static float k = 1f;
}

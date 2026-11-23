using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using TimelapseVertigo.Common;
using TimelapseVertigo.Common.Settings;
using TimelapseVertigo.Rules.Combat;

// Token: 0x02000575 RID: 1397
public sealed class zj : a9t, amj
{
	// Token: 0x0600240C RID: 9228 RVA: 0x000C80D0 File Offset: 0x000C62D0
	public zj(bcx A_0, dbi A_1, ebk A_2, csy A_3, wv A_4)
	{
		czh.a(A_0, "vehicle");
		czh.a(A_1, "container");
		wj wj = wj.a();
		if (wj.c())
		{
			this.y = egg.ad;
		}
		else
		{
			this.y = wj.dm;
			this.z = wj.ir;
		}
		this.u = new d22(this.y, Color.LightGray);
		this.v = new d22(this.y, Color.White);
		this.w = new d22(this.y, Color.Orange);
		this.x = new d22(this.y, Color.Red);
		this.f = A_0;
		this.g = A_4;
		this.h = A_1;
		this.i = A_2;
		this.j = A_3;
		this.e();
		this.d();
		if (wj.c())
		{
			this.e = new dsy(this, this, esj.a(), 400, null, null, 3000, false, false);
			return;
		}
		this.e = new dsy(this, this, esj.a(), Math.Max(400, base.Size.c / 2), null, null, 3000, false, false);
	}

	// Token: 0x0600240D RID: 9229 RVA: 0x000C8244 File Offset: 0x000C6444
	public override void iv(e6d A_0, cp9 A_1)
	{
		this.e.a(A_0);
		base.iv(A_0, A_1);
		Point point = base.at();
		if (!wj.a().c() && this.ab != null && this.ac != null && this.ad == this.b)
		{
			foreach (zj.b b in this.ab)
			{
				if (b == this.ac)
				{
					int num = b.c;
					int num2 = base.Size.c - wj.a().ds - (b.a + num);
					if (num2 < 0)
					{
						num += num2;
					}
					Rectangle a_ = new Rectangle(point.X + b.a, point.Y + b.b, num, b.d);
					Texture2D resource = A_1.a.GetResource<Texture2D>("Locale\\Meta\\Blank", null);
					A_1.b().xa(resource, a_, adi.a * 0.25f);
				}
			}
		}
		int a_2 = 290;
		int a_3 = 80;
		if (!wj.a().c())
		{
			a_2 = this.m.Location.X;
			a_3 = this.m.Location.Y + this.m.Size.d + 3 * this.aa;
		}
		if (this.b == zj.a.a)
		{
			this.a(A_1, point, a_2, a_3, this.q, this.r, 115);
			return;
		}
		this.a(A_1, point, a_2, a_3, this.s, this.t, 115);
	}

	// Token: 0x0600240E RID: 9230 RVA: 0x000C8428 File Offset: 0x000C6628
	private void a(cp9 A_0, Point A_1, int A_2, int A_3, dn3 A_4, dn3 A_5, int A_6)
	{
		if (A_4 != null)
		{
			A_4.a(new Point(A_1.X + A_2, A_1.Y + A_3), A_0, null, 1f);
		}
		if (A_5 != null)
		{
			A_5.a(new Point(A_1.X + A_2 + this.a(A_6), A_1.Y + A_3), A_0, null, 1f);
		}
	}

	// Token: 0x0600240F RID: 9231 RVA: 0x000C8494 File Offset: 0x000C6694
	public override void ag5(e6d A_0)
	{
		if ((this.d += A_0.a().ElapsedGameTime.TotalMilliseconds) > 250.0)
		{
			this.d = 0.0;
			this.c();
		}
		this.c.a(null);
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (this.f != null && serviceOrThrow.aqu() != null && serviceOrThrow.aqu().v() != null && serviceOrThrow.aqu().v().Vehicle == this.f)
		{
			this.c.a(ItemExchangeParty.ActiveVehicleTrunk.ToString());
		}
		base.ag5(A_0);
	}

	// Token: 0x06002410 RID: 9232 RVA: 0x000C855C File Offset: 0x000C675C
	private int a(int A_0)
	{
		return Convert.ToInt32((float)A_0 * this.z.X);
	}

	// Token: 0x06002411 RID: 9233 RVA: 0x000C8574 File Offset: 0x000C6774
	public ecs yf(euz A_0)
	{
		wj wj = wj.a();
		MouseState state = Mouse.GetState();
		Point a_ = new Point(state.X, state.Y);
		Point a_2 = base.at();
		Point point = d05.a(a_, a_2, true);
		this.ab = new List<zj.b>();
		int num = 210;
		int num2 = 18;
		int num3 = 290;
		int num4 = 80;
		if (!wj.c())
		{
			num3 = this.m.Location.X;
			num4 = this.m.Location.Y + this.m.Size.d + 3 * this.aa;
			num2 = Convert.ToInt32(bpo.GetServiceOrThrow<cne>().GetResource<SpriteFont>(this.y, null).MeasureString(" ").Y);
			num = this.a(num);
			num3 -= num2 / 2;
			num += num2 / 2;
		}
		if (this.b == zj.a.a)
		{
			this.ab.Add(new zj.b(num3, num4, num, num2, "Прочность", qv.b("VehicleStatTooltips/Durability")));
			this.ab.Add(new zj.b(num3, num4 + num2, num, num2, "Энергия", qv.b("VehicleStatTooltips/Energy")));
			this.ab.Add(new zj.b(num3, num4 + num2 * 2, num, num2, "Мощность двигателя", qv.b("VehicleStatTooltips/EnginePower")));
			this.ab.Add(new zj.b(num3, num4 + num2 * 3, num, num2, "Потребление", qv.b("VehicleStatTooltips/EnergyPerTile")));
			this.ab.Add(new zj.b(num3, num4 + num2 * 4, num, num2, "Вес / Общий вес", qv.b("VehicleStatTooltips/Weight")));
			this.ab.Add(new zj.b(num3, num4 + num2 * 5, num, num2, "Базовая скорость", qv.b("VehicleStatTooltips/BaseSpeed")));
			this.ab.Add(new zj.b(num3, num4 + num2 * 6, num, num2, "Модификатор скорости", qv.b("VehicleStatTooltips/SpeedModifier")));
			this.ab.Add(new zj.b(num3, num4 + num2 * 7, num, num2, "Скорость / Модификатор уворота", (this.f.p() != null) ? qv.b("VehicleStatTooltips/MannedSpeed") : qv.b("VehicleStatTooltips/UnmannedSpeed")));
			this.ab.Add(new zj.b(num3, num4 + num2 * 8, num, num2, "Устойчивость / Манёвренность", qv.b("VehicleStatTooltips/Stability")));
			this.ab.Add(new zj.b(num3, num4 + num2 * 9, num, num2, "Бонус урона в ближнем бою", qv.b("VehicleStatTooltips/MeleeDamageBonus")));
		}
		else
		{
			this.ab.Add(new zj.b(num3, num4, num, num2, "Прикрытие", qv.b("VehicleStatTooltips/Cover")));
			this.ab.Add(new zj.b(num3, num4 + num2 * 2, num, num2, "Сопротивление механическому урону", qv.b("VehicleStatTooltips/ResistanceMechanical") + " " + qv.b("VehicleStatTooltips/ResistanceDescription")));
			this.ab.Add(new zj.b(num3, num4 + num2 * 3, num, num2, "Сопротивление тепловому урону", qv.b("VehicleStatTooltips/ResistanceHeat") + " " + qv.b("VehicleStatTooltips/ResistanceDescription")));
			this.ab.Add(new zj.b(num3, num4 + num2 * 4, num, num2, "Сопротивление урону холодом", qv.b("VehicleStatTooltips/ResistanceCold") + " " + qv.b("VehicleStatTooltips/ResistanceDescription")));
			this.ab.Add(new zj.b(num3, num4 + num2 * 5, num, num2, "Сопротивление урону электричеством", qv.b("VehicleStatTooltips/ResistanceElectricity") + " " + qv.b("VehicleStatTooltips/ResistanceDescription")));
			this.ab.Add(new zj.b(num3, num4 + num2 * 6, num, num2, "Сопротивление урону кислотой", qv.b("VehicleStatTooltips/ResistanceAcid") + " " + qv.b("VehicleStatTooltips/ResistanceDescription")));
			this.ab.Add(new zj.b(num3, num4 + num2 * 7, num, num2, "Сопротивление энергетическому урону", qv.b("VehicleStatTooltips/ResistanceEnergy") + " " + qv.b("VehicleStatTooltips/ResistanceDescription")));
			this.ab.Add(new zj.b(num3, num4 + num2 * 8, num, num2, "Сопротивление биологическому урону", qv.b("VehicleStatTooltips/ResistanceBio") + " " + qv.b("VehicleStatTooltips/ResistanceDescription")));
		}
		foreach (zj.b b in this.ab)
		{
			if (point.X >= b.a && point.Y >= b.b && point.X < b.a + b.c && point.Y < b.b + b.d)
			{
				this.ac = b;
				this.ad = this.b;
				return new ecs(new List<dl6>
				{
					new dl6(new List<bph>
					{
						new bph(new d22(cq4.c(), adi.c), b.e, null)
					}),
					new dl6(new List<bph>
					{
						new bph(new d22(cq4.c(), Color.White), null, null)
					}),
					new dl6(new List<bph>
					{
						new bph(new d22(cq4.c(), Color.LightGray), b.f, null)
					})
				});
			}
		}
		return null;
	}

	// Token: 0x06002412 RID: 9234 RVA: 0x000C8B7C File Offset: 0x000C6D7C
	private new void e()
	{
		wj wj = wj.a();
		esj esj = a2x.a();
		base.Text = ((this.f.an() != null) ? this.f.an().d() : "Неизвестный транспорт");
		this.aa = 10;
		esj esj2 = new esj(495, 460);
		if (wj.c())
		{
			base.Size = new esj(495, 460);
		}
		else
		{
			int @in = wj.@in;
			int io = wj.io;
			esj2 = new esj((int)Math.Min((double)@in, (double)esj.c * 0.5), (int)Math.Max((double)io, (double)esj.d * 0.6));
			this.aa = wj.iv;
			base.Size = esj2;
		}
		this.k = new ct5();
		if (wj.c())
		{
			this.k.Location = new Point(4, 28);
			this.k.Size = new esj(300, 235);
		}
		else
		{
			this.k.Location = new Point(this.aa / 2, wj.ci.d);
			this.k.d = new Rectangle?(new Rectangle(0, 0, wj.iq.c, wj.iq.d));
			this.k.Size = wj.ip;
		}
		if (this.f != null && this.f.an() != null && this.f.an().g() != null)
		{
			dlr dlr = this.f.an().g().fu() as dlr;
			if (dlr != null)
			{
				if (wj.c() || wj.d == UiSize.Small)
				{
					this.k.b = "GUI\\Images\\Vehicles\\" + dlr.h();
				}
				else
				{
					this.k.b = "GUI\\Images\\Vehicles\\" + dlr.h() + "_" + wj.e;
				}
			}
		}
		this.aox(this.k);
		this.c = new b3w(this.h, this.j, false, true, false, false, 0, false);
		if (wj.c())
		{
			this.c.Location = new Point(10, 260);
			this.c.b(12, 3);
		}
		else
		{
			this.c.Location = new Point(this.aa, this.k.Location.Y + Math.Max(275, this.k.Size.d));
			esj esj3 = this.c.a(esj2.c - 2 * this.aa, esj2.d - this.c.Location.Y - wj.c2.d - 2 * this.aa);
			this.c.b(esj3.c, esj3.d);
			base.Size = new esj(this.c.Size.c + 2 * this.aa, this.c.Location.Y + this.c.Size.d + 2 * this.aa + wj.c2.d);
		}
		this.c.d(new EventHandler<b25>(this.b));
		this.c.a(new EventHandler<b25>(this.a));
		this.c.Gravity = axy.c;
		this.aox(this.c);
		if (wj.c() && esj.d > 770)
		{
			int num = 460 + (esj.d - 770);
			num = d05.a(460, num, 800);
			int num2 = num - base.Size.d;
			base.Size = new esj(base.Size.c, num);
			esj esj4 = this.c.a(this.c.Size.c, this.c.Size.d + num2);
			this.c.b(esj4.c, esj4.d);
		}
		this.l = new ec9();
		if (wj.c())
		{
			this.l.c = bo1.v;
			this.l.Location = new Point(276, 38);
			this.l.Size = new esj(210, 36);
		}
		else
		{
			this.l.c = wj.f;
			this.l.e = wj.dc;
			this.l.d = new esj?(wj.dd);
			this.l.Location = new Point(this.k.Location.X + this.k.Size.c, this.k.Location.Y + this.aa);
			esj esj5 = new esj(3 * this.aa + 2 * wj.dv.c, 2 * this.aa + wj.dv.d);
			esj5.d = Math.Max(esj5.d, wj.dd.d * 2);
			wj.a(ref esj5.d);
			this.l.Size = esj5;
		}
		this.l.Gravity = axy.b;
		this.aox(this.l);
		this.m = zj.a("Базовые");
		if (wj.c())
		{
			this.m.Location = new Point(290, 45);
		}
		else
		{
			this.m.Location = new Point(this.k.Location.X + this.k.Size.c + this.aa, this.l.Location.Y + (this.l.Size.d - this.m.Size.d) / 2);
			if (wj.d == UiSize.Small)
			{
				this.m.Location = new Point(this.m.Location.X - 40, this.m.Location.Y);
				this.l.Location = new Point(this.l.Location.X - 40, this.l.Location.Y);
			}
		}
		this.m.Tag = baf.a;
		this.m.c(new EventHandler<b25>(this.c));
		this.m.Checked = true;
		this.m.Tag = zj.a.a;
		this.aox(this.m);
		this.n = zj.a("Защита");
		if (wj.c())
		{
			this.n.Location = new Point(this.m.Location.X + this.m.Size.c + 10, 45);
		}
		else
		{
			this.n.Location = new Point(this.m.Location.X + this.m.Size.c + this.aa, this.m.Location.Y);
		}
		this.n.Tag = baf.b;
		this.n.c(new EventHandler<b25>(this.c));
		this.n.Checked = false;
		this.n.Tag = zj.a.b;
		this.aox(this.n);
		Vector2 vector;
		if (wj.c())
		{
			vector = Vector2.One;
		}
		else
		{
			vector = wj.@is;
		}
		foreach (c38 c in this.f.an().e())
		{
			bjz bjz = new bjz(this.f, c, this.g != null || c.b());
			bjz.Location = new Point(this.k.Location.X + (int)((float)c.d().X * vector.X) - bjz.Size.c / 2, this.k.Location.Y + (int)((float)c.d().Y * vector.Y) - bjz.Size.d / 2);
			bjz.Location = new Point(bjz.Location.X, bjz.Location.Y);
			this.aox(bjz);
			agt agt;
			this.f.o().TryGetValue(c.h(), out agt);
			if (agt != null)
			{
				bjz.yb(agt, false);
			}
			bjz.b(new EventHandler(this.a));
			if (this.g == null && !c.b())
			{
				bjz.a(new Func<ebk, coh, bool>(zj.c.a.a));
				bjz.a(new Func<ebk, bool>(zj.c.a.a));
			}
		}
		this.p = new dak();
		this.p.Text = "Упорядочить";
		if (wj.c())
		{
			this.p.Font = egg.ap;
			this.p.TextLabelOffset = new Point(0, egg.b(this.p.Font));
			this.p.Size = new esj(175, 25);
			this.p.d = bo1.z;
		}
		else
		{
			this.p.Size = wj.c2;
			this.p.Font = wj.c5;
			this.p.TextLabelOffset = new Point(0, egg.b(this.p.Font));
			this.p.d = wj.f;
			this.p.f = wj.e7;
			this.p.e = new esj?(wj.e8);
		}
		this.p.h = Color.Black;
		this.p.i = Color.Black;
		this.p.g = adi.a;
		this.p.j = adi.b;
		this.p.Enabled = (this.i != null);
		this.p.Gravity = axy.b;
		this.p.c(new EventHandler<b25>(this.d));
		e4z.j(this.p);
		this.aox(this.p);
		this.o = new dak();
		this.o.Text = "Взять всё";
		if (wj.c())
		{
			this.o.Font = egg.ap;
			this.o.TextLabelOffset = new Point(0, egg.b(this.o.Font));
			this.o.Size = new esj(175, 25);
			this.o.d = bo1.z;
		}
		else
		{
			this.o.Size = wj.c2;
			this.o.Font = wj.c5;
			this.o.TextLabelOffset = new Point(0, egg.b(this.o.Font));
			this.o.d = wj.f;
			this.o.f = wj.e7;
			this.o.e = new esj?(wj.e8);
		}
		this.o.h = Color.Black;
		this.o.i = Color.Black;
		this.o.g = adi.a;
		this.o.j = adi.b;
		this.o.Enabled = (this.i != null);
		this.o.Gravity = axy.b;
		this.o.c(new EventHandler<b25>(this.e));
		e4z.j(this.o);
		this.aox(this.o);
		this.p.Location = new Point((base.Size.c - (this.p.Size.c + this.o.Size.c + 20)) / 2, this.c.Location.Y + this.c.Size.d + 10);
		this.o.Location = new Point(this.p.Location.X + this.p.Size.c + 20, this.p.Location.Y);
		if (wj.c())
		{
			int num3 = this.o.Location.Y + this.o.Size.d + 10;
			if (num3 % 2 != 0)
			{
				num3++;
			}
			base.Size = new esj(base.Size.c, num3);
		}
		else
		{
			int a_ = this.o.Location.Y + this.o.Size.d + this.aa;
			wj.a(ref a_);
			base.Size = new esj(base.Size.c, a_);
		}
		this.b();
	}

	// Token: 0x06002413 RID: 9235 RVA: 0x000C9A34 File Offset: 0x000C7C34
	private static zt a(string A_0)
	{
		wj wj = wj.a();
		zt zt = new zt();
		zt.Text = A_0;
		if (wj.c())
		{
			zt.Font = egg.ap;
			zt.TextLabelOffset = new Point(0, 3);
			zt.Size = new esj(88, 22);
		}
		else
		{
			zt.Font = wj.dn;
			zt.TextLabelOffset = new Point(0, egg.b(zt.Font));
			zt.Size = wj.dv;
			zt.d = wj.f;
			zt.e = wj.fg;
			zt.f = new esj?(wj.fh);
		}
		zt.b = Color.Black;
		zt.a = adi.a;
		zt.HorizontalAlignment = cab.b;
		return zt;
	}

	// Token: 0x06002414 RID: 9236 RVA: 0x000C9B04 File Offset: 0x000C7D04
	private new void d()
	{
		this.f.k();
		this.c();
	}

	// Token: 0x06002415 RID: 9237 RVA: 0x000C9B18 File Offset: 0x000C7D18
	private void c()
	{
		ecs ecs = new ecs();
		ecs.a.AddRange(new List<dl6>
		{
			new dl6(new List<bph>
			{
				new bph(this.u, "Прочность:", null)
			}),
			new dl6(new List<bph>
			{
				new bph(this.u, "Энергия:", null)
			}),
			new dl6(new List<bph>
			{
				new bph(this.u, "Мощн. двигателя:", null)
			}),
			new dl6(new List<bph>
			{
				new bph(this.u, "Потребление:", null)
			}),
			new dl6(new List<bph>
			{
				new bph(this.u, "Вес:", null)
			}),
			new dl6(new List<bph>
			{
				new bph(this.u, "Базовая скорость:", null)
			}),
			new dl6(new List<bph>
			{
				new bph(this.u, "Модиф. скорости:", null)
			}),
			new dl6(new List<bph>
			{
				new bph(this.u, string.Format("{0}Скорость:", (this.f.p() == null) ? "Авто " : ""), null)
			}),
			new dl6(new List<bph>
			{
				new bph(this.u, "Уст. / Манёвр.:", null)
			}),
			new dl6(new List<bph>
			{
				new bph(this.u, "+Ближний урон:", null)
			})
		});
		ecs ecs2 = new ecs();
		d22 a_;
		if (this.f.ag() < (double)this.f.v() * 0.15)
		{
			a_ = this.x;
		}
		else if (this.f.ag() < (double)this.f.v() * 0.5)
		{
			a_ = this.w;
		}
		else
		{
			a_ = this.v;
		}
		d22 a_2;
		if (this.f.g() == 0.0)
		{
			a_2 = this.x;
		}
		else if (this.f.g() < (double)this.f.am() * 0.25)
		{
			a_2 = this.w;
		}
		else
		{
			a_2 = this.v;
		}
		ecs2.a.AddRange(new List<dl6>
		{
			new dl6(new List<bph>
			{
				new bph(a_, string.Format("{0} / {1}", (int)Math.Ceiling(this.f.ag()), this.f.v()), null)
			}),
			new dl6(new List<bph>
			{
				new bph(a_2, string.Format("{0} / {1}", (int)Math.Ceiling(this.f.g()), this.f.am()), null)
			}),
			new dl6(new List<bph>
			{
				new bph(this.v, this.f.i().ToString(), null)
			}),
			new dl6(new List<bph>
			{
				new bph(this.v, this.a(this.f.h()).ToString(), null)
			}),
			new dl6(new List<bph>
			{
				new bph(this.v, string.Format("{0} | {1}", Convert.ToInt32(this.f.ac()).ToString(), Convert.ToInt32(this.f.w()).ToString()), null)
			}),
			new dl6(new List<bph>
			{
				new bph(this.v, this.b(c3w.c[this.f.y()]), null)
			}),
			new dl6(new List<bph>
			{
				new bph(this.v, Convert.ToInt32(this.f.n() * 100.0).ToString() + "%", null)
			}),
			new dl6(new List<bph>
			{
				new bph((this.f.g() == 0.0) ? this.x : this.v, this.b(this.f.m()) + " | " + Convert.ToInt32(this.f.u() * 100.0).ToString() + "%", null)
			}),
			new dl6(new List<bph>
			{
				new bph(this.v, string.Format("{0}% | {1}%", Convert.ToInt32(this.f.aa() * 100.0), Convert.ToInt32(this.f.ao() * 100.0)), null)
			}),
			new dl6(new List<bph>
			{
				new bph(this.v, string.Format("{0}%", Convert.ToInt32(this.f.q() * 100.0)), null)
			})
		});
		this.q = ecs.b();
		this.r = ecs2.b();
	}

	// Token: 0x06002416 RID: 9238 RVA: 0x000CA10C File Offset: 0x000C830C
	private void b()
	{
		ecs ecs = new ecs(new List<dl6>
		{
			new dl6(new List<bph>
			{
				new bph(this.u, "Прикрытие:", null)
			}),
			new dl6(new List<bph>
			{
				new bph(this.u, " ", null)
			})
		});
		ecs ecs2 = new ecs(new List<dl6>
		{
			new dl6(new List<bph>
			{
				new bph(this.v, ((int)(this.f.ad() * 100.0)).ToString() + "%", null)
			}),
			new dl6(new List<bph>
			{
				new bph(this.v, " ", null)
			})
		});
		foreach (object obj in Enum.GetValues(typeof(DamageType)))
		{
			DamageType key = (DamageType)obj;
			ecs.a.Add(new dl6(new List<bph>
			{
				new bph(this.u, key.ToString(), null)
			}));
			ecs2.a.Add(new dl6(new List<bph>
			{
				new bph(this.v, string.Format("{0}", this.f.j()[key].ToString()), null)
			}));
		}
		this.s = ecs.b();
		this.t = ecs2.b();
	}

	// Token: 0x06002417 RID: 9239 RVA: 0x000CA2EC File Offset: 0x000C84EC
	private void a(cqy A_0)
	{
		if (A_0.yx() != null && (this.c.s() == null || this.c.s().kj(this.c.x(), A_0.yx(), this.c.m())) && c69.a(A_0, this.i, A_0.x6(), true))
		{
			e4z.c();
		}
	}

	// Token: 0x06002418 RID: 9240 RVA: 0x000CA364 File Offset: 0x000C8564
	private string b(double A_0)
	{
		return Convert.ToInt32(A_0 * 100.0).ToString();
	}

	// Token: 0x06002419 RID: 9241 RVA: 0x000CA38C File Offset: 0x000C858C
	private object a(double A_0)
	{
		return A_0 / c3w.h * 1000.0;
	}

	// Token: 0x0600241A RID: 9242 RVA: 0x000CA3A8 File Offset: 0x000C85A8
	private void a()
	{
		object a_ = this.c.m();
		foreach (coh coh in Enumerable.ToList<coh>(this.c.x().z2()))
		{
			if (this.c.x() == null)
			{
				break;
			}
			if (this.c.s() != null && !this.c.s().kj(this.c.x(), coh, a_))
			{
				break;
			}
			this.c.x().z5(coh);
			c69.a(this.c, this.i, coh, true);
			if (this.c.s() != null)
			{
				this.c.s().kl(this.c.x(), coh, a_);
			}
		}
	}

	// Token: 0x0600241B RID: 9243 RVA: 0x000CA4B8 File Offset: 0x000C86B8
	public new void g()
	{
		this.a();
	}

	// Token: 0x0600241C RID: 9244 RVA: 0x000CA4C0 File Offset: 0x000C86C0
	public new void f()
	{
		this.c.v();
	}

	// Token: 0x0600241D RID: 9245 RVA: 0x000CA4D0 File Offset: 0x000C86D0
	protected override void i0()
	{
		base.i0();
	}

	// Token: 0x0600241E RID: 9246 RVA: 0x000CA4D8 File Offset: 0x000C86D8
	protected override void i1()
	{
		base.i1();
	}

	// Token: 0x0600241F RID: 9247 RVA: 0x000CA4E0 File Offset: 0x000C86E0
	private new void e(object A_0, b25 A_1)
	{
		this.g();
	}

	// Token: 0x06002420 RID: 9248 RVA: 0x000CA4E8 File Offset: 0x000C86E8
	private new void d(object A_0, b25 A_1)
	{
		this.f();
	}

	// Token: 0x06002421 RID: 9249 RVA: 0x000CA4F4 File Offset: 0x000C86F4
	private void c(object A_0, b25 A_1)
	{
		zt zt = A_0 as zt;
		if (zt != null && zt.Tag is zj.a)
		{
			this.b = (zj.a)zt.Tag;
			foreach (zt zt2 in Enumerable.OfType<zt>(base.Controls))
			{
				zt2.Checked = (zt2 == zt);
			}
		}
	}

	// Token: 0x06002422 RID: 9250 RVA: 0x000CA580 File Offset: 0x000C8780
	protected override void ik(object A_0, b25 A_1)
	{
		base.ik(A_0, A_1);
		this.e.b();
	}

	// Token: 0x06002423 RID: 9251 RVA: 0x000CA598 File Offset: 0x000C8798
	protected override void nr(object A_0, b25 A_1)
	{
		base.nr(A_0, A_1);
		this.e.b();
	}

	// Token: 0x06002424 RID: 9252 RVA: 0x000CA5B0 File Offset: 0x000C87B0
	protected override void ns(object A_0, b25 A_1)
	{
		base.ns(A_0, A_1);
		this.e.b();
	}

	// Token: 0x06002425 RID: 9253 RVA: 0x000CA5C8 File Offset: 0x000C87C8
	private void b(object A_0, b25 A_1)
	{
		if (A_1.b() == eoo.d && this.i != null)
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
			if ((state.IsKeyDown(Keys.LeftAlt) || state.IsKeyDown(Keys.RightAlt)) && this.i != null)
			{
				cqy cqy2 = A_0 as cqy;
				if (cqy2 != null)
				{
					this.a(cqy2);
				}
			}
		}
	}

	// Token: 0x06002426 RID: 9254 RVA: 0x000CA654 File Offset: 0x000C8854
	private void a(object A_0, b25 A_1)
	{
		if (A_1.b() == eoo.b && this.i != null)
		{
			cqy cqy = A_0 as cqy;
			if (cqy != null)
			{
				this.a(cqy);
			}
		}
	}

	// Token: 0x06002427 RID: 9255 RVA: 0x000CA68C File Offset: 0x000C888C
	private void a(object A_0, EventArgs A_1)
	{
		if (this.g != null)
		{
			cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
			if (serviceOrThrow.aqu() != null && serviceOrThrow.aqu().v() != null)
			{
				c5x c5x = serviceOrThrow.aqu().v().b() as c5x;
				if (c5x != null && c5x.h.b != null)
				{
					this.g.b(c5x.h.b);
				}
			}
		}
	}

	// Token: 0x040014DC RID: 5340
	private new const int a = 250;

	// Token: 0x040014DD RID: 5341
	private new zj.a b;

	// Token: 0x040014DE RID: 5342
	public new b3w c;

	// Token: 0x040014DF RID: 5343
	private new double d;

	// Token: 0x040014E0 RID: 5344
	private new dsy e;

	// Token: 0x040014E1 RID: 5345
	private new bcx f;

	// Token: 0x040014E2 RID: 5346
	private new wv g;

	// Token: 0x040014E3 RID: 5347
	private new dbi h;

	// Token: 0x040014E4 RID: 5348
	private new ebk i;

	// Token: 0x040014E5 RID: 5349
	private new csy j;

	// Token: 0x040014E6 RID: 5350
	private new ct5 k;

	// Token: 0x040014E7 RID: 5351
	private new ec9 l;

	// Token: 0x040014E8 RID: 5352
	private new zt m;

	// Token: 0x040014E9 RID: 5353
	private zt n;

	// Token: 0x040014EA RID: 5354
	private dak o;

	// Token: 0x040014EB RID: 5355
	private dak p;

	// Token: 0x040014EC RID: 5356
	private dn3 q;

	// Token: 0x040014ED RID: 5357
	private dn3 r;

	// Token: 0x040014EE RID: 5358
	private dn3 s;

	// Token: 0x040014EF RID: 5359
	private dn3 t;

	// Token: 0x040014F0 RID: 5360
	private d22 u;

	// Token: 0x040014F1 RID: 5361
	private d22 v;

	// Token: 0x040014F2 RID: 5362
	private d22 w;

	// Token: 0x040014F3 RID: 5363
	private new d22 x;

	// Token: 0x040014F4 RID: 5364
	private string y;

	// Token: 0x040014F5 RID: 5365
	private new Vector2 z = Vector2.One;

	// Token: 0x040014F6 RID: 5366
	private int aa;

	// Token: 0x040014F7 RID: 5367
	private List<zj.b> ab;

	// Token: 0x040014F8 RID: 5368
	private zj.b ac;

	// Token: 0x040014F9 RID: 5369
	private zj.a ad;

	// Token: 0x0200202A RID: 8234
	private new enum a
	{
		// Token: 0x040046B1 RID: 18097
		a,
		// Token: 0x040046B2 RID: 18098
		b
	}

	// Token: 0x0200202B RID: 8235
	private new sealed class b
	{
		// Token: 0x0600C2F6 RID: 49910 RVA: 0x00437BBC File Offset: 0x00435DBC
		public b(int A_0, int A_1, int A_2, int A_3, string A_4, string A_5)
		{
			this.a = A_0;
			this.b = A_1;
			this.c = A_2;
			this.d = A_3;
			this.e = A_4;
			this.f = A_5;
		}

		// Token: 0x040046B3 RID: 18099
		public int a;

		// Token: 0x040046B4 RID: 18100
		public int b;

		// Token: 0x040046B5 RID: 18101
		public int c;

		// Token: 0x040046B6 RID: 18102
		public int d;

		// Token: 0x040046B7 RID: 18103
		public string e;

		// Token: 0x040046B8 RID: 18104
		public string f;
	}

	// Token: 0x0200202C RID: 8236
	[CompilerGenerated]
	[Serializable]
	private new sealed class c
	{
		// Token: 0x0600C2F9 RID: 49913 RVA: 0x00437C08 File Offset: 0x00435E08
		internal bool a(ebk A_0, coh A_1)
		{
			return false;
		}

		// Token: 0x0600C2FA RID: 49914 RVA: 0x00437C0C File Offset: 0x00435E0C
		internal bool a(ebk A_0)
		{
			return false;
		}

		// Token: 0x040046B9 RID: 18105
		public static readonly zj.c a = new zj.c();

		// Token: 0x040046BA RID: 18106
		public static Func<ebk, coh, bool> b;

		// Token: 0x040046BB RID: 18107
		public static Func<ebk, bool> c;
	}
}

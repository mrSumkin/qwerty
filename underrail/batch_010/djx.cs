using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Ouroboros.Common.Data;
using TimelapseVertigo.Common.Settings;

// Token: 0x0200205F RID: 8287
public sealed class djx : euz, amj
{
	// Token: 0x0600C4FD RID: 50429 RVA: 0x00448EA4 File Offset: 0x004470A4
	public override bool iz(MouseState A_0)
	{
		if (this.u.iz(A_0))
		{
			return true;
		}
		if (this.t == 1.0)
		{
			Point point = base.at();
			if (A_0.X >= point.X + 4 && A_0.X < point.X + 4 + this.ai.c && A_0.Y >= point.Y + this.b.Height + (this.a.d - this.ai.d) && A_0.Y < point.Y + this.b.Height + this.a.d)
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x0600C4FE RID: 50430 RVA: 0x00448F78 File Offset: 0x00447178
	public djx(TypedObjectReference<efk> A_0)
	{
		this.x = A_0;
		this.b();
	}

	// Token: 0x0600C4FF RID: 50431 RVA: 0x0044905C File Offset: 0x0044725C
	public void c()
	{
		if (this.s.GetValueOrDefault() != djx.a.b && this.r.GetValueOrDefault() != djx.a.b && this.q != djx.a.b)
		{
			e4z.h();
		}
		this.s = new djx.a?(djx.a.b);
	}

	// Token: 0x0600C500 RID: 50432 RVA: 0x004490A8 File Offset: 0x004472A8
	public void d()
	{
		djx.a? a = this.s;
		djx.a a2 = djx.a.a;
		if (!(a.GetValueOrDefault() == a2 & a != null))
		{
			a = this.r;
			a2 = djx.a.a;
			if (!(a.GetValueOrDefault() == a2 & a != null) && this.q != djx.a.a)
			{
				e4z.g();
			}
		}
		this.s = new djx.a?(djx.a.a);
	}

	// Token: 0x0600C501 RID: 50433 RVA: 0x00449114 File Offset: 0x00447314
	public override void iv(e6d A_0, cp9 A_1)
	{
		Texture2D resource = A_1.a.GetResource<Texture2D>(this.ak, null);
		d02 service = bpo.GetService<d02>();
		wj wj = wj.a();
		if (resource != null)
		{
			Vector2 vector = base.at().b();
			Vector2 vector2 = new Vector2(vector.X, (float)((double)(vector.Y + (float)(this.a.d - this.ai.d)) + (double)(2 + this.ai.d) * (1.0 - this.t)) + 2f);
			if (this.t > 0.0)
			{
				Vector2 vector3 = new Vector2(vector.X + (float)((this.b.Width - this.ai.c) / 2), vector2.Y + (float)this.b.Height - 1f);
				int height = (int)(this.t * (double)this.ai.d);
				A_1.b().w5(resource, vector3, new Rectangle?(new Rectangle(this.g, this.h, this.ai.c, height)), Color.White);
				if (wj.d == UiSize.Classic)
				{
					A_1.b().w5(resource, vector3, new Rectangle?(new Rectangle(this.g + this.i, this.h, this.ai.c, height)), Color.White * 0.65f);
				}
				else
				{
					A_1.b().w5(resource, vector3, new Rectangle?(new Rectangle(this.g + this.i, this.h, this.ai.c, height)), Color.LightGray);
				}
				if (this.t == 1.0 && this.x != null && this.x.ao() != null && service != null && service.ahg())
				{
					d4n d4n = service.ahu(this.x.ao());
					int num = -1;
					int num2 = -1;
					if (d4n != null && d4n == service.ahe())
					{
						int num3 = this.ai.d;
						if (this.y > 0.0)
						{
							int num4 = d4n.g() ? 2 : 4;
							int num5 = (int)(this.y * this.j);
							num3 -= num5;
							if (num3 < 0)
							{
								num5 += num3;
								num3 = 0;
							}
							A_1.b().w5(resource, new Vector2(vector3.X, vector3.Y + (float)num3), new Rectangle?(new Rectangle(this.g + this.i * num4, this.h + this.a.d - (this.ai.d - num3), this.ai.c, num5)), Color.LightGray);
							num2 = num3;
						}
						if (num3 > 0 && this.z > 0.0)
						{
							int num4 = 3;
							int num5 = (int)(this.z * this.j);
							num3 -= num5;
							num = num3;
							if (num3 < 0)
							{
								num5 += num3;
								num3 = 0;
							}
							A_1.b().w5(resource, new Vector2(vector3.X, vector3.Y + (float)num3), new Rectangle?(new Rectangle(this.g + this.i * num4, this.h + this.a.d - (this.ai.d - num3), this.ai.c, num5)), Color.LightGray);
						}
					}
					else
					{
						int num6 = (int)(A_0.a().TotalGameTime.TotalMilliseconds / 50.0) % this.k;
						A_1.b().w5(resource, vector3, new Rectangle?(new Rectangle(this.g + this.i * 4, this.h + num6, this.ai.c, this.ai.d)), Color.White * 0.5f);
					}
					if (service.ahi() == bh3.b)
					{
						ps service2 = bpo.GetService<ps>();
						if (service2 != null && service2.alh() != null)
						{
							ax4 ax = service2.alh().abk();
							if (ax != null)
							{
								int num7 = ax.c;
								int num8 = ax.b;
								Color red;
								if ((double)num8 > d4n.c || (double)num7 > d4n.c + d4n.d - (double)num8)
								{
									red = Color.Red;
								}
								else
								{
									red = adi.c;
								}
								Rectangle empty = Rectangle.Empty;
								Vector2 zero = Vector2.Zero;
								if (num7 > 0)
								{
									if ((double)num7 > d4n.d)
									{
										num8 += num7 - (int)d4n.d;
										num7 = (int)d4n.d;
									}
									empty = new Rectangle(this.g + this.i * 5, 0, this.ai.c, Math.Min(this.ai.d, (int)((double)num7 * this.j)));
									zero = new Vector2(vector3.X, vector3.Y + (float)num);
								}
								Rectangle empty2 = Rectangle.Empty;
								Vector2 zero2 = Vector2.Zero;
								if (num8 > 0)
								{
									empty2 = new Rectangle(this.g + this.i * 5, this.h, this.ai.c, Math.Min(this.ai.d, (int)((double)num8 * this.j)));
									zero2 = new Vector2(vector3.X, vector3.Y + (float)num2);
									if (zero2.Y + (float)empty2.Height > vector3.Y + (float)this.ai.d)
									{
										zero2.Y = vector3.Y + (float)this.ai.d - (float)empty2.Height;
									}
								}
								if (zero != Vector2.Zero)
								{
									if (zero2 != Vector2.Zero)
									{
										if (zero.Y + (float)empty.Height > zero2.Y)
										{
											zero.Y = zero2.Y - (float)empty.Height;
										}
									}
									else if (zero.Y + (float)empty.Height > vector3.Y + (float)this.ai.d)
									{
										zero.Y = vector3.Y + (float)this.ai.d - (float)empty.Height;
									}
									if (zero.Y + (float)empty.Height >= vector3.Y)
									{
										if (zero.Y < vector3.Y)
										{
											empty.Height -= (int)(vector3.Y - zero.Y);
											zero.Y = vector3.Y;
										}
										A_1.b().w5(resource, zero, new Rectangle?(empty), red * (float)this.aa);
									}
								}
								if (zero2 != Vector2.Zero)
								{
									if (zero2.Y < vector3.Y)
									{
										empty2.Height -= (int)(vector3.Y - zero2.Y);
										zero2.Y = vector3.Y;
									}
									A_1.b().w5(resource, zero2, new Rectangle?(empty2), red * (float)this.aa);
								}
								if (this.ad != null)
								{
									this.ad.a(A_1.a, A_1, A_0);
								}
							}
						}
					}
				}
			}
			A_1.b().w5(resource, vector + this.u.Location.b(), new Rectangle?(this.c), Color.White);
			A_1.b().w5(resource, vector2, new Rectangle?(this.b), Color.White);
		}
		base.iv(A_0, A_1);
		if (resource != null && this.t == 0.0 && service != null && !service.ahg() && service.ahj() > 0.0)
		{
			double num9 = service.ahj() / (double)d0u.e;
			Tuple<int, int> tuple = wj.ax;
			if (tuple == null)
			{
				tuple = new Tuple<int, int>(0, 0);
			}
			Rectangle rectangle = this.d;
			rectangle.Height -= tuple.Item1 + tuple.Item2;
			int num10 = Math.Max((int)((1.0 - num9) * (double)rectangle.Height), 1);
			Point point = this.u.at();
			point.Y += tuple.Item1;
			A_1.b().w5(resource, new Vector2((float)point.X, (float)(point.Y + num10)), new Rectangle?(new Rectangle(rectangle.X, rectangle.Y + num10, rectangle.Width, rectangle.Height - num10)), Color.White * 0.5f);
		}
		this.ae.a(A_0);
		this.af.a(A_0);
		this.ag.a(A_0);
		this.ah.a(A_0);
	}

	// Token: 0x0600C502 RID: 50434 RVA: 0x00449AA4 File Offset: 0x00447CA4
	public override void ag5(e6d A_0)
	{
		this.a();
		base.ag5(A_0);
		if (this.aj)
		{
			this.af.b();
			this.ag.b();
			this.ah.b();
		}
		wj wj = wj.a();
		if (wj.d != UiSize.Classic)
		{
			Point point = base.at();
			int num = this.a.d - this.ai.d;
			this.ae.a(new Rectangle?(new Rectangle(point.X, point.Y + num, base.Size.c, base.Size.d - num)));
			this.ae.b();
		}
		d4n d4n = null;
		d02 service = bpo.GetService<d02>();
		if (service.ahg() && this.x.ao() != null)
		{
			d4n = service.ahu(this.x.ao());
			if (d4n != null && d4n == service.ahe())
			{
				int num2 = d4n.b.aa().Offense.n() + (int)d4n.e + Math.Max(d4n.b.aa().Offense.m(), (int)d4n.d);
				this.ai = new esj(this.ai.c, (int)((double)num2 * this.j));
				if (!wj.c())
				{
					if (this.ai.d > wj.am.d)
					{
						this.ai.d = wj.am.d;
					}
				}
				else if (this.ai.d > 1024)
				{
					this.ai.d = 1024;
				}
			}
		}
		double num3 = A_0.a().ElapsedGameTime.TotalMilliseconds * 0.0010000000474974513;
		if (this.ab)
		{
			if ((this.aa += num3) >= 0.6)
			{
				this.aa = 0.6;
				this.ab = false;
			}
		}
		else if ((this.aa -= num3) < 0.15000000596046448)
		{
			this.aa = 0.15000000596046448;
			this.ab = true;
		}
		bool flag = false;
		bool flag2 = false;
		bool flag3 = false;
		if (this.r != null)
		{
			if (this.r.Value != this.q)
			{
				this.q = djx.a.c;
				this.a(this.r.Value, A_0);
			}
			else
			{
				this.r = null;
			}
		}
		else if (this.s != null)
		{
			this.r = this.s;
			this.s = null;
		}
		ax4 ax = null;
		if (this.t == 1.0)
		{
			if (d4n != null && d4n == service.ahe())
			{
				ps service2 = bpo.GetService<ps>();
				if (service2 != null && service2.alh() != null)
				{
					ax = service2.alh().abk();
				}
				if (d4n.c != this.y)
				{
					int num4 = Math.Sign(d4n.c - this.y);
					this.y += (double)num4 * A_0.a().ElapsedGameTime.TotalMilliseconds * 0.1;
					if ((num4 == -1 && this.y < d4n.c) || (num4 == 1 && this.y > d4n.c))
					{
						this.y = d4n.c;
					}
				}
				if (d4n.d != this.z)
				{
					int num4 = Math.Sign(d4n.d - this.z);
					this.z += (double)num4 * A_0.a().ElapsedGameTime.TotalMilliseconds * 0.1;
					if ((num4 == -1 && this.z < d4n.d) || (num4 == 1 && this.z > d4n.d))
					{
						this.z = d4n.d;
					}
				}
			}
			flag2 = true;
			flag3 = true;
		}
		else if (this.t == 0.0)
		{
			flag = true;
		}
		this.aj = false;
		if (this.u.Visible != flag)
		{
			this.u.Visible = flag;
			this.aj = true;
		}
		if (this.v.Visible != flag3)
		{
			this.v.Visible = flag3;
			this.aj = true;
		}
		if (this.w.Visible != flag2)
		{
			this.w.Visible = flag2;
			this.aj = true;
		}
		if (this.ac != ax)
		{
			this.ac = ax;
			this.ad = this.a(d4n, this.ac);
		}
		if (bpo.GetServiceOrThrow<cnk>().aq1().c().c() && service != null && service.ahg() && d4n != null && d4n == service.ahe() && d4n.c == 0.0 && d4n.d == 0.0 && service.ahi() == bh3.b && !service.ahs(true, true))
		{
			service.ahq(d4n, true, true, true, null, true);
		}
	}

	// Token: 0x0600C503 RID: 50435 RVA: 0x0044A06C File Offset: 0x0044826C
	public ecs yf(euz A_0)
	{
		ecs ecs = null;
		if (A_0 == this.v)
		{
			ecs = cq4.a("Конец хода", d1o.b(Hotkey.EndTurn).ToUpperInvariant(), "Завершает ваш текущий ход и передаёт ход другим персонажам.");
		}
		else if (A_0 == this.w)
		{
			ecs = cq4.a("Конец боя", d1o.b(Hotkey.EndCombat).ToUpperInvariant(), "Пытается завершить бой. Работает только если поблизости нет врагов.");
		}
		else if (A_0 == this.u)
		{
			ecs = cq4.a("Начать бой", d1o.b(Hotkey.EndCombat).ToUpperInvariant(), "Войти в пошаговый режим боя.");
		}
		else if (this.t == 1.0 && this.x != null && this.x.ao() != null)
		{
			d02 service = bpo.GetService<d02>();
			if (service != null && service.ahg())
			{
				d4n d4n = service.ahu(this.x.ao());
				if (d4n != null && d4n == service.ahe())
				{
					ecs = new ecs();
					ecs.a.Add(new dl6(new List<bph>
					{
						new bph(new d22(cq4.c(), adi.an), string.Format("Очки передвижения: {0}", (int)d4n.d), null)
					}));
					ecs.a.Add(new dl6(new List<bph>
					{
						new bph(new d22(cq4.c(), Color.LightGray), qv.b("Concepts/MovementPoints"), null)
					}));
					ecs.a.Add(new dl6(new List<bph>
					{
						new bph(new d22(cq4.c(), Color.Transparent), " ", null)
					}));
					ecs.a.Add(new dl6(new List<bph>
					{
						new bph(new d22(cq4.c(), adi.am), string.Format("Очки действия: {0}", (int)d4n.c), null)
					}));
					ecs.a.Add(new dl6(new List<bph>
					{
						new bph(new d22(cq4.c(), Color.LightGray), qv.a("Concepts/ActionPoints", new object[]
						{
							aiy.q
						}), null)
					}));
					ecs.a.Add(new dl6(new List<bph>
					{
						new bph(new d22(cq4.c(), Color.Transparent), " ", null)
					}));
				}
			}
		}
		return ecs;
	}

	// Token: 0x0600C504 RID: 50436 RVA: 0x0044A2F4 File Offset: 0x004484F4
	private b5j a(d4n A_0, ax4 A_1)
	{
		if (A_0 == null || A_1 == null)
		{
			return null;
		}
		bool flag = false;
		bool flag2 = false;
		double num = Math.Max(0.0, A_0.d - (double)A_1.c);
		double num2 = A_0.c - (double)A_1.b;
		if (num2 < 0.0)
		{
			flag = true;
			num2 = 0.0;
		}
		num2 -= Math.Max(0.0, (double)A_1.c - A_0.d);
		if (num2 < 0.0)
		{
			flag2 = true;
			num2 = 0.0;
		}
		ecs ecs = new ecs();
		ecs.a.Add(new dl6(new List<bph>
		{
			new bph(new d22(cq4.c(), adi.an), string.Format("  {0,2} ОП", (int)A_0.d), null),
			new bph(new d22(cq4.c(), adi.am), string.Format("  {0,2} ОД", (int)A_0.c), null)
		}));
		ecs.a.Add(new dl6(new List<bph>
		{
			new bph(new d22(cq4.c(), flag2 ? adi.aq : adi.an), string.Format("- {0,2} ОП", A_1.c), null),
			new bph(new d22(cq4.c(), flag ? adi.aq : adi.am), string.Format("  {0,2} ОД", A_1.b), null)
		}));
		ecs.a.Add(new dl6(new List<bph>
		{
			new bph(new d22(cq4.c(), flag2 ? adi.aq : adi.an), string.Format("= {0,2} ОП", (int)num), null),
			new bph(new d22(cq4.c(), (flag || flag2) ? adi.aq : adi.am), string.Format("  {0,2} ОД", (int)num2), null)
		}));
		Point point = base.at();
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		b5j b5j;
		if (serviceOrThrow.aq1().b().g() == InterfaceElementSize2.Huge)
		{
			b5j = new b5j(ecs, Rectangle.Empty, new esj(250, 80), 250, new Point?(new Point(point.X - 280, point.Y + this.b.Height + this.a.d - 105)), false, false);
		}
		else if (serviceOrThrow.aq1().b().g() == InterfaceElementSize2.ExtraLarge)
		{
			b5j = new b5j(ecs, Rectangle.Empty, new esj(200, 60), 150, new Point?(new Point(point.X - 230, point.Y + this.b.Height + this.a.d - 105)), false, false);
		}
		else if (serviceOrThrow.aq1().b().g() == InterfaceElementSize2.Large)
		{
			b5j = new b5j(ecs, Rectangle.Empty, new esj(150, 60), 150, new Point?(new Point(point.X - 180, point.Y + this.b.Height + this.a.d - 105)), false, false);
		}
		else
		{
			b5j = new b5j(ecs, Rectangle.Empty, new esj(100, 40), 100, new Point?(new Point(point.X - 120, point.Y + this.b.Height + this.a.d - 70)), false, false);
		}
		b5j.j = false;
		b5j.k *= 0.75f;
		return b5j;
	}

	// Token: 0x0600C505 RID: 50437 RVA: 0x0044A71C File Offset: 0x0044891C
	private void b()
	{
		wj wj = wj.a();
		if (wj.d != UiSize.Classic)
		{
			this.ak = wj.f;
			this.a = wj.am;
			this.b = wj.an;
			this.c = wj.ao;
			this.d = wj.ap;
			this.e = wj.aq;
			this.f = wj.ar;
			this.g = wj.@as;
			this.h = wj.at;
			this.i = wj.au;
			this.j = (double)wj.av;
			this.k = wj.aw;
		}
		this.ai = new esj(this.a.c, (int)((double)(aiy.g + aiy.h) * this.j));
		base.Size = new esj(this.b.Width, this.b.Height + this.a.d + this.c.Height);
		this.u = new doz();
		this.u.a(this.ak);
		this.u.a(new Point(this.c.X, this.c.Y + this.c.Height));
		this.u.Location = new Point(0, this.b.Height + this.a.d);
		this.u.Size = new esj(this.c.Width, this.c.Height);
		this.u.IsPrivateComponent = true;
		this.u.Visible = false;
		this.u.p(new EventHandler<b25>(this.h));
		this.u.j(new EventHandler<b25>(this.e));
		this.u.l(new EventHandler<b25>(this.f));
		e4z.j(this.u);
		this.aox(this.u);
		this.v = new doz();
		this.v.a(this.ak);
		this.v.a(new Point(this.e.X, this.e.Y));
		this.v.Location = new Point(0, this.b.Height + this.a.d);
		this.v.Size = new esj(this.e.Width, this.e.Height);
		this.v.IsPrivateComponent = true;
		this.v.Visible = false;
		this.v.p(new EventHandler<b25>(this.i));
		this.v.j(new EventHandler<b25>(this.a));
		this.v.l(new EventHandler<b25>(this.b));
		e4z.j(this.v);
		this.aox(this.v);
		this.w = new doz();
		this.w.a(this.ak);
		this.w.a(new Point(this.f.X, this.f.Y));
		this.w.Location = new Point(this.v.Size.c, this.b.Height + this.a.d);
		this.w.Size = new esj(this.f.Width, this.f.Height);
		this.w.IsPrivateComponent = true;
		this.w.Visible = false;
		this.w.p(new EventHandler<b25>(this.g));
		this.w.j(new EventHandler<b25>(this.c));
		this.w.l(new EventHandler<b25>(this.d));
		e4z.j(this.w);
		this.aox(this.w);
		this.ae = new dsy(this, this, esj.a(), 250, null, null, 250, false, false);
		this.af = new dsy(this.u, this, esj.a(), 250, null, null, 3000, false, false);
		this.ag = new dsy(this.w, this, esj.a(), 250, null, null, 3000, false, false);
		this.ah = new dsy(this.v, this, esj.a(), 250, null, null, 3000, false, false);
	}

	// Token: 0x0600C506 RID: 50438 RVA: 0x0044AC28 File Offset: 0x00448E28
	private void a()
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
		if (this.ae != null)
		{
			this.ae.a(num);
		}
		if (this.af != null)
		{
			this.af.a(num);
		}
		if (this.ag != null)
		{
			this.ag.a(num);
		}
		if (this.ah != null)
		{
			this.ah.a(num);
		}
	}

	// Token: 0x0600C507 RID: 50439 RVA: 0x0044AD0C File Offset: 0x00448F0C
	private void a(djx.a A_0, e6d A_1)
	{
		if (A_0 == djx.a.a)
		{
			this.t -= A_1.a().ElapsedGameTime.TotalMilliseconds * 0.002;
			if (this.t <= 0.0)
			{
				this.t = 0.0;
				this.q = djx.a.a;
				this.r = null;
				return;
			}
		}
		else if (A_0 == djx.a.b)
		{
			this.t += A_1.a().ElapsedGameTime.TotalMilliseconds * 0.002;
			if (this.t >= 1.0)
			{
				this.t = 1.0;
				this.q = djx.a.b;
				this.r = null;
			}
		}
	}

	// Token: 0x0600C508 RID: 50440 RVA: 0x0044ADE8 File Offset: 0x00448FE8
	private void i(object A_0, b25 A_1)
	{
		bi3 service = bpo.GetService<bi3>();
		if (service != null)
		{
			service.aim();
		}
		d02 service2 = bpo.GetService<d02>();
		if (service2 != null && service2.ahg())
		{
			d4n d4n = service2.ahu(this.x.ao());
			if (d4n != null && d4n == service2.ahe() && !service2.ahs(true, true))
			{
				service2.ahq(d4n, true, true, true, null, true);
			}
		}
	}

	// Token: 0x0600C509 RID: 50441 RVA: 0x0044AE64 File Offset: 0x00449064
	private void h(object A_0, b25 A_1)
	{
		bi3 service = bpo.GetService<bi3>();
		if (service != null)
		{
			service.aim();
		}
		if (this.x != null)
		{
			au2 au = this.x.ao() as au2;
			if (au != null)
			{
				c5x c5x = au.b() as c5x;
				if (c5x != null && c5x.h.b != null)
				{
					d02 service2 = bpo.GetService<d02>();
					if (service2 != null && !service2.ahg())
					{
						if (service2.ahj() > 0.0)
						{
							a7v.a(new vr(null, null, "Нельзя начать пошаговый бой так скоро.", new Color?(adi.l), null));
							return;
						}
						service2.ahn(c5x.h.b, true);
					}
				}
			}
		}
	}

	// Token: 0x0600C50A RID: 50442 RVA: 0x0044AF24 File Offset: 0x00449124
	private void g(object A_0, b25 A_1)
	{
		bi3 service = bpo.GetService<bi3>();
		if (service != null)
		{
			service.aim();
		}
		d02 service2 = bpo.GetService<d02>();
		if (service2 != null && service2.ahg())
		{
			service2.ahs(false, false);
		}
	}

	// Token: 0x0600C50B RID: 50443 RVA: 0x0044AF64 File Offset: 0x00449164
	protected override void ik(object A_0, b25 A_1)
	{
		base.ik(A_0, A_1);
		this.ae.b();
	}

	// Token: 0x0600C50C RID: 50444 RVA: 0x0044AF7C File Offset: 0x0044917C
	protected override void nr(object A_0, b25 A_1)
	{
		base.nr(A_0, A_1);
		this.ae.b();
	}

	// Token: 0x0600C50D RID: 50445 RVA: 0x0044AF94 File Offset: 0x00449194
	private void f(object A_0, b25 A_1)
	{
		this.af.b();
	}

	// Token: 0x0600C50E RID: 50446 RVA: 0x0044AFA4 File Offset: 0x004491A4
	private void e(object A_0, b25 A_1)
	{
		this.af.b();
	}

	// Token: 0x0600C50F RID: 50447 RVA: 0x0044AFB4 File Offset: 0x004491B4
	private void d(object A_0, b25 A_1)
	{
		this.ag.b();
	}

	// Token: 0x0600C510 RID: 50448 RVA: 0x0044AFC4 File Offset: 0x004491C4
	private void c(object A_0, b25 A_1)
	{
		this.ag.b();
	}

	// Token: 0x0600C511 RID: 50449 RVA: 0x0044AFD4 File Offset: 0x004491D4
	private void b(object A_0, b25 A_1)
	{
		this.ah.b();
	}

	// Token: 0x0600C512 RID: 50450 RVA: 0x0044AFE4 File Offset: 0x004491E4
	private void a(object A_0, b25 A_1)
	{
		this.ah.b();
	}

	// Token: 0x040047F1 RID: 18417
	private new esj a = new esj(35, 1024);

	// Token: 0x040047F2 RID: 18418
	private new Rectangle b = new Rectangle(318, 0, 43, 13);

	// Token: 0x040047F3 RID: 18419
	private new Rectangle c = new Rectangle(318, 13, 43, 43);

	// Token: 0x040047F4 RID: 18420
	private new Rectangle d = new Rectangle(318, 229, 43, 43);

	// Token: 0x040047F5 RID: 18421
	private new Rectangle e = new Rectangle(318, 143, 21, 43);

	// Token: 0x040047F6 RID: 18422
	private new Rectangle f = new Rectangle(340, 143, 21, 43);

	// Token: 0x040047F7 RID: 18423
	private new int g = 362;

	// Token: 0x040047F8 RID: 18424
	private int h;

	// Token: 0x040047F9 RID: 18425
	private int i = 36;

	// Token: 0x040047FA RID: 18426
	private new double j = 2.25;

	// Token: 0x040047FB RID: 18427
	private new int k = 8;

	// Token: 0x040047FC RID: 18428
	private new const double l = 0.002;

	// Token: 0x040047FD RID: 18429
	private new const double m = 0.1;

	// Token: 0x040047FE RID: 18430
	private const double n = 0.0010000000474974513;

	// Token: 0x040047FF RID: 18431
	private const double o = 0.6;

	// Token: 0x04004800 RID: 18432
	private const double p = 0.15000000596046448;

	// Token: 0x04004801 RID: 18433
	private djx.a q;

	// Token: 0x04004802 RID: 18434
	private djx.a? r;

	// Token: 0x04004803 RID: 18435
	private djx.a? s;

	// Token: 0x04004804 RID: 18436
	private double t;

	// Token: 0x04004805 RID: 18437
	private doz u;

	// Token: 0x04004806 RID: 18438
	private doz v;

	// Token: 0x04004807 RID: 18439
	private doz w;

	// Token: 0x04004808 RID: 18440
	private TypedObjectReference<efk> x;

	// Token: 0x04004809 RID: 18441
	private double y;

	// Token: 0x0400480A RID: 18442
	private double z;

	// Token: 0x0400480B RID: 18443
	private double aa;

	// Token: 0x0400480C RID: 18444
	private bool ab = true;

	// Token: 0x0400480D RID: 18445
	private ax4 ac;

	// Token: 0x0400480E RID: 18446
	private b5j ad;

	// Token: 0x0400480F RID: 18447
	private dsy ae;

	// Token: 0x04004810 RID: 18448
	private new dsy af;

	// Token: 0x04004811 RID: 18449
	private dsy ag;

	// Token: 0x04004812 RID: 18450
	private dsy ah;

	// Token: 0x04004813 RID: 18451
	private esj ai;

	// Token: 0x04004814 RID: 18452
	private bool aj;

	// Token: 0x04004815 RID: 18453
	public string ak = bo1.ad;

	// Token: 0x02002060 RID: 8288
	private new enum a
	{
		// Token: 0x04004817 RID: 18455
		a,
		// Token: 0x04004818 RID: 18456
		b,
		// Token: 0x04004819 RID: 18457
		c
	}
}

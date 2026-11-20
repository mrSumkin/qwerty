using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using TimelapseVertigo.Common.Settings;
using TimelapseVertigo.Rules.Locale;

// Token: 0x02001FFD RID: 8189
public sealed class bp0 : euz, amj
{
	// Token: 0x0600C12B RID: 49451 RVA: 0x0042EFC8 File Offset: 0x0042D1C8
	public bp0()
	{
		this.b();
	}

	// Token: 0x0600C12C RID: 49452 RVA: 0x0042EFE8 File Offset: 0x0042D1E8
	public override void iv(e6d A_0, cp9 A_1)
	{
		this.e.a(A_0);
		this.f.a(A_0);
		this.g.a(A_0);
		this.h.a(A_0);
		base.iv(A_0, A_1);
	}

	// Token: 0x0600C12D RID: 49453 RVA: 0x0042F030 File Offset: 0x0042D230
	public ecs yf(euz A_0)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqw() != null)
		{
			if (A_0 == this.i)
			{
				ZoneControlLevel key = eir.d(serviceOrThrow.aqw());
				ecs ecs = new ecs(new List<dl6>
				{
					new dl6(new List<bph>
					{
						new bph(new d22(cq4.c(), Color.White), "Вы находитесь в ", null),
						new bph(new d22(cq4.c(), adi.c), bp0.d[key], null)
					}),
					new dl6(new List<bph>
					{
						new bph(new d22(cq4.c(), Color.White), null, null)
					})
				});
				foreach (string a_ in qv.b("ZoneSecurity/" + key.ToString()).Split(new char[]
				{
					'\r',
					'\n'
				}, StringSplitOptions.RemoveEmptyEntries))
				{
					ecs.a.Add(new dl6(new List<bph>
					{
						new bph(new d22(cq4.c(), Color.LightGray), a_, null)
					}));
				}
				return ecs;
			}
			if (A_0 == this.j)
			{
				ecs ecs2 = new ecs(new List<dl6>
				{
					new dl6(new List<bph>
					{
						new bph(new d22(cq4.c(), Color.White), "Запись камерой наблюдения", null)
					}),
					new dl6(new List<bph>
					{
						new bph(new d22(cq4.c(), Color.White), null, null)
					})
				});
				foreach (string a_2 in qv.b("ZoneSecurity/CameraFootage").Split(new char[]
				{
					'\r',
					'\n'
				}, StringSplitOptions.RemoveEmptyEntries))
				{
					ecs2.a.Add(new dl6(new List<bph>
					{
						new bph(new d22(cq4.c(), Color.LightGray), a_2, null)
					}));
				}
				return ecs2;
			}
			if (A_0 == this.k)
			{
				ecs ecs3 = new ecs(new List<dl6>
				{
					new dl6(new List<bph>
					{
						new bph(new d22(cq4.c(), Color.White), "Без свидетелей", null)
					}),
					new dl6(new List<bph>
					{
						new bph(new d22(cq4.c(), Color.White), null, null)
					})
				});
				foreach (string a_3 in qv.b("ZoneSecurity/LeaveNoWitnesses").Split(new char[]
				{
					'\r',
					'\n'
				}, StringSplitOptions.RemoveEmptyEntries))
				{
					ecs3.a.Add(new dl6(new List<bph>
					{
						new bph(new d22(cq4.c(), Color.LightGray), a_3, null)
					}));
				}
				return ecs3;
			}
			if (A_0 == this.l)
			{
				ecs ecs4 = new ecs(new List<dl6>
				{
					new dl6(new List<bph>
					{
						new bph(new d22(cq4.c(), Color.White), "Сохранение отключено", null)
					}),
					new dl6(new List<bph>
					{
						new bph(new d22(cq4.c(), Color.White), null, null)
					})
				});
				foreach (string a_4 in qv.b("ZoneSecurity/SavingDisabled").Split(new char[]
				{
					'\r',
					'\n'
				}, StringSplitOptions.RemoveEmptyEntries))
				{
					ecs4.a.Add(new dl6(new List<bph>
					{
						new bph(new d22(cq4.c(), Color.LightGray), a_4, null)
					}));
				}
				return ecs4;
			}
		}
		return null;
	}

	// Token: 0x0600C12E RID: 49454 RVA: 0x0042F438 File Offset: 0x0042D638
	public override void ag5(e6d A_0)
	{
		this.a();
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		int num = 1;
		if (serviceOrThrow.aqw() != null)
		{
			wj wj = wj.a();
			ZoneControlLevel zoneControlLevel = eir.d(serviceOrThrow.aqw());
			if (wj.c())
			{
				this.i.d = new Rectangle?(new Rectangle((int)(zoneControlLevel * (ZoneControlLevel)this.a.c), bp0.b, this.a.c, this.a.d));
			}
			else
			{
				this.i.d = new Rectangle?(new Rectangle((int)(wj.by.X + zoneControlLevel * (ZoneControlLevel)wj.bx.c), wj.by.Y, this.a.c, this.a.d));
			}
			this.i.Color = bp0.c[zoneControlLevel];
			this.i.Visible = true;
			bool flag = eir.c(serviceOrThrow.aqw());
			this.j.Visible = flag;
			if (flag)
			{
				num++;
			}
			bool flag2 = eir.b(serviceOrThrow.aqw());
			this.k.Visible = flag2;
			this.k.Location = new Point(0, this.a.d * num);
			if (flag2)
			{
				num++;
			}
			bool flag3 = eir.a(serviceOrThrow.aqw());
			this.l.Visible = flag3;
			this.l.Location = new Point(0, this.a.d * num);
			if (flag3)
			{
				num++;
			}
		}
		base.Size = new esj(this.a.c, this.a.d * num);
		base.ag5(A_0);
	}

	// Token: 0x0600C12F RID: 49455 RVA: 0x0042F604 File Offset: 0x0042D804
	private Texture2D c()
	{
		return bpo.GetServiceOrThrow<cne>().us(bo1.bq, new double?((double)-1));
	}

	// Token: 0x0600C130 RID: 49456 RVA: 0x0042F620 File Offset: 0x0042D820
	private void b()
	{
		wj wj = wj.a();
		this.i = new bg1();
		if (wj.d == UiSize.Classic)
		{
			this.i.c = new Func<Texture2D>(this.c);
		}
		else
		{
			this.a = wj.bx;
			this.i.b = wj.f;
		}
		this.i.Size = this.a;
		this.i.j(new EventHandler<b25>(this.g));
		this.i.l(new EventHandler<b25>(this.h));
		this.i.Visible = false;
		base.Size = this.a;
		this.j = new bg1();
		if (wj.d == UiSize.Classic)
		{
			this.j.c = new Func<Texture2D>(this.c);
			this.j.d = new Rectangle?(new Rectangle(0, 68, this.a.c, this.a.d));
		}
		else
		{
			this.j.b = wj.f;
			this.j.d = new Rectangle?(new Rectangle(wj.by.X, wj.by.Y + wj.bx.d, wj.bx.c, wj.bx.d));
		}
		this.j.Color = adi.c * 0.75f;
		this.j.Size = this.a;
		this.j.Location = new Point(0, this.a.d);
		this.j.j(new EventHandler<b25>(this.f));
		this.j.l(new EventHandler<b25>(this.e));
		this.j.Visible = false;
		this.k = new bg1();
		if (wj.d == UiSize.Classic)
		{
			this.k.c = new Func<Texture2D>(this.c);
			this.k.d = new Rectangle?(new Rectangle(51, 68, this.a.c, this.a.d));
		}
		else
		{
			this.k.b = wj.f;
			this.k.d = new Rectangle?(new Rectangle(wj.by.X + wj.bx.c, wj.by.Y + wj.bx.d, wj.bx.c, wj.bx.d));
		}
		this.k.Color = adi.c * 0.75f;
		this.k.Size = this.a;
		this.k.Location = new Point(0, this.a.d);
		this.k.j(new EventHandler<b25>(this.c));
		this.k.l(new EventHandler<b25>(this.d));
		this.k.Visible = false;
		this.l = new bg1();
		if (wj.d == UiSize.Classic)
		{
			this.l.c = new Func<Texture2D>(this.c);
			this.l.d = new Rectangle?(new Rectangle(102, 68, this.a.c, this.a.d));
		}
		else
		{
			this.l.b = wj.f;
			this.l.d = new Rectangle?(new Rectangle(wj.by.X + wj.bx.c * 2, wj.by.Y + wj.bx.d, wj.bx.c, wj.bx.d));
		}
		this.l.Color = adi.c * 0.75f;
		this.l.Size = this.a;
		this.l.Location = new Point(0, this.a.d);
		this.l.j(new EventHandler<b25>(this.a));
		this.l.l(new EventHandler<b25>(this.b));
		this.l.Visible = false;
		this.e = new dsy(this.i, this, esj.a(), 400, null, null, 3000, false, false);
		this.f = new dsy(this.j, this, esj.a(), 400, null, null, 3000, false, false);
		this.g = new dsy(this.k, this, esj.a(), 400, null, null, 3000, false, false);
		this.h = new dsy(this.l, this, esj.a(), 400, null, null, 3000, false, false);
		this.aox(this.i);
		this.aox(this.j);
		this.aox(this.k);
		this.aox(this.l);
	}

	// Token: 0x0600C131 RID: 49457 RVA: 0x0042FBC0 File Offset: 0x0042DDC0
	private void a()
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		int num = 400;
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
		if (this.e != null)
		{
			this.e.a(num);
		}
		if (this.f != null)
		{
			this.f.a(num);
		}
		if (this.g != null)
		{
			this.g.a(num);
		}
		if (this.h != null)
		{
			this.h.a(num);
		}
	}

	// Token: 0x0600C132 RID: 49458 RVA: 0x0042FCA4 File Offset: 0x0042DEA4
	private void h(object A_0, b25 A_1)
	{
		this.e.b();
	}

	// Token: 0x0600C133 RID: 49459 RVA: 0x0042FCB4 File Offset: 0x0042DEB4
	private void g(object A_0, b25 A_1)
	{
		this.e.b();
	}

	// Token: 0x0600C134 RID: 49460 RVA: 0x0042FCC4 File Offset: 0x0042DEC4
	private void f(object A_0, b25 A_1)
	{
		this.f.b();
	}

	// Token: 0x0600C135 RID: 49461 RVA: 0x0042FCD4 File Offset: 0x0042DED4
	private void e(object A_0, b25 A_1)
	{
		this.f.b();
	}

	// Token: 0x0600C136 RID: 49462 RVA: 0x0042FCE4 File Offset: 0x0042DEE4
	private void d(object A_0, b25 A_1)
	{
		this.g.b();
	}

	// Token: 0x0600C137 RID: 49463 RVA: 0x0042FCF4 File Offset: 0x0042DEF4
	private void c(object A_0, b25 A_1)
	{
		this.g.b();
	}

	// Token: 0x0600C138 RID: 49464 RVA: 0x0042FD04 File Offset: 0x0042DF04
	private void b(object A_0, b25 A_1)
	{
		this.h.b();
	}

	// Token: 0x0600C139 RID: 49465 RVA: 0x0042FD14 File Offset: 0x0042DF14
	private void a(object A_0, b25 A_1)
	{
		this.h.b();
	}

	// Token: 0x040045E1 RID: 17889
	private new esj a = new esj(50, 50);

	// Token: 0x040045E2 RID: 17890
	private new static readonly int b = 17;

	// Token: 0x040045E3 RID: 17891
	private new static readonly Dictionary<ZoneControlLevel, Color> c = new Dictionary<ZoneControlLevel, Color>
	{
		{
			ZoneControlLevel.Uncontrolled,
			adi.b * 0.75f
		},
		{
			ZoneControlLevel.PartiallyControlled,
			adi.a * 0.75f
		},
		{
			ZoneControlLevel.Controlled,
			adi.c * 0.75f
		}
	};

	// Token: 0x040045E4 RID: 17892
	private new static readonly Dictionary<ZoneControlLevel, string> d = new Dictionary<ZoneControlLevel, string>
	{
		{
			ZoneControlLevel.Uncontrolled,
			"неконтролируемой зоне"
		},
		{
			ZoneControlLevel.PartiallyControlled,
			"частично контролируемой зоне"
		},
		{
			ZoneControlLevel.Controlled,
			"контролируемой зоне"
		}
	};

	// Token: 0x040045E5 RID: 17893
	private new dsy e;

	// Token: 0x040045E6 RID: 17894
	private new dsy f;

	// Token: 0x040045E7 RID: 17895
	private new dsy g;

	// Token: 0x040045E8 RID: 17896
	private dsy h;

	// Token: 0x040045E9 RID: 17897
	private bg1 i;

	// Token: 0x040045EA RID: 17898
	private new bg1 j;

	// Token: 0x040045EB RID: 17899
	private new bg1 k;

	// Token: 0x040045EC RID: 17900
	private new bg1 l;
}

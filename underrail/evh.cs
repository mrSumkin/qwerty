using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using TimelapseVertigo.Common;
using TimelapseVertigo.Common.Settings;
using TimelapseVertigo.Rules;
using TimelapseVertigo.UI.Controls;

// Token: 0x02000596 RID: 1430
public sealed class evh : a9t, amj
{
	// Token: 0x17000112 RID: 274
	// (get) Token: 0x06002505 RID: 9477 RVA: 0x000D0EB8 File Offset: 0x000CF0B8
	public b3w BagView
	{
		get
		{
			return this.a;
		}
	}

	// Token: 0x06002506 RID: 9478 RVA: 0x000D0EC0 File Offset: 0x000CF0C0
	public evh(efk A_0)
	{
		czh.a(A_0, "character");
		this.k = A_0;
		this.c();
	}

	// Token: 0x06002507 RID: 9479 RVA: 0x000D0EE4 File Offset: 0x000CF0E4
	private void c()
	{
		int num = 20;
		int num2 = 20;
		int num3 = 700;
		int num4 = 460;
		Point cy = new Point(15, 51);
		wj wj = wj.a();
		if (wj.d != UiSize.Classic)
		{
			num3 = wj.cv;
			num4 = wj.cw;
			cy = wj.cy;
			num = wj.cx;
			num2 = Math.Max(15, num);
		}
		this.b();
		esj esj = a2x.a();
		esj esj2;
		if (wj.d == UiSize.Classic)
		{
			esj2 = new esj((int)Math.Min((double)num3, (double)esj.c * 0.5), (int)Math.Max((double)num4, (double)esj.d * 0.6));
		}
		else
		{
			esj2 = new esj((int)Math.Min((double)num3, (double)esj.c * 0.5), (int)Math.Max((double)num4, (double)esj.d * 0.7));
		}
		this.c = new dak();
		this.c.Text = dh9.c("CharInventory_Button_Sort");
		evh.a(wj, this.c);
		this.c.g = adi.a;
		this.c.j = adi.b;
		this.c.p(new EventHandler<b25>(this.b));
		e4z.j(this.c);
		this.aox(this.c);
		this.d = new dak();
		this.d.Text = dh9.c("CharInventory_Button_TransferAll");
		evh.a(wj, this.d);
		this.d.g = adi.a;
		this.d.j = adi.b;
		this.d.p(new EventHandler<b25>(this.a));
		e4z.j(this.d);
		this.aox(this.d);
		int a_ = 0;
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null)
		{
			a_ = serviceOrThrow.aqu().s;
		}
		egd egd = efw.a(serviceOrThrow.aq1().g().a);
		this.a = new b3w(this.k.Bag, null, true, true, true, false, a_, egd.a < 1280);
		this.a.a(this);
		this.a.a(ItemExchangeParty.PlayerInventory.ToString());
		if (wj.d == UiSize.Classic)
		{
			this.a.Location = new Point(260, 45);
			esj esj3 = this.a.a(esj2.c - (260 + num), esj2.d - (45 + num + num2 + this.c.Size.d));
			this.a.b(esj3.c, esj3.d);
		}
		else
		{
			this.a.Location = new Point(wj.cy.X + wj.cl.X + 15 + wj.ck.c + num + wj.cj, 45);
			esj esj4 = this.a.a(esj2.c - this.a.Location.X, esj2.d - (45 + num + num2 + this.c.Size.d));
			this.a.b(esj4.c, esj4.d);
		}
		this.c.Location = new Point(this.a.Location.X + this.a.Size.c / 2 - this.c.Size.c - 15, this.a.Location.Y + this.a.Size.d + num2);
		this.d.Location = new Point(this.a.Location.X + this.a.Size.c / 2 - 5, this.c.Location.Y);
		if (wj.d == UiSize.Classic)
		{
			esj esj5 = new esj(Math.Max(500, 260 + this.a.Size.c + num), Math.Max(460, 45 + this.a.Size.d + num + num2 + this.c.Size.d));
			if (esj5.d % 2 != 0)
			{
				esj5.d++;
			}
			base.Size = esj5;
		}
		else
		{
			esj esj6 = new esj(Math.Max(500, this.a.Location.X + this.a.Size.c), Math.Max(460, 45 + this.a.Size.d + num + num2 + this.c.Size.d));
			esj6.d += wj.g - esj6.d % wj.g;
			base.Size = esj6;
		}
		this.aox(this.a);
		this.b = new bts(this.k, this.a, this, new Func<coh>(this.a));
		this.b.Location = cy;
		this.aox(this.b);
		if (wj.c())
		{
			this.e = new avo();
			if (egg.v)
			{
				this.e.a(egg.n);
			}
			else
			{
				this.e.a(egg.z);
			}
			try
			{
				this.e.Text = string.Format(dh9.c("CharInventory_Notification_EquippingApCost"), euf.h((serviceOrThrow.aqu() != null) ? serviceOrThrow.aqu().v() : null));
			}
			catch
			{
			}
			this.e.a(false);
			this.e.Location = new Point(10, this.b.Location.Y + this.b.Size.d - 3 + egg.b(this.e.g()));
			this.e.Size = new esj(220, 45);
			this.e.a(cab.a);
			this.e.a(ad4.a);
			this.e.Color = Color.Red;
			this.aox(this.e);
			this.f = new avo();
			this.f.a(this.e.g());
			this.f.Text = dh9.c("CharInventory_Notification_CannotEquipCurrently");
			this.f.Location = this.e.Location;
			this.f.Size = this.e.Size;
			this.f.Color = Color.Red;
			this.aox(this.f);
			this.g = new avo();
			this.g.a(this.e.g());
			this.g.Text = dh9.c("CharInventory_Notification_CannotEquipStealth");
			this.g.Location = this.e.Location;
			this.g.Size = this.e.Size;
			this.g.Color = Color.OrangeRed;
			this.aox(this.g);
		}
		else
		{
			this.h = new bg1();
			this.h.Size = wj.c4;
			this.h.b = wj.f;
			this.h.d = new Rectangle?(new Rectangle(wj.c3.X, wj.c3.Y + wj.c4.d, wj.c4.c, wj.c4.d));
			this.h.Color = Color.OrangeRed;
			this.h.Visible = false;
			this.aox(this.h);
			this.i = new bg1();
			this.i.Size = wj.c4;
			this.i.b = wj.f;
			this.i.d = new Rectangle?(new Rectangle(wj.c3.X, wj.c3.Y + 2 * wj.c4.d, wj.c4.c, wj.c4.d));
			this.i.Color = adi.k;
			this.i.Visible = false;
			this.aox(this.i);
			this.j = new bg1();
			this.j.Size = wj.c4;
			this.j.b = wj.f;
			this.j.d = new Rectangle?(new Rectangle(wj.c3.X, wj.c3.Y, wj.c4.c, wj.c4.d));
			this.j.Color = adi.k;
			this.j.Visible = false;
			this.aox(this.j);
			euz euz = this.h;
			euz euz2 = this.i;
			euz euz3 = this.j;
			Point a_2 = new Point(15, base.Size.d - 15 - this.h.Size.d);
			euz3.Location = a_2;
			euz.Location = (euz2.Location = a_2);
			this.l = new dsy(this.h, this, esj.a(), base.Size.c / 2, null, null, 1000, false, false);
			this.m = new dsy(this.i, this, esj.a(), base.Size.c / 2, null, null, 1000, false, false);
			this.n = new dsy(this.j, this, esj.a(), base.Size.c / 2, null, null, 1000, false, false);
		}
		if (!wj.c() && this.d.Location.X + this.d.Size.c + 10 > base.Size.c)
		{
			int num5 = this.d.Location.X + this.d.Size.c - base.Size.c + 10;
			this.d.d(-num5, 0);
			this.c.d(-num5, 0);
		}
	}

	// Token: 0x06002508 RID: 9480 RVA: 0x000D1A74 File Offset: 0x000CFC74
	private static void a(wj A_0, dak A_1)
	{
		if (A_0.d == UiSize.Classic)
		{
			A_1.Size = new esj(120, 25);
			if (egg.v)
			{
				A_1.Font = egg.a;
				A_1.TextLabelOffset = new Point(0, 6);
			}
			else
			{
				A_1.Font = egg.aq;
				A_1.TextLabelOffset = new Point(0, egg.b(A_1.Font));
			}
			A_1.d = bo1.z;
			return;
		}
		A_1.Size = A_0.c2;
		A_1.Font = A_0.c5;
		A_1.TextLabelOffset = new Point(0, egg.b(A_1.Font));
		A_1.d = A_0.f;
		A_1.f = A_0.e7;
		A_1.e = new esj?(A_0.e8);
	}

	// Token: 0x06002509 RID: 9481 RVA: 0x000D1B4C File Offset: 0x000CFD4C
	private void b()
	{
		base.Text = string.Format("{0} - {1}/{2}", dh9.c("SystemBar_Inventory"), this.k.bc, this.k.CarryCapacity);
	}

	// Token: 0x0600250A RID: 9482 RVA: 0x000D1B8C File Offset: 0x000CFD8C
	public override void iv(e6d A_0, cp9 A_1)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		wj wj = wj.a();
		if (!this.k.IsInControl || this.k.SpecialStates.f)
		{
			if (wj.c())
			{
				this.e.Visible = false;
				this.f.Visible = true;
				this.g.Visible = false;
			}
			else
			{
				this.h.Visible = false;
				this.i.Visible = true;
				this.j.Visible = false;
			}
		}
		else if (this.k.IsInCombat)
		{
			if (wj.c())
			{
				this.e.Visible = true;
				this.f.Visible = false;
				this.g.Visible = false;
			}
			else
			{
				this.h.Visible = true;
				this.i.Visible = false;
				this.j.Visible = false;
			}
		}
		else if (serviceOrThrow.aqu() != null && serviceOrThrow.aqu().ae() >= GameDifficulty.Hard && serviceOrThrow.aqu().v() != null && serviceOrThrow.aqu().v().b() != null && awq.a(serviceOrThrow.aqu().v().b()))
		{
			if (wj.c())
			{
				this.e.Visible = false;
				this.f.Visible = false;
				this.g.Visible = true;
			}
			else
			{
				this.h.Visible = false;
				this.i.Visible = false;
				this.j.Visible = true;
			}
		}
		else if (wj.c())
		{
			this.e.Visible = false;
			this.f.Visible = false;
			this.g.Visible = false;
		}
		else
		{
			this.h.Visible = false;
			this.i.Visible = false;
			this.j.Visible = false;
		}
		base.iv(A_0, A_1);
		if (this.l != null)
		{
			this.l.a(A_0);
		}
		if (this.m != null)
		{
			this.m.a(A_0);
		}
		if (this.n != null)
		{
			this.n.a(A_0);
		}
	}

	// Token: 0x0600250B RID: 9483 RVA: 0x000D1DF4 File Offset: 0x000CFFF4
	public override void ag5(e6d A_0)
	{
		base.ag5(A_0);
		ps serviceOrThrow = bpo.GetServiceOrThrow<ps>();
		this.d.Enabled = (serviceOrThrow.ak9() != null || serviceOrThrow.ala() != null);
		if (this.l != null)
		{
			this.l.b();
		}
		if (this.m != null)
		{
			this.m.b();
		}
		if (this.n != null)
		{
			this.n.b();
		}
	}

	// Token: 0x0600250C RID: 9484 RVA: 0x000D1E78 File Offset: 0x000D0078
	public ecs yf(euz A_0)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		string a_;
		if (A_0 == this.i)
		{
			a_ = dh9.c("CharInventory_Notification_CannotEquipCurrently");
		}
		else if (A_0 == this.h)
		{
			a_ = string.Format(dh9.c("CharInventory_Notification_EquippingApCost"), euf.h((serviceOrThrow.aqu() != null) ? serviceOrThrow.aqu().v() : null));
		}
		else
		{
			if (A_0 != this.j)
			{
				return null;
			}
			a_ = dh9.c("CharInventory_Notification_CannotEquipStealth");
		}
		return new ecs(new List<dl6>
		{
			new dl6(new List<bph>
			{
				new bph(new d22(cq4.c(), Color.LightGray), a_, null)
			})
		});
	}

	// Token: 0x0600250D RID: 9485 RVA: 0x000D1F44 File Offset: 0x000D0144
	protected override void i0()
	{
		base.i0();
		this.a.d(new EventHandler<b25>(this.d));
		this.a.a(new EventHandler<b25>(this.c));
		this.k.a(new EventHandler<EventArgs>(this.a));
	}

	// Token: 0x0600250E RID: 9486 RVA: 0x000D1F9C File Offset: 0x000D019C
	protected override void i1()
	{
		this.a.e(new EventHandler<b25>(this.d));
		this.a.f(new EventHandler<b25>(this.c));
		this.k.c(new EventHandler<EventArgs>(this.a));
		base.i1();
	}

	// Token: 0x0600250F RID: 9487 RVA: 0x000D1FF4 File Offset: 0x000D01F4
	private new void d(object A_0, b25 A_1)
	{
		cqy cqy = A_0 as cqy;
		if (A_1.b() == eoo.d)
		{
			if (!d4f.a() && cqy != null && cqy.x6() != null && cqy.x6().Definition.a2().Count > 0)
			{
				if (cqy.x6().Definition.a2().Count > 1)
				{
					Point point = cqy.at();
					global::bc.a(cqy, this, cqy.x6(), new Point(point.X + cqy.Size.c / 2, point.Y + cqy.Size.d / 2), false, true);
					return;
				}
				av av = ecf.a(cqy.x6().Definition.a2()[0].Value, new dsx(), cqy.x6());
				if (av != null && av.yw())
				{
					bpo.GetServiceOrThrow<ps>().amb(av);
					return;
				}
			}
		}
		else if (A_1.b() == eoo.b && !d4f.a && cqy != null && cqy.x6() != null && !d4f.b())
		{
			KeyboardState state = Keyboard.GetState();
			if (state.IsKeyDown(Keys.LeftControl) || state.IsKeyDown(Keys.RightControl))
			{
				this.b(cqy);
				return;
			}
			if (state.IsKeyDown(Keys.LeftAlt) || state.IsKeyDown(Keys.RightAlt))
			{
				ps serviceOrThrow = bpo.GetServiceOrThrow<ps>();
				if (serviceOrThrow.ala() != null)
				{
					if (serviceOrThrow.ala().ye(cqy, cqy.x6()) && cqy.yg(serviceOrThrow.ala()) && c69.a(cqy, serviceOrThrow.ala(), cqy.x6(), true))
					{
						e4z.c();
						return;
					}
				}
				else if (serviceOrThrow.ak9() != null && serviceOrThrow.ak9().ye(cqy, cqy.x6()) && cqy.yg(serviceOrThrow.ak9()) && c69.a(cqy, serviceOrThrow.ak9(), cqy.x6(), true))
				{
					e4z.c();
				}
			}
		}
	}

	// Token: 0x06002510 RID: 9488 RVA: 0x000D2228 File Offset: 0x000D0428
	private void c(object A_0, b25 A_1)
	{
		KeyboardState state = Keyboard.GetState();
		if (!state.IsKeyDown(Keys.LeftControl) && !state.IsKeyDown(Keys.RightControl) && !state.IsKeyDown(Keys.LeftAlt) && !state.IsKeyDown(Keys.RightAlt))
		{
			cqy cqy = A_0 as cqy;
			if (cqy != null && cqy.x6() != null)
			{
				ps serviceOrThrow = bpo.GetServiceOrThrow<ps>();
				if (serviceOrThrow.ak9() != null)
				{
					if (serviceOrThrow.ak9().ye(cqy, cqy.x6()) && cqy.yg(serviceOrThrow.ak9()) && c69.a(cqy, serviceOrThrow.ak9(), cqy.x6(), true))
					{
						e4z.c();
						return;
					}
				}
				else
				{
					this.b(cqy);
				}
			}
		}
	}

	// Token: 0x06002511 RID: 9489 RVA: 0x000D22F8 File Offset: 0x000D04F8
	private void b(object A_0, b25 A_1)
	{
		this.a.v();
	}

	// Token: 0x06002512 RID: 9490 RVA: 0x000D2308 File Offset: 0x000D0508
	private void a(object A_0, b25 A_1)
	{
		ps serviceOrThrow = bpo.GetServiceOrThrow<ps>();
		ebk a_;
		if (serviceOrThrow.ak9() != null)
		{
			a_ = serviceOrThrow.ak9();
		}
		else
		{
			if (serviceOrThrow.ala() == null)
			{
				return;
			}
			a_ = serviceOrThrow.ala();
		}
		object a_2 = this.a.m();
		foreach (coh coh in Enumerable.ToList<coh>(this.a.x().z2()))
		{
			if (this.a.x() == null)
			{
				break;
			}
			if (this.a.s() != null && !this.a.s().kj(this.a.x(), coh, a_2))
			{
				break;
			}
			if (c69.a(this.a, a_, coh, true))
			{
				this.a.x().z5(coh);
				if (this.a.s() != null)
				{
					this.a.s().kl(this.a.x(), coh, a_2);
				}
			}
		}
	}

	// Token: 0x06002513 RID: 9491 RVA: 0x000D2450 File Offset: 0x000D0650
	private void a(object A_0, EventArgs A_1)
	{
		this.b();
	}

	// Token: 0x06002514 RID: 9492 RVA: 0x000D2458 File Offset: 0x000D0658
	protected override void lq(object A_0, b25 A_1)
	{
		base.lq(A_0, A_1);
		if (A_1.b() == eoo.d)
		{
			d4f.a();
		}
	}

	// Token: 0x06002515 RID: 9493 RVA: 0x000D2474 File Offset: 0x000D0674
	protected override void r4(object A_0, el5 A_1)
	{
		base.r4(A_0, A_1);
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null)
		{
			int num = this.a.o();
			serviceOrThrow.aqu().s = ((num >= 0) ? num : 0);
		}
	}

	// Token: 0x06002516 RID: 9494 RVA: 0x000D24C0 File Offset: 0x000D06C0
	private void b(cqy A_0)
	{
		etf service = bpo.GetService<etf>();
		if (service != null && service.ar8(A_0))
		{
			return;
		}
		this.a(A_0);
	}

	// Token: 0x06002517 RID: 9495 RVA: 0x000D24F0 File Offset: 0x000D06F0
	private void a(cqy A_0)
	{
		cqy cqy = null;
		if (A_0.x6() is a06)
		{
			if (A_0.x6() is cd1)
			{
				if (this.b.t != null && this.b.t.ah8() && this.b.t.x6() == null)
				{
					cqy = this.b.t;
					goto IL_1F7;
				}
				if (this.b.u != null && this.b.u.ah8() && this.b.u.x6() == null)
				{
					cqy = this.b.u;
					goto IL_1F7;
				}
				if (this.b.t.ah8())
				{
					cqy = this.b.t;
					goto IL_1F7;
				}
				goto IL_1F7;
			}
			else
			{
				if (this.b.n == null)
				{
					goto IL_1F7;
				}
				using (List<cqy>.Enumerator enumerator = this.b.n.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						cqy cqy2 = enumerator.Current;
						dl0 dl = cqy2 as dl0;
						if (dl != null && dl.ah8() && dl.ah9().IsAssignableFrom(A_0.x6().GetType()))
						{
							cqy = cqy2;
							break;
						}
					}
					goto IL_1F7;
				}
			}
		}
		if (A_0.x6() is acz && this.b.m != null)
		{
			PlayerGearItemSlotControl<coh> playerGearItemSlotControl = null;
			foreach (PlayerGearItemSlotControl<coh> playerGearItemSlotControl2 in this.b.m)
			{
				if (playerGearItemSlotControl2.ah8())
				{
					if (playerGearItemSlotControl2.x6() == null)
					{
						playerGearItemSlotControl = playerGearItemSlotControl2;
						break;
					}
					if (playerGearItemSlotControl == null)
					{
						playerGearItemSlotControl = playerGearItemSlotControl2;
					}
				}
			}
			if (playerGearItemSlotControl != null)
			{
				cqy = playerGearItemSlotControl;
			}
		}
		IL_1F7:
		if (cqy != null && cqy.ye(A_0, A_0.x6()) && A_0.yg(cqy) && c69.a(A_0, cqy, A_0.x6(), false))
		{
			e4z.c();
		}
	}

	// Token: 0x06002518 RID: 9496 RVA: 0x000D274C File Offset: 0x000D094C
	private coh a()
	{
		dkk dkk = bpo.GetServiceOrThrow<d1a>().aa8() as dkk;
		if (dkk != null && dkk.ContainerView == this.a)
		{
			return dkk.x6();
		}
		return null;
	}

	// Token: 0x0400157A RID: 5498
	private new b3w a;

	// Token: 0x0400157B RID: 5499
	private new bts b;

	// Token: 0x0400157C RID: 5500
	private new dak c;

	// Token: 0x0400157D RID: 5501
	private new dak d;

	// Token: 0x0400157E RID: 5502
	private new avo e;

	// Token: 0x0400157F RID: 5503
	private new avo f;

	// Token: 0x04001580 RID: 5504
	private new avo g;

	// Token: 0x04001581 RID: 5505
	private new bg1 h;

	// Token: 0x04001582 RID: 5506
	private new bg1 i;

	// Token: 0x04001583 RID: 5507
	private new bg1 j;

	// Token: 0x04001584 RID: 5508
	private new efk k;

	// Token: 0x04001585 RID: 5509
	private new dsy l;

	// Token: 0x04001586 RID: 5510
	private new dsy m;

	// Token: 0x04001587 RID: 5511
	private dsy n;
}

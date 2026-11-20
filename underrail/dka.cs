using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using Ouroboros.Common.Data;
using Ouroboros.Core.Logging;
using Ouroboros.Events;
using Ouroboros.Playfield.References;
using TimelapseVertigo.Common;
using TimelapseVertigo.Common.Settings;
using TimelapseVertigo.Rules.Capabilities;
using TimelapseVertigo.UI;

// Token: 0x02000599 RID: 1433
public sealed class dka : ps
{
	// Token: 0x0600252F RID: 9519 RVA: 0x000D3678 File Offset: 0x000D1878
	public bool aku()
	{
		return this.av;
	}

	// Token: 0x06002530 RID: 9520 RVA: 0x000D3680 File Offset: 0x000D1880
	public void akv(bool A_0)
	{
		this.av = A_0;
	}

	// Token: 0x06002531 RID: 9521 RVA: 0x000D368C File Offset: 0x000D188C
	internal ci3 ac()
	{
		return this.d;
	}

	// Token: 0x06002532 RID: 9522 RVA: 0x000D3694 File Offset: 0x000D1894
	public a7m akw()
	{
		if (this.d != null)
		{
			return this.d.q();
		}
		return null;
	}

	// Token: 0x06002533 RID: 9523 RVA: 0x000D36B0 File Offset: 0x000D18B0
	public amw akx()
	{
		return this.k;
	}

	// Token: 0x06002534 RID: 9524 RVA: 0x000D36B8 File Offset: 0x000D18B8
	public bu2 aky()
	{
		return this.j;
	}

	// Token: 0x06002535 RID: 9525 RVA: 0x000D36C0 File Offset: 0x000D18C0
	public b0b akz()
	{
		return this.aj;
	}

	// Token: 0x06002536 RID: 9526 RVA: 0x000D36C8 File Offset: 0x000D18C8
	public void a(b0b A_0)
	{
		this.aj = A_0;
	}

	// Token: 0x06002537 RID: 9527 RVA: 0x000D36D4 File Offset: 0x000D18D4
	public bg3 ak0()
	{
		return this.ap;
	}

	// Token: 0x06002538 RID: 9528 RVA: 0x000D36DC File Offset: 0x000D18DC
	public b0b ak1()
	{
		return this.an;
	}

	// Token: 0x06002539 RID: 9529 RVA: 0x000D36E4 File Offset: 0x000D18E4
	public bool ak2()
	{
		return this.ab;
	}

	// Token: 0x0600253A RID: 9530 RVA: 0x000D36EC File Offset: 0x000D18EC
	public void ak3(bool A_0)
	{
		this.ab = A_0;
	}

	// Token: 0x0600253B RID: 9531 RVA: 0x000D36F8 File Offset: 0x000D18F8
	public bool ak4()
	{
		return this.aa > 0 || this.ab;
	}

	// Token: 0x0600253C RID: 9532 RVA: 0x000D3710 File Offset: 0x000D1910
	public ado ak5()
	{
		ado ado = new ado();
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null && serviceOrThrow.aqu().v() != null && serviceOrThrow.aqu().v().b() != null && serviceOrThrow.aqu().v().b().j == cgy.b)
		{
			c5x c5x = serviceOrThrow.aqu().v().b() as c5x;
			if (c5x.i.b != null && c5x.i.b.a() != null)
			{
				ado.a = c5x.i.b.a();
				ado.b = c5x.i.b.a().fm();
				ado.c = c5x.i.b.a().oi();
			}
		}
		return ado;
	}

	// Token: 0x0600253D RID: 9533 RVA: 0x000D37FC File Offset: 0x000D19FC
	public bool ak6()
	{
		return this.z != null;
	}

	// Token: 0x0600253E RID: 9534 RVA: 0x000D3808 File Offset: 0x000D1A08
	public bool ak7()
	{
		return this.s.j() && this.s.f();
	}

	// Token: 0x0600253F RID: 9535 RVA: 0x000D3828 File Offset: 0x000D1A28
	public eg ak8()
	{
		if (this.s.j())
		{
			return this.s.a();
		}
		return null;
	}

	// Token: 0x06002540 RID: 9536 RVA: 0x000D3848 File Offset: 0x000D1A48
	public ebk ak9()
	{
		if (this.s.j() && this.s.h() != null)
		{
			return this.s.h().g;
		}
		return null;
	}

	// Token: 0x06002541 RID: 9537 RVA: 0x000D3880 File Offset: 0x000D1A80
	public ebk ala()
	{
		if (this.e.j() && this.e.h() != null)
		{
			return this.e.h().a;
		}
		if (this.n.j() && this.n.h() != null)
		{
			return this.n.h().c;
		}
		return null;
	}

	// Token: 0x06002542 RID: 9538 RVA: 0x000D38F0 File Offset: 0x000D1AF0
	public ebk alb()
	{
		return this.am;
	}

	// Token: 0x06002543 RID: 9539 RVA: 0x000D38F8 File Offset: 0x000D1AF8
	public bool alc()
	{
		return this.j.j();
	}

	// Token: 0x06002544 RID: 9540 RVA: 0x000D3908 File Offset: 0x000D1B08
	public bool ald()
	{
		return this.j.j() && !this.j.d();
	}

	// Token: 0x06002545 RID: 9541 RVA: 0x000D392C File Offset: 0x000D1B2C
	public bool ale()
	{
		return this.ad == 0;
	}

	// Token: 0x06002546 RID: 9542 RVA: 0x000D3938 File Offset: 0x000D1B38
	public aje alf()
	{
		return this.v;
	}

	// Token: 0x06002547 RID: 9543 RVA: 0x000D3944 File Offset: 0x000D1B44
	public bool alg()
	{
		if (this.ai > 0)
		{
			return true;
		}
		cnk cnk = ces.a();
		if (cnk != null && cnk.aqu() != null && cnk.aqu().v() != null)
		{
			c5x c5x = cnk.aqu().v().b() as c5x;
			if (c5x != null)
			{
				ny aspect = c5x.GetAspect<ny>();
				if (aspect != null)
				{
					cst cst = aspect.a() as cst;
					if (cst != null && (cst.kh() & m7.o) == m7.o)
					{
						return true;
					}
				}
			}
		}
		return false;
	}

	// Token: 0x06002548 RID: 9544 RVA: 0x000D39DC File Offset: 0x000D1BDC
	public abz alh()
	{
		return this.w;
	}

	// Token: 0x06002549 RID: 9545 RVA: 0x000D39E4 File Offset: 0x000D1BE4
	public eu7 ali()
	{
		return this.aq;
	}

	// Token: 0x0600254A RID: 9546 RVA: 0x000D39EC File Offset: 0x000D1BEC
	public void alj(eu7 A_0)
	{
		this.aq = A_0;
	}

	// Token: 0x0600254B RID: 9547 RVA: 0x000D39F8 File Offset: 0x000D1BF8
	public bool alk()
	{
		return bpo.GetServiceOrThrow<d4m>().avo() is a5c;
	}

	// Token: 0x0600254C RID: 9548 RVA: 0x000D3A0C File Offset: 0x000D1C0C
	public bool all()
	{
		return this.ar;
	}

	// Token: 0x0600254D RID: 9549 RVA: 0x000D3A14 File Offset: 0x000D1C14
	public void alm(bool A_0)
	{
		this.ar = A_0;
	}

	// Token: 0x0600254E RID: 9550 RVA: 0x000D3A20 File Offset: 0x000D1C20
	public dka()
	{
		this.q();
	}

	// Token: 0x0600254F RID: 9551 RVA: 0x000D3A40 File Offset: 0x000D1C40
	public bad aln(object A_0)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		c5x c5x = A_0 as c5x;
		if (c5x != null)
		{
			if (serviceOrThrow.aqu().v().b() == c5x)
			{
				return null;
			}
			bool a_ = cho.a(c5x);
			amc aspect = c5x.GetAspect<amc>();
			if (aspect != null && aspect.aa() != null && !aspect.aa().Dead && !aspect.aa().Ethereal)
			{
				h h;
				if (!aspect.aa().Passive)
				{
					h = aspect.aa().a(serviceOrThrow.aqu().ac(), asp.a);
				}
				else
				{
					h = serviceOrThrow.aqu().v().a(serviceOrThrow.aqu().ac(), aspect.aa().FactionId);
				}
				bad bad = null;
				if (h == global::h.a)
				{
					bad = new mm();
				}
				else if (new c5d().cg(A_0))
				{
					bad = new c5o();
				}
				if (bad != null)
				{
					bad.a(c5x);
					return bad;
				}
			}
			if (c5x.r.b is ed2)
			{
				du du = new du(ecf.a(dgk.Get<bb3>(), new dsx(), null) as eu7);
				du.a(c5x);
				return du;
			}
			if (c5x.s.b is yp)
			{
				du du2 = new du(ecf.a(dgk.Get<ax9>(), new dsx(), null) as eu7);
				du2.a(c5x);
				return du2;
			}
			if (c5x.s.b != null && c5x.s.b.ab())
			{
				buw buw = new buw(a_);
				buw.a(c5x);
				return buw;
			}
		}
		ak1 ak = A_0 as ak1;
		if (ak != null)
		{
			HashSet<Keys> hashSet = new HashSet<Keys>(Keyboard.GetState().GetPressedKeys());
			if (!hashSet.Contains(Keys.LeftShift) && !hashSet.Contains(Keys.RightShift))
			{
				bad bad2 = null;
				List<ya> list = ak.a(typeof(b0j));
				List<ya> list2 = ak.a(typeof(dsz));
				b0j b0j = (list != null) ? (Enumerable.FirstOrDefault<ya>(list) as b0j) : null;
				if (ak.a(serviceOrThrow.aqu().v().a().d) && b0j != null && (b0j.Condition == null || b0j.Condition.jh(null)))
				{
					c5x c5x2 = serviceOrThrow.aqu().v().b() as c5x;
					if (c5x2 == null || !aw1.a(c5x2, ak, true, c5x2))
					{
						bad2 = new f3(list[0]);
					}
					else
					{
						bad2 = new atl();
					}
				}
				else if (aya.a() && ak.a(serviceOrThrow.aqu().v().a().d) && list2 != null && list2.Count > 0 && !aw1.a(ak, true, null, l9.a))
				{
					c5x c5x3 = serviceOrThrow.aqu().v().b() as c5x;
					bad2 = new du(ecf.a(dgk.Get<d5e>(), new eru(new EntityAspectReference<amc, amc>(c5x3.GetAspect<amc>())), null) as eu7);
				}
				else
				{
					List<ya> list3 = ak.a(typeof(cdo));
					if (list3 != null && list3.Count > 0)
					{
						foreach (ya ya in list3)
						{
							cdo cdo = ya as cdo;
							if (ak.a(serviceOrThrow.aqu().v().a().d) && cdo != null && (cdo.c() == null || cdo.c().jh(ak)))
							{
								c5x c5x4 = serviceOrThrow.aqu().v().b() as c5x;
								if (c5x4 == null || !aw1.a(c5x4, ak, true, c5x4))
								{
									bad2 = new f3(cdo);
								}
								else
								{
									bad2 = new atl();
								}
							}
						}
						if (bad2 == null)
						{
							bad2 = new atl();
						}
					}
					else
					{
						bad2 = new atl();
					}
				}
				if (bad2 != null)
				{
					bad2.a(ak);
					return bad2;
				}
			}
		}
		return null;
	}

	// Token: 0x06002550 RID: 9552 RVA: 0x000D3ED4 File Offset: 0x000D20D4
	public void alo()
	{
		bcm serviceOrThrow = bpo.GetServiceOrThrow<bcm>();
		serviceOrThrow.aav(this.d);
		serviceOrThrow.aax(this.d);
		am7 serviceOrThrow2 = bpo.GetServiceOrThrow<am7>();
		serviceOrThrow2.ai4(c2g.a);
		serviceOrThrow2.ai6();
		this.d.q().c();
	}

	// Token: 0x06002551 RID: 9553 RVA: 0x000D3F20 File Offset: 0x000D2120
	public void alp()
	{
		if (this.d != null)
		{
			bcm serviceOrThrow = bpo.GetServiceOrThrow<bcm>();
			if (serviceOrThrow.aau() == this.d)
			{
				serviceOrThrow.aav(null);
				serviceOrThrow.aax(null);
			}
		}
	}

	// Token: 0x06002552 RID: 9554 RVA: 0x000D3F60 File Offset: 0x000D2160
	public void alq()
	{
		this.e.ad();
		this.f.ad();
		this.s.ad();
		this.l.ad();
		this.m.ad();
		this.n.ad();
		this.i.ad();
		this.g.a(null);
	}

	// Token: 0x06002553 RID: 9555 RVA: 0x000D3FC8 File Offset: 0x000D21C8
	public void alr()
	{
		this.g.ad();
	}

	// Token: 0x06002554 RID: 9556 RVA: 0x000D3FD8 File Offset: 0x000D21D8
	public void als()
	{
		this.c();
		this.d();
		this.o.a(null);
	}

	// Token: 0x06002555 RID: 9557 RVA: 0x000D3FF4 File Offset: 0x000D21F4
	public void alt()
	{
		this.o.ad();
	}

	// Token: 0x06002556 RID: 9558 RVA: 0x000D4004 File Offset: 0x000D2204
	public void alu()
	{
		if (this.o.j())
		{
			this.alt();
			return;
		}
		this.als();
	}

	// Token: 0x06002557 RID: 9559 RVA: 0x000D4024 File Offset: 0x000D2224
	public void alv()
	{
		this.c();
		this.h.a(null);
	}

	// Token: 0x06002558 RID: 9560 RVA: 0x000D4038 File Offset: 0x000D2238
	public void alw()
	{
		this.h.ad();
	}

	// Token: 0x06002559 RID: 9561 RVA: 0x000D4048 File Offset: 0x000D2248
	public void w()
	{
		if (this.h.j())
		{
			this.alw();
			return;
		}
		this.alv();
	}

	// Token: 0x0600255A RID: 9562 RVA: 0x000D4068 File Offset: 0x000D2268
	public void alx()
	{
		this.d();
		this.l.a(null);
	}

	// Token: 0x0600255B RID: 9563 RVA: 0x000D407C File Offset: 0x000D227C
	public void aly()
	{
		this.l.ad();
	}

	// Token: 0x0600255C RID: 9564 RVA: 0x000D408C File Offset: 0x000D228C
	public void af()
	{
		if (this.l.j())
		{
			this.aly();
			return;
		}
		this.alx();
	}

	// Token: 0x0600255D RID: 9565 RVA: 0x000D40AC File Offset: 0x000D22AC
	public void alz()
	{
		this.d();
		this.m.a(null);
	}

	// Token: 0x0600255E RID: 9566 RVA: 0x000D40C0 File Offset: 0x000D22C0
	public void al0()
	{
		this.m.ad();
	}

	// Token: 0x0600255F RID: 9567 RVA: 0x000D40D0 File Offset: 0x000D22D0
	public void t()
	{
		if (this.m.j())
		{
			this.al0();
			return;
		}
		this.alz();
	}

	// Token: 0x06002560 RID: 9568 RVA: 0x000D40F4 File Offset: 0x000D22F4
	private void s()
	{
		if (this.n.j())
		{
			this.x();
			return;
		}
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null && serviceOrThrow.aqu().v() != null)
		{
			c5x c5x = serviceOrThrow.aqu().v().b() as c5x;
			if (c5x.i.b != null)
			{
				bx5 bx = new bx5(c5x);
				bx.l(new EventHandler<EventArgs>(new b90().a));
				c5x.i.b.a(bx, atp.a, true, false);
				a7v.a(new ed7(c5x, null));
			}
		}
	}

	// Token: 0x06002561 RID: 9569 RVA: 0x000D419C File Offset: 0x000D239C
	private void r()
	{
		if (this.i.j())
		{
			this.al2();
			return;
		}
		this.al1();
	}

	// Token: 0x06002562 RID: 9570 RVA: 0x000D41BC File Offset: 0x000D23BC
	public void al1()
	{
		this.c();
		this.i.a(null);
	}

	// Token: 0x06002563 RID: 9571 RVA: 0x000D41D0 File Offset: 0x000D23D0
	public void al2()
	{
		this.i.ad();
	}

	// Token: 0x06002564 RID: 9572 RVA: 0x000D41E0 File Offset: 0x000D23E0
	public void al3()
	{
		this.alt();
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (c2h.a(serviceOrThrow.aqu().v()) && serviceOrThrow.aqu().v().Portrait != "power_suit")
		{
			this.am2();
			return;
		}
		this.p.a(new bxm(a9m.a, null));
	}

	// Token: 0x06002565 RID: 9573 RVA: 0x000D4248 File Offset: 0x000D2448
	public void z()
	{
		this.p.ad();
	}

	// Token: 0x06002566 RID: 9574 RVA: 0x000D4258 File Offset: 0x000D2458
	public void al4()
	{
		this.d();
		this.q.a(null);
	}

	// Token: 0x06002567 RID: 9575 RVA: 0x000D426C File Offset: 0x000D246C
	public void al5()
	{
		this.q.ad();
	}

	// Token: 0x06002568 RID: 9576 RVA: 0x000D427C File Offset: 0x000D247C
	public void aa()
	{
		if (this.q.j())
		{
			this.al5();
			return;
		}
		this.al4();
	}

	// Token: 0x06002569 RID: 9577 RVA: 0x000D429C File Offset: 0x000D249C
	public void al6()
	{
		this.d();
		this.r.a(null);
	}

	// Token: 0x0600256A RID: 9578 RVA: 0x000D42B0 File Offset: 0x000D24B0
	public void al7()
	{
		this.r.ad();
	}

	// Token: 0x0600256B RID: 9579 RVA: 0x000D42C0 File Offset: 0x000D24C0
	public void v()
	{
		if (this.r.j())
		{
			this.al7();
			return;
		}
		this.al6();
	}

	// Token: 0x0600256C RID: 9580 RVA: 0x000D42E0 File Offset: 0x000D24E0
	public void u()
	{
		this.d();
		this.s.a(null);
	}

	// Token: 0x0600256D RID: 9581 RVA: 0x000D42F4 File Offset: 0x000D24F4
	public void ad()
	{
		this.s.ad();
	}

	// Token: 0x0600256E RID: 9582 RVA: 0x000D4304 File Offset: 0x000D2504
	public void ab()
	{
		if (this.s.j())
		{
			this.ad();
			return;
		}
		this.u();
	}

	// Token: 0x0600256F RID: 9583 RVA: 0x000D4324 File Offset: 0x000D2524
	public void al8()
	{
		this.d();
		this.c();
		this.t.a(null);
	}

	// Token: 0x06002570 RID: 9584 RVA: 0x000D4340 File Offset: 0x000D2540
	public void al9()
	{
		this.t.ad();
	}

	// Token: 0x06002571 RID: 9585 RVA: 0x000D4350 File Offset: 0x000D2550
	public void aj()
	{
		if (this.t.j())
		{
			this.al9();
			return;
		}
		this.al8();
	}

	// Token: 0x06002572 RID: 9586 RVA: 0x000D4370 File Offset: 0x000D2570
	public void ama()
	{
		if (!this.u.j())
		{
			this.u.a(null);
		}
	}

	// Token: 0x06002573 RID: 9587 RVA: 0x000D4390 File Offset: 0x000D2590
	public void amb(av A_0)
	{
		if (A_0 is eu7)
		{
			bad bad = a5v.a(A_0);
			if (bad != null)
			{
				this.b.ail(bad);
				if (bad.eg() is d73)
				{
					cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
					this.b.ain(serviceOrThrow.aqu().v().b());
				}
			}
			return;
		}
		bl6 bl = A_0 as bl6;
		if (bl != null)
		{
			this.b.aim();
			e06 a_ = new e06(bl);
			this.c.lj(a_);
		}
	}

	// Token: 0x06002574 RID: 9588 RVA: 0x000D4420 File Offset: 0x000D2620
	public void amc(b0b A_0)
	{
		c5x c5x = A_0 as c5x;
		if (c5x == null || c5x.h.b == null || c5x.h.b.aa() == null || c5x.h.b.aa().Dead)
		{
			return;
		}
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() == null || serviceOrThrow.aqu().v() == null)
		{
			return;
		}
		c5x c5x2 = serviceOrThrow.aqu().v().b() as c5x;
		if (c5x2 == null || c5x2.i.b == null || (c5x2.i.b.a() != null && c5x2.i.b.a().State != dc4.c))
		{
			return;
		}
		mm mm = new mm();
		if (mm.io() && mm.a(A_0))
		{
			this.c.lj(mm);
		}
	}

	// Token: 0x06002575 RID: 9589 RVA: 0x000D4524 File Offset: 0x000D2724
	public bool amd()
	{
		if (this.b.aij() != null)
		{
			this.b.aim();
			return true;
		}
		return false;
	}

	// Token: 0x06002576 RID: 9590 RVA: 0x000D4548 File Offset: 0x000D2748
	public string ame(euz A_0)
	{
		if (this.b == null || this.b.aij() == null)
		{
			return null;
		}
		evy evy = A_0 as evy;
		if (evy != null)
		{
			return evy.eu();
		}
		ta ta = A_0 as ta;
		if (ta != null && ta.zf())
		{
			string text = d4f.a(ta);
			if (text != null)
			{
				return text;
			}
		}
		return TimelapseCursor.Impossible.ToString();
	}

	// Token: 0x06002577 RID: 9591 RVA: 0x000D45BC File Offset: 0x000D27BC
	public void ah()
	{
		this.ag++;
		this.k();
	}

	// Token: 0x06002578 RID: 9592 RVA: 0x000D45D4 File Offset: 0x000D27D4
	public void ag()
	{
		this.ag--;
		this.k();
	}

	// Token: 0x06002579 RID: 9593 RVA: 0x000D45EC File Offset: 0x000D27EC
	public void amf()
	{
		this.ac++;
		this.k();
	}

	// Token: 0x0600257A RID: 9594 RVA: 0x000D4604 File Offset: 0x000D2804
	public void amg()
	{
		int num = this.ac - 1;
		this.ac = num;
		if (num < 0)
		{
			this.ac = 0;
		}
		this.k();
	}

	// Token: 0x0600257B RID: 9595 RVA: 0x000D4638 File Offset: 0x000D2838
	public void amh()
	{
		this.aa++;
		this.l();
	}

	// Token: 0x0600257C RID: 9596 RVA: 0x000D4650 File Offset: 0x000D2850
	public void ami()
	{
		int num = this.aa - 1;
		this.aa = num;
		if (num < 0)
		{
			this.aa = 0;
		}
		this.l();
	}

	// Token: 0x0600257D RID: 9597 RVA: 0x000D4684 File Offset: 0x000D2884
	public void amj()
	{
		this.ae = !this.ae;
		this.j();
	}

	// Token: 0x0600257E RID: 9598 RVA: 0x000D469C File Offset: 0x000D289C
	public void amk()
	{
		this.af = !this.af;
		this.j();
	}

	// Token: 0x0600257F RID: 9599 RVA: 0x000D46B4 File Offset: 0x000D28B4
	public void aml()
	{
		this.ad++;
		this.j();
	}

	// Token: 0x06002580 RID: 9600 RVA: 0x000D46D0 File Offset: 0x000D28D0
	public void amm()
	{
		int num = this.ad - 1;
		this.ad = num;
		if (num < 0)
		{
			this.ad = 0;
		}
		this.j();
	}

	// Token: 0x06002581 RID: 9601 RVA: 0x000D4704 File Offset: 0x000D2904
	public void amn()
	{
		this.ah++;
		this.i();
	}

	// Token: 0x06002582 RID: 9602 RVA: 0x000D471C File Offset: 0x000D291C
	public void amo()
	{
		int num = this.ah - 1;
		this.ah = num;
		if (num < 0)
		{
			this.ah = 0;
		}
		this.i();
	}

	// Token: 0x06002583 RID: 9603 RVA: 0x000D4750 File Offset: 0x000D2950
	public void amp()
	{
		this.ai++;
		if (this.ai > 0)
		{
			this.d.q().h();
		}
	}

	// Token: 0x06002584 RID: 9604 RVA: 0x000D4780 File Offset: 0x000D2980
	public void amq()
	{
		int num = this.ai - 1;
		this.ai = num;
		if (num < 0)
		{
			this.ai = 0;
		}
	}

	// Token: 0x06002585 RID: 9605 RVA: 0x000D47AC File Offset: 0x000D29AC
	public Guid? amr(bool A_0, float? A_1 = null, bool A_2 = false)
	{
		b0b b0b = bpo.GetService<cnk>().aqu().v().b();
		if (b0b != null)
		{
			if (A_2 && this.d.q().anz() == b0b.Area)
			{
				Vector2 vector = this.d.q().vq(b0b.Location.X, b0b.Location.Y, b0b.Location.Z);
				if (vector.X >= 30f && vector.Y >= 30f && vector.X <= (float)(this.d.q().Size.c - 70) && vector.Y <= (float)(this.d.q().Size.d - 70))
				{
					return null;
				}
			}
			return this.ams(b0b, A_0, A_1);
		}
		dux.b(LogSeverity.Error, "Locale Controller could not go to player character, it was null.", new object[0]);
		return null;
	}

	// Token: 0x06002586 RID: 9606 RVA: 0x000D48C0 File Offset: 0x000D2AC0
	public Guid? ams(b0b A_0, bool A_1, float? A_2 = null)
	{
		return this.k.aex(A_0.Area, A_0.aj(), A_1, A_2);
	}

	// Token: 0x06002587 RID: 9607 RVA: 0x000D48E8 File Offset: 0x000D2AE8
	public Guid? amt(aud A_0, Vector3 A_1, bool A_2, float? A_3 = null)
	{
		return this.k.aex(A_0, A_1, A_2, A_3);
	}

	// Token: 0x06002588 RID: 9608 RVA: 0x000D48FC File Offset: 0x000D2AFC
	public bool amu(string A_0, b0b A_1, b0b A_2, List<ble> A_3, bool A_4, bool A_5, bool A_6 = true, PropertyCollection A_7 = null, bool A_8 = false, bool A_9 = false)
	{
		if (string.IsNullOrEmpty(A_0))
		{
			dux.b(LogSeverity.Error, "Locale Controller attempted to dialog with empty or null name.", new object[0]);
			return false;
		}
		azm azm = null;
		eve serviceOrThrow = bpo.GetServiceOrThrow<eve>();
		try
		{
			azm = serviceOrThrow.y3(A_0);
			aji.a(azm, A_0);
		}
		catch (Exception ex)
		{
			dux.b(LogSeverity.Error, "Failed to load dialog model with name '{0}'. Exception: {1}", new object[]
			{
				A_0,
				ex.ToString()
			});
			return false;
		}
		if (azm == null)
		{
			dux.b(LogSeverity.Error, "Failed to load dialog model with name '{0}'.", new object[]
			{
				A_0
			});
			return false;
		}
		return this.amv(azm, A_1, A_2, A_3, A_4, A_5, A_6, A_7, A_8, A_9);
	}

	// Token: 0x06002589 RID: 9609 RVA: 0x000D49B0 File Offset: 0x000D2BB0
	public bool amv(azm A_0, b0b A_1, b0b A_2, List<ble> A_3, bool A_4, bool A_5, bool A_6 = true, PropertyCollection A_7 = null, bool A_8 = false, bool A_9 = false)
	{
		this.al9();
		c5x c5x = A_1 as c5x;
		if (c5x != null && c5x.h.b != null)
		{
			c5x.h.b.u();
		}
		c5x c5x2 = A_2 as c5x;
		if (c5x2 != null && c5x2.h.b != null)
		{
			c5x2.h.b.u();
		}
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		d02 service = bpo.GetService<d02>();
		List<c5x> list = new List<c5x>();
		if (c5x != null)
		{
			list.Add(c5x);
		}
		if (c5x2 != null)
		{
			list.Add(c5x2);
		}
		foreach (c5x c5x3 in list)
		{
			if (c5x3.Area != null)
			{
				HashSet<bqt> hashSet = new HashSet<bqt>();
				foreach (ak1 ak in c5x3.l)
				{
					foreach (bqt bqt in ak.TriggerProxies)
					{
						hashSet.Add(bqt);
					}
				}
				foreach (bqt bqt2 in hashSet)
				{
					a1w a1w = bqt2.Trigger as a1w;
					if (a1w != null)
					{
						foreach (c5x c5x4 in list)
						{
							if (c5x4 != c5x3)
							{
								a1w.a(c5x3, c5x4);
							}
						}
					}
				}
			}
		}
		if (!A_9 && c5x != null && c5x2 != null && c5x.h.b != null && c5x2.h.b != null && c5x2.h.b.aa().a(serviceOrThrow.aqu().ac(), c5x2.h.b.aa().FactionId) == global::h.a)
		{
			return false;
		}
		if (!A_9 && !A_4 && ((service != null && service.ahg()) || serviceOrThrow.aqu().v().IsInCombat))
		{
			dux.b(LogSeverity.Warning, "Не удалось начать диалог '{0}'. Персонаж находится бою.", new object[]
			{
				A_0.e()
			});
			a7v.a(new h0("Нельзя начать диалог во время боя.", new Color?(adi.i)));
			return false;
		}
		if (c5x != null && c5x.Zone != null && c5x.t.b != null)
		{
			c5x.t.b.y6()[ddq.a2] = c5x.Zone.ElapsedZoneTime + TimeSpan.FromSeconds(3.0);
		}
		if (c5x2 != null && c5x2.Zone != null && c5x2.t.b != null)
		{
			c5x2.t.b.y6()[ddq.a2] = c5x2.Zone.ElapsedZoneTime + TimeSpan.FromSeconds(3.0);
		}
		if (!this.j.j())
		{
			e89 a_ = new e89(A_0, A_1, A_2, A_3, true, A_5, A_6, A_7, A_8);
			this.j.a(a_);
			return true;
		}
		dux.b(LogSeverity.Error, "Failed to open dialog interfaces to start dialog '{0}'. Another dialog is already taking place.", new object[]
		{
			A_0.e()
		});
		return false;
	}

	// Token: 0x0600258A RID: 9610 RVA: 0x000D4DF4 File Offset: 0x000D2FF4
	public bool amw(b0b A_0, b0b A_1)
	{
		c5x c5x = A_0 as c5x;
		c5x c5x2 = A_1 as c5x;
		if (c5x2 == null)
		{
			dux.b(LogSeverity.Error, "Bartering target was not a Local Entity.", new object[0]);
			return false;
		}
		if (c5x2.i == null || c5x2.i.b == null)
		{
			dux.b(LogSeverity.Error, "Bartering target did not have an action aspect.", new object[0]);
			return false;
		}
		if (c5x == null)
		{
			dux.b(LogSeverity.Error, "Bartering initiator was not a Local Entity.", new object[0]);
			return false;
		}
		if (c5x.i == null || c5x.i.b == null)
		{
			dux.b(LogSeverity.Error, "Bartering initiator did not have an action aspect.", new object[0]);
			return false;
		}
		dvp aspect = c5x2.GetAspect<dvp>();
		ble aspect2 = c5x2.GetAspect<j7>();
		if (aspect == null)
		{
			dux.b(LogSeverity.Error, "Attempted to barter with null merchant.", new object[0]);
			return false;
		}
		avh avh = new avh(c5x);
		avh.l(new EventHandler<EventArgs>(this.a));
		avh avh2 = new avh(c5x2);
		avh2.l(new EventHandler<EventArgs>(this.a));
		c5x.i.b.a(avh, atp.a, true, false);
		c5x2.i.b.a(avh2, atp.a, true, false);
		aspect.aqc(false);
		this.d();
		this.h.a(null, true, true);
		this.s.a(new aim(c5x, c5x2, aspect, aspect2));
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null)
		{
			amc aspect3 = aspect.a8().GetAspect<amc>();
			if (aspect3 != null && !string.IsNullOrEmpty(aspect3.aa().Id))
			{
				string a_ = string.Format("barter_{0}", aspect3.aa().Id);
				serviceOrThrow.aqu().c(a_, null);
			}
		}
		return true;
	}

	// Token: 0x0600258B RID: 9611 RVA: 0x000D4FB8 File Offset: 0x000D31B8
	public void ai()
	{
		if (this.ac().m().Visible && this.ac().m().Enabled)
		{
			this.ab = !this.ab;
			this.l();
		}
	}

	// Token: 0x0600258C RID: 9612 RVA: 0x000D5004 File Offset: 0x000D3204
	public void amx()
	{
		this.d.am();
	}

	// Token: 0x0600258D RID: 9613 RVA: 0x000D5014 File Offset: 0x000D3214
	public void amy()
	{
		this.d.bn();
	}

	// Token: 0x0600258E RID: 9614 RVA: 0x000D5024 File Offset: 0x000D3224
	public cl7 amz()
	{
		if (this.d != null)
		{
			return this.d.n().i();
		}
		return null;
	}

	// Token: 0x0600258F RID: 9615 RVA: 0x000D5044 File Offset: 0x000D3244
	public TimelapseTextFeeds am0()
	{
		return this.d.v().h();
	}

	// Token: 0x06002590 RID: 9616 RVA: 0x000D5058 File Offset: 0x000D3258
	public void am1()
	{
		this.am9();
		this.ad();
	}

	// Token: 0x06002591 RID: 9617 RVA: 0x000D506C File Offset: 0x000D326C
	public void am2()
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null && serviceOrThrow.aqu().v() != null && c2h.a(serviceOrThrow.aqu().v()))
		{
			dnj a_ = serviceOrThrow.aqu().v().k();
			this.p.a(new bxm(a9m.b, a_));
		}
	}

	// Token: 0x06002592 RID: 9618 RVA: 0x000D50D4 File Offset: 0x000D32D4
	public void am3(string A_0)
	{
		ai ai = bpo.GetServiceOrThrow<bjk>().ac5(A_0);
		if (ai != null)
		{
			this.d();
			this.c();
			if (this.j != null && this.j.j())
			{
				this.j.ad();
			}
			if (this.e.j())
			{
				this.e.ad();
			}
			this.amn();
			this.aml();
			bpo.GetServiceOrThrow<d4m>().avp(ai);
		}
	}

	// Token: 0x06002593 RID: 9619 RVA: 0x000D5158 File Offset: 0x000D3358
	public baa am4(TimeSpan A_0)
	{
		baa baa = new baa();
		baa.a = this.an;
		if (this.an != null)
		{
			h? h = dka.a(this.an);
			baa.b = ((h != null) ? h.Value : global::h.c);
		}
		return baa;
	}

	// Token: 0x06002594 RID: 9620 RVA: 0x000D51B0 File Offset: 0x000D33B0
	public void am5()
	{
		this.d.d().c();
	}

	// Token: 0x06002595 RID: 9621 RVA: 0x000D51C4 File Offset: 0x000D33C4
	public void am6()
	{
		this.d.d().d();
	}

	// Token: 0x06002596 RID: 9622 RVA: 0x000D51D8 File Offset: 0x000D33D8
	public void am7()
	{
		this.w.abl();
	}

	// Token: 0x06002597 RID: 9623 RVA: 0x000D51E8 File Offset: 0x000D33E8
	public void am8(b0b A_0, object A_1, csy A_2)
	{
		amc amc = A_1 as amc;
		if (amc == null)
		{
			return;
		}
		amc.a(A_0);
		if (this.e.j())
		{
			this.e.ad();
		}
		this.d();
		this.e.a(new ece(amc.a8().y8(), A_0 as c5x, amc.aa().Bag, A_2, true, null));
	}

	// Token: 0x06002598 RID: 9624 RVA: 0x000D525C File Offset: 0x000D345C
	public void am9()
	{
		this.e.ad();
	}

	// Token: 0x06002599 RID: 9625 RVA: 0x000D526C File Offset: 0x000D346C
	public void x()
	{
		this.n.ad();
	}

	// Token: 0x0600259A RID: 9626 RVA: 0x000D527C File Offset: 0x000D347C
	public void a(c5x A_0, akr A_1)
	{
		object obj;
		if (this.f.j())
		{
			obj = this.f.a();
			this.f.ad();
		}
		else
		{
			obj = null;
		}
		if (obj != A_1)
		{
			aud aud;
			if (string.IsNullOrEmpty(A_1.b()))
			{
				aud = A_1.a8().Area;
			}
			else
			{
				aud = A_1.a8().Zone.n(A_1.b());
			}
			if (aud != null)
			{
				ar7 ar = new ar7(A_1.e(), aud);
				if (ar.ao() != null)
				{
					this.a(ar.ao() as c5x, A_1, b14.a, A_1.a(), A_1.d(), A_1.f());
				}
			}
		}
	}

	// Token: 0x0600259B RID: 9627 RVA: 0x000D533C File Offset: 0x000D353C
	public void ana(b0b A_0, object A_1, b14 A_2, int A_3, Point? A_4 = null, string A_5 = null)
	{
		object obj;
		if (this.f.j())
		{
			obj = this.f.a();
			this.f.ad();
		}
		else
		{
			obj = null;
		}
		if (obj != A_1 && A_0 is c5x)
		{
			this.a(A_0 as c5x, A_1, A_2, A_3, A_4, A_5);
		}
	}

	// Token: 0x0600259C RID: 9628 RVA: 0x000D53A0 File Offset: 0x000D35A0
	public void anb(object A_0 = null)
	{
		if (A_0 == null || this.f.a() == A_0)
		{
			this.f.ad();
		}
	}

	// Token: 0x0600259D RID: 9629 RVA: 0x000D53C8 File Offset: 0x000D35C8
	public void anc()
	{
		bool flag = this.g.j();
		bool flag2 = bpo.GetServiceOrThrow<bcm>().aau() == this.d;
		aud aud = null;
		Vector3 a_ = Vector3.Zero;
		if (flag)
		{
			this.g.ad();
		}
		if (flag2)
		{
			aud = ((this.d != null) ? this.d.q().anz() : null);
			a_ = this.k.b();
			this.d();
			this.c();
			this.alp();
		}
		cl7 a_2 = this.d.n().i();
		this.d = new ci3(this);
		this.d.n().a(a_2);
		this.f();
		this.g();
		this.h();
		if (dz6.e())
		{
			this.d.d().c();
		}
		if (flag2)
		{
			if (aud != null)
			{
				this.k.aex(aud, a_, true, null);
			}
			if (flag)
			{
				this.g.a(null);
			}
			this.alo();
		}
	}

	// Token: 0x0600259E RID: 9630 RVA: 0x000D54E8 File Offset: 0x000D36E8
	public void and(Color? A_0)
	{
		if (this.d != null && this.d.q() != null)
		{
			this.d.q().i = A_0;
		}
	}

	// Token: 0x0600259F RID: 9631 RVA: 0x000D5518 File Offset: 0x000D3718
	public void ane(int A_0, int? A_1 = null, int? A_2 = null, int? A_3 = null, int? A_4 = null, int? A_5 = null)
	{
		if (this.d != null)
		{
			this.d.al = (double)A_0;
			if (A_1 != null)
			{
				this.d.ag = A_1.Value;
			}
			if (A_2 != null)
			{
				this.d.ah = A_2.Value;
			}
			if (A_3 != null)
			{
				this.d.ai = A_3.Value;
			}
			if (A_4 != null)
			{
				this.d.aj = A_4.Value;
			}
			if (A_5 != null)
			{
				this.d.ak = A_5.Value;
			}
		}
	}

	// Token: 0x060025A0 RID: 9632 RVA: 0x000D55D4 File Offset: 0x000D37D4
	public void anf(edg A_0)
	{
		if (this.d != null)
		{
			this.d.q().h.a = A_0;
		}
	}

	// Token: 0x060025A1 RID: 9633 RVA: 0x000D55F8 File Offset: 0x000D37F8
	public void ang(bool A_0 = false)
	{
		if (A_0)
		{
			this.d.j();
			return;
		}
		this.d.e();
	}

	// Token: 0x060025A2 RID: 9634 RVA: 0x000D5618 File Offset: 0x000D3818
	public void anh()
	{
		this.f.ad();
	}

	// Token: 0x060025A3 RID: 9635 RVA: 0x000D5628 File Offset: 0x000D3828
	public void ani()
	{
		this.g.avt();
	}

	// Token: 0x060025A4 RID: 9636 RVA: 0x000D5638 File Offset: 0x000D3838
	public void anj()
	{
		bpo.GetServiceOrThrow<d4m>().avr();
		if (this.ah > 0)
		{
			for (int i = 0; i < this.ah; i++)
			{
				this.amo();
			}
		}
		Guid value = cxc.a.GetPrimitivePropertyValue<Guid>("Attack_That_Killed_Player", new Guid?(Guid.Empty)).Value;
		if (value != Guid.Empty)
		{
			int value2 = cxc.a.GetPrimitivePropertyValue<int>("Kill_Count_For_Attack_" + value.ToString(), new int?(0)).Value;
			bool value3 = cxc.a.GetPrimitivePropertyValue<bool>("Attack_Is_Grenade_" + value.ToString(), new bool?(false)).Value;
			if (cxc.a.GetClassPropertyValue<string>("Faction_Of_Attack_" + value.ToString()) == asp.a && value3 && value2 == 1)
			{
				cxc.c(eyy.ay);
			}
		}
		a3r a3r = bpo.GetServiceOrThrow<cnk>().arj();
		bool a_ = a3r != null && !ast.a(a3r.GameVersion, a3r.DLCs);
		bcm serviceOrThrow = bpo.GetServiceOrThrow<bcm>();
		afb afb = new afb(this, a_);
		afb.Location = new Point((serviceOrThrow.aau().Size.c - afb.Size.c) / 2, (serviceOrThrow.aau().Size.d - afb.Size.d) / 2);
		afb.e(serviceOrThrow.aau());
		afb.a9();
	}

	// Token: 0x060025A5 RID: 9637 RVA: 0x000D57F8 File Offset: 0x000D39F8
	internal void b(e6d A_0)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		d02 service = bpo.GetService<d02>();
		if (this.alg() || this.ah > 0)
		{
			chr service2 = bpo.GetService<chr>();
			if (service2 != null && service2.aw())
			{
				service2.ay();
			}
		}
		if (this.d != null && this.d.q() != null && this.d.q().an9() != null)
		{
			if (serviceOrThrow.aq1().g().d)
			{
				this.d.q().e.a = true;
				float num = this.d.q().an9().ua();
				this.d.q().an9().ud(1f);
				this.d.q().an9().uf(2f);
				if (this.d.q().Size.c > 1920)
				{
					this.d.q().an9().uf(3f);
				}
				this.d.q().an9().ub(serviceOrThrow.aq8());
				this.d.q().an9().uq(false, false, true);
				serviceOrThrow.aq9(this.d.q().an9().ua());
				if (num != this.d.q().an9().ua())
				{
					this.d.q().f();
				}
			}
			else
			{
				egd egd = efw.a(serviceOrThrow.aq1().g().a);
				this.d.q().e.a = false;
				if (this.d.q().an9().ua() != egd.h)
				{
					this.d.q().an9().ub(egd.h);
					serviceOrThrow.ar1(this.d.q().an9().ua(), false);
					this.d.q().f();
				}
			}
		}
		if (this.an != null && this.an.h.b != null && this.an.h.b.aa().Dead)
		{
			this.an = null;
		}
		if (this.al >= 0.0)
		{
			if (this.j != null && this.j.j())
			{
				this.j.ad();
			}
			if (service != null && service.ahg() && service.ahi() != bh3.c)
			{
				service.ahr();
			}
			if ((this.al += A_0.a().ElapsedGameTime.TotalMilliseconds) >= 2000.0 && (service == null || !service.ahg() || service.ahi() != bh3.c))
			{
				this.amh();
				this.anj();
				this.al = -1.0;
			}
		}
		this.k.a(A_0.a().ElapsedGameTime.TotalMilliseconds);
		if (this.ak6())
		{
			this.z.a(A_0.a().ElapsedGameTime.TotalMilliseconds);
		}
		if (this.ac().q().anz() != null && this.ac().q().anz().Zone != null)
		{
			ax1 addon = this.ac().q().anz().Zone.GetAddon<ax1>();
			if (addon != null)
			{
				addon.apo(this.ac().q().anz().qe(), this.ac().q().an9().t1());
			}
		}
		if (this.ac == 0)
		{
			this.a(A_0.a().ElapsedGameTime);
		}
		if (this.d != null)
		{
			if (this.an != null && this.an.h.b != null)
			{
				this.d.a(this.an.h.b);
			}
			else
			{
				this.d.a(null);
			}
		}
		this.v.a(A_0);
		d4n a_ = null;
		if (service != null && service.ahg())
		{
			a_ = service.ahe();
		}
		bad bad = this.b.aij();
		if (bad == null)
		{
			if (this.d.q().an2() != null)
			{
				bad = this.aln(this.d.q().an2());
			}
			else if (this.d.q().an1() != null)
			{
				bad = this.aln(this.d.q().an1());
			}
			else if (this.aq != null && this.aq.d() == SpellTargetType.Self)
			{
				bad = new du(this.aq);
				if (serviceOrThrow.aqu() != null && serviceOrThrow.aqu().v() != null && serviceOrThrow.aqu().v().b() != null)
				{
					bad.a(serviceOrThrow.aqu().v().b());
				}
			}
		}
		else if (this.d.q().an2() != null)
		{
			bad.a(this.d.q().an2());
		}
		else if (this.d.q().an1() != null)
		{
			bad.a(this.d.q().an1());
		}
		this.b();
		this.w.a(bad, a_);
		this.aq = null;
		a20.a(A_0.a().ElapsedGameTime.TotalMilliseconds);
		d4f.a = d4f.b();
		cdb.a(serviceOrThrow);
		bnr bnr = bpo.GetServiceOrThrow<d1a>().aa7() as bnr;
		if (bnr != null && bnr.Name == "Death")
		{
			this.ai = 0;
		}
		if ((this.@as += A_0.a().ElapsedGameTime.TotalMilliseconds) > 3000.0)
		{
			this.@as = 0.0;
			if (!this.j.j() && !this.alk())
			{
				this.anf(edg.b);
			}
			if (!this.alk() && serviceOrThrow.aqw() != null && serviceOrThrow.aqw().CustomProperties.GetPrimitivePropertyValue<bool>(a46.a, new bool?(false)).Value)
			{
				serviceOrThrow.aqw().CustomProperties[a46.a] = false;
			}
		}
		if (serviceOrThrow.aqu() != null && serviceOrThrow.aqu().y() < new Version(1, 1, 2, 0) && this.ale() && !this.alg() && serviceOrThrow.aqu().v() != null && serviceOrThrow.aqu().v().PsiAbilities.a() > 0 && !serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("psiBookShown", new bool?(false)).Value)
		{
			serviceOrThrow.aqu().r()["psiBookShown"] = true;
			this.al1();
		}
		this.a(A_0);
	}

	// Token: 0x060025A6 RID: 9638 RVA: 0x000D5FEC File Offset: 0x000D41EC
	internal void ae()
	{
		this.y.b();
		this.z.b();
		this.o();
		this.m();
	}

	// Token: 0x060025A7 RID: 9639 RVA: 0x000D6014 File Offset: 0x000D4214
	internal void a(c5x A_0, c7j A_1)
	{
		object obj;
		if (this.e.j())
		{
			obj = this.e.a();
			this.e.ad();
		}
		else
		{
			obj = null;
		}
		if (obj != A_1)
		{
			this.d();
			string text = A_1.a8().y8();
			if (text != null && text.EndsWith(")"))
			{
				text = text.Substring(0, text.Length - 8);
			}
			this.e.a(new ece(text, A_0, A_1.ItemContainer, A_1, false, A_1));
		}
	}

	// Token: 0x060025A8 RID: 9640 RVA: 0x000D60AC File Offset: 0x000D42AC
	internal void a(c5x A_0, wv A_1)
	{
		object obj;
		if (this.n.j())
		{
			obj = this.n.a();
			this.n.ad();
		}
		else
		{
			obj = null;
		}
		object obj2 = (A_1 != null) ? A_1 : A_0;
		if (obj != obj2)
		{
			bcx bcx = null;
			if (A_1 != null)
			{
				bcx = A_1.g();
			}
			else if (A_0.h.b != null)
			{
				bcx = A_0.h.b.aa().Vehicle;
			}
			if (bcx != null)
			{
				this.d();
				if (A_1 == null)
				{
					this.n.a(new b22(bcx, A_0, bcx.ap(), new a4m(bcx), obj2));
					return;
				}
				this.n.a(new b22(A_1.g(), A_0, A_1.g().ap(), A_1, obj2));
			}
		}
	}

	// Token: 0x060025A9 RID: 9641 RVA: 0x000D618C File Offset: 0x000D438C
	internal void y()
	{
		this.amf();
		this.aml();
		this.amr(true, null, false);
		this.al = 0.0;
	}

	// Token: 0x060025AA RID: 9642 RVA: 0x000D61C8 File Offset: 0x000D43C8
	private void q()
	{
		this.c = new tf();
		this.b = new cv4(this.c);
		this.b.f(new EventHandler<dtl>(this.a));
		this.b.a(new EventHandler<dtl>(this.b));
		this.b.b(new EventHandler<dtl>(this.c));
		this.y = new a96();
		this.y.d();
		this.z = new b8t();
		this.z.c();
		this.x = new cac();
		this.n();
		this.d = new ci3(this);
		this.f();
		this.g();
		this.aa = 0;
		this.ab = false;
		this.ac = 0;
		this.ad = 0;
		this.e = new aiq(this);
		this.n = new bd2(this);
		this.f = new d7a(this);
		this.g = new e26(this);
		this.h = new b59(this);
		this.i = new cr8(this);
		this.j = new zq(this);
		this.k = new b88(this);
		this.l = new evf(this);
		this.m = new ekd(this);
		this.o = new dkq(this);
		this.p = new agw(this);
		this.q = new c23(this);
		this.r = new bes(this);
		this.s = new bis(this);
		this.t = new efc(this);
		this.u = new ebm(this);
		this.v = new c4b(this);
		this.w = new btd();
		this.p();
		this.h();
		this.ank();
		this.am = new b3g();
	}

	// Token: 0x060025AB RID: 9643 RVA: 0x000D63A8 File Offset: 0x000D45A8
	private void p()
	{
		this.ak = new List<KeyValuePair<Type, b61>>();
		this.RegisterAndRememberGlobalEventHandler<d2e>(new ewv(this));
		this.RegisterAndRememberGlobalEventHandler<epm>(new bx4(this));
		this.RegisterAndRememberGlobalEventHandler<dwq>(new bo(this));
		this.RegisterAndRememberGlobalEventHandler<f8>(new dgz(this));
		this.RegisterAndRememberGlobalEventHandler<czu>(new d7c(this));
	}

	// Token: 0x060025AC RID: 9644 RVA: 0x000D63FC File Offset: 0x000D45FC
	private void RegisterAndRememberGlobalEventHandler<T>(GlobalEventHandler<T> handler) where T : dli
	{
		bpo.GetServiceOrThrow<eta>().RegisterHandler<T>(handler);
		this.ak.Add(new KeyValuePair<Type, b61>(typeof(T), handler));
	}

	// Token: 0x060025AD RID: 9645 RVA: 0x000D6424 File Offset: 0x000D4624
	private void o()
	{
		eta serviceOrThrow = bpo.GetServiceOrThrow<eta>();
		foreach (KeyValuePair<Type, b61> keyValuePair in this.ak)
		{
			serviceOrThrow.ao4(keyValuePair.Key, keyValuePair.Value);
		}
		this.ak = null;
	}

	// Token: 0x060025AE RID: 9646 RVA: 0x000D6498 File Offset: 0x000D4698
	private void n()
	{
		bpo.RegisterService<ps>(this);
		bpo.RegisterService<bi3>(this.b);
		bpo.RegisterService<aa8>(this.c);
		bpo.RegisterService<aha>(this.y);
		bpo.RegisterService<ap1>(this.z);
		bpo.RegisterService<cz7>(this.x);
		pp.a = this;
	}

	// Token: 0x060025AF RID: 9647 RVA: 0x000D64E8 File Offset: 0x000D46E8
	private void m()
	{
		bpo.UnregisterService<ps>();
		bpo.UnregisterService<bi3>();
		bpo.UnregisterService<aa8>();
		bpo.UnregisterService<aha>();
		bpo.UnregisterService<ap1>();
		bpo.UnregisterService<cz7>();
		if (pp.a == this)
		{
			pp.a = null;
		}
	}

	// Token: 0x060025B0 RID: 9648 RVA: 0x000D651C File Offset: 0x000D471C
	private void l()
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		ax1 ax = null;
		if (serviceOrThrow.aqw() != null)
		{
			ax = serviceOrThrow.aqw().GetAddon<ax1>();
		}
		if (this.aa > 0 || this.ab)
		{
			if (serviceOrThrow.aqw() != null && serviceOrThrow.aqw().State == epb.b)
			{
				serviceOrThrow.aqw().n();
				if (ax != null)
				{
					ax.ap0();
					return;
				}
			}
		}
		else if (serviceOrThrow.aqw() != null && serviceOrThrow.aqw().State == epb.a)
		{
			serviceOrThrow.aqw().p();
			if (ax != null)
			{
				ax.ap1();
			}
		}
	}

	// Token: 0x060025B1 RID: 9649 RVA: 0x000D65C8 File Offset: 0x000D47C8
	private void k()
	{
		this.d.q().Visible = (this.ag == 0);
		this.d.q().Enabled = (this.ac == 0);
		this.d.n().Enabled = (this.ac == 0);
		if (this.ac > 0)
		{
			this.d.q().h();
		}
	}

	// Token: 0x060025B2 RID: 9650 RVA: 0x000D663C File Offset: 0x000D483C
	private void j()
	{
		bool a_ = this.ad == 0 && !this.ae;
		this.d.a(a_);
		this.h.b(a_);
		this.i.b(a_);
		this.e.b(a_);
		this.f.b(a_);
		this.o.b(a_);
		this.q.b(a_);
		this.s.b(a_);
		this.l.b(a_);
		this.m.b(a_);
		this.t.b(a_);
		bcm service = bpo.GetService<bcm>();
		if (service != null)
		{
			service.aap(!this.af);
		}
		if (this.ad > 0)
		{
			this.al7();
		}
	}

	// Token: 0x060025B3 RID: 9651 RVA: 0x000D6718 File Offset: 0x000D4918
	private void i()
	{
		bcm service = bpo.GetService<bcm>();
		if (service != null)
		{
			service.aar(this.ah <= 0);
		}
	}

	// Token: 0x060025B4 RID: 9652 RVA: 0x000D6744 File Offset: 0x000D4944
	private void h()
	{
		if (this.b.aij() == null || this.b.aij().eg() == null)
		{
			this.d.q().g.a(brh.b);
			this.d.q().g.b = brh.c;
			return;
		}
		if (this.b.aij().eg().c5() != bcw.a)
		{
			this.d.q().g.a(brh.b);
			this.d.q().g.b = brh.c;
			return;
		}
		this.d.q().g.a(brh.a);
		this.d.q().g.b = brh.c;
	}

	// Token: 0x060025B5 RID: 9653 RVA: 0x000D6818 File Offset: 0x000D4A18
	private void g()
	{
		this.ac().q().aor(new EventHandler<afm>(this.a));
		this.ac().q().aoh(new EventHandler<a3x>(this.a));
		this.ac().q().m(new EventHandler<b25>(this.a));
	}

	// Token: 0x060025B6 RID: 9654 RVA: 0x000D687C File Offset: 0x000D4A7C
	private void f()
	{
		this.d.g(new EventHandler<ane>(this.a));
		this.d.d(new EventHandler<ane>(this.b));
	}

	// Token: 0x060025B7 RID: 9655 RVA: 0x000D68B0 File Offset: 0x000D4AB0
	private void e()
	{
		if (this.b.aij() != null)
		{
			this.b.aim();
			return;
		}
		if (this.g.j())
		{
			this.alr();
			return;
		}
		if (this.t.j())
		{
			this.al9();
			return;
		}
		if (this.s.j())
		{
			this.ad();
			return;
		}
		if (this.e.j())
		{
			this.am9();
			return;
		}
		if (this.r.j())
		{
			this.al7();
			return;
		}
		if (this.p.j())
		{
			this.z();
			return;
		}
		if (this.l.j())
		{
			this.aly();
			return;
		}
		if (this.m.j())
		{
			this.al0();
			return;
		}
		if (this.f.j())
		{
			this.anb(null);
			return;
		}
		if (this.o.j())
		{
			this.alt();
			return;
		}
		if (this.q.j())
		{
			this.al5();
			return;
		}
		if (this.h.j())
		{
			this.alw();
			return;
		}
		if (this.i.j())
		{
			this.al2();
			return;
		}
		if (this.n.j())
		{
			this.x();
			return;
		}
		this.d.j();
		this.alq();
	}

	// Token: 0x060025B8 RID: 9656 RVA: 0x000D6A30 File Offset: 0x000D4C30
	public void ank()
	{
		cnk service = bpo.GetService<cnk>();
		if (service.aqu().m() != null)
		{
			this.d.n().a(service.aqu().m().a);
			this.d.v().a(service.aqu().m().b);
		}
	}

	// Token: 0x060025B9 RID: 9657 RVA: 0x000D6A94 File Offset: 0x000D4C94
	private void d()
	{
		this.ad();
		this.al5();
		this.am9();
		this.alt();
		this.al7();
		this.aly();
		this.anb(null);
		this.al0();
		this.x();
		this.al9();
	}

	// Token: 0x060025BA RID: 9658 RVA: 0x000D6AE0 File Offset: 0x000D4CE0
	private void c()
	{
		this.alw();
		this.al9();
		this.alt();
		this.anb(null);
		this.al2();
	}

	// Token: 0x060025BB RID: 9659 RVA: 0x000D6B0C File Offset: 0x000D4D0C
	private void c(c5x A_0)
	{
		if (A_0 != this.an)
		{
			if (A_0 != null && !A_0.IsPlayer)
			{
				if (A_0.h.b != null && !A_0.h.b.aa().Ethereal)
				{
					this.an = A_0;
				}
			}
			else
			{
				this.an = null;
			}
			this.ao = 0.0;
		}
	}

	// Token: 0x060025BC RID: 9660 RVA: 0x000D6B84 File Offset: 0x000D4D84
	private static bool b(c5x A_0)
	{
		return A_0 != null && A_0.h.b != null && !A_0.h.b.aa().Dead;
	}

	// Token: 0x060025BD RID: 9661 RVA: 0x000D6BB8 File Offset: 0x000D4DB8
	public void anl()
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		this.an = (serviceOrThrow.aqu().v().b() as c5x);
	}

	// Token: 0x060025BE RID: 9662 RVA: 0x000D6BE8 File Offset: 0x000D4DE8
	private static h? a(c5x A_0)
	{
		if (A_0 != null && A_0.h.b != null)
		{
			cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
			if (serviceOrThrow.aqu() != null && serviceOrThrow.aqu().v() != null)
			{
				return new h?(A_0.h.b.aa().a(serviceOrThrow.aqu().ac(), serviceOrThrow.aqu().v().FactionId));
			}
		}
		return null;
	}

	// Token: 0x060025BF RID: 9663 RVA: 0x000D6C6C File Offset: 0x000D4E6C
	private void a(TimeSpan A_0)
	{
		if (this.an != null)
		{
			if (this.an.Area == null || this.an.j != cgy.b)
			{
				this.an = null;
				return;
			}
			if (this.an.c(dm9.b))
			{
				this.ao = 0.0;
				return;
			}
			if ((this.ao += A_0.TotalMilliseconds) > (double)dm9.c)
			{
				this.ao = 0.0;
				this.an = null;
			}
		}
	}

	// Token: 0x060025C0 RID: 9664 RVA: 0x000D6D0C File Offset: 0x000D4F0C
	private void b()
	{
		this.ap = null;
		c5x c5x = this.d.q().an2() as c5x;
		if (c5x != null && c5x.h.b != null)
		{
			double num = c5x.l();
			if (this.au != c5x)
			{
				this.at = new Queue<double>();
				this.au = c5x;
			}
			this.at.Enqueue(num);
			if (this.at.Count > 30)
			{
				this.at.Dequeue();
			}
			double a_ = Enumerable.Average(this.at);
			cnk service = bpo.GetService<cnk>();
			if (service != null && service.aqu() != null && service.aqu().v() != null && service.aqu().v().b() != null)
			{
				efk efk = service.aqu().v();
				efk efk2 = c5x.h.b.aa();
				cd1 cd = efk.Offense.u();
				e4 e = ckf.a(cd.TypedDefinition.b()) as e4;
				c5x c5x2 = service.aqu().v().b() as c5x;
				amc a_2 = (c5x2 != null) ? c5x2.h.b : null;
				double num2 = aw1.b(service.aqu().v().b(), c5x);
				du du = this.b.aij() as du;
				if (du != null && du.ati() != null && du.ati().p() is bix)
				{
					this.ap = ((bix)du.ati().p()).bs(du.ati(), c5x.h.b.aa(), num2, a_, efk.Darkvision, awq.f(a_2), c3u.a);
				}
				else if (e != null)
				{
					cmn a_3 = awq.a(a_2, c5x.h.b, null, null);
					this.ap = e.zj(efk, efk2, num2, awq.f(a_2), c5x.l(), cd.CurrentBullet, a_3);
				}
				else
				{
					double num3 = 1.0;
					if (du != null && du.ati() != null)
					{
						bon bon = du.ati().p() as bon;
						if (bon != null)
						{
							eoj a_4 = new eoj(efk, efk.Offense.u(), efk2);
							num3 = bon.l9(a_4, num2);
							num3 = bon.ajx(a_4, num3, efk2, num2);
						}
						else
						{
							num3 = 1.0;
						}
					}
					if (euf.b(efk.Offense.u().TypedDefinition))
					{
						cmn a_5 = awq.b(a_2, c5x.h.b, null);
						if (du != null && du.ati() != null)
						{
							bxf bxf = du.ati().p() as bxf;
							if (bxf != null)
							{
								this.ap = bxf.i3(efk, efk2, a_5, num3);
							}
						}
						this.ap = euf.a(efk, efk2, a_5, num3, null);
					}
					else
					{
						cmn a_6 = awq.a(a_2, c5x.h.b, null, null);
						this.ap = euf.a(efk, efk2, Math.Min(num2, (double)efk.Offense.u().TypedDefinition.ad()), a_, efk.Darkvision, efk.Offense.u().CurrentBullet, awq.f(a_2), num3, a_6, null, null);
					}
				}
			}
		}
		ak1 ak = this.d.q().an1();
		if (ak != null)
		{
			cnk service2 = bpo.GetService<cnk>();
			if (service2 != null && service2.aqu() != null && service2.aqu().v() != null && service2.aqu().v().b() != null)
			{
				c5x c5x3 = service2.aqu().v().b() as c5x;
				amc a_7 = (c5x3 != null) ? c5x3.h.b : null;
				double a_8 = aw1.a(service2.aqu().v().b(), ak);
				du du2 = this.b.aij() as du;
				double[] array;
				if (du2 != null && du2.ati() != null && du2.ati().p() is a5q)
				{
					cmn a_9 = awq.a(a_7, null, null, null);
					array = ((a5q)du2.ati().p()).f2(du2.ati(), a_8, awq.f(a_7), a_9);
				}
				else
				{
					array = euf.b(service2.aqu().v(), a_8);
				}
				if (array != null && array.Length != 0)
				{
					this.ap = new bg3
					{
						a = array[0]
					};
				}
			}
		}
	}

	// Token: 0x060025C1 RID: 9665 RVA: 0x000D7238 File Offset: 0x000D5438
	private void a(c5x A_0, object A_1, b14 A_2, int A_3, Point? A_4, string A_5)
	{
		if (A_0.a())
		{
			cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
			if (serviceOrThrow.aqu() != null && serviceOrThrow.aqu().v() != null)
			{
				ev2 ev = new ev2("CameraEye");
				ev.Range = (float)A_3;
				new c6g(serviceOrThrow.aqu().v().c(), ev).be(A_0);
				this.d();
				this.c();
				this.alt();
				this.f.a(new de8(A_0, A_1, A_2, A_4, A_5));
			}
		}
	}

	// Token: 0x060025C2 RID: 9666 RVA: 0x000D72CC File Offset: 0x000D54CC
	private void a(object A_0, afm A_1)
	{
		if (A_1.b() == eoo.b)
		{
			if (this.b.aij() != null)
			{
				this.b.ain(A_1.a());
				return;
			}
			bad bad = this.aln(A_1.a());
			if (bad != null && bad.io() && bad.a(A_1.a()))
			{
				this.c.lj(bad);
				return;
			}
		}
		else if (A_1.b() == eoo.d && !this.amd())
		{
			this.c(null);
		}
	}

	// Token: 0x060025C3 RID: 9667 RVA: 0x000D7364 File Offset: 0x000D5564
	private void a(object A_0, a3x A_1)
	{
		if (A_1.b() == eoo.b)
		{
			bad bad;
			if (this.b.aij() == null)
			{
				bad = this.aln(A_1.a());
				if (bad != null && bad.io() && bad.a(A_1.a()))
				{
					this.c.lj(bad);
				}
			}
			else
			{
				bad = this.b.aij();
				this.b.ain(A_1.a());
			}
			if (bad != null)
			{
				c5x c5x = A_1.a() as c5x;
				if (c5x != null && dka.b(c5x))
				{
					cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
					if (serviceOrThrow.aq1().b().b() == AutoSelectOption.Always || (this.an == null && serviceOrThrow.aq1().b().b() == AutoSelectOption.NoneSelected))
					{
						this.c(c5x);
						return;
					}
				}
			}
		}
		else if (A_1.b() == eoo.d)
		{
			c5x c5x2 = A_1.a() as c5x;
			if (c5x2.s.b != null)
			{
				avd[] array = c5x2.s.b.jz();
				if (array != null && array.Length != 0)
				{
					MouseState state = Mouse.GetState();
					bc.a(this.d, this.d.n(), c5x2.s.b, new Point(state.X, state.Y));
					return;
				}
			}
			if (!this.amd())
			{
				this.c(c5x2);
			}
		}
	}

	// Token: 0x060025C4 RID: 9668 RVA: 0x000D74EC File Offset: 0x000D56EC
	private void a(object A_0, b25 A_1)
	{
		this.amd();
	}

	// Token: 0x060025C5 RID: 9669 RVA: 0x000D74F8 File Offset: 0x000D56F8
	private void c(object A_0, dtl A_1)
	{
		this.h();
	}

	// Token: 0x060025C6 RID: 9670 RVA: 0x000D7500 File Offset: 0x000D5700
	private void b(object A_0, dtl A_1)
	{
		this.h();
	}

	// Token: 0x060025C7 RID: 9671 RVA: 0x000D7508 File Offset: 0x000D5708
	private void a(object A_0, dtl A_1)
	{
		this.h();
	}

	// Token: 0x060025C8 RID: 9672 RVA: 0x000D7514 File Offset: 0x000D5714
	private void b(object A_0, ane A_1)
	{
		this.d.q().at = d1o.a(Hotkey.ScrollUp);
		this.d.q().au = d1o.a(Hotkey.ScrollDown);
		this.d.q().av = d1o.a(Hotkey.ScrollLeft);
		this.d.q().aw = d1o.a(Hotkey.ScrollRight);
		this.d.q().a(A_1, false);
		if (this.alg())
		{
			return;
		}
		Keys keys = A_1.a;
		if (this.d.n().Enabled && this.d.n().Visible)
		{
			for (int i = 1; i <= 9; i++)
			{
				if (A_1.a == d1o.a((Hotkey)10 + i))
				{
					this.d.n().d(i);
				}
			}
			for (int j = 1; j <= 6; j++)
			{
				if (A_1.a == d1o.a((Hotkey)20 + j))
				{
					this.d.n().f(j - 1);
				}
			}
			if (A_1.a == d1o.a(Hotkey.ToggleShield))
			{
				cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
				if (serviceOrThrow.aqu().v() != null && !serviceOrThrow.aqu().v().Dead)
				{
					this.d.n().r.ArtificiallyPressed = false;
					return;
				}
			}
			else if (A_1.a == d1o.a(Hotkey.RechargeShield))
			{
				cnk serviceOrThrow2 = bpo.GetServiceOrThrow<cnk>();
				if (serviceOrThrow2.aqu().v() != null && !serviceOrThrow2.aqu().v().Dead)
				{
					this.d.n().s.ArtificiallyPressed = false;
				}
			}
		}
	}

	// Token: 0x060025C9 RID: 9673 RVA: 0x000D76E0 File Offset: 0x000D58E0
	private void a(object A_0, ane A_1)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		this.d.q().at = d1o.a(Hotkey.ScrollUp);
		this.d.q().au = d1o.a(Hotkey.ScrollDown);
		this.d.q().av = d1o.a(Hotkey.ScrollLeft);
		this.d.q().aw = d1o.a(Hotkey.ScrollRight);
		this.d.q().a(A_1, true);
		if (this.g.j())
		{
			if (A_1.a == Keys.Escape)
			{
				this.e();
			}
			return;
		}
		if (A_1.a == Keys.OemTilde)
		{
			this.d.k();
		}
		if (A_1.a == Keys.Escape)
		{
			this.e();
			return;
		}
		if (A_1.a == d1o.a(Hotkey.QuickLoad) && serviceOrThrow.arl("quicksave"))
		{
			a3r a3r = serviceOrThrow.ark();
			if (a3r != null)
			{
				bpo.GetServiceOrThrow<d4m>().avp(dla.a(TimelapseWorkflows.LoadGameFromLocale, new object[]
				{
					a3r
				}));
				return;
			}
		}
		if (this.alg())
		{
			return;
		}
		if (A_1.a == d1o.a(Hotkey.HelpScreen))
		{
			this.ama();
		}
		else if (A_1.a == d1o.a(Hotkey.QuickSave))
		{
			if (serviceOrThrow.arh())
			{
				bpo.GetServiceOrThrow<d4m>().avp(dla.a(TimelapseWorkflows.SaveGame, new object[]
				{
					"quicksave",
					null,
					serviceOrThrow.aq1().d().b()
				}));
			}
			else
			{
				a7v.a(new h0("Вы не можете сохранить игру сейчас.", new Color?(adi.l)));
			}
		}
		Keys keys = A_1.a;
		if (this.d.n().Enabled && this.d.n().Visible)
		{
			for (int i = 1; i <= 9; i++)
			{
				if (A_1.a == d1o.a((Hotkey)10 + i))
				{
					this.d.n().c(i);
				}
			}
			for (int j = 1; j <= 6; j++)
			{
				if (A_1.a == d1o.a((Hotkey)20 + j))
				{
					this.d.n().e(j - 1);
				}
			}
			if (A_1.a == d1o.a(Hotkey.ToggleShield))
			{
				if (serviceOrThrow.aqu().v() != null && !serviceOrThrow.aqu().v().Dead)
				{
					this.d.n().r.ArtificiallyPressed = true;
				}
			}
			else if (A_1.a == d1o.a(Hotkey.RechargeShield) && serviceOrThrow.aqu().v() != null && !serviceOrThrow.aqu().v().Dead)
			{
				this.d.n().s.ArtificiallyPressed = true;
			}
		}
		if (A_1.b.Contains(Keys.LeftControl) || A_1.b.Contains(Keys.RightControl))
		{
			if (A_1.a == Keys.L && this.ac().n().Visible && this.ac().n().Enabled)
			{
				this.ac().n().l().a(eoo.b);
				return;
			}
			if (A_1.a == Keys.P && this.ac().n().Visible && this.ac().n().Enabled)
			{
				this.ac().n().j().a(eoo.b);
				return;
			}
		}
		else if (A_1.a == d1o.a(Hotkey.EndTurn))
		{
			d02 service = bpo.GetService<d02>();
			if (service != null && service.ahg() && service.ahe() != null && service.ahi() == bh3.b && service.ahe().b != null && service.ahe().b.aa() is e3q)
			{
				e4z.j();
				if (!service.ahs(true, true))
				{
					service.ahq(service.ahe(), true, true, true, null, true);
					return;
				}
			}
		}
		else if (A_1.a == d1o.a(Hotkey.EndCombat))
		{
			d02 service2 = bpo.GetService<d02>();
			if (service2 != null)
			{
				if (service2.ahg())
				{
					service2.ahs(false, false);
					return;
				}
				if (service2.ahj() > 0.0)
				{
					a7v.a(new vr(null, null, "Нельзя начать пошаговый бой так скоро.", new Color?(adi.l), null));
					return;
				}
				e4z.j();
				if (serviceOrThrow.aqu() != null && serviceOrThrow.aqu().v() != null)
				{
					c5x c5x = serviceOrThrow.aqu().v().b() as c5x;
					if (c5x != null && c5x.h.b != null)
					{
						service2.ahn(c5x.h.b, true);
						return;
					}
				}
			}
		}
		else if (A_1.a == d1o.a(Hotkey.TakeAll))
		{
			if (this.e.j())
			{
				e4z.a("ButtonPressed", 1f);
				this.e.b();
				return;
			}
			if (this.n.j())
			{
				e4z.a("ButtonPressed", 1f);
				this.n.b();
				return;
			}
		}
		else
		{
			if (A_1.a == d1o.a(Hotkey.QuickInvoker))
			{
				this.alu();
				return;
			}
			if (A_1.a == d1o.a(Hotkey.CombatStatsOverview))
			{
				this.aa();
				return;
			}
			if (A_1.a == d1o.a(Hotkey.CraftingWindow) && serviceOrThrow.aqu() != null && serviceOrThrow.aqu().v() != null && !serviceOrThrow.aqu().v().b(d8o.t))
			{
				this.v();
				return;
			}
			if (A_1.a == d1o.a(Hotkey.CharacterSheet))
			{
				this.al3();
				return;
			}
			if (A_1.a == d1o.a(Hotkey.Inventory))
			{
				this.w();
				return;
			}
			if (A_1.a == d1o.a(Hotkey.Notes))
			{
				this.af();
				return;
			}
			if (A_1.a == d1o.a(Hotkey.OdditiesWindow))
			{
				this.t();
				return;
			}
			if (dk2.f() && A_1.a == d1o.a(Hotkey.VehicleWindow))
			{
				this.s();
				return;
			}
			if (dm9.f && A_1.a == d1o.a(Hotkey.Psi) && serviceOrThrow.aqu() != null && serviceOrThrow.aqu().v() != null && serviceOrThrow.aqu().v().PsiAbilities.a() > 0)
			{
				this.r();
				return;
			}
			if (A_1.a == d1o.a(Hotkey.GlobalMapWindow))
			{
				this.aj();
				return;
			}
			if (A_1.a == d1o.a(Hotkey.ToggleHUD))
			{
				this.amj();
				return;
			}
			if (A_1.a == d1o.a(Hotkey.SwapWeapon))
			{
				if (this.ac().n().Visible && this.ac().n().Enabled && serviceOrThrow.aqu().v() != null && !serviceOrThrow.aqu().v().Dead)
				{
					serviceOrThrow.aqu().v().Offense.k();
					return;
				}
			}
			else if (A_1.a == d1o.a(Hotkey.SpeedUp))
			{
				if (!dz6.e())
				{
					this.ac().l().a(true);
					return;
				}
			}
			else if (A_1.a == d1o.a(Hotkey.SlowDown))
			{
				if (!dz6.e())
				{
					this.ac().l().b(true);
					return;
				}
			}
			else if (A_1.a == d1o.a(Hotkey.ToggleFollowPlayer) && !this.alk() && !this.ak4())
			{
				this.a();
			}
		}
	}

	// Token: 0x060025CA RID: 9674 RVA: 0x000D7F00 File Offset: 0x000D6100
	private void a()
	{
		dka.aw = !dka.aw;
	}

	// Token: 0x060025CB RID: 9675 RVA: 0x000D7F10 File Offset: 0x000D6110
	private void a(e6d A_0)
	{
		if (this.ac() != null && this.ac().q() != null && this.ac().q().an9() != null)
		{
			cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
			this.ac().q().d.c(true);
			this.ac().q().d.a(serviceOrThrow.aq1().e().d());
			this.ac().q().a(serviceOrThrow.aq1().e().f());
			if (this.akx() != null)
			{
				if (dka.aw && !this.alk() && this.j.i() != y5.c && this.j.i() != y5.d && serviceOrThrow.aqu() != null && serviceOrThrow.aqu().v() != null && serviceOrThrow.aqu().v().b() != null && serviceOrThrow.aqu().v().b().Area == this.ac().q().anz() && A_0.b().RightButton != ButtonState.Pressed)
				{
					if (this.akx().aev() == null || this.akx().aev() == serviceOrThrow.aqu().v().b())
					{
						float num = Vector2.Distance(serviceOrThrow.aqu().v().b().aj().b(), this.ac().q().an9().t1().b()) / 3f;
						num = Convert.ToSingle(Math.Sqrt((double)num));
						num = d05.b(0.1f, num, 100f);
						float a_ = num * 6f;
						this.akx().ae0(serviceOrThrow.aqu().v().b(), a_, false);
						this.ac().q().d.c(false);
						this.ac().q().d.a(false);
						this.ac().q().a(false);
						return;
					}
				}
				else if (this.akx().aev() == serviceOrThrow.aqu().v().b())
				{
					this.akx().ae1();
				}
			}
		}
	}

	// Token: 0x060025CC RID: 9676 RVA: 0x000D817C File Offset: 0x000D637C
	private void a(object A_0, EventArgs A_1)
	{
		this.s.ad();
	}

	// Token: 0x04001594 RID: 5524
	private const int a = 2000;

	// Token: 0x04001595 RID: 5525
	private cv4 b;

	// Token: 0x04001596 RID: 5526
	private tf c;

	// Token: 0x04001597 RID: 5527
	private ci3 d;

	// Token: 0x04001598 RID: 5528
	private aiq e;

	// Token: 0x04001599 RID: 5529
	private d7a f;

	// Token: 0x0400159A RID: 5530
	private e26 g;

	// Token: 0x0400159B RID: 5531
	private b59 h;

	// Token: 0x0400159C RID: 5532
	private cr8 i;

	// Token: 0x0400159D RID: 5533
	private zq j;

	// Token: 0x0400159E RID: 5534
	private b88 k;

	// Token: 0x0400159F RID: 5535
	private evf l;

	// Token: 0x040015A0 RID: 5536
	private ekd m;

	// Token: 0x040015A1 RID: 5537
	private bd2 n;

	// Token: 0x040015A2 RID: 5538
	private dkq o;

	// Token: 0x040015A3 RID: 5539
	private agw p;

	// Token: 0x040015A4 RID: 5540
	private c23 q;

	// Token: 0x040015A5 RID: 5541
	private bes r;

	// Token: 0x040015A6 RID: 5542
	private bis s;

	// Token: 0x040015A7 RID: 5543
	private efc t;

	// Token: 0x040015A8 RID: 5544
	private ebm u;

	// Token: 0x040015A9 RID: 5545
	private c4b v;

	// Token: 0x040015AA RID: 5546
	private btd w;

	// Token: 0x040015AB RID: 5547
	private cac x;

	// Token: 0x040015AC RID: 5548
	private a96 y;

	// Token: 0x040015AD RID: 5549
	private b8t z;

	// Token: 0x040015AE RID: 5550
	private int aa;

	// Token: 0x040015AF RID: 5551
	private bool ab;

	// Token: 0x040015B0 RID: 5552
	private int ac;

	// Token: 0x040015B1 RID: 5553
	private int ad;

	// Token: 0x040015B2 RID: 5554
	private bool ae;

	// Token: 0x040015B3 RID: 5555
	private bool af;

	// Token: 0x040015B4 RID: 5556
	private int ag;

	// Token: 0x040015B5 RID: 5557
	private int ah;

	// Token: 0x040015B6 RID: 5558
	private int ai;

	// Token: 0x040015B7 RID: 5559
	private b0b aj;

	// Token: 0x040015B8 RID: 5560
	private List<KeyValuePair<Type, b61>> ak;

	// Token: 0x040015B9 RID: 5561
	private double al = -1.0;

	// Token: 0x040015BA RID: 5562
	private ebk am;

	// Token: 0x040015BB RID: 5563
	private c5x an;

	// Token: 0x040015BC RID: 5564
	private double ao;

	// Token: 0x040015BD RID: 5565
	private bg3 ap;

	// Token: 0x040015BE RID: 5566
	private eu7 aq;

	// Token: 0x040015BF RID: 5567
	private bool ar;

	// Token: 0x040015C0 RID: 5568
	private double @as;

	// Token: 0x040015C1 RID: 5569
	private Queue<double> at;

	// Token: 0x040015C2 RID: 5570
	private c5x au;

	// Token: 0x040015C3 RID: 5571
	private bool av;

	// Token: 0x040015C4 RID: 5572
	private static bool aw;

	// Token: 0x0200059B RID: 1435
	private class a : eyp
	{
		// Token: 0x06002631 RID: 9777 RVA: 0x000D818C File Offset: 0x000D638C
		public a(dka A_0)
		{
			this.a = A_0;
		}

		// Token: 0x06002632 RID: 9778 RVA: 0x000D81A0 File Offset: 0x000D63A0
		public void g0(string A_0)
		{
			if (A_0 == "L")
			{
				arv arv = new arv(SavedGameManipulationMode.Load, abx.b);
				arv.Gravity = axy.c;
				arv.b();
				bpo.GetServiceOrThrow<bcm>().aau().aox(arv);
				arv.a(new EventHandler<el5>(this.a));
				return;
			}
			if (A_0 == "R")
			{
				this.a();
				return;
			}
			this.a.g.avt();
		}

		// Token: 0x06002633 RID: 9779 RVA: 0x000D8220 File Offset: 0x000D6420
		private void a()
		{
			a3r a3r = bpo.GetServiceOrThrow<cnk>().arj();
			if (a3r != null && !ast.a(a3r.GameVersion, a3r.DLCs))
			{
				bpo.GetServiceOrThrow<d4m>().avp(dla.a(TimelapseWorkflows.LoadGameFromLocale, new object[]
				{
					a3r
				}));
			}
		}

		// Token: 0x06002634 RID: 9780 RVA: 0x000D8270 File Offset: 0x000D6470
		private void a(object A_0, el5 A_1)
		{
			this.a.anj();
		}

		// Token: 0x040015C5 RID: 5573
		private dka a;
	}
}

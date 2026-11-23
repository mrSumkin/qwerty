using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Ouroboros.Playfield.Lightning;
using Ouroboros.Playfield.Space;
using TimelapseVertigo.Rules;
using TimelapseVertigo.Rules.Characters;
using TimelapseVertigo.Rules.Items;

// Token: 0x02000BB4 RID: 2996
[euj]
public class aow
{
	// Token: 0x06004425 RID: 17445 RVA: 0x001AF758 File Offset: 0x001AD958
	[ayh("XPHWEBJIVB")]
	public void i(c5x A_0, c5x A_1, Dictionary<string, object> A_2)
	{
		this.d();
	}

	// Token: 0x06004426 RID: 17446 RVA: 0x001AF760 File Offset: 0x001AD960
	[ayh("XPHWEBJIVOSP")]
	public void ab(c5x A_0, c5x A_1, Dictionary<string, object> A_2)
	{
		this.a();
	}

	// Token: 0x06004427 RID: 17447 RVA: 0x001AF768 File Offset: 0x001AD968
	[ayh("XPHWEBJIVMETN")]
	public void s(c5x A_0, c5x A_1, Dictionary<string, object> A_2)
	{
		this.a("north", false);
	}

	// Token: 0x06004428 RID: 17448 RVA: 0x001AF778 File Offset: 0x001AD978
	[ayh("XPHWEBJIVMETE")]
	public void e(c5x A_0, c5x A_1, Dictionary<string, object> A_2)
	{
		this.a("east", false);
	}

	// Token: 0x06004429 RID: 17449 RVA: 0x001AF788 File Offset: 0x001AD988
	[ayh("XPHWEBJIVMETS")]
	public void c(c5x A_0, c5x A_1, Dictionary<string, object> A_2)
	{
		this.a("south", false);
	}

	// Token: 0x0600442A RID: 17450 RVA: 0x001AF798 File Offset: 0x001AD998
	[ayh("XPHWEBJIVMETW")]
	public void p(c5x A_0, c5x A_1, Dictionary<string, object> A_2)
	{
		this.a("west", false);
	}

	// Token: 0x0600442B RID: 17451 RVA: 0x001AF7A8 File Offset: 0x001AD9A8
	[ayh("XPHWEBJCETR")]
	public void w(c5x A_0, c5x A_1, Dictionary<string, object> A_2)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null)
		{
			c5x c5x = serviceOrThrow.aqu().v().b() as c5x;
			if (c5x != null)
			{
				c5x a_ = new ar7(new Guid("114ee4b2-9d26-4a2d-b2e5-e547ebced2d7"), c5x.Area).ao() as c5x;
				this.a(a_);
			}
		}
	}

	// Token: 0x0600442C RID: 17452 RVA: 0x001AF80C File Offset: 0x001ADA0C
	[ayh("XPHWEBJPNAF")]
	public void y(c5x A_0, c5x A_1, Dictionary<string, object> A_2)
	{
		if (A_1 != null)
		{
			this.a(A_1, new bool?(false));
		}
	}

	// Token: 0x0600442D RID: 17453 RVA: 0x001AF824 File Offset: 0x001ADA24
	[ayh("XPHWEBJTCS")]
	public void x(c5x A_0, c5x A_1, Dictionary<string, object> A_2)
	{
		el3 el = new el3();
		el.b(new HorizontalDirection?(HorizontalDirection.North));
		el.b("med3");
		el.ym(A_0, A_1, A_2);
		el.b("sol13");
		el.ym(A_0, A_1, A_2);
		el.b("sol14");
		el.ym(A_0, A_1, A_2);
		el.b("sol15");
		el.ym(A_0, A_1, A_2);
		el.b("int2");
		el.ym(A_0, A_1, A_2);
	}

	// Token: 0x0600442E RID: 17454 RVA: 0x001AF8A8 File Offset: 0x001ADAA8
	[ayh("XPHWEBJST")]
	public void v(c5x A_0, c5x A_1, Dictionary<string, object> A_2)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null)
		{
			b6r b6r = new b6r();
			b6r.b(new Guid("d111cfb3-3946-48e7-822d-9089e89b8168"));
			b6r.a(new Guid("d5b79115-5b19-4af4-b2a1-2f0f6fa822cf"));
			b6r.a(bbo.c);
			b6r.b("xphw_exobase_trg1");
			b6r.ym(A_0, A_1, A_2);
			this.b();
			this.n(A_0, A_1, A_2);
			serviceOrThrow.aqu().r()["loc_xphw_exobase_trainingGroundStarted"] = true;
		}
	}

	// Token: 0x0600442F RID: 17455 RVA: 0x001AF930 File Offset: 0x001ADB30
	[ayh("XPHWEBJDMC")]
	public void l(c5x A_0, c5x A_1, Dictionary<string, object> A_2)
	{
		this.b();
	}

	// Token: 0x06004430 RID: 17456 RVA: 0x001AF93C File Offset: 0x001ADB3C
	[ayh("XPHWEBIAL")]
	public void r(c5x A_0, c5x A_1, Dictionary<string, object> A_2)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null && !serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("faction_xphw_exoBase_exosoldiers_stopDeployment", new bool?(false)).Value)
		{
			float value = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<float>("faction_xphw_exoBase_alarmLevel", new float?((float)1)).Value;
			serviceOrThrow.aqu().r()["faction_xphw_exoBase_alarmLevel"] = Math.Min(5f, value + 1f);
		}
	}

	// Token: 0x06004431 RID: 17457 RVA: 0x001AF9D4 File Offset: 0x001ADBD4
	[ayh("XPHWEBEACS")]
	public void t(c5x A_0, c5x A_1, Dictionary<string, object> A_2)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null && serviceOrThrow.aqw() != null)
		{
			d60 d = serviceOrThrow.aqw().a();
			if (d != null)
			{
				c5x c5x = Enumerable.FirstOrDefault<b0b>(d.ab4(new string[]
				{
					"exoass_machine"
				})) as c5x;
				if (c5x != null)
				{
					ny aspect = c5x.GetAspect<ny>();
					if (aspect != null)
					{
						int a_ = 80;
						string text = "Objects\\Devices\\xphw_exomachine";
						awx awx = new awx();
						awx awx2 = awx;
						awx2.a(awx2.kh() | m7.b);
						List<auv> list = awx.ad();
						bi5 bi = new bi5();
						bi.a(new int?(0));
						bi.a(text + "_scan");
						bi.f(true);
						list.Add(new a4s(bi, null, new ar7(c5x), null));
						List<auv> list2 = awx.ad();
						bi5 bi2 = new bi5();
						bi2.a(new int?(1));
						bi2.a(new float?((float)1));
						bi2.a(true);
						list2.Add(new a4s(bi2, null, new ar7(c5x), null));
						List<auv> list3 = awx.ad();
						bfq bfq = new bfq(Guid.NewGuid().ToString(), "Xphw_ExoAssembly_ScanBeep");
						bfq.a(1f);
						list3.Add(new a4s(bfq, null, new ar7(c5x), null));
						List<auv> list4 = awx.ad();
						bfq bfq2 = new bfq(Guid.NewGuid().ToString(), "Xphw_ExoAssembly_ScanHydraulic");
						bfq2.a(1f);
						list4.Add(new a4s(bfq2, null, new ar7(c5x), null));
						for (int i = 0; i <= 8; i++)
						{
							List<auv> list5 = awx.ad();
							bi5 bi3 = new bi5();
							bi3.a(new int?(0));
							bi3.b(true);
							bi3.b(i);
							list5.Add(new a4s(bi3, null, new ar7(c5x), null));
							List<auv> list6 = awx.ad();
							bi5 bi4 = new bi5();
							bi4.a(new int?(1));
							bi4.b(true);
							bi4.b(i);
							list6.Add(new a4s(bi4, null, new ar7(c5x), null));
							awx.ad().Add(new bm3(a_));
						}
						List<auv> list7 = awx.ad();
						bi5 bi5 = new bi5();
						bi5.a(new int?(0));
						bi5.b(true);
						bi5.b(0);
						list7.Add(new a4s(bi5, null, new ar7(c5x), null));
						List<auv> list8 = awx.ad();
						bi5 bi6 = new bi5();
						bi6.a(new int?(1));
						bi6.b(true);
						bi6.b(0);
						list8.Add(new a4s(bi6, null, new ar7(c5x), null));
						List<auv> list9 = awx.ad();
						bi5 bi7 = new bi5();
						bi7.a(new int?(0));
						bi7.a(text);
						bi7.f(true);
						list9.Add(new a4s(bi7, null, new ar7(c5x), null));
						List<auv> list10 = awx.ad();
						bi5 bi8 = new bi5();
						bi8.a(new int?(1));
						bi8.a(new float?(0f));
						bi8.a(true);
						list10.Add(new a4s(bi8, null, new ar7(c5x), null));
						aspect.a(awx, atp.a, true, true);
					}
				}
			}
		}
	}

	// Token: 0x06004432 RID: 17458 RVA: 0x001AFCF8 File Offset: 0x001ADEF8
	[ayh("XPHWEBJETG")]
	public void g(c5x A_0, c5x A_1, Dictionary<string, object> A_2)
	{
		foreach (d4n d4n in Enumerable.ToList<d4n>(bpo.GetService<d02>().ahl()))
		{
			if (d4n.b != null && d4n.b.a8() != null && !d4n.b.aa().Dead && d4n.b.aa().FactionId.Contains("exoBase"))
			{
				return;
			}
		}
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null && !serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("loc_xphw_exobase_trainingGroundEnded", new bool?(false)).Value)
		{
			b6r b6r = new b6r();
			b6r.b(new Guid("740242b2-7d70-4d85-a1fe-5d3f2f149644"));
			b6r.a(new Guid("bd833963-e0a1-4622-9767-ddd25a99a2ec"));
			b6r.a(bbo.b);
			b6r.b("xphw_exobase_trg1");
			b6r.ym(A_0, A_1, A_2);
			b6r b6r2 = new b6r();
			b6r2.b(new Guid("d111cfb3-3946-48e7-822d-9089e89b8168"));
			b6r2.a(new Guid("d5b79115-5b19-4af4-b2a1-2f0f6fa822cf"));
			b6r2.a(bbo.b);
			b6r2.b("xphw_exobase_trg1");
			b6r2.ym(A_0, A_1, A_2);
			this.a(new List<string>
			{
				"south",
				"east",
				"west",
				"north"
			}, true);
			serviceOrThrow.aqu().r()["loc_xphw_exobase_trainingGroundEnded"] = true;
			c5x c5x = serviceOrThrow.aqu().v().b() as c5x;
			if (c5x != null)
			{
				c5x.c().a("PrisonAlarm");
			}
		}
	}

	// Token: 0x06004433 RID: 17459 RVA: 0x001AFEE4 File Offset: 0x001AE0E4
	[ayh("XPHWEBJLWLS")]
	public void n(c5x A_0, c5x A_1, Dictionary<string, object> A_2)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null)
		{
			d60 d = serviceOrThrow.aqw().a();
			if (d != null)
			{
				c5x c5x = Enumerable.FirstOrDefault<b0b>(d.ab4(new string[]
				{
					"data"
				})) as c5x;
				if (c5x != null)
				{
					if (c5x.a("north"))
					{
						this.a(new List<string>
						{
							"north"
						}, false);
					}
					if (c5x.a("east"))
					{
						this.a(new List<string>
						{
							"east"
						}, false);
					}
					if (c5x.a("west"))
					{
						this.a(new List<string>
						{
							"west"
						}, false);
					}
					if (c5x.a("south"))
					{
						this.a(new List<string>
						{
							"south"
						}, false);
					}
				}
			}
		}
	}

	// Token: 0x06004434 RID: 17460 RVA: 0x001AFFD8 File Offset: 0x001AE1D8
	[ayh("XPHWEBJTEST")]
	public void b(c5x A_0, c5x A_1, Dictionary<string, object> A_2)
	{
		cnk service = bpo.GetService<cnk>();
		if (service.aqu() != null)
		{
			d60 d = service.aqw().a();
			if (d != null)
			{
				string a_ = null;
				List<b0b> list = d.ab4(new string[]
				{
					"SquadName_Andromeda-0"
				});
				if (list != null && Enumerable.Any<b0b>(list))
				{
					a_ = dqp.c(Enumerable.FirstOrDefault<b0b>(list) as c5x);
					foreach (b0b b0b in list)
					{
						b0b.w();
						b0b.an();
					}
					dqp.a(list, a_, service.aqw().y8());
				}
				list = dqp.a(1, service.aqw().y8(), true);
				if (list != null && Enumerable.Any<b0b>(list))
				{
					int num = 0;
					string str = "deploy_trg_1_";
					foreach (b0b b0b2 in list)
					{
						csd csd = service.aqw().g(str + num++.ToString());
						if (csd != null)
						{
							b0b2.Location = csd.Location;
							b0b2.Layer = aju.x;
							b0b2.VisualDirection = csd.Direction;
							csd.Area.a(b0b2);
						}
					}
				}
			}
		}
	}

	// Token: 0x06004435 RID: 17461 RVA: 0x001B016C File Offset: 0x001AE36C
	[ayh("XPHWEBSSJP")]
	public void o(c5x A_0, c5x A_1, Dictionary<string, object> A_2)
	{
		cnk service = bpo.GetService<cnk>();
		object value;
		if (service.aqu() != null && A_2 != null && A_2.TryGetValue("Study", out value) && Convert.ToInt32(value) <= 1)
		{
			service.aqu().r()["loc_xphw_exoBase_knowSkulljackPattern"] = true;
		}
	}

	// Token: 0x06004436 RID: 17462 RVA: 0x001B01CC File Offset: 0x001AE3CC
	[ayh("XPHWEBJESAP")]
	public void m(c5x A_0, c5x A_1, Dictionary<string, object> A_2)
	{
		if (A_0 == null || A_2 == null)
		{
			return;
		}
		object obj;
		object obj2;
		if (A_2.TryGetValue("dialog", out obj) && obj is azm && A_2.TryGetValue("node", out obj2))
		{
			ad7 ad = obj2 as ad7;
			if (ad != null)
			{
				foreach (atr atr in ad.PossibleAnswers)
				{
					if (atr.Name.Contains("Exoskeleton") && !atr.d() && atr.c() == null)
					{
						int num = atr.Name.LastIndexOf(':');
						c8d c8d = new c8d(new LibraryItemDefinitionProvider<c43>(("Armor\\Xphw\\" + atr.Name.Substring(0, num + 1)).Replace(" ", "").Replace(":", "")));
						if (c8d != null && !string.IsNullOrEmpty(c8d.Definition.az()) && !c8d.Definition.az().Contains("Unknown"))
						{
							atr.a(c8d);
						}
					}
				}
			}
		}
	}

	// Token: 0x06004437 RID: 17463 RVA: 0x001B032C File Offset: 0x001AE52C
	[ayh("XPHWEBJULDD")]
	public void k(c5x A_0, c5x A_1, Dictionary<string, object> A_2)
	{
		if (A_1 != null)
		{
			cnb cnb = A_1.GetAspect<bim>() as cnb;
			if (cnb != null && cnb.b() != null)
			{
				c5x c5x = new ar7(cnb.b().Value, A_1.Area).ao() as c5x;
				if (c5x != null)
				{
					d2b aspect = c5x.GetAspect<d2b>();
					if (aspect != null && aspect.n())
					{
						aspect.e(false);
					}
				}
			}
		}
	}

	// Token: 0x06004438 RID: 17464 RVA: 0x001B03B0 File Offset: 0x001AE5B0
	[ayh("XPHWEBJDCSPC")]
	public void j(c5x A_0, c5x A_1, Dictionary<string, object> A_2)
	{
		if (A_0 != null && A_0.IsPlayer && !d8s.b() && A_0.h.b != null && A_1 != null)
		{
			int num = 15;
			if (c2h.c(A_0.h.b.aa()) >= num)
			{
				a7v.a(new aqt("Shelf Back Panel Missing"));
				bmj.a(A_1, new d53("У этой полки нет задней стенки. Вы можете просто протиснуться.", adi.g, null, false));
				A_0.c();
				A_0.v.b.a("reveal", "DarkSecretReveal", 1f, c9z.a, false, false);
				int num2 = c2h.c(num, c2h.d(A_0.h.b.aa()));
				if (num2 > 0)
				{
					e3q e3q = A_0.h.b.aa() as e3q;
					if (e3q != null && e3q.e() == ExperienceSystem.Classic)
					{
						e3q.c(num2);
					}
					cxc.a(eyy.bp);
				}
				A_1.q("Протиснуться");
				c7j c7j = A_1.GetAspect<bim>() as c7j;
				if (c7j != null)
				{
					if (Enumerable.Any<coh>(c7j.ItemContainer.z2()))
					{
						foreach (coh a_ in Enumerable.ToList<coh>(c7j.ItemContainer.z2()))
						{
							c7j.ItemContainer.z5(a_);
							A_0.h.b.aa().Bag.z3(a_, false);
						}
					}
					A_1.RemoveAspect<c7j>();
				}
				bim bim = new bim(A_1);
				List<cze> list = bim.s();
				bfq bfq = new bfq();
				bfq.a(bvl.c);
				bfq.b("use");
				bfq.a(true);
				bfq.c("Xphw_ExoBoxShelf_Open");
				list.Add(bfq);
				List<cze> list2 = bim.s();
				cr5 cr = new cr5();
				cr.a(new List<HorizontalDirection>
				{
					HorizontalDirection.South,
					HorizontalDirection.Southeast,
					HorizontalDirection.Southwest
				});
				cr.a(new be6
				{
					OverrideTargetArea = A_0.Area.y8(),
					OverrideTargetId = new Guid?(A_0.qe()),
					DestinationWaypoint = "ElectronicShelfInside"
				});
				list2.Add(cr);
				List<cze> list3 = bim.s();
				cr5 cr2 = new cr5();
				cr2.a(new List<HorizontalDirection>
				{
					HorizontalDirection.North,
					HorizontalDirection.Northeast,
					HorizontalDirection.Northwest
				});
				cr2.a(new be6
				{
					OverrideTargetArea = A_0.Area.y8(),
					OverrideTargetId = new Guid?(A_0.qe()),
					DestinationWaypoint = "ElectronicShelfOutside"
				});
				list3.Add(cr2);
				bim.a(new List<HorizontalDirection>
				{
					HorizontalDirection.North,
					HorizontalDirection.South
				});
				A_1.SetAspect<bim>(bim);
			}
		}
	}

	// Token: 0x06004439 RID: 17465 RVA: 0x001B06A0 File Offset: 0x001AE8A0
	[ayh("XPHWEBJUL1CR")]
	public void z(c5x A_0, c5x A_1, Dictionary<string, object> A_2)
	{
		cnk service = bpo.GetService<cnk>();
		if (service.aqu() != null)
		{
			d60 addon = service.aqw().GetAddon<d60>();
			if (addon != null)
			{
				foreach (b0b b0b in addon.ab4(new string[]
				{
					"controlRoomDoors"
				}))
				{
					d2b aspect = b0b.GetAspect<d2b>();
					if (aspect != null && aspect.n())
					{
						aspect.e(false);
					}
					cnb cnb = b0b.GetAspect<bim>() as cnb;
					if (cnb != null)
					{
						cnb.d(true);
					}
				}
			}
			bfq bfq = new bfq();
			bfq.c("UnlockMech");
			bfq.a(bvl.d);
			bfq.ym(null, null, null);
			b6r b6r = new b6r();
			b6r.a(bbo.b);
			b6r.b(service.aqw().n("xphw_exobase_lab1").y8());
			b6r.a(false);
			b6r.b(new Guid("e7038acb-8349-4738-8bbc-3df3b4c8317d"));
			b6r.a(new Guid("f4d2a0b0-ba2b-4194-885d-65b1804ca018"));
			b6r.ym(A_0, A_1, A_2);
		}
	}

	// Token: 0x0600443A RID: 17466 RVA: 0x001B07D4 File Offset: 0x001AE9D4
	[ayh("XPHWEBLTSDR")]
	public void q(c5x A_0, c5x A_1, Dictionary<string, object> A_2)
	{
		cnk service = bpo.GetService<cnk>();
		if (A_0 != null && A_0.h.b != null && !A_0.h.b.aa().FactionId.Contains("exoBase") && service.aqw() != null)
		{
			d60 d = service.aqw().a();
			if (d != null)
			{
				b0b b0b = Enumerable.FirstOrDefault<b0b>(d.ab4(new string[]
				{
					"securityDispatcher"
				}));
				if (b0b != null)
				{
					bja aspect = b0b.GetAspect<bja>();
					if (aspect != null)
					{
						aspect.d(new asf(Guid.NewGuid(), new bt4(A_0.Area.y8(), A_0.aj())));
					}
					a3f a3f = A_0.GetAspect<a3f>();
					if (a3f == null)
					{
						a3f = new a3f(A_1);
						A_1.SetAspect<a3f>(a3f);
					}
					TimeSpan? primitivePropertyValue = a3f.a().GetPrimitivePropertyValue<TimeSpan>("LaserBeep", null);
					if (primitivePropertyValue == null || primitivePropertyValue.Value <= service.aqu().p())
					{
						new bfq("alarm", "LaserTrapAlert").ym(A_0, A_1, A_2);
						a3f.a()["LaserBeep"] = service.aqu().p() + TimeSpan.FromSeconds(2.0);
					}
				}
			}
		}
	}

	// Token: 0x0600443B RID: 17467 RVA: 0x001B0940 File Offset: 0x001AEB40
	[ayh("XPHWEBSDRM")]
	public void d(c5x A_0, c5x A_1, Dictionary<string, object> A_2)
	{
		cnk service = bpo.GetService<cnk>();
		if (service.aqu() != null && A_0 != null)
		{
			a3f a3f = A_0.GetAspect<a3f>();
			if (a3f == null)
			{
				a3f = new a3f(A_0);
				A_0.SetAspect<a3f>(a3f);
			}
			if (!a3f.a().HasProperty("LastRequestTime") || service.aqu().p() >= a3f.a().GetPrimitivePropertyValue<TimeSpan>("LastRequestTime", null).Value + TimeSpan.FromSeconds(5.0))
			{
				this.r(A_0, A_1, A_2);
				a3f.a()["LastRequestTime"] = service.aqu().p();
				if (A_0.Zone.y8().EndsWith("lab1"))
				{
					dqp.a(service.aqw(), true);
				}
			}
		}
	}

	// Token: 0x0600443C RID: 17468 RVA: 0x001B0A30 File Offset: 0x001AEC30
	[ayh("XPHWEBUC")]
	public void f(c5x A_0, c5x A_1, Dictionary<string, object> A_2)
	{
		dqp.a(A_1);
	}

	// Token: 0x0600443D RID: 17469 RVA: 0x001B0A3C File Offset: 0x001AEC3C
	[ayh("XPHWEBCA")]
	public void a(c5x A_0, c5x A_1, Dictionary<string, object> A_2)
	{
		if (A_1 != null)
		{
			cwt cwt = A_2["attackResult"] as cwt;
			if (cwt != null && cwt.i != null && cwt.i.b == asp.a)
			{
				cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
				if (serviceOrThrow.aqu() != null)
				{
					bv9 bv = serviceOrThrow.aqu().ac() as bv9;
					if (bv != null)
					{
						cky cky = bv.abu(asp.go, asp.a);
						if (cky != null && cky.a != global::h.a)
						{
							bv.a(asp.go, asp.gs, global::h.a, null, true, false, false);
						}
					}
				}
			}
		}
	}

	// Token: 0x0600443E RID: 17470 RVA: 0x001B0AF4 File Offset: 0x001AECF4
	[ayh("XPHWUPSLAN")]
	public void u(c5x A_0, c5x A_1, Dictionary<string, object> A_2)
	{
		if (A_2 == null)
		{
			return;
		}
		object obj;
		if (A_2.TryGetValue("element", out obj))
		{
			atr atr = obj as atr;
			if (atr != null)
			{
				this.a(atr, "soldier", "sol");
				return;
			}
		}
	}

	// Token: 0x0600443F RID: 17471 RVA: 0x001B0B3C File Offset: 0x001AED3C
	[ayh("XPHWUPMEAN")]
	public void h(c5x A_0, c5x A_1, Dictionary<string, object> A_2)
	{
		if (A_2 == null)
		{
			return;
		}
		object obj;
		if (A_2.TryGetValue("element", out obj))
		{
			atr atr = obj as atr;
			if (atr != null)
			{
				this.a(atr, "medic", "med");
				return;
			}
		}
	}

	// Token: 0x06004440 RID: 17472 RVA: 0x001B0B84 File Offset: 0x001AED84
	private void a(atr A_0, string A_1, string A_2)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqw() == null)
		{
			return;
		}
		serviceOrThrow.aqw();
		d60 d = serviceOrThrow.aqw().a();
		if (d == null)
		{
			return;
		}
		string text = A_0.g();
		if (string.IsNullOrEmpty(text))
		{
			return;
		}
		string[] array = text.Split(new string[]
		{
			" ",
			".",
			"::"
		}, StringSplitOptions.RemoveEmptyEntries);
		for (int i = 0; i < array.Length; i++)
		{
			string a = array[i];
			if (a == A_1 || a == "Распределить" || a == "Перераспределить")
			{
				if (i < array.Length - 1)
				{
					c5x c5x = null;
					int num;
					if (int.TryParse(array[i + 1], out num))
					{
						c5x = (d.ab5(A_2 + num.ToString()) as c5x);
					}
					else
					{
						string text2 = array[i + 1];
						if (text2 == A_1)
						{
							goto IL_1E2;
						}
						foreach (b0b b0b in d.ab4(new string[]
						{
							A_2
						}))
						{
							c5x c5x2 = (c5x)b0b;
							if (c5x2.y8() == text2)
							{
								c5x = c5x2;
								break;
							}
						}
					}
					if (c5x != null)
					{
						a3f aspect = c5x.GetAspect<a3f>();
						if (aspect != null)
						{
							string classPropertyValue = aspect.a().GetClassPropertyValue<string>("position");
							string a_;
							if (string.IsNullOrEmpty(classPropertyValue) || classPropertyValue == "init")
							{
								a_ = string.Format("::Распределить {0}.::", c5x.y8());
							}
							else
							{
								a_ = string.Format("::Перераспределить {0} - распределён {1}.::", c5x.y8(), classPropertyValue);
							}
							A_0.b(a_);
						}
					}
				}
				return;
			}
			IL_1E2:;
		}
	}

	// Token: 0x06004441 RID: 17473 RVA: 0x001B0D94 File Offset: 0x001AEF94
	[ayh("XPHWTROEBR")]
	public void aa(c5x A_0, c5x A_1, Dictionary<string, object> A_2)
	{
		if (A_1 == null)
		{
			return;
		}
		bk2 aspect = A_1.GetAspect<bk2>();
		if (aspect != null)
		{
			aspect.a();
		}
	}

	// Token: 0x06004442 RID: 17474 RVA: 0x001B0DBC File Offset: 0x001AEFBC
	public void a(List<string> A_0, bool A_1 = false)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null)
		{
			d60 d = serviceOrThrow.aqw().a();
			if (d != null)
			{
				foreach (b0b b0b in d.ab2(A_0))
				{
					c5x c5x = (c5x)b0b;
					dm aspect = c5x.GetAspect<dm>();
					if (aspect != null)
					{
						if (!A_1)
						{
							if (!c5x.a("disabled") && !aspect.g())
							{
								if (serviceOrThrow.aqu().ae() <= GameDifficulty.Normal)
								{
									aspect.a(new int?(20000));
								}
								else if (serviceOrThrow.aqu().ae() == GameDifficulty.Hard)
								{
									aspect.a(new int?(15000));
								}
								else if (serviceOrThrow.aqu().ae() == GameDifficulty.Dominating)
								{
									aspect.a(new int?(10000));
								}
								aspect.b(true);
								c5x.b("disabled");
							}
							if (c5x.Zone.i(c5x.qe().ToString() + "_trainingLantern") == null)
							{
								ah7 ah = new ah7(c5x.qe().ToString() + "_trainingLantern", c5x.Zone);
								ah.Layer = c5x.Layer;
								ah.Light = new ae8(dyz.k, 1f, LightType.Increment);
								ah.LightFadeRate = 0.21f;
								ah.Range = 5f;
								c5x.Zone.a(ah);
								ah.g().be(c5x);
								ah.d();
								alv aspect2 = c5x.GetAspect<alv>();
								if (aspect2 != null && aspect2.a[1] != null)
								{
									aspect2.a[1].c = new Color?(dyz.k);
								}
							}
						}
						else
						{
							ah7 ah2 = c5x.Zone.i(c5x.qe().ToString() + "_trainingLantern");
							if (ah2 != null)
							{
								ah2.Enabled = false;
								ah2.d();
							}
							alv aspect3 = c5x.GetAspect<alv>();
							if (aspect3 != null && aspect3.a[1] != null)
							{
								aspect3.a[1].d = new float?(0f);
							}
							if (aspect != null)
							{
								aspect.b(false);
							}
							c5x.b("disabled");
						}
					}
				}
				if (A_1)
				{
					cqq cqq = new cqq();
					foreach (b0b b0b2 in serviceOrThrow.aqw().Areas[0].Entities)
					{
						c5x c5x2 = (c5x)b0b2;
						e3l aspect4 = c5x2.GetAspect<e3l>();
						if (aspect4 != null)
						{
							bool flag = false;
							using (List<string>.Enumerator enumerator2 = aspect4.a.GetEnumerator())
							{
								while (enumerator2.MoveNext())
								{
									if (enumerator2.Current.Contains("xphw_wall_pillar"))
									{
										flag = true;
									}
								}
							}
							if (flag)
							{
								cqq.a(c5x2, 10);
							}
						}
					}
					c5x c5x3 = Enumerable.FirstOrDefault<b0b>(d.ab4(new string[]
					{
						"data"
					})) as c5x;
					if (c5x3 != null)
					{
						c5x3.b("battleNotStarted");
					}
				}
			}
		}
	}

	// Token: 0x06004443 RID: 17475 RVA: 0x001B11BC File Offset: 0x001AF3BC
	public void a(int A_0)
	{
		switch (A_0)
		{
		default:
			return;
		}
	}

	// Token: 0x06004444 RID: 17476 RVA: 0x001B11D4 File Offset: 0x001AF3D4
	private void b()
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null)
		{
			d60 d = serviceOrThrow.aqw().a();
			if (d != null)
			{
				c5x c5x = Enumerable.FirstOrDefault<b0b>(d.ab4(new string[]
				{
					"movableConsole"
				})) as c5x;
				if (c5x != null)
				{
					c5x.RemoveAspect<dt5>();
					bim aspect = c5x.GetAspect<bim>();
					if (aspect != null)
					{
						aspect.g(false);
					}
					double num = (double)c5x.Location.Z;
					dtb dtb = new dtb();
					c5x c5x2 = serviceOrThrow.aqu().v().b() as c5x;
					if (c5x2 != null)
					{
						ar7 a_ = new ar7(c5x2);
						List<auv> list = dtb.ad();
						bfq bfq = new bfq();
						bfq.c("Xphw_TrainingGroundsConsoleRetraction");
						a4s a4s = new a4s(bfq, null, null, null);
						a4s.b(a_);
						list.Add(a4s);
						for (int i = 0; i < 25; i++)
						{
							num -= 0.0535;
							dtb.ad().Add(new bm3(25));
							dtb.ad().Add(new a8v(c5x, new Vector3(c5x.Location.X, c5x.Location.Y, (float)num)));
						}
						List<auv> list2 = dtb.ad();
						ch3 ch = new ch3();
						ch.a(new float?(0f));
						list2.Add(new a4s(ch, null, new ar7(c5x), null));
						List<auv> list3 = dtb.ad();
						bfq bfq2 = new bfq();
						bfq2.c("ManholeOpen");
						a4s a4s2 = new a4s(bfq2, null, null, null);
						a4s2.b(a_);
						list3.Add(a4s2);
						c5x c5x3 = Enumerable.FirstOrDefault<b0b>(d.ab4(new string[]
						{
							"movableFloor"
						})) as c5x;
						if (c5x3 != null)
						{
							num = (double)c5x3.Location.X;
							for (int j = 0; j < 23; j++)
							{
								num -= 0.041;
								dtb.ad().Add(new bm3(25));
								dtb.ad().Add(new a8v(c5x3, new Vector3((float)num, c5x3.Location.Y, c5x3.Location.Z)));
							}
							c5x3.ah();
						}
						bcy bcy = new bcy();
						bcy.a(new Guid?(c5x.qe()));
						bcy.a("xphw_exobase_trg1");
						bcy.a(new bjp(new byte[0]));
						dtb.ad().Add(new a4s(bcy, null, null, null));
						c5x.Zone.ActionManager.g9(dtb, atp.a);
						c5x c5x4 = Enumerable.FirstOrDefault<b0b>(d.ab4(new string[]
						{
							"data"
						})) as c5x;
						if (c5x4 != null)
						{
							e3l aspect2 = c5x4.GetAspect<e3l>();
							if (aspect2 != null)
							{
								aspect2.a.Remove("battleNotStarted");
								aspect2.a();
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06004445 RID: 17477 RVA: 0x001B14C0 File Offset: 0x001AF6C0
	public void d()
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null)
		{
			c5x c5x = serviceOrThrow.aqu().v().b() as c5x;
			if (c5x != null)
			{
				c5x c5x2 = new ar7(new Guid("114ee4b2-9d26-4a2d-b2e5-e547ebced2d7"), c5x.Area).ao() as c5x;
				if (c5x2 != null)
				{
					a3f aspect = c5x2.GetAspect<a3f>();
					if (aspect != null)
					{
						this.a(c5x2, aspect, serviceOrThrow);
						List<b0b> list = serviceOrThrow.aqw().a().ab4(new string[]
						{
							"voidFighter"
						});
						int i = 0;
						while (i < 4)
						{
							string text = "";
							switch (i)
							{
							case 0:
								if ((int)aspect.a()["north"] < 4 && !c5x2.a("specialSquadAlive"))
								{
									text = "north";
									goto IL_15B;
								}
								break;
							case 1:
								if ((int)aspect.a()["east"] < 4)
								{
									text = "east";
									goto IL_15B;
								}
								break;
							case 2:
								if ((int)aspect.a()["south"] < 4)
								{
									text = "south";
									goto IL_15B;
								}
								break;
							case 3:
								if ((int)aspect.a()["west"] < 4)
								{
									text = "west";
									goto IL_15B;
								}
								break;
							default:
								goto IL_15B;
							}
							IL_1333:
							i++;
							continue;
							IL_15B:
							if (text.Equals("north") && c5x2.a("specialSquadAlive"))
							{
								goto IL_1333;
							}
							float num = 0f;
							float num2 = 0f;
							float num3 = 1f;
							int num4 = 0;
							int num5 = 0;
							int num6 = 0;
							bool flag = false;
							bool flag2 = false;
							bool flag3 = false;
							bool flag4 = false;
							List<c5x> list2 = new List<c5x>();
							List<c5x> list3 = new List<c5x>();
							List<c5x> list4 = new List<c5x>();
							List<c5x> list5 = new List<c5x>();
							float num7 = (float)c5x.h.b.aa().Skills.Get<dql>().g();
							foreach (b0b b0b in list)
							{
								c5x c5x3 = (c5x)b0b;
								a3f aspect2 = c5x3.GetAspect<a3f>();
								if (aspect2 != null && aspect2.a()["position"] != null && aspect2.a()["position"].ToString() == text)
								{
									list2.Add(c5x3);
									float num8 = 1f;
									float num9 = 0f;
									if (c5x3.a("sol"))
									{
										list3.Add(c5x3);
										switch (serviceOrThrow.aqu().a())
										{
										case GameDifficulty.Easy:
											num8 = 4f;
											break;
										case GameDifficulty.Normal:
											num8 = 3.75f;
											break;
										case GameDifficulty.Hard:
											num8 = 3.5f;
											break;
										case GameDifficulty.Dominating:
											num8 = 3.25f;
											break;
										}
										num8 += num7 / 100f;
										num8 *= 1.1f;
										if (c5x3.a("negativeAffliction"))
										{
											if (c5x3.a("weak"))
											{
												num8 -= 1f;
											}
											if (c5x3.a("depleted"))
											{
												num8 -= 2f;
											}
											if (c5x3.a("refracted"))
											{
												num8 *= -1f;
											}
											if (c5x3.a("traitor"))
											{
												num8 = 0f;
												num4++;
											}
										}
										else if (c5x3.a("positiveAffliction"))
										{
											if (c5x3.a("vigorous"))
											{
												num8 += 2f;
											}
											if (c5x3.a("stalwart"))
											{
												num8 += 3f;
											}
											if (c5x3.a("martyr"))
											{
												num5++;
											}
										}
									}
									if (c5x3.a("med"))
									{
										list4.Add(c5x3);
										num9 = 2.5f + num7 / 100f;
										num9 *= 1.2f;
										if (c5x3.a("negativeAffliction"))
										{
											if (c5x3.a("irrational"))
											{
												num6++;
											}
											if (c5x3.a("vile"))
											{
												num9 = 0f;
												num8 = -3f;
											}
										}
										else if (c5x3.a("positiveAffliction"))
										{
											if (c5x3.a("thankful"))
											{
												num9 += 1f;
											}
											if (c5x3.a("virtuous"))
											{
												num9 += 2f;
											}
										}
									}
									if (c5x3.a("int"))
									{
										num3 = 2f + num7 / 400f;
										num3 *= 1.2f;
										list5.Add(c5x3);
										if (c5x3.a("negativeAffliction"))
										{
											if (c5x3.a("depressed"))
											{
												flag2 = true;
											}
											if (c5x3.a("paranoid"))
											{
												flag = true;
											}
											if (c5x3.a("abusive"))
											{
												flag4 = true;
											}
										}
										else if (c5x3.a("positiveAffliction") && c5x3.a("courageous"))
										{
											flag3 = true;
										}
									}
									num += num8;
									num2 += num9;
								}
							}
							if (num4 == num5)
							{
								num4 = 0;
								num5 = 0;
							}
							else if (num4 > num5)
							{
								num4 -= num5;
								num5 = 0;
							}
							else if (num4 < num5)
							{
								num4 = 0;
								num5 -= num4;
							}
							if (num6 > 0)
							{
								num2 = 0f;
							}
							if (flag)
							{
								num3 -= 0.5f;
							}
							if (flag2)
							{
								num3 = 1f;
							}
							if (flag3)
							{
								num3 += 0.5f;
							}
							num *= num3;
							c5x c5x4 = Enumerable.FirstOrDefault<b0b>(serviceOrThrow.aqw().a().ab4(new string[]
							{
								text + "VoidWallEntity_" + aspect.a()[text].ToString()
							})) as c5x;
							if (c5x4 == null)
							{
								goto IL_1333;
							}
							float num10 = 1f;
							if (!c5x2.a(text + "ShouldAttack"))
							{
								switch (serviceOrThrow.aqu().a())
								{
								case GameDifficulty.Easy:
									if ((int)aspect.a()["battleMomentum"] < 9)
									{
										num10 = 0.3f;
									}
									else
									{
										num10 = 0.4f;
									}
									break;
								case GameDifficulty.Normal:
									if ((int)aspect.a()["battleMomentum"] < 8)
									{
										num10 = 0.4f;
									}
									else
									{
										num10 = 0.5f;
									}
									break;
								case GameDifficulty.Hard:
									if ((int)aspect.a()["battleMomentum"] < 7)
									{
										num10 = 0.5f;
									}
									else
									{
										num10 = 0.6f;
									}
									break;
								case GameDifficulty.Dominating:
									if ((int)aspect.a()["battleMomentum"] < 6)
									{
										num10 = 0.6f;
									}
									else
									{
										num10 = 0.7f;
									}
									break;
								}
								num10 *= 0.85f;
							}
							else if (c5x2.a(text + "ShouldAttack"))
							{
								switch (serviceOrThrow.aqu().a())
								{
								case GameDifficulty.Easy:
									num10 = 1.1f;
									break;
								case GameDifficulty.Normal:
									num10 = 1.15f;
									break;
								case GameDifficulty.Hard:
									num10 = 1.25f;
									break;
								case GameDifficulty.Dominating:
									num10 = 1.3f;
									break;
								}
								num10 *= 1f;
							}
							float num11 = 1f;
							if (c5x2.a(text + "ET"))
							{
								switch (serviceOrThrow.aqu().a())
								{
								case GameDifficulty.Easy:
									num11 = 1.6f;
									break;
								case GameDifficulty.Normal:
									num11 = 1.5f;
									break;
								case GameDifficulty.Hard:
									num11 = 1.4f;
									break;
								case GameDifficulty.Dominating:
									num11 = 1.3f;
									break;
								}
								num11 *= 1.25f;
							}
							float num12 = num * num11 - (float)c5x4.GetAspect<a3f>().a()["voidPower"] * num10;
							if (list2.Count < 3)
							{
								int num13 = 3;
								GameDifficulty gameDifficulty = serviceOrThrow.aqu().a();
								if (gameDifficulty != GameDifficulty.Hard)
								{
									if (gameDifficulty == GameDifficulty.Dominating)
									{
										num13 = 4;
									}
								}
								else
								{
									num13 = 4;
								}
								list2.Clear();
								Enumerable.FirstOrDefault<b0b>(Enumerable.OrderBy<b0b, int>(list, new Func<b0b, int>(aow.a.a.a)));
								using (List<b0b>.Enumerator enumerator = list.GetEnumerator())
								{
									while (enumerator.MoveNext())
									{
										b0b b0b2 = enumerator.Current;
										c5x c5x5 = (c5x)b0b2;
										this.a(c5x5, null);
										list2.Add(c5x5);
										if (c5x5.a("sol") && cuo.a.Next(0, 101) < 85)
										{
											this.a(c5x5, "sol", true);
										}
										if (c5x5.a("med") && cuo.a.Next(0, 101) < 85)
										{
											this.a(c5x5, "med", true);
										}
										if (c5x5.a("int") && cuo.a.Next(0, 101) < 85)
										{
											this.a(c5x5, "int", true);
										}
									}
									goto IL_A46;
								}
								goto IL_9CC;
								IL_A46:
								if (num13 <= 0)
								{
									goto IL_1333;
								}
								IL_9CC:
								c5x c5x6 = Enumerable.FirstOrDefault<c5x>(Enumerable.OrderBy<c5x, int>(Enumerable.Where<c5x>(list2, new Func<c5x, bool>(aow.a.a.d)), new Func<c5x, int>(aow.a.a.f)));
								if (c5x6 != null)
								{
									c5x6.b("MarkedForDeath");
									list2.Remove(c5x6);
								}
								num13--;
								goto IL_A46;
							}
							Enumerable.FirstOrDefault<c5x>(Enumerable.OrderBy<c5x, int>(list3, new Func<c5x, int>(aow.a.a.a)));
							Enumerable.FirstOrDefault<c5x>(Enumerable.OrderBy<c5x, int>(list4, new Func<c5x, int>(aow.a.a.e)));
							if (num12 >= 0f)
							{
								c5x2.b("victory" + text);
								if (c5x2.a(text + "ShouldAttack"))
								{
									aspect.a()["battleMomentum"] = (int)aspect.a()["battleMomentum"] + 2;
									int num14 = 0;
									int num15 = 0;
									switch (serviceOrThrow.aqu().a())
									{
									case GameDifficulty.Easy:
										num14 = 45 + (c5x2.a(text + "ET") ? 10 : 0);
										num15 = 4 + (c5x2.a(text + "ET") ? -1 : 0) + (flag4 ? 10 : 0);
										break;
									case GameDifficulty.Normal:
										num14 = 30 + (c5x2.a(text + "ET") ? 8 : 0);
										num15 = 12 + (c5x2.a(text + "ET") ? -2 : 0) + (flag4 ? 15 : 0);
										break;
									case GameDifficulty.Hard:
										num14 = 25 + (c5x2.a(text + "ET") ? 6 : 0);
										num15 = 20 + (c5x2.a(text + "ET") ? -4 : 0) + (flag4 ? 20 : 0);
										break;
									case GameDifficulty.Dominating:
										num14 = 20 + (c5x2.a(text + "ET") ? 6 : 0);
										num15 = 30 + (c5x2.a(text + "ET") ? -8 : 0) + (flag4 ? 25 : 0);
										break;
									}
									num14 = (int)((float)num14 * 1f);
									num15 = (int)((float)num15 * 1f);
									foreach (c5x a_ in list2)
									{
										if (this.a(a_, false))
										{
											this.a(a_, new bool?(true));
										}
									}
									foreach (c5x a_2 in list3)
									{
										if (!this.a(a_2, true))
										{
											if (cuo.a.Next(0, 101) < num14)
											{
												this.a(a_2, "sol", false);
											}
											else if (cuo.a.Next(0, 101) < num15)
											{
												this.a(a_2, "sol", true);
											}
										}
									}
									foreach (c5x a_3 in list4)
									{
										if (!this.a(a_3, true))
										{
											if (cuo.a.Next(0, 101) < num14)
											{
												this.a(a_3, "med", false);
											}
											else if (cuo.a.Next(0, 101) < num15)
											{
												this.a(a_3, "med", true);
											}
										}
									}
									using (List<c5x>.Enumerator enumerator2 = list5.GetEnumerator())
									{
										while (enumerator2.MoveNext())
										{
											c5x a_4 = enumerator2.Current;
											if (!this.a(a_4, true))
											{
												if (cuo.a.Next(0, 101) < num14)
												{
													this.a(a_4, "int", false);
												}
												else if (cuo.a.Next(0, 101) < num15)
												{
													this.a(a_4, "int", true);
												}
											}
										}
										goto IL_11BC;
									}
								}
								int num16 = 0;
								switch (serviceOrThrow.aqu().a())
								{
								case GameDifficulty.Easy:
									num16 = 75 + (c5x2.a(text + "ET") ? 15 : 0);
									break;
								case GameDifficulty.Normal:
									num16 = 70 + (c5x2.a(text + "ET") ? 15 : 0);
									break;
								case GameDifficulty.Hard:
									num16 = 65 + (c5x2.a(text + "ET") ? 15 : 0);
									break;
								case GameDifficulty.Dominating:
									num16 = 60 + (c5x2.a(text + "ET") ? 15 : 0);
									break;
								}
								num16 = (int)((float)num16 * 1f);
								using (List<c5x>.Enumerator enumerator2 = list2.GetEnumerator())
								{
									while (enumerator2.MoveNext())
									{
										c5x a_5 = enumerator2.Current;
										if (cuo.a.Next(0, 101) < num16)
										{
											this.a(a_5, null);
										}
									}
									goto IL_11BC;
								}
								goto IL_FDD;
							}
							goto IL_FDD;
							IL_11BC:
							if (num2 > 0f && num12 < 0f)
							{
								num12 += num2;
								foreach (c5x a_6 in list4)
								{
									this.c(a_6);
									a_6.b("medicHeal");
								}
							}
							int j = 0;
							if (num12 < -12f)
							{
								j = 3;
							}
							else if (num12 < -6f)
							{
								j = 2;
							}
							else if ((num12 < -3f && list.Count >= 6) || (num12 < 0f && (list.Count < 6 || (int)aspect.a()["battleMomentum"] > 8)))
							{
								j = 1;
							}
							j = j + num4 - num5;
							if (j > 0)
							{
								while (j > 0)
								{
									c5x c5x7 = Enumerable.FirstOrDefault<c5x>(Enumerable.OrderBy<c5x, int>(Enumerable.Where<c5x>(list2, new Func<c5x, bool>(aow.a.a.c)), new Func<c5x, int>(aow.a.a.b)));
									if (c5x7 != null)
									{
										c5x7.b("MarkedForDeath");
										list2.Remove(c5x7);
									}
									j--;
								}
								goto IL_1333;
							}
							goto IL_1333;
							IL_FDD:
							if (num12 < 0f)
							{
								c5x2.b("defeat" + text);
								int num17 = 80;
								switch (serviceOrThrow.aqu().a())
								{
								case GameDifficulty.Easy:
									num17 = 70 + (flag4 ? 10 : 0);
									break;
								case GameDifficulty.Normal:
									num17 = 75 + (flag4 ? 11 : 0);
									break;
								case GameDifficulty.Hard:
									num17 = 80 + (flag4 ? 12 : 0);
									break;
								case GameDifficulty.Dominating:
									num17 = 85 + (flag4 ? 10 : 0);
									break;
								}
								num17 = (int)((float)num17 * 1f);
								foreach (c5x a_7 in list3)
								{
									if (!this.a(a_7, true) && cuo.a.Next(0, 101) < num17)
									{
										this.a(a_7, "sol", true);
									}
								}
								foreach (c5x a_8 in list4)
								{
									if (!this.a(a_8, true) && cuo.a.Next(0, 101) < num17)
									{
										this.a(a_8, "med", true);
									}
								}
								foreach (c5x a_9 in list5)
								{
									if (!this.a(a_9, true) && cuo.a.Next(0, 101) < num17)
									{
										this.a(a_9, "int", true);
									}
								}
								goto IL_11BC;
							}
							goto IL_11BC;
						}
						aspect.a()["battleMomentum"] = (int)aspect.a()["battleMomentum"] + 1;
						this.a(c5x2, aspect, serviceOrThrow);
					}
				}
			}
		}
	}

	// Token: 0x06004446 RID: 17478 RVA: 0x001B2950 File Offset: 0x001B0B50
	public void c()
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null)
		{
			c5x c5x = serviceOrThrow.aqu().v().b() as c5x;
			if (c5x != null)
			{
				c5x c5x2 = new ar7(new Guid("114ee4b2-9d26-4a2d-b2e5-e547ebced2d7"), c5x.Area).ao() as c5x;
				if (c5x2 != null)
				{
					a3f aspect = c5x2.GetAspect<a3f>();
					if (aspect != null)
					{
						List<b0b> list = serviceOrThrow.aqw().a().ab4(new string[]
						{
							"amalgam"
						});
						float a_ = 2f;
						switch (serviceOrThrow.aqu().a())
						{
						case GameDifficulty.Normal:
							a_ = 2.35f;
							break;
						case GameDifficulty.Hard:
							a_ = 2.6f;
							break;
						case GameDifficulty.Dominating:
							a_ = 2.8f;
							break;
						}
						foreach (b0b b0b in list)
						{
							c5x c5x3 = (c5x)b0b;
							a3f aspect2 = c5x3.GetAspect<a3f>();
							if (aspect2 != null)
							{
								bool a_2 = c5x.h.b.aa().StatusEffects.a("secondSight") || c5x.h.b.aa().a("theJuice", false) != null;
								aspect2.a()["voidPower"] = this.a(aspect, a_, c5x3, a_2, serviceOrThrow);
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06004447 RID: 17479 RVA: 0x001B2AF4 File Offset: 0x001B0CF4
	public void e(c5x A_0)
	{
		a3f aspect = A_0.GetAspect<a3f>();
		if (aspect != null)
		{
			string text = "";
			A_0.GetAspect<e3l>();
			for (int i = 0; i < 4; i++)
			{
				switch (i)
				{
				case 0:
					text = "north";
					break;
				case 1:
					text = "east";
					break;
				case 2:
					text = "south";
					break;
				case 3:
					text = "west";
					break;
				}
				if (A_0.a(text + "ShouldAttack") && A_0.a("victory" + text) && (int)aspect.a()[text] >= 4)
				{
					A_0.b(text + "Complete");
				}
			}
			this.b(A_0);
		}
	}

	// Token: 0x06004448 RID: 17480 RVA: 0x001B2BCC File Offset: 0x001B0DCC
	public void a(string A_0, bool A_1)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null)
		{
			c5x c5x = Enumerable.FirstOrDefault<b0b>(serviceOrThrow.aqw().a().ab4(new string[]
			{
				"data"
			})) as c5x;
			if (c5x != null)
			{
				a3f aspect = c5x.GetAspect<a3f>();
				if (aspect != null)
				{
					this.a(c5x);
					c5x c5x2 = Enumerable.FirstOrDefault<b0b>(serviceOrThrow.aqw().a().ab4(new string[]
					{
						"torchEntity"
					})) as c5x;
					if (c5x2 != null)
					{
						string text;
						if (A_0 == null || A_0 == "")
						{
							text = "torchMiddle";
						}
						else
						{
							int num = (int)aspect.a()[A_0] + ((A_1 > false) ? 1 : 0);
							if (num > 3)
							{
								text = "torchMiddle";
							}
							else
							{
								text = "torch" + A_0 + "_" + num.ToString();
							}
						}
						csd csd = c5x2.Zone.g(text);
						if (csd != null)
						{
							bpr a_ = new bpr(c5x2.GetAspect<mj>(), new Vector3(csd.Location.b(), 2f));
							c5x2.Zone.ActionManager.g9(a_, atp.a);
							dz6.a(a_);
						}
						if (text != "torchMiddle")
						{
							c5x.b(A_0 + "ET");
						}
					}
				}
			}
		}
	}

	// Token: 0x06004449 RID: 17481 RVA: 0x001B2D40 File Offset: 0x001B0F40
	public void b(string A_0, int A_1)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null && serviceOrThrow.aqw() != null)
		{
			aud aud = serviceOrThrow.aqw().n("xphw_exobase_trg2");
			d60 d = serviceOrThrow.aqw().a();
			if (d != null && aud != null)
			{
				List<b0b> list = d.ab4(new string[]
				{
					A_0 + "VoidWallEntity_" + (A_1 - 1).ToString()
				});
				if (list != null)
				{
					foreach (b0b b0b in list)
					{
						c5x c5x = (c5x)b0b;
						dtb dtb = new dtb();
						List<auv> list2 = dtb.ad();
						ad6 ad = new ad6(c5x);
						ad.b(1.0);
						ad.c(0.0);
						ad.a(0.0005);
						list2.Add(ad);
						c5x.TileFormationModifiers.c();
						c5x.z();
						dtb.ad().Add(new c7(c5x, false, false, true, false));
						serviceOrThrow.aqw().ActionManager.g9(dtb, atp.a);
						foreach (b0b b0b2 in d.ab4(new string[]
						{
							A_0 + "LightBlocker_" + (A_1 - 1).ToString()
						}))
						{
							c5x c5x2 = (c5x)b0b2;
							c5x2.w();
							c5x2.an();
						}
						edk edk = new edk();
						edk.b().Add(A_0 + (A_1 - 1).ToString());
						edk.ym(serviceOrThrow.aqu().v().b(), null, null);
						aud.StartingLightning = new Color((int)aud.StartingLightning.R, (int)(aud.StartingLightning.G + 5), (int)(aud.StartingLightning.B + 5), (int)aud.StartingLightning.A);
						b0b b0b3 = d.ab5(A_0 + "VoidLanternEntity_" + (A_1 - 1).ToString());
						if (b0b3 != null)
						{
							foreach (ejt ejt in b0b3.RaysEmitters)
							{
								bsf bsf = ejt as bsf;
								if (bsf != null)
								{
									bsf.Definition.Enabled = false;
									bsf.b();
								}
							}
						}
					}
					for (int i = 0; i < aud.Size.c; i++)
					{
						for (int j = 0; j < aud.Size.d; j++)
						{
							ak1 ak = aud.b(i, j);
							if (ak != null)
							{
								ak.e();
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600444A RID: 17482 RVA: 0x001B3084 File Offset: 0x001B1284
	public bool a(string A_0, int A_1)
	{
		if (A_1 > 3)
		{
			cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
			if (serviceOrThrow.aqu() != null && serviceOrThrow.aqw() != null)
			{
				d60 d = serviceOrThrow.aqw().a();
				if (d != null)
				{
					b0b b0b = d.ab5(A_0 + "Brazier");
					if (b0b != null)
					{
						bk2 aspect = b0b.GetAspect<bk2>();
						if (aspect != null)
						{
							aspect.a();
						}
					}
				}
			}
			return true;
		}
		return false;
	}

	// Token: 0x0600444B RID: 17483 RVA: 0x001B30F4 File Offset: 0x001B12F4
	public void a(string A_0, aud A_1)
	{
		if (A_1 == null)
		{
			return;
		}
		List<a41> list = new List<a41>();
		foreach (ya ya in A_1.Triggers)
		{
			if (ya is a41 && (ya as a41).MarkerCode.Equals(A_0))
			{
				list.Add(ya as a41);
			}
		}
		if (Enumerable.Any<a41>(list))
		{
			foreach (a41 a in list)
			{
				for (int i = a.Location.X; i < a.Location.X + a.Size.c; i++)
				{
					for (int j = a.Location.Y; j < a.Location.Y + a.Size.d; j++)
					{
						ak1 ak = A_1.b(i, j);
						if (ak != null)
						{
							foreach (b0b b0b in Enumerable.ToList<b0b>(ak.Entities))
							{
								c5x c5x = (c5x)b0b;
								if (c5x.o.b != null && c5x.o.b is etz && (c5x.o.b as etz).a.StartsWith("Objects\\Compositions\\xphw_voidtile"))
								{
									e4o e4o = new e4o(c5x);
									e4o.a((c5x.ae != null) ? ((byte)(Math.Min(1f, c5x.ae.Value) * 255f)) : byte.MaxValue);
									e4o.b(0);
									qy qy = new qy();
									qy.b(false);
									qy.c(false);
									qy.ad().Add(new bm3(20 + cuo.a.Next(0, 5) * 10));
									qy.ad().Add(e4o);
									qy.ad().Add(new c7(c5x, false, false, true, false));
									A_1.Zone.ActionManager.g9(qy, atp.a);
									break;
								}
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600444C RID: 17484 RVA: 0x001B33D8 File Offset: 0x001B15D8
	public void b(c5x A_0, bool A_1)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null)
		{
			bool flag = serviceOrThrow.aqw().a() != null;
			c5x c5x = new ar7(new Guid("114ee4b2-9d26-4a2d-b2e5-e547ebced2d7"), A_0.Area).ao() as c5x;
			if (flag && c5x != null)
			{
				dtb dtb = new dtb();
				dtb.ad().Add(new bm3(cuo.a.Next(300)));
				dtb.ad().Add(new a4s(new bfq("Xphw_VoidDevour"), null, new ar7(A_0), null));
				dtb.ad().Add(new a7j(A_0, "xphw_voidDevour0", 1, double.MaxValue, false, false, null, null, null, null, false, null));
				dtb.ad().Add(new a7j(A_0, "xphw_voidDevour1", 1, double.MaxValue, false, false, null, null, null, null, false, null));
				List<auv> list = dtb.ad();
				ad6 ad = new ad6(A_0);
				ad.b(1.0);
				ad.c(0.0);
				ad.a(0.003);
				list.Add(ad);
				dtb.ad().Add(new bm3(cuo.a.Next(1000)));
				dtb.ad().Add(new c7(A_0, false, false, true, false));
				serviceOrThrow.aqw().ActionManager.g9(dtb, atp.a);
				if (A_1)
				{
					a3f aspect = c5x.GetAspect<a3f>();
					if (aspect != null)
					{
						aspect.a()["commanderHealth"] = (int)aspect.a()["commanderHealth"] - 1;
						if ((int)aspect.a()["commanderHealth"] <= 5 || ((int)aspect.a()["commanderHealth"] <= 10 && c5x.a("specialSquadAlive")))
						{
							serviceOrThrow.aqu().r()["loc_xphw_exoBase_voidBattleLost"] = true;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600444D RID: 17485 RVA: 0x001B3648 File Offset: 0x001B1848
	public void a(c5x A_0, string A_1, bool A_2)
	{
		if (A_2)
		{
			if (Enumerable.FirstOrDefault<ax5>(A_0.h.b.aa().StatusEffects.Get<ax5>()) == null)
			{
				A_0.h.b.aa().StatusEffects.a(new ax5(), false, false, false);
			}
			ekw ekw = Enumerable.FirstOrDefault<ekw>(A_0.h.b.aa().StatusEffects.Get<ekw>());
			if (ekw != null)
			{
				A_0.h.b.aa().StatusEffects.d(ekw);
			}
			if (A_1.Equals("sol"))
			{
				switch (cuo.a.Next(0, 5))
				{
				case 1:
					A_0.b("weak");
					return;
				case 2:
					A_0.b("depleted");
					return;
				case 3:
					A_0.b("refracted");
					return;
				case 4:
					if (cuo.a.Next(0, 101) < 50)
					{
						A_0.b("traitor");
						return;
					}
					A_0.b("depleted");
					return;
				default:
					A_0.b("weak");
					return;
				}
			}
			else if (A_1.Equals("med"))
			{
				int num = cuo.a.Next(0, 3);
				if (num == 1)
				{
					A_0.b("irrational");
					return;
				}
				if (num != 2)
				{
					A_0.b("irrational");
					return;
				}
				A_0.b("vile");
				return;
			}
			else if (A_1.Equals("int"))
			{
				switch (cuo.a.Next(0, 3))
				{
				case 0:
					A_0.b("depressed");
					return;
				case 1:
					A_0.b("paranoid");
					return;
				case 2:
					A_0.b("abusive");
					return;
				default:
					A_0.b("depressed");
					return;
				}
			}
		}
		else
		{
			if (Enumerable.FirstOrDefault<ekw>(A_0.h.b.aa().StatusEffects.Get<ekw>()) == null)
			{
				A_0.h.b.aa().StatusEffects.a(new ekw(), false, false, false);
			}
			ax5 ax = Enumerable.FirstOrDefault<ax5>(A_0.h.b.aa().StatusEffects.Get<ax5>());
			if (ax != null)
			{
				A_0.h.b.aa().StatusEffects.d(ax);
			}
			if (A_1.Equals("sol"))
			{
				switch (cuo.a.Next(0, 4))
				{
				case 1:
					A_0.b("vigorous");
					break;
				case 2:
					A_0.b("stalwart");
					break;
				case 3:
					if (cuo.a.Next(0, 101) < 50)
					{
						A_0.b("martyr");
					}
					else
					{
						A_0.b("stalwart");
					}
					break;
				default:
					A_0.b("vigorous");
					break;
				}
			}
			else if (A_1.Equals("med"))
			{
				int num = cuo.a.Next(0, 3);
				if (num != 1)
				{
					if (num != 2)
					{
						A_0.b("thankful");
					}
					else
					{
						A_0.b("virtuous");
					}
				}
				else
				{
					A_0.b("thankful");
				}
			}
			else if (A_1.Equals("int") && cuo.a.Next(0, 101) < 50)
			{
				A_0.b("courageous");
			}
			e3l aspect = A_0.GetAspect<e3l>();
			if (aspect != null)
			{
				aspect.a();
			}
		}
	}

	// Token: 0x0600444E RID: 17486 RVA: 0x001B39F8 File Offset: 0x001B1BF8
	public void c(c5x A_0, bool A_1)
	{
		if (A_0 != null)
		{
			e25 e = new e25();
			e.a(new Guid?(A_0.qe()));
			e.a(7f);
			e.a(!A_1);
			e.ym(A_0, A_0, null);
		}
	}

	// Token: 0x0600444F RID: 17487 RVA: 0x001B3A40 File Offset: 0x001B1C40
	public void a(c5x A_0, string A_1, string A_2)
	{
		List<string> list = new List<string>();
		Color value = new Color(255, 255, 255);
		if (A_1.Equals("med"))
		{
			if (A_2.Equals("medicHeal"))
			{
				value = new Color(255, 255, 125);
				list.AddRange(new List<string>
				{
					"Поддержание функциональности туберомаммиллярного ядра.",
					"Стабилизация уровня гамма-аминомасляной кислоты.",
					"Управление гипокретиновыми нейронами. Процедура завершена.",
					"Применяемые дозы аденозина.",
					"Номинализация супрахиазматического ядра.",
					"Статус!",
					"Состояние NREM - оптимальное.",
					"Поставка медицинских препаратов.",
					"Лечение нарушений циркадного ритма."
				});
			}
			else if (A_2.Equals("medicSabotage"))
			{
				value = new Color(255, 55, 12);
				list.AddRange(new List<string>
				{
					"Отключение VLPO!",
					"Подавление гипокретина!",
					"Дисбаланс уровня кортизола!",
					"Предотвращение ингибирования GABA."
				});
			}
		}
		else if (A_1.Equals("sol"))
		{
			if (A_2.Equals("soldierMartyrSave"))
			{
				value = new Color(255, 255, 125);
				list.AddRange(new List<string>
				{
					"Смерть может подождать!",
					"Жизнь моих братьев превыше моей!",
					"Будьте начеку! Нет времени на отдых.",
					"Мы не созданы для того, чтобы падать духом - поднимайтесь!",
					"Помните о тренировках! Полагайтесь на свой инстинкт и сенсоры.",
					"Сенсоры на все часы! Противник может появиться с любого направления.",
					"Мы обязаны выполнять свой долг!"
				});
			}
			else if (A_2.Equals("soldierTraitorKill"))
			{
				value = new Color(255, 25, 25);
				list.AddRange(new List<string>
				{
					"Подъём! Подъё-ё-ём!!!",
					"Этот кошмар скоро заканчивается!",
					"Хахахааа-аааа-хахахаааа!",
					"Созданы, чтобы умереть!",
					"Конец близок!",
					"Тьма уже здесь!",
					"Отключай разъём!",
					"Срок годности - давно истёк!"
				});
			}
			else if (A_2.Equals("soldierFightWin"))
			{
				list.AddRange(new List<string>
				{
					"Стоять твёрдо!",
					"Периметр под защитой.",
					"Вторгшиеся объекты откинуты назад.",
					"Решение неминуемо. Победа обеспечена.",
					"Закрепление позиций.",
					"Поддержание тактической формации.",
					"Миссия выполнена!",
					"Угроза подавлена!",
					"Будьте начеку!",
					"Все сенсоры функционируют.",
					"Позиция удержана.",
					"Сканирование...",
					"Мы справимся!",
					"Мы созданы для этого!",
					"Вот оно!",
					"С нашей мощью невозможно сравниться.",
					"Держать глаза открытыми!",
					"Мы справимся!",
					"О, да!",
					"Не пути назад.",
					"Отступать некуда!",
					"Получай!",
					"Команда сети активна.",
					"Спецназ в деле.",
					"Боевой вектор подтверждён.",
					"Стальная воля!",
					"Сектор чистый.",
					"Победа впереди.",
					"Продолжать в том же духе...",
					"На позиции.",
					"Мы контролируем ситуацию!",
					"Чисто!",
					"Зажжём!",
					"Целевая зона захвачена!",
					"Объект под защитой."
				});
			}
			else if (A_2.Equals("soldierFightLose"))
			{
				list.AddRange(new List<string>
				{
					"Ч-что?",
					"Периметр прорван. Отступаем!",
					"Мы подавлены!",
					"Отступаем!",
					"Теряем позицию!",
					"Формация нарушена!",
					"Мы не можем удержать позицию!",
					"Они нас сожрут!",
					"Они повсюду!",
					"Агх... нос... А-а-а-агх!",
					"Моя голова-а...",
					"Нет... это конец!",
					"Отступаем, отступаем!",
					"Неееееет!",
					"Это провал!",
					"Нашим мечтам конец!",
					"Когда это закончится?",
					"Это место проклято!",
					"Это бесполезно!",
					"Что?..",
					"Мы не справились...",
					"::Кричит.::",
					"::Задыхается.::"
				});
			}
		}
		else if (A_1.Equals("int"))
		{
			if (A_2.Equals("intDepressed"))
			{
				value = new Color(255, 25, 25);
				list.AddRange(new List<string>
				{
					"В этом нет никакого смысла...",
					"Наши усилия тщетны...",
					"Вот и всё... вот и всё закончилось...",
					"Закрывайте глаза...",
					"Это место поглотит нас заживо.",
					"Наши пытки только начались.",
					"Просто сдаться... сдаться...",
					"Наше бессмысленное существование закончится сегодня."
				});
			}
			else if (A_2.Equals("intHalved"))
			{
				value = new Color(255, 25, 25);
				list.AddRange(new List<string>
				{
					"Продолжайте биться, трусы!",
					"Дезертиры!",
					"Оставаться в строю!",
					"Братья, стоять!",
					"Назад в бой!",
					"Наша судьба предрешена...",
					"Рапортую об отключениях!"
				});
			}
			else if (A_2.Equals("intCourageous"))
			{
				list.AddRange(new List<string>
				{
					"Не бойтесь, наша победа несомненна!",
					"Истребляйте эту мерзость!",
					"Наша решимость непревзойденна! Бейтесь!",
					"Мы ждали этого шанса! И мы не упустим его!",
					"Не проявляйте милосердия. Не оставляйте в живых ничего!",
					"Идите беспощадно.",
					"Никто не сможет разрушить нашу связь! Мы будем упорствовать!",
					"Вперёд к славе!"
				});
			}
			else if (A_2.Equals("intBuffNegated"))
			{
				value = new Color(255, 25, 25);
				list.AddRange(new List<string>
				{
					"Надежды нет...",
					"Пустота зовёт меня..."
				});
			}
		}
		if (list.Count > 1)
		{
			us us = new us();
			us.a(new Guid?(A_0.qe()));
			us.a(bvl.e);
			us.a(list[cuo.a.Next(0, Enumerable.Count<string>(list) - 1)]);
			us.b(new Color?(value));
			us.ym(A_0, A_0, null);
		}
	}

	// Token: 0x06004450 RID: 17488 RVA: 0x001B416C File Offset: 0x001B236C
	private float a(a3f A_0, float A_1, c5x A_2, bool A_3, cnk A_4)
	{
		int num = (int)A_0.a()["battleMomentum"];
		float num2 = 8f;
		float num3 = 2f;
		switch (A_4.aqu().a())
		{
		case GameDifficulty.Normal:
			num3 = 4f;
			break;
		case GameDifficulty.Hard:
			num3 = 5f;
			break;
		case GameDifficulty.Dominating:
			num3 = 7f;
			break;
		}
		int num4 = 5;
		int maxValue = 7;
		if (num > 3 && num <= 8)
		{
			num4 = 5 + num;
			maxValue = 9;
			num2 = 10f + A_1 * (float)num + num3 / 2f;
		}
		else if (num > 8 && num < 15)
		{
			num4 = 7;
			maxValue = 7 + num;
			num2 = 12f + A_1 * 6f + (float)(num / 4) + num3;
		}
		num2 = Math.Abs(num2) + (float)cuo.a.Next(-num4 - (int)A_1, maxValue) + num3 / 2f;
		if (num2 < 10f)
		{
			num2 = 10f;
		}
		if (num2 > 45f)
		{
			num2 = 45f;
		}
		num2 *= 0.85f;
		this.a(A_2, num2, A_3);
		this.d(A_2);
		d85 d = A_2.GetAspect<bim>() as d85;
		string a_ = "";
		string item = "";
		if (d != null)
		{
			d.a().Clear();
			d.s().Clear();
			if (num2 <= 11f)
			{
				A_2.b("lots");
				if (A_3)
				{
					a_ = "::Существо в своей самой уязвимой стадии. *Остальные* ещё скользят выше, не желая присоединиться к тому, кто перед вами.::";
				}
				item = "::Затаившееся, раздутое, склизкое существо, находящееся ещё в зачаточной стадии.::";
			}
			else if (num2 > 11f && num2 <= 15f)
			{
				A_2.b("horde");
				if (A_3)
				{
					a_ = "::Его присутствие представляет собой слабую угрозу. *Полчища* остальных видны далеко вдалеке.::";
				}
				item = "::Вихрь злобы. Голодный, метастазирующий, вопящий...::";
			}
			else if (num2 > 15f && num2 <= 23f)
			{
				A_2.b("throng");
				if (A_3)
				{
					a_ = "::*Жезл*, предназначенный для причинения страданий.::";
				}
				item = "::Своеобразное, меняющееся существо, и молодое, и старое, и правильное, и неправильное.::";
			}
			else if (num2 > 23f && num2 <= 28f)
			{
				A_2.b("swarm");
				if (A_3)
				{
					a_ = "::*Рой* кошмаров.::";
				}
				item = "::Из бездны доносится содрогающий вопль, полный кричащей боли.::";
			}
			else if (num2 > 28f && num2 <= 36f)
			{
				A_2.b("zounds");
				if (A_3)
				{
					a_ = "::*Звурки*! Предпоследняя сущность невыразимого ужаса извращающая саму реальность!::";
				}
				item = "::Раздутый, безглазый, туманный выкидыш питающийся мыслями стороннего наблюдателя.::";
			}
			else if (num2 > 36f)
			{
				A_2.b("legion");
				if (A_3)
				{
					a_ = "::*Легион* абсурдного умственного разврата деформирующий саму реальность.::";
				}
				item = "::Непонятная, невидимая, извивающаяся развращенность, существующая на грани воображения.::";
			}
			if (A_3)
			{
				List<cze> list = d.s();
				us us = new us();
				us.a(new Guid?(A_2.qe()));
				us.a(a_);
				us.a(new Color?(new Color(125, 255, 255)));
				us.a(bvl.e);
				list.Add(us);
			}
			else
			{
				d.a().Add(item);
			}
		}
		return num2;
	}

	// Token: 0x06004451 RID: 17489 RVA: 0x001B4488 File Offset: 0x001B2688
	private void a(c5x A_0, float A_1, bool A_2)
	{
		if (A_0 != null)
		{
			etz etz = A_0.GetAspect<cd0>() as etz;
			if (etz != null)
			{
				int num = 0;
				if (A_1 > 28f)
				{
					num = 2;
				}
				else if (A_1 > 15f)
				{
					num = 1;
				}
				if (!string.IsNullOrEmpty(etz.a))
				{
					if (A_2)
					{
						if (etz.a.EndsWith("_j"))
						{
							etz.a = etz.a.Substring(0, etz.a.Length - 3) + num.ToString() + "_j";
							return;
						}
						etz.a = etz.a.Substring(0, etz.a.Length - 1) + num.ToString() + "_j";
						return;
					}
					else
					{
						etz.a = etz.a.Substring(0, etz.a.Length - 1) + num.ToString();
					}
				}
			}
		}
	}

	// Token: 0x06004452 RID: 17490 RVA: 0x001B4588 File Offset: 0x001B2788
	private void d(c5x A_0)
	{
		e3l aspect = A_0.GetAspect<e3l>();
		if (aspect != null)
		{
			aspect.a.Remove("lots");
			aspect.a.Remove("horde");
			aspect.a.Remove("throng");
			aspect.a.Remove("swarm");
			aspect.a.Remove("zounds");
			aspect.a.Remove("legion");
			aspect.a();
		}
	}

	// Token: 0x06004453 RID: 17491 RVA: 0x001B4610 File Offset: 0x001B2810
	private void c(c5x A_0)
	{
		e3l aspect = A_0.GetAspect<e3l>();
		if (aspect != null)
		{
			aspect.a.Remove("medicHeal");
			aspect.a.Remove("medicSabotage");
			aspect.a.Remove("soldierMartyrSave");
			aspect.a.Remove("soldierTraitorKill");
			aspect.a.Remove("soldierFightWin");
			aspect.a.Remove("soldierFightLose");
			aspect.a.Remove("intDepressed");
			aspect.a.Remove("intHalved");
			aspect.a.Remove("intCourageous");
			aspect.a.Remove("intBuffNegated");
			aspect.a();
		}
	}

	// Token: 0x06004454 RID: 17492 RVA: 0x001B46DC File Offset: 0x001B28DC
	private void a(c5x A_0, bool? A_1 = null)
	{
		e3l aspect = A_0.GetAspect<e3l>();
		if (aspect != null)
		{
			if (A_1.GetValueOrDefault())
			{
				ekw ekw = Enumerable.FirstOrDefault<ekw>(A_0.h.b.aa().StatusEffects.Get<ekw>());
				if (ekw != null)
				{
					A_0.h.b.aa().StatusEffects.d(ekw);
				}
				aspect.a.Remove("positiveAffliction");
				aspect.a.Remove("vigorous");
				aspect.a.Remove("stalwart");
				aspect.a.Remove("martyr");
				aspect.a.Remove("thankful");
				aspect.a.Remove("virtuous");
				aspect.a.Remove("courageous");
				aspect.a();
				return;
			}
			bool? flag = A_1;
			bool flag2 = false;
			if (flag.GetValueOrDefault() == flag2 & flag != null)
			{
				ax5 ax = Enumerable.FirstOrDefault<ax5>(A_0.h.b.aa().StatusEffects.Get<ax5>());
				if (ax != null)
				{
					A_0.h.b.aa().StatusEffects.d(ax);
				}
				aspect.a.Remove("negativeAffliction");
				aspect.a.Remove("weak");
				aspect.a.Remove("depleted");
				aspect.a.Remove("refracted");
				aspect.a.Remove("traitor");
				aspect.a.Remove("irrational");
				aspect.a.Remove("vile");
				aspect.a.Remove("depressed");
				aspect.a.Remove("abusive");
				aspect.a.Remove("paranoid");
				aspect.a();
				return;
			}
			ax5 ax2 = Enumerable.FirstOrDefault<ax5>(A_0.h.b.aa().StatusEffects.Get<ax5>());
			if (ax2 != null)
			{
				A_0.h.b.aa().StatusEffects.d(ax2);
			}
			ekw ekw2 = Enumerable.FirstOrDefault<ekw>(A_0.h.b.aa().StatusEffects.Get<ekw>());
			if (ekw2 != null)
			{
				A_0.h.b.aa().StatusEffects.d(ekw2);
			}
			aspect.a.Remove("positiveAffliction");
			aspect.a.Remove("vigorous");
			aspect.a.Remove("stalwart");
			aspect.a.Remove("martyr");
			aspect.a.Remove("thankful");
			aspect.a.Remove("virtuous");
			aspect.a.Remove("courageous");
			aspect.a.Remove("negativeAffliction");
			aspect.a.Remove("weak");
			aspect.a.Remove("depleted");
			aspect.a.Remove("refracted");
			aspect.a.Remove("traitor");
			aspect.a.Remove("irrational");
			aspect.a.Remove("vile");
			aspect.a.Remove("depressed");
			aspect.a.Remove("abusive");
			aspect.a.Remove("paranoid");
			aspect.a();
		}
	}

	// Token: 0x06004455 RID: 17493 RVA: 0x001B4A80 File Offset: 0x001B2C80
	private bool a(c5x A_0, bool A_1)
	{
		if (A_0 == null)
		{
			return false;
		}
		if (A_1)
		{
			return A_0.a("positiveAffliction") || A_0.a("negativeAffliction");
		}
		return A_0.a("positiveAffliction");
	}

	// Token: 0x06004456 RID: 17494 RVA: 0x001B4AD4 File Offset: 0x001B2CD4
	private void b(c5x A_0)
	{
		e3l aspect = A_0.GetAspect<e3l>();
		if (aspect != null)
		{
			aspect.a.Remove("victorynorth");
			aspect.a.Remove("victorysouth");
			aspect.a.Remove("victorywest");
			aspect.a.Remove("victoryeast");
			aspect.a.Remove("defeatnorth");
			aspect.a.Remove("defeatsouth");
			aspect.a.Remove("defeatwest");
			aspect.a.Remove("defeateast");
			aspect.a.Remove("northShouldAttack");
			aspect.a.Remove("eastShouldAttack");
			aspect.a.Remove("southShouldAttack");
			aspect.a.Remove("westShouldAttack");
			aspect.a();
		}
	}

	// Token: 0x06004457 RID: 17495 RVA: 0x001B4BC0 File Offset: 0x001B2DC0
	private void a(c5x A_0)
	{
		e3l aspect = A_0.GetAspect<e3l>();
		if (aspect != null)
		{
			aspect.a.Remove("northET");
			aspect.a.Remove("eastET");
			aspect.a.Remove("westET");
			aspect.a.Remove("southET");
			aspect.a();
		}
	}

	// Token: 0x06004458 RID: 17496 RVA: 0x001B4C24 File Offset: 0x001B2E24
	private void a()
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null)
		{
			List<b0b> list = serviceOrThrow.aqw().a().ab4(new string[]
			{
				"voidFighter"
			});
			Enumerable.FirstOrDefault<b0b>(Enumerable.OrderBy<b0b, int>(list, new Func<b0b, int>(aow.a.a.b)));
			int num = 10;
			switch (serviceOrThrow.aqu().a())
			{
			case GameDifficulty.Normal:
				num = 9;
				break;
			case GameDifficulty.Hard:
				num = 8;
				break;
			case GameDifficulty.Dominating:
				num = 7;
				break;
			}
			foreach (b0b b0b in list)
			{
				c5x a_ = (c5x)b0b;
				if (num > 0)
				{
					if (!a_.a("negativeAffliction"))
					{
						break;
					}
					this.a(a_, new bool?(false));
					num--;
				}
			}
			foreach (b0b b0b2 in list)
			{
				c5x a_2 = (c5x)b0b2;
				if (num > 0)
				{
					if (this.a(a_2, true))
					{
						break;
					}
					if (a_2.a("sol"))
					{
						this.a(a_2, "sol", false);
					}
					if (a_2.a("med"))
					{
						this.a(a_2, "med", false);
					}
					if (a_2.a("int"))
					{
						this.a(a_2, "int", false);
					}
					num--;
				}
			}
		}
	}

	// Token: 0x06004459 RID: 17497 RVA: 0x001B4DF8 File Offset: 0x001B2FF8
	private void a(c5x A_0, a3f A_1, cnk A_2)
	{
		if (A_0.a("specialSquadAlive"))
		{
			switch ((int)A_1.a()["battleMomentum"])
			{
			case 6:
				if (A_2.aqu().a() == GameDifficulty.Dominating)
				{
					A_0.b("killSpecialSquad");
				}
				break;
			case 7:
				if (A_2.aqu().a() == GameDifficulty.Hard)
				{
					A_0.b("killSpecialSquad");
				}
				break;
			case 8:
				if (A_2.aqu().a() == GameDifficulty.Normal)
				{
					A_0.b("killSpecialSquad");
				}
				break;
			}
			if ((int)A_1.a()["battleMomentum"] > 8)
			{
				A_0.b("killSpecialSquad");
			}
		}
	}

	// Token: 0x02000BB5 RID: 2997
	[CompilerGenerated]
	[Serializable]
	private sealed class a
	{
		// Token: 0x0600445D RID: 17501 RVA: 0x001B4EE4 File Offset: 0x001B30E4
		internal int a(b0b A_0)
		{
			return cuo.a.Next();
		}

		// Token: 0x0600445E RID: 17502 RVA: 0x001B4EF0 File Offset: 0x001B30F0
		internal bool d(c5x A_0)
		{
			return !A_0.a("MarkedForDeath");
		}

		// Token: 0x0600445F RID: 17503 RVA: 0x001B4F00 File Offset: 0x001B3100
		internal int f(c5x A_0)
		{
			return cuo.a.Next();
		}

		// Token: 0x06004460 RID: 17504 RVA: 0x001B4F0C File Offset: 0x001B310C
		internal int a(c5x A_0)
		{
			return cuo.a.Next();
		}

		// Token: 0x06004461 RID: 17505 RVA: 0x001B4F18 File Offset: 0x001B3118
		internal int e(c5x A_0)
		{
			return cuo.a.Next();
		}

		// Token: 0x06004462 RID: 17506 RVA: 0x001B4F24 File Offset: 0x001B3124
		internal bool c(c5x A_0)
		{
			return !A_0.a("MarkedForDeath");
		}

		// Token: 0x06004463 RID: 17507 RVA: 0x001B4F34 File Offset: 0x001B3134
		internal int b(c5x A_0)
		{
			return cuo.a.Next();
		}

		// Token: 0x06004464 RID: 17508 RVA: 0x001B4F40 File Offset: 0x001B3140
		internal int b(b0b A_0)
		{
			return cuo.a.Next();
		}

		// Token: 0x04001C51 RID: 7249
		public static readonly aow.a a = new aow.a();

		// Token: 0x04001C52 RID: 7250
		public static Func<b0b, int> b;

		// Token: 0x04001C53 RID: 7251
		public static Func<c5x, bool> c;

		// Token: 0x04001C54 RID: 7252
		public static Func<c5x, int> d;

		// Token: 0x04001C55 RID: 7253
		public static Func<c5x, int> e;

		// Token: 0x04001C56 RID: 7254
		public static Func<c5x, int> f;

		// Token: 0x04001C57 RID: 7255
		public static Func<c5x, bool> g;

		// Token: 0x04001C58 RID: 7256
		public static Func<c5x, int> h;

		// Token: 0x04001C59 RID: 7257
		public static Func<b0b, int> i;
	}
}

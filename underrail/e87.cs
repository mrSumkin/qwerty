using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using TimelapseVertigo.Playfield.Locale;

// Token: 0x02000BC1 RID: 3009
[euj]
public class e87
{
	// Token: 0x060044D8 RID: 17624 RVA: 0x001BC6D0 File Offset: 0x001BA8D0
	[ayh("KHFAWM")]
	public void f(c5x A_0, c5x A_1, Dictionary<string, object> A_2)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow != null && serviceOrThrow.aqu() != null)
		{
			c5x c5x = serviceOrThrow.aqu().v().b() as c5x;
			if (c5x != null)
			{
				foreach (ya ya in Enumerable.ToList<ya>(c5x.Area.Triggers))
				{
					if (ya.Id == new Guid("9cdc0598-8bb4-4320-9178-1d4f96843374") || ya.Id == new Guid("156c3f5a-d79c-4cf4-8bbf-5dff3cbf2ed5") || ya.Id == new Guid("4ef7fbbb-916e-4c38-89bf-e8685e2e49d1") || ya.Id == new Guid("ee3900ba-5053-41ee-8b91-e9d89aafef5f") || ya.Id == new Guid("d0220c56-ee41-45fc-b5f1-bdc98b75f4a8") || ya.Id == new Guid("594ab6e1-f5cb-4d4c-87f6-017cf1fa0f05"))
					{
						ya.o();
					}
				}
				bv9 bv = serviceOrThrow.aqu().ac() as bv9;
				if (bv != null)
				{
					bv.a(asp.gl, asp.a, h.e, new h?(h.a), true, false, false);
					bv.a(asp.gl, asp.gm, h.a, null, true, false, false);
				}
				c5x c5x2 = new ar7(new Guid("0c0404f7-ab36-4376-99e0-4cd1f15b9ad5"), c5x.Area).ao() as c5x;
				c5x c5x3 = new ar7(new Guid("d98137b9-99eb-4833-aab5-8cbd6f77f6ad"), c5x.Area).ao() as c5x;
				c5x c5x4 = new ar7(new Guid("5c1e5cfc-622a-44e0-8394-f0760434d9a0"), c5x.Area).ao() as c5x;
				c5x c5x5 = new ar7(new Guid("ed4c482b-8631-4eba-95f3-fa47c4f254bd"), c5x.Area).ao() as c5x;
				serviceOrThrow.aqu().r()["npc_xpbl_kirillHunters_allied"] = true;
				if (c5x2 != null && c5x3 != null && c5x3 != null && c5x5 != null)
				{
					string a_ = "characters\\xpbl\\Gritz";
					bn5 bn = c5x2.GetAspect<j7>() as bn5;
					if (bn == null)
					{
						bn = new bn5(c5x2);
						c5x2.SetAspect<j7>(bn);
					}
					bn.b(a_);
					a_ = "characters\\xpbl\\Lars";
					bn = (c5x3.GetAspect<j7>() as bn5);
					if (bn == null)
					{
						bn = new bn5(c5x3);
						c5x3.SetAspect<j7>(bn);
					}
					bn.b(a_);
					a_ = "characters\\xpbl\\Senna";
					bn = (c5x4.GetAspect<j7>() as bn5);
					if (bn == null)
					{
						bn = new bn5(c5x4);
						c5x4.SetAspect<j7>(bn);
					}
					bn.b(a_);
					a_ = "characters\\xpbl\\Ven";
					bn = (c5x5.GetAspect<j7>() as bn5);
					if (bn == null)
					{
						bn = new bn5(c5x5);
						c5x5.SetAspect<j7>(bn);
					}
					bn.b(a_);
				}
			}
		}
	}

	// Token: 0x060044D9 RID: 17625 RVA: 0x001BC9F4 File Offset: 0x001BABF4
	[ayh("KHMHD")]
	public void b(c5x A_0, c5x A_1, Dictionary<string, object> A_2)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow != null && serviceOrThrow.aqu() != null)
		{
			c5x c5x = serviceOrThrow.aqu().v().b() as c5x;
			if (c5x != null && serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("npc_xpbl_kirillHunters_betrayed", new bool?(false)).Value && serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("npc_xpbl_kirillHunters_allied", new bool?(false)).Value && !serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("npc_xpbl_kirillAtLab", new bool?(false)).Value && !serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("loc_xpbl_kirillBattleStarted", new bool?(false)).Value && c5x.Zone.y8().Equals("xpbl_kirillLab2") && serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("powSrc_pwrSrc_xpbl_kirillLabPower", new bool?(false)).Value && !serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("npc_xpbl_kirill_dead", new bool?(false)).Value && serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("npc_xpbl_juraj_dead", new bool?(false)).Value && serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("npc_xpbl_gritz_dead", new bool?(false)).Value && serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("npc_xpbl_ven_dead", new bool?(false)).Value && serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("npc_xpbl_lars_dead", new bool?(false)).Value && serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("npc_xpbl_senna_dead", new bool?(false)).Value)
			{
				doq a_ = doq.a(Path.Combine(d5x.q(), "xpbl_kirillLab2_L2") + ".uzl");
				c5x.Zone.a(a_, 1, null);
				c5x c5x2 = new ar7(new Guid("5530751e-3a9a-4d30-8988-514fd9c18ef2"), c5x.Area).ao() as c5x;
				serviceOrThrow.aqu().r()["npc_xpbl_kirillHunters_betrayed"] = true;
				d60 d = c5x.Zone.a();
				if (d != null)
				{
					List<b0b> list = d.ab4(new string[]
					{
						"xpbl_kirillLab2_Mutants"
					});
					if (list != null)
					{
						foreach (b0b b0b in list)
						{
							c5x c5x3 = (c5x)b0b;
							a3f a3f = c5x3.GetAspect<a3f>();
							if (a3f == null)
							{
								a3f = new a3f(c5x3);
								c5x3.SetAspect<a3f>(a3f);
							}
							a3f.a()["BloodlessDeath"] = true;
							c5x3.h.b.aa().StatusEffects.a(new bk9(c5x3.h.b.aa(), 5, 5, false), false, false, false);
							c5x3.h.b.aa().a(null, null, false);
						}
						if (list.Count > 0)
						{
							serviceOrThrow.aqu().r()["loc_xpbl_kirillRoastedHunters"] = true;
							awx awx = new awx();
							awx awx2 = awx;
							awx2.a(awx2.kh() | m7.b);
							List<auv> list2 = awx.ad();
							bfq bfq = new bfq();
							bfq.c("FireballLaunch");
							bfq.a(0.8f);
							list2.Add(new a4s(bfq, new ar7(c5x), null, null));
							awx.ad().Add(new bm3(cuo.a.Next(500, 1200)));
							List<auv> list3 = awx.ad();
							bfq bfq2 = new bfq();
							bfq2.c("FireballExplode");
							bfq2.a(0.8f);
							list3.Add(new a4s(bfq2, new ar7(c5x), null, null));
							awx.ad().Add(new bm3(cuo.a.Next(300, 700)));
							List<auv> list4 = awx.ad();
							bfq bfq3 = new bfq();
							bfq3.c("FireballSpread");
							bfq3.a(0.6f);
							list4.Add(new a4s(bfq3, new ar7(c5x), null, null));
							awx.ad().Add(new bm3(cuo.a.Next(400, 600)));
							List<auv> list5 = awx.ad();
							bfq bfq4 = new bfq();
							bfq4.c("FireballSpread");
							bfq4.a(0.4f);
							list5.Add(new a4s(bfq4, new ar7(c5x), null, null));
							c5x.Zone.ActionManager.g9(awx, atp.a);
						}
						if (c5x2 != null)
						{
							serviceOrThrow.aqu().r()["npc_xpbl_kirillAtLab"] = true;
							a0l.a(c5x2, "global:xpbl_kirill:room", true);
							bm6 aspect = c5x2.GetAspect<bm6>();
							if (aspect != null)
							{
								aspect.y6()["GuardLoc"] = new bt4("global:xpbl_kirill:room");
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x060044DA RID: 17626 RVA: 0x001BCF60 File Offset: 0x001BB160
	[ayh("KHMHA")]
	public void d(c5x A_0, c5x A_1, Dictionary<string, object> A_2)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow != null && serviceOrThrow.aqu() != null)
		{
			c5x c5x = serviceOrThrow.aqu().v().b() as c5x;
			if (c5x != null)
			{
				cwt cwt = (cwt)A_2["attackResult"];
				if (cwt != null && cwt.i != null && c5x.h.b.aa().FactionId == cwt.i.b && serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("npc_xpbl_kirillHunters_allied", new bool?(false)).Value && !serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("npc_xpbl_kirillHunters_betrayed", new bool?(false)).Value)
				{
					serviceOrThrow.aqu().r()["npc_xpbl_kirillHunters_betrayed"] = true;
					awx awx = new awx();
					awx awx2 = awx;
					awx2.a(awx2.kh() | m7.b);
					List<auv> list = awx.ad();
					bd6 bd = new bd6();
					bd.a("xpbl_mutant_aidJuraj");
					bd.a(true);
					list.Add(new a4s(bd, new ar7(c5x), null, null));
					List<auv> list2 = awx.ad();
					bd6 bd2 = new bd6();
					bd2.a("xpbl_mutant_killKharon");
					bd2.a(true);
					list2.Add(new a4s(bd2, new ar7(c5x), null, null));
					if (c5x.Zone.y8().Equals("xpbl_kirillLab3") && !serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("loc_xpbl_kirillBattleStarted", new bool?(false)).Value)
					{
						List<auv> list3 = awx.ad();
						e80 e = new e80();
						e.a(false);
						list3.Add(new a4s(e, new ar7(c5x), null, null));
					}
					c5x.Zone.ActionManager.g9(awx, atp.a);
					if (c5x.Zone.y8().Equals("xpbl_kirillLab3") && !serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("loc_xpbl_kirillBattleStarted", new bool?(false)).Value)
					{
						bpo.GetServiceOrThrow<ps>().am3("Xpbl_KirillLab3_KirillArrivesToFightMuties");
					}
				}
			}
		}
	}

	// Token: 0x060044DB RID: 17627 RVA: 0x001BD198 File Offset: 0x001BB398
	[ayh("KHRMAKB")]
	public void a(c5x A_0, c5x A_1, Dictionary<string, object> A_2)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow != null && serviceOrThrow.aqu() != null)
		{
			c5x c5x = serviceOrThrow.aqu().v().b() as c5x;
			if (c5x != null)
			{
				c5x c5x2 = new ar7(new Guid("0c0404f7-ab36-4376-99e0-4cd1f15b9ad5"), c5x.Area).ao() as c5x;
				c5x c5x3 = new ar7(new Guid("5c1e5cfc-622a-44e0-8394-f0760434d9a0"), c5x.Area).ao() as c5x;
				c5x c5x4 = new ar7(new Guid("d4dd539d-3f2e-40cd-aed5-eba77c0bc2f8"), c5x.Area).ao() as c5x;
				awx awx = new awx();
				awx awx2 = awx;
				awx2.a(awx2.kh() | m7.b);
				if (c5x4 != null)
				{
					List<auv> list = awx.ad();
					doh doh = new doh();
					doh.a("juraj_leave");
					doh.a(new Guid?(c5x4.qe()));
					doh.a(bvl.e);
					list.Add(new a4s(doh, new ar7(c5x), null, null));
				}
				if (c5x3 != null)
				{
					List<auv> list2 = awx.ad();
					doh doh2 = new doh();
					doh2.a("senna_leave");
					doh2.a(new Guid?(c5x3.qe()));
					doh2.a(bvl.e);
					list2.Add(new a4s(doh2, new ar7(c5x), null, null));
				}
				if (c5x2 != null)
				{
					List<auv> list3 = awx.ad();
					doh doh3 = new doh();
					doh3.a("gritz_leave");
					doh3.a(new Guid?(c5x2.qe()));
					doh3.a(bvl.e);
					list3.Add(new a4s(doh3, new ar7(c5x), null, null));
				}
				List<auv> list4 = awx.ad();
				bfq bfq = new bfq();
				bfq.c("FireballSpread");
				bfq.a(0.4f);
				list4.Add(new a4s(bfq, new ar7(c5x), null, null));
				c5x.Zone.ActionManager.g9(awx, atp.a);
			}
		}
	}

	// Token: 0x060044DC RID: 17628 RVA: 0x001BD370 File Offset: 0x001BB570
	[ayh("KHMPFBWK")]
	public void e(c5x A_0, c5x A_1, Dictionary<string, object> A_2)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow != null && serviceOrThrow.aqu() != null)
		{
			c5x c5x = serviceOrThrow.aqu().v().b() as c5x;
			if (c5x != null)
			{
				d60 d = c5x.Zone.a();
				if (d != null)
				{
					List<b0b> list = d.ab4(new string[]
					{
						"xpbl_mutieHunters"
					});
					a12 a = new a12(ez2.CreateDefinitonProvider<c5s>("armor\\biohazardBoots"));
					if (a != null)
					{
						foreach (b0b b0b in list)
						{
							amc aspect = ((c5x)b0b).GetAspect<amc>();
							if (aspect != null)
							{
								if (aspect.aa().Gear.f().pp() != null)
								{
									aspect.aa().Bag.z3(aspect.aa().Gear.f().pp(), true);
								}
								aspect.aa().Gear.f().b(a);
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x060044DD RID: 17629 RVA: 0x001BD4A0 File Offset: 0x001BB6A0
	[ayh("KHWALL")]
	public void g(c5x A_0, c5x A_1, Dictionary<string, object> A_2)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow != null && serviceOrThrow.aqu() != null)
		{
			cka cka = serviceOrThrow.aqu().b().b("xpbl_juraj");
			if (cka != null)
			{
				cka.a(null);
			}
			cka = serviceOrThrow.aqu().b().b("xpbl_senna");
			if (cka != null)
			{
				cka.a(null);
			}
			cka = serviceOrThrow.aqu().b().b("xpbl_ven");
			if (cka != null)
			{
				cka.a(null);
			}
			cka = serviceOrThrow.aqu().b().b("xpbl_lars");
			if (cka != null)
			{
				cka.a(null);
			}
			cka = serviceOrThrow.aqu().b().b("xpbl_gritz");
			if (cka != null)
			{
				cka.a(null);
			}
			cka = serviceOrThrow.aqu().b().b("xpbl_kirill");
			if (cka != null)
			{
				cka.a(null);
			}
		}
	}

	// Token: 0x060044DE RID: 17630 RVA: 0x001BD598 File Offset: 0x001BB798
	[ayh("KHTKES")]
	public void c(c5x A_0, c5x A_1, Dictionary<string, object> A_2)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow != null && serviceOrThrow.aqu() != null)
		{
			c5x c5x = serviceOrThrow.aqu().v().b() as c5x;
			if (c5x != null)
			{
				c5x c5x2 = new ar7(new Guid("5530751e-3a9a-4d30-8988-514fd9c18ef2"), c5x.Area).ao() as c5x;
				if (c5x2 != null)
				{
					bm6 aspect = c5x2.GetAspect<bm6>();
					if (aspect != null)
					{
						if (c5x2.h.b.aa().CustomProperties.GetPrimitivePropertyValue<bool>("KirillEatingState", null) != null)
						{
							bool? primitivePropertyValue = c5x2.h.b.aa().CustomProperties.GetPrimitivePropertyValue<bool>("KirillEatingState", null);
							bool flag = false;
							if (!(primitivePropertyValue.GetValueOrDefault() == flag & primitivePropertyValue != null))
							{
								c5x2.h.b.aa().CustomProperties["KirillEatingState"] = false;
								c5x2.h.b.aa().Portrait = "kiril_withmask";
								dtb dtb = new dtb();
								serviceOrThrow.aqu().r()["npc_xpbl_kirillKitchen"] = false;
								List<auv> list = dtb.ad();
								hx hx = new hx();
								hx.a(new List<string>
								{
									"GuardAnimation"
								});
								list.Add(new a4s(hx, null, null, null));
								List<auv> list2 = dtb.ad();
								bx2 bx = new bx2();
								bx.a(new Guid?(c5x2.qe()));
								bx.b(c5x2.Area.y8());
								bx.a("kiril_withmask");
								list2.Add(new a4s(bx, null, null, null));
								List<auv> list3 = dtb.ad();
								a4s a4s = new a4s(new epw(new CharacterState?(CharacterState.Idle)), null, null, null);
								a4s.b(new ar7(c5x2));
								list3.Add(a4s);
								serviceOrThrow.aqw().ActionManager.g9(dtb, atp.a);
								return;
							}
						}
						dtb dtb2 = new dtb();
						List<auv> list4 = dtb2.ad();
						hx hx2 = new hx();
						hx2.a(new List<string>
						{
							ddq.k
						});
						a4s a4s2 = new a4s(hx2, null, null, null);
						a4s2.b(new ar7(c5x2));
						list4.Add(a4s2);
						List<auv> list5 = dtb2.ad();
						hx hx3 = new hx();
						hx3.a(new List<string>
						{
							ddq.l
						});
						a4s a4s3 = new a4s(hx3, null, null, null);
						a4s3.b(new ar7(c5x2));
						list5.Add(a4s3);
						serviceOrThrow.aqw().ActionManager.g9(dtb2, atp.a);
						c5x2.h.b.aa().CustomProperties["KirillEatingState"] = true;
						aspect.y6()[ddq.ay] = new bt4("global:xpbl_kirill:kirillEat");
						aspect.y6()[ddq.az] = true;
						aspect.y6()[ddq.w] = CharacterState.Custom3;
						c5x2.h.b.aa().Portrait = "kiril_maskdown";
						serviceOrThrow.aqu().r()["npc_xpbl_kirillKitchen"] = true;
						return;
					}
				}
			}
		}
	}
}

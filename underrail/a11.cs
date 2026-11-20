using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Ouroboros.Playfield.Space;
using TimelapseVertigo.Rules;
using TimelapseVertigo.Rules.Characters;
using TimelapseVertigo.Rules.Combat;
using TimelapseVertigo.Rules.Items;

// Token: 0x02000BC3 RID: 3011
[euj]
public class a11
{
	// Token: 0x060044E3 RID: 17635 RVA: 0x001BD9EC File Offset: 0x001BBBEC
	[ayh("DITJFEH")]
	public void o(c5x A_0, c5x A_1, Dictionary<string, object> A_2)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null && serviceOrThrow.aqu().v() != null && !serviceOrThrow.aqu().v().Dead)
		{
			if (serviceOrThrow.aqw().y8() == "dun_up_it5" && serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("dun_up_it5_demiseDefeated", new bool?(false)).Value)
			{
				serviceOrThrow.aqw().CustomProperties["SavingDisabled"] = false;
			}
			d02 service = bpo.GetService<d02>();
			if (service != null)
			{
				foreach (d4n d4n in Enumerable.ToList<d4n>(service.ahl()))
				{
					if (Enumerable.FirstOrDefault<a0s>(d4n.b.aa().StatusEffects.Get<a0s>()) != null)
					{
						a0s a0s = Enumerable.FirstOrDefault<a0s>(d4n.b.aa().StatusEffects.Get<a0s>());
						if (a0s != null)
						{
							switch (this.a(serviceOrThrow, d4n))
							{
							case 1:
								a0s.c(1000.0);
								break;
							case 2:
								a0s.c(2500.0);
								break;
							case 3:
								a0s.c(3500.0);
								break;
							case 4:
								a0s.c(6000.0);
								break;
							}
						}
					}
					else if (Enumerable.FirstOrDefault<bk9>(d4n.b.aa().StatusEffects.Get<bk9>()) == null && !d4n.b.a8().a("dun_up_it_freezeImmune"))
					{
						int num = this.a(serviceOrThrow, d4n);
						b31 b = Enumerable.FirstOrDefault<b31>(d4n.b.aa().StatusEffects.Get<b31>());
						if (b != null)
						{
							int num2 = 0;
							switch (num)
							{
							case 1:
								num2 = 5;
								break;
							case 2:
								num2 = 10;
								break;
							case 3:
								num2 = 20;
								break;
							case 4:
								num2 = 45;
								break;
							}
							if (b.Stacks < num2)
							{
								b31 b2 = b;
								int num3 = b2.Stacks;
								b2.Stacks = num3 + 1;
								if (num == 4)
								{
									b31 b3 = b;
									num3 = b3.Stacks;
									b3.Stacks = num3 + 1;
									b31 b4 = b;
									num3 = b4.Stacks;
									b4.Stacks = num3 + 1;
								}
								if (num == 3)
								{
									b31 b5 = b;
									num3 = b5.Stacks;
									b5.Stacks = num3 + 1;
								}
							}
							else if (b.Stacks > num2)
							{
								b31 b6 = b;
								int num3 = b6.Stacks;
								b6.Stacks = num3 - 1;
							}
							b.ad();
							if (b.Stacks > 15 && !awq.a(d4n.b, null, CharacterImmunities.Chill, "эффекту переохлаждения", true))
							{
								b34 b7 = Enumerable.FirstOrDefault<b34>(d4n.b.aa().StatusEffects.Get<b34>());
								if (b7 == null)
								{
									d4n.b.aa().StatusEffects.a(new b34(d0u.b * 4, h7.i), false, false, false);
								}
								else
								{
									b7.Stacks = d05.a(5, b7.Stacks + 1);
									b7.ad();
								}
							}
						}
						else
						{
							b31 a_ = new b31();
							d4n.b.aa().StatusEffects.a(a_, false, false, false);
						}
					}
					if (Enumerable.FirstOrDefault<a2>(d4n.b.aa().StatusEffects.Get<a2>()) == null)
					{
						a3f aspect = d4n.b.a8().GetAspect<a3f>();
						if (aspect != null && d4n.b.aa().FactionId != asp.a && d4n.b.a8().a("dun_up_it_shouldFreeze") && aspect.a()["OldFaction"] != null)
						{
							if (aspect.a()["OldFaction"].Equals("neutral"))
							{
								d4n.b.aa().FactionId = "monsters";
							}
							else
							{
								d4n.b.aa().FactionId = aspect.a()["OldFaction"].ToString();
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x060044E4 RID: 17636 RVA: 0x001BDEA4 File Offset: 0x001BC0A4
	[ayh("DITJAPI")]
	public void m(c5x A_0, c5x A_1, Dictionary<string, object> A_2)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow != null)
		{
			d60 d = serviceOrThrow.aqw().a();
			if (d != null)
			{
				List<b0b> list = d.ab4(new string[]
				{
					"frozenPipe_btm"
				});
				foreach (b0b b0b in list)
				{
					c5x c5x = (c5x)b0b;
				}
				list.Clear();
				list = d.ab4(new string[]
				{
					"frozenPipe_up"
				});
				foreach (b0b b0b2 in list)
				{
					c5x c5x2 = (c5x)b0b2;
				}
			}
		}
	}

	// Token: 0x060044E5 RID: 17637 RVA: 0x001BDF88 File Offset: 0x001BC188
	[ayh("DITJCWBE")]
	public void e(c5x A_0, c5x A_1, Dictionary<string, object> A_2)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null)
		{
			dm5 dm = new dm5();
			dm.a(new AmmoType?(AmmoType.None));
			dm.a("*");
			dm.d("Cold Wind");
			dm.a(0.0);
			dm.s().Add(new a1q(DamageType.Cold, 15, 30));
			dm.b(0);
			dm.c("ColdHit");
			dm.d(true);
			dm.a(17);
			dm.b("HauntingWindMild");
			dm.b(false);
			dm.c(false);
			dm.a(false);
			dtb dtb = new dtb();
			dtb.ad().Add(new bm3(cuo.a.Next(12000, 36000)));
			for (int i = 0; i < 2; i++)
			{
				dtb.ad().Add(new a4s(dm, null, new ar7(A_1), null));
				dtb.ad().Add(new bm3(cuo.a.Next(15000, 30000)));
			}
			serviceOrThrow.aqw().ActionManager.g9(dtb, atp.a);
		}
	}

	// Token: 0x060044E6 RID: 17638 RVA: 0x001BE0BC File Offset: 0x001BC2BC
	private int a(cnk A_0, d4n A_1)
	{
		string text = A_1.b.a8().Area.y8();
		List<int> classPropertyValue = A_0.aqu().r().GetClassPropertyValue<List<int>>("frag_dun_up_it_coldLevels");
		if (classPropertyValue != null && classPropertyValue.Count >= 3)
		{
			if (text.Equals("dun_up_it2") || text.Equals("dun_up_it2_entrance") || text.Equals("dun_up_it2_sideRoom"))
			{
				return classPropertyValue[0];
			}
			if (text.Equals("dun_up_it2_up") || text.Equals("dun_up_it2_sideRoomUp"))
			{
				return classPropertyValue[1];
			}
			if (text.Equals("dun_up_it3") || text.Equals("dun_up_it3_northSideRoom") || text.Equals("dun_up_it3_westSideRoom"))
			{
				return classPropertyValue[2];
			}
			if (text.Equals("dun_up_it3_up") || text.Equals("dun_up_it3_up1") || text.Equals("dun_up_it3_outside"))
			{
				if (A_0.aqu().ae() >= GameDifficulty.Hard)
				{
					return classPropertyValue[3];
				}
				return classPropertyValue[2];
			}
			else if (text.Equals("dun_up_it4_up") || text.Equals("dun_up_it4_up1") || text.Equals("dun_up_it4_outside") || text.Equals("dun_up_it4_westSideRoom") || text.Equals("dun_up_it4_northSideRoom") || text.Equals("dun_up_it5_up") || text.Equals("dun_up_it5") || text.Equals("dun_up_it5_northSideRoom") || text.Equals("dun_up_it5_dom") || text.Equals("dun_up_it5_domOutside"))
			{
				return classPropertyValue[3];
			}
		}
		return 1;
	}

	// Token: 0x060044E7 RID: 17639 RVA: 0x001BE29C File Offset: 0x001BC49C
	[ayh("DITJRRL")]
	public void n(c5x A_0, c5x A_1, Dictionary<string, object> A_2)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		d60 d = serviceOrThrow.aqw().a();
		if (serviceOrThrow != null && !serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("frag_dun_up_it5_riddleEnded", new bool?(false)).Value)
		{
			serviceOrThrow.aqu().r()["frag_dun_up_it_solvedLockers"] = 0;
			foreach (b0b b0b in d.ab4(new string[]
			{
				"RiddleLockers"
			}))
			{
				c5x c5x = (c5x)b0b;
				if (c5x.a("RiddleLockers"))
				{
					e3l e3l = c5x.GetAspect<e3l>();
					if (e3l == null)
					{
						e3l = new e3l(c5x);
						c5x.SetAspect<e3l>(e3l);
					}
					e3l.a.Clear();
				}
				c5x.b("RiddleLockers");
				c5x.b("VanishLocker");
			}
		}
	}

	// Token: 0x060044E8 RID: 17640 RVA: 0x001BE3B4 File Offset: 0x001BC5B4
	[ayh("DITJFRL")]
	public void d(c5x A_0, c5x A_1, Dictionary<string, object> A_2)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow != null && !serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("frag_dun_up_it5_riddleEnded", new bool?(false)).Value && A_1 != null && A_1.a("RiddleLockers") && !A_1.a("LockerActive"))
		{
			if (serviceOrThrow.aqu().r().GetPrimitivePropertyValue<int>("frag_dun_up_it_solvedLockers", new int?(0)).Value < 5)
			{
				serviceOrThrow.aqu().r()["frag_dun_up_it_solvedLockers"] = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<int>("frag_dun_up_it_solvedLockers", new int?(0)).Value + 1;
				A_1.b("LockerActive");
				return;
			}
			if (serviceOrThrow.aqu().r().GetPrimitivePropertyValue<int>("frag_dun_up_it_solvedLockers", new int?(0)).Value == 5)
			{
				coh coh = new d48(ez2.CreateDefinitonProvider<cv9>("consumables\\medicine\\advancedHealthHypo"));
				coh.Stacks = 3;
				coh.Lootable = false;
				coh.Stealable = false;
				coh coh2 = new d48(ez2.CreateDefinitonProvider<cv9>("consumables\\medicine\\bandage"));
				coh2.Stacks = 4;
				coh2.Lootable = false;
				coh2.Stealable = false;
				coh coh3 = new d48(ez2.CreateDefinitonProvider<cv9>("consumables\\medicine\\regenerativeMixture"));
				coh3.Stacks = 2;
				coh3.Lootable = false;
				coh3.Stealable = false;
				fv fv = new fv(ez2.CreateDefinitonProvider<a1k>("components\\chemicals\\coal"));
				fv.Stacks = 3;
				fv.Lootable = false;
				fv.Stealable = false;
				coh coh4 = new d48(ez2.CreateDefinitonProvider<cv9>("consumables\\medicine\\psiBooster"));
				coh4.Stacks = 3;
				coh4.Lootable = false;
				coh4.Stealable = false;
				us us = new us();
				us.a("::Предметы кажутся тёплыми на ощупь.::");
				us.a(bvl.d);
				us.ym(A_0, A_0, null);
				A_1.RemoveAspect<e3l>();
				c7j c7j = A_1.GetAspect<bim>() as c7j;
				if (c7j != null)
				{
					c7j.ItemContainer.z3(coh, true);
					c7j.ItemContainer.z3(coh2, true);
					c7j.ItemContainer.z3(coh3, true);
					c7j.ItemContainer.z3(fv, true);
					c7j.ItemContainer.z3(coh4, true);
				}
				this.c(A_0, A_1, null);
			}
		}
	}

	// Token: 0x060044E9 RID: 17641 RVA: 0x001BE610 File Offset: 0x001BC810
	[ayh("DITJERR")]
	public void c(c5x A_0, c5x A_1, Dictionary<string, object> A_2)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		d60 d = serviceOrThrow.aqw().a();
		if (serviceOrThrow != null)
		{
			serviceOrThrow.aqu().r()["frag_dun_up_it5_riddleEnded"] = true;
			serviceOrThrow.aqw().n("dun_up_it5_northSideRoom").StartingLightning = new Color((int)(serviceOrThrow.aqw().n("dun_up_it5_northSideRoom").StartingLightning.R + 45), (int)(serviceOrThrow.aqw().n("dun_up_it5_northSideRoom").StartingLightning.G + 45), (int)(serviceOrThrow.aqw().n("dun_up_it5_northSideRoom").StartingLightning.B + 45));
			for (int i = 0; i < serviceOrThrow.aqw().n("dun_up_it5_northSideRoom").Size.c; i++)
			{
				for (int j = 0; j < serviceOrThrow.aqw().n("dun_up_it5_northSideRoom").Size.d; j++)
				{
					ak1 ak = serviceOrThrow.aqw().n("dun_up_it5_northSideRoom").b(i, j);
					if (ak != null)
					{
						ak.e();
					}
				}
			}
			c7j c7j = A_1.GetAspect<bim>() as c7j;
			if (c7j != null)
			{
				dtb dtb = new dtb();
				List<auv> list = dtb.ad();
				a4s a4s = new a4s(new bfq("DarkSecretReveal", "DarkSecretReveal"), null, null, null);
				a4s.b(new ar7(A_0));
				list.Add(a4s);
				A_0.Zone.ActionManager.g9(dtb, atp.a);
				foreach (b0b b0b in d.ab4(new string[]
				{
					"VanishLocker"
				}))
				{
					c5x c5x = (c5x)b0b;
					c7j c7j2 = c5x.GetAspect<bim>() as c7j;
					if (c7j2 != null)
					{
						dtb dtb2 = new dtb();
						c7j2.g(false);
						foreach (coh coh in Enumerable.ToList<coh>(c7j2.ItemContainer.z2()))
						{
							if (coh.Definition is x2 || (coh.Lootable && coh.Stealable))
							{
								c7j.ItemContainer.z3(coh, true);
							}
						}
						List<auv> list2 = dtb2.ad();
						ad6 ad = new ad6(c5x);
						ad.b(1.0);
						ad.c(0.0);
						ad.a(0.0015);
						list2.Add(ad);
						dtb2.ad().Add(new c7(c5x, false, false, true, false));
						A_0.Zone.ActionManager.g9(dtb2, atp.a);
					}
				}
			}
		}
	}

	// Token: 0x060044EA RID: 17642 RVA: 0x001BE92C File Offset: 0x001BCB2C
	[ayh("DITJRRLFR")]
	public void a(c5x A_0, c5x A_1, Dictionary<string, object> A_2)
	{
		cnk service = bpo.GetService<cnk>();
		if (service != null && service.aqu() != null && A_0 != null && A_0.Zone != null)
		{
			service.aqw().n("dun_up_it5_northSideRoom").StartingLightning = new Color((int)(service.aqw().n("dun_up_it5_northSideRoom").StartingLightning.R - 15), (int)(service.aqw().n("dun_up_it5_northSideRoom").StartingLightning.G - 15), (int)(service.aqw().n("dun_up_it5_northSideRoom").StartingLightning.B - 15));
			for (int i = 0; i < service.aqw().n("dun_up_it5_northSideRoom").Size.c; i++)
			{
				for (int j = 0; j < service.aqw().n("dun_up_it5_northSideRoom").Size.d; j++)
				{
					ak1 ak = service.aqw().n("dun_up_it5_northSideRoom").b(i, j);
					if (ak != null)
					{
						ak.e();
					}
				}
			}
		}
	}

	// Token: 0x060044EB RID: 17643 RVA: 0x001BEA54 File Offset: 0x001BCC54
	[ayh("DITJWT")]
	public void v(c5x A_0, c5x A_1, Dictionary<string, object> A_2)
	{
		cnk service = bpo.GetService<cnk>();
		if (A_0 == null && A_1 != null)
		{
			A_0 = A_1;
		}
		if (service == null || service.aqu() == null)
		{
			return;
		}
		this.a(service);
		this.a(A_0, service);
	}

	// Token: 0x060044EC RID: 17644 RVA: 0x001BEA98 File Offset: 0x001BCC98
	private void a(c5x A_0, cnk A_1)
	{
		d02 service = bpo.GetService<d02>();
		if (service != null)
		{
			foreach (d4n d4n in Enumerable.ToList<d4n>(service.ahl()))
			{
				foreach (ya ya in A_0.Area.Triggers)
				{
					if (ya.Name.Contains("WindZone"))
					{
						if (A_1.aqu().ae() >= GameDifficulty.Hard && d4n.b.a8().Location.X >= (float)ya.Location.X && d4n.b.a8().Location.Y >= (float)ya.Location.Y && d4n.b.a8().Location.X <= (float)(ya.Size.c + ya.Location.X) && d4n.b.a8().Location.Y <= (float)(ya.Size.d + ya.Location.Y) && !d4n.b.a8().a("dun_up_it_freezeImmune"))
						{
							float num;
							if (a11.a > 45f)
							{
								num = a11.a / 3f;
							}
							else if (a11.a > 30f)
							{
								num = a11.a / 4f;
							}
							else
							{
								num = a11.a / 5f;
							}
							if (num > 1f && !d4n.b.aa().Ethereal)
							{
								cwt cwt = new cwt();
								cwt.j = new ap9(d4n.b.aa());
								cwt.l = true;
								cwt.y = "{2} получает второе дыхание на ";
								cwt.f.Add(new csk(DamageType.Cold, (int)num));
								cwt.k = "Wind";
								cwt.q = false;
								cwt.b = true;
								cwt.c = new bool?(false);
								cwt.h = ImpactSpeed.VeryHigh;
								cwt.w = true;
								d4n.b.aa().Defense.a(cwt);
							}
							c5x c5x = Enumerable.FirstOrDefault<b0b>(A_1.aqw().a().ab4(new string[]
							{
								"dun_up_it_WindAudio"
							})) as c5x;
							if (c5x != null)
							{
								c5x.Location = new Vector3(d4n.b.a8().Location.X, d4n.b.a8().Location.Y, 0f);
								c5x.ah();
							}
						}
						else if (d4n.b.a8().Location.X > (float)ya.Location.X && d4n.b.a8().Location.Y > (float)ya.Location.Y && !d4n.b.a8().a("dun_up_it_freezeImmune") && d4n.b.a8().Location.X < (float)(ya.Size.c + ya.Location.X) && d4n.b.a8().Location.Y < (float)(ya.Size.d + ya.Location.Y))
						{
							float num2;
							if (a11.a > 35f)
							{
								num2 = a11.a / 3f;
							}
							else if (a11.a > 20f)
							{
								num2 = a11.a / 4f;
							}
							else
							{
								num2 = a11.a / 5f;
							}
							if (num2 > 1f && !d4n.b.aa().Ethereal)
							{
								cwt cwt2 = new cwt();
								cwt2.j = new ap9(d4n.b.aa());
								cwt2.l = true;
								cwt2.y = "{2} получает второе дыхание на ";
								cwt2.f.Add(new csk(DamageType.Cold, (int)num2));
								cwt2.k = "Wind";
								cwt2.q = false;
								cwt2.b = true;
								cwt2.c = new bool?(false);
								cwt2.h = ImpactSpeed.VeryHigh;
								cwt2.w = true;
								d4n.b.aa().Defense.a(cwt2);
							}
							c5x c5x2 = Enumerable.FirstOrDefault<b0b>(A_1.aqw().a().ab4(new string[]
							{
								"dun_up_it_WindAudio"
							})) as c5x;
							if (c5x2 != null)
							{
								c5x2.Location = new Vector3(d4n.b.a8().Location.X, d4n.b.a8().Location.Y, 0f);
								c5x2.ah();
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x060044ED RID: 17645 RVA: 0x001BF030 File Offset: 0x001BD230
	private void a(cnk A_0)
	{
		c5x c5x = Enumerable.FirstOrDefault<b0b>(A_0.aqw().a().ab4(new string[]
		{
			"dun_up_it_windController"
		})) as c5x;
		if (c5x != null)
		{
			a3f aspect = c5x.GetAspect<a3f>();
			if (aspect != null)
			{
				int num = aspect.a().GetPrimitivePropertyValue<int>("WindPower", new int?(0)).Value;
				bool flag = aspect.a().GetPrimitivePropertyValue<bool>("Tide", new bool?(false)).Value;
				if (flag)
				{
					if (num < 70)
					{
						if (A_0.aqu().ae() >= GameDifficulty.Hard)
						{
							num++;
						}
						num++;
					}
					else
					{
						flag = false;
						num = 68;
					}
				}
				else if (num > 1)
				{
					if (A_0.aqu().ae() >= GameDifficulty.Hard)
					{
						num--;
					}
					num--;
				}
				else
				{
					flag = true;
					num = 1;
				}
				a11.a = (float)num;
				aspect.a()["WindPower"] = num;
				aspect.a()["Tide"] = flag;
				foreach (b0b b0b in A_0.aqw().a().ab4(new string[]
				{
					"dun_up_it_windSource"
				}))
				{
					d68 aspect2 = ((c5x)b0b).GetAspect<d68>();
					if (aspect2 != null)
					{
						aspect2.a((int)a11.a * 6);
					}
				}
				c5x c5x2 = Enumerable.FirstOrDefault<b0b>(A_0.aqw().a().ab4(new string[]
				{
					"dun_up_it_WindAudio"
				})) as c5x;
				if (c5x2 != null)
				{
					aru aspect3 = c5x2.GetAspect<aru>();
					if (aspect3 != null)
					{
						app app;
						aspect3.e().TryGetValue("HauntingWindMild", out app);
						if (app != null)
						{
							c5x2.v.b.a("HauntingWindMild", MathHelper.Clamp(a11.a / 35f, 0.02f, 0.98f));
						}
					}
				}
			}
		}
	}

	// Token: 0x060044EE RID: 17646 RVA: 0x001BF25C File Offset: 0x001BD45C
	[ayh("DITJIRCSC")]
	public void r(c5x A_0, c5x A_1, Dictionary<string, object> A_2)
	{
		int value = bpo.GetServiceOrThrow<cnk>().aqu().r().GetPrimitivePropertyValue<int>("frag_dun_up_it_coilSpidersKillCount", new int?(0)).Value;
		if (A_0 != null && cuo.a.Next(0, 3) < 2 && value > 2)
		{
			this.a("dun_up_it_coilSpiderRemnant", A_0);
		}
	}

	// Token: 0x060044EF RID: 17647 RVA: 0x001BF2BC File Offset: 0x001BD4BC
	[ayh("DITJIRIC")]
	public void j(c5x A_0, c5x A_1, Dictionary<string, object> A_2)
	{
		int value = bpo.GetServiceOrThrow<cnk>().aqu().r().GetPrimitivePropertyValue<int>("frag_dun_up_it_industrialBotKillCount", new int?(0)).Value;
		if (A_0 != null && cuo.a.Next(0, 3) < 2 && value > 0)
		{
			this.a("dun_up_it_industrialRemnant", A_0);
		}
	}

	// Token: 0x060044F0 RID: 17648 RVA: 0x001BF31C File Offset: 0x001BD51C
	[ayh("DITJIRCC")]
	public void p(c5x A_0, c5x A_1, Dictionary<string, object> A_2)
	{
		int value = bpo.GetServiceOrThrow<cnk>().aqu().r().GetPrimitivePropertyValue<int>("frag_dun_up_it_crawlerKillCount", new int?(0)).Value;
		if (A_0 != null && cuo.a.Next(0, 3) < 2 && value > 2)
		{
			this.a("dun_up_it_crawlerRemnant", A_0);
		}
	}

	// Token: 0x060044F1 RID: 17649 RVA: 0x001BF37C File Offset: 0x001BD57C
	private void a(string A_0, c5x A_1)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow != null)
		{
			d60 d = serviceOrThrow.aqw().a();
			if (d != null)
			{
				bool flag = false;
				using (List<b0b>.Enumerator enumerator = d.ab4(new string[]
				{
					A_0
				}).GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						if (((c5x)enumerator.Current).Area == A_1.Area)
						{
							flag = true;
							return;
						}
						flag = false;
					}
				}
				if (!flag)
				{
					c5x c5x = serviceOrThrow.aqu().v().b() as c5x;
					if (c5x != null && c5x.Area == A_1.Area)
					{
						bt4 bt = this.a(A_1);
						if (bt != null)
						{
							ezd ezd = new ezd("Locale\\Creatures\\IceRemnant", bt, null, null, null, null, null);
							ezd.ym(A_1, null, null);
							c5x c5x2 = ezd.f().ao() as c5x;
							if (c5x2 != null)
							{
								c5x2.b(A_0);
								c5x2.b("dun_up_it_freezeImmune");
								c5x2.t.b.b("iceRemnant");
								c5x2.t.b.c("iceRemnant");
								c5x2.h.b.aa().StatusEffects.a(new d0j(0), false, false, false);
								c5x2.t.b.y6()[ddq.bm] = true;
								c5x2.t.b.y6()[ddq.bn] = 5;
								c5x2.t.b.y6()[ddq.bo] = 2;
								c5x2.h.b.a(this.b(A_0));
								c5x2.c().a("PsionicProxyLoop", "PsionicProxyLoop", 0.5f, c9z.b, true, false);
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x060044F2 RID: 17650 RVA: 0x001BF5B0 File Offset: 0x001BD7B0
	private bt4 a(c5x A_0)
	{
		List<ak1> list = new List<ak1>();
		for (int i = 0; i < A_0.Area.Size.c; i++)
		{
			for (int j = 0; j < A_0.Area.Size.d; j++)
			{
				ak1 ak = A_0.Area.b(i, j);
				if (Enumerable.Count<b0b>(ak.c.Values, new Func<b0b, bool>(a11.a.a.a)) > 0 && !aw1.a(ak, false, null, l9.a) && !ak.b(dm9.b))
				{
					list.Add(ak);
				}
			}
		}
		if (list.Count > 0)
		{
			ak1 ak2 = list[cuo.a.Next(list.Count)];
			return new bt4(A_0.Area.y8(), new Vector3((float)ak2.Location.X, (float)ak2.Location.Y, 0f));
		}
		return null;
	}

	// Token: 0x060044F3 RID: 17651 RVA: 0x001BF6CC File Offset: 0x001BD8CC
	private string b(string A_0)
	{
		if (!(A_0 == "dun_up_it_coilSpiderRemnant"))
		{
			if (A_0 == "dun_up_it_industrialRemnant")
			{
				return "thread_bot";
			}
			if (!(A_0 == "dun_up_it_crawlerRemnant"))
			{
				return "crawler";
			}
			if (cuo.a.Next(0, 3) < 2)
			{
				return "greater_crawler";
			}
			return "crawler";
		}
		else
		{
			if (cuo.a.Next(0, 3) < 2)
			{
				return "greater_coil_spider";
			}
			return "coil_spider";
		}
	}

	// Token: 0x060044F4 RID: 17652 RVA: 0x001BF758 File Offset: 0x001BD958
	[ayh("DITJKWSP")]
	public void u(c5x A_0, c5x A_1, Dictionary<string, object> A_2)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow != null)
		{
			c5x c5x = serviceOrThrow.aqu().v().b() as c5x;
			if (c5x != null)
			{
				nb nb = new nb();
				nb.a(true);
				nb.a(bvl.d);
				nb.ym(c5x, c5x, null);
			}
		}
	}

	// Token: 0x060044F5 RID: 17653 RVA: 0x001BF7A8 File Offset: 0x001BD9A8
	[ayh("DITJASWTP")]
	public void f(c5x A_0, c5x A_1, Dictionary<string, object> A_2)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow != null)
		{
			if (A_1 != null)
			{
				e01 e = new e01();
				e.a("IceWallExplosion");
				e.b(true);
				e.a(1);
				e.ym(A_1, A_1, null);
			}
			c5x c5x = serviceOrThrow.aqu().v().b() as c5x;
			if (c5x != null)
			{
				de1 de = Enumerable.FirstOrDefault<de1>(c5x.h.b.aa().StatusEffects.Get<de1>());
				if (de != null)
				{
					if (de.Stacks < de.MaxStacks)
					{
						de1 de2 = de;
						int num = de2.Stacks;
						de2.Stacks = num + 1;
					}
					de.ad();
					return;
				}
				de1 a_ = new de1();
				c5x.h.b.aa().StatusEffects.a(a_, false, false, false);
			}
		}
	}

	// Token: 0x060044F6 RID: 17654 RVA: 0x001BF880 File Offset: 0x001BDA80
	[ayh("DITJCDSE")]
	public void g(c5x A_0, c5x A_1, Dictionary<string, object> A_2)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow != null && A_1 != null)
		{
			c5x c5x = serviceOrThrow.aqu().v().b() as c5x;
			if (c5x != null)
			{
				serviceOrThrow.aqu().r()["loc_dun_up_it_domFightStarted"] = true;
				c5x c5x2 = new ar7(new Guid("4e91ac09-78b8-455d-b23e-eb6dc13db338"), c5x.Area).ao() as c5x;
				ezd a_ = new ezd("Locale\\Creatures\\ColdDeath", new bt4(c5x.Area.y8(), c5x2.Location), new HorizontalDirection?(HorizontalDirection.South), null, null, null, null);
				ad6 ad = new ad6(c5x2);
				ad.b(0.0);
				ad.c(1.0);
				ad.a(0.0005);
				ad6 item = ad;
				dtb dtb = new dtb();
				dtb.ad().Add(item);
				dtb.ad().Add(new a4s(new bfq("IceWallFreeze"), null, new ar7(c5x), null));
				List<auv> list = dtb.ad();
				dqm dqm = new dqm(c5x2.o.b);
				dqm.b(0);
				dqm.c(25);
				dqm.a((double)dz6.b(50));
				list.Add(dqm);
				List<auv> list2 = dtb.ad();
				aud a_2 = c5x.Area;
				Vector3 a_3 = c5x2.Location + new Vector3(0f, 0f, 0.5f);
				string a_4 = "IceWallExplosion";
				int a_5 = 1;
				double maxValue = double.MaxValue;
				float? a_6 = new float?(dz6.c());
				list2.Add(new au0(a_2, a_3, a_4, a_5, maxValue, null, null, a_6));
				dtb.ad().Add(new a4s(new bfq("IceShattering"), null, new ar7(c5x), null));
				dtb.ad().Add(new c7(c5x2, false, false, true, false));
				dtb.ad().Add(new a4s(a_, new ar7(c5x), null, null));
				c5x.Zone.ActionManager.g9(dtb, atp.a);
				c5x c5x3 = new ar7(new Guid("b8d219e9-6a7e-4c8f-ad27-aef772444bb1"), serviceOrThrow.aqw().n("dun_up_it5_dom")).ao() as c5x;
				this.a(true, c5x);
				if (c5x3 != null)
				{
					a3f aspect = c5x3.GetAspect<a3f>();
					if (aspect != null)
					{
						foreach (string g in aspect.a().GetClassPropertyValue<List<string>>("RestlessSpirits"))
						{
							c5x c5x4 = new ar7(new Guid(g), c5x.Area).ao() as c5x;
							if (c5x4 != null)
							{
								c5x4.s.b.g(true);
							}
						}
						t6 aspect2 = c5x3.GetAspect<t6>();
						if (aspect2 != null)
						{
							aspect2.a(true);
						}
					}
					this.a();
				}
			}
		}
	}

	// Token: 0x060044F7 RID: 17655 RVA: 0x001BFBA0 File Offset: 0x001BDDA0
	private void a()
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		c5x c5x = serviceOrThrow.aqu().v().b() as c5x;
		if (c5x != null)
		{
			c5x c5x2 = new ar7(new Guid("b8d219e9-6a7e-4c8f-ad27-aef772444bb1"), serviceOrThrow.aqw().n("dun_up_it5_dom")).ao() as c5x;
			if (c5x2 != null)
			{
				a3f aspect = c5x2.GetAspect<a3f>();
				if (aspect != null)
				{
					List<string> list = aspect.a().GetClassPropertyValue<List<string>>("RestlessSpirits");
					List<string> list2 = aspect.a().GetClassPropertyValue<List<string>>("UnsolvedTasks");
					if (list != null && list2 != null && list.Count > 0 && list2.Count > 0)
					{
						list = Enumerable.ToList<string>(Enumerable.OrderBy<string, int>(list, new Func<string, int>(a11.a.a.a)));
						list2 = Enumerable.ToList<string>(Enumerable.OrderBy<string, int>(list2, new Func<string, int>(a11.a.a.b)));
						for (int i = 0; i < list.Count; i++)
						{
							c5x c5x3 = new ar7(new Guid(list[i]), c5x.Area).ao() as c5x;
							if (c5x3 != null)
							{
								c5x3.RemoveAspect<e3l>();
								c5x3.b(list2[i]);
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x060044F8 RID: 17656 RVA: 0x001BFD18 File Offset: 0x001BDF18
	private void a(bool A_0, c5x A_1)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		c5x c5x = new ar7(new Guid("5102b982-66f3-4180-91ae-a49a0428eb32"), serviceOrThrow.aqw().n("dun_up_it5_dom")).ao() as c5x;
		c5x c5x2 = new ar7(new Guid("a7ce22f6-67e3-45d5-ae25-07998068ac84"), serviceOrThrow.aqw().n("dun_up_it5_dom")).ao() as c5x;
		if (c5x != null && c5x2 != null)
		{
			if (A_0)
			{
				c5x.TileFormationModifiers.s3(1);
				c5x.z();
				ad6 ad = new ad6(c5x);
				ad.b(0.0);
				ad.c(1.0);
				ad.a(0.0005);
				ad6 item = ad;
				dtb dtb = new dtb();
				dtb.ad().Add(item);
				ad6 ad2 = new ad6(c5x2);
				ad2.b(0.0);
				ad2.c(1.0);
				ad2.a(0.0005);
				item = ad2;
				dtb.ad().Add(item);
				A_1.Zone.ActionManager.g9(dtb, atp.a);
				return;
			}
			ad6 ad3 = new ad6(c5x);
			ad3.b(1.0);
			ad3.c(0.0);
			ad3.a(0.0005);
			ad6 item2 = ad3;
			dtb dtb2 = new dtb();
			dtb2.ad().Add(item2);
			ad6 ad4 = new ad6(c5x2);
			ad4.b(1.0);
			ad4.c(0.0);
			ad4.a(0.0005);
			item2 = ad4;
			dtb2.ad().Add(item2);
			dtb2.ad().Add(new c7(c5x, false, false, true, false));
			dtb2.ad().Add(new c7(c5x2, false, false, true, false));
			A_1.Zone.ActionManager.g9(dtb2, atp.a);
		}
	}

	// Token: 0x060044F9 RID: 17657 RVA: 0x001BFF0C File Offset: 0x001BE10C
	private void a(string A_0)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		c5x c5x = serviceOrThrow.aqu().v().b() as c5x;
		if (c5x != null)
		{
			c5x c5x2 = new ar7(new Guid("b8d219e9-6a7e-4c8f-ad27-aef772444bb1"), serviceOrThrow.aqw().n("dun_up_it5_dom")).ao() as c5x;
			if (c5x2 != null)
			{
				a3f aspect = c5x2.GetAspect<a3f>();
				if (aspect != null)
				{
					List<string> classPropertyValue = aspect.a().GetClassPropertyValue<List<string>>("RestlessSpirits");
					List<string> classPropertyValue2 = aspect.a().GetClassPropertyValue<List<string>>("UnsolvedTasks");
					if (classPropertyValue != null && classPropertyValue2 != null && classPropertyValue.Count > 0 && classPropertyValue2.Count > 0)
					{
						c5x c5x3 = Enumerable.FirstOrDefault<b0b>(serviceOrThrow.aqw().a().ab4(new string[]
						{
							A_0
						})) as c5x;
						if (c5x3 != null)
						{
							classPropertyValue2.Remove(A_0);
							classPropertyValue.Remove(c5x3.qe().ToString());
							aspect.a()["UnsolvedTasks"] = classPropertyValue2;
							aspect.a()["RestlessSpirits"] = classPropertyValue;
							c5x3.TileFormationModifiers.c();
							c5x3.z();
							if (classPropertyValue.Count > 0)
							{
								this.a();
								de1 de = Enumerable.FirstOrDefault<de1>(c5x.h.b.aa().StatusEffects.Get<de1>());
								if (de == null)
								{
									c5x.h.b.aa().StatusEffects.a(new de1(), false, false, false);
								}
								else
								{
									de.Stacks = d05.a(10, de.Stacks + 1);
									de.ad();
								}
							}
							c5x3.u.b.a("::Свобода...::", true, null, new Color?(new Color(100, 100, 255)));
							dtb dtb = new dtb();
							c5x3.s.b.g(false);
							c5x c5x4 = new c5x();
							d02 service = bpo.GetService<d02>();
							if (service != null)
							{
								foreach (d4n d4n in Enumerable.ToList<d4n>(service.ahl()))
								{
									if (d4n.b.am() == "arch")
									{
										c5x4 = d4n.b.a8();
									}
								}
								us us = new us();
								us.a("::Лёд трескается. Холодный ветер изменяет его.::");
								us.a(bvl.e);
								us.a(new Color?(new Color(100, 100, 255)));
								us.a(new Guid?(c5x4.qe()));
								ad6 ad = new ad6(c5x3);
								ad.b(1.0);
								ad.c(0.0);
								ad.a(0.0005);
								ad6 item = ad;
								dtb.ad().Add(item);
								if (classPropertyValue.Count > 0)
								{
									this.b(c5x4);
									c5x4.i.b.a(true, false);
									Vector3 a_ = c5x3.Location;
									List<auv> list = dtb.ad();
									aud a_2 = c5x.Area;
									Vector3 a_3 = c5x.Location + new Vector3(0f, 0f, 0.75f);
									string a_4 = "IceWallExplosion";
									int a_5 = 1;
									double maxValue = double.MaxValue;
									float? a_6 = new float?(dz6.c());
									list.Add(new au0(a_2, a_3, a_4, a_5, maxValue, null, null, a_6));
									dtb.ad().Add(new a4s(new bfq("IceShattering"), null, new ar7(c5x), null));
									List<auv> list2 = dtb.ad();
									adn adn = new adn();
									adn.a(7500);
									adn.a(new Guid?(c5x4.qe()));
									adn.a(true);
									list2.Add(new a4s(adn, null, new ar7(c5x4), null));
									dtb.ad().Add(new a8v(c5x4, a_)
									{
										c = true
									});
									dtb.ad().Add(new a4s(new bfq("IceWallFreeze"), null, new ar7(c5x), null));
									dtb.ad().Add(new a4s(us, new ar7(c5x), new ar7(c5x4), null));
								}
								else
								{
									c5x c5x5 = new ar7(new Guid("3a3a9d30-1775-4553-993f-5e9f98cf50ca"), serviceOrThrow.aqw().n("dun_up_it5_dom")).ao() as c5x;
									if (c5x5 != null)
									{
										c5x5.s.b.g(true);
										c5x5.o.b.b = new Point(3, 0);
									}
									if (service != null)
									{
										service.ahk(5.0);
									}
									serviceOrThrow.aqu().r()["dun_up_it5_demiseDefeated"] = true;
									us.a("::Холодный ветер обвевает вас, но вы даже не вздрагиваете.::");
									us.a(null);
									us.a(bvl.d);
									us.a(null);
									this.a(false, c5x);
									dtb.ad().Add(new a4s(us, new ar7(c5x), new ar7(c5x), null));
									List<auv> list3 = dtb.ad();
									nb nb = new nb();
									nb.a(new Guid?(c5x4.qe()));
									nb.a(bvl.e);
									list3.Add(new a4s(nb, null, new ar7(c5x4), null));
									dtb.ad().Add(new c7(c5x2, false, false, true, false));
								}
								dtb.ad().Add(new c7(c5x3, false, false, true, false));
								c5x.Zone.ActionManager.g9(dtb, atp.a);
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x060044FA RID: 17658 RVA: 0x001C04FC File Offset: 0x001BE6FC
	[ayh("DITJRSIA")]
	public void k(c5x A_0, c5x A_1, Dictionary<string, object> A_2)
	{
		this.a("air");
	}

	// Token: 0x060044FB RID: 17659 RVA: 0x001C050C File Offset: 0x001BE70C
	[ayh("DITJRSIC")]
	public void h(c5x A_0, c5x A_1, Dictionary<string, object> A_2)
	{
		this.a("clothes");
	}

	// Token: 0x060044FC RID: 17660 RVA: 0x001C051C File Offset: 0x001BE71C
	[ayh("DITJRSIH")]
	public void t(c5x A_0, c5x A_1, Dictionary<string, object> A_2)
	{
		this.a("heat");
	}

	// Token: 0x060044FD RID: 17661 RVA: 0x001C052C File Offset: 0x001BE72C
	[ayh("DITJRSID")]
	public void i(c5x A_0, c5x A_1, Dictionary<string, object> A_2)
	{
		this.a("drink");
	}

	// Token: 0x060044FE RID: 17662 RVA: 0x001C053C File Offset: 0x001BE73C
	[ayh("DITJRSIR")]
	public void l(c5x A_0, c5x A_1, Dictionary<string, object> A_2)
	{
		this.a("move");
	}

	// Token: 0x060044FF RID: 17663 RVA: 0x001C054C File Offset: 0x001BE74C
	[ayh("DITJRSIS")]
	public void b(c5x A_0, c5x A_1, Dictionary<string, object> A_2)
	{
		this.a("sleep");
	}

	// Token: 0x06004500 RID: 17664 RVA: 0x001C055C File Offset: 0x001BE75C
	[ayh("DITJFSI")]
	public void q(c5x A_0, c5x A_1, Dictionary<string, object> A_2)
	{
		c5x c5x = bpo.GetServiceOrThrow<cnk>().aqu().v().b() as c5x;
		if (c5x != null)
		{
			de1 de = Enumerable.FirstOrDefault<de1>(c5x.h.b.aa().StatusEffects.Get<de1>());
			if (de == null)
			{
				c5x.h.b.aa().StatusEffects.a(new de1(), false, false, false);
			}
			else
			{
				de.Stacks = d05.a(10, de.Stacks + 1);
				de.ad();
			}
			c5x.u.b.a("::Холодная кровь течёт по вашим венам.::", true, null, new Color?(new Color(100, 100, 255)));
			dtb dtb = new dtb();
			List<auv> list = dtb.ad();
			aud a_ = c5x.Area;
			Vector3 a_2 = c5x.Location + new Vector3(0f, 0f, 0.75f);
			string a_3 = "IceWallExplosion";
			int a_4 = 1;
			double maxValue = double.MaxValue;
			float? a_5 = new float?(dz6.c());
			list.Add(new au0(a_, a_2, a_3, a_4, maxValue, null, null, a_5));
			dtb.ad().Add(new a4s(new bfq("IceShattering"), null, new ar7(c5x), null));
			c5x.Zone.ActionManager.g9(dtb, atp.a);
		}
	}

	// Token: 0x06004501 RID: 17665 RVA: 0x001C06C8 File Offset: 0x001BE8C8
	[ayh("DITJPBSW")]
	public void s(c5x A_0, c5x A_1, Dictionary<string, object> A_2)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		c5x c5x = serviceOrThrow.aqu().v().b() as c5x;
		if (c5x != null)
		{
			c5x c5x2 = new c5x();
			d02 service = bpo.GetService<d02>();
			if (service != null)
			{
				foreach (d4n d4n in Enumerable.ToList<d4n>(service.ahl()))
				{
					if (d4n.b.am() == "arch")
					{
						c5x2 = d4n.b.a8();
						c5x2.b("dun_up_it_freezeImmune");
					}
				}
			}
			if (c5x2 != null)
			{
				double num = aw1.b(c5x2, c5x);
				c5x2.z = new Vector2?(new Vector2(0f, 0f));
				c5x2.c().a("ColdDeathRemnantLoop", "ColdDeathRemnantLoop", 0.7f, c9z.b, true, false);
				new co1().ym(null, null, null);
				if (num <= 4.0)
				{
					Vector3 vector = c5x.Location + new Vector3(0f, 0f, 0.75f);
					aud aud = c5x.Area;
					de1 de = Enumerable.FirstOrDefault<de1>(c5x.h.b.aa().StatusEffects.Get<de1>());
					if (de == null)
					{
						c5x.h.b.aa().StatusEffects.a(new de1(), false, false, false);
					}
					else
					{
						de.Stacks = d05.a(10, de.Stacks + 1);
						de.ad();
					}
					dtb dtb = new dtb();
					List<auv> list = dtb.ad();
					aud a_ = aud;
					Vector3 a_2 = vector;
					string a_3 = "IceWallExplosion";
					int a_4 = 1;
					double maxValue = double.MaxValue;
					float? a_5 = new float?(dz6.c());
					list.Add(new au0(a_, a_2, a_3, a_4, maxValue, null, null, a_5));
					dtb.ad().Add(new a4s(new bfq("IceShattering"), null, new ar7(c5x2), null));
					serviceOrThrow.aqw().ActionManager.g9(dtb, atp.a);
				}
				c5x c5x3 = new ar7(new Guid("b8d219e9-6a7e-4c8f-ad27-aef772444bb1"), serviceOrThrow.aqw().n("dun_up_it5_dom")).ao() as c5x;
				if (c5x3 != null)
				{
					a3f aspect = c5x3.GetAspect<a3f>();
					if (aspect != null)
					{
						List<string> classPropertyValue = aspect.a().GetClassPropertyValue<List<string>>("RestlessSpirits");
						if (classPropertyValue != null && classPropertyValue.Count > 0)
						{
							for (int i = 0; i < classPropertyValue.Count; i++)
							{
								c5x c5x4 = new ar7(new Guid(classPropertyValue[i]), serviceOrThrow.aqw().n("dun_up_it5_dom")).ao() as c5x;
								if (cuo.a.Next(0, 5) < 1 && c5x4 != null)
								{
									string text = "";
									if (c5x4.a("air"))
									{
										text = "Свежего воздуха... пожааалуйста...";
									}
									if (c5x4.a("clothes"))
									{
										text = "Одеждыыы... с-с-слишком хооолодно...";
									}
									if (c5x4.a("heat"))
									{
										text = "Как жарко... как жарко...";
									}
									if (c5x4.a("drink"))
									{
										text = "Воды... воды...";
									}
									if (c5x4.a("move"))
									{
										text = "Помогите... идти...";
									}
									if (c5x4.a("sleep"))
									{
										text = "Спать... не могу спать...";
									}
									if (!text.Equals(""))
									{
										dtb dtb2 = new dtb();
										d9m d9m = new d9m();
										us us = new us();
										us.a(text);
										us.b(new Color?(new Color(100, 100, 255)));
										us.a(bvl.e);
										us.a(new Guid?(c5x4.qe()));
										d9m.a(cuo.a.Next(150, 2550));
										d9m.c().Add(us);
										dtb2.ad().Add(new a4s(d9m, new ar7(c5x4), new ar7(c5x4), null));
										c5x4.Zone.ActionManager.g9(dtb2, atp.a);
									}
								}
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06004502 RID: 17666 RVA: 0x001C0B2C File Offset: 0x001BED2C
	public void b(c5x A_0)
	{
		c5x c5x = bpo.GetServiceOrThrow<cnk>().aqu().v().b() as c5x;
		if (c5x != null)
		{
			dtb dtb = new dtb();
			List<c5x> list = new List<c5x>();
			foreach (ya ya in A_0.Area.Triggers)
			{
				if (ya.Name.Contains("SpawnArea"))
				{
					for (int i = ya.Location.X; i < ya.Location.X + ya.Size.c; i++)
					{
						for (int j = ya.Location.Y; j < ya.Location.Y + ya.Size.d; j++)
						{
							if (!aw1.a(A_0.Area.b(i, j), false, null, l9.a) && cuo.a.Next(0, 3) > 1)
							{
								ezd ezd = new ezd("Locale\\Objects\\Destructables\\IceWall" + cuo.a.Next(1, 3).ToString(), new bt4(c5x.Area.y8(), new Vector3((float)i, (float)j, 0f)), new HorizontalDirection?(HorizontalDirection.South), null, null, null, null);
								ezd.ym(c5x, c5x, null);
								c5x c5x2 = ezd.f().ao() as c5x;
								if (c5x2 != null)
								{
									c5x2.o.b.d = new float?(0f);
									list.Add(c5x2);
								}
							}
						}
					}
				}
			}
			foreach (c5x c5x3 in list)
			{
				c5x3.o.b.d = new float?((float)1);
				c5x3.o.b.b = new Point(0, c5x3.o.b.b.Y);
				if (cuo.a.Next(0, 3) > 1)
				{
					dtb.ad().Add(new a4s(new bfq("IceWallFreeze"), null, new ar7(c5x), null));
				}
				List<auv> list2 = dtb.ad();
				dqm dqm = new dqm(c5x3.o.b);
				dqm.b(0);
				dqm.c(cuo.a.Next(4, 10));
				dqm.a((double)dz6.b(20));
				list2.Add(dqm);
			}
			c5x.Zone.ActionManager.g9(dtb, atp.a);
			A_0.h.b.aa().CustomProperties["CryokinesisRange"] = A_0.h.b.aa().CustomProperties.GetPrimitivePropertyValue<float>("CryokinesisRange", new float?((float)10)) - 1f;
			rs rs = A_0.h.b.aa().Skills.Get<rs>();
			rs.a(rs.f() + 8);
			jk jk = A_0.h.b.aa().Skills.Get<jk>();
			jk.a(jk.f() + 10);
			A_0.h.b.aa().BaseMovementSpeed += 0.05f;
		}
	}

	// Token: 0x04001C64 RID: 7268
	private static float a = 1f;

	// Token: 0x02000BC4 RID: 3012
	[CompilerGenerated]
	[Serializable]
	private sealed class a
	{
		// Token: 0x06004507 RID: 17671 RVA: 0x001C0F54 File Offset: 0x001BF154
		internal bool a(b0b A_0)
		{
			return !A_0.aa;
		}

		// Token: 0x06004508 RID: 17672 RVA: 0x001C0F60 File Offset: 0x001BF160
		internal int a(string A_0)
		{
			return cuo.a.Next();
		}

		// Token: 0x06004509 RID: 17673 RVA: 0x001C0F6C File Offset: 0x001BF16C
		internal int b(string A_0)
		{
			return cuo.a.Next();
		}

		// Token: 0x04001C65 RID: 7269
		public static readonly a11.a a = new a11.a();

		// Token: 0x04001C66 RID: 7270
		public static Func<b0b, bool> b;

		// Token: 0x04001C67 RID: 7271
		public static Func<string, int> c;

		// Token: 0x04001C68 RID: 7272
		public static Func<string, int> d;
	}
}

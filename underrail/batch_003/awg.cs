using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using TimelapseVertigo.Playfield.Locale;
using TimelapseVertigo.Rules;
using TimelapseVertigo.Rules.Characters;
using TimelapseVertigo.Rules.Combat;

// Token: 0x02000BB3 RID: 2995
[euj]
public class awg
{
	// Token: 0x06004413 RID: 17427 RVA: 0x001AE050 File Offset: 0x001AC250
	[ayh("CCUJSFNNQ")]
	public void g(c5x A_0, c5x A_1, Dictionary<string, object> A_2)
	{
		this.a(false);
	}

	// Token: 0x06004414 RID: 17428 RVA: 0x001AE05C File Offset: 0x001AC25C
	[ayh("CCUJSFWNQ")]
	public void m(c5x A_0, c5x A_1, Dictionary<string, object> A_2)
	{
		this.a(true);
	}

	// Token: 0x06004415 RID: 17429 RVA: 0x001AE068 File Offset: 0x001AC268
	[ayh("CCUJIBC")]
	public void i(c5x A_0, c5x A_1, Dictionary<string, object> A_2)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow != null && serviceOrThrow.aqw().a() != null)
		{
			int num = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<int>("loc_cc_utility1_activeBoilersCount", new int?(0)).Value;
			num++;
			serviceOrThrow.aqu().r()["loc_cc_utility1_activeBoilersCount"] = num;
			c5x c5x = serviceOrThrow.aqu().v().b() as c5x;
			if (c5x != null)
			{
				if (num == 1)
				{
					us us = new us();
					us.a("::Внезапный статический разряд ударяет по руке.::");
					us.ym(c5x, c5x, null);
					bfq bfq = new bfq();
					bfq.a(bvl.d);
					bfq.c("Tazer");
					bfq.ym(c5x, c5x, null);
				}
				if ((serviceOrThrow.aqu().a() == GameDifficulty.Easy && num == 7) || (serviceOrThrow.aqu().a() == GameDifficulty.Normal && num == 5) || (serviceOrThrow.aqu().a() == GameDifficulty.Hard && num == 4) || (serviceOrThrow.aqu().a() == GameDifficulty.Dominating && num == 3))
				{
					this.a();
				}
			}
		}
	}

	// Token: 0x06004416 RID: 17430 RVA: 0x001AE194 File Offset: 0x001AC394
	[ayh("CCUJRAEL")]
	public void h(c5x A_0, c5x A_1, Dictionary<string, object> A_2)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow != null)
		{
			serviceOrThrow.aqu().a(new bw0("cc_s1", new egm(), 1));
		}
	}

	// Token: 0x06004417 RID: 17431 RVA: 0x001AE1C8 File Offset: 0x001AC3C8
	[ayh("CCUJKFO")]
	public void k(c5x A_0, c5x A_1, Dictionary<string, object> A_2)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow != null)
		{
			c5x c5x = Enumerable.FirstOrDefault<b0b>(serviceOrThrow.aqw().a().ab4(new string[]
			{
				"forger"
			})) as c5x;
			if (c5x != null)
			{
				nb nb = new nb();
				nb.a(bvl.c);
				nb.a(new Guid?(c5x.qe()));
				nb.a(false);
				nb.ym(c5x, c5x, null);
			}
		}
	}

	// Token: 0x06004418 RID: 17432 RVA: 0x001AE23C File Offset: 0x001AC43C
	[ayh("CCUJDFADI")]
	public void a(c5x A_0, c5x A_1, Dictionary<string, object> A_2)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow != null)
		{
			c5x c5x = Enumerable.FirstOrDefault<b0b>(serviceOrThrow.aqw().a().ab4(new string[]
			{
				"forger"
			})) as c5x;
			if (c5x != null && c5x.t.b != null)
			{
				c5x.t.b.y6().RemoveProperty(ddq.bc);
				c5x.t.b.y6().RemoveProperty(ddq.bd);
			}
		}
	}

	// Token: 0x06004419 RID: 17433 RVA: 0x001AE2CC File Offset: 0x001AC4CC
	[ayh("CCUJRFGAN")]
	public void l(c5x A_0, c5x A_1, Dictionary<string, object> A_2)
	{
		if (A_0 != null)
		{
			A_1 = A_0;
		}
		if (A_1 != null)
		{
			cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
			if (serviceOrThrow != null)
			{
				c5x c5x = serviceOrThrow.aqu().v().b() as c5x;
				if (c5x != null && A_1 != c5x)
				{
					c5x c5x2 = Enumerable.FirstOrDefault<b0b>(serviceOrThrow.aqw().a().ab4(new string[]
					{
						"forger"
					})) as c5x;
					if (c5x2 != null)
					{
						switch (cuo.a.Next(0, 3))
						{
						case 0:
							c5x2.t.b.y6()[ddq.o] = CharacterState.Operating;
							return;
						case 1:
							c5x2.t.b.y6()[ddq.o] = CharacterState.Custom1;
							return;
						case 2:
							c5x2.t.b.y6()[ddq.o] = CharacterState.Custom2;
							return;
						default:
							c5x2.t.b.y6()[ddq.o] = CharacterState.Operating;
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600441A RID: 17434 RVA: 0x001AE3F0 File Offset: 0x001AC5F0
	[ayh("CCUJDBPLAF")]
	public void f(c5x A_0, c5x A_1, Dictionary<string, object> A_2)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow != null)
		{
			c5x c5x = Enumerable.FirstOrDefault<b0b>(serviceOrThrow.aqw().a().ab4(new string[]
			{
				"forger"
			})) as c5x;
			if (c5x != null)
			{
				c5x c5x2 = serviceOrThrow.aqu().v().b() as c5x;
				if (c5x2 != null)
				{
					a1q a_ = default(a1q);
					cwt cwt = new cwt();
					cwt.i = new ap9("You", c5x2.h.b.aa().FactionId);
					cwt.l = true;
					cwt.b = true;
					cwt.e = true;
					cwt.w = false;
					a_ = new a1q(DamageType.Mechanical, 88, 125);
					cwt.f.Add(euf.a(a_, 1.0));
					c5x.h.b.aa().Defense.a(cwt);
					cwt.i = new ap9(c5x.y8(), c5x.h.b.aa().FactionId);
					c5x2.h.b.aa().Defense.a(cwt);
					bfq bfq = new bfq();
					bfq.c("UnarmedHitBody");
					bfq.a(bvl.d);
					bfq.ym(c5x2, c5x2, null);
					bfq bfq2 = new bfq();
					bfq2.c("UnarmedHitBodyResist");
					bfq2.a(bvl.d);
					bfq2.ym(c5x2, c5x2, null);
				}
			}
		}
	}

	// Token: 0x0600441B RID: 17435 RVA: 0x001AE570 File Offset: 0x001AC770
	[ayh("CCUJDADF")]
	public void j(c5x A_0, c5x A_1, Dictionary<string, object> A_2)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow != null)
		{
			c5x c5x = Enumerable.FirstOrDefault<b0b>(serviceOrThrow.aqw().a().ab4(new string[]
			{
				"forger"
			})) as c5x;
			if (c5x != null)
			{
				c5x c5x2 = serviceOrThrow.aqu().v().b() as c5x;
				if (c5x2 != null)
				{
					if (c5x.h.b != null && c5x.h.b.aa().Gear.h().Item != null)
					{
						c5x.h.b.aa().Defense.a(true);
					}
					a1q a_ = default(a1q);
					cwt cwt = new cwt();
					cwt.i = new ap9("You", c5x2.h.b.aa().FactionId);
					cwt.l = true;
					cwt.b = true;
					cwt.e = true;
					cwt.w = false;
					int a_2 = 30000;
					int a_3 = 2000;
					if (serviceOrThrow.aqu().ae() <= GameDifficulty.Normal)
					{
						a_ = new a1q(DamageType.Mechanical, 115, 145);
					}
					if (serviceOrThrow.aqu().ae() == GameDifficulty.Hard)
					{
						a_ = new a1q(DamageType.Mechanical, 100, 145);
						a_2 = 20000;
						a_3 = 1000;
					}
					if (serviceOrThrow.aqu().ae() == GameDifficulty.Dominating)
					{
						a_ = new a1q(DamageType.Mechanical, 96, 125);
						a_2 = 15000;
						a_3 = 1000;
					}
					cwt.f.Clear();
					cwt.f.Add(euf.a(a_, 1.0));
					c5x.h.b.aa().Defense.a(cwt);
					bfq bfq = new bfq();
					bfq.c("Stun");
					bfq.a(bvl.d);
					bfq.ym(c5x2, c5x2, null);
					bfq bfq2 = new bfq();
					bfq2.c("UnarmedHitBody");
					bfq2.a(bvl.d);
					bfq2.ym(c5x2, c5x2, null);
					if (!c5x.h.b.aa().d(CharacterImmunities.Daze))
					{
						eok eok = Enumerable.FirstOrDefault<eok>(c5x.h.b.aa().StatusEffects.Get<eok>());
						if (eok == null)
						{
							c5x.h.b.aa().StatusEffects.a(new eok(a_2), false, false, false);
						}
						else
						{
							eok.Duration = a_2;
							eok.ad();
						}
					}
					if (!c5x.h.b.aa().d(CharacterImmunities.Stun))
					{
						adn adn = new adn();
						adn.a(a_3);
						adn.a(new Guid?(c5x.qe()));
						adn.a(true);
						adn.ym(c5x, c5x, null);
					}
				}
			}
		}
	}

	// Token: 0x0600441C RID: 17436 RVA: 0x001AE84C File Offset: 0x001ACA4C
	[ayh("CCUJDADP")]
	public void d(c5x A_0, c5x A_1, Dictionary<string, object> A_2)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow != null)
		{
			c5x c5x = Enumerable.FirstOrDefault<b0b>(serviceOrThrow.aqw().a().ab4(new string[]
			{
				"forger"
			})) as c5x;
			c5x c5x2 = serviceOrThrow.aqu().v().b() as c5x;
			if (c5x != null)
			{
				if (c5x.h.b != null && c5x.h.b.aa().Gear.h().Item != null)
				{
					c5x.h.b.aa().Defense.a(true);
				}
				if (c5x2 != null)
				{
					a1q a_ = default(a1q);
					cwt cwt = new cwt();
					cwt.i = new ap9(c5x.y8(), c5x.h.b.aa().FactionId);
					cwt.l = true;
					cwt.b = true;
					cwt.e = true;
					cwt.w = false;
					int a_2 = 10000;
					if (serviceOrThrow.aqu().ae() <= GameDifficulty.Normal)
					{
						a_ = new a1q(DamageType.Mechanical, 46, 71);
					}
					if (serviceOrThrow.aqu().ae() == GameDifficulty.Hard)
					{
						a_ = new a1q(DamageType.Mechanical, 75, 89);
						a_2 = 15000;
					}
					if (serviceOrThrow.aqu().ae() == GameDifficulty.Dominating)
					{
						a_ = new a1q(DamageType.Mechanical, 125, 137);
						a_2 = 20000;
					}
					cwt.f.Clear();
					cwt.f.Add(euf.a(a_, 1.0));
					c5x2.h.b.aa().Defense.a(cwt);
					bfq bfq = new bfq();
					bfq.c("Daze");
					bfq.a(bvl.d);
					bfq.ym(c5x2, c5x2, null);
					bfq bfq2 = new bfq();
					bfq2.c("UnarmedHitBody");
					bfq2.a(bvl.d);
					bfq2.ym(c5x2, c5x2, null);
					if (!c5x2.h.b.aa().d(CharacterImmunities.Daze))
					{
						eok eok = Enumerable.FirstOrDefault<eok>(c5x2.h.b.aa().StatusEffects.Get<eok>());
						if (eok == null)
						{
							c5x2.h.b.aa().StatusEffects.a(new eok(a_2), false, false, false);
							return;
						}
						eok.Duration = a_2;
						eok.ad();
					}
				}
			}
		}
	}

	// Token: 0x0600441D RID: 17437 RVA: 0x001AEAC4 File Offset: 0x001ACCC4
	[ayh("CCUJRL")]
	public void e(c5x A_0, c5x A_1, Dictionary<string, object> A_2)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow != null)
		{
			if (A_0 != null)
			{
				A_1 = A_0;
				return;
			}
			if (A_1 != null)
			{
				int num = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<int>("npc_cc_su1_regeneratorKillCount", new int?(0)).Value + 1;
				if ((num == 6 && serviceOrThrow.aqu().ae() <= GameDifficulty.Normal) || (num == 8 && serviceOrThrow.aqu().ae() <= GameDifficulty.Hard) || (num == 11 && serviceOrThrow.aqu().ae() <= GameDifficulty.Dominating))
				{
					c5x c5x = new ar7(new Guid("f2fa0a00-be4c-4ab6-9d27-0b4cc04208c0"), A_1.Area).ao() as c5x;
					if (c5x != null)
					{
						serviceOrThrow.aqu().r()["npc_abomination_killed"] = true;
						c5x.Location = A_1.Location;
						c5x.ah();
						dtb dtb = new dtb();
						for (int i = 0; i < 3; i++)
						{
							dtb.ad().Add(new bm3(cuo.a.Next(500, 850)));
							List<auv> list = dtb.ad();
							bfq bfq = new bfq();
							bfq.c("BurrowerEggBurst");
							bfq.a(bvl.d);
							list.Add(new a4s(bfq, null, null, null));
							dtb.ad().Add(new bm3(cuo.a.Next(200, 350)));
							List<auv> list2 = dtb.ad();
							bfq bfq2 = new bfq();
							bfq2.c("ConsumingBite");
							bfq2.a(bvl.d);
							list2.Add(new a4s(bfq2, null, null, null));
						}
						serviceOrThrow.aqw().ActionManager.g9(dtb, atp.a);
					}
				}
			}
		}
	}

	// Token: 0x0600441E RID: 17438 RVA: 0x001AEC80 File Offset: 0x001ACE80
	[ayh("CCUJRALOK")]
	public void n(c5x A_0, c5x A_1, Dictionary<string, object> A_2)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow != null)
		{
			Vector3 a_ = default(Vector3);
			if (A_0 != null)
			{
				a_ = A_0.Location;
			}
			else if (A_1 != null)
			{
				a_ = A_1.Location;
			}
			else
			{
				a_ = new Vector3(17f, 38f, 0f);
			}
			bt4 value = new bt4("", a_);
			serviceOrThrow.aqu().r()["npc_abomination_deathLocation"] = value;
		}
	}

	// Token: 0x0600441F RID: 17439 RVA: 0x001AED00 File Offset: 0x001ACF00
	[ayh("CCUJTRRT")]
	public void b(c5x A_0, c5x A_1, Dictionary<string, object> A_2)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow != null)
		{
			int value = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<int>("npc_cc_su1_regeneratorKillCount", new int?(0)).Value;
			if (value != 6 || serviceOrThrow.aqu().ae() > GameDifficulty.Normal || (value == 8 && serviceOrThrow.aqu().ae() <= GameDifficulty.Hard) || (value == 11 && serviceOrThrow.aqu().ae() <= GameDifficulty.Dominating))
			{
				c5x c5x = Enumerable.FirstOrDefault<b0b>(serviceOrThrow.aqw().a().ab4(new string[]
				{
					"cc_s1u_mutantRespawner"
				})) as c5x;
				if (c5x != null)
				{
					dm aspect = c5x.GetAspect<dm>();
					if (aspect != null)
					{
						if (serviceOrThrow.aqu().ae() <= GameDifficulty.Normal)
						{
							aspect.a(new int?(15000));
						}
						if (serviceOrThrow.aqu().ae() <= GameDifficulty.Hard)
						{
							aspect.a(new int?(10000));
						}
						if (serviceOrThrow.aqu().ae() <= GameDifficulty.Dominating)
						{
							aspect.a(new int?(7500));
						}
						aspect.b(true);
					}
				}
			}
		}
	}

	// Token: 0x06004420 RID: 17440 RVA: 0x001AEE34 File Offset: 0x001AD034
	[ayh("CCUJARR")]
	public void c(c5x A_0, c5x A_1, Dictionary<string, object> A_2)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow != null)
		{
			c5x c5x = Enumerable.FirstOrDefault<b0b>(serviceOrThrow.aqw().a().ab4(new string[]
			{
				"cc_s1u_mutantRespawner"
			})) as c5x;
			if (c5x != null)
			{
				dm aspect = c5x.GetAspect<dm>();
				if (aspect != null)
				{
					aspect.b(false);
				}
			}
			if (!serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("npc_abomination_killed", new bool?(false)).Value)
			{
				c5x c5x2 = serviceOrThrow.aqu().v().b() as c5x;
				if (c5x2 != null)
				{
					Vector3 vector = default(Vector3);
					bt4 classPropertyValue = serviceOrThrow.aqu().r().GetClassPropertyValue<bt4>("npc_abomination_deathLocation");
					if (classPropertyValue != null)
					{
						classPropertyValue.a();
						ak1 ak = c5x2.Area.b((int)classPropertyValue.a().X, (int)classPropertyValue.a().Y);
						ak = Enumerable.FirstOrDefault<ak1>(aw1.a(Enumerable.FirstOrDefault<b0b>(ak.Entities) as c5x, null));
						if (ak == null)
						{
							vector = new Vector3(17f, 38f, 0f);
						}
						else
						{
							vector.X = (float)ak.Location.X;
							vector.Y = (float)ak.Location.Y;
						}
					}
					else
					{
						vector = new Vector3(17f, 38f, 0f);
					}
					ezd ezd = new ezd("Locale\\Creatures\\Abomination", new bt4("cc_s1u", vector), null, null, new CharacterState?(CharacterState.Idle), null, null);
					ezd.ym(c5x2, null, null);
					c5x c5x3 = ezd.f().ao() as c5x;
					if (c5x3 != null)
					{
						au0 a_ = new au0(c5x3.Area, new Vector3(vector.X, vector.Y, vector.Z + 0.15f), "BloodImpact", 1, double.MaxValue, null, null, null);
						c5x3.Zone.ActionManager.g9(a_, atp.a);
						bfq bfq = new bfq();
						bfq.a(bvl.e);
						bfq.a(new Guid?(c5x3.qe()));
						bfq.c("MutatedHumanGrowl");
						bfq.ym(c5x2, null, null);
						int num = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<int>("npc_cc_su1_regeneratorKillCount", new int?(0)).Value + 1;
						if (serviceOrThrow.aqu().ae() <= GameDifficulty.Hard)
						{
							c5x3.h.b.aa().Skills.Get<bec>().a(10);
						}
						if (num > 5 && serviceOrThrow.aqu().ae() <= GameDifficulty.Normal)
						{
							num = 5;
						}
						else if (num > 10 && serviceOrThrow.aqu().ae() == GameDifficulty.Hard)
						{
							num = 10;
						}
						else if (num > 15 && serviceOrThrow.aqu().ae() == GameDifficulty.Dominating)
						{
							num = 15;
						}
						c5x3.h.b.aa().Skills.Get<jk>().a(c5x3.h.b.aa().Skills.Get<jk>().f() + 20 * num);
						c5x3.h.b.aa().Skills.Get<e74>().a(c5x3.h.b.aa().Skills.Get<e74>().f() + 7 * num);
						c5x3.h.b.aa().Skills.Get<erc>().a(c5x3.h.b.aa().Skills.Get<e74>().f() + 7 * num);
						c5x3.h.b.aa().Skills.Get<bec>().a(c5x3.h.b.aa().Skills.Get<bec>().f() + 20 * num);
						c5x3.h.b.aa().BaseAbilities.a("Constitution").a(c5x3.h.b.aa().BaseAbilities.Constitution + num);
						c5x3.h.b.a((cuo.a.Next(0, 4) > 2) ? "mhun1" : ((cuo.a.Next(0, 4) > 2) ? "mhun2" : "mhun3"));
						c5x3.h.b.ao = new Color?(new Color(255, 255 - 12 * num, 255 - 16 * num));
						c5x3.h.b.aa().MovementSpeed = c5x3.h.b.aa().MovementSpeed - 0.02f * (float)num;
						c5x3.h.b.am = 0.1f;
						c5x3.h.b.al = 0.1f;
						this.a(serviceOrThrow, c5x3, num);
						bm6 aspect2 = c5x3.GetAspect<bm6>();
						if (aspect2 != null)
						{
							aspect2.y6()[ddq.bz] = "player";
							aspect2.y6()[ddq.b0] = 0.1f;
						}
						dxv dxv = new dxv(c5x3, "poisonedGas", c5x3.h.b.aa().FactionId);
						dxv.a(10.0);
						dxv aspect3 = dxv;
						c5x3.SetAspect<dxv>(aspect3);
					}
				}
			}
		}
	}

	// Token: 0x06004421 RID: 17441 RVA: 0x001AF438 File Offset: 0x001AD638
	public void a()
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow != null)
		{
			d60 d = serviceOrThrow.aqw().a();
			if (d != null)
			{
				List<b0b> list = d.ab4(new string[]
				{
					"cc_utility1_mist"
				});
				foreach (b0b b0b in list)
				{
					c5x c5x = (c5x)b0b;
					ad6 ad = new ad6(c5x);
					ad.b(0.0);
					ad.c(1.0);
					ad.a(0.0005);
					ad6 a_ = ad;
					c5x.Zone.ActionManager.g9(a_, atp.a);
				}
				list.Clear();
				list = d.ab4(new string[]
				{
					"cc_utility1_mistBlocker"
				});
				foreach (b0b b0b2 in list)
				{
					c5x c5x2 = (c5x)b0b2;
					c5x2.TileFormationModifiers.s3(0);
					c5x2.z();
				}
				c5x c5x3 = serviceOrThrow.aqu().v().b() as c5x;
				if (c5x3 != null)
				{
					us us = new us();
					us.a("::Горячий водной пар снижает полноту дыхания.::");
					us.ym(c5x3, c5x3, null);
					bfq bfq = new bfq();
					bfq.a(bvl.d);
					bfq.c("GasGrenadeLeak");
					bfq.ym(c5x3, c5x3, null);
				}
			}
		}
	}

	// Token: 0x06004422 RID: 17442 RVA: 0x001AF5C8 File Offset: 0x001AD7C8
	public void a(cnk A_0, c5x A_1, int A_2)
	{
		if (A_1 != null)
		{
			float num = 1f + 0.0175f * (float)A_2;
			float num2 = 0.1f;
			float num3 = num / 50f;
			dtb dtb = new dtb();
			for (int i = 0; i < 50; i++)
			{
				dtb.ad().Add(new bm3(2));
				num2 += num3;
				List<auv> list = dtb.ad();
				dnz dnz = new dnz();
				dnz.a(num2);
				dnz.b(num2);
				dnz.a(new Guid?(A_1.qe()));
				dnz.a("cc_s1u");
				list.Add(new a4s(dnz, null, null, null));
			}
			A_0.aqw().ActionManager.g9(dtb, atp.a);
		}
	}

	// Token: 0x06004423 RID: 17443 RVA: 0x001AF678 File Offset: 0x001AD878
	public void a(bool A_0)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow != null && !serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("npc_forger_met", new bool?(false)).Value && !serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("npc_forger_dead", new bool?(false)).Value && !serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("npc_forger_captured", new bool?(false)).Value)
		{
			if (A_0)
			{
				b4q b4q = new b4q();
				b4q.a(true);
				b4q.a("cc_forger_name");
				b4q.ym(null, null, null);
				return;
			}
			b4q b4q2 = new b4q();
			b4q2.a(true);
			b4q2.a("cc_forger_noName");
			b4q2.ym(null, null, null);
		}
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using TimelapseVertigo.Rules.Characters;

// Token: 0x020007E6 RID: 2022
public sealed class gx
{
	// Token: 0x060032C5 RID: 12997 RVA: 0x0013B1B0 File Offset: 0x001393B0
	public c5x a(csd A_0, int? A_1, string A_2, string A_3 = null, string A_4 = null, string A_5 = null, string A_6 = null, bool A_7 = false, List<cze> A_8 = null, bool A_9 = false)
	{
		string item = "creatures\\generichumans\\ironheadGrenadier";
		string item2 = "creatures\\generichumans\\ironheadSmasher";
		string item3 = "creatures\\generichumans\\ironheadGunner";
		string item4 = "creatures\\generichumans\\ironheadPsionic";
		string item5 = "creatures\\generichumans\\ironheadCommando";
		string item6 = "creatures\\generichumans\\ironheadBomber";
		string item7 = "creatures\\generichumans\\xpbl\\ironheadShotgunner";
		string item8 = "creatures\\generichumans\\xphw\\ironheadMachineGunner";
		string item9 = "creatures\\generichumans\\ironheadBerserker";
		string item10 = "creatures\\generichumans\\ironheadHeavyGunner";
		string item11 = "creatures\\generichumans\\ironheadDemolisher";
		string item12 = "creatures\\generichumans\\xpbl\\ironheadHeavyShotgunner";
		string item13 = "creatures\\generichumans\\xphw\\ironheadMinigunner";
		string item14 = "creatures\\generichumans\\ironheadPunisher";
		string item15 = "creatures\\generichumans\\xphw\\ironheadAnnihilator";
		string item16 = "creatures\\generichumans\\lunaticChiller";
		string item17 = "creatures\\generichumans\\lunaticBrawler";
		string item18 = "creatures\\generichumans\\lunaticGunner";
		string item19 = "creatures\\generichumans\\lunaticElectrician";
		string item20 = "creatures\\generichumans\\lunaticScanner";
		string item21 = "creatures\\generichumans\\lunaticPyromaniac";
		string item22 = "creatures\\generichumans\\xpbl\\lunaticImpaler";
		string item23 = "creatures\\generichumans\\lunaticFreezer";
		string item24 = "creatures\\generichumans\\lunaticPsychopath";
		string item25 = "creatures\\generichumans\\lunaticNuker";
		string item26 = "creatures\\generichumans\\lunaticPredator";
		string item27 = "creatures\\generichumans\\lunaticImitator";
		string item28 = "creatures\\generichumans\\xpbl\\lunaticTimepumper";
		string item29 = "creatures\\generichumans\\lunaticBeamer";
		string item30 = "creatures\\generichumans\\lurkerCutthroat";
		string item31 = "creatures\\generichumans\\lurkerGunner";
		string item32 = "creatures\\generichumans\\lurkerPsionic";
		string item33 = "creatures\\generichumans\\lurkerMurderer";
		string item34 = "creatures\\generichumans\\lurkerGunslinger";
		string item35 = "creatures\\generichumans\\lurkerHunter";
		string item36 = "creatures\\generichumans\\xpbl\\lurkerManiac";
		string item37 = "creatures\\generichumans\\lurkerAssassin";
		string item38 = "creatures\\generichumans\\lurkerSniper";
		string item39 = "creatures\\generichumans\\lurkerTrapper";
		string item40 = "creatures\\generichumans\\xpbl\\lurkerTormentor";
		string item41 = "creatures\\generichumans\\lurkerDissolver";
		string item42 = "creatures\\generichumans\\protectorateHeavyGunner";
		string item43 = "creatures\\generichumans\\protectorateSentinel";
		string item44 = "creatures\\generichumans\\protectorateShockTrooper";
		string item45 = "creatures\\generichumans\\protectorateSniper";
		string item46 = "creatures\\generichumans\\xphw\\protectorateGrenadier";
		string item47 = "creatures\\generichumans\\xphw\\protectorateSupportGunner";
		string item48 = "creatures\\generichumans\\xphw\\protectorateHeavySupportGunner";
		string item49 = "creatures\\generichumans\\xphw\\protectorateAntiArmor";
		string item50 = "creatures\\generichumans\\xpbl\\protectorateMarineGunnerUnmounted";
		string item51 = "creatures\\generichumans\\xpbl\\protectorateMarineSniperUnmounted";
		string item52 = "creatures\\generichumans\\xpbl\\protectorateMarineEnergyGunner";
		string item53 = "creatures\\generichumans\\tchortistGunner";
		string item54 = "creatures\\generichumans\\tchortistGrenadier";
		string item55 = "creatures\\generichumans\\tchortistPyromancer";
		string item56 = "creatures\\generichumans\\tchortistSharpshooter";
		string item57 = "creatures\\generichumans\\FoundryGunner";
		string item58 = "creatures\\generichumans\\FoundryShield";
		string item59 = "creatures\\generichumans\\FoundryGrenadier";
		string item60 = "creatures\\generichumans\\FoundrySniper";
		string item61 = "creature\\Faceless\\FacelessSoldier-Smg";
		string item62 = "creature\\Faceless\\FacelessSoldier-AssaultRifle";
		string item63 = "creature\\Faceless\\FacelessSoldier-Sledgehammer";
		string item64 = "creature\\Faceless\\FacelessSoldier-EnergyPistol";
		string item65 = "creatures\\Faceless\\FacelessDoctor";
		string item66 = "creatures\\Faceless\\FacelessCentaur";
		string item67 = "creatures\\Faceless\\FacelessMindreader";
		string item68 = "creatures\\generichumans\\xpbl\\pirateGunner";
		string item69 = "creatures\\generichumans\\xpbl\\pirateKnifeThrower";
		string item70 = "creatures\\generichumans\\xpbl\\pirateMacheteer";
		string item71 = "creatures\\generichumans\\xpbl\\pirateShotgunner";
		string item72 = "creatures\\generichumans\\xpbl\\pirateHeavyGunner";
		string item73 = "creatures\\generichumans\\xpbl\\pirateSmasher";
		string item74 = "creatures\\generichumans\\xpbl\\pirateSMGunner";
		string item75 = "creatures\\generichumans\\xpbl\\pirateSniper";
		string item76 = "creatures\\generichumans\\xpbl\\pirateTrapper";
		string item77 = "creatures\\generichumans\\xpbl\\pirateBomber";
		string item78 = "creatures\\generichumans\\xpbl\\savageKnifer";
		string item79 = "creatures\\generichumans\\xpbl\\savageCrossbowman";
		string item80 = "creatures\\generichumans\\xpbl\\savageSmasher";
		string item81 = "creatures\\generichumans\\xpbl\\savageSpearman";
		string item82 = "creatures\\generichumans\\xpbl\\savageSwordsman";
		string item83 = "creatures\\generichumans\\xpbl\\aegisSecTrooperGunner";
		string item84 = "creatures\\generichumans\\xpbl\\aegisSecTrooperHeavyGunner";
		string item85 = "creatures\\generichumans\\xpbl\\aegisSecTrooperShotgunner";
		string item86 = "creatures\\generichumans\\xpbl\\aegisSecTrooperSniper";
		string item87 = "creatures\\generichumans\\xpbl\\xphw\\aegisSecTrooperMachineGunner";
		string item88 = "Locale\\Creatures\\GenericHumans\\SGSHeavySniperSentry";
		List<string> list = new List<string>();
		List<string> list2 = new List<string>();
		List<string> list3 = new List<string>();
		List<string> list4 = new List<string>();
		List<string> list5 = new List<string>();
		if (A_2 != null)
		{
			switch (A_2.Length)
			{
			case 5:
				if (A_2 == "Aegis")
				{
					list.Add(item83);
					list2.Add(item84);
					list3.Add(item86);
					list3.Add(item85);
					if (dk2.b("xphw"))
					{
						list4.Add(item87);
						goto IL_AB6;
					}
					goto IL_AB6;
				}
				break;
			case 7:
			{
				char c = A_2[0];
				if (c != 'F')
				{
					if (c != 'L')
					{
						if (c == 'P')
						{
							if (A_2 == "Pirates")
							{
								list.Add(item68);
								list.Add(item69);
								list2.Add(item70);
								list2.Add(item76);
								list2.Add(item73);
								list.Add(item74);
								list3.Add(item71);
								list3.Add(item72);
								list3.Add(item77);
								list4.Add(item75);
								goto IL_AB6;
							}
						}
					}
					else if (A_2 == "Lurkers")
					{
						list.Add(item30);
						list.Add(item31);
						list2.Add(item33);
						list2.Add(item34);
						list2.Add(item35);
						list3.Add(item37);
						list3.Add(item38);
						list3.Add(item39);
						list4.Add(item32);
						if (A_4 != null)
						{
							goto IL_AB6;
						}
						list5.Add(item41);
						if (dk2.b("xpbl"))
						{
							list2.Add(item36);
							list3.Add(item40);
							goto IL_AB6;
						}
						goto IL_AB6;
					}
				}
				else if (A_2 == "Foundry")
				{
					list.Add(item57);
					list2.Add(item58);
					list2.Add(item59);
					list3.Add(item60);
					goto IL_AB6;
				}
				break;
			}
			case 8:
			{
				char c = A_2[0];
				if (c != 'F')
				{
					if (c == 'L')
					{
						if (A_2 == "Lunatics")
						{
							list.Add(item16);
							list.Add(item17);
							list.Add(item18);
							list2.Add(item19);
							list2.Add(item20);
							list2.Add(item21);
							list3.Add(item23);
							list3.Add(item24);
							list3.Add(item25);
							list3.Add(item27);
							if (A_4 != null)
							{
								goto IL_AB6;
							}
							list5.Add(item29);
							if (dk2.b("xpbl"))
							{
								list3.Add(item22);
								list3.Add(item26);
								list4.Add(item28);
								goto IL_AB6;
							}
							goto IL_AB6;
						}
					}
				}
				else if (A_2 == "Faceless")
				{
					list.Add(item61);
					list.Add(item62);
					list.Add(item63);
					list2.Add(item64);
					list2.Add(item65);
					list3.Add(item66);
					list3.Add(item67);
					goto IL_AB6;
				}
				break;
			}
			case 9:
				if (A_2 == "Ironheads")
				{
					list.Add(item);
					list.Add(item2);
					list.Add(item3);
					list2.Add(item5);
					list2.Add(item6);
					list3.Add(item9);
					list3.Add(item10);
					list3.Add(item11);
					list4.Add(item4);
					if (A_4 != null)
					{
						goto IL_AB6;
					}
					list5.Add(item14);
					if (dk2.b("xpbl"))
					{
						list2.Add(item7);
						list3.Add(item12);
					}
					if (dk2.b("xphw"))
					{
						list3.Add(item8);
						list4.Add(item13);
						list5.Add(item15);
						goto IL_AB6;
					}
					goto IL_AB6;
				}
				break;
			case 10:
				if (A_2 == "Tchortists")
				{
					list.Add(item53);
					list2.Add(item54);
					list2.Add(item55);
					list3.Add(item56);
					goto IL_AB6;
				}
				break;
			case 11:
				if (A_2 == "Sormirbaren")
				{
					list.Add(item78);
					list2.Add(item79);
					list2.Add(item81);
					list3.Add(item80);
					list2.Add(item82);
					list3.Add(item79);
					goto IL_AB6;
				}
				break;
			case 12:
			{
				char c = A_2[0];
				if (c != 'A')
				{
					if (c == 'P')
					{
						if (A_2 == "Protectorate")
						{
							list.Add(item42);
							list2.Add(item43);
							list2.Add(item44);
							list3.Add(item45);
							if (dk2.b("xphw"))
							{
								list2.Add(item46);
								list3.Add(item47);
								list4.Add(item48);
								list4.Add(item49);
								goto IL_AB6;
							}
							goto IL_AB6;
						}
					}
				}
				else if (A_2 == "Aegis_Jetski")
				{
					list.Add(item83);
					list2.Add(item84);
					list3.Add(item84);
					list4.Add(item85);
					goto IL_AB6;
				}
				break;
			}
			case 14:
			{
				char c = A_2[0];
				if (c != 'G')
				{
					if (c == 'P')
					{
						if (A_2 == "Pirates_Jetski")
						{
							list.Add(item76);
							list2.Add(item74);
							list3.Add(item72);
							list4.Add(item72);
							goto IL_AB6;
						}
					}
				}
				else if (A_2 == "Generic_Jetski")
				{
					list.Add(item);
					list.Add(item3);
					list.Add(item31);
					list.Add(item18);
					list2.Add(item5);
					list2.Add(item6);
					list2.Add(item34);
					list2.Add(item35);
					list3.Add(item11);
					list3.Add(item39);
					list4.Add(item4);
					list4.Add(item19);
					list4.Add(item23);
					list4.Add(item25);
					if (dk2.b("xpbl"))
					{
						list3.Add(item7);
						goto IL_AB6;
					}
					goto IL_AB6;
				}
				break;
			}
			case 17:
				if (A_2 == "Waterway_Security")
				{
					list.Add(item3);
					list.Add(item18);
					list2.Add(item5);
					list3.Add(item59);
					list3.Add(item11);
					list3.Add(item57);
					list3.Add(item58);
					list4.Add(item10);
					list4.Add(item88);
					if (dk2.b("xpbl"))
					{
						list3.Add(item7);
					}
					if (dk2.b("xphw"))
					{
						list3.Add(item8);
						goto IL_AB6;
					}
					goto IL_AB6;
				}
				break;
			case 19:
				if (A_2 == "Protectorate_Jetski")
				{
					list.Add(item50);
					list2.Add(item50);
					list2.Add(item50);
					list2.Add(item52);
					list3.Add(item50);
					list4.Add(item51);
					list4.Add(item52);
					list4.Add(item51);
					goto IL_AB6;
				}
				break;
			case 20:
				if (A_2 == "Waterway_Freelooters")
				{
					list.Add(item31);
					list.Add(item18);
					list.Add(item);
					list2.Add(item6);
					list2.Add(item34);
					list2.Add(item35);
					list3.Add(item39);
					list3.Add(item38);
					list4.Add(item19);
					list4.Add(item20);
					list4.Add(item21);
					list4.Add(item23);
					list4.Add(item25);
					goto IL_AB6;
				}
				break;
			}
		}
		list.Add(item);
		list.Add(item3);
		list.Add(item5);
		list.Add(item6);
		list.Add(item11);
		IL_AB6:
		Random random = new Random();
		int num = random.Next(1, 101);
		c5x c5x = new c5x();
		if (A_1 == null)
		{
			A_1 = new int?(random.Next(0, 30));
		}
		int? num2 = A_1;
		int num3 = 8;
		if (num2.GetValueOrDefault() <= num3 & num2 != null)
		{
			if (num <= 30)
			{
				c5x = vq.a(list2[random.Next(0, list2.Count)], A_0, false);
			}
			else
			{
				c5x = vq.a(list[random.Next(0, list.Count)], A_0, false);
			}
		}
		else
		{
			num2 = A_1;
			num3 = 8;
			if (num2.GetValueOrDefault() > num3 & num2 != null)
			{
				num2 = A_1;
				num3 = 12;
				if (num2.GetValueOrDefault() <= num3 & num2 != null)
				{
					if (num <= 5 && Enumerable.Any<string>(list4))
					{
						c5x = vq.a(list4[random.Next(0, list4.Count)], A_0, false);
						goto IL_F4E;
					}
					if (num > 5 && num <= 20)
					{
						c5x = vq.a(list3[random.Next(0, list3.Count)], A_0, false);
						goto IL_F4E;
					}
					if (num > 20 && num <= 60)
					{
						c5x = vq.a(list2[random.Next(0, list2.Count)], A_0, false);
						goto IL_F4E;
					}
					c5x = vq.a(list[random.Next(0, list.Count)], A_0, false);
					goto IL_F4E;
				}
			}
			num2 = A_1;
			num3 = 12;
			if (num2.GetValueOrDefault() > num3 & num2 != null)
			{
				num2 = A_1;
				num3 = 16;
				if (num2.GetValueOrDefault() <= num3 & num2 != null)
				{
					if (num <= 5 && Enumerable.Any<string>(list4))
					{
						c5x = vq.a(list4[random.Next(0, list4.Count)], A_0, false);
						goto IL_F4E;
					}
					if (num > 5 && num <= 15)
					{
						c5x = vq.a(list[random.Next(0, list.Count)], A_0, false);
						goto IL_F4E;
					}
					if (num > 15 && num <= 55)
					{
						c5x = vq.a(list3[random.Next(0, list3.Count)], A_0, false);
						goto IL_F4E;
					}
					c5x = vq.a(list2[random.Next(0, list2.Count)], A_0, false);
					goto IL_F4E;
				}
			}
			num2 = A_1;
			num3 = 16;
			if (num2.GetValueOrDefault() > num3 & num2 != null)
			{
				num2 = A_1;
				num3 = 20;
				if (num2.GetValueOrDefault() <= num3 & num2 != null)
				{
					if (num <= 2 && Enumerable.Any<string>(list5))
					{
						c5x = vq.a(list5[random.Next(0, list4.Count)], A_0, false);
						goto IL_F4E;
					}
					if (num > 2 && num <= 7 && Enumerable.Any<string>(list4))
					{
						c5x = vq.a(list4[random.Next(0, list4.Count)], A_0, false);
						goto IL_F4E;
					}
					if (num > 7 && num <= 37)
					{
						c5x = vq.a(list2[random.Next(0, list2.Count)], A_0, false);
						goto IL_F4E;
					}
					c5x = vq.a(list3[random.Next(0, list3.Count)], A_0, false);
					goto IL_F4E;
				}
			}
			if (num <= 4 && Enumerable.Any<string>(list5))
			{
				c5x = vq.a(list5[random.Next(0, list4.Count)], A_0, false);
			}
			else if (num > 4 && num <= 9 && Enumerable.Any<string>(list4))
			{
				c5x = vq.a(list4[random.Next(0, list4.Count)], A_0, false);
			}
			else if (num > 9 && num <= 30)
			{
				c5x = vq.a(list2[random.Next(0, list2.Count)], A_0, false);
			}
			else
			{
				c5x = vq.a(list3[random.Next(0, list3.Count)], A_0, false);
			}
		}
		IL_F4E:
		if (c5x != null)
		{
			a6p aspect = c5x.GetAspect<a6p>();
			c5x.t.b.y6()[ddq.ay] = new bt4(A_0.Name);
			if (c5x.h.b != null)
			{
				string text = null;
				if (A_2.EndsWith("Jetski"))
				{
					c5x.h.b.aa().Vehicle = this.c(c5x.h.b.am());
					if (c5x.h.b.aa().Vehicle != null)
					{
						if (this.a != null)
						{
							text = this.a;
						}
						if (aspect != null)
						{
							aspect.d().Add("-vehicle");
							aspect.d().Add("-feats");
							c5x.h.b.aa().Feats.d(typeof(cyz));
							c5x.h.b.aa().Feats.d(typeof(ej3));
						}
						c5x.h.b.aa().bl();
						c5x.h.b.aa().Vehicle.k();
						c5x.h.b.at();
					}
				}
				else
				{
					text = this.a(c5x.h.b.am(), A_2, null);
				}
				if (text != null)
				{
					c5x.h.b.a(text);
					if (aspect != null)
					{
						aspect.d().Add("-model");
					}
					if (c5x.h.b.am().Contains("_f"))
					{
						c5x.h.b.aa().Gender = Gender.Female;
						if (aspect != null)
						{
							aspect.d().Add("-system");
						}
					}
				}
				if (c5x.h.b.am() != c5x.h.b.aa().Portrait)
				{
					if (aspect != null)
					{
						aspect.d().Add("-appearance");
					}
					c5x.h.b.aa().Portrait = this.b;
				}
			}
			if (A_0.Name.EndsWith("nostlh") && c5x.h.b.aa().SpecialAbilities.a(typeof(e5b)))
			{
				c5x.t.b.y6()[ddq.ba] = true;
			}
			if (A_3 != null || A_4 != null)
			{
				if (aspect != null)
				{
					aspect.d().Add("-system");
				}
				if (A_3 != null)
				{
					c5x.q(A_3.ToString());
					c5x.h.b.aa().Name = A_3;
				}
				if (A_4 != null)
				{
					c5x.h.b.aa().FactionId = A_4;
				}
			}
			if (A_5 != null)
			{
				if (aspect != null)
				{
					aspect.d().Add("-ai");
				}
				c5x.t.b.a(A_5);
			}
			if (A_6 != null)
			{
				bn5 bn = c5x.GetAspect<j7>() as bn5;
				if (bn == null)
				{
					bn = new bn5(c5x);
					c5x.SetAspect<j7>(bn);
				}
				bn.a("speaker");
				bn.b(true);
				bn.b(A_6);
				if (A_2.EndsWith("Jetski"))
				{
					bn.a(false);
				}
			}
			if (A_7 && c5x.h.b != null)
			{
				if (aspect != null)
				{
					aspect.d().Add("-inventory");
				}
				efk efk = c5x.h.b.aa();
				if (efk != null)
				{
					foreach (coh coh in Enumerable.ToList<coh>(efk.Bag.z2()))
					{
						if (coh.Definition is x2 || coh.Definition.a7().GetPrimitivePropertyValue<bool>("MonsterInfrequent", new bool?(false)).Value)
						{
							efk.Bag.z5(coh);
						}
					}
					foreach (coh coh2 in efk.Gear.i())
					{
						if (coh2.Definition.a7().GetPrimitivePropertyValue<bool>("MonsterInfrequent", new bool?(false)).Value)
						{
							efk.Gear.c(coh2);
						}
					}
				}
			}
			if (A_8 != null && c5x.h.b != null)
			{
				if (aspect != null)
				{
					aspect.d().Add("-jobs");
				}
				c5x.h.b.ay().AddRange(A_8);
			}
			if (A_9)
			{
				c5x.t.b.y6()[ddq.b2] = true;
			}
		}
		return c5x;
	}

	// Token: 0x060032C6 RID: 12998 RVA: 0x0013C6C0 File Offset: 0x0013A8C0
	public c5x a(csd A_0, string A_1 = null, string A_2 = null, string A_3 = null, bool A_4 = false, string A_5 = null)
	{
		string text = "creatures\\dog";
		string text2 = "creatures\\xpbl\\doberman";
		string text3 = "creatures\\xpbl\\pitbull";
		string a_ = "creatures\\Faceless\\AugmentedRathound";
		List<string> list = new List<string>();
		Random random = new Random();
		c5x c5x;
		if (A_2 != null)
		{
			if (!(A_2 == "Dog"))
			{
				if (!(A_2 == "Doberman"))
				{
					if (!(A_2 == "Pitbull"))
					{
						if (!(A_2 == "AugRat"))
						{
							c5x = vq.a(text, A_0, false);
						}
						else
						{
							c5x = vq.a(a_, A_0, false);
						}
					}
					else
					{
						c5x = vq.a(text3, A_0, false);
					}
				}
				else
				{
					c5x = vq.a(text2, A_0, false);
				}
			}
			else
			{
				c5x = vq.a(text, A_0, false);
			}
		}
		else
		{
			list.Add(text);
			if (dk2.b("xpbl"))
			{
				list.Add(text2);
				list.Add(text3);
			}
			c5x = vq.a(list[random.Next(0, list.Count)], A_0, false);
		}
		if (c5x != null && c5x.h.b != null)
		{
			a6p aspect = c5x.GetAspect<a6p>();
			if (A_1 != null || A_3 != null)
			{
				if (aspect != null)
				{
					aspect.d().Add("-system");
				}
				if (A_1 != null)
				{
					c5x.h.b.aa().FactionId = A_1;
				}
				if (A_3 != null)
				{
					c5x.q(A_3.ToString());
					c5x.h.b.aa().Name = A_3;
				}
			}
			if (A_4)
			{
				bm6 aspect2 = c5x.GetAspect<bm6>();
				if (aspect2 != null)
				{
					aspect.d().Add("-ai");
					aspect2.b("humanSoldier");
					aspect2.y6()[ddq.ay] = new bt4(A_0.Name);
				}
			}
			if (A_5 != null)
			{
				bn5 bn = c5x.GetAspect<j7>() as bn5;
				if (bn == null)
				{
					bn = new bn5(c5x);
					c5x.SetAspect<j7>(bn);
				}
				bn.a("speaker");
				bn.b(true);
				bn.b(A_5);
			}
			if (c5x.h.b.am() == "xpbl_dg_pbb" && random.Next(0, 2) == 0)
			{
				c5x.h.b.a("xpbl_dg_pbw");
			}
		}
		return c5x;
	}

	// Token: 0x060032C7 RID: 12999 RVA: 0x0013C940 File Offset: 0x0013AB40
	public string a(string A_0, string A_1 = null, string A_2 = null)
	{
		string result = A_0;
		List<string> list = new List<string>();
		if (A_0.StartsWith("cmd"))
		{
			list.Add(bln.a8);
			list.Add(bln.a9);
			list.Add(bln.ba);
			list.Add(bln.bb);
		}
		else if (A_0.StartsWith("scavle"))
		{
			list.Add(bln.d);
			list.Add(bln.e);
			list.Add(bln.f);
			list.Add(bln.g);
			list.Add(bln.h);
		}
		else if (A_0.StartsWith("blve"))
		{
			list.Add(bln.i);
			list.Add(bln.j);
			list.Add(bln.k);
		}
		else if (A_0.StartsWith("rg"))
		{
			list.Add(bln.a4);
			list.Add(bln.a5);
			list.Add(bln.a6);
			list.Add(bln.a7);
		}
		else if (A_0.StartsWith("wrk"))
		{
			list.Add(bln.ac);
			list.Add(bln.ad);
			list.Add(bln.ae);
		}
		else if (A_0.StartsWith("brw"))
		{
			list.Add(bln.am);
			list.Add(bln.an);
		}
		else if (A_0.StartsWith("punk"))
		{
			list.Add(bln.l);
			list.Add(bln.m);
			list.Add(bln.n);
			list.Add(bln.o);
		}
		else if (A_0.StartsWith("ag"))
		{
			list.Add(bln.ax);
			list.Add(bln.ay);
			list.Add(bln.az);
			list.Add(bln.a0);
		}
		else if (A_0.StartsWith("mt") && A_1 != "Protectorate" && A_1 != "Foundry")
		{
			list.Add(bln.@as);
			list.Add(bln.at);
			list.Add(bln.au);
		}
		else if (A_0.StartsWith("hu"))
		{
			list.Add(bln.a2);
			list.Add(bln.a1);
		}
		else if (A_0 == "fl1" || A_0 == "fl2")
		{
			list.Add(bln.dd);
			list.Add(bln.de);
		}
		else if (A_0.StartsWith("xpbl_pr"))
		{
			if (A_0 == "xpbl_pr6" || A_0 == "xpbl_pr_f4")
			{
				list.Add(bln.hi);
				list.Add(bln.hm);
			}
			else if (A_0 == "xpbl_pr1" || A_0 == "xpbl_pr_f1" || A_0 == "xpbl_pr3" || A_0 == "xpbl_pr4")
			{
				list.Add(bln.hd);
				list.Add(bln.hj);
				list.Add(bln.hf);
				list.Add(bln.hg);
			}
			else if (A_0 != "xpbl_prf" && A_0 != "xpbl_prdv")
			{
				list.Add(bln.he);
				list.Add(bln.hh);
				list.Add(bln.hk);
				list.Add(bln.hl);
				list.Add(bln.ho);
			}
		}
		else if (A_0.StartsWith("xpbl_ags"))
		{
			if (A_0.Contains("0"))
			{
				list.Add(bln.hw);
				list.Add(bln.ht);
			}
			else
			{
				list.Add(bln.hx);
				list.Add(bln.hu);
				list.Add(bln.hv);
			}
		}
		else if (A_0.StartsWith("xpbl_svgw"))
		{
			list.Add(bln.ip);
			list.Add(bln.iq);
			list.Add(bln.ir);
			list.Add(bln.@is);
		}
		if (Enumerable.Any<string>(list))
		{
			Random random = new Random();
			result = list[random.Next(0, list.Count)];
		}
		return result;
	}

	// Token: 0x060032C8 RID: 13000 RVA: 0x0013CDD4 File Offset: 0x0013AFD4
	private bcx c(string A_0)
	{
		bcx result;
		if (A_0.StartsWith("xpbl_ags"))
		{
			result = this.b();
		}
		else if (A_0.StartsWith("xpbl_pr"))
		{
			result = this.b(A_0);
		}
		else if (A_0.StartsWith("xpbl_pm"))
		{
			result = this.a();
		}
		else
		{
			result = this.a(A_0);
		}
		return result;
	}

	// Token: 0x060032C9 RID: 13001 RVA: 0x0013CE44 File Offset: 0x0013B044
	private bcx b()
	{
		Random random = new Random();
		List<string> list = new List<string>();
		bcx result = new dgo().x4();
		list.Add(bln.hw);
		list.Add(bln.ht);
		if (Enumerable.Any<string>(list))
		{
			if (random.Next(0, 1) == 0)
			{
				this.b = bln.ht;
				this.a = bln.k5;
			}
			else
			{
				this.b = bln.hw;
				this.a = bln.k9;
			}
		}
		return result;
	}

	// Token: 0x060032CA RID: 13002 RVA: 0x0013CEC8 File Offset: 0x0013B0C8
	private bcx b(string A_0)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		Random random = new Random();
		List<string> list = new List<string>();
		bcx result = null;
		if (serviceOrThrow != null)
		{
			bool value = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("faction_xpbl_pir_gotAegisJets", new bool?(false)).Value;
			if (A_0 == "xpbl_pr6" || A_0 == "xpbl_pr_f4")
			{
				list.Add("xpbl_pr6");
				list.Add("xpbl_pr_f4");
			}
			else
			{
				list.Add("xpbl_pr2");
				list.Add("xpbl_pr3");
				list.Add("xpbl_prdv_f");
				list.Add("xpbl_pr_f1");
			}
			if (Enumerable.Any<string>(list))
			{
				string text = list[random.Next(0, list.Count)];
				if (text != null)
				{
					if (text == bln.he)
					{
						if (random.Next(0, 1) == 0)
						{
							result = new d1w().x4();
							this.a = bln.kw;
						}
						else
						{
							result = new bh6().x4();
							this.a = bln.k0;
						}
					}
					else if (text == bln.hf)
					{
						if (random.Next(0, 1) == 0)
						{
							result = new d1w().x4();
							this.a = bln.kx;
						}
						else
						{
							result = new cjl().x4();
							this.a = bln.k1;
						}
					}
					else if (text == bln.hi)
					{
						if (value && random.Next(0, 5) <= serviceOrThrow.aqu().r().GetPrimitivePropertyValue<int>("event_pir_meeting_jetsOfferLevel", new int?(0)).Value)
						{
							result = new dgo().x4();
							this.a = bln.k7;
						}
						else
						{
							result = new b44().x4();
							this.a = bln.ky;
						}
					}
					else if (text == bln.ho)
					{
						result = new bh6().x4();
						this.a = bln.k4;
					}
					else if (text == bln.hj)
					{
						result = new d1w().x4();
						this.a = bln.k2;
					}
					else if (text == bln.hm)
					{
						if (value && random.Next(0, 5) <= serviceOrThrow.aqu().r().GetPrimitivePropertyValue<int>("event_pir_meeting_jetsOfferLevel", new int?(0)).Value)
						{
							result = new dgo().x4();
							this.a = bln.la;
						}
						else
						{
							result = new bh6().x4();
							this.a = bln.k3;
						}
					}
					this.b = text;
				}
			}
		}
		return result;
	}

	// Token: 0x060032CB RID: 13003 RVA: 0x0013D1A8 File Offset: 0x0013B3A8
	private bcx a(string A_0)
	{
		Random random = new Random();
		List<string> list = new List<string>();
		bcx result = null;
		if (A_0.StartsWith("cmd"))
		{
			list.Add("cmd1");
			list.Add("cmd2");
			list.Add("cmd3");
			list.Add("cmd_f1");
		}
		else if (A_0.StartsWith("scavle") || A_0 == "drifter")
		{
			list.Add("scavle1");
			list.Add("scavle2");
			list.Add("scavle3");
			list.Add("scavle_f2");
		}
		else if (A_0.StartsWith("ag"))
		{
			list.Add("ag1");
			list.Add("ag2");
			list.Add("ag_f1");
			list.Add("ag_f2");
		}
		else if (A_0.StartsWith("rg"))
		{
			list.Add("rg1");
			list.Add("rg2");
		}
		else if (A_0.StartsWith("hu"))
		{
			list.Add("hu1");
			list.Add("hu_f1");
		}
		else
		{
			list.Add("punk1");
			list.Add("punk2");
			list.Add("punk_f1");
		}
		if (Enumerable.Any<string>(list))
		{
			string text = list[random.Next(0, list.Count)];
			if (text != null)
			{
				if (text == bln.a8)
				{
					result = new b44().x4();
					this.a = bln.lp;
				}
				else if (text == bln.a9)
				{
					result = new bh6().x4();
					this.a = bln.ls;
				}
				else if (text == bln.ba)
				{
					result = new cjl().x4();
					this.a = bln.lw;
				}
				else if (text == bln.bb)
				{
					result = new d1w().x4();
					this.a = bln.ld;
				}
				else if (text == bln.d)
				{
					result = new d1w().x4();
					this.a = bln.ln;
				}
				else if (text == bln.e)
				{
					result = new bh6().x4();
					this.a = bln.lv;
				}
				else if (text == bln.f)
				{
					result = new b44().x4();
					this.a = bln.lr;
				}
				else if (text == bln.h)
				{
					result = new cjl().x4();
					this.a = bln.li;
				}
				else if (text == bln.l)
				{
					if (random.Next(0, 2) == 0)
					{
						result = new bh6().x4();
						this.a = bln.lt;
					}
					else
					{
						result = new b44().x4();
						this.a = bln.lq;
					}
				}
				else if (text == bln.m)
				{
					result = new d1w().x4();
					this.a = bln.ln;
				}
				else if (text == bln.n)
				{
					result = new cjl().x4();
					this.a = bln.lh;
				}
				else if (text == bln.ax)
				{
					result = new b44().x4();
					this.a = bln.lo;
				}
				else if (text == bln.ay)
				{
					result = new d1w().x4();
					this.a = bln.lj;
				}
				else if (text == bln.az)
				{
					result = new cjl().x4();
					this.a = bln.lg;
				}
				else if (text == bln.a0)
				{
					result = new bh6().x4();
					this.a = bln.le;
				}
				else if (text == bln.a1)
				{
					result = new d1w().x4();
					this.a = bln.lk;
				}
				else if (text == bln.a2)
				{
					result = new bh6().x4();
					this.a = bln.lf;
				}
				else if (text == bln.a4)
				{
					result = new d1w().x4();
					this.a = bln.lm;
				}
				else if (text == bln.a5)
				{
					result = new bh6().x4();
					this.a = bln.lu;
				}
				this.b = text;
			}
		}
		return result;
	}

	// Token: 0x060032CC RID: 13004 RVA: 0x0013D690 File Offset: 0x0013B890
	private bcx a()
	{
		Random random = new Random();
		List<string> list = new List<string>();
		bcx result = new cda().x4();
		list.Add(bln.h1);
		list.Add(bln.h2);
		if (Enumerable.Any<string>(list))
		{
			if (random.Next(0, 1) == 0)
			{
				this.b = bln.h1;
				this.a = bln.lb;
			}
			else
			{
				this.b = bln.h2;
				this.a = bln.lc;
			}
		}
		return result;
	}

	// Token: 0x04001B20 RID: 6944
	private string a;

	// Token: 0x04001B21 RID: 6945
	private string b;
}

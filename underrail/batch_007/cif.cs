using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;
using Ouroboros.Playfield.Space;
using TimelapseVertigo.Playfield.Locale;
using TimelapseVertigo.Rules;

// Token: 0x02000A14 RID: 2580
[eiz("XPBLLECS1")]
[Serializable]
public sealed class cif : bdw, ISerializable
{
	// Token: 0x06003D67 RID: 15719 RVA: 0x0016DDA4 File Offset: 0x0016BFA4
	private cif(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x06003D68 RID: 15720 RVA: 0x0016DDAC File Offset: 0x0016BFAC
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x06003D69 RID: 15721 RVA: 0x0016DDB0 File Offset: 0x0016BFB0
	public cif()
	{
	}

	// Token: 0x06003D6A RID: 15722 RVA: 0x0016DDBC File Offset: 0x0016BFBC
	public void av(c1a A_0, cyt A_1)
	{
		if (A_0 != null)
		{
			aud aud = A_0.Areas[0];
			if (aud != null && !A_1.r().GetPrimitivePropertyValue<bool>("global_xpbl_expeditionUndeployed", new bool?(false)).Value)
			{
				if (A_1.r().GetPrimitivePropertyValue<bool>("global_xpbl_expeditionDestroyed", new bool?(false)).Value)
				{
					List<string> list = A_1.r().GetClassPropertyValue<List<string>>("loc_xpbl_le_camp_zonesDestroyed");
					if (list == null)
					{
						list = new List<string>();
					}
					if (!list.Contains(A_0.y8()))
					{
						this.b(aud, A_1);
						list.Add(A_0.y8());
						A_1.r()["loc_xpbl_le_camp_zonesDestroyed"] = list;
					}
					A_1.r()["loc_xpbl_camp_technicianCanBeHeardInContainer"] = false;
					return;
				}
				this.c(A_0, A_1);
				if (A_0.y8() == "xpbl_d5")
				{
					if (!A_1.r().GetPrimitivePropertyValue<bool>("loc_xpbl_le_coffins_noMoreCoffins", new bool?(false)).Value)
					{
						this.c(aud, A_1);
					}
					if (!A_1.r().GetPrimitivePropertyValue<bool>("loc_xpbl_d5_aegisBoatsSpawned", new bool?(false)).Value && (A_1.r().GetPrimitivePropertyValue<bool>("npc_xpbl_briggs_arrivedAtDock", new bool?(false)).Value || A_1.r().GetPrimitivePropertyValue<bool>("global_beginExpedition", new bool?(false)).Value))
					{
						this.b(A_0, A_1);
					}
				}
				if (A_0.y8() == "xpbl_d6")
				{
					if (!A_1.r().GetPrimitivePropertyValue<bool>("npc_xpbl_le_technician_discovered", new bool?(false)).Value && A_1.r().GetPrimitivePropertyValue<bool>("global_xpbl_le_philsImplantAcquired", new bool?(false)).Value && !A_1.r().GetPrimitivePropertyValue<bool>("loc_xpbl_le_lightAndVendingFixed", new bool?(false)).Value)
					{
						this.d(aud, A_1);
					}
					if (A_1.r().GetPrimitivePropertyValue<bool>("npc_xpbl_le_technician_discovered", new bool?(false)).Value)
					{
						c5x c5x = new ar7(new Guid("3d1da26e-a38d-4296-8c97-aa22a1eecb45"), aud).ao() as c5x;
						if (c5x != null && c5x.t.b != null && !c5x.t.b.y6().GetClassPropertyValue<bt4>(ddq.ay).b().EndsWith("6"))
						{
							if (c5x.t.b.y6().GetClassPropertyValue<bt4>(ddq.ay).b().StartsWith("N"))
							{
								c5x.t.b.y6()[ddq.ay] = new bt4("NA6");
							}
							else
							{
								c5x.t.b.y6()[ddq.ay] = new bt4("A6");
							}
						}
					}
					this.a(A_0, A_1);
				}
				if (A_0.y8() == "xpbl_e6" && A_1.r().GetPrimitivePropertyValue<bool>("global_beginExpedition", new bool?(false)).Value && !A_1.r().GetPrimitivePropertyValue<bool>("global_xpbl_pirates_joined", new bool?(false)).Value && (A_1.ac() as bv9).abu(asp.a, asp.f5).a != h.a)
				{
					if (A_1.r().GetPrimitivePropertyValue<bool>("global_xpbl_le_philsImplantAcquired", new bool?(false)).Value && !A_1.r().GetPrimitivePropertyValue<bool>("loc_xpbl_e6_crowdPlaced", new bool?(false)).Value)
					{
						this.d(A_0, A_1);
					}
					else if (A_1.r().GetPrimitivePropertyValue<bool>("loc_le_openedFort", new bool?(false)).Value && !A_1.r().GetPrimitivePropertyValue<bool>("loc_xpbl_e6_crowdRemoved", new bool?(false)).Value)
					{
						this.d(A_0, A_1);
					}
					if (A_1.r().GetPrimitivePropertyValue<bool>("interface_xpbl_mc_microChipImplanter_extractedChipFromPhilsHand", new bool?(false)).Value)
					{
						this.a(aud, A_1);
					}
				}
				if (A_1.r().GetPrimitivePropertyValue<bool>("loc_xpbl_camp_underAttack", new bool?(false)).Value)
				{
					this.f(aud, A_1);
					return;
				}
				if (!A_1.r().GetPrimitivePropertyValue<bool>("loc_xpbl_camp_underAttack", new bool?(false)).Value)
				{
					this.e(aud, A_1);
				}
			}
		}
	}

	// Token: 0x06003D6B RID: 15723 RVA: 0x0016E278 File Offset: 0x0016C478
	private void d(c1a A_0, cyt A_1)
	{
		c5x c5x = new ar7(new Guid("6739002c-5cbd-4158-81ee-c14a24a0cc92"), A_0.n("xpbl_e6")).ao() as c5x;
		c5x c5x2 = new ar7(new Guid("d0577449-97ef-46a1-970f-750d533a02bf"), A_0.n("xpbl_e6")).ao() as c5x;
		c5x c5x3 = new ar7(new Guid("ca3b3af8-b49c-4028-b90e-46003e072067"), A_0.n("xpbl_e6")).ao() as c5x;
		string text;
		string text2;
		string text3;
		if (!A_1.r().GetPrimitivePropertyValue<bool>("loc_le_openedFort", new bool?(false)).Value)
		{
			text = "researcher_fort";
			text2 = "laborer_fort";
			text3 = "guard_fort";
			A_1.r()["loc_xpbl_e6_crowdPlaced"] = true;
		}
		else
		{
			text = "NA4";
			text2 = "NA1";
			text3 = "NA2";
			A_1.r()["loc_xpbl_e6_crowdRemoved"] = true;
		}
		if (c5x != null)
		{
			a0l.a(c5x, text, true);
			c5x.t.b.y6()[ddq.ay] = new bt4(text);
			c5x.t.b.y6()["AlarmGuardAnimation"] = CharacterState.Operating;
			c5x.t.b.y6()[ddq.w] = CharacterState.Idle;
		}
		if (c5x3 != null)
		{
			a0l.a(c5x3, text2, true);
			c5x3.t.b.y6()[ddq.ay] = new bt4(text2);
		}
		if (c5x2 != null)
		{
			a0l.a(c5x2, text3, true);
			c5x2.t.b.y6()[ddq.ay] = new bt4(text3);
		}
	}

	// Token: 0x06003D6C RID: 15724 RVA: 0x0016E444 File Offset: 0x0016C644
	private void f(aud A_0, cyt A_1)
	{
		d60 d = A_0.Zone.a();
		if (d != null)
		{
			List<b0b> list = d.ab4(new string[]
			{
				"alarmSoundSource"
			});
			if (list != null && list.Count > 0)
			{
				foreach (b0b b0b in list)
				{
					aru aru = ((c5x)b0b).c();
					app app;
					aru.e().TryGetValue("alarm", out app);
					if (app == null)
					{
						aru.a("alarm", "PrisonAlarm", 0.4f, c9z.b, true, false);
					}
				}
			}
		}
		foreach (b0b b0b2 in Enumerable.ToList<b0b>(A_0.Entities))
		{
			c5x c5x = (c5x)b0b2;
			if (c5x != null && c5x.qe() != new Guid("419d485d-1c39-4698-8034-5710aa1df716") && c5x.t.b != null)
			{
				if (c5x.t.b.y6().GetClassPropertyValue<bt4>(ddq.ay) != null && c5x.t.b.y6().GetClassPropertyValue<bt4>(ddq.ay).b().StartsWith("NA"))
				{
					bt4 classPropertyValue = c5x.t.b.y6().GetClassPropertyValue<bt4>(ddq.ay);
					classPropertyValue.a(classPropertyValue.b().Remove(0, 1));
					csd csd = A_0.Zone.g(classPropertyValue.b());
					if (csd != null)
					{
						a0l.a(c5x, csd.Name, true);
						c5x.t.b.y6()[ddq.ay] = new bt4(csd.Name);
					}
				}
				else
				{
					List<string> classPropertyValue2 = c5x.t.b.y6().GetClassPropertyValue<List<string>>("AlarmPatrolRoute");
					List<string> classPropertyValue3 = c5x.t.b.y6().GetClassPropertyValue<List<string>>(ddq.k);
					if (classPropertyValue3 == null && classPropertyValue2 != null)
					{
						c5x.t.b.y6()[ddq.k] = classPropertyValue2;
						c5x.t.b.y6()["AlarmPatrolRoute"] = classPropertyValue3;
					}
				}
				CharacterState? primitivePropertyValue = c5x.t.b.y6().GetPrimitivePropertyValue<CharacterState>(ddq.w, null);
				if (primitivePropertyValue != null)
				{
					CharacterState? characterState = primitivePropertyValue;
					CharacterState characterState2 = CharacterState.Idle;
					if (!(characterState.GetValueOrDefault() == characterState2 & characterState != null))
					{
						c5x.t.b.y6()["AlarmGuardAnimation"] = primitivePropertyValue;
						c5x.t.b.y6()[ddq.w] = CharacterState.Idle;
					}
				}
			}
			if (c5x.qe() == new Guid("eaa0a2ff-1596-468b-988c-60ba825a1d61") && c5x.h.b != null && euf.o(c5x.h.b.aa().Offense.u()))
			{
				c5x.h.b.aa().Offense.k();
			}
		}
	}

	// Token: 0x06003D6D RID: 15725 RVA: 0x0016E7FC File Offset: 0x0016C9FC
	private void e(aud A_0, cyt A_1)
	{
		d60 d = A_0.Zone.a();
		if (d != null)
		{
			List<b0b> list = d.ab4(new string[]
			{
				"alarmSoundSource"
			});
			if (list != null && list.Count > 0)
			{
				foreach (b0b b0b in list)
				{
					aru aru = ((c5x)b0b).c();
					app app;
					aru.e().TryGetValue("alarm", out app);
					if (app != null)
					{
						aru.a("alarm", false);
					}
				}
			}
		}
		foreach (b0b b0b2 in Enumerable.ToList<b0b>(A_0.Entities))
		{
			c5x c5x = (c5x)b0b2;
			if (c5x != null && c5x.qe() != new Guid("419d485d-1c39-4698-8034-5710aa1df716") && c5x.t.b != null)
			{
				if (c5x.t.b.y6().GetClassPropertyValue<bt4>(ddq.ay) != null && c5x.t.b.y6().GetClassPropertyValue<bt4>(ddq.ay).b().StartsWith("A"))
				{
					csd csd = A_0.Zone.g("N" + c5x.t.b.y6().GetClassPropertyValue<bt4>(ddq.ay).b());
					if (csd != null)
					{
						a0l.a(c5x, csd.Name, true);
						c5x.t.b.y6()[ddq.ay] = new bt4(csd.Name);
					}
				}
				else
				{
					List<string> classPropertyValue = c5x.t.b.y6().GetClassPropertyValue<List<string>>("AlarmPatrolRoute");
					List<string> classPropertyValue2 = c5x.t.b.y6().GetClassPropertyValue<List<string>>(ddq.k);
					if (classPropertyValue2 != null)
					{
						c5x.t.b.y6()["AlarmPatrolRoute"] = classPropertyValue;
						c5x.t.b.y6()[ddq.k] = classPropertyValue2;
					}
				}
				CharacterState? primitivePropertyValue = c5x.t.b.y6().GetPrimitivePropertyValue<CharacterState>("AlarmGuardAnimation", null);
				if (primitivePropertyValue != null)
				{
					CharacterState? characterState = primitivePropertyValue;
					CharacterState characterState2 = CharacterState.Idle;
					if (!(characterState.GetValueOrDefault() == characterState2 & characterState != null))
					{
						c5x.t.b.y6()[ddq.w] = primitivePropertyValue;
						c5x.t.b.y6().RemoveProperty("AlarmGuardAnimation");
					}
				}
			}
			if (c5x.qe() == new Guid("eaa0a2ff-1596-468b-988c-60ba825a1d61") && c5x.h.b != null && !euf.o(c5x.h.b.aa().Offense.u()))
			{
				c5x.h.b.aa().Offense.k();
			}
		}
	}

	// Token: 0x06003D6E RID: 15726 RVA: 0x0016EB8C File Offset: 0x0016CD8C
	private void d(aud A_0, cyt A_1)
	{
		c5x c5x = new ar7(new Guid("3862a3a8-67d7-435a-b2df-54381be609cd"), A_0).ao() as c5x;
		if (c5x != null)
		{
			dt5 aspect = c5x.GetAspect<dt5>();
			if (aspect != null)
			{
				aspect.g().Clear();
				aspect.g().Add("xpbl_campPower");
			}
		}
		c5x c5x2 = new ar7(new Guid("314b6425-e21a-4823-8cc7-56045d83fc05"), A_0).ao() as c5x;
		if (c5x2 != null)
		{
			if (c5x2.p.b != null)
			{
				c5x2.p.b.a[1].f = 1f;
			}
			d85 d = c5x2.GetAspect<bim>() as d85;
			if (d != null)
			{
				d.a().Clear();
				d.a().Add("Исправлено.");
			}
		}
		A_1.r()["loc_xpbl_le_lightAndVendingFixed"] = true;
	}

	// Token: 0x06003D6F RID: 15727 RVA: 0x0016EC78 File Offset: 0x0016CE78
	private void c(aud A_0, cyt A_1)
	{
		int num = A_1.r().GetPrimitivePropertyValue<int>("loc_xpbl_le_coffins_nextCoffinToSpawn", new int?(0)).Value;
		int value = A_1.r().GetPrimitivePropertyValue<int>("global_xpbl_aegisSecTroopersAvailable", new int?(0)).Value;
		int value2 = A_1.r().GetPrimitivePropertyValue<int>("global_xpbl_aegisSecTroopersStartedWith", new int?(0)).Value;
		bool value3 = A_1.r().GetPrimitivePropertyValue<bool>("npc_xpbl_briggs_dead", new bool?(false)).Value;
		bool value4 = A_1.r().GetPrimitivePropertyValue<bool>("npc_xpbl_briggs_coffin", new bool?(false)).Value;
		bool value5 = A_1.r().GetPrimitivePropertyValue<bool>("npc_xpbl_yahota_dead", new bool?(false)).Value;
		bool value6 = A_1.r().GetPrimitivePropertyValue<bool>("npc_xpbl_yahota_coffin", new bool?(false)).Value;
		bool value7 = A_1.r().GetPrimitivePropertyValue<bool>("npc_xpbl_marcus_dead", new bool?(false)).Value;
		bool value8 = A_1.r().GetPrimitivePropertyValue<bool>("npc_xpbl_marcus_coffin", new bool?(false)).Value;
		bool value9 = A_1.r().GetPrimitivePropertyValue<bool>("npc_xpbl_ladelman_dead", new bool?(false)).Value;
		bool value10 = A_1.r().GetPrimitivePropertyValue<bool>("npc_xpbl_ladelman_coffin", new bool?(false)).Value;
		bool value11 = A_1.r().GetPrimitivePropertyValue<bool>("npc_xpbl_le_doc_dead", new bool?(false)).Value;
		bool value12 = A_1.r().GetPrimitivePropertyValue<bool>("npc_xpbl_le_doc_coffin", new bool?(false)).Value;
		List<string> list = A_1.r().GetClassPropertyValue<List<string>>("loc_xpbl_le_coffins_nameList");
		int num2 = value2 - value;
		List<c5x> list2 = new List<c5x>();
		d60 d = A_0.Zone.a();
		if (d != null)
		{
			foreach (b0b b0b in d.ab4(new string[]
			{
				"xpbl_le_coffins"
			}))
			{
				c5x c5x = (c5x)b0b;
				if (c5x != null)
				{
					float? ae = c5x.ae;
					float num3 = 0f;
					if (ae.GetValueOrDefault() == num3 & ae != null)
					{
						list2.Add(c5x);
					}
				}
			}
		}
		if (Enumerable.Any<c5x>(list2))
		{
			list2.Sort(new Comparison<c5x>(cif.a.a.a));
			if (list == null)
			{
				Random random = new Random();
				list = new List<string>
				{
					"Татьяна Миррина",
					"Спайк Гумберт",
					"Барух Раф",
					"Лерой Баррет",
					"Даниэль Ллойд",
					"Ариана Болдуин",
					"Миха Вик",
					"Джеймс Ганизани",
					"Хардинг Кентон",
					"Пол Джош"
				};
				for (int i = list.Count; i > 1; i--)
				{
					int index = random.Next(i);
					string value13 = list[i - 1];
					list[i - 1] = list[index];
					list[index] = value13;
				}
			}
			int num4 = 0;
			if (value3 && !value4)
			{
				num4++;
				A_1.r()["npc_xpbl_briggs_coffin"] = true;
				list.Insert(num, "Ричард Бриггс");
			}
			if (value5 && !value6)
			{
				num4++;
				A_1.r()["npc_xpbl_yahota_coffin"] = true;
				list.Insert(num, "Яхота Гейл");
			}
			if (value7 && !value8)
			{
				num4++;
				A_1.r()["npc_xpbl_marcus_coffin"] = true;
				list.Insert(num, "Маркус Вертер");
			}
			if (value9 && !value10)
			{
				num4++;
				A_1.r()["npc_xpbl_ladelman_coffin"] = true;
				list.Insert(num, "Энтони Ладельман");
			}
			if (value11 && !value12)
			{
				num4++;
				A_1.r()["npc_xpbl_le_doc_coffin"] = true;
				list.Insert(num, "Борис Дикий");
			}
			A_1.r()["loc_xpbl_le_coffins_nameList"] = list;
			if (num2 > num * 3 && num < list.Count)
			{
				int num5 = 1;
				int num6 = num * 3;
				while (num6 < num2 && num4 + num < list.Count)
				{
					if (num5 == 3)
					{
						num4++;
						num5 = 1;
					}
					else
					{
						num5++;
					}
					num6++;
				}
			}
			if (num4 > 0)
			{
				for (int j = 0; j < num4; j++)
				{
					c5x c5x2 = list2[j];
					if (c5x2 != null)
					{
						c5x2.ae = new float?((float)1);
						c5x2.TileFormationModifiers = new bjp(new byte[]
						{
							1
						});
						if (c5x2.Location.Z == 1.4f)
						{
							c5x2.VisualPriority = 2;
						}
						else if (c5x2.Location.Z == 0.9f)
						{
							c5x2.VisualPriority = 1;
						}
						else
						{
							c5x2.VisualPriority = 0;
						}
						d85 d2 = c5x2.GetAspect<bim>() as d85;
						if (d2 != null)
						{
							d2.g(true);
							d2.a().Add(list[num]);
						}
						num++;
					}
				}
			}
			A_1.r()["loc_xpbl_le_coffins_nextCoffinToSpawn"] = num;
			return;
		}
		A_1.r()["loc_xpbl_le_coffins_noMoreCoffins"] = true;
	}

	// Token: 0x06003D70 RID: 15728 RVA: 0x0016F278 File Offset: 0x0016D478
	private void c(c1a A_0, cyt A_1)
	{
		int value = A_1.r().GetPrimitivePropertyValue<int>("global_xpbl_aegisSecTroopersAvailable", new int?(0)).Value;
		if (value < 20)
		{
			d60 d = A_0.a();
			if (d != null)
			{
				List<b0b> list = d.ab4(new string[]
				{
					"xpbl_le_disposableTroopers"
				});
				int num;
				if (value < 20 && value >= 15)
				{
					num = 4;
				}
				else if (value < 15 && value >= 10)
				{
					num = 3;
				}
				else if (value < 10 && value >= 5)
				{
					num = 2;
				}
				else if (value < 5 && value != 0)
				{
					num = 1;
				}
				else
				{
					num = 0;
				}
				Random random = new Random();
				if (list.Count > num)
				{
					for (int i = list.Count; i > 1; i--)
					{
						int index = random.Next(i);
						b0b value2 = list[i - 1];
						list[i - 1] = list[index];
						list[index] = value2;
					}
					for (int j = list.Count; j > num; j--)
					{
						list[j - 1].w();
						list[j - 1].an();
					}
				}
			}
		}
	}

	// Token: 0x06003D71 RID: 15729 RVA: 0x0016F3CC File Offset: 0x0016D5CC
	private void b(aud A_0, cyt A_1)
	{
		if (!A_1.r().GetPrimitivePropertyValue<bool>("loc_xpbl_le_camp_powerDisabledPermanently", new bool?(false)).Value)
		{
			d60 d = A_0.Zone.a();
			if (d != null)
			{
				c5x c5x = Enumerable.FirstOrDefault<b0b>(d.ab4(new string[]
				{
					"xpbl_le_campPower"
				})) as c5x;
				if (c5x != null)
				{
					axh aspect = c5x.GetAspect<axh>();
					if (aspect != null)
					{
						aspect.a(null, false, null);
						A_1.r()["loc_xpbl_le_camp_powerDisabledPermanently"] = true;
					}
				}
			}
		}
		this.a(A_0.Zone, A_0.Zone.y8() + "_L2_junk");
		this.a(A_0.Zone, A_0.Zone.y8() + "_L3_desLights");
		Random random = new Random();
		List<coh> list = new List<coh>();
		bool flag = false;
		foreach (b0b b0b in Enumerable.ToList<b0b>(A_0.Entities))
		{
			c5x c5x2 = (c5x)b0b;
			if (c5x2 != null)
			{
				if (c5x2.h.b != null && (c5x2.h.b.aa().FactionId == asp.f5 || c5x2.h.b.aa().FactionId == asp.f7 || c5x2.h.b.aa().FactionId == asp.f6 || c5x2.y8().Contains("Auto-Turret")))
				{
					c5x2.h.b.aa().a(null, null, false);
				}
				else if (c5x2.a("destroyedBed") || c5x2.a("destroyedTent"))
				{
					if (c5x2.o.b != null)
					{
						if (c5x2.a("destroyedBed"))
						{
							c5x2.o.b.a = "Objects\\Obstacles\\xpbl_CampBedBurned" + c5x2.o.b.a.Substring(c5x2.o.b.a.Length - 1, 1);
						}
						else if (c5x2.a("destroyedTent"))
						{
							a3f aspect2 = c5x2.GetAspect<a3f>();
							if (aspect2 != null && aspect2.a().GetPrimitivePropertyValue<int>("frameX", null) != null)
							{
								c5x2.o.b.a = "Objects\\Obstacles\\xpbl_TentDestroyed";
								c5x2.o.b.b.X = aspect2.a().GetPrimitivePropertyValue<int>("frameX", null).Value;
							}
						}
					}
				}
				else if (c5x2.a("pickupable") || c5x2.a("destroyedStandingLight"))
				{
					c5x2.w();
					c5x2.an();
				}
				else if (A_1.r().GetClassPropertyValue<string>("loc_xpbl_e5_invadersType") == "Pirates")
				{
					if (c5x2.s.b != null && c5x2.s.b is c7j)
					{
						c7j c7j = c5x2.GetAspect<bim>() as c7j;
						if (c5x2.a("xpbl_d6_playersLocker"))
						{
							if (Enumerable.Any<coh>(c7j.ItemContainer.z2()))
							{
								list.AddRange(c7j.ItemContainer.z2());
								flag = true;
								c7j.ItemContainer.z2().Clear();
							}
						}
						else
						{
							c7j.ItemContainer.z2().Clear();
						}
						c7j.d(true);
						d2b aspect3 = c5x2.GetAspect<d2b>();
						if (aspect3 != null)
						{
							aspect3.e(false);
						}
					}
					if (A_0.Zone.y8() == "xpbl_d5")
					{
						wv wv = c5x2.GetAspect<bim>() as wv;
						if (wv != null)
						{
							if (wv.g().l().Contains("player"))
							{
								list.AddRange(wv.g().ap().z2());
								flag = true;
							}
							c5x2.w();
							c5x2.an();
							A_1.r()["faction_xpbl_pir_gotAegisJets"] = true;
							A_1.r()["event_pir_meeting_jetsOfferLevel"] = 4;
							A_1.r()["faction_xpbl_expedition_jetSkiStrength"] = 0;
						}
					}
				}
			}
		}
		if (A_0.Zone.y8() == "xpbl_d5" && A_1.r().GetClassPropertyValue<string>("loc_xpbl_e5_invadersType") == "Pirates")
		{
			erb.a("xpbl_agsBoat1_clean", A_0.Zone.g("AegisBoat1"));
			erb.a("xpbl_agsBoat3_clean", A_0.Zone.g("AegisBoat3"));
		}
		if (flag)
		{
			A_1.r()["global_xpbl_playersItemsFromCampLocker"] = list;
			A_1.a(new bw0("xpbl_g2", new @do(), 1));
		}
		if (A_1.r().GetClassPropertyValue<string>("loc_xpbl_e5_invadersType") == "Sormirbaren")
		{
			this.a(A_0.Zone, A_0.Zone.y8() + "_L4_savageInv");
			gx gx = new gx();
			bu6 service = bpo.GetService<bu6>();
			List<string> list2 = @is.a(true);
			int num = 10;
			int num2 = 0;
			if (service != null)
			{
				if (service.aq2() >= GameDifficulty.Dominating)
				{
					num = 30;
				}
				else if (service.aq2() == GameDifficulty.Hard)
				{
					num = 20;
				}
				else if (service.aq2() == GameDifficulty.Easy)
				{
					num = 5;
				}
			}
			foreach (csd csd in Enumerable.ToList<csd>(A_0.Zone.Waypoints))
			{
				if (csd != null && csd.Name.Contains("savage_spawn"))
				{
					Vector3 a_;
					HorizontalDirection horizontalDirection;
					new bt4(csd.Name).a(A_0.Zone, out A_0, out a_, out horizontalDirection);
					ak1 ak = A_0.a(a_.a());
					if (ak != null && !aw1.a(null, ak, false, null))
					{
						c5x c5x3;
						if (csd.Name.Contains("Shaman"))
						{
							if (A_1.r().GetPrimitivePropertyValue<int>("loc_xpbl_e5_battleNumber", new int?(0)).Value == 5 && random.Next(0, 101) > 80)
							{
								c5x3 = vq.a("creatures\\genericHumans\\xpbl\\savageShamanGreater", csd, false);
							}
							else
							{
								c5x3 = vq.a("creatures\\generichumans\\xpbl\\savageShaman", csd, false);
							}
						}
						else if (random.Next(0, 101) < num)
						{
							c5x3 = vq.a(list2[num2++], csd, false);
						}
						else
						{
							c5x3 = gx.a(csd, new int?(10), "Sormirbaren", null, null, null, null, false, null, false);
						}
						if (c5x3 != null && c5x3.t.b != null)
						{
							if (c5x3.t.b.y6().GetClassPropertyValue<bt4>(ddq.ay) == null)
							{
								c5x3.t.b.y6()[ddq.ay] = new bt4(csd.Name);
								if (csd.Name.Contains("Shaman"))
								{
									c5x3.t.b.y6()[ddq.w] = CharacterState.CastingPsi;
								}
							}
							c5x3.t.b.y6()[ddq.bs] = new exw(d6n.a, 0.0, true, null);
						}
					}
				}
			}
		}
	}

	// Token: 0x06003D72 RID: 15730 RVA: 0x0016FC50 File Offset: 0x0016DE50
	private void a(aud A_0, cyt A_1)
	{
		TimeSpan? primitivePropertyValue = A_1.r().GetPrimitivePropertyValue<TimeSpan>("loc_xpbl_e6_timeTillNextCoffeeRestock", null);
		if (!A_1.r().GetPrimitivePropertyValue<bool>("loc_xpbl_e6_timeTillNextCoffeeRestock_setFirstTime", new bool?(false)).Value)
		{
			A_1.r()["loc_xpbl_e6_timeTillNextCoffeeRestock"] = TimeSpan.FromMinutes(90.0);
			return;
		}
		if (primitivePropertyValue == null || primitivePropertyValue >= A_1.p())
		{
			A_1.r()["loc_xpbl_e6_timeTillNextCoffeeRestock"] = TimeSpan.FromMinutes(90.0);
			c5x c5x = new ar7(new Guid("300c3b9d-949d-4b36-9ed5-2da3d942c759"), A_0).ao() as c5x;
			if (c5x != null)
			{
				c7j c7j = c5x.GetAspect<bim>() as c7j;
				if (c7j != null)
				{
					int num = 3;
					bu6 service = bpo.GetService<bu6>();
					if (service != null)
					{
						if (service.aq2() >= GameDifficulty.Dominating)
						{
							num = 1;
						}
						else if (service.aq2() == GameDifficulty.Hard)
						{
							num = 2;
						}
						else if (service.aq2() == GameDifficulty.Easy)
						{
							num = 4;
						}
					}
					List<d5o> list = c7j.ItemContainer.z2().a("coffee", 5);
					int num2 = 0;
					if (list.Count > 0)
					{
						num2 = Enumerable.Sum<d5o>(list, new Func<d5o, int>(cif.a.a.a));
					}
					if (num2 < num)
					{
						for (int i = num2; i < num; i++)
						{
							coh coh = new d48(ez2.CreateDefinitonProvider<a3e>("consumables\\food\\xpbl\\coffee"));
							if (coh != null)
							{
								c7j.ItemContainer.z2().Add(coh);
							}
						}
						c7j.ItemContainer.aad();
					}
				}
			}
		}
	}

	// Token: 0x06003D73 RID: 15731 RVA: 0x0016FE48 File Offset: 0x0016E048
	private void b(c1a A_0, cyt A_1)
	{
		erb.a(A_1, A_0, "xpbl_agsBoat1_clean", A_0.g("AegisBoat1"));
		erb.a(A_1, A_0, "xpbl_agsBoat3_clean", A_0.g("AegisBoat3"));
		A_1.r()["loc_xpbl_d5_aegisBoatsSpawned"] = true;
	}

	// Token: 0x06003D74 RID: 15732 RVA: 0x0016FE9C File Offset: 0x0016E09C
	private void a(c1a A_0, cyt A_1)
	{
		bool value = A_1.r().GetPrimitivePropertyValue<bool>("loc_le_openedFort", new bool?(false)).Value;
		bool value2 = A_1.r().GetPrimitivePropertyValue<bool>("loc_xpbl_sc_foundDispatcherCoordinates", new bool?(false)).Value;
		if (A_0.y8() == "xpbl_d6")
		{
			d60 d = A_0.a();
			if (d != null)
			{
				foreach (b0b b0b in d.ab4(new string[]
				{
					"kitchenContainers"
				}))
				{
					c5x c5x = (c5x)b0b;
					if (c5x != null)
					{
						c7j c7j = c5x.GetAspect<bim>() as c7j;
						if (c7j != null && Enumerable.Any<coh>(c7j.ItemContainer.z2()))
						{
							if (value && c5x.y8() == "Freezer")
							{
								c7j.ItemContainer.z2().Clear();
							}
							if (value2 && c5x.y8() == "Refrigerator")
							{
								c7j.ItemContainer.z2().Clear();
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06003D75 RID: 15733 RVA: 0x0016FFF4 File Offset: 0x0016E1F4
	private void a(c1a A_0, string A_1)
	{
		doq a_ = doq.a(Path.Combine(d5x.q(), A_1) + ".uzl");
		A_0.a(a_, 1, null);
	}

	// Token: 0x02000A15 RID: 2581
	[CompilerGenerated]
	[Serializable]
	private sealed class a
	{
		// Token: 0x06003D78 RID: 15736 RVA: 0x00170040 File Offset: 0x0016E240
		internal int a(c5x A_0, c5x A_1)
		{
			return A_0.VisualPriority.CompareTo(A_1.VisualPriority);
		}

		// Token: 0x06003D79 RID: 15737 RVA: 0x00170064 File Offset: 0x0016E264
		internal int a(d5o A_0)
		{
			return A_0.StackPortion;
		}

		// Token: 0x04001B9E RID: 7070
		public static readonly cif.a a = new cif.a();

		// Token: 0x04001B9F RID: 7071
		public static Comparison<c5x> b;

		// Token: 0x04001BA0 RID: 7072
		public static Func<d5o, int> c;
	}
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using Ouroboros.Common.Data;
using Ouroboros.Playfield.Space;
using TimelapseVertigo.AI.Behaviors.Custom.Xphw;
using TimelapseVertigo.Rules;

// Token: 0x020007DA RID: 2010
public static class dqp
{
	// Token: 0x0600324C RID: 12876 RVA: 0x0013789C File Offset: 0x00135A9C
	public static void g()
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		bu6 service = bpo.GetService<bu6>();
		if (serviceOrThrow.aqu() != null && !serviceOrThrow.aqu().r().HasProperty("faction_xphw_exoBase_exosoldiers_count"))
		{
			int num = 80;
			int num2 = 30;
			if (service != null)
			{
				if (service.aq2() >= GameDifficulty.Dominating)
				{
					num += 30;
					num2 += 10;
				}
				else if (service.aq2() == GameDifficulty.Hard)
				{
					num += 15;
					num2 += 5;
				}
			}
			serviceOrThrow.aqu().r()["faction_xphw_exoBase_exosoldiers_count_max"] = num;
			serviceOrThrow.aqu().r()["faction_xphw_exoBase_superExosoldiers_count_max"] = num2;
			serviceOrThrow.aqu().r()["faction_xphw_exoBase_exosoldiers_count"] = num;
			serviceOrThrow.aqu().r()["faction_xphw_exoBase_superExosoldiers_count"] = num2;
		}
	}

	// Token: 0x0600324D RID: 12877 RVA: 0x00137984 File Offset: 0x00135B84
	public static List<c5x> a(List<csd> A_0, bool A_1, bool A_2 = false, bool A_3 = false, float A_4 = 0.5f, float A_5 = 0.5f, bool A_6 = false, List<string> A_7 = null)
	{
		List<string> list;
		if (A_7 != null)
		{
			list = A_7;
		}
		else
		{
			list = dqp.a(A_0.Count, A_2, A_3, A_4, A_5, A_6);
		}
		int num = 0;
		int num2 = (int)Math.Ceiling((double)A_0.Count / 2.0);
		if (list != null && Enumerable.Any<string>(list))
		{
			string a_ = dqp.f();
			List<c5x> list2 = new List<c5x>();
			foreach (csd csd in A_0)
			{
				if (num >= list.Count)
				{
					break;
				}
				c5x c5x = vq.a(list[num++], csd, false);
				if (c5x != null)
				{
					c5x = dqp.a(c5x, a_, A_1);
					if (c5x.t.b != null)
					{
						if (--num2 >= 0)
						{
							c5x.t.b.y6()[ddq.a5] = new List<Guid>
							{
								c29.a
							};
						}
						if (A_1)
						{
							c5x.t.b.y6()[ddq.ay] = new bt4(csd.Name + "_guard");
							c5x.t.b.y6()[ddq.bh] = "XPHWEBUC";
						}
						else
						{
							c5x.t.b.y6()[ddq.ay] = new bt4(csd.Name);
						}
					}
					if (A_2)
					{
						cnk service = bpo.GetService<cnk>();
						if (service.aqu() != null && !service.aqu().r().GetPrimitivePropertyValue<bool>("npc_xphw_gunslinger_died", new bool?(false)).Value && service.aqu().r().GetPrimitivePropertyValue<bool>("npc_xphw_gunslinger_teamUp", new bool?(false)).Value)
						{
							c5x.b("gunslingerObservable");
							if (c5x.GetAspect<a3f>() == null)
							{
								a3f a3f = new a3f(c5x);
								c5x.SetAspect<a3f>(a3f);
								a3f.a()["CommentCode"] = Xphw_GunslingerCommentCodeEnum.Combat_SuperSoldierEncounter;
								a3f.a()["Retry"] = false;
							}
						}
						service.aqu().r()["faction_xphw_exoBase_superSoldiers_deployed"] = true;
					}
					list2.Add(c5x);
				}
			}
			return list2;
		}
		return null;
	}

	// Token: 0x0600324E RID: 12878 RVA: 0x00137C34 File Offset: 0x00135E34
	public static List<csd> a(string A_0, c1a A_1)
	{
		if (!string.IsNullOrWhiteSpace(A_0) && A_1 != null)
		{
			List<csd> list = new List<csd>();
			foreach (csd csd in Enumerable.ToList<csd>(A_1.Waypoints))
			{
				if (csd.Name.Contains(A_0) && !csd.Name.EndsWith("_guard"))
				{
					list.Add(csd);
				}
			}
			return list;
		}
		return null;
	}

	// Token: 0x0600324F RID: 12879 RVA: 0x00137CD4 File Offset: 0x00135ED4
	public static List<string> a(bool A_0, c1a A_1, HorizontalDirection? A_2 = null)
	{
		if (A_1 != null)
		{
			List<csd> list = new List<csd>();
			List<string> list2 = new List<string>();
			string value = "deploy_" + (A_0 ? "mobile" : "static");
			foreach (csd csd in Enumerable.ToList<csd>(A_1.Waypoints))
			{
				if (csd.Name.Contains(value))
				{
					if (A_0)
					{
						cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
						if (serviceOrThrow.aqu() != null)
						{
							b0b a_ = serviceOrThrow.aqu().v().b() as c5x;
							ak1 a_2 = csd.Tile;
							if (aw1.a(a_, a_2) < 10.0)
							{
								continue;
							}
						}
					}
					int length = csd.Name.Length - (csd.Name.EndsWith("_guard") ? 8 : 2);
					if (!list2.Contains(csd.Name.Substring(0, length)))
					{
						list.Add(csd);
						list2.Add(csd.Name.Substring(0, length));
					}
				}
			}
			return list2;
		}
		return null;
	}

	// Token: 0x06003250 RID: 12880 RVA: 0x00137E28 File Offset: 0x00136028
	private static List<string> a(int A_0, bool A_1 = false, bool A_2 = false, float A_3 = 0.5f, float A_4 = 0.5f, bool A_5 = false)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null)
		{
			A_0 = Math.Min(A_0, A_1 ? serviceOrThrow.aqu().r().GetPrimitivePropertyValue<int>("faction_xphw_exoBase_superExosoldiers_count", new int?(0)).Value : serviceOrThrow.aqu().r().GetPrimitivePropertyValue<int>("faction_xphw_exoBase_exosoldiers_count", new int?(0)).Value);
			if (A_0 > 0)
			{
				List<string> list = new List<string>();
				string item = "creatures\\generichumans\\xphw\\exoSoldierRifleman";
				string item2 = "creatures\\generichumans\\xphw\\exoSoldierMachineGunner";
				string item3 = "creatures\\generichumans\\xphw\\exoSoldierGrenadier";
				string item4 = "creatures\\generichumans\\xphw\\exoSoldierEnergyGunner";
				string item5 = "creatures\\generichumans\\xphw\\exoSoldierMinigunner";
				string item6 = "creatures\\generichumans\\xphw\\exoSoldierSniper";
				string item7 = "creatures\\generichumans\\xphw\\exoSoldierAntiArmor";
				string item8 = "creatures\\generichumans\\xphw\\xpbl\\exoSoldierShotgunner";
				string item9 = "creatures\\generichumans\\xphw\\Technomedic";
				string item10 = "creatures\\generichumans\\xphw\\Intercessor";
				string item11 = "creatures\\generichumans\\xphw\\Psychophract";
				string item12 = "creatures\\machines\\xphw\\bostonBotFreezing";
				string item13 = "creatures\\machines\\xphw\\bostonBotScanner";
				List<string> list2 = new List<string>();
				List<string> list3 = new List<string>
				{
					item12,
					item13
				};
				if (!A_1)
				{
					int num = A_5 ? 60 : 20;
					list2.Add(item);
					list2.Add(item);
					list2.Add(item2);
					list2.Add(item4);
					list2.Add(item3);
					if (cuo.a.Next(0, 101) < num)
					{
						list2.Add(item5);
					}
					if (cuo.a.Next(0, 101) < num)
					{
						list2.Add(item6);
					}
					if (!A_5 && dk2.b("xpbl"))
					{
						list2.Add(item8);
					}
					if (A_5 && cuo.a.Next(0, 101) < 20)
					{
						list2.Add(item7);
					}
					if (A_0 > 2)
					{
						if (A_4 > 0f)
						{
							list.Add(item9);
						}
						if (A_0 > 7 || (A_0 > 5 && (double)A_4 > 0.5))
						{
							list.Add(item9);
						}
						if (A_0 > 13 || (A_0 > 10 && (double)A_4 > 0.5))
						{
							list.Add(item9);
						}
						if (A_2)
						{
							list.Add(item10);
						}
					}
				}
				else
				{
					list2.Add(item11);
				}
				int num2 = 0;
				int num3 = cuo.a.Next(0, list3.Count);
				int num4 = 0;
				int num5 = 0;
				for (int i = list.Count; i < A_0; i++)
				{
					if (A_3 != 0f && (num2 == 0 || (float)(num2 + 1) / (float)A_0 < 0.2f + ((A_3 > 0.5f) ? (A_3 / 10f) : (-(1f - A_3)))))
					{
						list.Add(list3[++num3 % list3.Count]);
						num2++;
					}
					else
					{
						string item14 = list2[cuo.a.Next(0, list2.Count)];
						list.Add(item14);
						if (!A_1)
						{
							if (string.Equals(item14, item6))
							{
								list2.Remove(item14);
							}
							else if (string.Equals(item14, item5))
							{
								if ((float)(++num4 / A_0) >= 0.13f)
								{
									list2.Remove(item14);
								}
							}
							else if (string.Equals(item14, item3) || string.Equals(item14, item7))
							{
								if ((float)(++num5 / A_0) >= 0.13f)
								{
									list2.Remove(item7);
									list2.Remove(item3);
								}
								else if (string.Equals(item14, item7))
								{
									list2.Remove(item7);
								}
							}
						}
					}
				}
				return cuo.ShuffleList<string>(list, null);
			}
		}
		return null;
	}

	// Token: 0x06003251 RID: 12881 RVA: 0x001381F8 File Offset: 0x001363F8
	public static string c(c5x A_0)
	{
		if (A_0 != null)
		{
			e3l aspect = A_0.GetAspect<e3l>();
			if (aspect != null)
			{
				foreach (string text in aspect.a)
				{
					if (!string.IsNullOrEmpty(text) && text.StartsWith("SquadName_"))
					{
						return text.Substring(10);
					}
				}
			}
		}
		return null;
	}

	// Token: 0x06003252 RID: 12882 RVA: 0x0013828C File Offset: 0x0013648C
	private static string f()
	{
		List<string> list = new List<string>
		{
			"Андромеда",
			"Водолей",
			"Жертвенник",
			"Возничий",
			"Волопас",
			"Киль",
			"Кассиопея",
			"Центавр",
			"Цефей",
			"Волосы Вероники",
			"Северная Корона",
			"Дракон",
			"Близнецы",
			"Геркулес",
			"Гидра",
			"Южная Гидра",
			"Единорог",
			"Змееносец",
			"Орион",
			"Пегас",
			"Персей",
			"Феникс",
			"Корма",
			"Стрелец",
			"Паруса",
			"Дева"
		};
		cnk service = bpo.GetService<cnk>();
		if (service.aqu() != null)
		{
			Random random = new Random(service.aqu().l());
			for (int i = list.Count; i > 1; i--)
			{
				int index = random.Next(i);
				string value = list[i - 1];
				list[i - 1] = list[index];
				list[index] = value;
			}
			int num = service.aqu().r().GetPrimitivePropertyValue<int>("faction_xphw_exoBase_squadNameIndex", new int?(0)).Value;
			int num2 = service.aqu().r().GetPrimitivePropertyValue<int>("faction_xphw_exoBase_squadNameNumeral", new int?(0)).Value;
			bool flag = false;
			if (num > list.Count - 1)
			{
				num = 0;
				flag = true;
			}
			service.aqu().r()["faction_xphw_exoBase_squadNameIndex"] = num + 1;
			if (flag)
			{
				if (num2 >= 1000)
				{
					num2 = 0;
				}
				else
				{
					num2++;
				}
			}
			service.aqu().r()["faction_xphw_exoBase_squadNameNumeral"] = num2;
			return list[num] + "-" + num2.ToString();
		}
		return list[0];
	}

	// Token: 0x06003253 RID: 12883 RVA: 0x00138504 File Offset: 0x00136704
	private static c5x a(c5x A_0, string A_1, bool A_2)
	{
		bpo.GetServiceOrThrow<cnk>();
		if (A_0 != null)
		{
			A_0.b("SquadName_" + A_1);
			A_0.b("dsp_exobase");
			if (!A_2)
			{
				A_0.b("StaticDeployment");
			}
			dqp.b(A_0);
			if (A_0.h.b != null)
			{
				if (A_0.h.b.aa().Gear.l().Item != null && A_0.h.b.aa().Gear.l().Item.Definition.ba() != null)
				{
					double num = A_0.h.b.aa().Gear.l().Item.Battery;
					int? num2 = A_0.h.b.aa().Gear.l().Item.Definition.ba();
					double? num3 = (num2 != null) ? new double?((double)num2.GetValueOrDefault()) : null;
					if (!(num == num3.GetValueOrDefault() & num3 != null))
					{
						A_0.h.b.aa().Gear.l().Item.Battery = (double)A_0.h.b.aa().Gear.l().Item.Definition.ba().Value;
					}
				}
				if (A_2)
				{
					A_0.h.b.aa().BaseMovementSpeed = 0.8f;
					A_0.h.b.aa().bl();
				}
			}
		}
		return A_0;
	}

	// Token: 0x06003254 RID: 12884 RVA: 0x001386D4 File Offset: 0x001368D4
	private static c5x b(c5x A_0)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (A_0 != null && A_0.h.b != null && serviceOrThrow.aqu() != null)
		{
			if (A_0.h.b.aa().b(d8o.e))
			{
				A_0.b("ExoSquad_Bot");
			}
			else if (A_0.a("SuperExosoldier") || A_0.h.b.am() == bln.ma)
			{
				A_0.b("SuperExosoldier");
				serviceOrThrow.aqu().r()["faction_xphw_exoBase_superExosoldiers_count"] = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<int>("faction_xphw_exoBase_superExosoldiers_count", new int?(0)).Value - 1;
			}
			else
			{
				serviceOrThrow.aqu().r()["faction_xphw_exoBase_exosoldiers_count"] = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<int>("faction_xphw_exoBase_exosoldiers_count", new int?(0)).Value - 1;
			}
		}
		return A_0;
	}

	// Token: 0x06003255 RID: 12885 RVA: 0x001387F4 File Offset: 0x001369F4
	public static bool a(c1a A_0, bool A_1, bool A_2 = false)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null && dqp.e())
		{
			if (A_2)
			{
				return true;
			}
			if (dqp.a(A_0, serviceOrThrow.aqu()))
			{
				return false;
			}
			float value = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<float>("faction_xphw_exoBase_alarmLevel", new float?((float)1)).Value;
			float value2 = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<float>("faction_xphw_exoBase_exosoldiers_casualtiesPerMinute", new float?(0f)).Value;
			int value3 = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<int>(A_0.y8() + "_squadCounter", new int?(0)).Value;
			if (A_1)
			{
				TimeSpan? primitivePropertyValue = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<TimeSpan>("faction_xphw_exoBase_nextMobileDeploymentCheck", null);
				if (primitivePropertyValue == null || serviceOrThrow.aqu().o() >= primitivePropertyValue)
				{
					double a_ = Math.Max(0.5, 1.0 + (double)(value3 / 4) - (double)(value / 5f));
					double a_2 = Math.Max(1.0, 2.0 + (double)(value3 / 3) - (double)(value / 5f));
					serviceOrThrow.aqu().r()["faction_xphw_exoBase_nextMobileDeploymentCheck"] = serviceOrThrow.aqu().o() + TimeSpan.FromMinutes(cuo.a(a_, a_2));
					if (value2 * 2f <= value)
					{
						return true;
					}
				}
			}
			else
			{
				d60 d = A_0.a();
				if (d != null && Enumerable.FirstOrDefault<b0b>(d.ab4(new string[]
				{
					"StaticDeployment"
				})) != null)
				{
					return false;
				}
				int num = 1;
				if (A_0.y8().EndsWith("out") && !serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("faction_xphw_exoBase_entered", new bool?(false)).Value)
				{
					num = Math.Min(10, 2 * serviceOrThrow.aqu().r().GetPrimitivePropertyValue<int>("faction_xphw_exoBase_exosoldiers_killed", new int?(1)).Value);
				}
				else if (A_0.y8().EndsWith("up1") || A_0.y8().EndsWith("up2"))
				{
					num = 5;
				}
				if (cuo.a.Next(0, 101) <= 10 * num)
				{
					return true;
				}
				if (value2 * 2f > value)
				{
					return true;
				}
			}
		}
		return false;
	}

	// Token: 0x06003256 RID: 12886 RVA: 0x00138AB0 File Offset: 0x00136CB0
	public static void a(c5x A_0)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null && A_0 != null)
		{
			if (A_0.a("SuperExosoldier"))
			{
				serviceOrThrow.aqu().r()["faction_xphw_exoBase_superExosoldiers_count"] = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<int>("faction_xphw_exoBase_superExosoldiers_count", new int?(0)).Value + 1;
			}
			else if (!A_0.a("ExoSquad_Bot"))
			{
				serviceOrThrow.aqu().r()["faction_xphw_exoBase_exosoldiers_count"] = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<int>("faction_xphw_exoBase_exosoldiers_count", new int?(0)).Value + 1;
			}
			A_0.w();
			A_0.an();
		}
	}

	// Token: 0x06003257 RID: 12887 RVA: 0x00138B84 File Offset: 0x00136D84
	public static bool e()
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null && !serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("npc_xphw_psiCommander_dead", new bool?(false)).Value && !serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("loc_xphw_exoBase_voidBattleWon", new bool?(false)).Value)
		{
			bool flag = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("faction_xphw_exoBase_exosoldiers_stopDeployment", new bool?(false)).Value;
			if (serviceOrThrow.aqu().r().GetPrimitivePropertyValue<int>("faction_xphw_exoBase_exosoldiers_count", new int?(0)).Value <= 5 && !flag)
			{
				dqp.a();
				if (serviceOrThrow.aqu().r().GetPrimitivePropertyValue<int>("faction_xphw_exoBase_exosoldiers_count", new int?(0)).Value > 1)
				{
					return true;
				}
				flag = true;
				serviceOrThrow.aqu().r()["faction_xphw_exoBase_exosoldiers_stopDeployment"] = flag;
			}
			if (!flag)
			{
				return true;
			}
			if (dqp.d())
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x06003258 RID: 12888 RVA: 0x00138CA8 File Offset: 0x00136EA8
	public static bool d(c1a A_0)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null)
		{
			if (serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("faction_xphw_exoBase_returnedToCryo", new bool?(false)).Value)
			{
				return true;
			}
			if (A_0.y8().EndsWith("com") && serviceOrThrow.aqu().r().GetPrimitivePropertyValue<int>("faction_xphw_exoBase_exosoldiers_count", new int?(0)).Value <= 10)
			{
				return false;
			}
			if (serviceOrThrow.aqu().r().GetPrimitivePropertyValue<int>("faction_xphw_exoBase_exosoldiers_count", new int?(0)).Value <= 10)
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x06003259 RID: 12889 RVA: 0x00138D60 File Offset: 0x00136F60
	public static bool d()
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null && !serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("npc_xphw_psiCommander_dead", new bool?(false)).Value)
		{
			if (serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("faction_xphw_exoBase_superSoldiers_stopDeployment", new bool?(false)).Value || serviceOrThrow.aqu().r().GetPrimitivePropertyValue<int>("faction_xphw_exoBase_superExosoldiers_count", new int?(0)).Value <= 1)
			{
				return false;
			}
			if (serviceOrThrow.aqu().r().GetPrimitivePropertyValue<int>("faction_xphw_exoBase_exosoldiers_count", new int?(0)).Value <= 0 || serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("faction_xphw_exoBase_exosoldiers_stopDeployment", new bool?(false)).Value)
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x0600325A RID: 12890 RVA: 0x00138E50 File Offset: 0x00137050
	public static bool a(c1a A_0, cyt A_1)
	{
		if (A_0 == null || A_1 == null)
		{
			return false;
		}
		if (dqp.d() || A_1.r().GetPrimitivePropertyValue<bool>("faction_xphw_exoBase_restrictedAccess", new bool?(false)).Value)
		{
			return false;
		}
		bool value = A_1.r().GetPrimitivePropertyValue<bool>("faction_xphw_exoBase_entered", new bool?(false)).Value;
		float value2 = (float)A_1.r().GetPrimitivePropertyValue<int>("faction_xphw_exoBase_exosoldiers_killed", new int?(0)).Value;
		int value3 = A_1.r().GetPrimitivePropertyValue<int>("faction_xphw_exoBase_exosoldiers_count_max", new int?(0)).Value;
		float num = value ? 0.5f : 0.2f;
		return value2 > (float)value3 * num;
	}

	// Token: 0x0600325B RID: 12891 RVA: 0x00138F1C File Offset: 0x0013711C
	public static HorizontalDirection? c(c1a A_0)
	{
		HorizontalDirection? result = null;
		Dictionary<string, HorizontalDirection> dictionary = dqp.b(A_0);
		if (dictionary != null && Enumerable.Any<KeyValuePair<string, HorizontalDirection>>(dictionary))
		{
			cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
			if (serviceOrThrow.aqu() != null)
			{
				string classPropertyValue = serviceOrThrow.aqu().r().GetClassPropertyValue<string>("loc_xphw_exoBase_lastDeploymentZone");
				if (!string.IsNullOrEmpty(classPropertyValue) && Enumerable.Contains<string>(dictionary.Keys, classPropertyValue))
				{
					result = new HorizontalDirection?(dictionary[classPropertyValue]);
				}
			}
		}
		return result;
	}

	// Token: 0x0600325C RID: 12892 RVA: 0x00138F9C File Offset: 0x0013719C
	private static Dictionary<string, HorizontalDirection> b(c1a A_0)
	{
		Dictionary<string, HorizontalDirection> dictionary = new Dictionary<string, HorizontalDirection>();
		foreach (Property property in Enumerable.ToList<Property>(A_0.CustomProperties.Properties))
		{
			if (property.Name == "AdjacentZones")
			{
				foreach (string text in (property.Value as List<string>))
				{
					if (!string.IsNullOrEmpty(text))
					{
						dictionary.Add(text.Substring(0, text.LastIndexOf("_")), bnx.a(Enumerable.Last<string>(text.Split(new char[]
						{
							'_'
						}))));
					}
				}
			}
		}
		return dictionary;
	}

	// Token: 0x0600325D RID: 12893 RVA: 0x001390A0 File Offset: 0x001372A0
	public static bool? a(c1a A_0, bool A_1 = false)
	{
		cnk service = bpo.GetService<cnk>();
		d60 d = A_0.a();
		bool? result = null;
		if (service.aqu() != null)
		{
			if (A_0.y8().EndsWith("lab1"))
			{
				if (A_1 && !service.aqu().r().GetPrimitivePropertyValue<bool>("loc_xphw_exobase_lab1_deploymentEnabled", new bool?(false)).Value)
				{
					if (dqp.a(A_0, false, true))
					{
						List<csd> list = dqp.a("deploy_alarm", A_0);
						if (list != null && Enumerable.Any<csd>(list))
						{
							bool a_ = false;
							bu6 service2 = bpo.GetService<bu6>();
							if (service2 != null && service2.aq2() >= GameDifficulty.Hard)
							{
								a_ = true;
							}
							List<c5x> list2 = dqp.a(list, false, dqp.d(), true, 0.5f, 0.5f, a_, null);
							if (list2 != null && Enumerable.Any<c5x>(list2))
							{
								foreach (c5x c5x in list2)
								{
									if (c5x.t.b != null)
									{
										c5x.t.b.y6()[ddq.ay] = new bt4(c5x.t.b.y6().GetClassPropertyValue<bt4>(ddq.ay).b() + "_guard");
									}
								}
							}
						}
					}
					service.aqu().r()["faction_xphw_exoBase_nextMobileDeploymentCheck"] = service.aqu().o() + TimeSpan.FromMinutes(4.0);
					service.aqu().r()["loc_xphw_exobase_lab1_deploymentEnabled"] = true;
					result = new bool?(true);
				}
			}
			else if (A_0.y8().EndsWith("com"))
			{
				if (dqp.a(A_0, false, true) && service.aqu().r().GetPrimitivePropertyValue<int>("faction_xphw_exoBase_exosoldiers_count", new int?(0)).Value <= 10 && service.aqu().r().GetPrimitivePropertyValue<int>("faction_xphw_exoBase_exosoldiers_count", new int?(0)).Value > 0 && d != null && Enumerable.FirstOrDefault<b0b>(d.ab4(new string[]
				{
					"StaticDeployment"
				})) == null)
				{
					List<csd> list3 = dqp.a("deploy_lastStand", A_0);
					if (list3 != null && Enumerable.Any<csd>(list3))
					{
						dqp.a(list3, false, false, false, 0f, 0.3f, true, null);
						result = new bool?(true);
					}
				}
			}
			else if (A_0.y8().EndsWith("tun"))
			{
				if (!service.aqu().r().GetPrimitivePropertyValue<bool>("faction_xphw_exoBase_entered", new bool?(false)).Value && !service.aqu().r().GetPrimitivePropertyValue<bool>("loc_xphw_exobase_tun_deployedAmbushSquad", new bool?(false)).Value && dqp.a(A_0, false, true) && d != null && Enumerable.FirstOrDefault<b0b>(d.ab4(new string[]
				{
					"StaticDeployment"
				})) == null)
				{
					List<csd> list4 = dqp.a("deploy_ambush", A_0);
					if (list4 != null && Enumerable.Any<csd>(list4))
					{
						service.aqu().r()["loc_xphw_exobase_tun_deployedAmbushSquad"] = true;
						dqp.a(list4, false, false, true, 0.5f, 0.5f, false, dqp.c());
						result = new bool?(true);
					}
				}
			}
			else if (A_0.y8().EndsWith("ent") && service.aqu().r().GetPrimitivePropertyValue<bool>("loc_xphw_exobase_arm_foundKeycard", new bool?(false)).Value && !service.aqu().r().GetPrimitivePropertyValue<bool>("loc_xphw_exobase_tun_deployedLobbySquad", new bool?(false)).Value && service.aqu().r().GetPrimitivePropertyValue<int>("faction_xphw_exoBase_exosoldiers_killed", new int?(0)).Value > 0 && dqp.a(A_0, false, true) && d != null && Enumerable.FirstOrDefault<b0b>(d.ab4(new string[]
			{
				"StaticDeployment"
			})) == null)
			{
				service.aqu().r()["loc_xphw_exobase_tun_deployedLobbySquad"] = true;
				result = new bool?(false);
			}
		}
		return result;
	}

	// Token: 0x0600325E RID: 12894 RVA: 0x00139548 File Offset: 0x00137748
	public static List<string> c()
	{
		bu6 service = bpo.GetService<bu6>();
		if (service != null)
		{
			List<string> list = new List<string>
			{
				"creatures\\generichumans\\xphw\\exoSoldierMinigunner",
				"creatures\\generichumans\\xphw\\exoSoldierGrenadier",
				(service.aq2() < GameDifficulty.Hard) ? "creatures\\generichumans\\xphw\\exoSoldierRifleman" : "creatures\\generichumans\\xphw\\exoSoldierMachineGunner",
				"creatures\\generichumans\\xphw\\Intercessor",
				"creatures\\generichumans\\xphw\\Technomedic",
				"creatures\\machines\\xphw\\bostonBotScanner"
			};
			if (service.aq2() >= GameDifficulty.Dominating)
			{
				list.Add("creatures\\generichumans\\xphw\\exoSoldierSniper");
			}
			return list;
		}
		return null;
	}

	// Token: 0x0600325F RID: 12895 RVA: 0x001395DC File Offset: 0x001377DC
	public static List<string> b()
	{
		return new List<string>
		{
			"xphw_exobase_arm",
			"xphw_exobase_com",
			"xphw_exobase_ent",
			"xphw_exobase_lab1",
			"xphw_exobase_labu1",
			"xphw_exobase_labu2",
			"xphw_exobase_med1",
			"xphw_exobase_med2",
			"xphw_exobase_out",
			"xphw_exobase_tun",
			"xphw_exobase_up1",
			"xphw_exobase_up2"
		};
	}

	// Token: 0x06003260 RID: 12896 RVA: 0x00139674 File Offset: 0x00137874
	public static void a(List<b0b> A_0, string A_1, string A_2)
	{
		if (A_0 != null && Enumerable.Any<b0b>(A_0) && !string.IsNullOrEmpty(A_2))
		{
			cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
			if (serviceOrThrow.aqu() != null)
			{
				int num = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<int>(A_2 + "_squadCounter", new int?(0)).Value;
				string str = "_squad";
				int num2;
				num = (num2 = num + 1);
				string path = A_2 + str + num2.ToString() + ".dat";
				string text = Path.Combine("glent\\xphw_exosq", path).ToLowerInvariant();
				if (!bmg.b(text))
				{
					bmg.b().PutItemCompressed<List<b0b>>(text, A_0, true);
				}
				serviceOrThrow.aqu().r()[A_2 + "_squadCounter"] = num;
			}
		}
	}

	// Token: 0x06003261 RID: 12897 RVA: 0x00139748 File Offset: 0x00137948
	public static List<b0b> a(int A_0, string A_1, bool A_2 = true)
	{
		if (!string.IsNullOrEmpty(A_1))
		{
			string path = A_1 + "_squad" + A_0.ToString() + ".dat";
			string text = Path.Combine("glent\\xphw_exosq", path).ToLowerInvariant();
			if (bmg.b(text))
			{
				List<b0b> itemCompressed = bmg.b().GetItemCompressed<List<b0b>>(text, false);
				if (itemCompressed != null && Enumerable.Any<b0b>(itemCompressed))
				{
					if (A_2)
					{
						bmg.b().e(text);
					}
					return itemCompressed;
				}
			}
		}
		return null;
	}

	// Token: 0x06003262 RID: 12898 RVA: 0x001397C8 File Offset: 0x001379C8
	public static void a()
	{
		foreach (string a_ in dqp.b())
		{
			dqp.a(a_);
		}
	}

	// Token: 0x06003263 RID: 12899 RVA: 0x00139820 File Offset: 0x00137A20
	public static void a(string A_0)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null)
		{
			for (int i = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<int>(A_0 + "_squadCounter", new int?(0)).Value; i > 0; i--)
			{
				dqp.a(i, A_0, true);
			}
			serviceOrThrow.aqu().r().RemoveProperty(A_0 + "_squadCounter");
		}
	}

	// Token: 0x06003264 RID: 12900 RVA: 0x0013989C File Offset: 0x00137A9C
	public static void a(c1a A_0)
	{
		List<string> list = dqp.b();
		if (list != null)
		{
			Dictionary<string, HorizontalDirection> dictionary = dqp.b(A_0);
			foreach (string text in list)
			{
				if (A_0.y8() != text && !Enumerable.Contains<string>(dictionary.Keys, text))
				{
					dqp.a(text);
				}
			}
		}
	}

	// Token: 0x06003265 RID: 12901 RVA: 0x00139924 File Offset: 0x00137B24
	public static void a(bool A_0 = true)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null && serviceOrThrow.aqw() != null)
		{
			for (int i = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<int>(serviceOrThrow.aqw().y8() + "_squadCounter", new int?(0)).Value; i > 0; i--)
			{
				List<b0b> list = dqp.a(i, serviceOrThrow.aqw().y8(), A_0);
				if (list != null && Enumerable.Any<b0b>(list))
				{
					foreach (b0b b0b in list)
					{
						e3l aspect = b0b.GetAspect<e3l>();
						if (aspect != null)
						{
							string text = Enumerable.FirstOrDefault<string>(aspect.a, new Func<string, bool>(dqp.a.a.a));
							if (!string.IsNullOrEmpty(text))
							{
								aud aud = serviceOrThrow.aqw().n(text.Substring(5));
								if (aud != null)
								{
									aspect.a.Remove(text);
									b0b.Layer = aju.x;
									aud.a(b0b);
									dqp.b(b0b as c5x);
								}
							}
						}
					}
				}
			}
			serviceOrThrow.aqu().r().RemoveProperty(serviceOrThrow.aqw().y8() + "_squadCounter");
		}
	}

	// Token: 0x04001AFA RID: 6906
	private const string a = "faction_xphw_exoBase_exosoldiers_count";

	// Token: 0x04001AFB RID: 6907
	private const string b = "faction_xphw_exoBase_superExosoldiers_count";

	// Token: 0x04001AFC RID: 6908
	private const string c = "faction_xphw_exoBase_nextMobileDeploymentCheck";

	// Token: 0x04001AFD RID: 6909
	private const string d = "glent\\xphw_exosq";

	// Token: 0x020007DB RID: 2011
	[CompilerGenerated]
	[Serializable]
	private sealed class a
	{
		// Token: 0x06003268 RID: 12904 RVA: 0x00139AD0 File Offset: 0x00137CD0
		internal bool a(string A_0)
		{
			return A_0.StartsWith("Area_");
		}

		// Token: 0x04001AFE RID: 6910
		public static readonly dqp.a a = new dqp.a();

		// Token: 0x04001AFF RID: 6911
		public static Func<string, bool> b;
	}
}

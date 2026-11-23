using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using TimelapseVertigo.Generators.Items;
using TimelapseVertigo.Playfield.Locale;
using TimelapseVertigo.Rules.Characters;

// Token: 0x020007D3 RID: 2003
public static class d06
{
	// Token: 0x0600322E RID: 12846 RVA: 0x00135058 File Offset: 0x00133258
	public static c5x a(c5x A_0, bfc A_1)
	{
		d2b aspect = A_0.GetAspect<d2b>();
		if (aspect != null && aspect.n() && aspect.e())
		{
			int num = (int)((double)(10 + ((A_1.BaseLevel > 0) ? A_1.BaseLevel : 10) * 5) * (0.75 + cuo.a.NextDouble() * 0.5));
			num = Math.Max(5, num / 5 * 5);
			aspect.a(num);
		}
		ery aspect2 = A_0.GetAspect<ery>();
		if (aspect2 != null)
		{
			int a_ = Math.Max(1, A_1.BaseLevel - 5);
			int a_2 = A_1.BaseLevel + 3;
			int a_3 = A_1.BaseLevel + 7;
			foreach (xs xs in aspect2.f().g())
			{
				if (xs.Generator != null)
				{
					xs.Generator.na(a_);
					if ((xs.Generator is df8 && ((df8)xs.Generator).b() / (ItemRange)100 == ItemRange.MedicalDrugs) || (xs.Generator is a64 && ((a64)xs.Generator).c() is fv))
					{
						xs.Generator.nc(a_3);
					}
					else
					{
						xs.Generator.nc(a_2);
					}
				}
			}
		}
		return A_0;
	}

	// Token: 0x0600322F RID: 12847 RVA: 0x001351EC File Offset: 0x001333EC
	public static c5x a(c5x A_0)
	{
		Random random = new Random();
		if (A_0 != null)
		{
			int x = random.Next(0, 3);
			A_0.o.b.b.X = x;
		}
		return A_0;
	}

	// Token: 0x06003230 RID: 12848 RVA: 0x00135228 File Offset: 0x00133428
	public static List<string> c(List<string> A_0 = null, string A_1 = "X")
	{
		List<string> list = new List<string>
		{
			"ww_smallMerchantBoatX1",
			"ww_smallMerchantBoatX2",
			"ww_smallMerchantBoatY1",
			"ww_smallMerchantBoatY2",
			"ww_largeMerchantBoatX1",
			"ww_largeMerchantBoatX2",
			"ww_largeMerchantBoatY1",
			"ww_largeMerchantBoatY2",
			"ww_largeScrapBoatX1",
			"ww_largeScrapBoatY1",
			"xpbl_ww_largeMerchantBoatX1"
		};
		List<string> list2 = new List<string>();
		if (A_1 == "X" || A_1 == "Y")
		{
			using (List<string>.Enumerator enumerator = list.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					string text = enumerator.Current;
					if (text.Substring(text.Length - 2, 1) == A_1 && (dk2.b("xpbl") || !text.ToLowerInvariant().StartsWith("xpbl")))
					{
						if (A_0 != null && Enumerable.Any<string>(A_0))
						{
							using (List<string>.Enumerator enumerator2 = A_0.GetEnumerator())
							{
								while (enumerator2.MoveNext())
								{
									string text2 = enumerator2.Current;
									if (text.ToUpperInvariant().Contains(text2.ToUpperInvariant()) && !list2.Contains(text))
									{
										list2.Add(text);
									}
								}
								continue;
							}
						}
						list2.Add(text);
					}
				}
				return list2;
			}
			return list;
		}
		return list;
	}

	// Token: 0x06003231 RID: 12849 RVA: 0x001353E0 File Offset: 0x001335E0
	public static List<string> b(List<string> A_0 = null, string A_1 = "X")
	{
		List<string> list = new List<string>
		{
			"xpbl_ww_smallPirateBoatX1",
			"xpbl_ww_smallPirateBoatX2",
			"xpbl_ww_smallPirateBoatY1",
			"xpbl_ww_smallPirateBoatY2"
		};
		List<string> list2 = new List<string>();
		if (A_1 == "X" || A_1 == "Y")
		{
			using (List<string>.Enumerator enumerator = list.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					string text = enumerator.Current;
					if (text.Substring(text.Length - 2, 1) == A_1)
					{
						if (A_0 != null && Enumerable.Any<string>(A_0))
						{
							using (List<string>.Enumerator enumerator2 = A_0.GetEnumerator())
							{
								while (enumerator2.MoveNext())
								{
									string text2 = enumerator2.Current;
									if (text.ToUpperInvariant().Contains(text2.ToUpperInvariant()) && !list2.Contains(text))
									{
										list2.Add(text);
									}
								}
								continue;
							}
						}
						list2.Add(text);
					}
				}
				return list2;
			}
			return list;
		}
		return list;
	}

	// Token: 0x06003232 RID: 12850 RVA: 0x00135528 File Offset: 0x00133728
	public static List<string> a(List<string> A_0 = null, string A_1 = "X")
	{
		List<string> list = new List<string>
		{
			"xpbl_ww_smallprcBoatY1",
			"xpbl_ww_smallprcBoatY2"
		};
		List<string> list2 = new List<string>();
		if (A_1 == "X" || A_1 == "Y")
		{
			using (List<string>.Enumerator enumerator = list.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					string text = enumerator.Current;
					if (text.Substring(text.Length - 2, 1) == A_1 && (dk2.b("xpbl") || !text.ToLowerInvariant().StartsWith("xpbl")))
					{
						if (A_0 != null && Enumerable.Any<string>(A_0))
						{
							using (List<string>.Enumerator enumerator2 = A_0.GetEnumerator())
							{
								while (enumerator2.MoveNext())
								{
									string text2 = enumerator2.Current;
									if (text.ToUpperInvariant().Contains(text2.ToUpperInvariant()) && !list2.Contains(text))
									{
										list2.Add(text);
									}
								}
								continue;
							}
						}
						list2.Add(text);
					}
				}
				return list2;
			}
			return list;
		}
		return list;
	}

	// Token: 0x06003233 RID: 12851 RVA: 0x0013567C File Offset: 0x0013387C
	public static dcw a(dcw A_0 = null, List<xs> A_1 = null)
	{
		dcw dcw;
		if (A_0 != null)
		{
			dcw = A_0;
		}
		else
		{
			dcw = new dcw();
		}
		List<xs> list = new List<xs>();
		if (A_1 == null)
		{
			List<int> list2 = new List<int>
			{
				1,
				2,
				3,
				4,
				5,
				6,
				7,
				8,
				9,
				12,
				19,
				20,
				21,
				30
			};
			for (int i = 0; i <= cuo.a.Next(1, 4); i++)
			{
				List<xs> list3 = list;
				xs xs = new xs();
				df8 df = new df8((ItemRange)cuo.a.Next(401, 500));
				df.nc(15);
				df.na(10);
				xs.Generator = df;
				xs.Amount = 1;
				xs.Chance = 0.9f;
				list3.Add(xs);
			}
			List<xs> list4 = list;
			xs xs2 = new xs();
			df8 df2 = new df8((ItemRange)list2[cuo.a.Next(0, list2.Count)]);
			df2.nc(18);
			df2.na(12);
			xs2.Generator = df2;
			xs2.Amount = 4;
			xs2.Chance = 0.6f;
			list4.Add(xs2);
			List<xs> list5 = list;
			xs xs3 = new xs();
			df8 df3 = new df8(ItemRange.EnergyCells);
			df3.nc(16);
			df3.na(14);
			xs3.Generator = df3;
			xs3.Amount = 2;
			xs3.Chance = 0.3f;
			list5.Add(xs3);
			List<xs> list6 = list;
			xs xs4 = new xs();
			df8 df4 = new df8(ItemRange.Food_Canned);
			df4.nc(12);
			df4.na(1);
			xs4.Generator = df4;
			xs4.Amount = 3;
			xs4.Chance = 0.2f;
			list6.Add(xs4);
			foreach (xs xs5 in list)
			{
				List<bmd> list7 = xs5.a(null, null, null, null);
				if (list7 != null && Enumerable.Any<bmd>(list7))
				{
					dcw.z2().AddRange(Enumerable.Select<bmd, coh>(Enumerable.Where<bmd>(list7, new Func<bmd, bool>(d06.a.a.b)), new Func<bmd, coh>(d06.a.a.a)));
				}
			}
		}
		return dcw;
	}

	// Token: 0x06003234 RID: 12852 RVA: 0x00135928 File Offset: 0x00133B28
	public static bcx a(bcx A_0)
	{
		if (A_0 != null)
		{
			if (cuo.a.Next(0, 101) <= 30)
			{
				if (cuo.a.Next(0, 101) < 50)
				{
					A_0.o()["engine"] = null;
				}
				else
				{
					A_0.o()["engine"] = new agt(ez2.CreateDefinitonProvider<eqg>(c8x.an));
				}
			}
			if (cuo.a.Next(0, 101) <= 30)
			{
				if (cuo.a.Next(0, 101) < 50)
				{
					A_0.o()["battery"] = null;
				}
				else
				{
					A_0.o()["battery"] = new agt(ez2.CreateDefinitonProvider<esd>(c8x.aq));
				}
			}
			if (cuo.a.Next(0, 101) <= 30)
			{
				A_0.o()["suspension"] = null;
			}
			A_0.k();
			A_0.b((double)cuo.a.Next(50, A_0.v() + 1));
			if (A_0.o().ContainsKey("battery"))
			{
				agt agt = A_0.o()["battery"];
				if (agt != null)
				{
					esd esd = agt.fu() as esd;
					if (esd != null && esd.ba() != null)
					{
						agt.Battery = (double)cuo.a.Next(0, esd.ba().Value + 1);
					}
				}
			}
			int num = cuo.a.Next(0, 11) * 5;
			if (cuo.a.Next(0, 101) <= 15)
			{
				A_0.f(0);
			}
			else
			{
				A_0.f(30 + num);
				A_0.a(d06.a(null, null));
			}
			if (cuo.a.Next(0, 101) < 20)
			{
				A_0.a(true);
			}
			else
			{
				A_0.c(50 + num);
			}
			A_0.k();
		}
		return A_0;
	}

	// Token: 0x06003235 RID: 12853 RVA: 0x00135B28 File Offset: 0x00133D28
	public static c5x a(c5x A_0, bcx A_1)
	{
		if (!string.IsNullOrEmpty(A_1.f()) || A_1.z() > 0)
		{
			d2b d2b = new d2b(A_0);
			d2b.b(A_1.f());
			d2b.a(A_1.z());
			d2b.d(true);
			d2b.e(true);
			d2b.a(true);
			d2b.a(LockType.Mechanical);
			A_0.SetAspect<d2b>(d2b);
		}
		return A_0;
	}

	// Token: 0x06003236 RID: 12854 RVA: 0x00135B94 File Offset: 0x00133D94
	public static c5x a(csd A_0, string A_1, int A_2, string A_3 = null, bool A_4 = false, bool A_5 = false)
	{
		c5x c5x = null;
		gx gx = new gx();
		string text = null;
		string a_ = null;
		string a_2 = null;
		string text2 = null;
		bool a_3 = true;
		bool flag = false;
		if (A_1 == asp.ar)
		{
			text = "Waterway_Freelooters";
			a_ = "Флибустьер";
			a_2 = "";
		}
		else if (A_1 == asp.fi)
		{
			text = "Waterway_Security";
			if (A_3 != null)
			{
				a_ = A_3;
			}
			else
			{
				a_ = "Моряк";
			}
			a_2 = "";
			text2 = "randomEvents\\xpbl\\cvw_sailors";
		}
		else if (A_1 == asp.fw)
		{
			text = "Pirates";
			a_3 = false;
			text2 = "support\\xpbl\\pir_raiders";
		}
		if (A_0.Name.Contains("_guard"))
		{
			if (A_1 == asp.fw)
			{
				if (A_0.Name.Contains("Melee"))
				{
					c5x = vq.a(d06.a(false), A_0, false);
				}
				else
				{
					c5x = vq.a(d06.a(true), A_0, false);
				}
			}
			else
			{
				c5x = gx.a(A_0, new int?(A_2), text, a_, A_1, a_2, text2, a_3, null, true);
			}
		}
		else if (A_0.Name.Contains("_cap"))
		{
			string text3 = "Капитан";
			if (A_1 == asp.fi && A_0.Name.Contains("small"))
			{
				text3 = "Шкипер";
			}
			else if (A_1 == asp.ar)
			{
				text3 = "Глава флибустьеров";
			}
			else if (text == "Pirates")
			{
				text3 = "Штурман";
			}
			if (text == "Pirates")
			{
				c5x = vq.a(d06.a(true), A_0, false);
				if (c5x != null)
				{
					c5x.q(text3);
				}
			}
			else
			{
				c5x = gx.a(A_0, new int?(A_2 + 5), text, text3, A_1, a_2, text2, a_3, null, false);
			}
		}
		else if (A_0.Name.Contains("_mcnt"))
		{
			if (A_1 != asp.fi)
			{
				if (cuo.a.Next(0, 101) <= 30)
				{
					c5x = gx.a(A_0, new int?(A_2), text, a_, A_1, a_2, text2, a_3, null, false);
				}
			}
			else
			{
				c5x = vq.a("Creature\\Characters\\randomEvents\\xpbl\\cvw_cargoKeeper", A_0, false);
				if (c5x != null)
				{
					if (c5x.h.b != null)
					{
						c5x.h.b.a(gx.a(c5x.h.b.am(), null, null));
						if (c5x.h.b.am().Contains("_f"))
						{
							c5x.h.b.aa().Gender = Gender.Female;
						}
					}
					if (c5x.t.b != null)
					{
						c5x.t.b.y6()[ddq.ay] = new bt4(A_0.Name);
					}
					d06.a(c5x, true);
					flag = true;
				}
			}
		}
		if (c5x != null && c5x.h.b != null)
		{
			c5x.h.b.aa().HostilityBroadcastMode = c2n.c;
			if (text == "Pirates")
			{
				c5x.b("SurvivingSnitch");
				bn5 bn = c5x.GetAspect<j7>() as bn5;
				if (bn == null)
				{
					bn = new bn5(c5x);
					c5x.SetAspect<j7>(bn);
				}
				bn.a("speaker");
				bn.b(true);
				bn.b(text2);
				c5x.h.b.aa().FactionId = asp.fw;
			}
			if (A_5)
			{
				if (!Enumerable.Any<coh>(c5x.h.b.aa().Bag.b("food.mushroomBrew")))
				{
					c5x.h.b.aa().Bag.z3(new d48(ez2.CreateDefinitonProvider<cv9>("Consumables\\Food\\MushroomBrew"))
					{
						Stacks = cuo.a.Next(1, 3)
					}, true);
				}
				c5x.t.b.y6()[ddq.b3] = "food.mushroomBrew";
				c5x.t.b.y6()[ddq.b4] = cuo.a.Next(5, 15) * 100;
			}
		}
		if (A_4)
		{
			c5x.b("sailors_attacked");
		}
		if (flag)
		{
			c5x.b("cargokeeperPresent");
		}
		return c5x;
	}

	// Token: 0x06003237 RID: 12855 RVA: 0x00136028 File Offset: 0x00134228
	public static string a()
	{
		List<string> list = new List<string>
		{
			"Моряк",
			"Охранник",
			"Наёмник",
			"Матрос",
			"Наёмный убийца",
			"Член команды"
		};
		return list[cuo.a.Next(0, list.Count)];
	}

	// Token: 0x06003238 RID: 12856 RVA: 0x00136094 File Offset: 0x00134294
	public static c5x a(c5x A_0, bool A_1 = false)
	{
		dvp aspect = A_0.GetAspect<dvp>();
		if (aspect != null)
		{
			bool flag = false;
			DateTime t = new DateTime(DateTime.Now.Year, 7, 2);
			DateTime t2 = new DateTime(DateTime.Now.Year, 7, 4);
			if (DateTime.Today >= t && DateTime.Today <= t2 && cuo.a.Next(0, 101) <= 70)
			{
				aspect.b("Xpbl\\TravelingMerchants\\explosives");
				A_0.b("merchantType_explosives");
				return A_0;
			}
			if (A_1)
			{
				int num = cuo.a.Next(0, 101);
				if (num >= 40)
				{
					switch (cuo.a.Next(0, 4))
					{
					case 1:
						aspect.b("Xpbl\\TravelingMerchants\\fur");
						A_0.b("merchantType_fur");
						break;
					case 2:
						aspect.b("Xpbl\\TravelingMerchants\\vehicle");
						A_0.b("merchantType_vehicle");
						break;
					case 3:
						aspect.b("Xpbl\\TravelingMerchants\\food");
						A_0.b("merchantType_food");
						break;
					default:
						aspect.b("Xpbl\\TravelingMerchants\\industrial");
						A_0.b("merchantType_industrial");
						break;
					}
				}
				else
				{
					flag = true;
				}
			}
			else
			{
				flag = true;
			}
			if (flag)
			{
				switch (cuo.a.Next(0, 7))
				{
				case 1:
					aspect.b("Xpbl\\TravelingMerchants\\electronics");
					A_0.b("merchantType_electronics");
					break;
				case 2:
					aspect.b("Xpbl\\TravelingMerchants\\mechanical");
					A_0.b("merchantType_mechanical");
					break;
				case 3:
					aspect.b("Xpbl\\TravelingMerchants\\medicine");
					A_0.b("merchantType_medicine");
					break;
				case 4:
					aspect.b("Xpbl\\TravelingMerchants\\hunting");
					A_0.b("merchantType_hunting");
					break;
				case 5:
					aspect.b("Xpbl\\TravelingMerchants\\weapons");
					A_0.b("merchantType_weapons");
					break;
				case 6:
					aspect.b("Xpbl\\TravelingMerchants\\food");
					A_0.b("merchantType_food");
					break;
				default:
					aspect.b("Xpbl\\TravelingMerchants\\general");
					A_0.b("merchantType_general");
					break;
				}
			}
		}
		return A_0;
	}

	// Token: 0x06003239 RID: 12857 RVA: 0x001362D8 File Offset: 0x001344D8
	public static void b(c1a A_0, string A_1 = "N")
	{
		d60 d = A_0.a();
		if (d != null)
		{
			foreach (b0b b0b in d.ab4(new string[]
			{
				"RampS",
				"RampN",
				"RampE",
				"RampW"
			}))
			{
				c5x c5x = (c5x)b0b;
				if (c5x.a("Ramp" + A_1) && c5x.o.b != null)
				{
					float num = 0.1f;
					float num2 = 0f;
					float num3 = 0.1f;
					if (c5x.o.b.a == "Objects\\Vehicles\\ProtShipRamp")
					{
						if (c5x.o.b.b.X == 4)
						{
							c5x.o.b.b.X = 1;
						}
						else if (c5x.o.b.b.X == 5)
						{
							c5x.o.b.b.X = 0;
						}
						else if (c5x.o.b.b.X == 6)
						{
							c5x.o.b.b.X = 2;
						}
						else if (c5x.o.b.b.X >= 7)
						{
							c5x.o.b.b.X = 3;
						}
						num = 1f;
						num2 = 0.2f;
						num3 = 0.5f;
						if (c5x.ae != null)
						{
							c5x.ae = null;
						}
					}
					else
					{
						c5x.o.b.b.Y = 1;
					}
					if (A_1 == "N")
					{
						c5x.Location = new Vector3(c5x.Location.X, c5x.Location.Y - num, c5x.Location.Z + num2);
						c5x.Size = new Vector3(c5x.Size.X, num3, c5x.Size.Z);
					}
					else if (A_1 == "W")
					{
						c5x.Location = new Vector3(c5x.Location.X - num, c5x.Location.Y, c5x.Location.Z + num2);
						c5x.Size = new Vector3(num3, c5x.Size.Y, c5x.Size.Z);
					}
					c5x.IsFloor = true;
					c5x.VisualPriority = 1;
					c5x.TileFormationModifiers.s4(1);
					c5x.TileFormationModifiers.s3(7);
					c5x.z();
					c5x.ah();
				}
				e3l aspect = c5x.GetAspect<e3l>();
				if (aspect != null)
				{
					aspect.a.RemoveAll(new Predicate<string>(d06.a.a.a));
				}
			}
		}
	}

	// Token: 0x0600323A RID: 12858 RVA: 0x00136628 File Offset: 0x00134828
	public static void a(c1a A_0, string A_1)
	{
		d60 d = A_0.a();
		if (d != null)
		{
			foreach (b0b b0b in d.ab4(new string[]
			{
				"wwloot"
			}))
			{
				c5x c5x = (c5x)b0b;
				c3g aspect = c5x.GetAspect<c3g>();
				if (aspect != null)
				{
					aspect.d().Add(A_1);
					e3l aspect2 = c5x.GetAspect<e3l>();
					if (aspect2 != null)
					{
						aspect2.a.Remove("wwloot");
					}
				}
			}
		}
	}

	// Token: 0x0600323B RID: 12859 RVA: 0x001366D4 File Offset: 0x001348D4
	public static string a(bool A_0)
	{
		List<string> list = new List<string>
		{
			"creatures\\generichumans\\xpbl\\pirateMacheteer",
			"creatures\\generichumans\\xpbl\\pirateMacheteer",
			"creatures\\generichumans\\xpbl\\pirateSmasher"
		};
		List<string> list2 = new List<string>
		{
			"creatures\\generichumans\\xpbl\\pirateGunner",
			"creatures\\generichumans\\xpbl\\pirateGunner",
			"creatures\\generichumans\\xpbl\\pirateKnifeThrower",
			"creatures\\generichumans\\xpbl\\pirateShotgunner",
			"creatures\\generichumans\\xpbl\\pirateShotgunner",
			"creatures\\generichumans\\xpbl\\pirateHeavyGunner",
			"creatures\\generichumans\\xpbl\\pirateHeavyGunner",
			"creatures\\generichumans\\xpbl\\pirateSMGunner",
			"creatures\\generichumans\\xpbl\\pirateSMGunner",
			"creatures\\generichumans\\xpbl\\pirateSniper",
			"creatures\\generichumans\\xpbl\\pirateTrapper",
			"creatures\\generichumans\\xpbl\\pirateTrapper",
			"creatures\\generichumans\\xpbl\\pirateBomber"
		};
		string result;
		if (A_0)
		{
			result = list2[cuo.a.Next(0, list2.Count)];
		}
		else
		{
			result = list[cuo.a.Next(0, list.Count)];
		}
		return result;
	}

	// Token: 0x020007D4 RID: 2004
	[CompilerGenerated]
	[Serializable]
	private sealed class a
	{
		// Token: 0x0600323E RID: 12862 RVA: 0x001367F0 File Offset: 0x001349F0
		internal bool b(bmd A_0)
		{
			return A_0.Item != null;
		}

		// Token: 0x0600323F RID: 12863 RVA: 0x001367FC File Offset: 0x001349FC
		internal coh a(bmd A_0)
		{
			return A_0.Item;
		}

		// Token: 0x06003240 RID: 12864 RVA: 0x00136804 File Offset: 0x00134A04
		internal bool a(string A_0)
		{
			return A_0.Contains("Ramp");
		}

		// Token: 0x04001AE8 RID: 6888
		public static readonly d06.a a = new d06.a();

		// Token: 0x04001AE9 RID: 6889
		public static Func<bmd, bool> b;

		// Token: 0x04001AEA RID: 6890
		public static Func<bmd, coh> c;

		// Token: 0x04001AEB RID: 6891
		public static Predicate<string> d;
	}
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;

// Token: 0x0200054B RID: 1355
public static class b2p
{
	// Token: 0x060022A7 RID: 8871 RVA: 0x000B6B78 File Offset: 0x000B4D78
	public static void f(cyt A_0, c1a A_1)
	{
		if (!b2p.a(A_0) && b2p.c(A_0) == A_1.y8())
		{
			b2p.c(A_0, A_1);
		}
	}

	// Token: 0x060022A8 RID: 8872 RVA: 0x000B6BA4 File Offset: 0x000B4DA4
	public static void e(cyt A_0, c1a A_1)
	{
		if (!b2p.a(A_0) && A_0.r().GetClassPropertyValue<string>("FerryCurrentLocation") == A_1.y8())
		{
			b2p.b(A_0, A_1);
		}
	}

	// Token: 0x060022A9 RID: 8873 RVA: 0x000B6BD8 File Offset: 0x000B4DD8
	public static string c(cyt A_0)
	{
		List<KeyValuePair<string, int>> list = b2p.b(A_0);
		if (list.Count != 0)
		{
			int num = list.Count * 20;
			int num2 = (int)A_0.o().TotalMinutes % num;
			int num3 = 0;
			foreach (KeyValuePair<string, int> keyValuePair in list)
			{
				num3 += 20;
				if (num2 < num3)
				{
					b2p.a(A_0, keyValuePair.Value - 1);
					return keyValuePair.Key;
				}
			}
		}
		return null;
	}

	// Token: 0x060022AA RID: 8874 RVA: 0x000B6C88 File Offset: 0x000B4E88
	public static List<KeyValuePair<string, int>> b(cyt A_0)
	{
		List<KeyValuePair<string, int>> list = new List<KeyValuePair<string, int>>();
		if (A_0.r().GetPrimitivePropertyValue<bool>("PlayerMutantWentToMutieRefuge", new bool?(false)).Value)
		{
			list.Add(new KeyValuePair<string, int>("xpbl_i8", 1));
		}
		else
		{
			list.Add(new KeyValuePair<string, int>("xpbl_b6", 1));
			list.Add(new KeyValuePair<string, int>("xpbl_g1", 2));
			list.Add(new KeyValuePair<string, int>("xpbl_i8", 3));
			list.Add(new KeyValuePair<string, int>("xpbl_j11", 4));
		}
		return list;
	}

	// Token: 0x060022AB RID: 8875 RVA: 0x000B6D1C File Offset: 0x000B4F1C
	public static void d(cyt A_0, c1a A_1)
	{
		if (A_1 != null)
		{
			csd csd = A_1.g("global:xpbl_todd");
			if (csd != null)
			{
				c5x c5x = vq.a("Creature\\Characters\\xpbl\\Todd", csd, false);
				if (c5x != null)
				{
					amc aspect = c5x.GetAspect<amc>();
					if (aspect != null)
					{
						aspect.aa().FactionId = asp.gc;
					}
					A_0.r()["FerryToddSpawned"] = true;
				}
			}
		}
	}

	// Token: 0x060022AC RID: 8876 RVA: 0x000B6D88 File Offset: 0x000B4F88
	private static bool a(cyt A_0)
	{
		return A_0.r().GetPrimitivePropertyValue<bool>("npc_xpbl_ferryman_died", new bool?(false)).Value;
	}

	// Token: 0x060022AD RID: 8877 RVA: 0x000B6DB4 File Offset: 0x000B4FB4
	private static void c(cyt A_0, c1a A_1)
	{
		A_0.r()["FerryFullyDiscovered"] = false;
		csd csd = A_1.g("FerryPlacement");
		if (csd != null && csd.Area != null)
		{
			bool flag;
			c1a a_ = b2p.a(A_0, out flag);
			if (flag)
			{
				acu.a(a_);
			}
			bool value = A_0.r().GetPrimitivePropertyValue<bool>("FerryPlaced:" + A_1.y8(), new bool?(false)).Value;
			bool value2 = A_0.r().GetPrimitivePropertyValue<bool>("npc_xpbl_ferryman_movingOut", new bool?(false)).Value;
			TimeSpan? primitivePropertyValue = A_0.r().GetPrimitivePropertyValue<TimeSpan>("npc_xpbl_ferryman_movingOutDelay", null);
			if (value2)
			{
				string classPropertyValue = A_0.r().GetClassPropertyValue<string>("FerryCurrentLocation");
				if (classPropertyValue != null && (classPropertyValue != A_1.y8() || primitivePropertyValue == null || (primitivePropertyValue != null && primitivePropertyValue <= A_0.o())))
				{
					A_0.r()["npc_xpbl_ferryman_movingOut"] = false;
				}
			}
			b2p.b(a_, csd.Area, csd.Location);
			b2p.a(a_, csd.Area, csd.Location, !value, flag);
			A_0.r()["FerryPlaced:" + A_1.y8()] = true;
			A_0.r()["FerryCurrentLocation"] = A_1.y8();
			string classPropertyValue2 = A_0.r().GetClassPropertyValue<string>("npc_xpbl_as_todd_finalDestination");
			if (classPropertyValue2 != null && classPropertyValue2 == "ferryman")
			{
				if (!A_0.r().GetPrimitivePropertyValue<bool>("FerryToddSpawned", new bool?(false)).Value)
				{
					b2p.d(A_0, A_1);
				}
				if (!A_0.r().GetPrimitivePropertyValue<bool>("npc_xpbl_ferryman_canAskAboutTodd", new bool?(false)).Value)
				{
					A_0.r()["npc_xpbl_ferryman_canAskAboutTodd"] = true;
				}
			}
			b2p.a(a_);
			b2p.a(A_0, A_1);
			new dvn(A_0.c().b(), "xpbl_Ferryman").ym(null, null, null);
		}
	}

	// Token: 0x060022AE RID: 8878 RVA: 0x000B7018 File Offset: 0x000B5218
	private static void b(cyt A_0, c1a A_1)
	{
		new dvn(A_0.c().b(), null).ym(null, null, null);
		csd csd = A_1.g("FerryPlacement");
		if (csd != null && csd.Area != null)
		{
			bool flag;
			c1a a_ = b2p.a(A_0, out flag);
			b2p.a(a_, csd.Area, csd.Location);
			b2p.a(a_);
		}
	}

	// Token: 0x060022AF RID: 8879 RVA: 0x000B707C File Offset: 0x000B527C
	private static void a(c1a A_0, aud A_1, Vector3 A_2, bool A_3, bool A_4)
	{
		c1a c1a = A_1.Zone;
		new List<ah7>();
		foreach (ah7 a_ in Enumerable.ToList<ah7>(A_0.LanternDefinitions))
		{
			A_0.b(a_);
		}
		foreach (csd csd in Enumerable.ToList<csd>(A_0.Waypoints))
		{
			A_0.b(csd);
			csd.Location += A_2;
			csd.AreaName = A_1.y8();
			csd.Layer = 1;
			c1a.a(csd);
		}
		if (A_1 != null)
		{
			aud aud = Enumerable.First<aud>(A_0.Areas);
			b2p.a item = new b2p.a();
			bool flag = A_1.y8() != "xpbl_i8";
			foreach (b0b b0b in Enumerable.ToList<b0b>(aud.Entities))
			{
				c5x c5x = (c5x)b0b;
				if (!flag || !c5x.a("ferryCraneMetaTile"))
				{
					b0b.an();
					b0b.Layer = 1;
					Vector3 a_2;
					if (A_2 != Vector3.Zero)
					{
						a_2 = new Vector3(b0b.Location.X + A_2.X, b0b.Location.Y + A_2.Y, b0b.Location.Z);
					}
					else
					{
						a_2 = b0b.Location;
					}
					b0b.Location = a_2;
					A_1.a(b0b);
					if (A_1.Initialized)
					{
						b0b.bc(true);
					}
					if (A_4)
					{
						c5x c5x2 = b0b as c5x;
						c5x2.b("ferryPart");
						eyo eyo = new eyo(c5x2);
						eyo.d().Add(item);
						c5x2.SetAspect<eyo>(eyo);
					}
					else
					{
						eyo aspect = b0b.GetAspect<eyo>();
						if (aspect != null)
						{
							aspect.a(false);
						}
					}
					if (c5x.a("ferryRamp"))
					{
						bool flag2 = A_1.y8() != "xpbl_i8";
						c5x.ae = (flag2 ? null : new float?(0f));
						if (flag2)
						{
							c5x.TileFormationModifiers = new bjp(new byte[]
							{
								7
							});
						}
						else
						{
							c5x.TileFormationModifiers = new bjp();
						}
						c5x.z();
					}
					if (c5x.a("ferryBackWater"))
					{
						bool flag3 = A_1.y8() == "xpbl_i8";
						c5x.ae = (flag3 ? null : new float?(0f));
					}
					if (c5x.a("ferryCrane"))
					{
						c5x.o.b.a = "Objects\\LargeMachines\\Ferry\\xpbl_FerryX_CraneSmall" + (flag ? "_up" : "");
					}
				}
			}
			foreach (ya ya in Enumerable.ToList<ya>(aud.Triggers))
			{
				if (!(ya is et4))
				{
					ya.o();
					ya.Layer = 1;
					if (A_2 != Vector3.Zero)
					{
						ya.Location = d05.a(ya.Location, A_2.a(), false);
					}
					l2 l = ya as l2;
					if (l != null)
					{
						l.jl(A_1);
					}
					A_1.b(ya);
				}
			}
		}
	}

	// Token: 0x060022B0 RID: 8880 RVA: 0x000B74CC File Offset: 0x000B56CC
	private static void b(c1a A_0, aud A_1, Vector3 A_2)
	{
		csd csd = A_1.Zone.g("FerryDump");
		if (csd != null && csd.Area == A_1)
		{
			int a_ = (int)csd.Location.X;
			int a_2 = (int)csd.Location.Y;
			aud aud = Enumerable.First<aud>(A_0.Areas);
			aud.l();
			HashSet<Point> hashSet = new HashSet<Point>();
			foreach (ya ya in aud.Triggers)
			{
				if (ya is et4)
				{
					for (int i = ya.Location.X; i < ya.Location.X + ya.Size.c; i++)
					{
						for (int j = ya.Location.Y; j < ya.Location.Y + ya.Size.d; j++)
						{
							hashSet.Add(new Point(i, j));
						}
					}
				}
			}
			for (int k = 0; k < aud.Size.d; k++)
			{
				for (int l = 0; l < aud.Size.c; l++)
				{
					ak1 ak = aud.b(l, k);
					bool flag = true;
					if (hashSet.Contains(ak.Location))
					{
						flag = false;
					}
					if (flag)
					{
						Point a_3 = new Point((int)(A_2.X + (float)l), (int)(A_2.Y + (float)k));
						ak1 ak2 = A_1.a(a_3);
						ak1 ak3 = A_1.b(a_, a_2);
						while (aw1.a(ak3 = A_1.b(a_, a_2), false, null, l9.b))
						{
							if (!b2p.a(A_1, csd, ref a_, ref a_2))
							{
								return;
							}
						}
						if (ak2 != null && ak3 != null)
						{
							using (List<b0b>.Enumerator enumerator2 = Enumerable.ToList<b0b>(ak2.Entities).GetEnumerator())
							{
								while (enumerator2.MoveNext())
								{
									b0b b0b = enumerator2.Current;
									c5x c5x = (c5x)b0b;
									if (c5x.Layer == aju.x && (c5x.h.b != null || c5x.s.b is c7j || c5x.s.b is wv))
									{
										c5x.Location = ak3.Location.a();
										c5x.ah();
									}
								}
								goto IL_27A;
							}
							goto IL_269;
						}
						IL_27A:
						if (!aw1.a(A_1.b(a_, a_2), false, null, l9.b))
						{
							goto IL_28F;
						}
						IL_269:
						if (!b2p.a(A_1, csd, ref a_, ref a_2))
						{
							return;
						}
						goto IL_27A;
					}
					IL_28F:;
				}
			}
		}
	}

	// Token: 0x060022B1 RID: 8881 RVA: 0x000B77B4 File Offset: 0x000B59B4
	private static bool a(aud A_0, csd A_1, ref int A_2, ref int A_3)
	{
		int num = A_2 + 1;
		A_2 = num;
		if (num >= A_0.Size.c)
		{
			A_2 = (int)A_1.Location.X;
			num = A_3 + 1;
			A_3 = num;
			if (num >= A_0.Size.d)
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x060022B2 RID: 8882 RVA: 0x000B7804 File Offset: 0x000B5A04
	private static void a(c1a A_0, aud A_1, Vector3 A_2)
	{
		aud aud = Enumerable.First<aud>(A_0.Areas);
		aud.l();
		HashSet<Point> hashSet = new HashSet<Point>();
		foreach (ya ya in aud.Triggers)
		{
			if (ya is et4)
			{
				for (int i = ya.Location.X; i < ya.Location.X + ya.Size.c; i++)
				{
					for (int j = ya.Location.Y; j < ya.Location.Y + ya.Size.d; j++)
					{
						hashSet.Add(new Point(i, j));
					}
				}
			}
		}
		HashSet<ya> hashSet2 = new HashSet<ya>();
		for (int k = 0; k < aud.Size.d; k++)
		{
			for (int l = 0; l < aud.Size.c; l++)
			{
				Point a_ = new Point((int)(A_2.X + (float)l), (int)(A_2.Y + (float)k));
				ak1 ak = A_1.a(a_);
				if (ak != null)
				{
					bool flag = true;
					ak1 ak2 = aud.b(l, k);
					if (ak2 != null && hashSet.Contains(ak2.Location))
					{
						flag = false;
					}
					if (flag)
					{
						foreach (bqt bqt in ak.TriggerProxies)
						{
							if (bqt.Trigger != null && bqt.Trigger.Layer == 1)
							{
								hashSet2.Add(bqt.Trigger);
							}
						}
					}
					foreach (b0b b0b in Enumerable.ToList<b0b>(ak.Entities))
					{
						c5x c5x = (c5x)b0b;
						if (c5x.Layer == 1 && (flag || c5x.a("ferryPart")))
						{
							if (c5x.y8() == "Пси-двойник" && !c5x.IsPlayer)
							{
								c5x.w();
								c5x.an();
							}
							else
							{
								c5x.an();
								c5x.Location -= A_2;
								aud.a(c5x);
							}
						}
					}
				}
			}
		}
		foreach (ya ya2 in hashSet2)
		{
			ya2.o();
			ya2.Location = d05.a(ya2.Location, A_2.a(), true);
			aud.b(ya2);
		}
		foreach (csd csd in Enumerable.ToList<csd>(A_1.Zone.Waypoints))
		{
			if (csd.Layer == 1 && csd.Area == A_1 && csd.Location.X >= A_2.X && csd.Location.Y >= A_2.Y && csd.Location.X < A_2.X + (float)aud.Size.c && csd.Location.Y < A_2.Y + (float)aud.Size.d)
			{
				A_1.Zone.b(csd);
				csd.Location -= A_2;
				csd.AreaName = aud.y8();
				A_0.a(csd);
			}
		}
	}

	// Token: 0x060022B3 RID: 8883 RVA: 0x000B7C5C File Offset: 0x000B5E5C
	private static c1a a(cyt A_0, out bool A_1)
	{
		string text = Path.Combine(d5x.x, "xpbl_ferry.uz").ToLowerInvariant();
		if (!bmg.b(text))
		{
			string a_ = Path.Combine(d5x.o(), "xpbl_ferry.uz");
			bmg.a(text, a_);
			A_1 = true;
		}
		else
		{
			A_1 = false;
		}
		return bmg.b().GetItemCompressed<c1a>(text, true);
	}

	// Token: 0x060022B4 RID: 8884 RVA: 0x000B7CB8 File Offset: 0x000B5EB8
	private static void a(c1a A_0)
	{
		string name = Path.Combine(d5x.x, "xpbl_ferry.uz").ToLowerInvariant();
		bmg.b().PutItemCompressed<c1a>(name, A_0, true);
	}

	// Token: 0x060022B5 RID: 8885 RVA: 0x000B7CE8 File Offset: 0x000B5EE8
	private static void a(cyt A_0, c1a A_1)
	{
		bool value = A_0.r().GetPrimitivePropertyValue<bool>("faction_xpbl_blackLakeMuties_eradicated", new bool?(false)).Value;
		bool value2 = A_0.r().GetPrimitivePropertyValue<bool>("faction_xpbl_pirates_defeated", new bool?(false)).Value;
		bool value3 = A_0.r().GetPrimitivePropertyValue<bool>("loc_xpbl_j12_sormirbarenCleared", new bool?(false)).Value;
		string text = "xpbl_b6";
		string text2 = "xpbl_g1";
		string text3 = "xpbl_j11";
		string text4 = "xpbl_i8";
		string text5 = "transit";
		if (A_1.y8() == text && !value)
		{
			text5 = text;
		}
		else if (A_1.y8() == text2 && !value2)
		{
			text5 = text2;
		}
		else if (A_1.y8() == text3 && !value3)
		{
			text5 = text3;
		}
		else if (A_1.y8() == text4)
		{
			text5 = text4;
		}
		A_0.r()["npc_xpbl_ferryman_mercantileCode"] = text5;
		eiw eiw = new eiw();
		eiw.a(text5);
		eiw.a(new Guid?(new Guid("7bb4a093-c4a3-4201-95af-5a11007a64da")));
		eiw.ym(A_0.v().b(), null, null);
	}

	// Token: 0x060022B6 RID: 8886 RVA: 0x000B7E34 File Offset: 0x000B6034
	private static void a(cyt A_0, int A_1)
	{
		List<string> list = new List<string>
		{
			"убежище мутантов",
			"порт Чето",
			"северо-восточные воды",
			"соурмирбэрен деревня гейзеров"
		};
		A_0.r()["npc_xpbl_ferryman_currentLocation"] = list[A_1];
		if (A_1 + 1 >= list.Count)
		{
			A_0.r()["npc_xpbl_ferryman_firstNextLocation"] = list[A_1 - list.Count + 1];
		}
		else
		{
			A_0.r()["npc_xpbl_ferryman_firstNextLocation"] = list[A_1 + 1];
		}
		if (A_1 + 2 >= list.Count)
		{
			A_0.r()["npc_xpbl_ferryman_secondNextLocation"] = list[A_1 - list.Count + 2];
			return;
		}
		A_0.r()["npc_xpbl_ferryman_secondNextLocation"] = list[A_1 + 2];
	}

	// Token: 0x0200054C RID: 1356
	[eiz("FLDFJ")]
	[Serializable]
	private sealed class a : cze, ISerializable
	{
		// Token: 0x060022B7 RID: 8887 RVA: 0x000B7F20 File Offset: 0x000B6120
		private a(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
		{
		}

		// Token: 0x060022B8 RID: 8888 RVA: 0x000B7F2C File Offset: 0x000B612C
		public a()
		{
		}

		// Token: 0x060022B9 RID: 8889 RVA: 0x000B7F34 File Offset: 0x000B6134
		public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
		{
			cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
			if (serviceOrThrow.aqu() != null && serviceOrThrow.aqw() != null && !serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("FerryFullyDiscovered", new bool?(false)).Value)
			{
				serviceOrThrow.aqu().r()["FerryFullyDiscovered"] = true;
				List<b0b> list = serviceOrThrow.aqw().GetAddon<d60>().ab4(new string[]
				{
					"ferryPart"
				});
				if (list != null)
				{
					foreach (b0b b0b in list)
					{
						foreach (ak1 ak in b0b.l)
						{
							ak.a(dm9.a);
						}
					}
				}
			}
		}
	}
}

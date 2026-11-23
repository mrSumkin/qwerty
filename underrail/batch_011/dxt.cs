using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;
using Ouroboros.Playfield.References;
using TimelapseVertigo.Playfield.CustomLogic.Data;

// Token: 0x02000926 RID: 2342
[eiz("CCPLH")]
[Serializable]
public sealed class dxt : bdw, ISerializable
{
	// Token: 0x06003987 RID: 14727 RVA: 0x00153B7C File Offset: 0x00151D7C
	private dxt(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x06003988 RID: 14728 RVA: 0x00153B84 File Offset: 0x00151D84
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x06003989 RID: 14729 RVA: 0x00153B88 File Offset: 0x00151D88
	public dxt()
	{
	}

	// Token: 0x0600398A RID: 14730 RVA: 0x00153B90 File Offset: 0x00151D90
	public void av(c1a A_0, cyt A_1)
	{
		if (A_0 != null)
		{
			aud aud = A_0.n("cc_ph1");
			if (aud != null)
			{
				dxt.a(A_1, aud, "64d953dd-8266-413d-b9b9-058116461071", "c50c6a64-80fb-4c17-aadc-b7300896863e");
				if (!A_1.r().GetPrimitivePropertyValue<bool>("cc_ph_importedDebris", new bool?(false)).Value)
				{
					doq doq = doq.a(Path.Combine(d5x.q(), "cc_ph_l2") + ".uzl");
					foreach (cpe cpe in doq.e())
					{
						foreach (b0b b0b in cpe.Entities)
						{
							((c5x)b0b).b("debris");
						}
					}
					A_0.a(doq, 1, null);
					A_1.r()["cc_ph_importedDebris"] = true;
				}
				if (A_1.r().GetPrimitivePropertyValue<bool>("cc_ph_removedGraffiti", new bool?(false)).Value)
				{
					c5x c5x = new ar7(new Guid("fd624637-5683-4ab1-8ee1-204ac0d2fda5"), aud).ao() as c5x;
					c5x c5x2 = new ar7(new Guid("6ba32e92-814d-4cc3-828b-5c329a56bdce"), aud).ao() as c5x;
					foreach (c5x c5x3 in new c5x[]
					{
						c5x,
						c5x2
					})
					{
						if (c5x3 != null)
						{
							c5x3.w();
							c5x3.an();
						}
					}
				}
				doq a_ = doq.a(Path.Combine(d5x.q(), "cc_ph_l3") + ".uzl");
				Dictionary<PlayerHouseElement, string> dictionary = d39.a(A_1, null);
				Dictionary<PlayerHouseElement, string> dictionary2 = d39.a(A_1, "_previous");
				foreach (KeyValuePair<PlayerHouseElement, string> keyValuePair in dictionary)
				{
					string text = null;
					if (dictionary2.ContainsKey(keyValuePair.Key))
					{
						text = dictionary2[keyValuePair.Key];
					}
					if (text != keyValuePair.Value)
					{
						this.a(A_0, a_, keyValuePair.Key, text, keyValuePair.Value);
						dictionary2[keyValuePair.Key] = keyValuePair.Value;
					}
				}
			}
			this.a(A_0);
			this.a(A_1, A_0);
		}
	}

	// Token: 0x0600398B RID: 14731 RVA: 0x00153E48 File Offset: 0x00152048
	public static void a(cyt A_0, aud A_1, string A_2, string A_3)
	{
		c5x c5x = new ar7(new Guid(A_2), A_1).ao() as c5x;
		c5x c5x2 = new ar7(new Guid(A_3), A_1).ao() as c5x;
		if (c5x != null && c5x2 != null)
		{
			Dictionary<string, c5x> dictionary = new Dictionary<string, c5x>();
			dictionary["left"] = c5x;
			dictionary["right"] = c5x2;
			bool value = A_0.r().GetPrimitivePropertyValue<bool>("cc_ph_entranceDoor_opened", new bool?(false)).Value;
			bool value2 = A_0.r().GetPrimitivePropertyValue<bool>("cc_ph_entranceDoor_unlocked", new bool?(false)).Value;
			foreach (KeyValuePair<string, c5x> keyValuePair in dictionary)
			{
				cnb cnb = keyValuePair.Value.GetAspect<bim>() as cnb;
				d2b aspect = keyValuePair.Value.GetAspect<d2b>();
				if (cnb != null)
				{
					cnb.d(value);
				}
				if (aspect != null)
				{
					aspect.e(!value2);
				}
			}
		}
	}

	// Token: 0x0600398C RID: 14732 RVA: 0x00153F70 File Offset: 0x00152170
	private void a(c1a A_0, doq A_1, PlayerHouseElement A_2, string A_3, string A_4)
	{
		aud a_ = A_0.n("cc_ph1");
		d60 d = A_0.a();
		if (d != null)
		{
			List<b0b> list = d.ab4(new string[]
			{
				A_3
			});
			c7j c7j = new EntityAspectReference<c7j, bim>(A_0.n("cc_ph1"), new Guid("89c5fae5-d45d-4418-afd1-dbb087584548")).ao();
			foreach (b0b b0b in list)
			{
				c5x c5x = (c5x)b0b;
				c7j c7j2 = c5x.s.b as c7j;
				if (c7j2 != null && c7j != null)
				{
					foreach (coh a_2 in c7j2.ItemContainer.z2())
					{
						c7j.ItemContainer.z3(a_2, true);
					}
					c7j2.ItemContainer.z7();
				}
				c5x.w();
				c5x.an();
			}
			if (!string.IsNullOrEmpty(A_4))
			{
				foreach (cpe cpe in A_1.e())
				{
					aud aud = A_0.d(cpe.AreaId);
					if (aud != null)
					{
						foreach (b0b b0b2 in cpe.Entities)
						{
							c5x c5x2 = (c5x)b0b2;
							if (c5x2.a(A_4))
							{
								c5x2.Layer = aju.x;
								aud.a(c5x2);
								e3l aspect = c5x2.GetAspect<e3l>();
								if (aspect != null)
								{
									foreach (string text in aspect.a)
									{
										if (text.StartsWith("addLantern:", StringComparison.OrdinalIgnoreCase) && text.Length > "addLantern".Length)
										{
											string text2 = text.Substring("addLantern:".Length);
											if (!string.IsNullOrWhiteSpace(text2))
											{
												ah7 ah = A_0.i(text2);
												if (ah != null)
												{
													ah.g().be(c5x2);
												}
											}
										}
									}
								}
								if (aud.Initialized)
								{
									c5x2.bc(true);
								}
							}
						}
					}
				}
			}
		}
		if (A_4 == "cleared")
		{
			if (A_2 == PlayerHouseElement.MainFloorDebris)
			{
				this.a(a_, 11, 12, 16, 19);
				return;
			}
			if (A_2 == PlayerHouseElement.LowerFloorDebris)
			{
				this.a(a_, 3, 0, 7, 3);
				return;
			}
			if (A_2 == PlayerHouseElement.UpperFloorDebris)
			{
				this.a(a_, 7, 0, 13, 4);
				return;
			}
		}
		else
		{
			if (A_2 == PlayerHouseElement.MainPower && A_4 == "fixed")
			{
				this.a(A_0, "bf17b2df-335e-461b-9141-9a78b01fd99c", "cc_ph0", true);
				return;
			}
			if (A_2 == PlayerHouseElement.MainFloorLights && A_4 == "fixed")
			{
				this.a(A_0, "7fd52084-81ef-444f-8eba-5c4bd60bf9a7", "cc_ph1", true);
				return;
			}
			if (A_2 == PlayerHouseElement.UpperFloorLights && A_4 == "fixed")
			{
				this.a(A_0, "999b0634-f744-4aa0-b2f2-2056b8efc0e0", "cc_ph2", true);
				return;
			}
			if (A_2 == PlayerHouseElement.LowerFloorLights && A_4 == "fixed")
			{
				this.a(A_0, "20ae2216-d787-4fc1-9087-e4e32dbfd865", "cc_ph0", true);
				return;
			}
			if (A_2 == PlayerHouseElement.MainFloor_LivingRoom_Rug)
			{
				this.a(A_0, A_1, "cc_ph1", 1, 9, 12, 17, A_3, A_4);
				return;
			}
			if (A_2 == PlayerHouseElement.UpperFloor_Gym_Rug)
			{
				this.a(A_0, A_1, "cc_ph2", 0, 12, 8, 19, A_3, A_4);
				return;
			}
			if (A_2 == PlayerHouseElement.UpperFloor_Bedroom_Rug)
			{
				this.a(A_0, A_1, "cc_ph2", 13, 0, 19, 5, A_3, A_4);
			}
		}
	}

	// Token: 0x0600398D RID: 14733 RVA: 0x001543EC File Offset: 0x001525EC
	private void a(c1a A_0, doq A_1, string A_2, int A_3, int A_4, int A_5, int A_6, string A_7, string A_8)
	{
		dxt.a a = new dxt.a();
		a.a = A_0.n(A_2);
		if (a.a != null)
		{
			if (!string.IsNullOrWhiteSpace(A_7))
			{
				for (int i = A_3; i <= A_5; i++)
				{
					for (int j = A_4; j <= A_6; j++)
					{
						ak1 ak = a.a.b(i, j);
						if (ak != null)
						{
							foreach (b0b b0b in Enumerable.ToList<b0b>(ak.c.Values))
							{
								c5x c5x = (c5x)b0b;
								if (c5x.IsFloor && c5x.Layer == aju.x && c5x.o.b != null && (c5x.o.b.a == "Floor\\Rug1" || c5x.o.b.a == "Floor\\ShabyCarpet" || c5x.o.b.a == "Floor\\NightCarpet"))
								{
									c5x.w();
									c5x.an();
								}
							}
						}
					}
				}
			}
			if (!string.IsNullOrWhiteSpace(A_8))
			{
				cpe cpe = Enumerable.FirstOrDefault<cpe>(Enumerable.Where<cpe>(A_1.e(), new Func<cpe, bool>(a.a)));
				if (cpe != null)
				{
					string b;
					if (A_8.EndsWith("_rug_brown"))
					{
						b = "Floor\\Rug1";
					}
					else if (A_8.EndsWith("_rug_blue"))
					{
						b = "Floor\\ShabyCarpet";
					}
					else
					{
						b = "Floor\\NightCarpet";
					}
					foreach (b0b b0b2 in cpe.Entities)
					{
						c5x c5x2 = (c5x)b0b2;
						if (c5x2.IsFloor && c5x2.Location.X >= (float)A_3 && c5x2.Location.X <= (float)A_5 && c5x2.Location.Y >= (float)A_4 && c5x2.Location.Y <= (float)A_6)
						{
							c2j c2j = c5x2.GetAspect<cd0>() as c2j;
							if (c2j != null && c2j.a == b)
							{
								c5x2.Layer = aju.x;
								a.a.a(c5x2);
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600398E RID: 14734 RVA: 0x001546B0 File Offset: 0x001528B0
	private void a(c1a A_0, string A_1, string A_2, bool A_3)
	{
		c5x c5x = new ar7(new Guid(A_1), A_0.n(A_2)).ao() as c5x;
		if (c5x != null)
		{
			axh aspect = c5x.GetAspect<axh>();
			if (aspect != null)
			{
				aspect.a(null, A_3, null);
			}
		}
	}

	// Token: 0x0600398F RID: 14735 RVA: 0x00154700 File Offset: 0x00152900
	private void a(aud A_0, int A_1, int A_2, int A_3, int A_4)
	{
		for (int i = A_1; i <= A_3; i++)
		{
			for (int j = A_2; j <= A_4; j++)
			{
				ak1 ak = A_0.b(i, j);
				if (ak != null)
				{
					foreach (b0b b0b in Enumerable.ToList<b0b>(ak.c.Values))
					{
						c5x c5x = (c5x)b0b;
						if (c5x.a("debris"))
						{
							c5x.w();
							c5x.an();
						}
					}
				}
			}
		}
	}

	// Token: 0x06003990 RID: 14736 RVA: 0x001547B4 File Offset: 0x001529B4
	private void a(c1a A_0)
	{
		foreach (aud aud in Enumerable.ToList<aud>(A_0.Areas))
		{
			foreach (b0b b0b in Enumerable.ToList<b0b>(aud.Entities))
			{
				c5x c5x = (c5x)b0b;
				if (!string.IsNullOrEmpty(c5x.y8()) && c5x.h.b == null && c5x.s.b is c7j && (c5x.y8().EndsWith("- тело") || c5x.y8() == "Останки"))
				{
					c5x.RemoveAspect<a3f>();
					c5x.q("Remains");
					c7j c7j = c5x.GetAspect<bim>() as c7j;
					List<cze> list = c7j.p();
					d3y d3y = new d3y();
					d3y.a(true);
					list.Add(d3y);
					c7j.c("BackpackOpen");
					c7j.c("BackpackClose");
					if (c5x.o.b != null)
					{
						c5x.o.b.a = "Objects\\Containers\\Remains\\Default";
						c5x.o.b.b = new Point(0, 0);
					}
				}
				else if (c5x.GetAspect<a3f>() != null && c5x.GetAspect<a3f>().a().GetPrimitivePropertyValue<bool>("IsCorpse", new bool?(false)).Value)
				{
					c5x.w();
					c5x.an();
				}
				else if (c5x.o.b != null && c5x.o.b.a == "Effects\\BloodPool")
				{
					c5x.w();
					c5x.an();
				}
			}
		}
	}

	// Token: 0x06003991 RID: 14737 RVA: 0x001549DC File Offset: 0x00152BDC
	private void a(cyt A_0, c1a A_1)
	{
		cky cky = (A_0.ac() as bv9).abu(asp.b5, asp.a);
		if (A_0.r().GetPrimitivePropertyValue<bool>("npc_lux_lunaticSynesthete_gaveJuice", new bool?(false)).Value && cky.a != h.a && !A_0.r().GetPrimitivePropertyValue<bool>("loc_cc_ph_spawnedSynestheteGift", new bool?(false)).Value)
		{
			doq a_ = doq.a(Path.Combine(d5x.q(), "cc_ph_l6") + ".uzl");
			A_1.a(a_, 1, null);
			A_0.r()["loc_cc_ph_spawnedSynestheteGift"] = true;
		}
	}

	// Token: 0x02000927 RID: 2343
	[CompilerGenerated]
	private sealed class a
	{
		// Token: 0x06003993 RID: 14739 RVA: 0x00154A9C File Offset: 0x00152C9C
		internal bool a(cpe A_0)
		{
			return A_0.AreaId == this.a.qe();
		}

		// Token: 0x04001B92 RID: 7058
		public aud a;
	}
}

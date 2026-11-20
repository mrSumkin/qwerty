using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;

// Token: 0x02000940 RID: 2368
[eiz("XPBLLEDEC")]
[Serializable]
public sealed class dtk : bdw, ISerializable
{
	// Token: 0x060039F6 RID: 14838 RVA: 0x0015697C File Offset: 0x00154B7C
	private dtk(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x060039F7 RID: 14839 RVA: 0x00156984 File Offset: 0x00154B84
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x060039F8 RID: 14840 RVA: 0x00156988 File Offset: 0x00154B88
	public dtk()
	{
	}

	// Token: 0x060039F9 RID: 14841 RVA: 0x00156994 File Offset: 0x00154B94
	public void av(c1a A_0, cyt A_1)
	{
		ah7 ah = A_0.i("StandingLight");
		if (ah != null)
		{
			ah.Enabled = false;
		}
		ah7 ah2 = A_0.i("TentLight");
		if (ah2 != null)
		{
			ah2.Enabled = false;
		}
		if (A_0.y8() == "xpbl_d5")
		{
			erb.a("xpbl_agsBoat1_clean", A_0.g("AegisBoat1"));
			erb.a("xpbl_agsBoat3_clean", A_0.g("AegisBoat3"));
		}
		if (A_0.y8() == "xpbl_d5" || A_0.y8() == "xpbl_d6" || A_0.y8() == "xpbl_e6")
		{
			doq a_ = doq.a(Path.Combine(d5x.q(), A_0.y8() + "_L2_junk") + ".uzl");
			A_0.a(a_, 1, null);
		}
		foreach (aud aud in Enumerable.ToList<aud>(A_0.Areas))
		{
			foreach (b0b b0b in Enumerable.ToList<b0b>(aud.Entities))
			{
				c5x c5x = (c5x)b0b;
				if (c5x != null)
				{
					if (aud.y8() == "xpbl_d5" && c5x.s.b is wv)
					{
						wv wv = c5x.GetAspect<bim>() as wv;
						if (wv != null && wv.g().l().Contains("expedition_security"))
						{
							c5x.w();
							c5x.an();
						}
					}
					else if (c5x.h.b != null && (c5x.h.b.aa().FactionId == asp.f5 || c5x.h.b.aa().FactionId == asp.f6 || c5x.h.b.aa().FactionId == asp.f7))
					{
						c5x.w();
						c5x.an();
					}
					else if (c5x.a("xpbl_le_campPower") && !A_1.r().GetPrimitivePropertyValue<bool>("loc_xpbl_le_camp_powerDisabledPermanently", new bool?(false)).Value)
					{
						axh aspect = c5x.GetAspect<axh>();
						if (aspect != null)
						{
							aspect.a(null, false, null);
							A_1.r()["loc_xpbl_le_camp_powerDisabledPermanently"] = true;
						}
					}
					else if (c5x.a("xpbl_d6_playersLocker"))
					{
						c7j c7j = c5x.GetAspect<bim>() as c7j;
						if (c7j != null && Enumerable.Any<coh>(c7j.ItemContainer.z2()))
						{
							d6j serviceOrThrow = bpo.GetServiceOrThrow<d6j>();
							if (serviceOrThrow.dv() != null)
							{
								c5k c5k = serviceOrThrow.dv().a("locale\\objects\\containers\\remains\\default");
								if (c5k != null)
								{
									c5x c5x2 = c5k.a(null, false) as c5x;
									if (c5x2 != null)
									{
										c5x2.Layer = aju.x;
										c5x2.Location = new Vector3(c5x.Location.X, c5x.Location.Y, 0f);
										c5x2.q("Bag");
										if (c5x2.o.b != null)
										{
											c5x2.o.b.a = "Objects\\Items\\LootBag";
										}
										c7j c7j2 = c5x2.GetAspect<bim>() as c7j;
										if (c7j2 != null)
										{
											c7j2.ItemContainer.z2().AddRange(c7j.ItemContainer.z2());
											List<cze> list = c7j2.p();
											d3y d3y = new d3y();
											d3y.a(true);
											list.Add(d3y);
										}
										aud.a(c5x2);
									}
								}
							}
						}
						c5x.w();
						c5x.an();
					}
					else if (aud.y8() == "xpbl_e5" && c5x.a("xpbl_e5_damagedNaga"))
					{
						bv9 bv = A_1.ac() as bv9;
						if (bv != null)
						{
							cky cky = bv.abu(asp.gb, asp.f5);
							if (cky != null && cky.a != h.a)
							{
								c5x.w();
								c5x.an();
							}
						}
					}
					else if (c5x.a("xpbl_camp_despawnableElements"))
					{
						c5x.w();
						c5x.an();
					}
				}
			}
		}
	}
}

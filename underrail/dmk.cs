using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;

// Token: 0x020009FE RID: 2558
[eiz("XPBLCVWPRPS")]
[Serializable]
public sealed class dmk : bdw, ISerializable
{
	// Token: 0x06003D0A RID: 15626 RVA: 0x0016B134 File Offset: 0x00169334
	private dmk(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x06003D0B RID: 15627 RVA: 0x0016B13C File Offset: 0x0016933C
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x06003D0C RID: 15628 RVA: 0x0016B140 File Offset: 0x00169340
	public dmk()
	{
	}

	// Token: 0x06003D0D RID: 15629 RVA: 0x0016B14C File Offset: 0x0016934C
	public void av(c1a A_0, cyt A_1)
	{
		aud aud = A_0.n("cvw21");
		if (aud != null)
		{
			bool value = A_1.r().GetPrimitivePropertyValue<bool>("loc_cvw21_pirateRaidProtectorateShip_spawned", new bool?(false)).Value;
			string a_ = "PirateRaidProtectorateShip";
			string text = "xpbl_cvw_prc1";
			string text2 = "Despawn";
			d60 d = A_0.a();
			if (!value)
			{
				erb.a(A_1, A_0, text, A_0.g(a_));
				gx gx = new gx();
				foreach (csd csd in Enumerable.ToList<csd>(A_0.Waypoints))
				{
					if (csd.Name.StartsWith("pirateSpawn") && !A_1.r().GetPrimitivePropertyValue<bool>("quests_xpbl_pirates_secondRaid_goAlone", new bool?(false)).Value && aw1.a(new bt4(csd.Name), aud, l9.b))
					{
						c5x c5x = gx.a(csd, new int?(10), "Pirates_Jetski", null, asp.fw, null, "support\\xpbl\\pir_jets1", false, null, false);
						if (c5x != null)
						{
							c5x.b(text2);
							if (c5x.t.b != null)
							{
								c5x.t.b.y6()[ddq.ay] = new bt4("pirateAttack" + int.Parse(csd.Name.Substring(csd.Name.Length - 1, 1)).ToString());
							}
						}
					}
				}
				if (d != null)
				{
					List<b0b> list = d.ab4(new string[]
					{
						"potentialPilot"
					});
					if (Enumerable.Any<b0b>(list))
					{
						list = cuo.ShuffleList<b0b>(list, null);
						foreach (b0b b0b in list)
						{
							c5x c5x2 = (c5x)b0b;
							if (c5x2 != null && c5x2.t.b != null)
							{
								c5x2.t.b.b("dreadnoughtPilot");
								c5x2.t.b.c("dreadnoughtPilot");
								c5x2.t.b.y6()[ddq.bx] = "dreadnought";
								c5x2.t.b.y6()[ddq.by] = "quests_xpbl_pirates_secondRaid_pilotEnterDreadnought";
								break;
							}
						}
					}
				}
				A_1.r()["loc_cvw21_pirateRaidProtectorateShip_spawned"] = true;
				return;
			}
			erb.a(text, A_0.g(a_));
			if (d != null)
			{
				foreach (b0b b0b2 in d.ab4(new string[]
				{
					text2
				}))
				{
					if (b0b2 != null)
					{
						b0b2.w();
						b0b2.an();
					}
				}
			}
		}
	}
}

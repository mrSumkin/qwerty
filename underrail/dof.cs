using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules;

// Token: 0x020009FF RID: 2559
[eiz("XPBLCVWPRMF")]
[Serializable]
public sealed class dof : bdw, ISerializable
{
	// Token: 0x06003D0E RID: 15630 RVA: 0x0016B4BC File Offset: 0x001696BC
	private dof(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x06003D0F RID: 15631 RVA: 0x0016B4C4 File Offset: 0x001696C4
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x06003D10 RID: 15632 RVA: 0x0016B4C8 File Offset: 0x001696C8
	public dof()
	{
	}

	// Token: 0x06003D11 RID: 15633 RVA: 0x0016B4D4 File Offset: 0x001696D4
	public void av(c1a A_0, cyt A_1)
	{
		aud aud = A_0.n("cvw38");
		if (aud != null)
		{
			bool value = A_1.r().GetPrimitivePropertyValue<bool>("loc_cvw38_pirateRaidMerchantFerry_spawned", new bool?(false)).Value;
			int a_ = 0;
			string a_2 = "PirateRaidMerchantFerry";
			string text = "xpbl_cvw_chmch1";
			string text2 = "Despawn";
			d60 d = A_0.a();
			List<b0b> list = d.ab4(new string[]
			{
				"patrolController"
			});
			if (!value)
			{
				erb.a(A_1, A_0, text, A_0.g(a_2));
				gx gx = new gx();
				bu6 service = bpo.GetService<bu6>();
				int value2 = 15;
				if (service != null)
				{
					if (service.aq2() >= GameDifficulty.Dominating)
					{
						value2 = 25;
					}
					else if (service.aq2() == GameDifficulty.Easy)
					{
						value2 = 10;
					}
				}
				foreach (csd csd in Enumerable.ToList<csd>(A_0.Waypoints))
				{
					if (csd.Name.StartsWith("ferryEscort"))
					{
						if (aw1.a(new bt4(csd.Name), aud, l9.b))
						{
							c5x c5x = gx.a(csd, new int?(value2), "Generic_Jetski", "Свита", asp.gj, "", null, true, null, false);
							if (c5x != null)
							{
								c5x.b(text2);
							}
						}
					}
					else if (csd.Name.StartsWith("pirateSpawn") && !A_1.r().GetPrimitivePropertyValue<bool>("quests_xpbl_pirates_firstRaid_goAlone", new bool?(false)).Value && aw1.a(new bt4(csd.Name), aud, l9.b))
					{
						c5x c5x2 = gx.a(csd, new int?(10), "Pirates_Jetski", null, asp.fw, null, "support\\xpbl\\pir_jets1", false, null, false);
						if (c5x2 != null)
						{
							c5x2.b(text2);
							if (c5x2.t.b != null)
							{
								c5x2.t.b.y6()[ddq.ay] = new bt4("pirateAttack" + int.Parse(csd.Name.Substring(csd.Name.Length - 1, 1)).ToString());
							}
						}
					}
				}
				if (!A_1.r().GetPrimitivePropertyValue<bool>("loc_xpbl_rig_sonarDestroyed", new bool?(false)).Value && !A_1.r().GetPrimitivePropertyValue<bool>("loc_rig_blackEels_wipedOut", new bool?(false)).Value)
				{
					A_1.b(new dp6());
				}
				A_1.r()["loc_cvw38_pirateRaidMerchantFerry_spawned"] = true;
			}
			else
			{
				erb.a(text, A_0.g(a_2));
				foreach (b0b b0b in d.ab4(new string[]
				{
					text2
				}))
				{
					if (b0b != null)
					{
						b0b.w();
						b0b.an();
					}
				}
				a_ = 1;
			}
			foreach (b0b b0b2 in list)
			{
				if (b0b2 != null)
				{
					ehi aspect = b0b2.GetAspect<ehi>();
					if (aspect != null)
					{
						aspect.c(a_);
					}
				}
			}
		}
	}
}

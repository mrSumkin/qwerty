using System;
using System.Linq;
using System.Runtime.Serialization;

// Token: 0x020009FD RID: 2557
[eiz("XPBLRIGF")]
[Serializable]
public sealed class bks : bdw, ISerializable
{
	// Token: 0x06003D01 RID: 15617 RVA: 0x0016A480 File Offset: 0x00168680
	private bks(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x06003D02 RID: 15618 RVA: 0x0016A488 File Offset: 0x00168688
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x06003D03 RID: 15619 RVA: 0x0016A48C File Offset: 0x0016868C
	public bks()
	{
	}

	// Token: 0x06003D04 RID: 15620 RVA: 0x0016A498 File Offset: 0x00168698
	public void av(c1a A_0, cyt A_1)
	{
		if (A_0 != null)
		{
			if (A_0.y8() == "xpbl_rig1")
			{
				if (A_1.r().GetPrimitivePropertyValue<bool>("quests_xpbl_pirates_theRig_partyLeavesRig", new bool?(false)).Value && !A_1.r().GetPrimitivePropertyValue<bool>("quests_xpbl_pirates_theRig_ferryDespawnedFromRig", new bool?(false)).Value)
				{
					this.a(A_1, A_0);
				}
				if (!A_1.r().GetPrimitivePropertyValue<bool>("loc_xpbl_rig_setNorthGate", new bool?(false)).Value)
				{
					dys dys = new dys();
					dys.a(true);
					dys.ym(A_1.v().b(), null, null);
					A_1.r()["loc_xpbl_rig_setNorthGate"] = true;
				}
			}
			else
			{
				aud aud = A_0.n("xpbl_rig2");
				if (aud != null)
				{
					if (A_1.r().GetPrimitivePropertyValue<bool>("loc_rig_blackEels_wipedOut", new bool?(false)).Value || (!A_1.r().GetPrimitivePropertyValue<bool>("loc_xpbl_rig_attacked", new bool?(false)).Value && (A_1.r().GetPrimitivePropertyValue<bool>("npc_xpbl_rig_murky_dead", new bool?(false)).Value || A_1.r().GetPrimitivePropertyValue<bool>("npc_xpbl_rig_squeezer_dead", new bool?(false)).Value || A_1.r().GetPrimitivePropertyValue<bool>("npc_xpbl_rig_boulder_dead", new bool?(false)).Value)))
					{
						this.a(A_1);
					}
					else if (A_1.r().GetPrimitivePropertyValue<bool>("npc_rig_squeezer_met", new bool?(false)).Value)
					{
						this.a(aud, A_1);
					}
					if (A_1.r().GetPrimitivePropertyValue<bool>("quests_xpbl_pirates_theRig_started", new bool?(false)).Value && A_1.r().GetPrimitivePropertyValue<bool>("loc_xpbl_rig_sonarDestroyed", new bool?(false)).Value && !A_1.r().GetPrimitivePropertyValue<bool>("quests_xpbl_pirates_theRig_completed", new bool?(false)).Value && !A_1.r().GetPrimitivePropertyValue<bool>("quests_xpbl_pirates_theRig_goAlone", new bool?(false)).Value && !A_1.r().GetPrimitivePropertyValue<bool>("quests_xpbl_pirates_theRig_partyDocksAtRig", new bool?(false)).Value && !A_1.r().GetPrimitivePropertyValue<bool>("quests_xpbl_pirates_theRig_tookOutSonarEarly", new bool?(false)).Value && !A_1.r().GetPrimitivePropertyValue<bool>("quests_xpbl_pirates_theRig_sonarDestroyedBeforePartyDocked", new bool?(false)).Value)
					{
						A_1.r()["quests_xpbl_pirates_theRig_sonarDestroyedBeforePartyDocked"] = true;
						A_1.r()["npc_xpbl_pir_grim_guardedAudience"] = true;
					}
				}
			}
			if (A_1.r().GetPrimitivePropertyValue<bool>("loc_rig_blackEels_wipedOut", new bool?(false)).Value)
			{
				this.b(A_1, A_0.y8());
			}
			if (dh7.a != null && dh7.a.c != null && !dh7.a.c.StartsWith("xpbl_rig"))
			{
				if (A_1.r().GetPrimitivePropertyValue<bool>("quests_xpbl_pirates_theRig_attackStarted", new bool?(false)).Value && A_1.r().GetPrimitivePropertyValue<bool>("loc_xpbl_rig_sonarDestroyed", new bool?(false)).Value && !A_1.r().GetPrimitivePropertyValue<bool>("quests_xpbl_pirates_theRig_partyLeavesRig", new bool?(false)).Value)
				{
					A_1.r()["quests_xpbl_pirates_theRig_partyLeavesRig"] = true;
					this.a(A_1, A_0);
				}
				if (A_1.r().GetPrimitivePropertyValue<bool>("quests_xpbl_pirates_theRig_partyLeavesRig", new bool?(false)).Value && !A_1.r().GetPrimitivePropertyValue<bool>("quests_xpbl_pirates_theRig_revertHostilities", new bool?(false)).Value)
				{
					A_1.r()["quests_xpbl_pirates_theRig_revertHostilities"] = true;
					this.a(A_1, A_0.y8());
				}
			}
		}
	}

	// Token: 0x06003D05 RID: 15621 RVA: 0x0016A8D8 File Offset: 0x00168AD8
	private void a(aud A_0, cyt A_1)
	{
		c5x c5x = new ar7(new Guid("13a9b92d-e46c-4998-8a39-0df52e8e4b11"), A_0).ao() as c5x;
		c5x c5x2 = new ar7(new Guid("5c99cafb-4e7a-46d6-ba49-d32479030e07"), A_0).ao() as c5x;
		if (c5x != null && c5x2 != null)
		{
			TimeSpan? primitivePropertyValue = A_1.r().GetPrimitivePropertyValue<TimeSpan>("loc_xpbl_rig_squeezerBoulderRotationTime", null);
			if (primitivePropertyValue == null)
			{
				A_1.r()["loc_xpbl_rig_squeezerBoulderRotationTime"] = A_1.p() + TimeSpan.FromMinutes(60.0);
				return;
			}
			if (primitivePropertyValue <= A_1.p())
			{
				c5x c5x3;
				if (A_1.r().GetPrimitivePropertyValue<bool>("loc_xpbl_rig_boulderOnDuty", new bool?(false)).Value)
				{
					a0l.a(c5x, "boulder-squeezer_rest", true);
					a0l.a(c5x2, "boulder-squeezer_guard", true);
					c5x3 = c5x2;
					A_1.r()["loc_xpbl_rig_boulderOnDuty"] = false;
				}
				else
				{
					a0l.a(c5x, "boulder-squeezer_guard", true);
					a0l.a(c5x2, "boulder-squeezer_rest", true);
					c5x3 = c5x;
					A_1.r()["loc_xpbl_rig_boulderOnDuty"] = true;
				}
				A_1.r()["loc_xpbl_rig_squeezerBoulderRotationTime"] = A_1.p() + TimeSpan.FromMinutes(60.0);
				if (c5x3 != null)
				{
					eiw eiw = new eiw();
					eiw.a(c5x3.Area.y8());
					eiw.a(new Guid?(c5x3.qe()));
					eiw.ym(c5x3, null, null);
					return;
				}
			}
		}
		else
		{
			if (c5x != null)
			{
				c5x.an();
			}
			if (c5x2 != null)
			{
				c5x2.an();
			}
			A_1.r()["loc_xpbl_rig_bouldersClosed"] = true;
		}
	}

	// Token: 0x06003D06 RID: 15622 RVA: 0x0016AAD4 File Offset: 0x00168CD4
	private void b(cyt A_0, string A_1)
	{
		if (!A_0.r().GetPrimitivePropertyValue<bool>("loc_" + A_1 + "_workersCleared", new bool?(false)).Value)
		{
			d02 service = bpo.GetService<d02>();
			if (service != null)
			{
				foreach (d4n d4n in Enumerable.ToList<d4n>(service.ahl()))
				{
					if (d4n.b != null && d4n.b.a8() != null && !d4n.b.aa().Dead && d4n.b.aa().FactionId == asp.gi)
					{
						d4n.b.a8().w();
						d4n.b.a8().an();
					}
				}
			}
			A_0.r()["loc_" + A_1 + "_workersCleared"] = true;
		}
	}

	// Token: 0x06003D07 RID: 15623 RVA: 0x0016ABFC File Offset: 0x00168DFC
	private void a(cyt A_0)
	{
		if (!A_0.r().GetPrimitivePropertyValue<bool>("loc_xpbl_rig_tavernEmptied", new bool?(false)).Value)
		{
			d02 service = bpo.GetService<d02>();
			if (service != null)
			{
				foreach (d4n d4n in Enumerable.ToList<d4n>(service.ahl()))
				{
					if (d4n.b != null && d4n.b.a8() != null && !d4n.b.aa().Dead && d4n.b.aa().FactionId == asp.gf && d4n.b.a8().qe() != new Guid("13a9b92d-e46c-4998-8a39-0df52e8e4b11") && d4n.b.a8().qe() != new Guid("5c99cafb-4e7a-46d6-ba49-d32479030e07"))
					{
						d4n.b.a8().w();
						d4n.b.a8().an();
					}
				}
			}
			A_0.r()["loc_xpbl_rig_tavernEmptied"] = true;
		}
	}

	// Token: 0x06003D08 RID: 15624 RVA: 0x0016AD54 File Offset: 0x00168F54
	private void a(cyt A_0, string A_1)
	{
		bv9 bv = A_0.ac() as bv9;
		bool value = A_0.r().GetPrimitivePropertyValue<bool>("quests_xpbl_pirates_theRig_revertHostilities", new bool?(false)).Value;
		bool value2 = A_0.r().GetPrimitivePropertyValue<bool>("quests_xpbl_pirates_theRig_revertHostilities_faction", new bool?(false)).Value;
		bool value3 = A_0.r().GetPrimitivePropertyValue<bool>("quests_xpbl_pirates_theRig_" + A_1 + "_revertedHostilities", new bool?(false)).Value;
		bool value4 = A_0.r().GetPrimitivePropertyValue<bool>("loc_xpbl_rig_alarmRaised", new bool?(false)).Value;
		bool value5 = A_0.r().GetPrimitivePropertyValue<bool>("quests_xpbl_pirates_theRig_setHostiityIfAlarmed", new bool?(false)).Value;
		if (!A_0.r().GetPrimitivePropertyValue<bool>("loc_rig_blackEels_wipedOut", new bool?(false)).Value)
		{
			if (value && !value3)
			{
				if (value2)
				{
					if (bv != null)
					{
						bv.a(asp.gg, asp.a, h.b, null, true, false, false);
						bv.a(asp.gi, asp.a, h.b, null, true, false, false);
						bv.a(asp.gh, asp.a, h.b, null, true, false, false);
						bv.a(asp.gf, asp.a, h.c, null, true, false, false);
					}
					A_0.r()["loc_xpbl_rig_alarmRaised"] = false;
					A_0.r()["quests_xpbl_pirates_theRig_revertHostilities_faction"] = true;
				}
				d02 service = bpo.GetService<d02>();
				if (service != null)
				{
					foreach (d4n d4n in Enumerable.ToList<d4n>(service.ahl()))
					{
						if (d4n.b != null && d4n.b.a8() != null && !d4n.b.aa().Dead && d4n.b.aa().FactionId.StartsWith("rig_"))
						{
							d4n.b.aa().c(asp.a);
						}
					}
					A_0.r()["quests_xpbl_pirates_theRig_" + A_1 + "_revertedHostilities"] = true;
				}
			}
			else if (value4 && !value5)
			{
				if (bv != null)
				{
					bv.a(asp.gg, asp.a, h.a, null, true, false, false);
					bv.a(asp.ae, asp.a, h.a, null, true, false, false);
				}
				A_0.r()["quests_xpbl_pirates_theRig_setHostiityIfAlarmed"] = false;
			}
			dys dys = new dys();
			dys.a(true);
			dys.ym(A_0.v().b(), null, null);
		}
	}

	// Token: 0x06003D09 RID: 15625 RVA: 0x0016B06C File Offset: 0x0016926C
	private void a(cyt A_0, c1a A_1)
	{
		erb.a("xpbl_rig_ps", A_1.g("RigRaidFerry"));
		A_0.r()["quests_xpbl_pirates_theRig_ferryDespawnedFromRig"] = true;
		c5x c5x = new ar7(new Guid("40fc535a-4678-4c6b-bc8e-d19a0c09e3b2"), A_1.n("xpbl_rig1")).ao() as c5x;
		if (c5x != null && c5x.t.b != null)
		{
			c5x.t.b.y6().RemoveProperty(ddq.k);
		}
		if (!A_0.r().GetPrimitivePropertyValue<bool>("quests_xpbl_pirates_theRig_goAlone", new bool?(false)).Value)
		{
			A_0.r()["npc_xpbl_pir_grim_guardedAudience"] = true;
		}
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;

// Token: 0x02000AFF RID: 2815
[eiz("XPBLCVWPSRAJ")]
[Serializable]
public sealed class akc : cze, ISerializable
{
	// Token: 0x0600413E RID: 16702 RVA: 0x0018EBA8 File Offset: 0x0018CDA8
	private akc(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x0600413F RID: 16703 RVA: 0x0018EBB4 File Offset: 0x0018CDB4
	public akc()
	{
	}

	// Token: 0x06004140 RID: 16704 RVA: 0x0018EBC0 File Offset: 0x0018CDC0
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null)
		{
			string name = "quests_xpbl_pirates_secondRaid_shipCleared";
			bool flag = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>(name, new bool?(false)).Value;
			if (!flag)
			{
				d02 service = bpo.GetService<d02>();
				if (service != null)
				{
					int num = 0;
					foreach (d4n d4n in Enumerable.ToList<d4n>(service.ahl()))
					{
						if (d4n.b != null && !d4n.b.aa().Dead && d4n.b.aa().FactionId == asp.bt)
						{
							num++;
						}
					}
					if (num < 3)
					{
						serviceOrThrow.aqu().r()["quests_xpbl_pirates_secondRaid_pilotEnterDreadnought"] = true;
						if (num <= 0)
						{
							flag = true;
							serviceOrThrow.aqu().r()[name] = flag;
							serviceOrThrow.aqu().r()["npc_xpbl_pir_grim_guardedAudience"] = true;
						}
					}
				}
				if (flag && !serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("npc_xpbl_pir_razor_dead", new bool?(false)).Value)
				{
					gx gx = new gx();
					foreach (csd csd in Enumerable.ToList<csd>(serviceOrThrow.aqw().Waypoints))
					{
						if (csd.Name.StartsWith("pirateFinalSpawn") && aw1.a(new bt4(csd.Name), serviceOrThrow.aqu().v().b().Area, l9.b))
						{
							c5x c5x = gx.a(csd, new int?(10), "Pirates_Jetski", null, asp.fw, null, "support\\xpbl\\pir_jets1", false, null, false);
							if (c5x != null)
							{
								c5x.b("Despawn");
								if (c5x.t.b != null)
								{
									c5x.t.b.y6()[ddq.ay] = new bt4("pirateAttack" + int.Parse(csd.Name.Substring(csd.Name.Length - 1, 1)).ToString());
									c5x.t.b.y6()[ddq.bc] = "npc_cvw21_pir_jetter_toldLooting";
								}
							}
						}
					}
					serviceOrThrow.aqu().b(new cql(serviceOrThrow.aqw().y8()));
				}
			}
		}
	}
}

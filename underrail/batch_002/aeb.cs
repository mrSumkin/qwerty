using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;

// Token: 0x02000B00 RID: 2816
[eiz("XPBLCVWMSRAJ")]
[Serializable]
public sealed class aeb : cze, ISerializable
{
	// Token: 0x06004141 RID: 16705 RVA: 0x0018EEC8 File Offset: 0x0018D0C8
	private aeb(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06004142 RID: 16706 RVA: 0x0018EED4 File Offset: 0x0018D0D4
	public aeb()
	{
	}

	// Token: 0x06004143 RID: 16707 RVA: 0x0018EEE0 File Offset: 0x0018D0E0
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null)
		{
			string text = "quests_xpbl_pirates_firstRaid_shipCleared";
			if (!serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>(text, new bool?(false)).Value)
			{
				new dqd(asp.gj, text).ym(A_0, A_1, null);
				if (serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>(text, new bool?(false)).Value)
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
									c5x.t.b.y6()[ddq.bc] = "npc_cvw38_pir_jetter_toldLooting";
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;

// Token: 0x02000B14 RID: 2836
[eiz("XPBLLEGMPCTS")]
[Serializable]
public sealed class ctd : cze, ISerializable
{
	// Token: 0x0600418E RID: 16782 RVA: 0x00192AC0 File Offset: 0x00190CC0
	private ctd(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x0600418F RID: 16783 RVA: 0x00192ACC File Offset: 0x00190CCC
	public ctd()
	{
	}

	// Token: 0x06004190 RID: 16784 RVA: 0x00192AD4 File Offset: 0x00190CD4
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		aud aud = null;
		if (A_0 != null)
		{
			aud = A_0.Area;
		}
		else if (A_1 != null)
		{
			aud = A_1.Area;
		}
		if (aud != null)
		{
			cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
			if (serviceOrThrow.aqu() != null)
			{
				efk efk = serviceOrThrow.aqu().v();
				if (efk != null)
				{
					serviceOrThrow.aqu().r()["npc_xpbl_seeger_mpc_mpcsPerDelivery"] = 0;
					List<string> list = new List<string>();
					list.Add("plot.xpbl_mpc_mechanic");
					list.Add("plot.xpbl_mpc_soldier");
					list.Add("plot.xpbl_mpc_robotics");
					list.Add("plot.xpbl_mpc_hydrothermal");
					list.Add("plot.xpbl_mpc_plants");
					list.Add("plot.xpbl_mpc_mutation");
					list.Add("plot.xpbl_mpc_security");
					list.Add("plot.xpbl_mpc_animals");
					list.Add("lemurianSmTablet");
					List<string> list2 = new List<string>();
					list2.Add("npc_xpbl_seeger_mpc_mechanic");
					list2.Add("npc_xpbl_seeger_mpc_soldier");
					list2.Add("npc_xpbl_seeger_mpc_robotics");
					list2.Add("npc_xpbl_seeger_mpc_hydrothermal");
					list2.Add("npc_xpbl_seeger_mpc_plants");
					list2.Add("npc_xpbl_seeger_mpc_mutation");
					list2.Add("npc_xpbl_seeger_mpc_security");
					list2.Add("npc_xpbl_seeger_mpc_animals");
					list2.Add("npc_xpbl_seeger_mpc_slimy");
					foreach (coh coh in Enumerable.ToList<coh>(efk.Bag.z2()))
					{
						if (coh != null && coh.Definition.a5() != null && (coh.Definition.a5().StartsWith("plot.xpbl_mpc_") || coh.Definition.a5().StartsWith("lemurianSmTablet")))
						{
							for (int i = 0; i < list.Count; i++)
							{
								if (coh.Definition.a5() == list[i])
								{
									if (coh.Definition.a5().StartsWith("lemurianSmTablet"))
									{
										serviceOrThrow.aqu().r()["npc_xpbl_seeger_handedSlimyNpc"] = true;
									}
									serviceOrThrow.aqu().r()[list2[i]] = true;
									serviceOrThrow.aqu().r()["npc_xpbl_seeger_mpc_mpcsPerDelivery"] = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<int>("npc_xpbl_seeger_mpc_mpcsPerDelivery", new int?(0)).Value + 1;
									efk.Bag.a(list[i], 1);
								}
							}
						}
					}
				}
			}
		}
	}
}

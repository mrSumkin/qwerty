using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules;

// Token: 0x02000B4E RID: 2894
[eiz("DCFAC")]
[Serializable]
public sealed class dyk : cze, ISerializable
{
	// Token: 0x0600426B RID: 17003 RVA: 0x0019C028 File Offset: 0x0019A228
	private dyk(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x0600426C RID: 17004 RVA: 0x0019C034 File Offset: 0x0019A234
	public dyk()
	{
	}

	// Token: 0x0600426D RID: 17005 RVA: 0x0019C040 File Offset: 0x0019A240
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null && serviceOrThrow.aqw() != null)
		{
			int num = 0;
			bool value = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("quest_fo_facelessRecon_finished", new bool?(false)).Value;
			bool value2 = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("npc_rcmindreader_removed", new bool?(false)).Value;
			bool value3 = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("npc_cc16_faceless_released", new bool?(false)).Value;
			bool value4 = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("npc_rcmindreader_dead", new bool?(false)).Value;
			bool value5 = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("npc_cc16_faceless_killed", new bool?(false)).Value;
			bool value6 = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("npc_cc_injuredFaceless_attacked", new bool?(false)).Value;
			int value7 = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<int>("global_facelessKilled", new int?(0)).Value;
			int value8 = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<int>("loc_rcshop_deadfaceless", new int?(0)).Value;
			int num2 = value7 + value8;
			bool value9 = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("loc_dc_flo_mindreading_passedHighTC", new bool?(false)).Value;
			bv9 bv = serviceOrThrow.aqu().ac() as bv9;
			if (bv != null)
			{
				cky cky = bv.abu(asp.a, asp.c9);
				bv.abu(asp.a, asp.ch);
				if (cky.a > h.a && value)
				{
					num++;
				}
				if (value2)
				{
					num++;
				}
				if (value3 && !value5 && !value6)
				{
					num++;
				}
				if (value4 && !value9)
				{
					num--;
				}
				if (value3 && value6 && !value9)
				{
					num = -5;
				}
				if (value5 && !value9)
				{
					num = -5;
				}
				if (cky.a == h.a && !value9)
				{
					num = -5;
				}
			}
			if (!value9)
			{
				if (num2 > 10)
				{
					num = -5;
				}
				else
				{
					int num3 = 0;
					int num4 = 4;
					bu6 service = bpo.GetService<bu6>();
					if (service != null)
					{
						if (service.aq2() >= GameDifficulty.Dominating)
						{
							num4 = 2;
						}
						else if (service.aq2() >= GameDifficulty.Hard)
						{
							num4 = 3;
						}
						else if (service.aq2() == GameDifficulty.Easy)
						{
							num4 = 6;
						}
					}
					for (int i = 0; i < num2; i++)
					{
						if (num3 == num4)
						{
							num--;
							num3 = 0;
						}
						num3++;
					}
				}
			}
			serviceOrThrow.aqu().r()["loc_dc_flo_attitudeCalculationKilled"] = num2;
			serviceOrThrow.aqu().r()["loc_dc_flo_attitudeCalculation"] = num;
		}
	}
}

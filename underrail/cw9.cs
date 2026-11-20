using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x02000B90 RID: 2960
[eiz("CCRBID")]
[Serializable]
public sealed class cw9 : cze, ISerializable
{
	// Token: 0x06004371 RID: 17265 RVA: 0x001A609C File Offset: 0x001A429C
	private cw9(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06004372 RID: 17266 RVA: 0x001A60A8 File Offset: 0x001A42A8
	public cw9()
	{
	}

	// Token: 0x06004373 RID: 17267 RVA: 0x001A60B4 File Offset: 0x001A42B4
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null && serviceOrThrow.aqw() != null)
		{
			string classPropertyValue = serviceOrThrow.aqu().r().GetClassPropertyValue<string>("npc_cc_ray_describeBreakIn_gender");
			string classPropertyValue2 = serviceOrThrow.aqu().r().GetClassPropertyValue<string>("npc_cc_ray_describeBreakIn_color");
			string classPropertyValue3 = serviceOrThrow.aqu().r().GetClassPropertyValue<string>("npc_cc_ray_describeBreakIn_height");
			string classPropertyValue4 = serviceOrThrow.aqu().r().GetClassPropertyValue<string>("npc_cc_ray_describeBreakIn_constitution");
			string classPropertyValue5 = serviceOrThrow.aqu().r().GetClassPropertyValue<string>("npc_cc_ray_describeBreakIn_clothes");
			string classPropertyValue6 = serviceOrThrow.aqu().r().GetClassPropertyValue<string>("npc_cc_ray_describeBreakIn_hair");
			string classPropertyValue7 = serviceOrThrow.aqu().r().GetClassPropertyValue<string>("npc_cc_ray_describeBreakIn_face");
			string text = "";
			bool flag = false;
			int num = 0;
			if (classPropertyValue2 != null)
			{
				text = text + classPropertyValue2 + " ";
				num++;
			}
			if (classPropertyValue6 != null)
			{
				if (classPropertyValue6.Equals("с лысой головой,"))
				{
					text = text + classPropertyValue6 + " ";
					flag = true;
				}
				else
				{
					text = text + classPropertyValue6 + " волосы, ";
					flag = true;
				}
				num++;
			}
			if (classPropertyValue3 != null && classPropertyValue3.Equals("карлик"))
			{
				text += classPropertyValue3;
				num++;
			}
			else if (classPropertyValue != null && flag)
			{
				text = text + classPropertyValue + ", ";
				if (classPropertyValue3 != null)
				{
					text += classPropertyValue3;
				}
			}
			else
			{
				if (classPropertyValue3 != null && !classPropertyValue3.Equals("среднего роста"))
				{
					text = text + classPropertyValue3 + " ";
				}
				if (classPropertyValue != null)
				{
					if (!classPropertyValue.Equals("человек неизвестного пола"))
					{
						text = text + classPropertyValue + "";
					}
					else
					{
						text += classPropertyValue;
					}
					if (classPropertyValue3.Equals("среднего роста"))
					{
						text = text + " " + classPropertyValue3;
					}
				}
				if (!classPropertyValue3.Contains("среднего"))
				{
					num++;
				}
			}
			if (classPropertyValue4 != null)
			{
				text = text + ", " + classPropertyValue4 + ",";
				if (!classPropertyValue4.Contains("среднего"))
				{
					num++;
				}
			}
			if (classPropertyValue5 != null)
			{
				if (classPropertyValue4 == null)
				{
					text += ",";
				}
				text = text + " " + classPropertyValue5 + ",";
				num++;
			}
			if (classPropertyValue7 != null)
			{
				text = text + " с " + classPropertyValue7;
				num++;
			}
			if (text.EndsWith(","))
			{
				text = text.TrimEnd(new char[]
				{
					','
				});
			}
			serviceOrThrow.aqu().r()["npc_cc_ray_describeBreakIn_finalDescription"] = text;
			if (num > 0)
			{
				serviceOrThrow.aqu().r()["npc_cc_ray_describeBreakIn_sufficientFacts"] = true;
			}
		}
	}
}

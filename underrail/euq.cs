using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x020008F2 RID: 2290
[eiz("RNDDCCSBAE")]
[Serializable]
public sealed class euq : bdw, ISerializable
{
	// Token: 0x060038B7 RID: 14519 RVA: 0x00150780 File Offset: 0x0014E980
	private euq(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x060038B8 RID: 14520 RVA: 0x00150788 File Offset: 0x0014E988
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x060038B9 RID: 14521 RVA: 0x0015078C File Offset: 0x0014E98C
	public euq()
	{
	}

	// Token: 0x060038BA RID: 14522 RVA: 0x00150798 File Offset: 0x0014E998
	public void av(c1a A_0, cyt A_1)
	{
		if (A_1.r().GetClassPropertyValue<string>("dun_cc_sBombers_eventStatus").Equals("triggered"))
		{
			int? primitivePropertyValue = A_1.r().GetPrimitivePropertyValue<int>("dun_cc_sBombersKilled", new int?(0));
			int num = 3;
			if (primitivePropertyValue.GetValueOrDefault() < num & primitivePropertyValue != null)
			{
				A_1.r()["dun_cc_sBombers_eventStatus"] = "detonated";
				A_1.r()["dun_cc_sBombersKilled"] = 3;
				d60 d = A_0.a();
				if (d != null)
				{
					List<b0b> list = d.ab4(new string[]
					{
						"cc_sBombers"
					});
					foreach (b0b b0b in list)
					{
						c5x c5x = (c5x)b0b;
						c5x.an();
						c5x.w();
					}
					list.Clear();
					list = d.ab4(new string[]
					{
						"cc_sBombers_hidden"
					});
					foreach (b0b b0b2 in list)
					{
						c5x c5x2 = (c5x)b0b2;
						if (c5x2.GetAspect<etz>() != null)
						{
							c5x2.ae = new float?(0.65f);
						}
						else
						{
							c5x2.ae = new float?((float)1);
						}
					}
				}
			}
		}
	}
}

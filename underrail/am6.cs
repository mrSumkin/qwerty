using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x02000B93 RID: 2963
[eiz("TPBFS")]
[Serializable]
public sealed class am6 : cze, ISerializable
{
	// Token: 0x0600437B RID: 17275 RVA: 0x001A66F0 File Offset: 0x001A48F0
	private am6(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x0600437C RID: 17276 RVA: 0x001A66FC File Offset: 0x001A48FC
	public am6()
	{
	}

	// Token: 0x0600437D RID: 17277 RVA: 0x001A6704 File Offset: 0x001A4904
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
				bool value = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("test_Start", new bool?(false)).Value;
				bool flag = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("test_End", new bool?(false)).Value;
				int num = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<int>("test_turnsLeft", new int?(0)).Value;
				if (!serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("test_setTurns", new bool?(false)).Value)
				{
					num = 1;
					serviceOrThrow.aqu().r()["test_turnsLeft"] = num;
					bool flag2 = true;
					serviceOrThrow.aqu().r()["test_setTurns"] = flag2;
				}
				if (value)
				{
					if (num == 0 && !flag)
					{
						eaq eaq = new eaq();
						eaq.b(asp.c1);
						eaq.a(asp.bd);
						eaq.a(h.a);
						eaq.a(true);
						eaq.ym(null, null, null);
						flag = true;
						serviceOrThrow.aqu().r()["test_End"] = flag;
					}
					else if (!flag)
					{
						num--;
					}
					serviceOrThrow.aqu().r()["test_turnsLeft"] = num;
				}
			}
		}
	}
}

using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x02000AF5 RID: 2805
[eiz("XPBLRSGJ")]
[Serializable]
public sealed class b15 : cze, ISerializable
{
	// Token: 0x0600411F RID: 16671 RVA: 0x0018D898 File Offset: 0x0018BA98
	private b15(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06004120 RID: 16672 RVA: 0x0018D8A4 File Offset: 0x0018BAA4
	public b15()
	{
	}

	// Token: 0x06004121 RID: 16673 RVA: 0x0018D8B0 File Offset: 0x0018BAB0
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null && !serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("xpbl_gy_skerderGravesRandomized", new bool?(false)).Value)
		{
			List<int> list = new List<int>();
			List<int> list2 = new List<int>();
			for (int i = 0; i < 20; i++)
			{
				list.Add(i);
			}
			for (int j = 0; j < 20; j++)
			{
				int item = list[cuo.a.Next(list.Count)];
				list.Remove(item);
				list2.Add(item);
			}
			serviceOrThrow.aqu().r()["xpbl_gy_skerderGravesRandomized"] = true;
			serviceOrThrow.aqu().r()["xpbl_gy_skerderGravesRandomizedList"] = list2;
			serviceOrThrow.aqu().r()["xpbl_gy_crankLocation"] = cuo.a.Next(40);
		}
	}
}

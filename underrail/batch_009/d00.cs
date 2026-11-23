using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;

// Token: 0x020009F8 RID: 2552
[eiz("XPBLSORRSN")]
[Serializable]
public sealed class d00 : bdw, ISerializable
{
	// Token: 0x06003CED RID: 15597 RVA: 0x00169DB4 File Offset: 0x00167FB4
	private d00(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x06003CEE RID: 15598 RVA: 0x00169DBC File Offset: 0x00167FBC
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x06003CEF RID: 15599 RVA: 0x00169DC0 File Offset: 0x00167FC0
	public d00()
	{
	}

	// Token: 0x06003CF0 RID: 15600 RVA: 0x00169DCC File Offset: 0x00167FCC
	public void av(c1a A_0, cyt A_1)
	{
		if (A_0 != null && !A_1.r().GetPrimitivePropertyValue<bool>("loc_xpbl_" + A_0.y8() + "_sormirbarenCleared", new bool?(false)).Value)
		{
			double value = (double)A_1.r().GetPrimitivePropertyValue<int>("loc_xpbl_e5_battleNumber", new int?(0)).Value;
			int? primitivePropertyValue = A_1.r().GetPrimitivePropertyValue<int>(string.Format("loc_xpbl_{0}_numberOfDisposableSavages", A_0.y8().ToLowerInvariant()), null);
			double num = value * 0.08;
			List<c5x> list = new List<c5x>();
			foreach (aud aud in A_0.Areas)
			{
				foreach (b0b b0b in Enumerable.ToList<b0b>(aud.Entities))
				{
					c5x c5x = (c5x)b0b;
					if (c5x != null && c5x.h.b != null && c5x.h.b.aa().FactionId == asp.fx && !c5x.a("nonRemovableSormirbaren"))
					{
						list.Add(c5x);
					}
				}
			}
			if (primitivePropertyValue == null)
			{
				primitivePropertyValue = new int?(list.Count);
				A_1.r()[string.Format("loc_xpbl_{0}_numberOfDisposableSavages", A_0.y8().ToLowerInvariant())] = primitivePropertyValue;
			}
			int num2 = Convert.ToInt32((double)primitivePropertyValue.Value * (1.0 - num));
			if (list.Count > num2)
			{
				int num3 = list.Count - num2;
				list = cuo.ShuffleList<c5x>(list, null);
				for (int i = 0; i < num3; i++)
				{
					list[i].w();
					list[i].an();
				}
			}
		}
	}
}

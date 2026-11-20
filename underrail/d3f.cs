using System;
using System.Linq;
using System.Runtime.Serialization;

// Token: 0x0200096A RID: 2410
[eiz("DCFCZ")]
[Serializable]
public sealed class d3f : bdw, ISerializable
{
	// Token: 0x06003AA2 RID: 15010 RVA: 0x0015B8E4 File Offset: 0x00159AE4
	private d3f(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x06003AA3 RID: 15011 RVA: 0x0015B8EC File Offset: 0x00159AEC
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x06003AA4 RID: 15012 RVA: 0x0015B8F0 File Offset: 0x00159AF0
	public d3f()
	{
	}

	// Token: 0x06003AA5 RID: 15013 RVA: 0x0015B8FC File Offset: 0x00159AFC
	public void av(c1a A_0, cyt A_1)
	{
		if (A_0 != null && A_1 != null)
		{
			bool value = A_1.r().GetPrimitivePropertyValue<bool>("global_TchortDefeated", new bool?(false)).Value;
			bool value2 = A_1.r().GetPrimitivePropertyValue<bool>("dc_facelessControlledZoneCleared_" + A_0.y8(), new bool?(false)).Value;
			if (value && !value2)
			{
				A_1.r()["dc_facelessControlledZoneCleared_" + A_0.y8()] = true;
				d02 service = bpo.GetService<d02>();
				if (service != null)
				{
					foreach (d4n d4n in Enumerable.ToList<d4n>(service.ahl()))
					{
						if (d4n.b.aa().FactionId == asp.ch && !d4n.b.aa().Dead)
						{
							d4n.b.a8().w();
							d4n.b.a8().an();
						}
					}
				}
			}
		}
	}
}

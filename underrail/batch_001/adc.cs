using System;
using System.Linq;
using System.Runtime.Serialization;

// Token: 0x0200094E RID: 2382
[eiz("RCCEC")]
[Serializable]
public sealed class adc : bdw, ISerializable
{
	// Token: 0x06003A2F RID: 14895 RVA: 0x00158044 File Offset: 0x00156244
	private adc(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x06003A30 RID: 14896 RVA: 0x0015804C File Offset: 0x0015624C
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x06003A31 RID: 14897 RVA: 0x00158050 File Offset: 0x00156250
	public adc()
	{
	}

	// Token: 0x06003A32 RID: 14898 RVA: 0x00158058 File Offset: 0x00156258
	public void av(c1a A_0, cyt A_1)
	{
		if (A_0 != null)
		{
			cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
			aud aud = A_0.n("lu-b12");
			if (aud != null)
			{
				TimeSpan? primitivePropertyValue = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<TimeSpan>("loc_lu-b12_clearCorpsesTime", null);
				if (!serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("loc_lu-b12_clearCorpses_done", new bool?(false)).Value && serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("quest_fd_KillEnvoyCompleted", new bool?(false)).Value)
				{
					if (!serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("loc_lu-b12_clearCorpses_setTime", new bool?(false)).Value)
					{
						serviceOrThrow.aqu().r()["loc_lu-b12_clearCorpsesTime"] = serviceOrThrow.aqu().p() + TimeSpan.FromMinutes(30.0);
						serviceOrThrow.aqu().r()["loc_lu-b12_clearCorpses_setTime"] = true;
					}
					if (serviceOrThrow.aqu().p() >= primitivePropertyValue)
					{
						foreach (b0b b0b in Enumerable.ToList<b0b>(aud.Entities))
						{
							c5x c5x = (c5x)b0b;
							if (!string.IsNullOrEmpty(c5x.y8()) && c5x.h.b == null && c5x.s.b is c7j && (c5x.y8().EndsWith("- тело") || c5x.y8() == "Останки"))
							{
								c5x.w();
								c5x.an();
							}
							else if (c5x.o.b != null && c5x.o.b.a == "Effects\\BloodPool")
							{
								c5x.w();
								c5x.an();
							}
							else if (c5x.GetAspect<a3f>() != null && c5x.GetAspect<a3f>().a().GetPrimitivePropertyValue<bool>("IsCorpse", new bool?(false)).Value)
							{
								c5x.an();
								c5x.w();
							}
						}
						serviceOrThrow.aqu().r()["loc_lu-b12_clearCorpses_done"] = true;
					}
				}
			}
		}
	}
}

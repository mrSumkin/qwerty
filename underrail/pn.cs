using System;
using System.Linq;
using System.Runtime.Serialization;

// Token: 0x020008EA RID: 2282
[eiz("DCTCF")]
[Serializable]
public sealed class pn : bdw, ISerializable
{
	// Token: 0x06003894 RID: 14484 RVA: 0x0014F208 File Offset: 0x0014D408
	private pn(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x06003895 RID: 14485 RVA: 0x0014F210 File Offset: 0x0014D410
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x06003896 RID: 14486 RVA: 0x0014F214 File Offset: 0x0014D414
	public pn()
	{
	}

	// Token: 0x06003897 RID: 14487 RVA: 0x0014F220 File Offset: 0x0014D420
	public void av(c1a A_0, cyt A_1)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null && !serviceOrThrow.aqu().v().StatusEffects.a(aav.a))
		{
			foreach (aud aud in Enumerable.ToList<aud>(A_0.Areas))
			{
				foreach (b0b b0b in Enumerable.ToList<b0b>(aud.Entities))
				{
					c5x c5x = (c5x)b0b;
					if (c5x.h.b != null && c5x.h.b.aa().FactionId == asp.e6)
					{
						if (c5x.qe() == new Guid("b98c7df9-7051-4ce0-b199-39f6ab4e82ab"))
						{
							c5x.h.b.aa().c(asp.a);
						}
						else
						{
							c5x.w();
							c5x.an();
						}
					}
				}
			}
		}
	}
}

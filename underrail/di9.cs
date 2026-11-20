using System;
using System.Linq;
using System.Runtime.Serialization;

// Token: 0x02000A27 RID: 2599
[eiz("TCHKATIZ")]
[Serializable]
public sealed class di9 : bdw, ISerializable
{
	// Token: 0x06003DC1 RID: 15809 RVA: 0x00172CE0 File Offset: 0x00170EE0
	private di9(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x06003DC2 RID: 15810 RVA: 0x00172CE8 File Offset: 0x00170EE8
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x06003DC3 RID: 15811 RVA: 0x00172CEC File Offset: 0x00170EEC
	public di9()
	{
	}

	// Token: 0x06003DC4 RID: 15812 RVA: 0x00172CF8 File Offset: 0x00170EF8
	public void av(c1a A_0, cyt A_1)
	{
		if (A_0 != null)
		{
			bpo.GetServiceOrThrow<cnk>();
			foreach (aud aud in Enumerable.ToList<aud>(A_0.Areas))
			{
				foreach (b0b b0b in Enumerable.ToList<b0b>(aud.Entities))
				{
					c5x c5x = (c5x)b0b;
					if (c5x != null && c5x.h.b != null && !c5x.h.b.aa().Dead && c5x.h.b.aa().FactionId.StartsWith(asp.es))
					{
						if (c5x.h.b.aa().FactionId == asp.ev)
						{
							c5x.w();
							c5x.an();
						}
						else
						{
							c5x.h.b.aa().a(null, null, false);
						}
					}
				}
			}
		}
	}
}

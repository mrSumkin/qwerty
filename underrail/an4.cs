using System;
using System.Linq;
using System.Runtime.Serialization;

// Token: 0x02000938 RID: 2360
[eiz("RCPP")]
[Serializable]
public sealed class an4 : bdw, ISerializable
{
	// Token: 0x060039D6 RID: 14806 RVA: 0x001560D8 File Offset: 0x001542D8
	private an4(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x060039D7 RID: 14807 RVA: 0x001560E0 File Offset: 0x001542E0
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x060039D8 RID: 14808 RVA: 0x001560E4 File Offset: 0x001542E4
	public an4()
	{
	}

	// Token: 0x060039D9 RID: 14809 RVA: 0x001560F0 File Offset: 0x001542F0
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
					if (c5x != null && c5x.o.b != null && c5x.o.b.a == "Effects\\BloodPool")
					{
						c5x.w();
						c5x.an();
					}
					else if (c5x != null && c5x.GetAspect<a3f>() != null && c5x.GetAspect<a3f>().a().GetPrimitivePropertyValue<bool>("IsCorpse", new bool?(false)).Value)
					{
						c5x.an();
						c5x.w();
					}
				}
			}
		}
	}
}

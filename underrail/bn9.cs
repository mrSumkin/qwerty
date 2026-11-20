using System;
using System.Runtime.Serialization;

// Token: 0x0200097A RID: 2426
[eiz("TCHRPFED")]
[Serializable]
public sealed class bn9 : bdw, ISerializable
{
	// Token: 0x06003AE3 RID: 15075 RVA: 0x0015D768 File Offset: 0x0015B968
	private bn9(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x06003AE4 RID: 15076 RVA: 0x0015D770 File Offset: 0x0015B970
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x06003AE5 RID: 15077 RVA: 0x0015D774 File Offset: 0x0015B974
	public bn9()
	{
	}

	// Token: 0x06003AE6 RID: 15078 RVA: 0x0015D780 File Offset: 0x0015B980
	public void av(c1a A_0, cyt A_1)
	{
		if (A_0 != null)
		{
			aud aud = A_0.n("tch-off");
			if (aud != null)
			{
				c5x c5x = new ar7(new Guid("9768201f-39b7-402f-87e8-393ccf55354d"), aud).ao() as c5x;
				c5x c5x2 = new ar7(new Guid("215fe5c1-6760-4c3c-adca-8d97e62f3ba2"), aud).ao() as c5x;
				if (c5x != null && c5x.GetAspect<c3g>() != null)
				{
					c5x.RemoveAspect<c3g>();
				}
				if (c5x2 != null && c5x2.GetAspect<c3g>() != null)
				{
					c5x2.RemoveAspect<c3g>();
				}
			}
		}
	}
}

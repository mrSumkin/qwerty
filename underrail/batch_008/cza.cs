using System;
using System.Runtime.Serialization;

// Token: 0x02000901 RID: 2305
[eiz("CCUPZGI")]
[Serializable]
public sealed class cza : bdw, ISerializable
{
	// Token: 0x060038F3 RID: 14579 RVA: 0x00151998 File Offset: 0x0014FB98
	private cza(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x060038F4 RID: 14580 RVA: 0x001519A0 File Offset: 0x0014FBA0
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x060038F5 RID: 14581 RVA: 0x001519A4 File Offset: 0x0014FBA4
	public cza()
	{
	}

	// Token: 0x060038F6 RID: 14582 RVA: 0x001519B0 File Offset: 0x0014FBB0
	public void av(c1a A_0, cyt A_1)
	{
		if (A_0 != null)
		{
			aud aud = A_0.n("cc_pz2");
			if (aud != null)
			{
				c5x c5x = new ar7(new Guid("61f255d7-d6f5-438c-9c53-546aba326090"), aud).ao() as c5x;
				c5x c5x2 = new ar7(new Guid("e81fe416-e166-4e0b-9743-d5d56817f692"), aud).ao() as c5x;
				foreach (c5x c5x3 in new c5x[]
				{
					c5x,
					c5x2
				})
				{
					if (c5x3 != null)
					{
						d2b aspect = c5x3.GetAspect<d2b>();
						if (aspect != null && aspect.n())
						{
							aspect.a(true, false);
						}
					}
				}
			}
		}
	}
}

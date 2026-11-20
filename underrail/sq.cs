using System;
using System.Runtime.Serialization;
using Ouroboros.Playfield.References;

// Token: 0x020009B7 RID: 2487
[eiz("LUUWBD2")]
[Serializable]
public sealed class sq : bdw, ISerializable
{
	// Token: 0x06003BD8 RID: 15320 RVA: 0x0016211C File Offset: 0x0016031C
	private sq(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x06003BD9 RID: 15321 RVA: 0x00162124 File Offset: 0x00160324
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x06003BDA RID: 15322 RVA: 0x00162128 File Offset: 0x00160328
	public sq()
	{
	}

	// Token: 0x06003BDB RID: 15323 RVA: 0x00162134 File Offset: 0x00160334
	public void av(c1a A_0, cyt A_1)
	{
		if (A_0 != null)
		{
			aud aud = A_0.n("wbb2");
			if (aud != null)
			{
				d2b d2b = new EntityAspectReference<d2b, d2b>(aud, new Guid("7b40d772-0a1c-4da7-ab26-162f1095ea67")).ao();
				if (d2b != null)
				{
					d2b.a(true, false);
				}
			}
		}
	}
}

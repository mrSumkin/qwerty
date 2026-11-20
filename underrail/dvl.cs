using System;
using System.Runtime.Serialization;
using Ouroboros.Playfield.References;

// Token: 0x0200098D RID: 2445
[eiz("UPUUP5TD")]
[Serializable]
public sealed class dvl : bdw, ISerializable
{
	// Token: 0x06003B30 RID: 15152 RVA: 0x0015F0B8 File Offset: 0x0015D2B8
	private dvl(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x06003B31 RID: 15153 RVA: 0x0015F0C0 File Offset: 0x0015D2C0
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x06003B32 RID: 15154 RVA: 0x0015F0C4 File Offset: 0x0015D2C4
	public dvl()
	{
	}

	// Token: 0x06003B33 RID: 15155 RVA: 0x0015F0CC File Offset: 0x0015D2CC
	public void av(c1a A_0, cyt A_1)
	{
		if (A_0 != null)
		{
			aud aud = A_0.n("up5");
			if (aud != null)
			{
				d2b d2b = new EntityAspectReference<d2b, d2b>(aud, new Guid("9072764e-de0e-4b3c-99e9-b4197d7dd55d")).ao();
				if (d2b != null)
				{
					d2b.a("");
					d2b.a(true, false);
				}
			}
		}
	}
}

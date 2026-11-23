using System;
using System.Runtime.Serialization;
using Ouroboros.Playfield.References;

// Token: 0x0200098C RID: 2444
[eiz("UPUUP5PL")]
[Serializable]
public sealed class do8 : bdw, ISerializable
{
	// Token: 0x06003B2C RID: 15148 RVA: 0x0015F054 File Offset: 0x0015D254
	private do8(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x06003B2D RID: 15149 RVA: 0x0015F05C File Offset: 0x0015D25C
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x06003B2E RID: 15150 RVA: 0x0015F060 File Offset: 0x0015D260
	public do8()
	{
	}

	// Token: 0x06003B2F RID: 15151 RVA: 0x0015F06C File Offset: 0x0015D26C
	public void av(c1a A_0, cyt A_1)
	{
		if (A_0 != null)
		{
			aud aud = A_0.n("up5-pas");
			if (aud != null)
			{
				d2b d2b = new EntityAspectReference<d2b, d2b>(aud, new Guid("2c62393f-89f3-494e-bf70-ade0ad0db8f1")).ao();
				if (d2b != null)
				{
					d2b.a(true, false);
				}
			}
		}
	}
}

using System;
using System.Runtime.Serialization;
using Ouroboros.Playfield.References;

// Token: 0x020009CB RID: 2507
[eiz("FOUEHD1")]
[Serializable]
public sealed class bng : bdw, ISerializable
{
	// Token: 0x06003C27 RID: 15399 RVA: 0x00163768 File Offset: 0x00161968
	private bng(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x06003C28 RID: 15400 RVA: 0x00163770 File Offset: 0x00161970
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x06003C29 RID: 15401 RVA: 0x00163774 File Offset: 0x00161974
	public bng()
	{
	}

	// Token: 0x06003C2A RID: 15402 RVA: 0x0016377C File Offset: 0x0016197C
	public void av(c1a A_0, cyt A_1)
	{
		if (A_0 != null)
		{
			aud aud = A_0.n("fo3");
			if (aud != null)
			{
				b4h b4h = new EntityAspectReference<b4h, b4h>(aud, new Guid("076773f5-8e0e-422d-9616-3c48b2b01f95")).ao();
				if (b4h != null)
				{
					b4h.a(true);
				}
			}
		}
	}
}

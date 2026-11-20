using System;
using System.Runtime.Serialization;
using Ouroboros.Playfield.References;

// Token: 0x020009DF RID: 2527
[eiz("L28")]
[Serializable]
public sealed class aly : bdw, ISerializable
{
	// Token: 0x06003C79 RID: 15481 RVA: 0x001668CC File Offset: 0x00164ACC
	private aly(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x06003C7A RID: 15482 RVA: 0x001668D4 File Offset: 0x00164AD4
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x06003C7B RID: 15483 RVA: 0x001668D8 File Offset: 0x00164AD8
	public aly()
	{
	}

	// Token: 0x06003C7C RID: 15484 RVA: 0x001668E4 File Offset: 0x00164AE4
	public void av(c1a A_0, cyt A_1)
	{
		if (A_0 != null)
		{
			aud aud = A_0.n("WarehouseBlockAlpha1");
			if (aud != null)
			{
				d2b d2b = new EntityAspectReference<d2b, d2b>(aud, new Guid("b1154b8c-e604-4631-b3de-fd8ab8179425")).ao();
				if (d2b != null)
				{
					d2b.e(false);
				}
			}
		}
	}
}

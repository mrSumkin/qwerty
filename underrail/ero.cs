using System;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;

// Token: 0x020009DB RID: 2523
[eiz("JYDWH0")]
[Serializable]
public sealed class ero : bdw, ISerializable
{
	// Token: 0x06003C67 RID: 15463 RVA: 0x001660B0 File Offset: 0x001642B0
	private ero(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x06003C68 RID: 15464 RVA: 0x001660B8 File Offset: 0x001642B8
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x06003C69 RID: 15465 RVA: 0x001660BC File Offset: 0x001642BC
	public ero()
	{
	}

	// Token: 0x06003C6A RID: 15466 RVA: 0x001660C8 File Offset: 0x001642C8
	public void av(c1a A_0, cyt A_1)
	{
		if (A_0 != null)
		{
			aud aud = A_0.n("jyh1");
			ah7 ah = A_0.i("HandLantern");
			ah.Enabled = false;
			ah.d();
			if (aud != null)
			{
				for (int i = 3; i <= 17; i++)
				{
					for (int j = 2; j <= 12; j++)
					{
						ak1 ak = aud.b(i, j);
						if (ak != null && ak.c.Count > 0 && !ak.Formation.c(4L))
						{
							vq.a("objects\\natural\\BigRockPile", A_0, new bt4(aud.y8(), new Vector3((float)i, (float)j, 0f)), false);
						}
					}
				}
			}
		}
	}
}

using System;
using System.Runtime.Serialization;
using Ouroboros.Playfield.References;

// Token: 0x020009D3 RID: 2515
[eiz("MCUB01")]
[Serializable]
public sealed class bq5 : bdw, ISerializable
{
	// Token: 0x06003C47 RID: 15431 RVA: 0x001646B8 File Offset: 0x001628B8
	private bq5(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x06003C48 RID: 15432 RVA: 0x001646C0 File Offset: 0x001628C0
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x06003C49 RID: 15433 RVA: 0x001646C4 File Offset: 0x001628C4
	public bq5()
	{
	}

	// Token: 0x06003C4A RID: 15434 RVA: 0x001646CC File Offset: 0x001628CC
	public void av(c1a A_0, cyt A_1)
	{
		if (A_0 != null)
		{
			aud aud = A_0.n("MushroomCoveNW");
			if (aud != null)
			{
				d2b d2b = new EntityAspectReference<d2b, d2b>(aud, new Guid("0ba8e2e6-7b14-436c-93e1-842240b769a4")).ao();
				if (d2b != null)
				{
					d2b.a(true, false);
				}
				cd0 cd = new EntityAspectReference<cd0, cd0>(aud, new Guid("7c41062c-5c4e-4ea6-9a10-adf4b13935bc")).ao();
				if (cd != null)
				{
					cd.d = new float?(0.92f);
				}
			}
		}
	}
}

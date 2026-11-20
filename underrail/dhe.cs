using System;
using System.Runtime.Serialization;
using Ouroboros.Playfield.References;

// Token: 0x020009CA RID: 2506
[eiz("FOULB1")]
[Serializable]
public sealed class dhe : bdw, ISerializable
{
	// Token: 0x06003C23 RID: 15395 RVA: 0x00163708 File Offset: 0x00161908
	private dhe(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x06003C24 RID: 15396 RVA: 0x00163710 File Offset: 0x00161910
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x06003C25 RID: 15397 RVA: 0x00163714 File Offset: 0x00161914
	public dhe()
	{
	}

	// Token: 0x06003C26 RID: 15398 RVA: 0x0016371C File Offset: 0x0016191C
	public void av(c1a A_0, cyt A_1)
	{
		if (A_0 != null)
		{
			aud aud = A_0.n("fo-bunker");
			if (aud != null)
			{
				d2b d2b = new EntityAspectReference<d2b, d2b>(aud, new Guid("cc1a3e4e-1f43-4f27-88ae-1c8cee24d4eb")).ao();
				if (d2b != null)
				{
					d2b.a(true, false);
				}
			}
		}
	}
}

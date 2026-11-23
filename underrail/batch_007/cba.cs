using System;
using System.Runtime.Serialization;
using Ouroboros.Playfield.References;

// Token: 0x02000911 RID: 2321
[eiz("CCSGU1")]
[Serializable]
public sealed class cba : bdw, ISerializable
{
	// Token: 0x06003933 RID: 14643 RVA: 0x00152E64 File Offset: 0x00151064
	private cba(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x06003934 RID: 14644 RVA: 0x00152E6C File Offset: 0x0015106C
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x06003935 RID: 14645 RVA: 0x00152E70 File Offset: 0x00151070
	public cba()
	{
	}

	// Token: 0x06003936 RID: 14646 RVA: 0x00152E7C File Offset: 0x0015107C
	public void av(c1a A_0, cyt A_1)
	{
		if (A_0 != null)
		{
			aud aud = A_0.n("cc_s5");
			if (aud != null)
			{
				d2b d2b = new EntityAspectReference<d2b, d2b>(aud, new Guid("85d18426-74b7-4820-b7ab-076dd1241930")).ao();
				cnb cnb = new EntityAspectReference<cnb, bim>(aud, new Guid("85d18426-74b7-4820-b7ab-076dd1241930")).ao();
				if (d2b != null)
				{
					d2b.a(true, false);
				}
				if (cnb != null)
				{
					cnb.d(true);
				}
			}
		}
	}
}

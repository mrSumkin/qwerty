using System;
using System.Runtime.Serialization;
using Ouroboros.Playfield.References;

// Token: 0x02000917 RID: 2327
[eiz("CCURFSG")]
[Serializable]
public sealed class an : bdw, ISerializable
{
	// Token: 0x0600394B RID: 14667 RVA: 0x001531C0 File Offset: 0x001513C0
	private an(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x0600394C RID: 14668 RVA: 0x001531C8 File Offset: 0x001513C8
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x0600394D RID: 14669 RVA: 0x001531CC File Offset: 0x001513CC
	public an()
	{
	}

	// Token: 0x0600394E RID: 14670 RVA: 0x001531D8 File Offset: 0x001513D8
	public void av(c1a A_0, cyt A_1)
	{
		if (A_0 != null)
		{
			aud aud = A_0.n("cc_s1");
			if (aud != null)
			{
				d2b d2b = new EntityAspectReference<d2b, d2b>(aud, new Guid("acbf1c69-09e2-4570-99c1-050671a5359b")).ao();
				if (d2b != null)
				{
					d2b.a(true, false);
				}
				cnb cnb = new EntityAspectReference<cnb, bim>(aud, new Guid("acbf1c69-09e2-4570-99c1-050671a5359b")).ao();
				if (cnb != null)
				{
					cnb.d(true);
				}
			}
		}
	}
}

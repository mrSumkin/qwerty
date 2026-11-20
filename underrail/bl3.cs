using System;
using System.IO;
using System.Runtime.Serialization;
using Ouroboros.Playfield.References;

// Token: 0x02000996 RID: 2454
[eiz("UPFDHMDL")]
[Serializable]
public sealed class bl3 : bdw, ISerializable
{
	// Token: 0x06003B54 RID: 15188 RVA: 0x0015F914 File Offset: 0x0015DB14
	private bl3(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x06003B55 RID: 15189 RVA: 0x0015F91C File Offset: 0x0015DB1C
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x06003B56 RID: 15190 RVA: 0x0015F920 File Offset: 0x0015DB20
	public bl3()
	{
	}

	// Token: 0x06003B57 RID: 15191 RVA: 0x0015F92C File Offset: 0x0015DB2C
	public void av(c1a A_0, cyt A_1)
	{
		if (A_0 != null)
		{
			aud aud = A_0.n("up5-pas");
			if (aud != null)
			{
				cnb cnb = new EntityAspectReference<cnb, bim>(aud, new Guid("66e5e0b2-9b11-45f3-840e-2da13a2867e1")).ao();
				d2b d2b = new EntityAspectReference<d2b, d2b>(aud, new Guid("66e5e0b2-9b11-45f3-840e-2da13a2867e1")).ao();
				if (cnb != null && cnb.q())
				{
					cnb.d(false);
				}
				if (d2b != null)
				{
					d2b.a("");
					d2b.e(true);
					d2b.a(true);
				}
				doq a_ = doq.a(Path.Combine(d5x.q(), "up5-pas_l2") + ".uzl");
				aud.Zone.a(a_, 1, null);
			}
		}
	}
}

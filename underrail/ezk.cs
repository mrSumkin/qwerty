using System;
using System.Runtime.Serialization;
using Ouroboros.Playfield.References;

// Token: 0x020009D0 RID: 2512
[eiz("RKLEPA")]
[Serializable]
public sealed class ezk : bdw, ISerializable
{
	// Token: 0x06003C3B RID: 15419 RVA: 0x00163DA8 File Offset: 0x00161FA8
	private ezk(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x06003C3C RID: 15420 RVA: 0x00163DB0 File Offset: 0x00161FB0
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x06003C3D RID: 15421 RVA: 0x00163DB4 File Offset: 0x00161FB4
	public ezk()
	{
	}

	// Token: 0x06003C3E RID: 15422 RVA: 0x00163DC0 File Offset: 0x00161FC0
	public void av(c1a A_0, cyt A_1)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null && A_0 != null)
		{
			serviceOrThrow.aqu().ac();
			aud aud = A_0.n("rkl2");
			if (aud != null)
			{
				csd csd = A_0.g("hunter1");
				csd csd2 = A_0.g("hunter2");
				if (csd != null)
				{
					c5x c5x = vq.a("creature\\characters\\support\\ch_hunter1", csd, true);
					if (c5x != null)
					{
						if (c5x.h.b != null)
						{
							c5x.h.b.aa().FactionId = asp.cx;
						}
						if (c5x.t.b != null)
						{
							c5x.t.b.y6()[ddq.ay] = new bt4("guardAncient");
						}
					}
				}
				if (csd2 != null)
				{
					c5x c5x2 = vq.a("creature\\characters\\support\\ch_hunter2", csd2, true);
					if (c5x2 != null)
					{
						if (c5x2.h.b != null)
						{
							c5x2.h.b.aa().FactionId = asp.cx;
						}
						if (c5x2.t.b != null)
						{
							c5x2.t.b.y6()[ddq.ay] = new bt4("guardAlpha");
						}
					}
				}
				cnb cnb = new EntityAspectReference<cnb, bim>(aud, new Guid("ca1d944e-3bb1-4ce3-8dad-59ebcff78131")).ao();
				cnb cnb2 = new EntityAspectReference<cnb, bim>(aud, new Guid("054110c0-7d2c-4669-82a8-0dd99cdc7b95")).ao();
				if (cnb != null)
				{
					cnb.d(true);
				}
				if (cnb2 != null)
				{
					cnb2.d(true);
				}
				bpo.GetServiceOrThrow<ps>().am3("Rkl_EdgarAndPlayerArrive");
			}
		}
	}
}

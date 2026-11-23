using System;
using System.Runtime.Serialization;
using Ouroboros.Playfield.References;

// Token: 0x02000903 RID: 2307
[eiz("CCSLDL")]
[Serializable]
public sealed class a7h : bdw, ISerializable
{
	// Token: 0x060038FB RID: 14587 RVA: 0x00151BA4 File Offset: 0x0014FDA4
	private a7h(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x060038FC RID: 14588 RVA: 0x00151BAC File Offset: 0x0014FDAC
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x060038FD RID: 14589 RVA: 0x00151BB0 File Offset: 0x0014FDB0
	public a7h()
	{
	}

	// Token: 0x060038FE RID: 14590 RVA: 0x00151BBC File Offset: 0x0014FDBC
	public void av(c1a A_0, cyt A_1)
	{
		if (A_0 != null)
		{
			aud aud = A_0.n("cc5");
			if (aud != null)
			{
				cnb cnb = new EntityAspectReference<cnb, bim>(aud, new Guid("85d18426-74b7-4820-b7ab-076dd1241930")).ao();
				d2b d2b = new EntityAspectReference<d2b, d2b>(aud, new Guid("85d18426-74b7-4820-b7ab-076dd1241930")).ao();
				if (cnb != null && cnb.q())
				{
					cnb.d(false);
				}
				if (d2b != null)
				{
					d2b.e(true);
					d2b.a(10);
				}
			}
		}
	}
}

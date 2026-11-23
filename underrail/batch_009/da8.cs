using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Ouroboros.Playfield.References;

// Token: 0x02000B5F RID: 2911
[eiz("OO")]
[Serializable]
public sealed class da8 : cze, ISerializable
{
	// Token: 0x060042A7 RID: 17063 RVA: 0x0019DA40 File Offset: 0x0019BC40
	private da8(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x060042A8 RID: 17064 RVA: 0x0019DA4C File Offset: 0x0019BC4C
	public da8()
	{
	}

	// Token: 0x060042A9 RID: 17065 RVA: 0x0019DA54 File Offset: 0x0019BC54
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null && serviceOrThrow.aqw() != null)
		{
			aud aud = serviceOrThrow.aqw().n("ojy-u1");
			if (aud != null)
			{
				d2b d2b = new EntityAspectReference<d2b, d2b>(aud, new Guid("6e720b16-b0cd-4502-a086-2e63cbf66343")).ao();
				d2b d2b2 = new EntityAspectReference<d2b, d2b>(aud, new Guid("b69172ff-2c63-402d-89e4-bcd3f0103a0f")).ao();
				if (d2b != null && d2b2 != null)
				{
					bool value = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("remote_lock_ojy_k6", new bool?(false)).Value;
					d2b.e(value);
					d2b2.e(value);
				}
			}
		}
	}
}

using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Ouroboros.Playfield.References;

// Token: 0x02000B5E RID: 2910
[eiz("OO1")]
[Serializable]
public sealed class etn : cze, ISerializable
{
	// Token: 0x060042A4 RID: 17060 RVA: 0x0019D978 File Offset: 0x0019BB78
	private etn(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x060042A5 RID: 17061 RVA: 0x0019D984 File Offset: 0x0019BB84
	public etn()
	{
	}

	// Token: 0x060042A6 RID: 17062 RVA: 0x0019D990 File Offset: 0x0019BB90
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null && serviceOrThrow.aqw() != null)
		{
			aud aud = serviceOrThrow.aqw().n("ojy3");
			if (aud != null)
			{
				d2b d2b = new EntityAspectReference<d2b, d2b>(aud, new Guid("faf9bf95-ddb5-44ee-b7bc-a2d8c446677c")).ao();
				d2b d2b2 = new EntityAspectReference<d2b, d2b>(aud, new Guid("e05fd00c-301d-4b4c-829f-1c534383371d")).ao();
				if (d2b != null && d2b2 != null)
				{
					bool value = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("remote_lock_ojy_k3", new bool?(false)).Value;
					d2b.e(value);
					d2b2.e(value);
				}
			}
		}
	}
}

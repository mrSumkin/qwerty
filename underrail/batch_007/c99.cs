using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Ouroboros.Playfield.References;

// Token: 0x02000A91 RID: 2705
[eiz("LUMBTDJ")]
[Serializable]
public sealed class c99 : cze, ISerializable
{
	// Token: 0x06003F79 RID: 16249 RVA: 0x00180EBC File Offset: 0x0017F0BC
	private c99(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06003F7A RID: 16250 RVA: 0x00180EC8 File Offset: 0x0017F0C8
	public c99()
	{
	}

	// Token: 0x06003F7B RID: 16251 RVA: 0x00180ED4 File Offset: 0x0017F0D4
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null && serviceOrThrow.aqw() != null)
		{
			aud aud = serviceOrThrow.aqw().n("lux-md");
			if (aud != null)
			{
				EntityAspectReference<cnb, bim> entityAspectReference = new EntityAspectReference<cnb, bim>(aud, new Guid("9d582189-9d8d-4a75-96dd-24aae4146ebf"));
				EntityAspectReference<d2b, d2b> entityAspectReference2 = new EntityAspectReference<d2b, d2b>(aud, new Guid("9d582189-9d8d-4a75-96dd-24aae4146ebf"));
				EntityAspectReference<cd0, cd0> entityAspectReference3 = new EntityAspectReference<cd0, cd0>(aud, new Guid("692fcc3f-8a24-4ece-8557-08c9fb4fa45c"));
				if (entityAspectReference.ao() != null && entityAspectReference3.ao() != null && entityAspectReference2.ao() != null)
				{
					entityAspectReference3.ao().d = new float?(0f);
					entityAspectReference2.ao().a(null);
					entityAspectReference2.ao().e(false);
				}
			}
		}
	}
}

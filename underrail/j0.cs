using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x02000A96 RID: 2710
[eiz("SGSMCF")]
[Serializable]
public sealed class j0 : cze, ISerializable
{
	// Token: 0x06003F8B RID: 16267 RVA: 0x00181E28 File Offset: 0x00180028
	private j0(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06003F8C RID: 16268 RVA: 0x00181E34 File Offset: 0x00180034
	public j0()
	{
	}

	// Token: 0x06003F8D RID: 16269 RVA: 0x00181E40 File Offset: 0x00180040
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		c5x c5x = serviceOrThrow.aqu().v().b() as c5x;
		if (serviceOrThrow.aqu() != null && c5x != null)
		{
			c5x c5x2 = new ar7(new Guid("bad8f763-91ac-4ae0-9c9b-bfc937c5dff1"), c5x.Area).ao() as c5x;
			if (c5x2 != null)
			{
				amc aspect = c5x2.GetAspect<amc>();
				if (aspect != null)
				{
					aspect.aa().FactionId = "bandits";
				}
			}
		}
	}
}

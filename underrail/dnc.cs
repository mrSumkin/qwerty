using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Ouroboros.Playfield.References;

// Token: 0x02000B45 RID: 2885
[eiz("S35")]
[Serializable]
public sealed class dnc : cze, ISerializable
{
	// Token: 0x0600424C RID: 16972 RVA: 0x0019AF2C File Offset: 0x0019912C
	private dnc(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x0600424D RID: 16973 RVA: 0x0019AF38 File Offset: 0x00199138
	public dnc()
	{
	}

	// Token: 0x0600424E RID: 16974 RVA: 0x0019AF44 File Offset: 0x00199144
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		if (A_0 != null)
		{
			aud aud = A_0.Area;
			if (aud != null && aud.Zone != null)
			{
				new List<coh>();
				new EntityAspectReference<c7j, bim>(aud, new Guid("c7004858-1bfa-46fb-84cc-2815b313ea3a"));
			}
		}
	}
}

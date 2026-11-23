using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;

// Token: 0x02000535 RID: 1333
[eiz("IPE")]
[Serializable]
public sealed class beh : dkb, ISerializable
{
	// Token: 0x0600222D RID: 8749 RVA: 0x000B5214 File Offset: 0x000B3414
	private beh(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		if (ell.a() == 0)
		{
			base.GetType() == typeof(beh);
		}
	}

	// Token: 0x0600222E RID: 8750 RVA: 0x000B5240 File Offset: 0x000B3440
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
	}

	// Token: 0x0600222F RID: 8751 RVA: 0x000B524C File Offset: 0x000B344C
	public beh(coh A_0) : base(A_0)
	{
	}

	// Token: 0x06002230 RID: 8752 RVA: 0x000B5258 File Offset: 0x000B3458
	public override ecs se()
	{
		if (base.c() != null && base.c().Definition != null)
		{
			ecs ecs = new ecs(new List<dl6>
			{
				new dl6(new List<bph>
				{
					new bph(new d22(b94.a(), new Color(0, 255, 0)), "Куплен предмет: ", null)
				})
			});
			base.a(ecs.a[0]);
			return ecs;
		}
		return null;
	}
}

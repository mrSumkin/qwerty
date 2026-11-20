using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;

// Token: 0x02000531 RID: 1329
[eiz("IAE")]
[Serializable]
public sealed class bou : dkb, ISerializable
{
	// Token: 0x06002219 RID: 8729 RVA: 0x000B4EB4 File Offset: 0x000B30B4
	private bou(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x0600221A RID: 8730 RVA: 0x000B4EC0 File Offset: 0x000B30C0
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
	}

	// Token: 0x0600221B RID: 8731 RVA: 0x000B4ECC File Offset: 0x000B30CC
	public bou(coh A_0) : base(A_0)
	{
	}

	// Token: 0x0600221C RID: 8732 RVA: 0x000B4ED8 File Offset: 0x000B30D8
	public override ecs se()
	{
		if (base.c() != null && base.c().Definition != null)
		{
			ecs ecs = new ecs(new List<dl6>
			{
				new dl6(new List<bph>
				{
					new bph(new d22(b94.a(), new Color(0, 255, 0)), "Получен предмет: ", null)
				})
			});
			base.a(ecs.a[0]);
			return ecs;
		}
		return null;
	}
}

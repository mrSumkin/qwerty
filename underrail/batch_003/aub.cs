using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;

// Token: 0x02000533 RID: 1331
[eiz("ILE")]
[Serializable]
public sealed class aub : dkb, ISerializable
{
	// Token: 0x06002225 RID: 8741 RVA: 0x000B508C File Offset: 0x000B328C
	private aub(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		if (ell.a() == 0)
		{
			base.GetType() == typeof(aub);
		}
	}

	// Token: 0x06002226 RID: 8742 RVA: 0x000B50B8 File Offset: 0x000B32B8
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
	}

	// Token: 0x06002227 RID: 8743 RVA: 0x000B50C4 File Offset: 0x000B32C4
	public aub(coh A_0) : base(A_0)
	{
	}

	// Token: 0x06002228 RID: 8744 RVA: 0x000B50D0 File Offset: 0x000B32D0
	public override ecs se()
	{
		if (base.c() != null && base.c().Definition != null)
		{
			ecs ecs = new ecs(new List<dl6>
			{
				new dl6(new List<bph>
				{
					new bph(new d22(b94.a(), new Color(0, 255, 0)), "Потерян предмет: ", null)
				})
			});
			base.a(ecs.a[0]);
			return ecs;
		}
		return null;
	}
}

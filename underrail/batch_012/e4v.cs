using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;

// Token: 0x02000534 RID: 1332
[eiz("ISE")]
[Serializable]
public sealed class e4v : dkb, ISerializable
{
	// Token: 0x06002229 RID: 8745 RVA: 0x000B5150 File Offset: 0x000B3350
	private e4v(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		if (ell.a() == 0)
		{
			base.GetType() == typeof(e4v);
		}
	}

	// Token: 0x0600222A RID: 8746 RVA: 0x000B517C File Offset: 0x000B337C
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
	}

	// Token: 0x0600222B RID: 8747 RVA: 0x000B5188 File Offset: 0x000B3388
	public e4v(coh A_0) : base(A_0)
	{
	}

	// Token: 0x0600222C RID: 8748 RVA: 0x000B5194 File Offset: 0x000B3394
	public override ecs se()
	{
		if (base.c() != null && base.c().Definition != null)
		{
			ecs ecs = new ecs(new List<dl6>
			{
				new dl6(new List<bph>
				{
					new bph(new d22(b94.a(), new Color(0, 255, 0)), "Продан предмет: ", null)
				})
			});
			base.a(ecs.a[0]);
			return ecs;
		}
		return null;
	}
}

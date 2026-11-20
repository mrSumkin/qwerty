using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;
using TimelapseVertigo.Common;

// Token: 0x0200052E RID: 1326
[eiz("MRE")]
[Serializable]
public sealed class cnl : cb7, b2h, ISerializable
{
	// Token: 0x06002207 RID: 8711 RVA: 0x000B4C74 File Offset: 0x000B2E74
	private cnl(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		if (ell.a() == 0)
		{
			base.GetType() == typeof(cnl);
		}
	}

	// Token: 0x06002208 RID: 8712 RVA: 0x000B4CA0 File Offset: 0x000B2EA0
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
	}

	// Token: 0x06002209 RID: 8713 RVA: 0x000B4CAC File Offset: 0x000B2EAC
	public cnl(cqh A_0) : base(A_0)
	{
	}

	// Token: 0x0600220A RID: 8714 RVA: 0x000B4CB8 File Offset: 0x000B2EB8
	public bool a()
	{
		return false;
	}

	// Token: 0x0600220B RID: 8715 RVA: 0x000B4CC0 File Offset: 0x000B2EC0
	public List<string> b()
	{
		return new List<string>
		{
			TimelapseTextFeeds.Chat.ToString(),
			TimelapseTextFeeds.Combat.ToString()
		};
	}

	// Token: 0x0600220C RID: 8716 RVA: 0x000B4CFC File Offset: 0x000B2EFC
	public ecs se()
	{
		if (base.c() != null)
		{
			return new ecs(new List<dl6>
			{
				new dl6(new List<bph>
				{
					new bph(bvm.a(), "- Получено новое сообщение: ", null),
					new bph(bvm.a(new Color(0, 255, 0)), base.c().Name, null)
				})
			});
		}
		return null;
	}
}

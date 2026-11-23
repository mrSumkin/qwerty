using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;
using TimelapseVertigo.Common;

// Token: 0x0200052C RID: 1324
[eiz("DDE")]
[Serializable]
public sealed class e09 : cb7, b2h, ISerializable
{
	// Token: 0x060021FB RID: 8699 RVA: 0x000B4A7C File Offset: 0x000B2C7C
	private e09(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		if (ell.a() == 0)
		{
			base.GetType() == typeof(e09);
		}
	}

	// Token: 0x060021FC RID: 8700 RVA: 0x000B4AA8 File Offset: 0x000B2CA8
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
	}

	// Token: 0x060021FD RID: 8701 RVA: 0x000B4AB4 File Offset: 0x000B2CB4
	public e09(cqh A_0) : base(A_0)
	{
	}

	// Token: 0x060021FE RID: 8702 RVA: 0x000B4AC0 File Offset: 0x000B2CC0
	public bool a()
	{
		return false;
	}

	// Token: 0x060021FF RID: 8703 RVA: 0x000B4AC8 File Offset: 0x000B2CC8
	public List<string> b()
	{
		return new List<string>
		{
			TimelapseTextFeeds.Chat.ToString(),
			TimelapseTextFeeds.Combat.ToString()
		};
	}

	// Token: 0x06002200 RID: 8704 RVA: 0x000B4B04 File Offset: 0x000B2D04
	public ecs se()
	{
		if (base.c() != null)
		{
			return new ecs(new List<dl6>
			{
				new dl6(new List<bph>
				{
					new bph(bvm.a(), "- Новый документ загружен:х20", null),
					new bph(bvm.a(new Color(0, 255, 0)), base.c().Name, null)
				})
			});
		}
		return null;
	}
}

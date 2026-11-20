using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;
using TimelapseVertigo.Common;

// Token: 0x0200052D RID: 1325
[eiz("LEDE")]
[Serializable]
public sealed class elm : cb7, b2h, ISerializable
{
	// Token: 0x06002201 RID: 8705 RVA: 0x000B4B78 File Offset: 0x000B2D78
	private elm(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		if (ell.a() == 0)
		{
			base.GetType() == typeof(elm);
		}
	}

	// Token: 0x06002202 RID: 8706 RVA: 0x000B4BA4 File Offset: 0x000B2DA4
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
	}

	// Token: 0x06002203 RID: 8707 RVA: 0x000B4BB0 File Offset: 0x000B2DB0
	public elm(cqh A_0) : base(A_0)
	{
	}

	// Token: 0x06002204 RID: 8708 RVA: 0x000B4BBC File Offset: 0x000B2DBC
	public bool a()
	{
		return false;
	}

	// Token: 0x06002205 RID: 8709 RVA: 0x000B4BC4 File Offset: 0x000B2DC4
	public List<string> b()
	{
		return new List<string>
		{
			TimelapseTextFeeds.Chat.ToString(),
			TimelapseTextFeeds.Combat.ToString()
		};
	}

	// Token: 0x06002206 RID: 8710 RVA: 0x000B4C00 File Offset: 0x000B2E00
	public ecs se()
	{
		if (base.c() != null)
		{
			return new ecs(new List<dl6>
			{
				new dl6(new List<bph>
				{
					new bph(bvm.a(), "- Добавлена новая запись в журнале:х20", null),
					new bph(bvm.a(new Color(0, 255, 0)), base.c().Name, null)
				})
			});
		}
		return null;
	}
}

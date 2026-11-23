using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;

// Token: 0x0200052F RID: 1327
[eiz("QFE")]
[Serializable]
public sealed class cwz : dul, ISerializable
{
	// Token: 0x0600220D RID: 8717 RVA: 0x000B4D70 File Offset: 0x000B2F70
	private cwz(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x0600220E RID: 8718 RVA: 0x000B4D7C File Offset: 0x000B2F7C
	public cwz(eei A_0) : base(A_0)
	{
	}

	// Token: 0x0600220F RID: 8719 RVA: 0x000B4D88 File Offset: 0x000B2F88
	public override ecs h6()
	{
		return new ecs(new List<dl6>
		{
			new dl6(new List<bph>
			{
				new bph(new d22(b94.a(), Color.Yellow), "Запись в журнале закрыта: ", null),
				new bph(new d22(b94.a(), adi.c), base.e().Name, null)
			})
		});
	}
}

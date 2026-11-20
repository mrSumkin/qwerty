using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;

// Token: 0x02000537 RID: 1335
[eiz("QCE")]
[Serializable]
public sealed class cd5 : dul, ISerializable
{
	// Token: 0x06002233 RID: 8755 RVA: 0x000B5354 File Offset: 0x000B3554
	private cd5(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06002234 RID: 8756 RVA: 0x000B5360 File Offset: 0x000B3560
	public cd5(eei A_0) : base(A_0)
	{
	}

	// Token: 0x06002235 RID: 8757 RVA: 0x000B536C File Offset: 0x000B356C
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

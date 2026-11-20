using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;

// Token: 0x02000538 RID: 1336
[eiz("QAE")]
[Serializable]
public sealed class bxa : dul, ISerializable
{
	// Token: 0x06002236 RID: 8758 RVA: 0x000B53DC File Offset: 0x000B35DC
	private bxa(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06002237 RID: 8759 RVA: 0x000B53E8 File Offset: 0x000B35E8
	public bxa(eei A_0) : base(A_0)
	{
	}

	// Token: 0x06002238 RID: 8760 RVA: 0x000B53F4 File Offset: 0x000B35F4
	public override ecs h6()
	{
		return new ecs(new List<dl6>
		{
			new dl6(new List<bph>
			{
				new bph(new d22(b94.a(), Color.Yellow), "Новая запись в журнале: ", null),
				new bph(new d22(b94.a(), adi.c), base.e().Name, null)
			})
		});
	}
}

using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;

// Token: 0x02000536 RID: 1334
public sealed class j6 : dul
{
	// Token: 0x06002231 RID: 8753 RVA: 0x000B52D8 File Offset: 0x000B34D8
	public j6(eei A_0) : base(A_0)
	{
	}

	// Token: 0x06002232 RID: 8754 RVA: 0x000B52E4 File Offset: 0x000B34E4
	public override ecs h6()
	{
		return new ecs(new List<dl6>
		{
			new dl6(new List<bph>
			{
				new bph(new d22(b94.a(), Color.Yellow), "Запись в журнале обновлена: ", null),
				new bph(new d22(b94.a(), adi.c), base.e().Name, null)
			})
		});
	}
}

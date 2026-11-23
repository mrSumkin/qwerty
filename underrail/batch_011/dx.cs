using System;
using System.Collections.Generic;
using TimelapseVertigo.Common;

// Token: 0x0200051C RID: 1308
public sealed class dx : c47, b2h
{
	// Token: 0x060021AF RID: 8623 RVA: 0x000B3C2C File Offset: 0x000B1E2C
	public ecs c()
	{
		return this.a;
	}

	// Token: 0x060021B0 RID: 8624 RVA: 0x000B3C34 File Offset: 0x000B1E34
	public bool a()
	{
		return true;
	}

	// Token: 0x060021B1 RID: 8625 RVA: 0x000B3C38 File Offset: 0x000B1E38
	public dx(ecs A_0)
	{
		czh.a(A_0, "text");
		this.a = A_0;
	}

	// Token: 0x060021B2 RID: 8626 RVA: 0x000B3C54 File Offset: 0x000B1E54
	public List<string> b()
	{
		return new List<string>
		{
			TimelapseTextFeeds.Chat.ToString()
		};
	}

	// Token: 0x060021B3 RID: 8627 RVA: 0x000B3C7C File Offset: 0x000B1E7C
	public ecs se()
	{
		return this.a;
	}

	// Token: 0x0400145C RID: 5212
	private ecs a;
}

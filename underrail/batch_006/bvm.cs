using System;
using Microsoft.Xna.Framework;

// Token: 0x020004A0 RID: 1184
public static class bvm
{
	// Token: 0x06001E26 RID: 7718 RVA: 0x000A6EE8 File Offset: 0x000A50E8
	public static d22 a(Color A_0)
	{
		if (egg.v)
		{
			return new d22(egg.n, A_0);
		}
		return new d22(egg.ak, A_0);
	}

	// Token: 0x06001E27 RID: 7719 RVA: 0x000A6F0C File Offset: 0x000A510C
	public static d22 a()
	{
		if (egg.v)
		{
			return new d22(egg.n, Color.White);
		}
		return new d22(egg.ak, Color.White);
	}
}

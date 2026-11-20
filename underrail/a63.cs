using System;
using Ouroboros.Playfield.Space;

// Token: 0x02000249 RID: 585
public static class a63
{
	// Token: 0x06001097 RID: 4247 RVA: 0x000448F8 File Offset: 0x00042AF8
	public static HorizontalDirection b(HorizontalDirection A_0)
	{
		int result;
		if ((result = (int)(A_0 + 1)) > 7)
		{
			result = 0;
		}
		return (HorizontalDirection)result;
	}

	// Token: 0x06001098 RID: 4248 RVA: 0x00044918 File Offset: 0x00042B18
	public static HorizontalDirection a(HorizontalDirection A_0)
	{
		int result;
		if ((result = A_0 - HorizontalDirection.Northeast) < 0)
		{
			result = 7;
		}
		return (HorizontalDirection)result;
	}
}

using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Ouroboros.Playfield.Lightning;

// Token: 0x0200023C RID: 572
public static class aac
{
	// Token: 0x06001033 RID: 4147 RVA: 0x0004337C File Offset: 0x0004157C
	public static Color a(aud A_0, IEnumerable<c3y> A_1)
	{
		Color color = A_0.StartingLightning;
		foreach (c3y c3y in A_1)
		{
			if (c3y != null && c3y.a() != null)
			{
				if (c3y.a().aej().a() == LightType.Absolute)
				{
					color = c3y.a().aej().b();
					break;
				}
				if (c3y.a().aej().a() == LightType.Increment)
				{
					color = aac.b(color, c3y.a().aej().b());
				}
				else
				{
					color = aac.a(color, c3y.a().aej().b());
				}
			}
		}
		color = new Color((int)((byte)d05.a((int)A_0.MinimalLightning.R, (int)color.R, (int)A_0.MaximalLightning.R)), (int)((byte)d05.a((int)A_0.MinimalLightning.G, (int)color.G, (int)A_0.MaximalLightning.G)), (int)((byte)d05.a((int)A_0.MinimalLightning.B, (int)color.B, (int)A_0.MaximalLightning.B)));
		return color;
	}

	// Token: 0x06001034 RID: 4148 RVA: 0x000434F0 File Offset: 0x000416F0
	private static Color b(Color A_0, Color A_1)
	{
		return new Color((int)aac.a((int)(A_0.R + A_1.R)), (int)aac.a((int)(A_0.G + A_1.G)), (int)aac.a((int)(A_0.B + A_1.B)));
	}

	// Token: 0x06001035 RID: 4149 RVA: 0x00043540 File Offset: 0x00041740
	private static Color a(Color A_0, Color A_1)
	{
		return new Color((int)aac.a((int)(A_0.R - A_1.R)), (int)aac.a((int)(A_0.G - A_1.G)), (int)aac.a((int)(A_0.B - A_1.B)));
	}

	// Token: 0x06001036 RID: 4150 RVA: 0x00043590 File Offset: 0x00041790
	private static byte a(int A_0)
	{
		if (A_0 < 0)
		{
			return 0;
		}
		if (A_0 > 255)
		{
			return byte.MaxValue;
		}
		return (byte)A_0;
	}
}

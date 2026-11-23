using System;
using Microsoft.Xna.Framework.Graphics;

// Token: 0x02000777 RID: 1911
[aut("MapHighlight")]
public class dh : cmk
{
	// Token: 0x06003076 RID: 12406 RVA: 0x0012B010 File Offset: 0x00129210
	public Effect d3(cne A_0, a7m A_1)
	{
		return A_0.GetResource<Effect>("Shaders\\MapHighlight", new double?((double)-1));
	}

	// Token: 0x06003077 RID: 12407 RVA: 0x0012B028 File Offset: 0x00129228
	public void d4(Effect A_0, a2f A_1, a7m A_2)
	{
		if (A_0 != null && A_1 != null && A_1.d != null)
		{
			A_0.Parameters["dx"].SetValue(1f / (float)A_1.d.a().Width);
			A_0.Parameters["dy"].SetValue(1f / (float)A_1.d.a().Height);
		}
		else
		{
			A_0.Parameters["dx"].SetValue(1f);
			A_0.Parameters["dy"].SetValue(1f);
		}
		A_0.Parameters["HighlightColor"].SetValue(adi.c.ToVector4());
		dpp service = bpo.GetService<dpp>();
		if (service != null)
		{
			A_0.Parameters["HighlightFactor"].SetValue(0.5f * (float)Math.Min(1.0, service.u8() / 1000.0));
			return;
		}
		A_0.Parameters["HighlightFactor"].SetValue(0f);
	}
}

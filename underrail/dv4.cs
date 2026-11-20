using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

// Token: 0x02000779 RID: 1913
[aut("OutlineInner")]
public class dv4 : cmk
{
	// Token: 0x0600307C RID: 12412 RVA: 0x0012B25C File Offset: 0x0012945C
	public Effect d3(cne A_0, a7m A_1)
	{
		return A_0.GetResource<Effect>("Shaders\\OutlineInner", new double?((double)-1));
	}

	// Token: 0x0600307D RID: 12413 RVA: 0x0012B274 File Offset: 0x00129474
	public void d4(Effect A_0, a2f A_1, a7m A_2)
	{
		if (A_0 != null && A_1 != null && A_1.d != null)
		{
			A_0.Parameters["dx"].SetValue(1f / (float)A_1.d.a().Width);
			A_0.Parameters["dy"].SetValue(1f / (float)A_1.d.a().Height);
			float value = ((float)A_1.c.Top + 0.5f) / (float)A_1.d.a().Height;
			float value2 = ((float)A_1.c.Bottom - 0.5f) / (float)A_1.d.a().Height;
			float value3 = ((float)A_1.c.Left + 0.5f) / (float)A_1.d.a().Width;
			float value4 = ((float)A_1.c.Right + 0.5f) / (float)A_1.d.a().Width;
			A_0.Parameters["top"].SetValue(value);
			A_0.Parameters["bottom"].SetValue(value2);
			A_0.Parameters["left"].SetValue(value3);
			A_0.Parameters["right"].SetValue(value4);
		}
		else
		{
			A_0.Parameters["dx"].SetValue(1f);
			A_0.Parameters["dy"].SetValue(1f);
		}
		if (A_1.v != null)
		{
			object obj;
			A_1.v.TryGetValue("OutlineColor", out obj);
			if (obj is Color)
			{
				A_0.Parameters["OutlineColor"].SetValue(((Color)obj).ToVector4());
			}
		}
	}
}

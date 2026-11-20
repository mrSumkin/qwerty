using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

// Token: 0x0200077A RID: 1914
[aut("Outline")]
public class bl7 : cmk
{
	// Token: 0x0600307F RID: 12415 RVA: 0x0012B46C File Offset: 0x0012966C
	public Effect d3(cne A_0, a7m A_1)
	{
		return A_0.GetResource<Effect>("Shaders\\Outline", new double?((double)-1));
	}

	// Token: 0x06003080 RID: 12416 RVA: 0x0012B480 File Offset: 0x00129680
	public void d4(Effect A_0, a2f A_1, a7m A_2)
	{
		if (A_0 != null && A_1 != null && A_1.d != null)
		{
			by8 by = A_1.d as by8;
			if (by != null)
			{
				if (by.i == null && by.m != null)
				{
					by.i = by.m.i;
				}
				if (by.i != null)
				{
					A_0.Parameters["dx"].SetValue(1f / (float)by.i.Width);
					A_0.Parameters["dy"].SetValue(1f / (float)by.i.Height);
					float value = 0f;
					float value2 = 1f;
					A_0.Parameters["top"].SetValue(value);
					A_0.Parameters["bottom"].SetValue(value2);
				}
			}
			else
			{
				A_0.Parameters["dx"].SetValue(1f / (float)A_1.d.a().Width);
				A_0.Parameters["dy"].SetValue(1f / (float)A_1.d.a().Height);
				float value3 = (float)(A_1.c.Top + 1) / (float)A_1.d.a().Height;
				float value4 = (float)(A_1.c.Bottom - 1) / (float)A_1.d.a().Height;
				A_0.Parameters["top"].SetValue(value3);
				A_0.Parameters["bottom"].SetValue(value4);
			}
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

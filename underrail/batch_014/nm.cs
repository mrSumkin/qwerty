using System;
using Microsoft.Xna.Framework.Graphics;

// Token: 0x02000778 RID: 1912
[aut("MapOutline")]
public class nm : cmk
{
	// Token: 0x06003079 RID: 12409 RVA: 0x0012B168 File Offset: 0x00129368
	public Effect d3(cne A_0, a7m A_1)
	{
		return A_0.GetResource<Effect>("Shaders\\MapOutline", new double?((double)-1));
	}

	// Token: 0x0600307A RID: 12410 RVA: 0x0012B17C File Offset: 0x0012937C
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
		A_0.Parameters["OutlineColor"].SetValue(adi.c.ToVector4());
	}
}

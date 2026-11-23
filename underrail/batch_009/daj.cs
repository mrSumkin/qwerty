using System;
using Microsoft.Xna.Framework.Input;

// Token: 0x020001AF RID: 431
[dmo(DisplayName = "Gametop", Description = "Fame surface area container.", InitialWidth = 200, InitialHeight = 200)]
public class daj : amm
{
	// Token: 0x06000C3D RID: 3133 RVA: 0x00032310 File Offset: 0x00030510
	public daj()
	{
		((btr)this).a(true);
	}

	// Token: 0x06000C3E RID: 3134 RVA: 0x00032320 File Offset: 0x00030520
	public override bool iz(MouseState A_0)
	{
		bef service = bpo.GetService<bef>();
		if (service != null)
		{
			esj esj = service.k4();
			return A_0.X >= 0 && A_0.Y >= 0 && A_0.X < esj.c && A_0.Y < esj.d;
		}
		return true;
	}
}

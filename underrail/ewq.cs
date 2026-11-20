using System;
using System.IO;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

// Token: 0x0200057A RID: 1402
public sealed class ewq : amm
{
	// Token: 0x06002436 RID: 9270 RVA: 0x000CAAB8 File Offset: 0x000C8CB8
	public ewq()
	{
		Texture2D texture2D = this.a();
		if (texture2D != null)
		{
			base.Size = new esj(texture2D.Width, texture2D.Height);
		}
		else
		{
			base.Size = new esj(1024, 768);
		}
		this.Focusable = true;
	}

	// Token: 0x06002437 RID: 9271 RVA: 0x000CAB10 File Offset: 0x000C8D10
	protected override void vt(object A_0, b25 A_1)
	{
		base.vt(A_0, A_1);
		if (A_1.b() == eoo.d)
		{
			this.Focusable = false;
			base.z();
		}
	}

	// Token: 0x06002438 RID: 9272 RVA: 0x000CAB34 File Offset: 0x000C8D34
	protected override void i0()
	{
		base.i0();
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null)
		{
			serviceOrThrow.aqu().r()["sys_readHelp"] = true;
		}
	}

	// Token: 0x06002439 RID: 9273 RVA: 0x000CAB74 File Offset: 0x000C8D74
	protected override void g6(object A_0, ane A_1)
	{
		base.g6(A_0, A_1);
		if (A_1.a != Keys.F1)
		{
			this.Focusable = false;
			base.z();
		}
	}

	// Token: 0x0600243A RID: 9274 RVA: 0x000CAB9C File Offset: 0x000C8D9C
	public override void iv(e6d A_0, cp9 A_1)
	{
		Texture2D texture2D = this.a();
		if (texture2D != null)
		{
			Vector2 a_ = base.at().b();
			A_1.b().w4(texture2D, a_, Color.White);
		}
		base.iv(A_0, A_1);
	}

	// Token: 0x0600243B RID: 9275 RVA: 0x000CABDC File Offset: 0x000C8DDC
	private Texture2D a()
	{
		string text = Path.Combine(d5x.d, "InterfaceHelp");
		if (!wj.a().c())
		{
			bef service = bpo.GetService<bef>();
			if (service != null)
			{
				esj esj = service.k4();
				if (esj.c >= 1920 && esj.d >= 1080)
				{
					text += "_l";
				}
				else
				{
					text += "_s";
				}
			}
		}
		return bpo.GetServiceOrThrow<cne>().us(text, new double?((double)-1));
	}
}

using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

// Token: 0x0200201C RID: 8220
public sealed class cxh : euz
{
	// Token: 0x0600C28A RID: 49802 RVA: 0x00435B74 File Offset: 0x00433D74
	public string a()
	{
		return this.a;
	}

	// Token: 0x0600C28B RID: 49803 RVA: 0x00435B7C File Offset: 0x00433D7C
	public void a(string A_0)
	{
		this.a = A_0;
	}

	// Token: 0x0600C28C RID: 49804 RVA: 0x00435B88 File Offset: 0x00433D88
	public override void iv(e6d A_0, cp9 A_1)
	{
		cne cne = dr3.a();
		if (cne != null)
		{
			Texture2D resource = cne.GetResource<Texture2D>(this.a, null);
			if (resource != null)
			{
				Point point = base.at();
				Rectangle a_ = new Rectangle(point.X, point.Y, base.Size.c, base.Size.d);
				A_1.b().xa(resource, a_, base.Color);
			}
		}
	}

	// Token: 0x04004672 RID: 18034
	private new string a = bo1.d;
}

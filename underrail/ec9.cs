using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Ouroboros.Core.Logging;

// Token: 0x02000178 RID: 376
[dmo(DisplayName = "Classic Pane", Description = "", InitialWidth = 150, InitialHeight = 150)]
public class ec9 : amm
{
	// Token: 0x060009C6 RID: 2502 RVA: 0x000282E8 File Offset: 0x000264E8
	public override void iv(e6d A_0, cp9 A_1)
	{
		cvq cvq = dr3.e();
		Point point = base.at();
		try
		{
			cne cne = dr3.a();
			if (cne != null)
			{
				Texture2D texture2D = null;
				if (!string.IsNullOrEmpty(this.c))
				{
					texture2D = cne.GetResource<Texture2D>(this.c, null);
				}
				if (texture2D != null)
				{
					esj value;
					if (this.d != null)
					{
						value = this.d.Value;
					}
					else
					{
						value = new esj(texture2D.Width / 3, texture2D.Height / 3);
					}
					c4o.b(A_1, texture2D, value, Point.Zero, new Rectangle(point.X, point.Y, base.Size.c, base.Size.d), base.Color, true, new Point?(this.e));
				}
			}
		}
		catch (Exception ex)
		{
			if (cvq != null && cvq.n8() && cvq.n9(LogSeverity.Verbose, 110))
			{
				string a_ = "[GUI] - Failed to render Classic Pane. Exception: " + ex.ToString();
				cvq.n7(LogSeverity.Verbose, 110, a_);
			}
		}
		base.iv(A_0, A_1);
	}

	// Token: 0x04000634 RID: 1588
	private new const int a = 3;

	// Token: 0x04000635 RID: 1589
	private new const int b = 3;

	// Token: 0x04000636 RID: 1590
	public new string c;

	// Token: 0x04000637 RID: 1591
	public new esj? d;

	// Token: 0x04000638 RID: 1592
	public new Point e;
}

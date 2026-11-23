using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Ouroboros.Core.Logging;

// Token: 0x020001AE RID: 430
public class bg1 : euz
{
	// Token: 0x06000C3A RID: 3130 RVA: 0x00032038 File Offset: 0x00030238
	public override void iv(e6d A_0, cp9 A_1)
	{
		cvq cvq = dr3.e();
		Texture2D texture2D = this.b();
		if (texture2D != null)
		{
			try
			{
				Point point = base.at();
				Rectangle a_ = new Rectangle(point.X, point.Y, this.a ? base.Size.c : Math.Min(base.Size.c, (this.d != null) ? this.d.Value.Width : texture2D.Width), this.a ? base.Size.d : Math.Min(base.Size.d, (this.d != null) ? this.d.Value.Height : texture2D.Height));
				if (this.e)
				{
					A_1.a();
					A_1.b().w3(A_1.d, A_1.e, SamplerState.LinearClamp, null, null, null);
				}
				if (!this.a)
				{
					Rectangle value;
					if (this.d != null)
					{
						value = this.d.Value;
					}
					else
					{
						value = new Rectangle(0, 0, Math.Min(base.Size.c, texture2D.Width), Math.Min(base.Size.d, texture2D.Height));
					}
					A_1.b().w6(texture2D, a_, new Rectangle?(value), base.Color);
				}
				else
				{
					A_1.b().w6(texture2D, a_, this.d, base.Color);
				}
				if (this.e)
				{
					A_1.a();
					A_1.a(null);
				}
			}
			catch (Exception ex)
			{
				if (cvq != null && cvq.n8() && cvq.n9(LogSeverity.Error, 110))
				{
					string a_2 = "[GUI] - Failed rendering picture control. Exception: " + ex.ToString();
					cvq.n7(LogSeverity.Error, 110, a_2);
				}
			}
		}
		base.iv(A_0, A_1);
	}

	// Token: 0x06000C3B RID: 3131 RVA: 0x00032270 File Offset: 0x00030470
	private Texture2D b()
	{
		if (this.c != null)
		{
			return this.c();
		}
		cne cne = bg1.a();
		cvq cvq = dr3.e();
		Texture2D result = null;
		if (cne != null)
		{
			if (!string.IsNullOrEmpty(this.b))
			{
				result = cne.GetResource<Texture2D>(this.b, null);
			}
		}
		else if (cvq != null && cvq.n8() && cvq.n9(LogSeverity.Error, 110))
		{
			string a_ = "[GUI] - Failed to retrieve dynamic resource manager.";
			cvq.n7(LogSeverity.Error, 110, a_);
		}
		return result;
	}

	// Token: 0x06000C3C RID: 3132 RVA: 0x00032308 File Offset: 0x00030508
	private new static cne a()
	{
		return bpo.GetService<cne>();
	}

	// Token: 0x04000747 RID: 1863
	public new bool a;

	// Token: 0x04000748 RID: 1864
	public new string b;

	// Token: 0x04000749 RID: 1865
	public new Func<Texture2D> c;

	// Token: 0x0400074A RID: 1866
	public new Rectangle? d;

	// Token: 0x0400074B RID: 1867
	public new bool e;
}

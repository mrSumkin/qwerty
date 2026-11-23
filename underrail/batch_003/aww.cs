using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using TimelapseVertigo.Common.Data;

// Token: 0x02001FDD RID: 8157
public sealed class aww : euz
{
	// Token: 0x0600BFA4 RID: 49060 RVA: 0x00426250 File Offset: 0x00424450
	public override void iv(e6d A_0, cp9 A_1)
	{
		cne service = bpo.GetService<cne>();
		if (service == null)
		{
			return;
		}
		aww.a[] array = new aww.a[2];
		if (this.a != null && this.c != null)
		{
			array[0] = new aww.a
			{
				c = this.a,
				a = this.c,
				d = base.Color,
				b = this.e
			};
		}
		if (this.b != null && this.d != null)
		{
			array[1] = new aww.a
			{
				c = this.b,
				a = this.d,
				d = this.i,
				b = this.f
			};
		}
		foreach (aww.a a in array)
		{
			if (a != null && !string.IsNullOrEmpty(a.a))
			{
				Texture2D resource = service.GetResource<Texture2D>(a.a, null);
				if (resource != null)
				{
					esj value;
					if (this.g != null)
					{
						value = this.g.Value;
					}
					else
					{
						value = new esj(resource.Width, resource.Height / 3);
					}
					Point point = base.at();
					Rectangle a_ = new Rectangle(point.X, point.Y, base.Size.c, value.d);
					aww.a(A_1, resource, a.b, 0, value, a_, Color.White);
					float num = a.c.zm() - a.c.zk();
					float num2 = a.c.zo() - a.c.zk();
					if (num != 0f && num2 > 0f)
					{
						float num3 = Math.Max(0f, Math.Min(1f, num2 / num));
						if (num3 > 0f)
						{
							int width = (int)Math.Max((float)this.h, (float)base.Size.c * num3);
							Rectangle a_2 = new Rectangle(point.X, point.Y, width, value.d);
							aww.a(A_1, resource, a.b, 1, value, a_2, a.d);
						}
					}
					aww.a(A_1, resource, a.b, 2, value, a_, Color.White);
				}
			}
		}
		base.iv(A_0, A_1);
	}

	// Token: 0x0600BFA5 RID: 49061 RVA: 0x004264C4 File Offset: 0x004246C4
	private static void a(cp9 A_0, Texture2D A_1, Point A_2, int A_3, esj A_4, Rectangle A_5, Color A_6)
	{
		c4o.a(A_0, A_1, new Rectangle(A_2.X, A_2.Y + A_4.d * A_3, A_4.c, A_4.d), A_5, A_6);
	}

	// Token: 0x04004504 RID: 17668
	public new IBoundVariable<float> a;

	// Token: 0x04004505 RID: 17669
	public new IBoundVariable<float> b;

	// Token: 0x04004506 RID: 17670
	public new string c = bo1.f;

	// Token: 0x04004507 RID: 17671
	public new string d;

	// Token: 0x04004508 RID: 17672
	public new Point e;

	// Token: 0x04004509 RID: 17673
	public new Point f;

	// Token: 0x0400450A RID: 17674
	public new esj? g;

	// Token: 0x0400450B RID: 17675
	public int h;

	// Token: 0x0400450C RID: 17676
	public Color i;

	// Token: 0x02001FDE RID: 8158
	private new sealed class a
	{
		// Token: 0x0400450D RID: 17677
		public string a;

		// Token: 0x0400450E RID: 17678
		public Point b;

		// Token: 0x0400450F RID: 17679
		public IBoundVariable<float> c;

		// Token: 0x04004510 RID: 17680
		public Color d;
	}
}

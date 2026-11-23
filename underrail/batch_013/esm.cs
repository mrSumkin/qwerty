using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using TimelapseVertigo.Common.Settings;

// Token: 0x02001FD2 RID: 8146
public sealed class esm : bnz
{
	// Token: 0x0600BF53 RID: 48979 RVA: 0x00423588 File Offset: 0x00421788
	static esm()
	{
		esm.a[UiSize.Classic] = new esm.a(new Rectangle(554, 0, 34, 29), egg.p);
		esm.a[UiSize.Small] = new esm.a(new Rectangle(132, 57, 36, 21), egg.p);
		esm.a[UiSize.Large] = new esm.a(new Rectangle(240, 89, 54, 33), egg.ay);
		esm.a[UiSize.Huge] = new esm.a(new Rectangle(436, 41, 74, 46), egg.bd);
		esm.a[UiSize.Auto] = (esm.a[UiSize.Classic] = esm.a[UiSize.Small]);
	}

	// Token: 0x0600BF54 RID: 48980 RVA: 0x00423658 File Offset: 0x00421858
	public esm(string A_0, string A_1, Point A_2, int A_3, int A_4, esj A_5, Vector2 A_6, float A_7 = 1f) : base(A_0, A_1, A_2, A_3, A_4, A_5, A_6, A_7, 0)
	{
	}

	// Token: 0x0600BF55 RID: 48981 RVA: 0x0042367C File Offset: 0x0042187C
	public override void ob(e6d A_0, cp9 A_1, bool A_2)
	{
		base.ob(A_0, A_1, A_2);
		ps service = bpo.GetService<ps>();
		if (service != null && service.ak0() != null)
		{
			int num = 0;
			cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
			UiSize uiSize = serviceOrThrow.aq1().b().t();
			Texture2D resource;
			SpriteFont resource2;
			Rectangle rectangle;
			if (uiSize == UiSize.Classic)
			{
				resource = A_1.a.GetResource<Texture2D>(bo1.b3, null);
				resource2 = A_1.a.GetResource<SpriteFont>(egg.p, null);
				rectangle = new Rectangle(554, 0, 34, 29);
			}
			else
			{
				char c = bl9.a(serviceOrThrow.aq1().b().t());
				esm.a a = esm.a[uiSize];
				string assetName = string.Format(bo1.b4, c);
				resource = A_1.a.GetResource<Texture2D>(assetName, null);
				resource2 = A_1.a.GetResource<SpriteFont>(a.b, null);
				rectangle = a.a;
				num = egg.b(a.b);
			}
			if (resource != null && resource2 != null)
			{
				Vector2 vector;
				if (uiSize == UiSize.Classic)
				{
					vector = new Vector2((float)A_0.b().X - this.g.X + (float)this.e.c, (float)A_0.b().Y - this.g.Y + 2f);
					A_1.b().w5(resource, vector, new Rectangle?(rectangle), Color.White * 0.5f);
					vector = new Vector2(vector.X + 5f, vector.Y + 7f);
					int num2 = (int)(service.ak0().a * 100.0);
					A_1.b().xb(resource2, num2.ToString() + "%", vector, adi.c);
					return;
				}
				vector = new Vector2((float)A_0.b().X - this.g.X + (float)this.e.c, (float)A_0.b().Y - this.g.Y + (float)((this.e.d - rectangle.Height) / 2));
				A_1.b().w5(resource, vector, new Rectangle?(rectangle), Color.Gray * 0.65f);
				string text = ((int)(service.ak0().a * 100.0)).ToString() + "%";
				Vector2 vector2 = resource2.MeasureString(text);
				vector = new Vector2((float)Convert.ToInt32(vector.X + ((float)rectangle.Width - vector2.X) / 2f), (float)Convert.ToInt32(vector.Y + ((float)rectangle.Height - vector2.Y) / 2f + (float)num));
				A_1.b().xb(resource2, text, vector, adi.c);
			}
		}
	}

	// Token: 0x040044C6 RID: 17606
	private new static Dictionary<UiSize, esm.a> a = new Dictionary<UiSize, esm.a>();

	// Token: 0x02001FD3 RID: 8147
	private new struct a
	{
		// Token: 0x0600BF56 RID: 48982 RVA: 0x004239AC File Offset: 0x00421BAC
		public a(Rectangle A_0, string A_1)
		{
			this.a = A_0;
			this.b = A_1;
		}

		// Token: 0x040044C7 RID: 17607
		public Rectangle a;

		// Token: 0x040044C8 RID: 17608
		public string b;
	}
}

using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

// Token: 0x020001B7 RID: 439
public abstract class c86 : bu7
{
	// Token: 0x06000CAD RID: 3245 RVA: 0x0003414C File Offset: 0x0003234C
	public a2f b(dnn A_0, string A_1, Point A_2, string A_3, bool A_4)
	{
		return this.GetPartFromSet<a2f>(A_0, A_1, A_2, A_3, A_4);
	}

	// Token: 0x06000CAE RID: 3246 RVA: 0x00034160 File Offset: 0x00032360
	public T GetPartFromSet<T>(dnn viewMaterializer, string unitName, Point state, string variation, bool loadTexture) where T : a2f, new()
	{
		T t = default(T);
		if (unitName == null)
		{
			return default(T);
		}
		eva eva = viewMaterializer.x.a(unitName);
		if (eva != null)
		{
			Point point = state;
			if (point.X > eva.g.X)
			{
				point.X = eva.g.X;
			}
			if (point.Y > eva.g.Y)
			{
				point.Y = eva.g.Y;
			}
			int num = (eva.d > false) ? 1 : 0;
			t = Activator.CreateInstance<T>();
			if (loadTexture)
			{
				string text = eva.b + (variation ?? string.Empty);
				Texture2D resource = base.b().GetResource<Texture2D>(text, null);
				if (resource == null)
				{
					text = eva.b;
					resource = base.b().GetResource<Texture2D>(eva.b, null);
				}
				if (resource != null)
				{
					t.d = new e4m(resource, text);
				}
			}
			t.j = eva.f;
			t.c = new Rectangle(eva.e.X + num + point.X * (eva.c.X + num * 2), eva.e.Y + num + point.Y * (eva.c.Y + num * 2), eva.c.X, eva.c.Y);
		}
		return t;
	}
}

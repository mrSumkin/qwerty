using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Ouroboros.Core.Logging;

// Token: 0x02000772 RID: 1906
internal class a23 : cgr
{
	// Token: 0x0600304D RID: 12365 RVA: 0x001279F0 File Offset: 0x00125BF0
	public a23(a7m A_0)
	{
		czh.a(A_0, "axoMaterializer");
		av0 av = A_0.m() as av0;
		if (av != null)
		{
			this.a = esj.b(av.a, 2.0);
			this.b = new Rectangle(0, this.a.d, this.a.c, this.a.d);
			this.c = new Rectangle(this.a.c, this.a.d * 2, this.a.c, this.a.d);
			this.d = new Rectangle(0, this.a.d * 2, this.a.c, this.a.d);
			this.e = new Rectangle(this.a.c * 2, this.a.d, this.a.c, this.a.d);
			this.f = new Rectangle(this.a.c * 3, this.a.d, this.a.c, this.a.d);
			return;
		}
		dux.a(LogSeverity.CriticalError, "Unable to initialize CustomTileMaterialization. Axonometric materialization schema was null.", new object[0]);
	}

	// Token: 0x0600304E RID: 12366 RVA: 0x00127B54 File Offset: 0x00125D54
	public void tu(cp9 A_0, cz6 A_1)
	{
		mv mv = A_1.a as mv;
		float scale;
		if (mv != null && mv.s != null)
		{
			scale = mv.s.b().f();
		}
		else
		{
			scale = 0.3f;
		}
		Vector2? vector = null;
		cnk cnk = ces.a();
		c5x c5x = null;
		if (cnk != null && cnk.aqu() != null)
		{
			c5x = (cnk.aqu().v().b() as c5x);
		}
		if (c5x == null || !aw1.a(c5x, A_1.b, true, c5x))
		{
			List<ya> list = A_1.b.a(typeof(b0j));
			if (list != null && list.Count > 0)
			{
				foreach (ya ya in list)
				{
					b0j b0j = (b0j)ya;
					if (b0j.Condition == null || b0j.Condition.jh(null))
					{
						vector = new Vector2?(A_1.a.vq((float)A_1.b.Location.X, (float)A_1.b.Location.Y, 0f));
						this.d(A_0, vector.Value, a23.g * scale, A_1.a);
					}
				}
			}
			List<ya> list2 = A_1.b.a(typeof(cdo));
			if (list2 != null && list2.Count > 0)
			{
				foreach (ya ya2 in list2)
				{
					cdo cdo = (cdo)ya2;
					if (cdo.c() == null || cdo.c().jh(A_1.b))
					{
						vector = new Vector2?(A_1.a.vq((float)A_1.b.Location.X, (float)A_1.b.Location.Y, 0f));
						this.d(A_0, vector.Value, a23.h * scale, A_1.a);
						break;
					}
				}
			}
		}
		if (mv.ae)
		{
			if (A_1.a.an1() != null && mv.aa != null && mv.aa.aij() != null)
			{
				rl rl = mv.aa.aij().eg() as rl;
				if (rl != null && rl.cg(A_1.a.an1()))
				{
					Point point = A_1.b.Location;
					Point point2 = A_1.a.an1().Location;
					if (aw1.a((float)Math.Sqrt(Math.Pow((double)(point.X - point2.X), 2.0) + Math.Pow((double)(point.Y - point2.Y), 2.0)), (float)rl.th()))
					{
						float scale2 = rl.aqj(A_1.b) ? 0.5f : 0.25f;
						eal eal = mv.aa.aij() as eal;
						bool flag = false;
						Color value;
						if (eal != null && eal.ati() != null && eal.ati().p() != null)
						{
							mv.z[point] = eal.ati().p().Nature;
							if (eal.ati().p().Nature != ci8.c)
							{
								value = Color.Blue;
							}
							else
							{
								value = Color.Red;
							}
							flag = eal.ati().p().HasSecondaryEffectRadius;
						}
						else
						{
							value = Color.Red;
						}
						if (vector == null)
						{
							vector = new Vector2?(A_1.a.vq((float)point.X, (float)point.Y, 0f));
						}
						if (flag && A_1.a.an1() != null && A_1.a.an1() != A_1.b)
						{
							this.c(A_0, vector.Value, value * scale2, A_1.a);
						}
						else
						{
							this.d(A_0, vector.Value, value * scale2, A_1.a);
						}
					}
				}
			}
			if (mv != null && mv.p != null && mv.p.b == A_1.b)
			{
				vector = new Vector2?(A_1.a.vq((float)A_1.b.Location.X, (float)A_1.b.Location.Y, 0f));
				this.e(A_0, vector.Value, dcl.a(mv.p.c) * 0.6f, A_1.a);
			}
		}
	}

	// Token: 0x0600304F RID: 12367 RVA: 0x0012809C File Offset: 0x0012629C
	public void b(cp9 A_0, Vector2 A_1, Color A_2, bkx A_3)
	{
		A_0.b().w7(ci7.m(), A_1, new Rectangle?(this.e), A_2, 0f, Vector2.Zero, A_3.any(), SpriteEffects.None, 0f);
	}

	// Token: 0x06003050 RID: 12368 RVA: 0x001280E0 File Offset: 0x001262E0
	public void d(cp9 A_0, Vector2 A_1, Color A_2, bkx A_3)
	{
		A_0.b().w7(ci7.m(), A_1, new Rectangle?(this.b), A_2, 0f, Vector2.Zero, A_3.any(), SpriteEffects.None, 0f);
	}

	// Token: 0x06003051 RID: 12369 RVA: 0x00128124 File Offset: 0x00126324
	public void c(cp9 A_0, Vector2 A_1, Color A_2, bkx A_3)
	{
		A_0.b().w7(ci7.m(), A_1, new Rectangle?(this.c), A_2, 0f, Vector2.Zero, A_3.any(), SpriteEffects.None, 0f);
	}

	// Token: 0x06003052 RID: 12370 RVA: 0x00128168 File Offset: 0x00126368
	public void a(cp9 A_0, Vector2 A_1, Color A_2, bkx A_3)
	{
		A_0.b().w7(ci7.m(), A_1, new Rectangle?(this.d), A_2, 0f, Vector2.Zero, A_3.any(), SpriteEffects.None, 0f);
	}

	// Token: 0x06003053 RID: 12371 RVA: 0x001281AC File Offset: 0x001263AC
	public void e(cp9 A_0, Vector2 A_1, Color A_2, bkx A_3)
	{
		int num = dcl.a();
		Rectangle value = new Rectangle(num * this.a.c, 0, this.a.c, this.a.d);
		A_0.b().w7(ci7.m(), A_1, new Rectangle?(value), A_2, 0f, Vector2.Zero, A_3.any(), SpriteEffects.None, 0f);
	}

	// Token: 0x06003054 RID: 12372 RVA: 0x0012821C File Offset: 0x0012641C
	public void a(cp9 A_0, Vector2 A_1, Color A_2, mv A_3)
	{
		A_0.b().w7(ci7.m(), A_1, new Rectangle?(this.f), A_2, 0f, Vector2.Zero, A_3.any(), SpriteEffects.None, 0f);
	}

	// Token: 0x04001A79 RID: 6777
	private esj a;

	// Token: 0x04001A7A RID: 6778
	private Rectangle b;

	// Token: 0x04001A7B RID: 6779
	private Rectangle c;

	// Token: 0x04001A7C RID: 6780
	private Rectangle d;

	// Token: 0x04001A7D RID: 6781
	private Rectangle e;

	// Token: 0x04001A7E RID: 6782
	private Rectangle f;

	// Token: 0x04001A7F RID: 6783
	private static readonly Color g = new Color(0, 0, 150);

	// Token: 0x04001A80 RID: 6784
	private static readonly Color h = new Color(150, 0, 0);
}

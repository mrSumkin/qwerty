using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

// Token: 0x02001FD1 RID: 8145
public sealed class c3i
{
	// Token: 0x0600BF4F RID: 48975 RVA: 0x00423420 File Offset: 0x00421620
	public void a(cp9 A_0, Rectangle A_1, Color A_2, int A_3 = 0, int? A_4 = null)
	{
		if (this.b != null)
		{
			for (int i = A_3; i < ((A_4 != null) ? (A_3 + A_4.Value) : this.b.Count); i++)
			{
				abu abu = this.b[i];
				if (abu.a != null)
				{
					A_0.b().w6(abu.a, A_1, new Rectangle?(abu.b), A_2 * abu.c);
				}
			}
		}
	}

	// Token: 0x0600BF50 RID: 48976 RVA: 0x004234B0 File Offset: 0x004216B0
	public void a(cp9 A_0, Vector2 A_1, Color A_2, float A_3 = 1f, int A_4 = 0, int? A_5 = null)
	{
		this.a(A_0, A_1, Vector2.Zero, A_2, A_3, A_4, A_5);
	}

	// Token: 0x0600BF51 RID: 48977 RVA: 0x004234D4 File Offset: 0x004216D4
	public void a(cp9 A_0, Vector2 A_1, Vector2 A_2, Color A_3, float A_4 = 1f, int A_5 = 0, int? A_6 = null)
	{
		if (this.b != null)
		{
			for (int i = A_5; i < ((A_6 != null) ? (A_5 + A_6.Value) : this.b.Count); i++)
			{
				abu abu = this.b[i];
				if (abu.a != null)
				{
					A_0.b().w7(abu.a, A_1, new Rectangle?(abu.b), A_3 * abu.c, 0f, A_2, A_4, SpriteEffects.None, 0f);
				}
			}
		}
	}

	// Token: 0x040044C4 RID: 17604
	public esj a;

	// Token: 0x040044C5 RID: 17605
	public List<abu> b = new List<abu>();
}

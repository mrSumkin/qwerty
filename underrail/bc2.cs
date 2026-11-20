using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

// Token: 0x0200011E RID: 286
public sealed class bc2 : ob
{
	// Token: 0x060006EA RID: 1770 RVA: 0x0001C8C8 File Offset: 0x0001AAC8
	public bc2(SpriteBatch A_0)
	{
		this.a = A_0;
	}

	// Token: 0x060006EB RID: 1771 RVA: 0x0001C8D8 File Offset: 0x0001AAD8
	public void w3(SpriteSortMode A_0, BlendState A_1, SamplerState A_2, DepthStencilState A_3, RasterizerState A_4, Effect A_5 = null)
	{
		SpriteBatch spriteBatch = this.a;
		if (spriteBatch == null)
		{
			return;
		}
		spriteBatch.Begin(A_0, A_1, A_2, A_3, A_4, A_5);
	}

	// Token: 0x060006EC RID: 1772 RVA: 0x0001C8F8 File Offset: 0x0001AAF8
	public void w4(Texture2D A_0, Vector2 A_1, Color A_2)
	{
		SpriteBatch spriteBatch = this.a;
		if (spriteBatch == null)
		{
			return;
		}
		spriteBatch.Draw(A_0, A_1, A_2);
	}

	// Token: 0x060006ED RID: 1773 RVA: 0x0001C910 File Offset: 0x0001AB10
	public void w5(Texture2D A_0, Vector2 A_1, Rectangle? A_2, Color A_3)
	{
		SpriteBatch spriteBatch = this.a;
		if (spriteBatch == null)
		{
			return;
		}
		spriteBatch.Draw(A_0, A_1, A_2, A_3);
	}

	// Token: 0x060006EE RID: 1774 RVA: 0x0001C92C File Offset: 0x0001AB2C
	public void w6(Texture2D A_0, Rectangle A_1, Rectangle? A_2, Color A_3)
	{
		SpriteBatch spriteBatch = this.a;
		if (spriteBatch == null)
		{
			return;
		}
		spriteBatch.Draw(A_0, A_1, A_2, A_3);
	}

	// Token: 0x060006EF RID: 1775 RVA: 0x0001C948 File Offset: 0x0001AB48
	public void w7(Texture2D A_0, Vector2 A_1, Rectangle? A_2, Color A_3, float A_4, Vector2 A_5, float A_6, SpriteEffects A_7, float A_8)
	{
		SpriteBatch spriteBatch = this.a;
		if (spriteBatch == null)
		{
			return;
		}
		spriteBatch.Draw(A_0, A_1, A_2, A_3, A_4, A_5, A_6, A_7, A_8);
	}

	// Token: 0x060006F0 RID: 1776 RVA: 0x0001C978 File Offset: 0x0001AB78
	public void w8(Texture2D A_0, Rectangle A_1, Rectangle? A_2, Color A_3, float A_4, Vector2 A_5, SpriteEffects A_6, float A_7, byte A_8, Vector2 A_9)
	{
		SpriteBatch spriteBatch = this.a;
		if (spriteBatch == null)
		{
			return;
		}
		spriteBatch.Draw(A_0, A_1, A_2, A_3, A_4, A_5, A_6, A_7);
	}

	// Token: 0x060006F1 RID: 1777 RVA: 0x0001C9A8 File Offset: 0x0001ABA8
	public void w9(Texture2D A_0, Vector2 A_1, Rectangle? A_2, Color A_3, float A_4, Vector2 A_5, Vector2 A_6, SpriteEffects A_7, float A_8)
	{
		SpriteBatch spriteBatch = this.a;
		if (spriteBatch == null)
		{
			return;
		}
		spriteBatch.Draw(A_0, A_1, A_2, A_3, A_4, A_5, A_6, A_7, A_8);
	}

	// Token: 0x060006F2 RID: 1778 RVA: 0x0001C9D8 File Offset: 0x0001ABD8
	public void xa(Texture2D A_0, Rectangle A_1, Color A_2)
	{
		SpriteBatch spriteBatch = this.a;
		if (spriteBatch == null)
		{
			return;
		}
		spriteBatch.Draw(A_0, A_1, A_2);
	}

	// Token: 0x060006F3 RID: 1779 RVA: 0x0001C9F0 File Offset: 0x0001ABF0
	public void xb(SpriteFont A_0, string A_1, Vector2 A_2, Color A_3)
	{
		SpriteBatch spriteBatch = this.a;
		if (spriteBatch == null)
		{
			return;
		}
		spriteBatch.DrawString(A_0, A_1, A_2, A_3);
	}

	// Token: 0x060006F4 RID: 1780 RVA: 0x0001CA0C File Offset: 0x0001AC0C
	public void an()
	{
		SpriteBatch spriteBatch = this.a;
		if (spriteBatch == null)
		{
			return;
		}
		spriteBatch.End();
	}

	// Token: 0x0400053A RID: 1338
	public SpriteBatch a;
}

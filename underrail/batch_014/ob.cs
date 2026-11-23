using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

// Token: 0x0200011B RID: 283
public interface ob
{
	// Token: 0x060006CC RID: 1740
	void w3(SpriteSortMode A_0, BlendState A_1, SamplerState A_2, DepthStencilState A_3, RasterizerState A_4, Effect A_5 = null);

	// Token: 0x060006CD RID: 1741
	void an();

	// Token: 0x060006CE RID: 1742
	void w4(Texture2D A_0, Vector2 A_1, Color A_2);

	// Token: 0x060006CF RID: 1743
	void xa(Texture2D A_0, Rectangle A_1, Color A_2);

	// Token: 0x060006D0 RID: 1744
	void w5(Texture2D A_0, Vector2 A_1, Rectangle? A_2, Color A_3);

	// Token: 0x060006D1 RID: 1745
	void w6(Texture2D A_0, Rectangle A_1, Rectangle? A_2, Color A_3);

	// Token: 0x060006D2 RID: 1746
	void w7(Texture2D A_0, Vector2 A_1, Rectangle? A_2, Color A_3, float A_4, Vector2 A_5, float A_6, SpriteEffects A_7, float A_8);

	// Token: 0x060006D3 RID: 1747
	void w8(Texture2D A_0, Rectangle A_1, Rectangle? A_2, Color A_3, float A_4, Vector2 A_5, SpriteEffects A_6, float A_7, byte A_8, Vector2 A_9);

	// Token: 0x060006D4 RID: 1748
	void w9(Texture2D A_0, Vector2 A_1, Rectangle? A_2, Color A_3, float A_4, Vector2 A_5, Vector2 A_6, SpriteEffects A_7, float A_8);

	// Token: 0x060006D5 RID: 1749
	void xb(SpriteFont A_0, string A_1, Vector2 A_2, Color A_3);
}

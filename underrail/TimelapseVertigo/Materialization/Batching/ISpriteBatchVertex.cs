using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace TimelapseVertigo.Materialization.Batching
{
	// Token: 0x0200005C RID: 92
	public interface ISpriteBatchVertex<TRenderParameters> where TRenderParameters : struct
	{
		// Token: 0x06000176 RID: 374
		void ac4(float A_0, float A_1, float A_2, float A_3, Color A_4, ref TRenderParameters A_5);

		// Token: 0x06000177 RID: 375
		VertexDeclaration ac3();
	}
}

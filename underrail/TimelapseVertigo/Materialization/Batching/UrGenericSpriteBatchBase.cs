using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace TimelapseVertigo.Materialization.Batching
{
	// Token: 0x0200005D RID: 93
	public abstract class UrGenericSpriteBatchBase<TVertex, TRenderParameters> where TVertex : struct, ISpriteBatchVertex<TRenderParameters> where TRenderParameters : struct
	{
		// Token: 0x06000178 RID: 376 RVA: 0x000082B0 File Offset: 0x000064B0
		protected UrGenericSpriteBatchBase(GraphicsDevice A_0, int A_1)
		{
			this.k = new UrGenericSpriteBatchBase<TVertex, TRenderParameters>.UrGenericSpriteBatchItem[A_1];
			this.i = Math.Max(1, A_1 / 4);
			this.b = A_0;
			this.a(this.k.Length);
			TVertex tvertex = Activator.CreateInstance<TVertex>();
			this.a = tvertex.ac3();
		}

		// Token: 0x06000179 RID: 377 RVA: 0x00008334 File Offset: 0x00006534
		public virtual void a(Effect A_0)
		{
			if (this.c)
			{
				throw new Exception("Существо уже было вызвано.");
			}
			this.d = A_0;
			this.c = true;
			this.l = 0;
			this.b.Textures[0] = null;
			this.b.Textures[1] = null;
			this.b.Textures[2] = null;
			this.b.Textures[3] = null;
			this.b.Textures[4] = null;
			this.b.Textures[5] = null;
			this.b.Textures[6] = null;
			this.b.Textures[7] = null;
		}

		// Token: 0x0600017A RID: 378 RVA: 0x000083FC File Offset: 0x000065FC
		public void an()
		{
			if (!this.c)
			{
				throw new Exception("Существо не было вызвано.");
			}
			this.b();
			this.c();
			this.c = false;
			this.b.DepthStencilState = this.o;
		}

		// Token: 0x0600017B RID: 379 RVA: 0x00008438 File Offset: 0x00006638
		private void b()
		{
			this.b.BlendState = this.q;
			if (this.s != null && this.s.Length != 0)
			{
				for (int i = 0; i < this.s.Length; i++)
				{
					this.b.SamplerStates[i] = this.s[i];
				}
			}
			this.b.RasterizerState = this.r;
			this.o = this.b.DepthStencilState;
			if (this.p)
			{
				this.b.DepthStencilState = DepthStencilState.Default;
			}
			else
			{
				this.b.DepthStencilState = DepthStencilState.DepthRead;
			}
			Viewport viewport = this.b.Viewport;
			if (viewport.Width != this.e.Width || viewport.Height != this.e.Height)
			{
				Viewport viewport2 = viewport;
				float num = (viewport2.Width > 0) ? (1f / (float)viewport2.Width) : 0f;
				float num2 = (viewport2.Height > 0) ? (-1f / (float)viewport2.Height) : 0f;
				Matrix matrix = default(Matrix);
				matrix.M11 = num * 2f;
				matrix.M22 = num2 * 2f;
				matrix.M33 = 1f;
				matrix.M44 = 1f;
				matrix.M41 = -1f;
				matrix.M42 = 1f;
				matrix.M41 -= num;
				matrix.M42 -= num2;
				this.f = matrix;
				this.e = viewport;
			}
			Vector2 value = new Vector2((float)viewport.Width, (float)viewport.Height);
			Matrix value2 = new Matrix(0.05882353f, 0.5294118f, 0.1764706f, 0.64705884f, 0.7647059f, 0.29411766f, 0.88235295f, 0.4117647f, 0.23529412f, 0.7058824f, 0.11764706f, 0.5882353f, 0.9411765f, 0.47058824f, 0.8235294f, 0.3529412f);
			EffectParameter effectParameter = this.d.Parameters["DitherThresholdMatrix"];
			if (effectParameter != null)
			{
				effectParameter.SetValue(value2);
			}
			EffectParameter effectParameter2 = this.d.Parameters["MatrixTransform"];
			if (effectParameter2 != null)
			{
				effectParameter2.SetValue(this.f);
			}
			EffectParameter effectParameter3 = this.d.Parameters["TargetSize"];
			if (effectParameter3 != null)
			{
				effectParameter3.SetValue(value);
			}
			if (this.d.CurrentTechnique == null)
			{
				this.d.CurrentTechnique = this.d.Techniques[0];
			}
			this.d.CurrentTechnique.Passes[0].Apply();
		}

		// Token: 0x0600017C RID: 380 RVA: 0x0000872C File Offset: 0x0000692C
		public void a(Texture2D A_0, Texture2D A_1, Texture2D A_2, Texture2D A_3, Texture2D A_4, Texture2D A_5, Texture2D A_6, Texture2D A_7, Vector2 A_8, Rectangle? A_9, Color A_10, float A_11, Vector2 A_12, Vector2 A_13, SpriteEffects A_14, TRenderParameters A_15)
		{
			if (!this.c)
			{
				throw new Exception("Существо не вызывается");
			}
			if (A_0 == null)
			{
				return;
			}
			if (A_9 != null)
			{
				Rectangle value = A_9.Value;
			}
			ref UrGenericSpriteBatchBase<TVertex, TRenderParameters>.UrGenericSpriteBatchItem ptr = ref this.a();
			ptr.a = A_0;
			ptr.b = A_1;
			ptr.c = A_2;
			ptr.d = A_3;
			ptr.e = A_4;
			ptr.f = A_5;
			ptr.g = A_6;
			ptr.h = A_7;
			float num = 1f / (float)A_0.Width;
			float num2 = 1f / (float)A_0.Height;
			A_12 *= A_13;
			float num3;
			float num4;
			Vector2 zero;
			Vector2 one;
			if (A_9 != null)
			{
				Rectangle valueOrDefault = A_9.GetValueOrDefault();
				num3 = (float)valueOrDefault.Width * A_13.X;
				num4 = (float)valueOrDefault.Height * A_13.Y;
				zero.X = (float)valueOrDefault.X * num;
				zero.Y = (float)valueOrDefault.Y * num2;
				one.X = (float)(valueOrDefault.X + valueOrDefault.Width) * num;
				one.Y = (float)(valueOrDefault.Y + valueOrDefault.Height) * num2;
			}
			else
			{
				num3 = (float)A_0.Width * A_13.X;
				num4 = (float)A_0.Height * A_13.Y;
				zero = Vector2.Zero;
				one = Vector2.One;
			}
			if ((A_14 & SpriteEffects.FlipVertically) != SpriteEffects.None)
			{
				float y = one.Y;
				one.Y = zero.Y;
				zero.Y = y;
			}
			if ((A_14 & SpriteEffects.FlipHorizontally) != SpriteEffects.None)
			{
				float x = one.X;
				one.X = zero.X;
				zero.X = x;
			}
			if (A_11 == 0f)
			{
				ptr.a(A_8.X - A_12.X, A_8.Y - A_12.Y, num3, num4, A_10, zero, one, A_15);
				return;
			}
			ptr.a(A_8.X, A_8.Y, -A_12.X, -A_12.Y, num3, num4, (float)Math.Sin((double)A_11), (float)Math.Cos((double)A_11), A_10, zero, one, A_15);
		}

		// Token: 0x0600017D RID: 381 RVA: 0x00008960 File Offset: 0x00006B60
		private ref UrGenericSpriteBatchBase<TVertex, TRenderParameters>.UrGenericSpriteBatchItem a()
		{
			int num = this.l;
			this.l = num + 1;
			int num2 = num;
			if (num2 >= this.k.Length)
			{
				int num3 = this.k.Length + this.i;
				Array.Resize<UrGenericSpriteBatchBase<TVertex, TRenderParameters>.UrGenericSpriteBatchItem>(ref this.k, num3);
				for (int i = num2; i < num3; i++)
				{
					this.k[i] = default(UrGenericSpriteBatchBase<TVertex, TRenderParameters>.UrGenericSpriteBatchItem);
				}
				this.a(Math.Min(this.k.Length, 5461));
			}
			return ref this.k[num2];
		}

		// Token: 0x0600017E RID: 382 RVA: 0x000089F0 File Offset: 0x00006BF0
		public void c()
		{
			if (this.l == 0)
			{
				return;
			}
			int num = 0;
			int num3;
			for (int i = this.l; i > 0; i -= num3)
			{
				int a_ = 0;
				int num2 = 0;
				Texture2D texture2D = null;
				Texture2D texture2D2 = null;
				Texture2D texture2D3 = null;
				Texture2D texture2D4 = null;
				Texture2D texture2D5 = null;
				Texture2D texture2D6 = null;
				Texture2D texture2D7 = null;
				Texture2D texture2D8 = null;
				num3 = i;
				if (num3 > 5461)
				{
					num3 = 5461;
				}
				int num4 = 0;
				int j = 0;
				while (j < num3)
				{
					ref UrGenericSpriteBatchBase<TVertex, TRenderParameters>.UrGenericSpriteBatchItem ptr = ref this.k[num];
					if (ptr.a != texture2D || ptr.b != texture2D2 || ptr.c != texture2D3 || ptr.d != texture2D4 || ptr.e != texture2D5 || ptr.f != texture2D6 || ptr.g != texture2D7 || ptr.h != texture2D8)
					{
						this.a(a_, num2, texture2D, texture2D2);
						texture2D = ptr.a;
						texture2D2 = ptr.b;
						texture2D3 = ptr.c;
						texture2D4 = ptr.d;
						texture2D5 = ptr.e;
						texture2D6 = ptr.f;
						texture2D7 = ptr.g;
						texture2D8 = ptr.h;
						num2 = (a_ = 0);
						num4 = 0;
						if (this.s.Length >= 1)
						{
							this.b.Textures[0] = texture2D;
						}
						if (this.s.Length >= 2)
						{
							this.b.Textures[1] = texture2D2;
						}
						if (this.s.Length >= 3)
						{
							this.b.Textures[2] = texture2D3;
						}
						if (this.s.Length >= 4)
						{
							this.b.Textures[3] = texture2D4;
						}
						if (this.s.Length >= 5)
						{
							this.b.Textures[4] = texture2D5;
						}
						if (this.s.Length >= 6)
						{
							this.b.Textures[5] = texture2D6;
						}
						if (this.s.Length >= 7)
						{
							this.b.Textures[6] = texture2D7;
						}
						if (this.s.Length >= 8)
						{
							this.b.Textures[7] = texture2D8;
						}
					}
					this.n[num4] = ptr.i;
					this.n[num4 + 1] = ptr.j;
					this.n[num4 + 2] = ptr.k;
					this.n[num4 + 3] = ptr.l;
					ptr.a = null;
					ptr.b = null;
					ptr.c = null;
					ptr.d = null;
					ptr.e = null;
					ptr.f = null;
					ptr.g = null;
					ptr.h = null;
					j++;
					num++;
					num2 += 4;
					num4 += 4;
				}
				this.a(a_, num2, texture2D, texture2D2);
			}
			this.l = 0;
		}

		// Token: 0x0600017F RID: 383 RVA: 0x00008D14 File Offset: 0x00006F14
		private void a(int A_0, int A_1, Texture A_2, Texture A_3)
		{
			if (A_0 == A_1)
			{
				return;
			}
			int num = A_1 - A_0;
			this.b.DrawUserIndexedPrimitives<TVertex>(PrimitiveType.TriangleList, this.n, 0, num, this.m, 0, num / 4 * 2, this.a);
		}

		// Token: 0x06000180 RID: 384 RVA: 0x00008D54 File Offset: 0x00006F54
		private unsafe void a(int A_0)
		{
			int num = 6 * A_0;
			if (this.m != null && num <= this.m.Length)
			{
				return;
			}
			short[] array = new short[6 * A_0];
			int num2 = 0;
			if (this.m != null)
			{
				this.m.CopyTo(array, 0);
				num2 = this.m.Length / 6;
			}
			short[] array2;
			short* ptr;
			if ((array2 = array) == null || array2.Length == 0)
			{
				ptr = null;
			}
			else
			{
				ptr = &array2[0];
			}
			short* ptr2 = ptr + num2 * 6;
			int i = num2;
			while (i < A_0)
			{
				*ptr2 = (short)(i * 4);
				ptr2[1] = (short)(i * 4 + 1);
				ptr2[2] = (short)(i * 4 + 2);
				ptr2[3] = (short)(i * 4 + 1);
				ptr2[4] = (short)(i * 4 + 3);
				ptr2[5] = (short)(i * 4 + 2);
				i++;
				ptr2 += 6;
			}
			array2 = null;
			this.m = array;
			this.n = new TVertex[4 * A_0];
		}

		// Token: 0x040002D8 RID: 728
		private VertexDeclaration a;

		// Token: 0x040002D9 RID: 729
		private GraphicsDevice b;

		// Token: 0x040002DA RID: 730
		private bool c;

		// Token: 0x040002DB RID: 731
		private Effect d;

		// Token: 0x040002DC RID: 732
		private Viewport e;

		// Token: 0x040002DD RID: 733
		private Matrix f;

		// Token: 0x040002DE RID: 734
		private Vector3 g;

		// Token: 0x040002DF RID: 735
		private float h;

		// Token: 0x040002E0 RID: 736
		private int i = 3000;

		// Token: 0x040002E1 RID: 737
		private const int j = 5461;

		// Token: 0x040002E2 RID: 738
		private UrGenericSpriteBatchBase<TVertex, TRenderParameters>.UrGenericSpriteBatchItem[] k;

		// Token: 0x040002E3 RID: 739
		private int l;

		// Token: 0x040002E4 RID: 740
		private short[] m;

		// Token: 0x040002E5 RID: 741
		private TVertex[] n;

		// Token: 0x040002E6 RID: 742
		private DepthStencilState o;

		// Token: 0x040002E7 RID: 743
		public bool p = true;

		// Token: 0x040002E8 RID: 744
		public BlendState q = BlendState.AlphaBlend;

		// Token: 0x040002E9 RID: 745
		public RasterizerState r = RasterizerState.CullNone;

		// Token: 0x040002EA RID: 746
		public SamplerState[] s;

		// Token: 0x0200005E RID: 94
		public struct UrGenericSpriteBatchItem
		{
			// Token: 0x06000181 RID: 385 RVA: 0x00008E60 File Offset: 0x00007060
			public void a(float A_0, float A_1, float A_2, float A_3, float A_4, float A_5, float A_6, float A_7, Color A_8, Vector2 A_9, Vector2 A_10, TRenderParameters A_11)
			{
				this.i.ac4(A_0 + A_2 * A_7 - A_3 * A_6, A_1 + A_2 * A_6 + A_3 * A_7, A_9.X, A_9.Y, A_8, ref A_11);
				this.j.ac4(A_0 + (A_2 + A_4) * A_7 - A_3 * A_6, A_1 + (A_2 + A_4) * A_6 + A_3 * A_7, A_10.X, A_9.Y, A_8, ref A_11);
				this.k.ac4(A_0 + A_2 * A_7 - (A_3 + A_5) * A_6, A_1 + A_2 * A_6 + (A_3 + A_5) * A_7, A_9.X, A_10.Y, A_8, ref A_11);
				this.l.ac4(A_0 + (A_2 + A_4) * A_7 - (A_3 + A_5) * A_6, A_1 + (A_2 + A_4) * A_6 + (A_3 + A_5) * A_7, A_10.X, A_10.Y, A_8, ref A_11);
			}

			// Token: 0x06000182 RID: 386 RVA: 0x00008F74 File Offset: 0x00007174
			public void a(float A_0, float A_1, float A_2, float A_3, Color A_4, Vector2 A_5, Vector2 A_6, TRenderParameters A_7)
			{
				this.i.ac4(A_0, A_1, A_5.X, A_5.Y, A_4, ref A_7);
				this.j.ac4(A_0 + A_2, A_1, A_6.X, A_5.Y, A_4, ref A_7);
				this.k.ac4(A_0, A_1 + A_3, A_5.X, A_6.Y, A_4, ref A_7);
				this.l.ac4(A_0 + A_2, A_1 + A_3, A_6.X, A_6.Y, A_4, ref A_7);
			}

			// Token: 0x040002EB RID: 747
			public Texture2D a;

			// Token: 0x040002EC RID: 748
			public Texture2D b;

			// Token: 0x040002ED RID: 749
			public Texture2D c;

			// Token: 0x040002EE RID: 750
			public Texture2D d;

			// Token: 0x040002EF RID: 751
			public Texture2D e;

			// Token: 0x040002F0 RID: 752
			public Texture2D f;

			// Token: 0x040002F1 RID: 753
			public Texture2D g;

			// Token: 0x040002F2 RID: 754
			public Texture2D h;

			// Token: 0x040002F3 RID: 755
			public TVertex i;

			// Token: 0x040002F4 RID: 756
			public TVertex j;

			// Token: 0x040002F5 RID: 757
			public TVertex k;

			// Token: 0x040002F6 RID: 758
			public TVertex l;
		}
	}
}

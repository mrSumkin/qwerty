using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;
using Ouroboros.Playfield.Lightning;

// Token: 0x0200107D RID: 4221
[eiz("SWTAJ")]
[Serializable]
public sealed class cp0 : cze, ISerializable
{
	// Token: 0x060057FF RID: 22527 RVA: 0x00263F14 File Offset: 0x00262114
	private cp0(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06005800 RID: 22528 RVA: 0x00263F20 File Offset: 0x00262120
	public cp0()
	{
	}

	// Token: 0x06005801 RID: 22529 RVA: 0x00263F2C File Offset: 0x0026212C
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		if (Enumerable.FirstOrDefault<bsf>(Enumerable.Where<bsf>(Enumerable.OfType<bsf>(A_1.RaysEmitters), new Func<bsf, bool>(cp0.a.a.a))) == null)
		{
			new ah7("swampTranceLantern", null)
			{
				Layer = aju.x,
				Light = new ae8(new Color(255, 115, 125), 0.75f, LightType.Increment),
				Range = 4f,
				LightFadeRate = 0.2f
			}.g().be(A_1);
		}
	}

	// Token: 0x0200107E RID: 4222
	[CompilerGenerated]
	[Serializable]
	private new sealed class a
	{
		// Token: 0x06005804 RID: 22532 RVA: 0x00263FE0 File Offset: 0x002621E0
		internal bool a(bsf A_0)
		{
			return A_0.Definition != null && A_0.Definition.Name == "swampTranceLantern";
		}

		// Token: 0x04002389 RID: 9097
		public static readonly cp0.a a = new cp0.a();

		// Token: 0x0400238A RID: 9098
		public static Func<bsf, bool> b;
	}
}

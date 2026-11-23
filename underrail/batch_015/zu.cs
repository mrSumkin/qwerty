using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;
using Ouroboros.Playfield.Lightning;

// Token: 0x02001051 RID: 4177
[eiz("WCAAJ")]
[Serializable]
public sealed class zu : cze, ISerializable
{
	// Token: 0x0600569B RID: 22171 RVA: 0x0025FB28 File Offset: 0x0025DD28
	private zu(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x0600569C RID: 22172 RVA: 0x0025FB34 File Offset: 0x0025DD34
	public zu()
	{
	}

	// Token: 0x0600569D RID: 22173 RVA: 0x0025FB40 File Offset: 0x0025DD40
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		if (Enumerable.FirstOrDefault<bsf>(Enumerable.Where<bsf>(Enumerable.OfType<bsf>(A_1.RaysEmitters), new Func<bsf, bool>(zu.a.a.a))) == null)
		{
			new ah7("wirelessChargingAura", null)
			{
				Layer = aju.x,
				Light = new ae8(new Color(50, 255, 205, 255), 0.225f, LightType.Increment),
				Range = 3f,
				LightFadeRate = 0.07f
			}.g().be(A_1);
		}
	}

	// Token: 0x02001052 RID: 4178
	[CompilerGenerated]
	[Serializable]
	private new sealed class a
	{
		// Token: 0x060056A0 RID: 22176 RVA: 0x0025FBFC File Offset: 0x0025DDFC
		internal bool a(bsf A_0)
		{
			return A_0.Definition != null && A_0.Definition.Name == "wirelessChargingAura";
		}

		// Token: 0x0400231F RID: 8991
		public static readonly zu.a a = new zu.a();

		// Token: 0x04002320 RID: 8992
		public static Func<bsf, bool> b;
	}
}

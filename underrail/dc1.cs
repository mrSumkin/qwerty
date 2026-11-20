using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;
using Ouroboros.Playfield.Lightning;

// Token: 0x02000A5B RID: 2651
[eiz("LRLCJ")]
[Serializable]
public sealed class dc1 : cze, ISerializable
{
	// Token: 0x06003EA6 RID: 16038 RVA: 0x0017A828 File Offset: 0x00178A28
	private dc1(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06003EA7 RID: 16039 RVA: 0x0017A834 File Offset: 0x00178A34
	public dc1()
	{
	}

	// Token: 0x06003EA8 RID: 16040 RVA: 0x0017A840 File Offset: 0x00178A40
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		c5x c5x = A_1 as c5x;
		if (c5x != null && c5x.h.b != null)
		{
			bsf bsf = Enumerable.FirstOrDefault<bsf>(Enumerable.Where<bsf>(Enumerable.OfType<bsf>(c5x.RaysEmitters), new Func<bsf, bool>(dc1.a.a.a)));
			if (c5x.h.b.aa().SpecialStates.a)
			{
				if (bsf != null)
				{
					bsf.ig();
					return;
				}
			}
			else if (bsf == null)
			{
				bsf = new ah7("LemurianServantLight", null)
				{
					Layer = aju.x,
					Light = new ae8(new Color(106, 243, 242), 0.25f, LightType.Increment),
					LightFadeRate = 0.08f,
					Range = 4f
				}.g();
				bsf.be(c5x);
			}
		}
	}

	// Token: 0x02000A5C RID: 2652
	[CompilerGenerated]
	[Serializable]
	private new sealed class a
	{
		// Token: 0x06003EAB RID: 16043 RVA: 0x0017A944 File Offset: 0x00178B44
		internal bool a(bsf A_0)
		{
			return A_0.Definition != null && A_0.Definition.Name == "LemurianServantLight";
		}

		// Token: 0x04001BC0 RID: 7104
		public static readonly dc1.a a = new dc1.a();

		// Token: 0x04001BC1 RID: 7105
		public static Func<bsf, bool> b;
	}
}

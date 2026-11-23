using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;

// Token: 0x02000B74 RID: 2932
[eiz("FOUBRJ")]
[Serializable]
public sealed class ap2 : cze, ISerializable
{
	// Token: 0x0600430E RID: 17166 RVA: 0x001A3100 File Offset: 0x001A1300
	private ap2(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x0600430F RID: 17167 RVA: 0x001A310C File Offset: 0x001A130C
	public ap2()
	{
	}

	// Token: 0x06004310 RID: 17168 RVA: 0x001A3118 File Offset: 0x001A1318
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		c5x c5x = A_0 as c5x;
		if (c5x != null && c5x.p.b != null && c5x.p.b.a.Count >= 2)
		{
			c7j c7j = c5x.s.b as c7j;
			if (c7j != null)
			{
				if (!Enumerable.Any<coh>(c7j.ItemContainer.z2(), new Func<coh, bool>(ap2.a.a.a)))
				{
					c5x.p.b.a[0].b = new Point(2, 0);
					c5x.p.b.a[1].b = new Point(3, 0);
					c5x.RemoveAspect<t6>();
				}
			}
		}
	}

	// Token: 0x02000B75 RID: 2933
	[CompilerGenerated]
	[Serializable]
	private new sealed class a
	{
		// Token: 0x06004313 RID: 17171 RVA: 0x001A320C File Offset: 0x001A140C
		internal bool a(coh A_0)
		{
			return A_0.Definition.a5() == "beastHead";
		}

		// Token: 0x04001C33 RID: 7219
		public static readonly ap2.a a = new ap2.a();

		// Token: 0x04001C34 RID: 7220
		public static Func<coh, bool> b;
	}
}

using System;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;
using Ouroboros.Common.Aspects;

// Token: 0x02000F81 RID: 3969
[eiz("TCHEEA")]
[Serializable]
public sealed class b6v : Aspect<c5x>, c98
{
	// Token: 0x060050BA RID: 20666 RVA: 0x002459C8 File Offset: 0x00243BC8
	private b6v(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x060050BB RID: 20667 RVA: 0x002459D4 File Offset: 0x00243BD4
	public b6v(c5x A_0) : base(A_0)
	{
	}

	// Token: 0x060050BC RID: 20668 RVA: 0x002459E0 File Offset: 0x00243BE0
	public void r7(eds A_0)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		int num = 3;
		int x = num;
		double num2 = 12.5;
		if (serviceOrThrow.aqu() != null && serviceOrThrow.aqu().v() != null && serviceOrThrow.aqu().v().b() != null)
		{
			Vector2 vector = new Vector2(base.a8().Location.X, 200f);
			Vector2 vector2 = serviceOrThrow.aqu().v().b().Location.b();
			double num3 = bnx.a(base.a8().Location.b(), vector, vector2);
			int num4 = 0;
			if (vector2.X > vector.X)
			{
				num4 = 1;
			}
			else if (vector2.X < vector.X)
			{
				num4 = -1;
			}
			int a_ = num + num4 * (int)(num3 / num2);
			x = d05.a(0, a_, 9);
		}
		if (base.a8().o.b != null)
		{
			base.a8().o.b.b = new Point(x, base.a8().o.b.b.Y);
		}
	}
}

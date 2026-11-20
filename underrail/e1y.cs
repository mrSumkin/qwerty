using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;

// Token: 0x02000461 RID: 1121
public sealed class e1y : pd
{
	// Token: 0x06001D2D RID: 7469 RVA: 0x000A1D04 File Offset: 0x0009FF04
	public e1y(string A_0, IEnumerable<c96> A_1 = null) : base(A_0, A_1)
	{
	}

	// Token: 0x06001D2E RID: 7470 RVA: 0x000A1D1C File Offset: 0x0009FF1C
	public e1y(string A_0, bool A_1, IEnumerable<c96> A_2 = null) : base(A_0, A_2)
	{
		this.b = A_1;
	}

	// Token: 0x06001D2F RID: 7471 RVA: 0x000A1D38 File Offset: 0x0009FF38
	public override void mc(TimeSpan A_0, double A_1)
	{
		if (!this.Subject.y6().GetPrimitivePropertyValue<bool>("InheritNextIdleMoveTime", new bool?(false)).Value)
		{
			this.Subject.y6()["NextIdleMoveTime"] = A_0 + TimeSpan.FromMilliseconds((0.5 + cuo.a.NextDouble()) * (double)this.a);
		}
		this.Subject.y6()["InheritNextIdleMoveTime"] = null;
		Vector3 vector = this.Subject.a8().aj();
		Point point = new Point((int)vector.X, (int)vector.Y);
		this.Subject.y6()["IdlingCenter"] = point;
	}

	// Token: 0x06001D30 RID: 7472 RVA: 0x000A1E08 File Offset: 0x000A0008
	public override bool acj(TimeSpan A_0, double A_1)
	{
		return !this.b || this.Subject.y6().GetPrimitivePropertyValue<bool>(ddq.bm, new bool?(false)).Value;
	}

	// Token: 0x04001029 RID: 4137
	public new int a = 1000;

	// Token: 0x0400102A RID: 4138
	public new bool b;
}

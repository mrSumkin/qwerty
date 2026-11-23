using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;

// Token: 0x02000B21 RID: 2849
[eiz("BLO6")]
[Serializable]
public sealed class ene : cze, ISerializable
{
	// Token: 0x060041CB RID: 16843 RVA: 0x00196F68 File Offset: 0x00195168
	private ene(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x060041CC RID: 16844 RVA: 0x00196F74 File Offset: 0x00195174
	public ene()
	{
	}

	// Token: 0x060041CD RID: 16845 RVA: 0x00196F80 File Offset: 0x00195180
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		c5x c5x = A_1 as c5x;
		object obj;
		if (c5x != null && A_2 != null && A_2.TryGetValue("tickCount", out obj) && obj is int)
		{
			int num = (int)obj;
			ak1 ak = c5x.Area.a(c5x.aj().a());
			if (ak != null)
			{
				new e3d(new edx(ak), null, true, true).ym(A_0, A_1, null);
			}
			if (num >= 8)
			{
				c5x.RemoveAspect<dm>();
				if (c5x.p.b != null && c5x.p.b.a.Count >= 2)
				{
					c5x.p.b.a[0].b = new Point(2, 0);
					c5x.p.b.a.RemoveAt(1);
				}
				if (c5x.v.b != null)
				{
					c5x.v.b.a("leak", false);
				}
			}
		}
	}
}

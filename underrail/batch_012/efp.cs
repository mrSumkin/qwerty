using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;

// Token: 0x02000B4A RID: 2890
[eiz("DCSI")]
[Serializable]
public sealed class efp : cze, ISerializable
{
	// Token: 0x0600425B RID: 16987 RVA: 0x0019B6F0 File Offset: 0x001998F0
	private efp(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x0600425C RID: 16988 RVA: 0x0019B6FC File Offset: 0x001998FC
	public efp()
	{
	}

	// Token: 0x0600425D RID: 16989 RVA: 0x0019B708 File Offset: 0x00199908
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		c5x c5x = serviceOrThrow.aqu().v().b() as c5x;
		if (serviceOrThrow.aqu() != null && c5x != null)
		{
			c5x c5x2 = new ar7(new Guid("8226ea09-fd08-46a2-a8fa-892b2808014e"), c5x.Area).ao() as c5x;
			bool value = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("npc_dc_iris_hackedGood", new bool?(false)).Value;
			if (c5x2 != null)
			{
				alv aspect = c5x2.GetAspect<alv>();
				if (aspect != null)
				{
					if (value)
					{
						aspect.a[0].b = new Point(1, 0);
						aspect.a[1].b = new Point(1, 1);
						aspect.a[2].b = new Point(1, 2);
						aspect.a[3].b = new Point(1, 3);
						aspect.a[4].b = new Point(1, 4);
						return;
					}
					aspect.a[0].b = new Point(2, 0);
					aspect.a[1].b = new Point(2, 1);
					aspect.a[2].b = new Point(2, 2);
					aspect.a[3].b = new Point(2, 3);
					aspect.a[4].b = new Point(2, 4);
				}
			}
		}
	}
}

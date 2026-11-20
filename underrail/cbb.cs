using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x02001106 RID: 4358
[eiz("F65")]
[Serializable]
public sealed class cbb : cze, ISerializable
{
	// Token: 0x06005C6F RID: 23663 RVA: 0x0027810C File Offset: 0x0027630C
	private cbb(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetInt32("F65:D");
	}

	// Token: 0x06005C70 RID: 23664 RVA: 0x00278128 File Offset: 0x00276328
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("F65:D", this.a);
	}

	// Token: 0x06005C71 RID: 23665 RVA: 0x00278144 File Offset: 0x00276344
	public cbb(int A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06005C72 RID: 23666 RVA: 0x00278154 File Offset: 0x00276354
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		c5x c5x = A_1 as c5x;
		if (c5x != null && A_2 != null)
		{
			object obj;
			A_2.TryGetValue("tickCount", out obj);
			if (obj is int && (int)obj >= this.a)
			{
				if (c5x.v.b != null)
				{
					c5x.v.b.a("forceField", false);
				}
				qy qy = new qy();
				qy.b(false);
				qy.c(false);
				ad6 ad = new ad6(c5x);
				ad.b(1.0);
				ad.c(0.0);
				ad.a(dz6.a(0.00075));
				qy.ad().Add(ad);
				List<auv> list = qy.ad();
				c7 c = new c7(c5x, false, false, true, false);
				c.a(true);
				list.Add(c);
				c5x.Zone.ActionManager.g9(qy, atp.a);
				dz6.a(qy);
			}
		}
	}

	// Token: 0x040024DB RID: 9435
	private new int a;
}

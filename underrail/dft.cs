using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x020010CC RID: 4300
[eiz("GGTJ")]
[Serializable]
public sealed class dft : cze, ISerializable
{
	// Token: 0x06005A96 RID: 23190 RVA: 0x00271520 File Offset: 0x0026F720
	private dft(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetInt32("GGTJ:D");
	}

	// Token: 0x06005A97 RID: 23191 RVA: 0x0027153C File Offset: 0x0026F73C
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("GGTJ:D", this.a);
	}

	// Token: 0x06005A98 RID: 23192 RVA: 0x00271558 File Offset: 0x0026F758
	public dft(int A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06005A99 RID: 23193 RVA: 0x00271568 File Offset: 0x0026F768
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		c5x c5x = A_1 as c5x;
		if (c5x != null && A_2 != null)
		{
			object obj;
			A_2.TryGetValue("tickCount", out obj);
			if (obj is int && (int)obj >= this.a)
			{
				if (c5x.i.b != null)
				{
					c5x.i.b.a(true, false);
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

	// Token: 0x04002444 RID: 9284
	private new int a;
}

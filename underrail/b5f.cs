using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;

// Token: 0x020010D3 RID: 4307
[eiz("AWDJ")]
[Serializable]
public sealed class b5f : cze, ISerializable
{
	// Token: 0x06005AC8 RID: 23240 RVA: 0x00271D7C File Offset: 0x0026FF7C
	private b5f(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06005AC9 RID: 23241 RVA: 0x00271D88 File Offset: 0x0026FF88
	public b5f()
	{
	}

	// Token: 0x06005ACA RID: 23242 RVA: 0x00271D94 File Offset: 0x0026FF94
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		c5x c5x = A_1 as c5x;
		if (c5x != null)
		{
			ak1 ak = Enumerable.FirstOrDefault<ak1>(c5x.l);
			if (ak != null && !aw1.a(null, ak, false, null))
			{
				a3f aspect = c5x.GetAspect<a3f>();
				if (aspect != null)
				{
					int num = aspect.a().GetPrimitivePropertyValue<int>("Timer", new int?(0)).Value;
					aspect.a()["Timer"] = ++num;
					if (num >= 5)
					{
						aspect.a()["Timer"] = 0;
						crx crx = new crx();
						crx.a(c5x.Area.y8());
						crx.a(bbo.c);
						crx.c().Add(c5x.qe());
						crx.ym(null, c5x, null);
					}
				}
			}
		}
	}
}

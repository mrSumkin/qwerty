using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x020016B9 RID: 5817
[eiz("PUTSA0")]
[Serializable]
public sealed class drr : a6k, ISerializable
{
	// Token: 0x06007EDB RID: 32475 RVA: 0x00359A34 File Offset: 0x00357C34
	private drr(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06007EDC RID: 32476 RVA: 0x00359A40 File Offset: 0x00357C40
	public drr()
	{
	}

	// Token: 0x06007EDD RID: 32477 RVA: 0x00359A48 File Offset: 0x00357C48
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		c5x c5x = base.vg().h() as c5x;
		if (c5x != null)
		{
			HashSet<ak1> hashSet = new HashSet<ak1>();
			foreach (ak1 ak in c5x.l)
			{
				hashSet.Add(ak);
			}
			foreach (ak1 ak2 in aw1.a(c5x, false))
			{
				hashSet.Add(ak2);
			}
			double num = double.MaxValue;
			c5x c5x2 = null;
			foreach (ak1 ak3 in hashSet)
			{
				foreach (b0b b0b in ak3.c.Values)
				{
					c5x c5x3 = (c5x)b0b;
					if (c5x3.s.b != null && c5x3.a("thrownSpear"))
					{
						double num2 = aw1.b(c5x, c5x3);
						if (c5x2 == null || num2 < num)
						{
							c5x2 = c5x3;
							num = num2;
						}
					}
				}
			}
			if (c5x2 != null && c5x2.s.b.a(c5x, null, true, false))
			{
				bmj.a(c5x, new d53("Вы подняли копьё.", adi.h, null, false));
				return dc4.c;
			}
		}
		bmj.a(c5x, new d53("Нет копий поблизости.", adi.l, null, false));
		return dc4.e;
	}
}

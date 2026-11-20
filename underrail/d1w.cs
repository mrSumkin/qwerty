using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x020006DA RID: 1754
[eiz("PJJG")]
[Serializable]
public sealed class d1w : drj, ISerializable
{
	// Token: 0x06002D0E RID: 11534 RVA: 0x001017D4 File Offset: 0x000FF9D4
	private d1w(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06002D0F RID: 11535 RVA: 0x001017E0 File Offset: 0x000FF9E0
	public d1w()
	{
	}

	// Token: 0x06002D10 RID: 11536 RVA: 0x001017E8 File Offset: 0x000FF9E8
	public override bcx x4()
	{
		bcx bcx = new bcx();
		b5o a_ = new b5o("xpbl_JunkJet");
		List<agt> list = new List<agt>();
		List<agt> list2 = new List<agt>();
		List<agt> list3 = new List<agt>();
		List<agt> list4 = new List<agt>();
		List<agt> list5 = new List<agt>();
		agt value = null;
		list.Add(new agt(ez2.CreateDefinitonProvider<eqg>(c8x.a)));
		list.Add(new agt(ez2.CreateDefinitonProvider<eqg>(c8x.d)));
		list2.Add(new agt(ez2.CreateDefinitonProvider<eqg>(c8x.f)));
		list2.Add(new agt(ez2.CreateDefinitonProvider<eqg>(c8x.g)));
		list3.Add(new agt(ez2.CreateDefinitonProvider<esd>(c8x.p)));
		list3.Add(new agt(ez2.CreateDefinitonProvider<esd>(c8x.s)));
		list4.Add(new agt(ez2.CreateDefinitonProvider<esd>(c8x.t)));
		list5.Add(new agt(ez2.CreateDefinitonProvider<esd>(c8x.u)));
		list5.Add(new agt(ez2.CreateDefinitonProvider<esd>(c8x.v)));
		Random random = new Random();
		int num = random.Next(0, 101);
		int num2 = random.Next(0, 101);
		int num3 = random.Next(0, 101);
		agt value2;
		if (num > 30)
		{
			value2 = list[random.Next(0, list.Count)];
		}
		else if (num > 5 && num <= 30)
		{
			value2 = list2[random.Next(0, list2.Count)];
		}
		else
		{
			value2 = new agt(ez2.CreateDefinitonProvider<eqg>(c8x.h));
		}
		agt value3;
		if (num2 > 30)
		{
			value3 = list3[random.Next(0, list3.Count)];
		}
		else if (num > 5 && num <= 30)
		{
			value3 = list4[random.Next(0, list4.Count)];
		}
		else
		{
			value3 = list5[random.Next(0, list5.Count)];
		}
		if (num3 > 97)
		{
			value = new agt(ez2.CreateDefinitonProvider<eu0>(c8x.ag));
		}
		else if (num3 <= 97 && num3 > 90)
		{
			value = new agt(ez2.CreateDefinitonProvider<eu0>(c8x.af));
		}
		else if (num3 <= 90 && num3 > 65)
		{
			value = new agt(ez2.CreateDefinitonProvider<eu0>(c8x.ae));
		}
		bcx.a(a_);
		bcx.o()["engine"] = value2;
		bcx.o()["battery"] = value3;
		bcx.o()["suspension"] = value;
		bcx.k();
		bcx.b((double)bcx.v());
		bcx.a(double.MaxValue);
		bcx.k();
		return bcx;
	}
}

using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x020006D7 RID: 1751
[eiz("PSCJSG")]
[Serializable]
public sealed class b44 : drj, ISerializable
{
	// Token: 0x06002D05 RID: 11525 RVA: 0x00100C6C File Offset: 0x000FEE6C
	private b44(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06002D06 RID: 11526 RVA: 0x00100C78 File Offset: 0x000FEE78
	public b44()
	{
	}

	// Token: 0x06002D07 RID: 11527 RVA: 0x00100C80 File Offset: 0x000FEE80
	public override bcx x4()
	{
		bcx bcx = new bcx();
		b5o a_ = new b5o("xpbl_Scooter");
		List<agt> list = new List<agt>();
		List<agt> list2 = new List<agt>();
		List<agt> list3 = new List<agt>();
		List<agt> list4 = new List<agt>();
		List<agt> list5 = new List<agt>();
		List<agt> list6 = new List<agt>();
		List<agt> list7 = new List<agt>();
		List<agt> list8 = new List<agt>();
		agt value = null;
		list.Add(new agt(ez2.CreateDefinitonProvider<eqg>(c8x.a)));
		list.Add(new agt(ez2.CreateDefinitonProvider<eqg>(c8x.b)));
		list.Add(new agt(ez2.CreateDefinitonProvider<eqg>(c8x.d)));
		list.Add(new agt(ez2.CreateDefinitonProvider<eqg>(c8x.e)));
		list2.Add(new agt(ez2.CreateDefinitonProvider<eqg>(c8x.f)));
		list2.Add(new agt(ez2.CreateDefinitonProvider<eqg>(c8x.g)));
		list3.Add(new agt(ez2.CreateDefinitonProvider<eqg>(c8x.h)));
		list3.Add(new agt(ez2.CreateDefinitonProvider<eqg>(c8x.k)));
		list4.Add(new agt(ez2.CreateDefinitonProvider<esd>(c8x.p)));
		list4.Add(new agt(ez2.CreateDefinitonProvider<esd>(c8x.q)));
		list4.Add(new agt(ez2.CreateDefinitonProvider<esd>(c8x.s)));
		list4.Add(new agt(ez2.CreateDefinitonProvider<esd>(c8x.w)));
		list5.Add(new agt(ez2.CreateDefinitonProvider<esd>(c8x.t)));
		list5.Add(new agt(ez2.CreateDefinitonProvider<esd>(c8x.u)));
		list6.Add(new agt(ez2.CreateDefinitonProvider<esd>(c8x.z)));
		list6.Add(new agt(ez2.CreateDefinitonProvider<esd>(c8x.y)));
		list6.Add(new agt(ez2.CreateDefinitonProvider<esd>(c8x.v)));
		list7.Add(new agt(ez2.CreateDefinitonProvider<eu0>(c8x.ah)));
		list7.Add(new agt(ez2.CreateDefinitonProvider<eu0>(c8x.af)));
		list8.Add(new agt(ez2.CreateDefinitonProvider<eu0>(c8x.ag)));
		list8.Add(new agt(ez2.CreateDefinitonProvider<eu0>(c8x.ai)));
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
			value2 = list3[random.Next(0, list3.Count)];
		}
		agt value3;
		if (num2 > 30)
		{
			value3 = list4[random.Next(0, list4.Count)];
		}
		else if (num > 5 && num <= 30)
		{
			value3 = list5[random.Next(0, list5.Count)];
		}
		else
		{
			value3 = list6[random.Next(0, list6.Count)];
		}
		if (num3 > 98)
		{
			value = list8[random.Next(0, list8.Count)];
		}
		else if (num3 <= 98 && num3 > 90)
		{
			value = list7[random.Next(0, list7.Count)];
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

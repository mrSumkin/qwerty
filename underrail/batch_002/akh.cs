using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using TimelapseVertigo.Generators.Items;

// Token: 0x02000706 RID: 1798
[eiz("WG")]
[Serializable]
public sealed class akh : y8, ISerializable
{
	// Token: 0x06002EAC RID: 11948 RVA: 0x00108624 File Offset: 0x00106824
	private akh(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06002EAD RID: 11949 RVA: 0x00108630 File Offset: 0x00106830
	public akh()
	{
	}

	// Token: 0x06002EAE RID: 11950 RVA: 0x00108638 File Offset: 0x00106838
	protected override List<coh> a2()
	{
		List<coh> list = new List<coh>();
		df8 df = new df8(ItemRange.Weapons);
		base.a(df);
		List<coh> list2 = df.np();
		if (list2 != null)
		{
			list.AddRange(list2);
		}
		return list;
	}

	// Token: 0x06002EAF RID: 11951 RVA: 0x00108670 File Offset: 0x00106870
	public override aw4 a1()
	{
		akh akh = new akh();
		this.rg(akh);
		return akh;
	}

	// Token: 0x040019F8 RID: 6648
	private new const string a = "Weapon Generator";
}

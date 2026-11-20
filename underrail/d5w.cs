using System;
using System.Collections.Generic;

// Token: 0x020014A1 RID: 5281
[d1q("psiBeetleBrainPsi")]
public sealed class d5w : eqz
{
	// Token: 0x060076DA RID: 30426 RVA: 0x00323E74 File Offset: 0x00322074
	public override afq ba()
	{
		List<KeyValuePair<afq, int>> list = new List<KeyValuePair<afq, int>>();
		list.Add(new KeyValuePair<afq, int>(new eye(), 10));
		list.Add(new KeyValuePair<afq, int>(new a74(), 1));
		list.Add(new KeyValuePair<afq, int>(new cdy(), 3));
		list.Add(new KeyValuePair<afq, int>(new c76(), 3));
		list.Add(new KeyValuePair<afq, int>(new d9r(), 2));
		list.Add(new KeyValuePair<afq, int>(new c7h(), 10));
		list.Add(new KeyValuePair<afq, int>(new cm4(), 3));
		list.Add(new KeyValuePair<afq, int>(new d4l(), 2));
		list.Add(new KeyValuePair<afq, int>(new c4h(), 4));
		list.Add(new KeyValuePair<afq, int>(new ege(), 3));
		list.Add(new KeyValuePair<afq, int>(new csw(), 10));
		list.Add(new KeyValuePair<afq, int>(new dg9(), 4));
		list.Add(new KeyValuePair<afq, int>(new ep9(), 1));
		list.Add(new KeyValuePair<afq, int>(new aym(), 5));
		list.Add(new KeyValuePair<afq, int>(new ci9(), 10));
		list.Add(new KeyValuePair<afq, int>(new een(), 2));
		list.Add(new KeyValuePair<afq, int>(new dtm(), 5));
		list.Add(new KeyValuePair<afq, int>(new cdx(), 3));
		list.Add(new KeyValuePair<afq, int>(new epn(), 3));
		List<afq> list2 = new List<afq>();
		foreach (KeyValuePair<afq, int> keyValuePair in list)
		{
			for (int i = 0; i < keyValuePair.Value; i++)
			{
				list2.Add(keyValuePair.Key);
			}
		}
		return list2[cuo.a.Next(list2.Count)];
	}
}

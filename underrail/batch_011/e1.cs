using System;
using System.Diagnostics;

// Token: 0x02002163 RID: 8547
[bmq("1.1.0.12_Pb_MainHallKitchenCabinetsNamesFix", "1.1.0.12", "pb-mainhall", false)]
public sealed class e1 : fg
{
	// Token: 0x0600C912 RID: 51474 RVA: 0x00470BD8 File Offset: 0x0046EDD8
	public bool b5(cyt A_0, c1a A_1)
	{
		try
		{
			c5x c5x = new ar7(new Guid("d113227c-e041-4f51-9144-8b88bd268717"), A_1.n("pb-mainhall")).ao() as c5x;
			c5x c5x2 = new ar7(new Guid("7721a9cb-3921-45da-a398-d9dfd74232dc"), A_1.n("pb-mainhall")).ao() as c5x;
			if (c5x != null && (c5x.y8() == null || c5x.y8() != "Кухонный шкаф"))
			{
				c5x.q("Кухонный шкаф");
			}
			if (c5x2 != null && (c5x2.y8() == null || c5x2.y8() != "Кухонный шкаф"))
			{
				c5x2.q("Кухонный шкаф");
			}
			return true;
		}
		catch (Exception ex)
		{
			Trace.WriteLine(ex.ToString());
		}
		return false;
	}
}

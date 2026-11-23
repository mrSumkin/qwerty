using System;
using Ouroboros.Common.Data;

// Token: 0x0200009F RID: 159
public static class evr
{
	// Token: 0x060003AA RID: 938 RVA: 0x000119C8 File Offset: 0x0000FBC8
	public static bool a(bq8 A_0, Property A_1, bool A_2)
	{
		if (A_0 != null && !string.IsNullOrEmpty(A_1.Name) && A_1.Value != null)
		{
			object obj = A_0.get_Item(A_1.Name);
			try
			{
				double num;
				if (obj == null)
				{
					num = 0.0;
				}
				else
				{
					num = Convert.ToDouble(obj);
				}
				double num2 = Convert.ToDouble(A_1.Value);
				double num3 = (double)(A_2 ? -1 : 1);
				object value = Convert.ChangeType(num + num2 * num3, A_1.Value.GetType());
				A_0.set_Item(A_1.Name, value);
				return true;
			}
			catch
			{
			}
			return false;
		}
		return false;
	}
}

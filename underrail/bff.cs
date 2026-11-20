using System;
using System.Collections.Generic;

// Token: 0x02000C58 RID: 3160
public abstract class bff : jn
{
	// Token: 0x06004705 RID: 18181 RVA: 0x001D5278 File Offset: 0x001D3478
	public override string cc()
	{
		return "xphw";
	}

	// Token: 0x06004706 RID: 18182 RVA: 0x001D5280 File Offset: 0x001D3480
	public override bool cd()
	{
		return true;
	}

	// Token: 0x06004707 RID: 18183 RVA: 0x001D5284 File Offset: 0x001D3484
	public bff(string A_0, string A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06004708 RID: 18184 RVA: 0x001D5290 File Offset: 0x001D3490
	public override string b1(cyt A_0)
	{
		if (this.b(A_0))
		{
			return null;
		}
		return this.c(A_0);
	}

	// Token: 0x06004709 RID: 18185 RVA: 0x001D52A8 File Offset: 0x001D34A8
	protected virtual bool b(cyt A_0)
	{
		return A_0.r().GetPrimitivePropertyValue<bool>("npc_xphw_loc_up_gattler_dead", new bool?(false)).Value;
	}

	// Token: 0x0600470A RID: 18186 RVA: 0x001D52D4 File Offset: 0x001D34D4
	protected virtual string c(cyt A_0)
	{
		List<KeyValuePair<string, int>> list = bff.a(A_0);
		if (list.Count != 0)
		{
			int num = list.Count * 5;
			int num2 = (int)A_0.o().TotalMinutes % num;
			int num3 = 0;
			foreach (KeyValuePair<string, int> keyValuePair in list)
			{
				num3 += 5;
				if (num2 < num3)
				{
					return keyValuePair.Key;
				}
			}
		}
		return null;
	}

	// Token: 0x0600470B RID: 18187 RVA: 0x001D5374 File Offset: 0x001D3574
	protected static List<KeyValuePair<string, int>> a(cyt A_0)
	{
		return new List<KeyValuePair<string, int>>
		{
			new KeyValuePair<string, int>("up2", 1),
			new KeyValuePair<string, int>("up2x", 2),
			new KeyValuePair<string, int>("up3x", 3),
			new KeyValuePair<string, int>("up4", 4)
		};
	}
}

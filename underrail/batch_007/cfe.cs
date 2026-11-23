using System;
using System.Collections.Generic;
using System.Linq;

// Token: 0x02001B5D RID: 7005
public class cfe
{
	// Token: 0x060097B1 RID: 38833 RVA: 0x003B2094 File Offset: 0x003B0294
	public coh a()
	{
		return Enumerable.FirstOrDefault<coh>(this.a);
	}

	// Token: 0x060097B2 RID: 38834 RVA: 0x003B20A4 File Offset: 0x003B02A4
	public bool a(efk A_0)
	{
		bool flag = true;
		if (this.b != null)
		{
			foreach (KeyValuePair<string, int> keyValuePair in this.b)
			{
				try
				{
					flag &= (A_0.Skills.a(keyValuePair.Key).g() >= keyValuePair.Value);
				}
				catch
				{
					flag = false;
				}
			}
		}
		return flag;
	}

	// Token: 0x04003A45 RID: 14917
	public List<coh> a = new List<coh>();

	// Token: 0x04003A46 RID: 14918
	public Dictionary<string, int> b = new Dictionary<string, int>();

	// Token: 0x04003A47 RID: 14919
	public Dictionary<string, coh> c = new Dictionary<string, coh>();

	// Token: 0x04003A48 RID: 14920
	public bool d;

	// Token: 0x04003A49 RID: 14921
	public string e;
}

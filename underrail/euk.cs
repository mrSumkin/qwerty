using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x02000686 RID: 1670
[eiz("MCX")]
[Serializable]
public sealed class euk : ISerializable
{
	// Token: 0x06002AE4 RID: 10980 RVA: 0x000F5444 File Offset: 0x000F3644
	private euk(SerializationInfo A_0, StreamingContext A_1)
	{
		di7.ReadList<string>("MCX:A", ref this.c, A_0);
		di7.ReadList<agn>("MCX:R", ref this.d, A_0);
		this.e = (A_0.GetValue("MCX:T", typeof(agn)) as agn);
		this.f = A_0.GetInt32("MCX:C");
	}

	// Token: 0x06002AE5 RID: 10981 RVA: 0x000F54AC File Offset: 0x000F36AC
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
		di7.WriteList<string>("MCX:A", this.c, info);
		di7.WriteList<agn>("MCX:R", this.d, info);
		info.AddValue("MCX:T", this.e);
		info.AddValue("MCX:C", this.f);
	}

	// Token: 0x06002AE6 RID: 10982 RVA: 0x000F5500 File Offset: 0x000F3700
	public euk()
	{
		this.c = new List<string>();
		for (int i = 0; i < euk.a; i++)
		{
			string item;
			do
			{
				char c = (char)cuo.a.Next(65, 91);
				int num;
				if (cuo.a.NextDouble() < 0.25)
				{
					num = cuo.a.Next(49, 58);
				}
				else
				{
					num = cuo.a.Next(65, 91);
				}
				item = c.ToString() + ((char)num).ToString();
			}
			while (this.c.Contains(item));
			this.c.Add(item);
		}
		this.d = new List<agn>();
		HashSet<agn> hashSet = new HashSet<agn>();
		for (int j = 0; j < euk.b; j++)
		{
			agn agn;
			do
			{
				int num2 = cuo.a.Next(3, 8);
				int num3 = cuo.a.Next(0, 6);
				agn = new agn();
				for (int k = 0; k < num2; k++)
				{
					int num4 = cuo.a.Next(euk.a);
					if (!agn.a.Contains(num4) && !agn.a.Contains(-num4))
					{
						agn.a.Add(num4);
					}
				}
				for (int l = 0; l < num3; l++)
				{
					int num5 = -(1 + cuo.a.Next(euk.a - 1));
					if (!agn.a.Contains(num5) && !agn.a.Contains(-num5))
					{
						agn.a.Add(num5);
					}
				}
			}
			while (agn.a.Count == 0 || hashSet.Contains(agn));
			this.d.Add(agn);
			hashSet.Add(agn);
		}
		do
		{
			this.e = new agn();
			this.f = cuo.a.Next(5, 8);
			for (int m = 0; m < this.f; m++)
			{
				int index = cuo.a.Next(euk.b);
				agn a_ = this.d[index];
				this.e.a(a_);
			}
			this.e.a();
		}
		while (this.e.a.Count < 4 || hashSet.Contains(this.e));
	}

	// Token: 0x04001745 RID: 5957
	public static readonly int a = 20;

	// Token: 0x04001746 RID: 5958
	public static readonly int b = 15;

	// Token: 0x04001747 RID: 5959
	public readonly List<string> c;

	// Token: 0x04001748 RID: 5960
	public readonly List<agn> d;

	// Token: 0x04001749 RID: 5961
	public readonly agn e;

	// Token: 0x0400174A RID: 5962
	public readonly int f;
}

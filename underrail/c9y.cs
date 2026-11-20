using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Ouroboros.Core.Logging;

// Token: 0x0200071B RID: 1819
[eiz("IOS")]
[Serializable]
public sealed class c9y : ISerializable
{
	// Token: 0x06002F46 RID: 12102 RVA: 0x0011E9CC File Offset: 0x0011CBCC
	private c9y(SerializationInfo A_0, StreamingContext A_1)
	{
		if (ell.a() != 0)
		{
			di7.ReadList<xs>("IOS:O", ref this.a, A_0);
			if (ell.a() >= 406)
			{
				this.b = (A_0.GetValue("IOS:BL", typeof(int?)) as int?);
				this.c = (A_0.GetValue("IOS:MD", typeof(int?)) as int?);
				this.d = (A_0.GetValue("IOS:MO", typeof(bool?)) as bool?);
			}
			if (ell.a() >= 427)
			{
				this.e = (A_0.GetValue("IOS:I", typeof(bool?)) as bool?);
				return;
			}
		}
		else
		{
			if (base.GetType() == typeof(c9y))
			{
				this.a = (List<xs>)A_0.GetValue("_Opportunities", typeof(List<xs>));
				return;
			}
			this.a = (List<xs>)A_0.GetValue("ItemOpportunitySet+_Opportunities", typeof(List<xs>));
		}
	}

	// Token: 0x06002F47 RID: 12103 RVA: 0x0011EB14 File Offset: 0x0011CD14
	public void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		di7.WriteList<xs>("IOS:O", this.a, info);
		info.AddValue("IOS:BL", this.b);
		info.AddValue("IOS:MD", this.c);
		info.AddValue("IOS:MO", this.d);
		info.AddValue("IOS:I", this.e);
	}

	// Token: 0x06002F48 RID: 12104 RVA: 0x0011EB8C File Offset: 0x0011CD8C
	public List<xs> g()
	{
		return this.a;
	}

	// Token: 0x06002F49 RID: 12105 RVA: 0x0011EB94 File Offset: 0x0011CD94
	public int? b()
	{
		return this.b;
	}

	// Token: 0x06002F4A RID: 12106 RVA: 0x0011EB9C File Offset: 0x0011CD9C
	public void b(int? A_0)
	{
		this.b = A_0;
	}

	// Token: 0x06002F4B RID: 12107 RVA: 0x0011EBA8 File Offset: 0x0011CDA8
	public int? d()
	{
		return this.c;
	}

	// Token: 0x06002F4C RID: 12108 RVA: 0x0011EBB0 File Offset: 0x0011CDB0
	public void a(int? A_0)
	{
		this.c = A_0;
	}

	// Token: 0x06002F4D RID: 12109 RVA: 0x0011EBBC File Offset: 0x0011CDBC
	public bool? a()
	{
		return this.d;
	}

	// Token: 0x06002F4E RID: 12110 RVA: 0x0011EBC4 File Offset: 0x0011CDC4
	public void b(bool? A_0)
	{
		this.d = A_0;
	}

	// Token: 0x06002F4F RID: 12111 RVA: 0x0011EBD0 File Offset: 0x0011CDD0
	public bool? f()
	{
		return this.e;
	}

	// Token: 0x06002F50 RID: 12112 RVA: 0x0011EBD8 File Offset: 0x0011CDD8
	public void a(bool? A_0)
	{
		this.e = A_0;
	}

	// Token: 0x06002F51 RID: 12113 RVA: 0x0011EBE4 File Offset: 0x0011CDE4
	public c9y()
	{
	}

	// Token: 0x06002F52 RID: 12114 RVA: 0x0011EBFC File Offset: 0x0011CDFC
	public List<bmd> c()
	{
		List<bmd> list = new List<bmd>();
		if (this.a != null)
		{
			Dictionary<int, List<xs>> dictionary = new Dictionary<int, List<xs>>();
			List<xs> list2 = new List<xs>();
			foreach (xs xs in this.a)
			{
				if (xs.SubGroup == 0)
				{
					list2.Add(xs);
				}
				else
				{
					List<xs> list3;
					dictionary.TryGetValue(xs.SubGroup, out list3);
					if (list3 == null)
					{
						list3 = new List<xs>();
						dictionary[xs.SubGroup] = list3;
					}
					list3.Add(xs);
				}
			}
			foreach (xs xs2 in list2)
			{
				List<bmd> list4 = xs2.a(this.b, this.c, this.d, this.e);
				if (list4 != null)
				{
					list.AddRange(list4);
				}
			}
			foreach (KeyValuePair<int, List<xs>> keyValuePair in dictionary)
			{
				List<bmd> list5 = this.a(keyValuePair.Value);
				if (list5 != null)
				{
					list.AddRange(list5);
				}
			}
		}
		return list;
	}

	// Token: 0x06002F53 RID: 12115 RVA: 0x0011ED84 File Offset: 0x0011CF84
	public c9y e()
	{
		c9y c9y = new c9y();
		if (this.a != null)
		{
			foreach (xs xs in this.a)
			{
				c9y.a.Add(xs.g());
			}
		}
		c9y.b = this.b;
		c9y.c = this.c;
		c9y.d = this.d;
		c9y.e = this.e;
		return c9y;
	}

	// Token: 0x06002F54 RID: 12116 RVA: 0x0011EE2C File Offset: 0x0011D02C
	private List<bmd> a(List<xs> A_0)
	{
		float num = 0f;
		double num2 = (double)Enumerable.Sum<xs>(A_0, new Func<xs, float>(c9y.a.a.a));
		float num3 = (float)(zp.a.NextDouble() * num2);
		foreach (xs xs in A_0)
		{
			if (num3 < num + xs.Chance)
			{
				try
				{
					return xs.a(true, this.b, this.c, this.d, this.e);
				}
				catch (Exception a_)
				{
					dux.a(LogSeverity.Error, a_, "Failed to generate item from item opportunity '{0}'.", new object[]
					{
						xs.ToString()
					});
				}
			}
			if (num >= 1f)
			{
				break;
			}
			num += xs.Chance;
		}
		return null;
	}

	// Token: 0x04001A28 RID: 6696
	private List<xs> a = new List<xs>();

	// Token: 0x04001A29 RID: 6697
	private int? b;

	// Token: 0x04001A2A RID: 6698
	private int? c;

	// Token: 0x04001A2B RID: 6699
	private bool? d;

	// Token: 0x04001A2C RID: 6700
	private bool? e;

	// Token: 0x0200071C RID: 1820
	[CompilerGenerated]
	[Serializable]
	private sealed class a
	{
		// Token: 0x06002F57 RID: 12119 RVA: 0x0011EF54 File Offset: 0x0011D154
		internal float a(xs A_0)
		{
			return A_0.Chance;
		}

		// Token: 0x04001A2D RID: 6701
		public static readonly c9y.a a = new c9y.a();

		// Token: 0x04001A2E RID: 6702
		public static Func<xs, float> b;
	}
}

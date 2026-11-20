using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x02000269 RID: 617
[eiz("ADM")]
[Serializable]
public sealed class yc : ISerializable
{
	// Token: 0x06001232 RID: 4658 RVA: 0x0004B098 File Offset: 0x00049298
	private yc(SerializationInfo A_0, StreamingContext A_1)
	{
		if (ell.b() != 0)
		{
			this.a = (bjp[,])A_0.GetValue("ADM:TD", typeof(bjp[,]));
			this.b = (Dictionary<Guid, bf0>)A_0.GetValue("ADM:ED", typeof(Dictionary<Guid, bf0>));
			return;
		}
		di7.ReadDictionary<Guid, bf0>("EntityDiscovery", ref this.b, A_0);
		int @int = A_0.GetInt32("AreaWidth");
		int int2 = A_0.GetInt32("AreaHeight");
		if (@int > 0 && int2 > 0)
		{
			this.a = new bjp[@int, int2];
			for (int i = 0; i < int2; i++)
			{
				for (int j = 0; j < @int; j++)
				{
					this.a[j, i] = (A_0.GetValue(j.ToString() + "," + i.ToString(), typeof(bjp)) as bjp);
				}
			}
		}
	}

	// Token: 0x06001233 RID: 4659 RVA: 0x0004B1A0 File Offset: 0x000493A0
	public void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		info.AddValue("ADM:TD", this.a);
		info.AddValue("ADM:ED", this.b);
	}

	// Token: 0x06001234 RID: 4660 RVA: 0x0004B1C4 File Offset: 0x000493C4
	public yc()
	{
	}

	// Token: 0x06001235 RID: 4661 RVA: 0x0004B1D8 File Offset: 0x000493D8
	public static yc b(aud A_0)
	{
		czh.a(A_0, "area");
		yc yc = new yc();
		yc.a = new bjp[A_0.Size.c, A_0.Size.d];
		for (int i = 0; i < A_0.Size.d; i++)
		{
			for (int j = 0; j < A_0.Size.c; j++)
			{
				yc.a[j, i] = yc.a(A_0.b(j, i));
			}
		}
		foreach (b0b b0b in A_0.Entities)
		{
			yc.b.Add(b0b.qe(), bf0.b(b0b));
		}
		return yc;
	}

	// Token: 0x06001236 RID: 4662 RVA: 0x0004B2C4 File Offset: 0x000494C4
	public static yc a(aud A_0)
	{
		czh.a(A_0, "area");
		yc yc = new yc();
		yc.a = new bjp[A_0.Size.c, A_0.Size.d];
		for (int i = 0; i < A_0.Size.d; i++)
		{
			for (int j = 0; j < A_0.Size.c; j++)
			{
				yc.a[j, i] = A_0.b(j, i).h;
			}
		}
		foreach (b0b b0b in A_0.Entities)
		{
			yc.b[b0b.qe()] = bf0.a(b0b);
		}
		return yc;
	}

	// Token: 0x06001237 RID: 4663 RVA: 0x0004B3B0 File Offset: 0x000495B0
	public void c(aud A_0)
	{
		czh.a(A_0, "area");
		int num = Math.Min(this.a.GetLength(0), A_0.Size.c);
		int num2 = Math.Min(this.a.GetLength(1), A_0.Size.d);
		for (int i = 0; i < num2; i++)
		{
			for (int j = 0; j < num; j++)
			{
				ak1 ak = A_0.b(j, i);
				if (ak != null)
				{
					ak.h = this.a[j, i];
				}
			}
		}
		if (A_0.Entities != null)
		{
			foreach (b0b b0b in A_0.Entities)
			{
				bf0 bf;
				this.b.TryGetValue(b0b.qe(), out bf);
				if (bf != null)
				{
					bf.c(b0b);
				}
			}
		}
	}

	// Token: 0x06001238 RID: 4664 RVA: 0x0004B4BC File Offset: 0x000496BC
	private static bjp a(ak1 A_0)
	{
		bjp h = A_0.h;
		A_0.h = null;
		return h;
	}

	// Token: 0x04000A1A RID: 2586
	public bjp[,] a;

	// Token: 0x04000A1B RID: 2587
	public Dictionary<Guid, bf0> b = new Dictionary<Guid, bf0>();
}

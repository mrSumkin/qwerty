using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x020000D3 RID: 211
[eiz("BCH")]
[Serializable]
public sealed class by1 : IDisposable, ISerializable
{
	// Token: 0x0600049A RID: 1178 RVA: 0x00014AD4 File Offset: 0x00012CD4
	private by1(SerializationInfo A_0, StreamingContext A_1)
	{
		di7.ReadList<b1c>("BCH:S", ref this.d, A_0);
		this.e = A_0.GetInt64("BCH:L");
	}

	// Token: 0x0600049B RID: 1179 RVA: 0x00014B00 File Offset: 0x00012D00
	public void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		di7.WriteList<b1c>("BCH:S", this.d, info);
		info.AddValue("BCH:L", this.e);
	}

	// Token: 0x0600049C RID: 1180 RVA: 0x00014B24 File Offset: 0x00012D24
	public by1()
	{
		this.b = dh4.c(by1.a);
		this.d = new List<b1c>();
		this.d.Add(new b1c(0L, by1.a));
	}

	// Token: 0x0600049D RID: 1181 RVA: 0x00014B60 File Offset: 0x00012D60
	public long a(long A_0)
	{
		for (int i = 0; i < this.d.Count; i++)
		{
			b1c b1c = this.d[i];
			if (b1c.b >= A_0)
			{
				this.d.RemoveAt(i);
				if (b1c.b > A_0)
				{
					b1c item = new b1c(b1c.a + A_0, b1c.b - A_0);
					this.d.Insert(i, item);
				}
				this.a();
				return b1c.a;
			}
		}
		return -1L;
	}

	// Token: 0x0600049E RID: 1182 RVA: 0x00014BEC File Offset: 0x00012DEC
	public void a(long A_0, long A_1)
	{
		b1c item = new b1c(A_0, A_1);
		for (int i = 0; i < this.d.Count; i++)
		{
			if (this.d[i].a >= A_0 + A_1)
			{
				this.d.Insert(i, item);
				this.a();
				return;
			}
		}
		this.d.Add(item);
		this.a();
	}

	// Token: 0x0600049F RID: 1183 RVA: 0x00014C5C File Offset: 0x00012E5C
	private void a()
	{
		for (int i = this.d.Count - 1; i >= 0; i--)
		{
			if (i > 0)
			{
				b1c b1c = this.d[i];
				b1c b1c2 = this.d[i - 1];
				if (b1c2.a + b1c2.b == b1c.a)
				{
					b1c2.b += b1c.b;
					this.d.RemoveAt(i);
				}
			}
		}
		if (this.d.Count > 0)
		{
			this.e = this.d[this.d.Count - 1].a;
			return;
		}
		this.e = 0L;
	}

	// Token: 0x060004A0 RID: 1184 RVA: 0x00014D1C File Offset: 0x00012F1C
	public void Dispose()
	{
		this.a(true);
		GC.SuppressFinalize(this);
	}

	// Token: 0x060004A1 RID: 1185 RVA: 0x00014D2C File Offset: 0x00012F2C
	private void a(bool A_0)
	{
		if (!this.c)
		{
			if (A_0)
			{
				dh4.a(this.b);
			}
			this.c = true;
		}
	}

	// Token: 0x04000450 RID: 1104
	public static readonly long a = 16777216L;

	// Token: 0x04000451 RID: 1105
	[NonSerialized]
	public byte[] b;

	// Token: 0x04000452 RID: 1106
	[NonSerialized]
	private bool c;

	// Token: 0x04000453 RID: 1107
	public List<b1c> d;

	// Token: 0x04000454 RID: 1108
	public long e;
}

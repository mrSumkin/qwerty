using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Runtime.Serialization;

// Token: 0x020000ED RID: 237
[TypeConverter(typeof(bf7))]
[eiz("CS")]
[Serializable]
public class bjp : ICloneable, ISerializable
{
	// Token: 0x0600054D RID: 1357 RVA: 0x000176CC File Offset: 0x000158CC
	protected bjp(SerializationInfo A_0, StreamingContext A_1)
	{
		di7.ReadList<byte>("CS:C", ref this.b, A_0);
		this.c = A_0.GetBoolean("CS:IV");
		this.d = A_0.GetInt64("CS:BM");
	}

	// Token: 0x0600054E RID: 1358 RVA: 0x00017720 File Offset: 0x00015920
	public virtual void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		di7.WriteList<byte>("CS:C", this.b, info);
		info.AddValue("CS:IV", this.c);
		info.AddValue("CS:BM", this.d);
	}

	// Token: 0x0600054F RID: 1359 RVA: 0x00017758 File Offset: 0x00015958
	public static bjp a()
	{
		return bjp.a;
	}

	// Token: 0x06000550 RID: 1360 RVA: 0x00017760 File Offset: 0x00015960
	public long b()
	{
		if (!this.c)
		{
			this.d = bcj.a(this.b);
			this.c = true;
		}
		return this.d;
	}

	// Token: 0x06000551 RID: 1361 RVA: 0x0001778C File Offset: 0x0001598C
	public bjp()
	{
	}

	// Token: 0x06000552 RID: 1362 RVA: 0x000177A0 File Offset: 0x000159A0
	public bjp(long A_0)
	{
		this.a(A_0);
	}

	// Token: 0x06000553 RID: 1363 RVA: 0x000177BC File Offset: 0x000159BC
	public bjp(IEnumerable<byte> A_0)
	{
		this.a(A_0);
	}

	// Token: 0x06000554 RID: 1364 RVA: 0x000177D8 File Offset: 0x000159D8
	public virtual void s3(byte A_0)
	{
		bcj.c(A_0);
		if (!this.b.Contains(A_0))
		{
			this.b.Add(A_0);
			this.c = false;
		}
	}

	// Token: 0x06000555 RID: 1365 RVA: 0x00017808 File Offset: 0x00015A08
	public virtual void c(IEnumerable<byte> A_0)
	{
		czh.a(A_0, "codes");
		foreach (byte a_ in A_0)
		{
			this.s3(a_);
		}
	}

	// Token: 0x06000556 RID: 1366 RVA: 0x00017864 File Offset: 0x00015A64
	public virtual void s4(byte A_0)
	{
		this.c = !this.b.Remove(A_0);
	}

	// Token: 0x06000557 RID: 1367 RVA: 0x0001787C File Offset: 0x00015A7C
	public void b(IEnumerable<byte> A_0)
	{
		czh.a(A_0, "codes");
		foreach (byte a_ in A_0)
		{
			this.s4(a_);
		}
	}

	// Token: 0x06000558 RID: 1368 RVA: 0x000178D8 File Offset: 0x00015AD8
	public bool a(bjp A_0)
	{
		return bcj.b(this.b(), A_0.b());
	}

	// Token: 0x06000559 RID: 1369 RVA: 0x000178EC File Offset: 0x00015AEC
	public bool b(long A_0)
	{
		return bcj.b(this.b(), A_0);
	}

	// Token: 0x0600055A RID: 1370 RVA: 0x000178FC File Offset: 0x00015AFC
	public bool b(bjp A_0)
	{
		return bcj.a(this.b(), A_0.b());
	}

	// Token: 0x0600055B RID: 1371 RVA: 0x00017910 File Offset: 0x00015B10
	public bool c(long A_0)
	{
		return bcj.a(this.b(), A_0);
	}

	// Token: 0x0600055C RID: 1372 RVA: 0x00017920 File Offset: 0x00015B20
	public bool a(byte A_0)
	{
		return this.b.Contains(A_0);
	}

	// Token: 0x0600055D RID: 1373 RVA: 0x00017930 File Offset: 0x00015B30
	public void c()
	{
		this.c = (this.c && this.b.Count == 0);
		this.b.Clear();
	}

	// Token: 0x0600055E RID: 1374 RVA: 0x00017964 File Offset: 0x00015B64
	private void a(IEnumerable<byte> A_0)
	{
		this.b = new List<byte>(A_0);
		this.c = false;
	}

	// Token: 0x0600055F RID: 1375 RVA: 0x0001797C File Offset: 0x00015B7C
	private void a(long A_0)
	{
		this.b.Clear();
		for (byte b = 0; b <= 64; b += 1)
		{
			if (bcj.a(A_0, b))
			{
				this.b.Add(b);
			}
		}
		this.c = false;
	}

	// Token: 0x06000560 RID: 1376 RVA: 0x000179C4 File Offset: 0x00015BC4
	protected virtual object s5()
	{
		return new bjp
		{
			b = new List<byte>(this.b),
			c = false
		};
	}

	// Token: 0x06000561 RID: 1377 RVA: 0x000179E4 File Offset: 0x00015BE4
	public object Clone()
	{
		return this.s5();
	}

	// Token: 0x06000562 RID: 1378 RVA: 0x000179F0 File Offset: 0x00015BF0
	public override string ToString()
	{
		string text = "";
		foreach (byte b in this.b)
		{
			text = text + ((!string.IsNullOrEmpty(text)) ? ", " : "") + b.ToString();
		}
		return text;
	}

	// Token: 0x06000563 RID: 1379 RVA: 0x00017A74 File Offset: 0x00015C74
	public static bjp a(string A_0)
	{
		string[] array = A_0.Split(new char[]
		{
			','
		});
		bjp bjp = new bjp();
		foreach (string s in array)
		{
			try
			{
				byte a_ = byte.Parse(s, CultureInfo.InvariantCulture);
				bjp.s3(a_);
			}
			catch
			{
			}
		}
		return bjp;
	}

	// Token: 0x0400048B RID: 1163
	private static bjp a = new bjp();

	// Token: 0x0400048C RID: 1164
	public List<byte> b = new List<byte>();

	// Token: 0x0400048D RID: 1165
	public bool c;

	// Token: 0x0400048E RID: 1166
	private long d;
}

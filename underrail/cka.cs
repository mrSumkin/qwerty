using System;
using System.IO;
using System.Runtime.Serialization;

// Token: 0x02000660 RID: 1632
[eiz("G31")]
[Serializable]
public sealed class cka : ISerializable
{
	// Token: 0x0600296C RID: 10604 RVA: 0x000EBEC0 File Offset: 0x000EA0C0
	private cka(SerializationInfo A_0, StreamingContext A_1)
	{
		this.a = A_0.GetString("G31:C");
		if (ell.a() < 173)
		{
			this.b = (A_0.GetValue("G31:E", typeof(b0b)) as b0b);
		}
		if (ell.a() >= 133)
		{
			this.c = (A_0.GetValue("G31:L", typeof(bhb)) as bhb);
			this.d = A_0.GetBoolean("G31:D");
		}
		if (ell.a() >= 544)
		{
			this.e = (A_0.GetValue("G31:U", typeof(TimeSpan?)) as TimeSpan?);
		}
	}

	// Token: 0x0600296D RID: 10605 RVA: 0x000EBF88 File Offset: 0x000EA188
	public void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		info.AddValue("G31:C", this.a);
		info.AddValue("G31:L", this.c);
		info.AddValue("G31:D", this.d);
		info.AddValue("G31:U", this.e);
	}

	// Token: 0x0600296E RID: 10606 RVA: 0x000EBFE0 File Offset: 0x000EA1E0
	public string g()
	{
		return this.a;
	}

	// Token: 0x0600296F RID: 10607 RVA: 0x000EBFE8 File Offset: 0x000EA1E8
	public b0b h()
	{
		return this.b;
	}

	// Token: 0x06002970 RID: 10608 RVA: 0x000EBFF0 File Offset: 0x000EA1F0
	public bhb d()
	{
		return this.c;
	}

	// Token: 0x06002971 RID: 10609 RVA: 0x000EBFF8 File Offset: 0x000EA1F8
	public void a(bhb A_0)
	{
		this.c = A_0;
	}

	// Token: 0x06002972 RID: 10610 RVA: 0x000EC004 File Offset: 0x000EA204
	public bool a()
	{
		return this.d;
	}

	// Token: 0x06002973 RID: 10611 RVA: 0x000EC00C File Offset: 0x000EA20C
	public void a(bool A_0)
	{
		this.d = A_0;
	}

	// Token: 0x06002974 RID: 10612 RVA: 0x000EC018 File Offset: 0x000EA218
	public TimeSpan? e()
	{
		return this.e;
	}

	// Token: 0x06002975 RID: 10613 RVA: 0x000EC020 File Offset: 0x000EA220
	public void a(TimeSpan? A_0)
	{
		this.e = A_0;
	}

	// Token: 0x06002976 RID: 10614 RVA: 0x000EC02C File Offset: 0x000EA22C
	public cka(string A_0, b0b A_1 = null)
	{
		this.a = A_0;
		this.b = A_1;
	}

	// Token: 0x06002977 RID: 10615 RVA: 0x000EC044 File Offset: 0x000EA244
	public b0b b()
	{
		if (this.b != null)
		{
			return this.b;
		}
		if (!bmg.a)
		{
			string path = this.a + "." + b0b.a;
			string name = Path.Combine(d5x.y, path).ToLowerInvariant();
			return bmg.b().GetItemUncompressed<b0b>(name, false);
		}
		string text = d5x.l();
		if (!Directory.Exists(text))
		{
			Directory.CreateDirectory(text);
			return null;
		}
		string path2 = this.a + "." + b0b.a;
		return eoq.DeserializeFromBinaryFile<b0b>(Path.Combine(text, path2), dds.a(), true);
	}

	// Token: 0x06002978 RID: 10616 RVA: 0x000EC0E8 File Offset: 0x000EA2E8
	public void a(b0b A_0)
	{
		this.b = null;
		if (A_0 == null)
		{
			this.c();
			return;
		}
		if (bmg.a)
		{
			string text = d5x.l();
			if (!Directory.Exists(text))
			{
				Directory.CreateDirectory(text);
			}
			string path = this.a + "." + b0b.a;
			eoq.SerializeToBinaryFile<b0b>(Path.Combine(text, path), A_0, dds.a(), eh9.c, true);
			return;
		}
		string path2 = this.a + "." + b0b.a;
		string name = Path.Combine(d5x.y, path2).ToLowerInvariant();
		bmg.b().PutItemUncompressed<b0b>(name, A_0, true);
	}

	// Token: 0x06002979 RID: 10617 RVA: 0x000EC190 File Offset: 0x000EA390
	public void c()
	{
		this.b = null;
		if (bmg.a)
		{
			string text = d5x.l();
			if (!Directory.Exists(text))
			{
				string path = this.a + "." + b0b.a;
				string text2 = Path.Combine(text, path);
				if (File.Exists(text2))
				{
					File.Delete(text2);
					return;
				}
			}
		}
		else
		{
			string path2 = this.a + "." + b0b.a;
			string a_ = Path.Combine(d5x.y, path2).ToLowerInvariant();
			bmg.b().e(a_);
		}
	}

	// Token: 0x0600297A RID: 10618 RVA: 0x000EC224 File Offset: 0x000EA424
	public void f()
	{
		if (this.b != null)
		{
			this.a(this.b);
		}
	}

	// Token: 0x04001699 RID: 5785
	private string a;

	// Token: 0x0400169A RID: 5786
	private b0b b;

	// Token: 0x0400169B RID: 5787
	private bhb c;

	// Token: 0x0400169C RID: 5788
	private bool d;

	// Token: 0x0400169D RID: 5789
	private TimeSpan? e;
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

// Token: 0x02001DDD RID: 7645
[eiz("CS4")]
[DefaultMember("Item")]
[Serializable]
public sealed class cyr : a9q, IEnumerable<aia>, ISerializable
{
	// Token: 0x0600A921 RID: 43297 RVA: 0x003EFE04 File Offset: 0x003EE004
	private cyr(SerializationInfo A_0, StreamingContext A_1)
	{
		if (ell.a() != 0)
		{
			this.a = A_0.GetString("CS4:N");
			this.b = (SortedList<aia, aia>)A_0.GetValue("CS4:SL", typeof(SortedList<aia, aia>));
			return;
		}
		if (base.GetType() == typeof(cyr))
		{
			this.a = A_0.GetString("_Name");
			this.b = (SortedList<aia, aia>)A_0.GetValue("_SortedList", typeof(SortedList<aia, aia>));
			return;
		}
		this.a = A_0.GetString("CapabilitySet+_Name");
		this.b = (SortedList<aia, aia>)A_0.GetValue("CapabilitySet+_SortedList", typeof(SortedList<aia, aia>));
	}

	// Token: 0x0600A922 RID: 43298 RVA: 0x003EFEE0 File Offset: 0x003EE0E0
	public void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		info.AddValue("CS4:N", this.a);
		info.AddValue("CS4:SL", this.b);
	}

	// Token: 0x0600A923 RID: 43299 RVA: 0x003EFF04 File Offset: 0x003EE104
	public int a()
	{
		return this.b.Count;
	}

	// Token: 0x0600A924 RID: 43300 RVA: 0x003EFF14 File Offset: 0x003EE114
	public string y8()
	{
		return this.a;
	}

	// Token: 0x0600A925 RID: 43301 RVA: 0x003EFF1C File Offset: 0x003EE11C
	public c3n a(int A_0)
	{
		return this.b.Values[A_0].Value;
	}

	// Token: 0x0600A926 RID: 43302 RVA: 0x003EFF34 File Offset: 0x003EE134
	public cyr(string A_0)
	{
		this.a = A_0;
	}

	// Token: 0x0600A927 RID: 43303 RVA: 0x003EFF54 File Offset: 0x003EE154
	public bool b(c3n A_0)
	{
		if (A_0 == null)
		{
			return false;
		}
		if (!this.c(A_0))
		{
			aia aia = A_0.e();
			this.b.Add(aia, aia);
			return true;
		}
		return false;
	}

	// Token: 0x0600A928 RID: 43304 RVA: 0x003EFF8C File Offset: 0x003EE18C
	public bool a(c3n A_0)
	{
		if (A_0 == null)
		{
			return false;
		}
		for (int i = 0; i < this.b.Count; i++)
		{
			if (this.b.Keys[i].Value == A_0)
			{
				this.b.RemoveAt(i);
				return true;
			}
		}
		return false;
	}

	// Token: 0x0600A929 RID: 43305 RVA: 0x003EFFE8 File Offset: 0x003EE1E8
	public bool c(c3n A_0)
	{
		cyr.b b = new cyr.b();
		b.a = A_0;
		return b.a != null && Enumerable.Any<aia>(this.b.Values, new Func<aia, bool>(b.a));
	}

	// Token: 0x0600A92A RID: 43306 RVA: 0x003F002C File Offset: 0x003EE22C
	public bool a(Type A_0)
	{
		cyr.a a = new cyr.a();
		a.a = A_0;
		return Enumerable.Any<aia>(this.b.Values, new Func<aia, bool>(a.a));
	}

	// Token: 0x0600A92B RID: 43307 RVA: 0x003F0064 File Offset: 0x003EE264
	public void b()
	{
		this.b.Clear();
	}

	// Token: 0x0600A92C RID: 43308 RVA: 0x003F0074 File Offset: 0x003EE274
	public IEnumerator<aia> GetEnumerator()
	{
		return this.b.Values.GetEnumerator();
	}

	// Token: 0x0600A92D RID: 43309 RVA: 0x003F0088 File Offset: 0x003EE288
	IEnumerator IEnumerable.c()
	{
		return this.b.GetEnumerator();
	}

	// Token: 0x04003F3D RID: 16189
	private string a;

	// Token: 0x04003F3E RID: 16190
	private SortedList<aia, aia> b = new SortedList<aia, aia>(lc.a());

	// Token: 0x02001DDF RID: 7647
	[CompilerGenerated]
	private sealed class b
	{
		// Token: 0x0600A93D RID: 43325 RVA: 0x003F021C File Offset: 0x003EE41C
		internal bool a(aia A_0)
		{
			return A_0.Value == this.a;
		}

		// Token: 0x04003F42 RID: 16194
		public c3n a;
	}

	// Token: 0x02001DE0 RID: 7648
	[CompilerGenerated]
	private sealed class a
	{
		// Token: 0x0600A93F RID: 43327 RVA: 0x003F0234 File Offset: 0x003EE434
		internal bool a(aia A_0)
		{
			return A_0.Value != null && A_0.Value.GetType() == this.a;
		}

		// Token: 0x04003F43 RID: 16195
		public Type a;
	}
}

using System;
using System.Runtime.Serialization;

// Token: 0x02001DD5 RID: 7637
[eiz("SNF")]
[Serializable]
public sealed class f : ISerializable
{
	// Token: 0x0600A8F6 RID: 43254 RVA: 0x003EF2E8 File Offset: 0x003ED4E8
	private f(SerializationInfo A_0, StreamingContext A_1)
	{
		this.a = A_0.GetInt32("SNF:V");
		this.b = A_0.GetInt32("SNF:M");
	}

	// Token: 0x0600A8F7 RID: 43255 RVA: 0x003EF314 File Offset: 0x003ED514
	public void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		info.AddValue("SNF:V", this.a);
		info.AddValue("SNF:M", this.b);
	}

	// Token: 0x170002A0 RID: 672
	// (get) Token: 0x0600A8F8 RID: 43256 RVA: 0x003EF338 File Offset: 0x003ED538
	// (set) Token: 0x0600A8F9 RID: 43257 RVA: 0x003EF340 File Offset: 0x003ED540
	public int Value
	{
		get
		{
			return this.a;
		}
		set
		{
			this.a = value;
		}
	}

	// Token: 0x170002A1 RID: 673
	// (get) Token: 0x0600A8FA RID: 43258 RVA: 0x003EF34C File Offset: 0x003ED54C
	// (set) Token: 0x0600A8FB RID: 43259 RVA: 0x003EF354 File Offset: 0x003ED554
	public int ModifiedValue
	{
		get
		{
			return this.b;
		}
		set
		{
			this.b = value;
		}
	}

	// Token: 0x0600A8FC RID: 43260 RVA: 0x003EF360 File Offset: 0x003ED560
	public f()
	{
	}

	// Token: 0x0600A8FD RID: 43261 RVA: 0x003EF368 File Offset: 0x003ED568
	public void b()
	{
		this.b = this.a;
	}

	// Token: 0x0600A8FE RID: 43262 RVA: 0x003EF378 File Offset: 0x003ED578
	public f a()
	{
		return new f
		{
			a = this.a,
			b = this.b
		};
	}

	// Token: 0x04003F2D RID: 16173
	private int a;

	// Token: 0x04003F2E RID: 16174
	private int b;
}

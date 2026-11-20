using System;
using System.ComponentModel;
using System.Runtime.Serialization;
using System.Xml.Serialization;

// Token: 0x02001DDE RID: 7646
[eiz("CR")]
[TypeConverter(typeof(bf7))]
[Serializable]
public sealed class aia : ISerializable
{
	// Token: 0x0600A92E RID: 43310 RVA: 0x003F0098 File Offset: 0x003EE298
	private aia(SerializationInfo A_0, StreamingContext A_1)
	{
		if (ell.a() != 0)
		{
			this.a = A_0.GetString("CR:CFTN");
			return;
		}
		if (base.GetType() == typeof(aia))
		{
			this.a = A_0.GetString("_CapabilityFullTypeName");
			return;
		}
		this.a = A_0.GetString("CapabilityReference+_CapabilityFullTypeName");
	}

	// Token: 0x0600A92F RID: 43311 RVA: 0x003F0104 File Offset: 0x003EE304
	public void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		info.AddValue("CR:CFTN", this.a);
	}

	// Token: 0x170002A4 RID: 676
	// (get) Token: 0x0600A930 RID: 43312 RVA: 0x003F0118 File Offset: 0x003EE318
	// (set) Token: 0x0600A931 RID: 43313 RVA: 0x003F0120 File Offset: 0x003EE320
	public string CapabilityFullTypeName
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

	// Token: 0x170002A5 RID: 677
	// (get) Token: 0x0600A932 RID: 43314 RVA: 0x003F012C File Offset: 0x003EE32C
	// (set) Token: 0x0600A933 RID: 43315 RVA: 0x003F0154 File Offset: 0x003EE354
	[XmlIgnore]
	[Browsable(false)]
	public c3n Value
	{
		get
		{
			if (!this.c)
			{
				this.b = this.a();
				this.c = true;
			}
			return this.b;
		}
		set
		{
			this.b = value;
			this.c = true;
		}
	}

	// Token: 0x0600A934 RID: 43316 RVA: 0x003F0164 File Offset: 0x003EE364
	public aia()
	{
	}

	// Token: 0x0600A935 RID: 43317 RVA: 0x003F016C File Offset: 0x003EE36C
	public aia(Type A_0)
	{
		czh.a(A_0, "capabilityType");
		this.a = dgk.b(A_0);
	}

	// Token: 0x0600A936 RID: 43318 RVA: 0x003F018C File Offset: 0x003EE38C
	public aia(string A_0)
	{
		czh.a(A_0, "capabilityName");
		this.a = A_0;
	}

	// Token: 0x0600A937 RID: 43319 RVA: 0x003F01A8 File Offset: 0x003EE3A8
	public aia(c3n A_0)
	{
		czh.a(A_0, "capability");
		this.a = dgk.b(A_0.GetType());
		this.Value = A_0;
	}

	// Token: 0x0600A938 RID: 43320 RVA: 0x003F01D4 File Offset: 0x003EE3D4
	private c3n a()
	{
		return dgk.a(this.a);
	}

	// Token: 0x0600A939 RID: 43321 RVA: 0x003F01E4 File Offset: 0x003EE3E4
	public aia b()
	{
		return new aia(this.a);
	}

	// Token: 0x0600A93A RID: 43322 RVA: 0x003F01F4 File Offset: 0x003EE3F4
	public override string ToString()
	{
		return this.a;
	}

	// Token: 0x0600A93B RID: 43323 RVA: 0x003F01FC File Offset: 0x003EE3FC
	public static aia a(string A_0)
	{
		if (!string.IsNullOrEmpty(A_0))
		{
			return new aia(A_0);
		}
		return null;
	}

	// Token: 0x04003F3F RID: 16191
	private string a;

	// Token: 0x04003F40 RID: 16192
	[NonSerialized]
	private c3n b;

	// Token: 0x04003F41 RID: 16193
	[NonSerialized]
	private bool c;
}

using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x02000A60 RID: 2656
[eiz("MPMRRMJ")]
[Serializable]
public class chu : cze, ISerializable
{
	// Token: 0x06003EBB RID: 16059 RVA: 0x0017B0D8 File Offset: 0x001792D8
	private chu(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetString("MPMRRMJ:I");
		this.b = A_0.GetSingle("MPMRRMJ:M");
	}

	// Token: 0x06003EBC RID: 16060 RVA: 0x0017B104 File Offset: 0x00179304
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("MPMRRMJ:I", this.a);
		info.AddValue("MPMRRMJ:M", this.b);
	}

	// Token: 0x06003EBD RID: 16061 RVA: 0x0017B130 File Offset: 0x00179330
	public string b()
	{
		return this.a;
	}

	// Token: 0x06003EBE RID: 16062 RVA: 0x0017B138 File Offset: 0x00179338
	public void a(string A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06003EBF RID: 16063 RVA: 0x0017B144 File Offset: 0x00179344
	public float a()
	{
		return this.b;
	}

	// Token: 0x06003EC0 RID: 16064 RVA: 0x0017B14C File Offset: 0x0017934C
	public void a(float A_0)
	{
		this.b = A_0;
	}

	// Token: 0x06003EC1 RID: 16065 RVA: 0x0017B158 File Offset: 0x00179358
	public chu()
	{
	}

	// Token: 0x06003EC2 RID: 16066 RVA: 0x0017B164 File Offset: 0x00179364
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null)
		{
			string name = bp5.j(this.a);
			float num = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<float>(name, null).Value;
			num += this.b;
			serviceOrThrow.aqu().r()[name] = num;
		}
	}

	// Token: 0x04001BC6 RID: 7110
	private new string a;

	// Token: 0x04001BC7 RID: 7111
	private float b;
}

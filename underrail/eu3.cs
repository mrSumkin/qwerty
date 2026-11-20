using System;
using System.Runtime.Serialization;

// Token: 0x02001960 RID: 6496
[eiz("GCM")]
[Serializable]
public sealed class eu3 : ISerializable
{
	// Token: 0x06008ADE RID: 35550 RVA: 0x0038E040 File Offset: 0x0038C240
	private eu3(SerializationInfo A_0, StreamingContext A_1)
	{
		if (ell.a() != 0)
		{
			this.a = A_0.GetString("GCM:N");
			this.b = A_0.GetInt32("GCM:BV");
			this.c = A_0.GetSingle("GCM:I");
			return;
		}
		if (base.GetType() == typeof(eu3))
		{
			this.a = A_0.GetString("_Name");
			this.b = A_0.GetInt32("_BaseValue");
			this.c = A_0.GetSingle("_Increase");
			return;
		}
		this.a = A_0.GetString("GenericComponentModifier+_Name");
		this.b = A_0.GetInt32("GenericComponentModifier+_BaseValue");
		this.c = A_0.GetSingle("GenericComponentModifier+_Increase");
	}

	// Token: 0x06008ADF RID: 35551 RVA: 0x0038E114 File Offset: 0x0038C314
	public void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		info.AddValue("GCM:N", this.a);
		info.AddValue("GCM:BV", this.b);
		info.AddValue("GCM:I", this.c);
	}

	// Token: 0x06008AE0 RID: 35552 RVA: 0x0038E14C File Offset: 0x0038C34C
	public string c()
	{
		return this.a;
	}

	// Token: 0x06008AE1 RID: 35553 RVA: 0x0038E154 File Offset: 0x0038C354
	public void a(string A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06008AE2 RID: 35554 RVA: 0x0038E160 File Offset: 0x0038C360
	public int a()
	{
		return this.b;
	}

	// Token: 0x06008AE3 RID: 35555 RVA: 0x0038E168 File Offset: 0x0038C368
	public void a(int A_0)
	{
		this.b = A_0;
	}

	// Token: 0x06008AE4 RID: 35556 RVA: 0x0038E174 File Offset: 0x0038C374
	public float b()
	{
		return this.c;
	}

	// Token: 0x06008AE5 RID: 35557 RVA: 0x0038E17C File Offset: 0x0038C37C
	public void a(float A_0)
	{
		this.c = A_0;
	}

	// Token: 0x06008AE6 RID: 35558 RVA: 0x0038E188 File Offset: 0x0038C388
	public eu3()
	{
	}

	// Token: 0x06008AE7 RID: 35559 RVA: 0x0038E190 File Offset: 0x0038C390
	public eu3(string A_0, int A_1, float A_2)
	{
		this.a = A_0;
		this.b = A_1;
		this.c = A_2;
	}

	// Token: 0x0400377F RID: 14207
	private string a;

	// Token: 0x04003780 RID: 14208
	private int b;

	// Token: 0x04003781 RID: 14209
	private float c;
}

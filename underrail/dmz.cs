using System;
using System.Runtime.Serialization;

// Token: 0x020011B2 RID: 4530
[eiz("PSC")]
[Serializable]
public sealed class dmz : ISerializable
{
	// Token: 0x0600607F RID: 24703 RVA: 0x002A2D58 File Offset: 0x002A0F58
	private dmz(SerializationInfo A_0, StreamingContext A_1)
	{
		this.a = A_0.GetString("PSC:C");
		this.b = (Guid)A_0.GetValue("PSC:L", typeof(Guid));
	}

	// Token: 0x06006080 RID: 24704 RVA: 0x002A2D9C File Offset: 0x002A0F9C
	public void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		info.AddValue("PSC:C", this.a);
		info.AddValue("PSC:L", this.b);
	}

	// Token: 0x06006081 RID: 24705 RVA: 0x002A2DC8 File Offset: 0x002A0FC8
	public string a()
	{
		return this.a;
	}

	// Token: 0x06006082 RID: 24706 RVA: 0x002A2DD0 File Offset: 0x002A0FD0
	public void a(string A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06006083 RID: 24707 RVA: 0x002A2DDC File Offset: 0x002A0FDC
	public Guid b()
	{
		return this.b;
	}

	// Token: 0x06006084 RID: 24708 RVA: 0x002A2DE4 File Offset: 0x002A0FE4
	public void a(Guid A_0)
	{
		this.b = A_0;
	}

	// Token: 0x06006085 RID: 24709 RVA: 0x002A2DF0 File Offset: 0x002A0FF0
	public dmz()
	{
	}

	// Token: 0x0400291D RID: 10525
	private string a;

	// Token: 0x0400291E RID: 10526
	private Guid b;
}

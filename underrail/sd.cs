using System;
using System.Runtime.Serialization;

// Token: 0x020011DB RID: 4571
[eiz("SHWT")]
[Serializable]
public sealed class sd : ya, ISerializable
{
	// Token: 0x06006208 RID: 25096 RVA: 0x002A7BC8 File Offset: 0x002A5DC8
	private sd(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetDouble("SHWT:E");
		this.b = A_0.GetString("SHWT:C");
	}

	// Token: 0x06006209 RID: 25097 RVA: 0x002A7C04 File Offset: 0x002A5E04
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("SHWT:E", this.a);
		info.AddValue("SHWT:C", this.b);
	}

	// Token: 0x0600620A RID: 25098 RVA: 0x002A7C30 File Offset: 0x002A5E30
	public double a()
	{
		return this.a;
	}

	// Token: 0x0600620B RID: 25099 RVA: 0x002A7C38 File Offset: 0x002A5E38
	public void a(double A_0)
	{
		this.a = A_0;
	}

	// Token: 0x0600620C RID: 25100 RVA: 0x002A7C44 File Offset: 0x002A5E44
	public string b()
	{
		return this.b;
	}

	// Token: 0x0600620D RID: 25101 RVA: 0x002A7C4C File Offset: 0x002A5E4C
	public void a(string A_0)
	{
		this.b = A_0;
	}

	// Token: 0x0600620E RID: 25102 RVA: 0x002A7C58 File Offset: 0x002A5E58
	public sd()
	{
	}

	// Token: 0x04002995 RID: 10645
	private double a = 1.0;

	// Token: 0x04002996 RID: 10646
	private string b;
}

using System;
using System.Runtime.Serialization;
using Ouroboros.Common.Aspects;

// Token: 0x02001281 RID: 4737
[eiz("PRGEA")]
[Serializable]
public sealed class bhk : Aspect<c5x>, ISerializable
{
	// Token: 0x060066E5 RID: 26341 RVA: 0x002BB570 File Offset: 0x002B9770
	private bhk(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = (A_0.GetValue("PRGEA:C", typeof(dth)) as dth);
		this.b = A_0.GetBoolean("PRGEA:D");
	}

	// Token: 0x060066E6 RID: 26342 RVA: 0x002BB5AC File Offset: 0x002B97AC
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("PRGEA:C", this.a);
		info.AddValue("PRGEA:D", this.b);
	}

	// Token: 0x060066E7 RID: 26343 RVA: 0x002BB5D8 File Offset: 0x002B97D8
	public dth b()
	{
		return this.a;
	}

	// Token: 0x060066E8 RID: 26344 RVA: 0x002BB5E0 File Offset: 0x002B97E0
	public void a(dth A_0)
	{
		this.a = A_0;
	}

	// Token: 0x060066E9 RID: 26345 RVA: 0x002BB5EC File Offset: 0x002B97EC
	public bool a()
	{
		return this.b;
	}

	// Token: 0x060066EA RID: 26346 RVA: 0x002BB5F4 File Offset: 0x002B97F4
	public void a(bool A_0)
	{
		this.b = A_0;
	}

	// Token: 0x060066EB RID: 26347 RVA: 0x002BB600 File Offset: 0x002B9800
	public bhk(c5x A_0) : base(A_0)
	{
	}

	// Token: 0x04002AA8 RID: 10920
	private dth a;

	// Token: 0x04002AA9 RID: 10921
	private bool b;
}

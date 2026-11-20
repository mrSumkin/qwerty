using System;
using System.Runtime.Serialization;
using Ouroboros.Common.Aspects;

// Token: 0x020012E1 RID: 4833
[eiz("G33")]
[Serializable]
public sealed class dqv : Aspect<c5x>, ISerializable
{
	// Token: 0x06006B14 RID: 27412 RVA: 0x002D0A28 File Offset: 0x002CEC28
	private dqv(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetString("G33:C");
	}

	// Token: 0x06006B15 RID: 27413 RVA: 0x002D0A44 File Offset: 0x002CEC44
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("G33:C", this.a);
	}

	// Token: 0x06006B16 RID: 27414 RVA: 0x002D0A60 File Offset: 0x002CEC60
	public string a()
	{
		return this.a;
	}

	// Token: 0x06006B17 RID: 27415 RVA: 0x002D0A68 File Offset: 0x002CEC68
	public void a(string A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06006B18 RID: 27416 RVA: 0x002D0A74 File Offset: 0x002CEC74
	public dqv(c5x A_0) : base(A_0)
	{
	}

	// Token: 0x04002BFB RID: 11259
	private string a;
}

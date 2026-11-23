using System;
using System.Runtime.Serialization;
using Ouroboros.Common.Aspects;

// Token: 0x020012D6 RID: 4822
[eiz("III")]
[Serializable]
public sealed class bpu : Aspect<c5x>, ISerializable, c02
{
	// Token: 0x06006AA5 RID: 27301 RVA: 0x002CEB6C File Offset: 0x002CCD6C
	private bpu(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.b = A_0.GetSingle("III:S");
		this.a = A_0.GetSingle("III:X");
	}

	// Token: 0x06006AA6 RID: 27302 RVA: 0x002CEBBC File Offset: 0x002CCDBC
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("III:S", this.b);
		info.AddValue("III:X", this.a);
	}

	// Token: 0x06006AA7 RID: 27303 RVA: 0x002CEBE8 File Offset: 0x002CCDE8
	public float h9()
	{
		return this.a;
	}

	// Token: 0x06006AA8 RID: 27304 RVA: 0x002CEBF0 File Offset: 0x002CCDF0
	public void b(float A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06006AA9 RID: 27305 RVA: 0x002CEBFC File Offset: 0x002CCDFC
	public float ia()
	{
		return this.b;
	}

	// Token: 0x06006AAA RID: 27306 RVA: 0x002CEC04 File Offset: 0x002CCE04
	public void a(float A_0)
	{
		this.b = A_0;
	}

	// Token: 0x06006AAB RID: 27307 RVA: 0x002CEC10 File Offset: 0x002CCE10
	public bpu(c5x A_0) : base(A_0)
	{
	}

	// Token: 0x04002BCB RID: 11211
	private float a = aju.d;

	// Token: 0x04002BCC RID: 11212
	private float b = aju.c;
}
